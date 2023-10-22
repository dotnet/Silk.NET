using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SilkTouchX.Clang;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace SilkTouchX.Mods;

/// <summary>
/// Adds VTables to allow multiple points of entry into the native library.
/// </summary>
[ModConfiguration<Configuration>]
public class AddVTables(IOptionsSnapshot<AddVTables.Configuration> config) : IMod
{
    /// <summary>
    /// Base class for VTable configurations.
    /// </summary>
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "Kind")]
    [JsonDerivedType(typeof(DllImport), nameof(DllImport))]
    [JsonDerivedType(typeof(ThreadLocal), nameof(ThreadLocal))]
    [JsonDerivedType(typeof(StaticWrapper), nameof(StaticWrapper))]
    public abstract record VTable
    {
        /// <summary>
        /// If <see cref="IsStatic"/> is true, is this the static default? If <see cref="IsStatic"/> is false, should
        /// this be the default for <see cref="ThreadLocal"/> (unless overridden?).
        /// </summary>
        public bool IsDefault { get; init; }

        /// <summary>
        /// The name of the override.
        /// </summary>
        public abstract string Name { get; init; }

        /// <summary>
        /// True if this type represents the configuration for a static VTable, false otherwise.
        /// </summary>
        public abstract bool IsStatic { get; }

        /// <summary>
        /// Gets the "boilerplate" partial required for this VTable.
        /// </summary>
        /// <returns>The VTable class declaration</returns>
        public virtual ClassDeclarationSyntax? GetBoilerplate() => null;

        /// <summary>
        /// Gets a class declaration for the VTable with the method contained in the context added.
        /// </summary>
        /// <returns>The VTable class declaration</returns>
        public abstract ClassDeclarationSyntax AddMethod(in VTableContext ctx);
    }

    /// <summary>
    /// Contains information used by <see cref="VTable"/>s to construct their implementations.
    /// </summary>
    /// <param name="CurrentPartial">
    /// The previous output of the <see cref="VTable"/> for this compilation unit, or <c>null</c> if this is the first
    /// time it's being executed for this compilation unit.
    /// </param>
    /// <param name="Original">
    /// The original (likely <see cref="System.Runtime.InteropServices.DllImportAttribute"/> marked) function.
    /// </param>
    /// <param name="LibraryName">The library name from the native function attribute.</param>
    /// <param name="EntryPoint">
    /// The entry point from the native function attribute (or the method name if an explicit entry point wasn't
    /// present).
    /// </param>
    /// <param name="StaticDecl">The declaration used in the static VTable interface.</param>
    /// <param name="InstanceDecl">The declaration used in the instance VTable interface.</param>
    /// <param name="ClassName">The class name.</param>
    public readonly record struct VTableContext(
        ClassDeclarationSyntax? CurrentPartial,
        MethodDeclarationSyntax Original,
        string LibraryName,
        string EntryPoint,
        MethodDeclarationSyntax StaticDecl,
        MethodDeclarationSyntax InstanceDecl,
        string ClassName
    );

    /// <summary>
    /// Configuration for the DllImport-based static VTable.
    /// </summary>
    public record DllImport : VTable
    {
        /// <summary>
        /// Mapping of DllImport library names to per-runtime-identifier library names.
        /// </summary>
        public Dictionary<string, Dictionary<string, string[]>>? LibraryNames { get; init; }

        /// <inheritdoc />
        public override string Name { get; init; } = nameof(DllImport);

        /// <inheritdoc />
        public override bool IsStatic => true;

        /// <inheritdoc />
        public override ClassDeclarationSyntax AddMethod(in VTableContext ctx) =>
            (
                ctx.CurrentPartial
                ?? ClassDeclaration(Name)
                    .WithModifiers(
                        TokenList(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.PartialKeyword))
                    )
                    .WithBaseList(
                        BaseList(
                            SingletonSeparatedList<BaseTypeSyntax>(
                                SimpleBaseType(IdentifierName($"I{ctx.ClassName}.Static"))
                            )
                        )
                    )
            ).AddMembers(ctx.Original);
    }

    /// <summary>
    /// Configuration for the static VTable wrapping a ThreadLocal instance VTable.
    /// </summary>
    public record ThreadLocal : VTable
    {
        /// <summary>
        /// Should we generate a <c>partial</c> method representing the factory? If false, and we can't determine our
        /// own sensible default, threads will have no default value.
        /// </summary>
        public bool GenerateFactoryPartial { get; init; } = false;

        /// <inheritdoc />
        public override string Name { get; init; } = nameof(ThreadLocal);

        /// <inheritdoc />
        public override bool IsStatic => true;

        /// <inheritdoc />
        public override ClassDeclarationSyntax AddMethod(in VTableContext ctx) =>
            throw new NotImplementedException();
    }

    /// <summary>
    /// Configuration for the instance VTable wrapping a static VTable.
    /// </summary>
    public record StaticWrapper : VTable
    {
        /// <inheritdoc />
        public override string Name { get; init; } = nameof(StaticWrapper);

        /// <inheritdoc />
        public override bool IsStatic => false;

        /// <inheritdoc />
        public override ClassDeclarationSyntax AddMethod(in VTableContext ctx) =>
            throw new NotImplementedException();
    }

    /// <summary>
    /// The mod's configuration.
    /// </summary>
    public record Configuration // DON'T USE CONSTRUCTOR-STYLE RECORDS! Needs a default ctor.
    {
        /// <summary>
        /// The various VTable types to generate.
        /// </summary>
        public IConfigurationSection[]? VTables { get; init; }
    }

    class Rewriter(VTable[] vTables) : ModCSharpSyntaxRewriter
    {
        private Dictionary<
            string,
            (InterfaceDeclarationSyntax Syntax, string? Namespace)
        > _interfaces = new();
        private InterfaceDeclarationSyntax? _currentInterface;
        private Dictionary<string, UsingDirectiveSyntax> _usings = new();
        private VTable[] _vTables = vTables;
        private ClassDeclarationSyntax?[] _currentVTableOutputs = new ClassDeclarationSyntax?[
            vTables.Length
        ];

        public override SyntaxNode? VisitCompilationUnit(CompilationUnitSyntax node)
        {
            foreach (var use in node.Usings)
            {
                _usings.TryAdd(use.ToString(), use);
            }

            return base.VisitCompilationUnit(node);
        }

        public override SyntaxNode? VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
        {
            foreach (var use in node.Usings)
            {
                _usings.TryAdd(use.ToString(), use);
            }

            return base.VisitNamespaceDeclaration(node);
        }

        public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            var ns = node.FirstAncestorOrSelf<BaseNamespaceDeclarationSyntax>();
            var key = $"I{node.Identifier}";
            var fullKey = ns is null ? node.Identifier.ToString() : $"{ns.Name}.{key}";
            if (_interfaces.TryGetValue(fullKey, out var iface))
            {
                // already using the full key
                _currentInterface = iface.Syntax;
                key = fullKey;
            }
            else if (_interfaces.TryGetValue(key, out iface))
            {
                var theirNs = iface.Syntax.FirstAncestorOrSelf<BaseNamespaceDeclarationSyntax>();
                var theirFullKey = theirNs is null
                    ? iface.Syntax.Identifier.ToString()
                    : $"{theirNs.Name}.{iface.Syntax.Identifier}";
                if (theirFullKey == fullKey)
                {
                    // this is our interface
                    _currentInterface = iface.Syntax;
                }
                else
                {
                    // conflict on the non-full key, separate them out.
                    _interfaces.Remove(key);
                    _interfaces.Add(theirFullKey, iface);

                    // this also means we need to create the interface with the full key
                    _currentInterface = NewInterface(key, node);
                    _interfaces.Add(fullKey, (_currentInterface, ns?.Name.ToString()));
                    key = fullKey;
                }
            }
            else
            {
                _currentInterface = NewInterface(key, node);
                _interfaces.Add(key, (_currentInterface, ns?.Name.ToString()));
            }

            var ret = (ClassDeclarationSyntax)base.VisitClassDeclaration(node)!;
            ret = ret.WithMembers(
                    List<MemberDeclarationSyntax>(
                        _currentVTableOutputs.Where(x => x is not null).Concat(ret.Members)!
                    )
                )
                .WithModifiers(
                    TokenList(
                        ret.Modifiers.Where(
                            x => x.Kind() is SyntaxKind.StaticKeyword or SyntaxKind.UnsafeKeyword
                        )
                    )
                );
            _currentVTableOutputs = new ClassDeclarationSyntax?[_currentVTableOutputs.Length];
            _interfaces[key] = (_currentInterface, ns?.Name.ToString());
            _currentInterface = null;
            return ret;

            static InterfaceDeclarationSyntax NewInterface(
                string key,
                MemberDeclarationSyntax node
            ) =>
                InterfaceDeclaration(key)
                    .WithModifiers(
                        TokenList(
                            node.Modifiers
                                .Where(
                                    x =>
                                        x.Kind()
                                            is SyntaxKind.PublicKeyword
                                                or SyntaxKind.PrivateKeyword
                                                or SyntaxKind.InternalKeyword
                                                or SyntaxKind.ProtectedKeyword
                                                or SyntaxKind.UnsafeKeyword
                                )
                                .Concat(Enumerable.Repeat(Token(SyntaxKind.PartialKeyword), 1))
                        )
                    )
                    .AddMembers(
                        InterfaceDeclaration("Static")
                            .WithModifiers(
                                TokenList(
                                    Token(SyntaxKind.PublicKeyword),
                                    Token(SyntaxKind.PartialKeyword)
                                )
                            )
                    );
        }

        public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            if (
                _currentInterface is not null
                && node.GetNativeFunctionInfo(out var lib, out var entryPoint)
                && node.Modifiers.Any(x => x.IsKind(SyntaxKind.StaticKeyword))
            )
            {
                var staticInterface = _currentInterface.Members
                    .OfType<InterfaceDeclarationSyntax>()
                    .First();
                node = (MethodDeclarationSyntax)base.VisitMethodDeclaration(node)!;
                var baseDecl = node.WithBody(null)
                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                    .WithAttributeLists(List<AttributeListSyntax>())
                    .AddNativeFunction(node);
                var staticDecl = baseDecl
                    .WithModifiers(
                        TokenList(
                            baseDecl.Modifiers.Where(
                                x =>
                                    x.Kind() is SyntaxKind.StaticKeyword or SyntaxKind.UnsafeKeyword
                            )
                        )
                    )
                    .AddModifiers(Token(SyntaxKind.AbstractKeyword));
                var instanceDecl = baseDecl.WithModifiers(
                    TokenList(baseDecl.Modifiers.Where(x => x.IsKind(SyntaxKind.UnsafeKeyword)))
                );
                _currentInterface = _currentInterface.WithMembers(
                    List(
                        _currentInterface.Members
                            .Select(
                                x =>
                                    x == staticInterface
                                        ? staticInterface = staticInterface.AddMembers(staticDecl)
                                        : x
                            )
                            .Concat(Enumerable.Repeat(instanceDecl, 1))
                    )
                );
                for (var i = 0; i < _vTables.Length; i++)
                {
                    _currentVTableOutputs[i] = _vTables[i].AddMethod(
                        new VTableContext(
                            _currentVTableOutputs[i],
                            node,
                            lib,
                            entryPoint ?? node.Identifier.ToString(),
                            staticDecl,
                            instanceDecl,
                            node.FirstAncestorOrSelf<ClassDeclarationSyntax>()!
                                .Identifier.ToString()
                        )
                    );
                }
            }

            return node;
        }

        public IEnumerable<KeyValuePair<string, SyntaxNode>> GetExtraFiles()
        {
            foreach (var (fqn, (iface, ns)) in _interfaces)
            {
                yield return new KeyValuePair<string, SyntaxNode>(
                    $"sources/{fqn}.gen.cs",
                    CompilationUnit()
                        .WithUsings(List(_usings.Values))
                        .WithMembers(
                            string.IsNullOrWhiteSpace(ns)
                                ? SingletonList<MemberDeclarationSyntax>(iface)
                                : SingletonList<MemberDeclarationSyntax>(
                                    FileScopedNamespaceDeclaration(
                                            ModUtils.NamespaceIntoIdentifierName(ns)
                                        )
                                        .WithMembers(SingletonList<MemberDeclarationSyntax>(iface))
                                )
                        )
                );
            }
        }
    }

    /// <inheritdoc />
    public Task<GeneratedSyntax> AfterScrapeAsync(string key, GeneratedSyntax syntax)
    {
        var cfg = config.Get(key);
        VTable[]? vTables = null;
        if (cfg.VTables is not null)
        {
            vTables = new VTable[cfg.VTables.Length];
            for (var i = 0; i < cfg.VTables.Length; i++)
            {
                vTables[i] = (VTable)(
                    cfg.VTables[i].Get(
                        cfg.VTables[i].GetValue<string>("Kind") switch
                        {
                            nameof(DllImport) => typeof(DllImport),
                            nameof(StaticWrapper) => typeof(StaticWrapper),
                            nameof(ThreadLocal) => typeof(ThreadLocal),
                            _
                                => throw new InvalidOperationException(
                                    "VTable must have valid \"Kind\" property"
                                )
                        }
                    )
                    ?? throw new InvalidOperationException(
                        "Failed to deserialize VTable configuration properly"
                    )
                );
            }
        }

        var rw = new Rewriter(
            vTables
                ?? new VTable[]
                {
                    new DllImport { IsDefault = true },
                    new StaticWrapper(),
                    new ThreadLocal()
                }
        );

        foreach (var (fname, node) in syntax.Files)
        {
            if (fname.StartsWith("sources/"))
            {
                syntax.Files[fname] = rw.Visit(node);
            }
        }

        foreach (var (fname, node) in rw.GetExtraFiles())
        {
            syntax.Files[fname] = node;
        }

        return Task.FromResult(syntax);
    }

    // public interface IMyStringLibrary
    // {
    //     public interface Static
    //     {
    //         static abstract byte* ToLower(byte* str);
    //         [MethodImpl(MethodImplOptions.AggressiveInlining)]
    //         static virtual Ptr<byte> ToLower(Ptr<byte> str)
    //         {
    //             fixed (byte* nStr = str)
    //             {
    //                 return ToLower(nStr);
    //             }
    //         }
    //         static abstract void FreeResult(byte* str);
    //         [MethodImpl(MethodImplOptions.AggressiveInlining)]
    //         static virtual FreeResult(Ptr<byte> str)
    //         {
    //             fixed (byte* nStr = str)
    //             {
    //                 FreeResult(nStr);
    //             }
    //         }
    //     }
    //     byte* ToLower(byte* str);
    //     Ptr<byte> ToLower(Ptr<byte> str)
    //     {
    //         fixed (byte* nStr = str)
    //         {
    //             return ToLower(nStr);
    //         }
    //     }
    //     void FreeResult(byte* str);
    //     void FreeResult(Ptr<byte> str)
    //     {
    //         fixed (byte* nStr = str)
    //         {
    //             FreeResult(nStr);
    //         }
    //     }
    // }
    // public class MyStringLibrary : IMyStringLibrary
    // {
    //     public static class DllImport : IMyStringLibrary.Static
    //     {
    //         [DllImportAttribute("mystringlib")]
    //         public static extern byte* ToLower(byte* str);
    //         [DllImportAttribute("mystringlib")]
    //         public static extern void FreeResult(byte* str);
    //     }
    //     public class StaticWrapper<T> : IMyStringLibrary where T: IMyStringLibrary.Static
    //     {
    //         public StaticWrapper();
    //         public byte* ToLower(byte* str) => T.ToLower(str);
    //         public void FreeResult(byte* str) => T.FreeResult(str);
    //     }
    //     public class ThreadLocal : IMyStringLibrary.Static
    //     {
    //         private static ThreadLocal<IMyStringLibrary> _current = new();
    //         public static void MakeCurrent(IMyStringLibrary current) => _current.Value = current;
    //         public static byte* ToLower(byte* str) => _current.Value.ToLower(str);
    //         public static void FreeResult(byte* str) => _current.Value.FreeResult(str);
    //         public static Ptr<byte> ToLower(Ptr<byte> str) => _current.Value.ToLower(str);
    //         public static void FreeResult(Ptr<byte> str) => _current.Value.FreeResult(str);
    //     }
    //
    //     // Non-Static Interface
    //     private Func<string, nint> _getProcAddress;
    //     byte* IMyStringLibrary.ToLower(byte* str)
    //     {
    //         var ptr = _getProcAddress("ToLower");
    //         if (ptr is 0) throw new("some symbol loading exception...");
    //         return ((delegate* unmanaged<byte*, byte*>)ptr)(str);
    //     }
    //
    //     void IMyStringLibrary.FreeResult(byte* str)
    //     {
    //         var ptr = _getProcAddress("FreeResult");
    //         if (ptr is 0) throw new("some symbol loading exception...");
    //         return ((delegate* unmanaged<byte*, void>)ptr)(str);
    //     }
    //
    //     public static IMyStringLibrary Create() => new StaticWrapper<DllImport>();
    //     public static IMyStringLibrary Create(Func<string, nint> getProcAddress) => new MyStringLibrary { _getProcAddress = getProcAddress };
    //
    //     // Static Interface
    //     public static byte* ToLower(byte* str) => DllImport.ToLower(str);
    //     public static Ptr<byte> ToLower(Ptr<byte> str) => DllImport.ToLower(str);
    //     public static void FreeResult(byte* str) => DllImport.FreeResult(str);
    //     public static void FreeResult(Ptr<byte> str) => DllImport.FreeResult(str);
    // }
}
