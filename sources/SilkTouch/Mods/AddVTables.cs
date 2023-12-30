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
using Silk.NET.SilkTouch.Clang;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

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
    [JsonDerivedType(typeof(ThisThread), nameof(ThisThread))]
    [JsonDerivedType(typeof(StaticWrapper), nameof(StaticWrapper))]
    public abstract record VTable
    {
        /// <summary>
        /// If <see cref="IsStatic"/> is true, is this the static default? If <see cref="IsStatic"/> is false, should
        /// this be the default for <see cref="ThisThread"/> (unless overridden?).
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
        public virtual ClassDeclarationSyntax? GetBoilerplate(in VTableBoilerplateContext ctx) =>
            null;

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
    /// Context for generating VTable boilerplate.
    /// </summary>
    /// <param name="ClassName">The class name.</param>
    /// <param name="StaticDefault">The static default class name.</param>
    /// <param name="StaticDefaultWrapper">The wrapper class for using the static default as an instance.</param>
    public readonly record struct VTableBoilerplateContext(
        string ClassName,
        string? StaticDefault,
        GenericNameSyntax? StaticDefaultWrapper
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
                                SimpleBaseType(
                                    GenericName(
                                        Identifier($"I{ctx.ClassName}.Static"),
                                        TypeArgumentList(
                                            SingletonSeparatedList<TypeSyntax>(IdentifierName(Name))
                                        )
                                    )
                                )
                            )
                        )
                    )
            ).AddMembers(ctx.Original);

        /// <inheritdoc />
        public override ClassDeclarationSyntax? GetBoilerplate(in VTableBoilerplateContext ctx) =>
            ClassDeclaration(Name)
                .WithModifiers(
                    TokenList(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.PartialKeyword))
                )
                .WithMembers(
                    SingletonList<MemberDeclarationSyntax>(
                        ConstructorDeclaration(Name)
                            .WithModifiers(TokenList(Token(SyntaxKind.StaticKeyword)))
                            .WithExpressionBody(
                                ArrowExpressionClause(
                                    InvocationExpression(
                                        MemberAccessExpression(
                                            SyntaxKind.SimpleMemberAccessExpression,
                                            IdentifierName("LoaderInterface"),
                                            IdentifierName("RegisterHook")
                                        ),
                                        ArgumentList(
                                            SingletonSeparatedList(
                                                Argument(
                                                    InvocationExpression(
                                                        MemberAccessExpression(
                                                            SyntaxKind.SimpleMemberAccessExpression,
                                                            IdentifierName("Assembly"),
                                                            IdentifierName("GetExecutingAssembly")
                                                        )
                                                    )
                                                )
                                            )
                                        )
                                    )
                                )
                            )
                            .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                    )
                );
    }

    /// <summary>
    /// Configuration for the static VTable wrapping a ThreadLocal instance VTable.
    /// </summary>
    public record ThisThread : VTable
    {
        /// <summary>
        /// Should we generate a <c>partial</c> method representing the factory? If false, and we can't determine our
        /// own sensible default, threads will have no default value.
        /// </summary>
        public bool GenerateFactoryPartial { get; init; } = false;

        /// <summary>
        /// Should we generate a <c>partial</c> method for setting the current value? If false, the default
        /// implementation will be used.
        /// </summary>
        public bool GenerateMakeCurrentPartial { get; init; } = false;

        /// <inheritdoc />
        public override string Name { get; init; } = nameof(ThisThread);

        /// <inheritdoc />
        public override bool IsStatic => true;

        /// <inheritdoc />
        public override ClassDeclarationSyntax? GetBoilerplate(in VTableBoilerplateContext ctx) =>
            ClassDeclaration(Name)
                .WithModifiers(
                    TokenList(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.PartialKeyword))
                )
                .WithBaseList(
                    BaseList(
                        SingletonSeparatedList<BaseTypeSyntax>(
                            SimpleBaseType(
                                GenericName(
                                    Identifier($"I{ctx.ClassName}.Static"),
                                    TypeArgumentList(
                                        SingletonSeparatedList<TypeSyntax>(IdentifierName(Name))
                                    )
                                )
                            )
                        )
                    )
                )
                .WithMembers(
                    List(
                        new MemberDeclarationSyntax?[]
                        {
                            PropertyDeclaration(
                                    GenericName(
                                        Identifier("ThreadLocal"),
                                        TypeArgumentList(
                                            SingletonSeparatedList<TypeSyntax>(
                                                IdentifierName($"I{ctx.ClassName}")
                                            )
                                        )
                                    ),
                                    "Underlying"
                                )
                                .WithModifiers(
                                    TokenList(
                                        Token(SyntaxKind.PublicKeyword),
                                        Token(SyntaxKind.StaticKeyword)
                                    )
                                )
                                .WithAccessorList(
                                    AccessorList(
                                        List(
                                            new[]
                                            {
                                                AccessorDeclaration(
                                                        SyntaxKind.GetAccessorDeclaration
                                                    )
                                                    .WithSemicolonToken(
                                                        Token(SyntaxKind.SemicolonToken)
                                                    )
                                            }
                                        )
                                    )
                                )
                                .WithInitializer(
                                    EqualsValueClause(
                                        ImplicitObjectCreationExpression(
                                            GenerateFactoryPartial
                                                ? ArgumentList(
                                                    SingletonSeparatedList(
                                                        Argument(IdentifierName("ContextFactory"))
                                                    )
                                                )
                                                : !string.IsNullOrWhiteSpace(ctx.StaticDefault)
                                                && ctx.StaticDefaultWrapper is not null
                                                && ctx.StaticDefault != Name
                                                    ? ArgumentList(
                                                        SingletonSeparatedList(
                                                            Argument(
                                                                ParenthesizedLambdaExpression()
                                                                    .WithModifiers(
                                                                        TokenList(
                                                                            Token(
                                                                                SyntaxKind.StaticKeyword
                                                                            )
                                                                        )
                                                                    )
                                                                    .WithExpressionBody(
                                                                        ObjectCreationExpression(
                                                                            ctx.StaticDefaultWrapper,
                                                                            ArgumentList(),
                                                                            null
                                                                        )
                                                                    )
                                                            )
                                                        )
                                                    )
                                                    : ArgumentList(),
                                            null
                                        )
                                    )
                                )
                                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),
                            MethodDeclaration(
                                    PredefinedType(Token(SyntaxKind.VoidKeyword)),
                                    "MakeCurrent"
                                )
                                .WithModifiers(
                                    GenerateMakeCurrentPartial
                                        ? TokenList(
                                            Token(SyntaxKind.PublicKeyword),
                                            Token(SyntaxKind.StaticKeyword),
                                            Token(SyntaxKind.PartialKeyword)
                                        )
                                        : TokenList(
                                            Token(SyntaxKind.PublicKeyword),
                                            Token(SyntaxKind.StaticKeyword)
                                        )
                                )
                                .WithParameterList(
                                    ParameterList(
                                        SingletonSeparatedList(
                                            Parameter(Identifier("ctx"))
                                                .WithType(IdentifierName($"I{ctx.ClassName}"))
                                        )
                                    )
                                )
                                .WithExpressionBody(
                                    GenerateMakeCurrentPartial
                                        ? null
                                        : ArrowExpressionClause(
                                            AssignmentExpression(
                                                SyntaxKind.SimpleAssignmentExpression,
                                                MemberAccessExpression(
                                                    SyntaxKind.SimpleMemberAccessExpression,
                                                    IdentifierName("Underlying"),
                                                    IdentifierName("Value")
                                                ),
                                                IdentifierName("ctx")
                                            )
                                        )
                                )
                                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),
                            GenerateFactoryPartial
                                ? MethodDeclaration(
                                        IdentifierName($"I{ctx.ClassName}"),
                                        "ContextFactory"
                                    )
                                    .WithModifiers(
                                        TokenList(
                                            Token(SyntaxKind.PrivateKeyword),
                                            Token(SyntaxKind.StaticKeyword),
                                            Token(SyntaxKind.PartialKeyword)
                                        )
                                    )
                                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                                : null
                        }.OfType<MemberDeclarationSyntax>()
                    )
                );

        /// <inheritdoc />
        public override ClassDeclarationSyntax AddMethod(in VTableContext ctx) =>
            (
                ctx.CurrentPartial
                ?? ClassDeclaration(Name)
                    .WithModifiers(
                        TokenList(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.PartialKeyword))
                    )
            )
                .AddMembers(
                    ctx.StaticDecl.WithModifiers(
                        TokenList(
                            new[] { Token(SyntaxKind.PublicKeyword) }.Concat(
                                ctx.StaticDecl.Modifiers.Where(
                                    x =>
                                        x.Kind()
                                            is SyntaxKind.StaticKeyword
                                                or SyntaxKind.UnsafeKeyword
                                )
                            )
                        )
                    )
                        .WithExpressionBody(
                            ArrowExpressionClause(
                                InvocationExpression(
                                    MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        PostfixUnaryExpression(
                                            SyntaxKind.SuppressNullableWarningExpression,
                                            MemberAccessExpression(
                                                SyntaxKind.SimpleMemberAccessExpression,
                                                IdentifierName("Underlying"),
                                                IdentifierName("Value")
                                            )
                                        ),
                                        IdentifierName(ctx.InstanceDecl.Identifier)
                                    ),
                                    ArgumentList(
                                        SeparatedList(
                                            ctx.InstanceDecl.ParameterList.Parameters.Select(
                                                x => Argument(IdentifierName(x.Identifier))
                                            )
                                        )
                                    )
                                )
                            )
                        )
                )
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
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
            (
                ctx.CurrentPartial
                ?? ClassDeclaration(Name)
                    .WithModifiers(
                        TokenList(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.PartialKeyword))
                    )
                    .WithTypeParameterList(
                        TypeParameterList(SingletonSeparatedList(TypeParameter("T")))
                    )
                    .WithBaseList(
                        BaseList(
                            SingletonSeparatedList<BaseTypeSyntax>(
                                SimpleBaseType(IdentifierName($"I{ctx.ClassName}"))
                            )
                        )
                    )
                    .WithConstraintClauses(
                        SingletonList(
                            TypeParameterConstraintClause(
                                IdentifierName("T"),
                                SingletonSeparatedList<TypeParameterConstraintSyntax>(
                                    TypeConstraint(
                                        GenericName(
                                            Identifier($"I{ctx.ClassName}.Static"),
                                            TypeArgumentList(
                                                SingletonSeparatedList<TypeSyntax>(
                                                    IdentifierName("T")
                                                )
                                            )
                                        )
                                    )
                                )
                            )
                        )
                    )
            ).AddMembers(
                ctx.InstanceDecl.AddModifiers(Token(SyntaxKind.PublicKeyword))
                    .WithBody(null)
                    .WithExpressionBody(
                        ArrowExpressionClause(
                            InvocationExpression(
                                MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    IdentifierName("T"),
                                    IdentifierName(ctx.InstanceDecl.Identifier)
                                ),
                                ArgumentList(
                                    SeparatedList(
                                        ctx.InstanceDecl.ParameterList.Parameters.Select(
                                            x => Argument(IdentifierName(x.Identifier))
                                        )
                                    )
                                )
                            )
                        )
                    )
            );
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
        private VTable[] _vTables = vTables;

        private ClassDeclarationSyntax?[] _currentVTableOutputs = new ClassDeclarationSyntax?[
            vTables.Length
        ];

        private Dictionary<string, UsingDirectiveSyntax> _aggregatedUsings = new();

        private string _staticDefault =
            vTables.FirstOrDefault(x => x.IsDefault && x.IsStatic)?.Name
            ?? throw new InvalidOperationException("Needs at least one static default.");

        private GenericNameSyntax? _staticDefaultWrapper = vTables
            .OfType<StaticWrapper>()
            .FirstOrDefault()
            ?.Name
            is { } str
            ? GenericName(str)
                .WithTypeArgumentList(
                    TypeArgumentList(
                        SingletonSeparatedList<TypeSyntax>(
                            IdentifierName(
                                vTables.FirstOrDefault(x => x.IsDefault && x.IsStatic)?.Name
                                    ?? throw new InvalidOperationException(
                                        "Needs at least one static default."
                                    )
                            )
                        )
                    )
                )
            : null;

        private enum MethodRewriteMode
        {
            NativeContextTrampoline,
            StaticDefault
        }

        private MethodRewriteMode? _rwMode;

        private List<MethodDeclarationSyntax> _methods = new();

        public override SyntaxNode? Visit(SyntaxNode? node)
        {
            var ret = base.Visit(node);
            if (node is CompilationUnitSyntax)
            {
                foreach (var (k, v) in UsingsToAdd)
                {
                    _aggregatedUsings[k] = v;
                }

                UsingsToAdd.Clear();
            }

            return ret;
        }

        public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            if (_currentInterface is not null)
            {
                return node;
            }

            var ns = node.NamespaceFromSyntaxNode();
            var key = $"I{node.Identifier}";
            var fullKey = ns.Length == 0 ? node.Identifier.ToString() : $"{ns}.{key}";
            if (_interfaces.TryGetValue(fullKey, out var iface))
            {
                // already using the full key
                _currentInterface = iface.Syntax;
                key = fullKey;
            }
            else if (_interfaces.TryGetValue(key, out iface))
            {
                var theirNs = iface.Syntax.NamespaceFromSyntaxNode();
                var theirFullKey =
                    theirNs.Length == 0
                        ? iface.Syntax.Identifier.ToString()
                        : $"{theirNs}.{iface.Syntax.Identifier}";
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
                    _interfaces.Add(fullKey, (_currentInterface, ns));
                    key = fullKey;
                }
            }
            else
            {
                _currentInterface = NewInterface(key, node);
                _interfaces.Add(key, (_currentInterface, ns));
            }

            var ret = (ClassDeclarationSyntax)base.VisitClassDeclaration(node)!;
            ret = ret.WithMembers(
                    List<MemberDeclarationSyntax>(
                        _currentVTableOutputs
                            .Where(x => x is not null)
                            .Concat(ret.Members)
                            .Concat(_methods)!
                    )
                )
                .WithModifiers(
                    TokenList(
                        ret.Modifiers.Where(
                            x =>
                                x.Kind()
                                    is SyntaxKind.UnsafeKeyword
                                        or SyntaxKind.PartialKeyword
                                        or SyntaxKind.PublicKeyword
                                        or SyntaxKind.PrivateKeyword
                                        or SyntaxKind.InternalKeyword
                        )
                    )
                )
                .WithBaseList(
                    BaseList(
                        SeparatedList(
                            new BaseTypeSyntax[]
                            {
                                SimpleBaseType(IdentifierName(key)),
                                SimpleBaseType(
                                    GenericName(
                                        Identifier($"{key}.Static"),
                                        TypeArgumentList(
                                            SingletonSeparatedList<TypeSyntax>(
                                                IdentifierName(node.Identifier)
                                            )
                                        )
                                    )
                                )
                            }
                        )
                    )
                );
            _currentVTableOutputs = new ClassDeclarationSyntax?[_currentVTableOutputs.Length];
            _interfaces[key] = (_currentInterface, ns);
            _currentInterface = null;
            return ret;

            static InterfaceDeclarationSyntax NewInterface(
                string key,
                MemberDeclarationSyntax node
            ) =>
                InterfaceDeclaration(key)
                    .WithModifiers(
                        TokenList(
                            node.Modifiers.Where(
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
                            .WithTypeParameterList(
                                TypeParameterList(SingletonSeparatedList(TypeParameter("TSelf")))
                            )
                            .WithConstraintClauses(
                                SingletonList(
                                    TypeParameterConstraintClause(
                                        IdentifierName("TSelf"),
                                        SingletonSeparatedList<TypeParameterConstraintSyntax>(
                                            TypeConstraint(
                                                GenericName(
                                                    Identifier("Static"),
                                                    TypeArgumentList(
                                                        SingletonSeparatedList<TypeSyntax>(
                                                            IdentifierName("TSelf")
                                                        )
                                                    )
                                                )
                                            )
                                        )
                                    )
                                )
                            )
                    );
        }

        public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            var parent = node.FirstAncestorOrSelf<ClassDeclarationSyntax>();
            if (
                _currentInterface is null
                || !node.AttributeLists.GetNativeFunctionInfo(
                    out var lib,
                    out var entryPoint,
                    out _
                )
                || !node.Modifiers.Any(SyntaxKind.StaticKeyword)
                || parent is null
            )
            {
                return base.VisitMethodDeclaration(node);
            }

            var staticInterface = _currentInterface
                .Members.OfType<InterfaceDeclarationSyntax>()
                .First();
            node = (MethodDeclarationSyntax)base.VisitMethodDeclaration(node)!;
            var baseDecl = node.WithBody(null)
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                .WithAttributeLists(
                    List(
                        node.AttributeLists.Select(
                            x =>
                                x.WithAttributes(
                                    SeparatedList(
                                        x.Attributes.Where(
                                            y =>
                                                !y.IsAttribute(
                                                    "System.Runtime.InteropServices.DllImport"
                                                )
                                                && !y.IsAttribute("Silk.NET.Core.NativeFunction")
                                                && !y.IsAttribute(
                                                    "System.Runtime.CompilerServices.MethodImpl"
                                                )
                                        )
                                    )
                                )
                        )
                            .Where(x => x.Attributes.Count > 0)
                    )
                )
                .AddNativeFunction(node);
            var staticDecl = baseDecl
                .WithModifiers(
                    TokenList(
                        baseDecl.Modifiers.Where(
                            x => x.Kind() is SyntaxKind.StaticKeyword or SyntaxKind.UnsafeKeyword
                        )
                    )
                )
                .AddModifiers(Token(SyntaxKind.AbstractKeyword));
            var instanceDecl = baseDecl.WithModifiers(
                TokenList(baseDecl.Modifiers.Where(x => x.IsKind(SyntaxKind.UnsafeKeyword)))
            );
            _currentInterface = _currentInterface.WithMembers(
                List(
                    _currentInterface
                        .Members.Select(
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
                        parent.Identifier.ToString()
                    )
                );
            }

            var nativeContextTramp = instanceDecl.WithExplicitInterfaceSpecifier(
                ExplicitInterfaceSpecifier(IdentifierName(_currentInterface.Identifier.ToString()))
            );
            if (
                node.AttributeLists.Any(
                    x =>
                        x.Attributes.Any(
                            y => y.IsAttribute("System.Runtime.InteropServices.DllImport")
                        )
                )
                && node.AttributeLists.GetNativeFunctionInfo(out lib, out var ep, out var callConv)
            )
            {
                nativeContextTramp = nativeContextTramp
                    .WithAttributeLists(List<AttributeListSyntax>())
                    .WithExpressionBody(
                        GenerateNativeContextTrampoline(
                            lib,
                            ep ?? node.Identifier.ToString(),
                            callConv,
                            node.ParameterList,
                            node.ReturnType
                        )
                    )
                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
            }
            else
            {
                _rwMode = MethodRewriteMode.NativeContextTrampoline;
                nativeContextTramp = node.Body is null
                    ? throw new InvalidOperationException(
                        "Function must have a body if it doesn't have a DllImportAttribute."
                    )
                    : nativeContextTramp
                        .WithBody((BlockSyntax)VisitBlock(node.Body)!)
                        .WithSemicolonToken(default);
                _rwMode = null;
            }

            _methods.Add(nativeContextTramp);

            var staticDefaultProxy = node.WithBody(null)
                .WithExpressionBody(
                    ArrowExpressionClause(
                        InvocationExpression(
                            MemberAccessExpression(
                                SyntaxKind.SimpleMemberAccessExpression,
                                IdentifierName(_staticDefault),
                                IdentifierName(node.Identifier.ToString())
                            ),
                            ArgumentList(
                                SeparatedList(
                                    node.ParameterList.Parameters.Select(
                                        x => Argument(IdentifierName(x.Identifier))
                                    )
                                )
                            )
                        )
                    )
                )
                .WithModifiers(
                    TokenList(node.Modifiers.Where(x => !x.IsKind(SyntaxKind.ExternKeyword)))
                )
                .WithAttributeLists(staticDecl.AttributeLists)
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
            _methods.Add(staticDefaultProxy);
            return null;
        }

        public override SyntaxNode? VisitLocalFunctionStatement(LocalFunctionStatementSyntax node)
        {
            if (
                _rwMode == MethodRewriteMode.NativeContextTrampoline
                && node.AttributeLists.Any(
                    x =>
                        x.Attributes.Any(
                            y => y.IsAttribute("System.Runtime.InteropServices.DllImport")
                        )
                )
                && node.AttributeLists.GetNativeFunctionInfo(
                    out var lib,
                    out var ep,
                    out var callConv
                )
            )
            {
                // make the local function non-static and using a function pointer call on the native context returned
                // pointer.
                return node.WithModifiers(
                        TokenList(
                            node.Modifiers.Where(
                                x =>
                                    x.Kind()
                                        is not SyntaxKind.StaticKeyword
                                            and not SyntaxKind.ExternKeyword
                            )
                        )
                    )
                    .WithAttributeLists(List<AttributeListSyntax>())
                    .WithExpressionBody(
                        GenerateNativeContextTrampoline(
                            lib,
                            ep ?? node.Identifier.ToString(),
                            callConv,
                            node.ParameterList,
                            node.ReturnType
                        )
                    )
                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
            }

            var rmModeBefore = _rwMode;
            var ret = (LocalFunctionStatementSyntax)base.VisitLocalFunctionStatement(node)!;
            if (rmModeBefore != _rwMode)
            {
                // the NativeContextTrampoline if statement has been hit when recursing into a contained local function,
                // make sure that we're non-static.
                ret = ret.WithModifiers(
                    TokenList(ret.Modifiers.Where(x => !x.IsKind(SyntaxKind.StaticKeyword)))
                );
            }

            return ret;
        }

        public IEnumerable<KeyValuePair<string, SyntaxNode>> GetExtraFiles()
        {
            var uta = UsingsToAdd;
            UsingsToAdd = _aggregatedUsings;
            foreach (var (fqn, (iface, ns)) in _interfaces)
            {
                yield return new KeyValuePair<string, SyntaxNode>(
                    $"sources/{fqn}.gen.cs",
                    CompilationUnit()
                        .WithUsings(GetUsings(UsingsToAdd, null))
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
                var nonInterface =
                    $"{fqn[..(fqn.LastIndexOf('.') + 1)]}{fqn[(fqn.LastIndexOf('.') + 2)..]}";
                var nonInterfaceIden = nonInterface[(nonInterface.LastIndexOf('.') + 1)..];
                var boilerplate = ClassDeclaration(nonInterfaceIden)
                    .WithModifiers(TokenList(Token(SyntaxKind.PartialKeyword)))
                    .WithMembers(
                        List<MemberDeclarationSyntax>(
                            _vTables
                                .Select(
                                    x =>
                                        x.GetBoilerplate(
                                            new VTableBoilerplateContext(
                                                nonInterfaceIden,
                                                _staticDefault,
                                                _staticDefaultWrapper
                                            )
                                        )
                                )
                                .Where(x => x is not null)
                                .Concat(GenerateTopLevelBoilerplate(nonInterfaceIden))!
                        )
                    )
                    .WithParameterList(
                        ParameterList(
                            SingletonSeparatedList(
                                Parameter(Identifier("nativeContext"))
                                    .WithType(IdentifierName("INativeContext"))
                            )
                        )
                    )
                    .WithBaseList(
                        BaseList(
                            SingletonSeparatedList<BaseTypeSyntax>(
                                SimpleBaseType(IdentifierName("IDisposable"))
                            )
                        )
                    );
                AddUsing("Silk.NET.Core.Loader");
                AddUsing("System.Reflection");
                yield return new KeyValuePair<string, SyntaxNode>(
                    $"sources/{nonInterface}.gen.cs",
                    CompilationUnit()
                        .WithUsings(GetUsings(UsingsToAdd, null))
                        .WithMembers(
                            string.IsNullOrWhiteSpace(ns)
                                ? SingletonList<MemberDeclarationSyntax>(boilerplate)
                                : SingletonList<MemberDeclarationSyntax>(
                                    FileScopedNamespaceDeclaration(
                                            ModUtils.NamespaceIntoIdentifierName(ns)
                                        )
                                        .WithMembers(
                                            SingletonList<MemberDeclarationSyntax>(boilerplate)
                                        )
                                )
                        )
                );
            }

            UsingsToAdd = uta;
        }

        private IEnumerable<MemberDeclarationSyntax> GenerateTopLevelBoilerplate(
            string nonInterfaceName
        )
        {
            if (
                _staticDefaultWrapper is not null
                && !_vTables.Any(x => x is ThisThread && x.Name == _staticDefault)
            )
            {
                yield return MethodDeclaration(IdentifierName($"I{nonInterfaceName}"), "Create")
                    .WithModifiers(
                        TokenList(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.StaticKeyword))
                    )
                    .WithExpressionBody(
                        ArrowExpressionClause(
                            ObjectCreationExpression(_staticDefaultWrapper, ArgumentList(), null)
                        )
                    )
                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
            }

            yield return MethodDeclaration(IdentifierName($"I{nonInterfaceName}"), "Create")
                .WithModifiers(
                    TokenList(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.StaticKeyword))
                )
                .WithParameterList(
                    ParameterList(
                        SingletonSeparatedList(
                            Parameter(Identifier("ctx")).WithType(IdentifierName("INativeContext"))
                        )
                    )
                )
                .WithExpressionBody(
                    ArrowExpressionClause(
                        ObjectCreationExpression(IdentifierName(nonInterfaceName))
                            .WithArgumentList(
                                ArgumentList(
                                    SingletonSeparatedList(Argument(IdentifierName("ctx")))
                                )
                            )
                    )
                )
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));

            yield return MethodDeclaration(PredefinedType(Token(SyntaxKind.VoidKeyword)), "Dispose")
                .WithExpressionBody(
                    ArrowExpressionClause(
                        InvocationExpression(
                            MemberAccessExpression(
                                SyntaxKind.SimpleMemberAccessExpression,
                                IdentifierName("nativeContext"),
                                IdentifierName("Dispose")
                            )
                        )
                    )
                )
                .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                .WithLeadingTrivia(
                    TriviaList(
                        Trivia(
                            DocumentationCommentTrivia(
                                SyntaxKind.SingleLineDocumentationCommentTrivia,
                                List(
                                    new XmlNodeSyntax[]
                                    {
                                        XmlText()
                                            .WithTextTokens(
                                                TokenList(
                                                    XmlTextLiteral(
                                                        TriviaList(
                                                            DocumentationCommentExterior("///")
                                                        ),
                                                        " ",
                                                        " ",
                                                        TriviaList()
                                                    )
                                                )
                                            ),
                                        XmlEmptyElement("inheritdoc")
                                    }
                                )
                            )
                        )
                    )
                )
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
        }

        private ArrowExpressionClauseSyntax GenerateNativeContextTrampoline(
            string lib,
            string ep,
            string? callConv,
            ParameterListSyntax parameterList,
            TypeSyntax returnType
        ) =>
            ArrowExpressionClause(
                InvocationExpression(
                        ParenthesizedExpression(
                            CastExpression(
                                FunctionPointerType()
                                    .WithCallingConvention(
                                        FunctionPointerCallingConvention(
                                                Token(SyntaxKind.UnmanagedKeyword)
                                            )
                                            .WithUnmanagedCallingConventionList(
                                                callConv is not null
                                                    ? FunctionPointerUnmanagedCallingConventionList(
                                                        SingletonSeparatedList(
                                                            FunctionPointerUnmanagedCallingConvention(
                                                                Identifier(callConv)
                                                            )
                                                        )
                                                    )
                                                    : null
                                            )
                                    )
                                    .WithParameterList(
                                        FunctionPointerParameterList(
                                            SeparatedList(
                                                parameterList
                                                    .Parameters.Select(
                                                        x =>
                                                            FunctionPointerParameter(
                                                                x.Type
                                                                    ?? throw new InvalidOperationException(
                                                                        "Parameter has no type!"
                                                                    )
                                                            )
                                                    )
                                                    .Concat(
                                                        Enumerable.Repeat(
                                                            FunctionPointerParameter(returnType),
                                                            1
                                                        )
                                                    )
                                            )
                                        )
                                    ),
                                InvocationExpression(
                                        MemberAccessExpression(
                                            SyntaxKind.SimpleMemberAccessExpression,
                                            IdentifierName("nativeContext"),
                                            IdentifierName("LoadFunction")
                                        )
                                    )
                                    .WithArgumentList(
                                        ArgumentList(
                                            SeparatedList<ArgumentSyntax>(
                                                new SyntaxNodeOrToken[]
                                                {
                                                    Argument(
                                                        LiteralExpression(
                                                            SyntaxKind.StringLiteralExpression,
                                                            Literal(ep)
                                                        )
                                                    ),
                                                    Token(SyntaxKind.CommaToken),
                                                    Argument(
                                                        LiteralExpression(
                                                            SyntaxKind.StringLiteralExpression,
                                                            Literal(lib)
                                                        )
                                                    )
                                                }
                                            )
                                        )
                                    )
                            )
                        )
                    )
                    .WithArgumentList(
                        ArgumentList(
                            SeparatedList(
                                parameterList.Parameters.Select(
                                    x => Argument(IdentifierName(x.Identifier.ToString()))
                                )
                            )
                        )
                    )
            );
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
                            nameof(ThisThread) => typeof(ThisThread),
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
                    new ThisThread()
                }
        );

        foreach (var (fname, node) in syntax.Files)
        {
            if (fname.StartsWith("sources/"))
            {
                syntax.Files[fname] =
                    rw.Visit(node) ?? throw new InvalidOperationException("Visit returned null");
            }
        }

        foreach (var (fname, node) in rw.GetExtraFiles())
        {
            syntax.Files[fname] = node;
        }

        return Task.FromResult(syntax);
    }
}
