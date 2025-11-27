using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Clang;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Adds VTables to allow multiple points of entry into the native library.
/// </summary>
/// <remarks>
/// Given a <c>static</c> method either marked as a bodiless <see cref="DllImport"/> or a "transformed"
/// method (as output from <see cref="TransformFunctions"/>), this mod will create an interface containing API
/// declarations for an "API object" as well as a <c>"Static"</c> sub-interface containing <c>static abstract</c>s or
/// <c>static virtual</c>s as appropriate. Where a default interface method is added (i.e. because it's a transformed
/// method), the original method is removed from the original class (and additional implementations of the VTable
/// interfaces) to allow the implementations to cascade down without duplicating code. Once the interfaces are created,
/// the original class shall contain <c>partial class</c>es for each of the configured VTables, implementing one of the
/// interfaces, depending on which kind of VTable it is. This logic resides in the <see cref="VTable"/> derived classes.
/// After all of that, the original class is modified to implement both interfaces, with the instance interface proxying
/// through a "native context" from which function pointers are loaded (and subsequently calling said function
/// pointers), and the static interface proxying through the configured "static default". In most cases, this is the
/// <see cref="DllImport"/>-based partial class implementation of the static interface. However, in some cases this
/// could be any other implementation such as the <see cref="ThisThread"/> implementation.
/// </remarks>
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
                                SimpleBaseType(IdentifierName($"I{ctx.ClassName}.Static"))
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
                .WithBaseList(
                    BaseList(
                        SingletonSeparatedList<BaseTypeSyntax>(
                            SimpleBaseType(IdentifierName($"I{ctx.ClassName}.Static"))
                        )
                    )
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
                            SimpleBaseType(IdentifierName($"I{ctx.ClassName}.Static"))
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
                                                    ),
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
                                                            Argument(
                                                                IdentifierName("ContextFactory")
                                                            )
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
                                : null,
                        }.OfType<MemberDeclarationSyntax>()
                    )
                );

        /// <inheritdoc />
        public override ClassDeclarationSyntax AddMethod(in VTableContext ctx)
        {
            var current =
                ctx.CurrentPartial
                ?? ClassDeclaration(Name)
                    .WithModifiers(
                        TokenList(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.PartialKeyword))
                    );
            if (!ctx.Original.Modifiers.Any(SyntaxKind.PublicKeyword))
            {
                // We only care about the stuff that appears in the interface at this time.
                return current;
            }
            return current.AddMembers(
                ctx.StaticDecl.WithModifiers(
                        TokenList(
                            new[] { Token(SyntaxKind.PublicKeyword) }.Concat(
                                ctx.StaticDecl.Modifiers.Where(x =>
                                    x.Kind()
                                        is not (
                                            SyntaxKind.PublicKeyword
                                            or SyntaxKind.PartialKeyword
                                        )
                                )
                            )
                        )
                    )
                    .WithExpressionBody(
                        ctx.StaticDecl.Body is not null
                            ? null
                            : ArrowExpressionClause(
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
                                            ctx.InstanceDecl.ParameterList.Parameters.Select(x =>
                                                Argument(IdentifierName(x.Identifier))
                                            )
                                        )
                                    )
                                )
                            )
                    )
                    .WithSemicolonToken(
                        ctx.StaticDecl.Body is not null ? default : Token(SyntaxKind.SemicolonToken)
                    )
                    .AddMaxOpt()
            );
        }
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
        public override ClassDeclarationSyntax AddMethod(in VTableContext ctx)
        {
            var current =
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
                                    TypeConstraint(IdentifierName($"I{ctx.ClassName}.Static"))
                                )
                            )
                        )
                    );
            if (!ctx.Original.Modifiers.Any(SyntaxKind.PublicKeyword))
            {
                // We only care about the stuff that appears in the interface at this time.
                return current;
            }
            return current.AddMembers(
                ctx.InstanceDecl.WithBody(null)
                    .WithModifiers(
                        TokenList(
                            ctx.InstanceDecl.Modifiers.Where(x =>
                                !x.IsKind(SyntaxKind.PartialKeyword)
                            )
                        )
                    )
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
                                        ctx.InstanceDecl.ParameterList.Parameters.Select(x =>
                                            Argument(IdentifierName(x.Identifier))
                                        )
                                    )
                                )
                            )
                        )
                    )
                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                    .AddMaxOpt()
            );
        }
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
        private InterfaceDeclarationSyntax? _currentInterface;
        private ClassDeclarationSyntax? _currentClass;
        private VTable[] _vTables = vTables;

        private ClassDeclarationSyntax?[] _currentVTableOutputs = new ClassDeclarationSyntax?[
            vTables.Length
        ];

        public Dictionary<string, UsingDirectiveSyntax> AggregatedUsings { get; } = new();

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

        private InterfaceDeclarationSyntax? _rwMethodCallsForExplicitInterfaceSpecifier;

        private List<MethodDeclarationSyntax> _methods = new();
        private bool _multiClass;
        private string? _className,
            _fullClassName;

        /// <summary>
        /// The current class name, if a single class is being handled from the current file. Not fully qualified.
        /// </summary>
        public string? ClassName
        {
            get => _multiClass ? null : _className;
            set => (_className, _multiClass) = (value, _multiClass && value is not null);
        }

        /// <summary>
        /// All interface partials generated from the classes contained in the current file.
        /// </summary>
        public List<(
            string Namespace,
            InterfaceDeclarationSyntax Interface
        )> InterfacePartials { get; set; } = [];

        /// <summary>
        /// All class names this rewriter has encountered. The key may be fully qualified depending on whether a class
        /// with the same name but different namespace has been encountered, the value is always fully-qualified.
        /// </summary>
        public Dictionary<string, string?> FullClassNames { get; set; } = [];

        /// <summary>
        /// The entry points encountered for each full class name.
        /// </summary>
        public Dictionary<
            string,
            List<(string EntryPoint, string Library)>
        > EntryPoints { get; set; } = [];

        public override SyntaxNode? Visit(SyntaxNode? node)
        {
            var ret = base.Visit(node);
            if (node is CompilationUnitSyntax)
            {
                foreach (var (k, v) in UsingsToAdd)
                {
                    AggregatedUsings[k] = v;
                }

                UsingsToAdd.Clear();
            }

            return ret;
        }

        private static string InterfaceKey(ClassDeclarationSyntax klass) => $"I{klass.Identifier}";

        public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            if (_currentClass is not null)
            {
                return node;
            }

            // Get the interface containing the methods
            var ns = node.NamespaceFromSyntaxNode();
            var key = InterfaceKey(node);
            var className = node.Identifier.ToString();
            _fullClassName = $"{ns}.{node.Identifier}";
            if (!_multiClass && _className is null)
            {
                _className = className;
            }
            else
            {
                _multiClass = true;
            }

            // The contents of the ClassNames hash set determines the output file name for the VTable boilerplate.
            // These are output to the source root, so if there's multiple classes with the same name but different
            // namespaces, then we need to ensure we're tracking that.
            if (FullClassNames.TryGetValue(_fullClassName, out _))
            {
                // already using the full class name.
            }
            else if (
                FullClassNames.TryGetValue(className, out var theirFullClassName)
                && theirFullClassName != _fullClassName
            )
            {
                // separate these two and use their full class names as the file name.
                FullClassNames[className] = null; // <-- keep it in case a third class comes along
                FullClassNames[_fullClassName] = _fullClassName;
                if (theirFullClassName is not null)
                {
                    FullClassNames[theirFullClassName] = theirFullClassName;
                }
            }
            else
            {
                // either it's new or we're not using the full class name and the namespace matches ours
                FullClassNames[className] = _fullClassName;
            }

            _currentClass = node;

            // Visit the class - this should record the methods.
            var ret = (ClassDeclarationSyntax)base.VisitClassDeclaration(node)!;

            _currentClass = null;
            if (_currentInterface is null) // <-- there were no eligible methods.
            {
                // We shouldn't need to reset in this case.
                return ret;
            }

            ret = ret.WithMembers(
                    List<MemberDeclarationSyntax>(
                        // _currentVTableOutputs contains the partials for the vtable implementations within this
                        // partial class. It is populated in VisitMethodDeclaration.
                        _currentVTableOutputs
                            .Where(x => x is not null)
                            .Concat(ret.Members)
                            .Concat(_methods)!
                    )
                )
                .WithModifiers(
                    TokenList(
                        ret.Modifiers.Where(x =>
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
                                SimpleBaseType(IdentifierName($"{key}.Static")),
                            }
                        )
                    )
                );

            // Reset for the next partial.
            InterfacePartials.Add((ns, _currentInterface));
            _currentInterface = null;
            _currentVTableOutputs.AsSpan().Clear();
            return ret;
        }

        private static InterfaceDeclarationSyntax NewInterface(
            string key,
            MemberDeclarationSyntax node
        ) =>
            InterfaceDeclaration(key)
                .WithModifiers(
                    TokenList(
                        node.Modifiers.Where(x =>
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

        public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            var parent = node.FirstAncestorOrSelf<ClassDeclarationSyntax>();
            if (
                _currentClass is null
                || !node.AttributeLists.GetNativeFunctionInfo(
                    out var lib,
                    out var entryPoint,
                    out var callConv
                )
                || !node.Modifiers.Any(SyntaxKind.StaticKeyword)
                || (
                    (node.Body is not null || node.ExpressionBody is not null)
                    && !node.AttributeLists.ContainsAttribute("Silk.NET.Core.Transformed")
                )
                || parent is null
            )
            {
                return base.VisitMethodDeclaration(node);
            }

            entryPoint ??= node.Identifier.ToString();
            _currentInterface ??= NewInterface(InterfaceKey(_currentClass), _currentClass);

            // Get the static interface within this interface
            var staticInterface = _currentInterface
                .Members.OfType<InterfaceDeclarationSyntax>()
                .First();
            node = (MethodDeclarationSyntax)base.VisitMethodDeclaration(node)!;

            // Create the common function declaration for the interfaces.
            var baseDecl = node.WithBody(null)
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                .WithAttributeLists(
                    List(
                        node.AttributeLists.Select(x =>
                                x.WithAttributes(
                                    SeparatedList(
                                        x.Attributes.Where(y =>
                                            !y.IsAttribute("System.Runtime.InteropServices.DllImport")
                                            && !y.IsAttribute("Silk.NET.Core.NativeFunction")
                                            && !y.IsAttribute("System.Runtime.CompilerServices.MethodImpl")
                                        )
                                    )
                                )
                            )
                            .Where(x => x.Attributes.Count > 0)
                    )
                )
                .AddNativeFunction(node);

            // Create the static abstract/virtual variant.
            var staticDecl = baseDecl
                .WithModifiers(
                    TokenList(
                        baseDecl.Modifiers.Where(x => x.Kind() is not SyntaxKind.ExternKeyword)
                    )
                )
                .WithBody(node.Body)
                .WithSemicolonToken(
                    node.Body is not null ? default : Token(SyntaxKind.SemicolonToken)
                )
                .WithExpressionBody(node.ExpressionBody);

            // Create the instance declaration.
            var instanceDecl = baseDecl
                .WithModifiers(
                    TokenList(
                        baseDecl.Modifiers.Where(x =>
                            x.Kind() is not (SyntaxKind.StaticKeyword or SyntaxKind.ExternKeyword)
                        )
                    )
                )
                .WithBody(node.Body)
                .WithSemicolonToken(
                    node.Body is not null ? default : Token(SyntaxKind.SemicolonToken)
                )
                .WithExpressionBody(node.ExpressionBody);
            if (node.Modifiers.Any(SyntaxKind.PublicKeyword))
            {
                _currentInterface = _currentInterface.WithMembers(
                    List(
                        _currentInterface
                            .Members.Select(x =>
                                x == staticInterface
                                    ? staticInterface = staticInterface.AddMembers(
                                        staticDecl
                                            .WithModifiers(
                                                TokenList(
                                                    staticDecl.Modifiers.Where(y =>
                                                        !y.IsKind(SyntaxKind.PublicKeyword)
                                                        && !y.IsKind(SyntaxKind.PartialKeyword)
                                                    )
                                                )
                                            )
                                            .AddModifiers(Token(SyntaxKind.AbstractKeyword))
                                            .WithBody(null)
                                            .WithExpressionBody(null)
                                            .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                                    )
                                    : x
                            )
                            .Concat(
                                Enumerable.Repeat(
                                    instanceDecl
                                        .WithModifiers(
                                            TokenList(
                                                instanceDecl.Modifiers.Where(x =>
                                                    !x.IsKind(SyntaxKind.PublicKeyword)
                                                    && !x.IsKind(SyntaxKind.PartialKeyword)
                                                )
                                            )
                                        )
                                        .WithBody(null)
                                        .WithExpressionBody(null)
                                        .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),
                                    1
                                )
                            )
                    )
                );
            }

            for (var i = 0; i < _vTables.Length; i++)
            {
                _currentVTableOutputs[i] = _vTables[i]
                    .AddMethod(
                        new VTableContext(
                            _currentVTableOutputs[i],
                            node,
                            lib,
                            entryPoint,
                            staticDecl,
                            instanceDecl,
                            parent.Identifier.ToString()
                        )
                    );
            }

            Debug.Assert(_fullClassName is not null);
            if (!EntryPoints.TryGetValue(_fullClassName, out var entryPoints))
            {
                EntryPoints[_fullClassName] = entryPoints = [];
            }

            var slot = entryPoints.IndexOf((entryPoint, lib));
            if (slot == -1)
            {
                slot = entryPoints.Count;
                entryPoints.Add((entryPoint, lib));
            }

            // For the instance implementation of the vtable interface, the class contains an INativeContext from which
            // we'll get function pointers, implementing the interface as a function pointer call. It's an explicit
            // implementation because otherwise the static and non-static functions will conflict.
            // If it's partial, then don't output this declaration part as explicit interface methods don't support
            // that.
            if (!node.Modifiers.Any(SyntaxKind.PartialKeyword))
            {
                _rwMethodCallsForExplicitInterfaceSpecifier = _currentInterface;
                var nativeContextTramp = instanceDecl
                    .WithModifiers(
                        TokenList(
                            instanceDecl.Modifiers.Where(x =>
                                x.Kind() is not SyntaxKind.PublicKeyword
                            )
                        )
                    )
                    .WithExplicitInterfaceSpecifier(
                        node.Modifiers.Any(SyntaxKind.PublicKeyword)
                            ? ExplicitInterfaceSpecifier(
                                IdentifierName(_currentInterface.Identifier.ToString())
                            )
                            : null
                    )
                    .WithExpressionBody(
                        node.Body is null
                        && node.ExpressionBody is null
                        && node.Modifiers.Any(SyntaxKind.ExternKeyword)
                            ? GenerateNativeContextTrampoline(
                                lib,
                                entryPoint,
                                callConv,
                                node.ParameterList,
                                node.ReturnType,
                                slot
                            )
                        : node.ExpressionBody is null ? null
                        : VisitArrowExpressionClause(node.ExpressionBody)
                            as ArrowExpressionClauseSyntax
                    )
                    .WithBody(node.Body is null ? null : VisitBlock(node.Body) as BlockSyntax)
                    .WithSemicolonToken(
                        node.Body is null ? Token(SyntaxKind.SemicolonToken) : default
                    )
                    .AddMaxOpt();
                _rwMethodCallsForExplicitInterfaceSpecifier = null;
                _methods.Add(nativeContextTramp);
            }

            // For the static implementation, we basically forward to whatever is the "static default".
            // We only do this if the method is public - if not, then it's not in the interface and therefore not in the
            // static default.
            if (node.Modifiers.Any(SyntaxKind.PublicKeyword))
            {
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
                                        node.ParameterList.Parameters.Select(x =>
                                            Argument(IdentifierName(x.Identifier))
                                        )
                                    )
                                )
                            )
                        )
                    )
                    .WithModifiers(
                        TokenList(
                            node.Modifiers.Where(x =>
                                x.Kind()
                                    is not (SyntaxKind.ExternKeyword or SyntaxKind.PartialKeyword)
                            )
                        )
                    )
                    .WithAttributeLists(staticDecl.AttributeLists)
                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                    .AddMaxOpt();
                _methods.Add(staticDefaultProxy);
            }

            return null;
        }

        public override SyntaxNode? VisitInvocationExpression(InvocationExpressionSyntax node)
        {
            if (_rwMethodCallsForExplicitInterfaceSpecifier is null)
            {
                return base.VisitInvocationExpression(node);
            }

            var type = node.FirstAncestorOrSelf<TypeDeclarationSyntax>();
            if (
                node.Expression is IdentifierNameSyntax { Identifier: var tok }
                && (
                    type?.Members.Any(x =>
                        x.Modifiers.Any(SyntaxKind.PublicKeyword)
                        && x.ChildTokens()
                            .FirstOrDefault(y => y.IsKind(SyntaxKind.IdentifierToken))
                            .ToString() == tok.ToString()
                    ) ?? false
                )
            )
            {
                return (
                    base.VisitInvocationExpression(node) as InvocationExpressionSyntax
                )?.WithExpression(
                    MemberAccessExpression(
                        SyntaxKind.SimpleMemberAccessExpression,
                        ParenthesizedExpression(
                            CastExpression(
                                IdentifierName(
                                    _rwMethodCallsForExplicitInterfaceSpecifier.Identifier
                                ),
                                ThisExpression()
                            )
                        ),
                        IdentifierName(tok)
                    )
                );
            }
            return base.VisitInvocationExpression(node);
        }

        public IEnumerable<KeyValuePair<string, CSharpSyntaxNode>> GetExtraFiles()
        {
            var uta = UsingsToAdd;
            UsingsToAdd = AggregatedUsings;
            foreach (var (outputName, nonInterface) in FullClassNames)
            {
                if (nonInterface is null)
                {
                    continue;
                }

                if (!EntryPoints.TryGetValue(nonInterface, out var entryPoints))
                {
                    continue;
                }

                var nonInterfaceIden = nonInterface[(nonInterface.LastIndexOf('.') + 1)..];
                var ns = nonInterface[..nonInterface.LastIndexOf('.')];
                var boilerplate = ClassDeclaration(nonInterfaceIden)
                    .WithModifiers(TokenList(Token(SyntaxKind.PartialKeyword)))
                    .WithMembers(
                        List<MemberDeclarationSyntax>(
                            _vTables
                                .Select(x =>
                                    x.GetBoilerplate(
                                        new VTableBoilerplateContext(
                                            nonInterfaceIden,
                                            _staticDefault,
                                            _staticDefaultWrapper
                                        )
                                    )
                                )
                                .Where(x => x is not null)
                                .Concat(GenerateTopLevelBoilerplate(nonInterfaceIden, entryPoints))!
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
                yield return new KeyValuePair<string, CSharpSyntaxNode>(
                    $"{outputName}.gen.cs",
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
            string nonInterfaceName,
            List<(string EntryPoint, string Library)> slots
        )
        {
            yield return FieldDeclaration(
                    VariableDeclaration(
                        ArrayType(
                            PointerType(PredefinedType(Token(SyntaxKind.VoidKeyword))),
                            SingletonList(ArrayRankSpecifier())
                        ),
                        SingletonSeparatedList(
                            VariableDeclarator("_slots")
                                .WithInitializer(
                                    EqualsValueClause(
                                        ArrayCreationExpression(
                                            ArrayType(
                                                    PointerType(
                                                        PredefinedType(
                                                            Token(SyntaxKind.VoidKeyword)
                                                        )
                                                    )
                                                )
                                                .WithRankSpecifiers(
                                                    SingletonList(
                                                        ArrayRankSpecifier(
                                                            SingletonSeparatedList<ExpressionSyntax>(
                                                                LiteralExpression(
                                                                    SyntaxKind.NumericLiteralExpression,
                                                                    Literal(slots.Count)
                                                                )
                                                            )
                                                        )
                                                    )
                                                )
                                        )
                                    )
                                )
                        )
                    )
                )
                .WithModifiers(
                    TokenList(
                        Token(SyntaxKind.PrivateKeyword),
                        Token(SyntaxKind.UnsafeKeyword),
                        Token(SyntaxKind.ReadOnlyKeyword)
                    )
                );

            if (
                _staticDefaultWrapper is not null
                && !_vTables.Any(x => x is ThisThread && x.Name == _staticDefault)
            )
            {
                yield return PropertyDeclaration(
                        IdentifierName($"I{nonInterfaceName}"),
                        Identifier("Instance")
                    )
                    .WithModifiers(
                        TokenList(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.StaticKeyword))
                    )
                    .WithAccessorList(
                        AccessorList(
                            SingletonList(
                                AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                            )
                        )
                    )
                    .WithInitializer(
                        EqualsValueClause(
                            ObjectCreationExpression(_staticDefaultWrapper, ArgumentList(), null)
                        )
                    )
                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));

                yield return MethodDeclaration(IdentifierName($"I{nonInterfaceName}"), "Create")
                    .WithModifiers(
                        TokenList(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.StaticKeyword))
                    )
                    .WithExpressionBody(ArrowExpressionClause(IdentifierName("Instance")))
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
                                        XmlEmptyElement("inheritdoc"),
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
            TypeSyntax returnType,
            int slot
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
                                                    .Parameters.Select(x =>
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
                                ParenthesizedExpression(
                                    ConditionalExpression(
                                        IsPatternExpression(
                                            ElementAccessExpression(
                                                IdentifierName("_slots"),
                                                BracketedArgumentList(
                                                    SingletonSeparatedList(
                                                        Argument(
                                                            LiteralExpression(
                                                                SyntaxKind.NumericLiteralExpression,
                                                                Literal(slot)
                                                            )
                                                        )
                                                    )
                                                )
                                            ),
                                            BinaryPattern(
                                                SyntaxKind.AndPattern,
                                                UnaryPattern(
                                                    Token(SyntaxKind.NotKeyword),
                                                    ConstantPattern(
                                                        LiteralExpression(
                                                            SyntaxKind.NullLiteralExpression
                                                        )
                                                    )
                                                ),
                                                VarPattern(
                                                    SingleVariableDesignation(
                                                        Identifier("loadedFnPtr")
                                                    )
                                                )
                                            )
                                        ),
                                        IdentifierName("loadedFnPtr"),
                                        AssignmentExpression(
                                            SyntaxKind.SimpleAssignmentExpression,
                                            ElementAccessExpression(
                                                IdentifierName("_slots"),
                                                BracketedArgumentList(
                                                    SingletonSeparatedList(
                                                        Argument(
                                                            LiteralExpression(
                                                                SyntaxKind.NumericLiteralExpression,
                                                                Literal(slot)
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
                                                                ),
                                                            }
                                                        )
                                                    )
                                                )
                                        )
                                    )
                                )
                            )
                        )
                    )
                    .WithArgumentList(
                        ArgumentList(
                            SeparatedList(
                                parameterList.Parameters.Select(x =>
                                    Argument(IdentifierName(x.Identifier.ToString()))
                                )
                            )
                        )
                    )
            );

        public void Reset()
        {
            InterfacePartials.Clear();
            ClassName = null;
            _methods.Clear();
        }
    }

    /// <inheritdoc />
    public async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        var cfg = config.Get(ctx.JobKey);
        VTable[]? vTables = null;
        if (cfg.VTables is not null)
        {
            vTables = new VTable[cfg.VTables.Length];
            for (var i = 0; i < cfg.VTables.Length; i++)
            {
                vTables[i] = (VTable)(
                    cfg.VTables[i]
                        .Get(
                            cfg.VTables[i].GetValue<string>("Kind") switch
                            {
                                nameof(DllImport) => typeof(DllImport),
                                nameof(StaticWrapper) => typeof(StaticWrapper),
                                nameof(ThisThread) => typeof(ThisThread),
                                _ => throw new InvalidOperationException(
                                    "VTable must have valid \"Kind\" property"
                                ),
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
                    new ThisThread(),
                }
        );
        var newFiles = new List<(string, CSharpSyntaxNode)>(rw.FullClassNames.Count);
        var proj = ctx.SourceProject;
        foreach (var docId in ctx.SourceProject?.DocumentIds ?? [])
        {
            var doc =
                proj!.GetDocument(docId) ?? throw new InvalidOperationException("Document missing");
            var (fname, node) = (doc.RelativePath(), await doc.GetSyntaxRootAsync(ct));
            if (fname is null)
            {
                continue;
            }

            rw.Reset();
            proj = doc.WithSyntaxRoot(
                rw.Visit(node)?.NormalizeWhitespace()
                    ?? throw new InvalidOperationException("Visit returned null")
            ).Project;
            if (rw.InterfacePartials.Count == 0)
            {
                continue;
            }

            var ifname =
                rw.ClassName is not null
                && fname.Replace(rw.ClassName, $"I{rw.ClassName}") is var ifn
                && ifn != fname
                    ? ifn
                    : ModUtils.AddEffectiveSuffix(fname, "Interfaces");
            var nNamespaces = rw.InterfacePartials.Select(x => x.Namespace).Distinct().Count();
            newFiles.Add(
                (
                    ifname,
                    CompilationUnit()
                        .WithUsings(ModCSharpSyntaxRewriter.GetUsings(rw.AggregatedUsings, null))
                        .WithMembers(
                            nNamespaces == 1
                                ? string.IsNullOrWhiteSpace(rw.InterfacePartials[0].Namespace)
                                    ? List<MemberDeclarationSyntax>(
                                        rw.InterfacePartials.Select(x => x.Interface)
                                    )
                                    : SingletonList<MemberDeclarationSyntax>(
                                        FileScopedNamespaceDeclaration(
                                                ModUtils.NamespaceIntoIdentifierName(
                                                    rw.InterfacePartials[0].Namespace
                                                )
                                            )
                                            .WithMembers(
                                                List<MemberDeclarationSyntax>(
                                                    rw.InterfacePartials.Select(x => x.Interface)
                                                )
                                            )
                                    )
                                : List<MemberDeclarationSyntax>(
                                    rw.InterfacePartials.GroupBy(x => x.Namespace)
                                        .Select(g =>
                                            NamespaceDeclaration(
                                                    ModUtils.NamespaceIntoIdentifierName(g.Key)
                                                )
                                                .WithMembers(
                                                    List<MemberDeclarationSyntax>(
                                                        g.Select(x => x.Interface)
                                                    )
                                                )
                                        )
                                )
                        )
                )
            );
        }

        foreach (
            var (fname, root) in newFiles.Concat(rw.GetExtraFiles().Select(x => (x.Key, x.Value)))
        )
        {
            proj = proj
                ?.AddDocument(
                    Path.GetFileName(fname),
                    root.NormalizeWhitespace(),
                    filePath: proj.FullPath(fname)
                )
                .Project;
        }

        ctx.SourceProject = proj;
    }
}
