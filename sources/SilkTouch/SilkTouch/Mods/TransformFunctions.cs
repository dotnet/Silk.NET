using System.Diagnostics;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Logging;
using Silk.NET.SilkTouch.Mods.Transformation;
using Silk.NET.SilkTouch.Naming;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Mods the bindings to use the Silk.NET.Core pointer types.
/// </summary>
[ModConfiguration<Configuration>]
public class TransformFunctions(
    FunctionTransformer ft,
    ILogger<TransformFunctions> logger,
    IProgressService progressService
) : ModCSharpSyntaxRewriter, IMod
{
    private ThreadLocal<string> _jobKey = new();

    private SemanticModel? _semanticModel;
    private Dictionary<string, string> _toRename = [];
    private string _typeName = string.Empty;
    private string _namespace = string.Empty;

    /// <summary>
    /// Configuration for the <see cref="TransformFunctions"/> and related code.
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// Whether all integer return types should be treated as potentially boolean.
        /// </summary>
        public required bool IntReturnsMaybeBool { get; init; }

        /// <summary>
        /// Types to treat as boolean and their boolean schemes if different to default.
        /// </summary>
        public Dictionary<string, string?>? BoolTypes { get; init; }

        /// <summary>
        /// Should the benefit of the doubt transformation be used for ArrayParameterTransformer
        /// </summary>
        public bool BenefitOfTheDoubtArrayTransformation { get; init; } = false;
    }

    /// <inheritdoc />
    public override string? JobKey
    {
        get => _jobKey.Value;
        set
        {
            if (value is null)
            {
                return;
            }
            _jobKey.Value = value;
        }
    }

    /// <inheritdoc />
    public async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        _jobKey.Value = ctx.JobKey;
        var proj = ctx.SourceProject;

        int count = proj?.DocumentIds.Count ?? 0;
        int index = 0;

        progressService.SetTask("Transforming Functions");
        foreach (var docId in ctx.SourceProject?.DocumentIds ?? [])
        {
            index++;
            UsingsToAdd.Clear();
            _typeName = string.Empty;
            var doc =
                proj!.GetDocument(docId) ?? throw new InvalidOperationException("Document missing");
            if (await doc.GetSyntaxRootAsync(ct) is { } root)
            {
                proj = doc.WithSyntaxRoot(Visit(root).NormalizeWhitespace()).Project;
            }

            progressService.SetProgress((float)index / count);
        }

        progressService.SetTask("Getting Project Compilation");
        var compilation = await proj!.GetCompilationAsync();
        if (compilation is null)
        {
            logger.LogWarning(
                "project was unable to compile, some usages may not be properly updated"
            );
        }

        List<(ISymbol, string)> toRenameSymbols = [];
        Visitor visitor = new(_toRename, toRenameSymbols, logger);

        index = 0;

        progressService.SetTask("Gathering Symbols");
        foreach (var docId in proj.DocumentIds ?? [])
        {
            index++;
            var doc =
                proj!.GetDocument(docId) ?? throw new InvalidOperationException("Document missing");
            if (await doc.GetSyntaxRootAsync(ct) is { } root)
            {
                var syntaxTree = await doc.GetSyntaxTreeAsync();
                _semanticModel =
                    compilation is not null && syntaxTree is not null
                        ? compilation.GetSemanticModel(syntaxTree!)
                        : await doc.GetSemanticModelAsync();

                visitor.SemanticModel = _semanticModel;
                visitor.Visit(root);
            }
            progressService.SetProgress((float)index / count);
        }

        ctx.SourceProject = proj;

        await NameUtils.RenameAllRoslynAsync(ctx, toRenameSymbols, logger, ct, false, true);
    }

    /// <inheritdoc />
    public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node)
    {
        string parentName = _typeName;
        _typeName += $".{node.Identifier}";
        _namespace = node.NamespaceFromSyntaxNode();
        var ret = base.VisitClassDeclaration(node) is ClassDeclarationSyntax cd
            ? cd.WithMembers(
                List(
                    cd.Members.Where(x => x is not MethodDeclarationSyntax)
                        .Concat(
                            ft.GetTransformedFunctions(
                                    _jobKey.Value,
                                    cd.Members.OfType<MethodDeclarationSyntax>(),
                                    this
                                )
                                .Select(FunctionSelect)
                                .OrderBy(x => x.Identifier.ToString())
                        )
                )
            )
            : node;
        _typeName = parentName;
        return ret;
    }

    /// <inheritdoc />
    public override SyntaxNode? VisitStructDeclaration(StructDeclarationSyntax node)
    {
        string parentName = _typeName;
        _typeName += $".{node.Identifier}";
        _namespace = node.NamespaceFromSyntaxNode();
        var ret = base.VisitStructDeclaration(node) is StructDeclarationSyntax cd
            ? cd.WithMembers(
                List(
                    cd.Members.Where(x => x is not MethodDeclarationSyntax)
                        .Concat(
                            ft.GetTransformedFunctions(
                                    _jobKey.Value,
                                    cd.Members.OfType<MethodDeclarationSyntax>(),
                                    this
                                )
                                .Select(FunctionSelect)
                                .OrderBy(x => x.Identifier.ToString())
                        )
                )
            )
            : node;
        _typeName = parentName;
        return ret;
    }

    /// <inheritdoc />
    public override SyntaxNode? VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
    {
        string parentName = _typeName;
        _typeName += $".{node.Identifier}";
        _namespace = node.NamespaceFromSyntaxNode();
        var ret = base.VisitInterfaceDeclaration(node) is InterfaceDeclarationSyntax id
            ? id.WithMembers(
                List(
                    id.Members.Where(x => x is not MethodDeclarationSyntax)
                        .Concat(
                            ft.GetTransformedFunctions(
                                    _jobKey.Value,
                                    id.Members.OfType<MethodDeclarationSyntax>(),
                                    this
                                )
                                .Select(FunctionSelect)
                                .OrderBy(x => x.Identifier.ToString())
                        )
                )
            )
            : node;
        _typeName = parentName;
        return ret;
    }

    private MethodDeclarationSyntax FunctionSelect(TransformedFunction transFunc)
    {
        if (!transFunc.IsOriginal || !transFunc.HasConflictingSignature)
            return transFunc.Function;

        // Sometimes when functions are transformed they only differ by return type. C# doesn't allow
        // this, so we add a suffix to the original function to differentiate them.
        var newIden = $"{transFunc.Function.Identifier}Raw";

        var transformedDiscrim =
            _namespace
            + "."
            + _typeName
            + ":"
            + ModUtils.DiscrimStr(
                transFunc.Function.Modifiers,
                transFunc.Function.TypeParameterList,
                transFunc.Function.Identifier.ToString(),
                transFunc.Function.ParameterList,
                returnType: null
            );
        _toRename.Add(transformedDiscrim, newIden);

        // Add the suffixed function
        var newFun = transFunc
            .Function.WithRenameSafeAttributeLists()
            .WithIdentifier(Identifier(newIden))
            .WithModifiers(TokenList(transFunc.Function.Modifiers.Where(mod => !mod.IsKind(SyntaxKind.NewKeyword))));

        return newFun;
    }

    private class Visitor(
        Dictionary<string, string> toRename,
        List<(ISymbol, string)> toRenameSymbols,
        ILogger logger
    ) : CSharpSyntaxWalker
    {
        public SemanticModel? SemanticModel;

        private string _typeName = string.Empty;
        private string _namespace = string.Empty;

        public override void VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            string parentName = _typeName;
            _typeName += $".{node.Identifier}";
            _namespace = node.NamespaceFromSyntaxNode();
            base.VisitClassDeclaration(node);
            _typeName = parentName;
        }

        public override void VisitStructDeclaration(StructDeclarationSyntax node)
        {
            string parentName = _typeName;
            _typeName += $".{node.Identifier}";
            _namespace = node.NamespaceFromSyntaxNode();
            base.VisitStructDeclaration(node);
            _typeName = parentName;
        }

        public override void VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
        {
            string parentName = _typeName;
            _typeName += $".{node.Identifier}";
            _namespace = node.NamespaceFromSyntaxNode();
            base.VisitInterfaceDeclaration(node);
            _typeName = parentName;
        }

        public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            base.VisitMethodDeclaration(node);

            var discrimWithRet =
                _namespace
                + "."
                + _typeName
                + ":"
                + ModUtils.DiscrimStr(
                    node.Modifiers,
                    node.TypeParameterList,
                    node.Identifier.ToString(),
                    node.ParameterList,
                    returnType: null
                );

            if (!toRename.TryGetValue(discrimWithRet, out string? newName))
            {
                return;
            }

            var symbol = SemanticModel.GetDeclaredSymbol(node);

            if (symbol is not null)
            {
                toRenameSymbols.Add((symbol, newName));
            }
            else
            {
                logger.LogError("Unable to retrieve symbol for {}", discrimWithRet);
            }
        }
    }
}
