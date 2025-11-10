// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;
using System.CommandLine;
using System.Diagnostics;
using System.Reflection;
using System.Xml.Linq;
using ClangSharp;
using ClangSharp.Interop;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Differencing;
using Microsoft.CodeAnalysis.Editing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Silk.NET.Core;
using Silk.NET.SilkTouch.Logging;
using Silk.NET.SilkTouch.Mods.Transformation;
using Silk.NET.SilkTouch.Sources;
using Silk.NET.SilkTouch.Utility;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods
{
    /// <summary>
    /// A mod to modify COM interface structs into opaque structs that act like ComPtr objects
    /// </summary>
    /// <param name="logger">The logger to use.</param>
    /// <param name="config">The configuration to use.</param>
    /// <param name="progressService">the progress service to use</param>
    [ModConfiguration<Configuration>]
    public class TransformCOM(
        ILogger<TransformCOM> logger,
        IOptionsSnapshot<TransformCOM.Configuration> config,
        IProgressService progressService
    ) : Mod, IFunctionTransformer
    {
        /// <summary>
        /// The configuration for the <see cref="TransformCOM"/> mod.
        /// </summary>
        public class Configuration
        {
            /// <summary>
            /// The base type names and their full namespace definition to consider the base of the com tree
            /// Usually this is (IUnknown.Interface, Silk.NET.Windows.IUnknown.Interface)
            /// </summary>
            public Dictionary<string, string>? BaseTypes { get; init; }

            /// <summary>
            /// Additional Com Types and (namespace, parent type) which are not read in this job but referenced by it
            /// </summary>
            public IConfigurationSection[]? AdditionalCOMTypes { get; init; }
        }

        /// <inheritdoc />
        public override async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
        {
            await base.ExecuteAsync(ctx, ct);

            // Read the configuration.
            var cfg = config.Get(ctx.JobKey);
            var proj = ctx.SourceProject;

            if (proj is null)
            {
                return;
            }

            int count = proj?.DocumentIds.Count ?? 1;
            int index = 0;

            var baseTypes = cfg.BaseTypes ?? [];
            if (!baseTypes.ContainsKey("IUnknown.Interface"))
                baseTypes.Add("IUnknown.Interface", "Silk.NET.Core.IUnknown.Interface");

            progressService.SetTask("COM Object Discovery");
            var firstPass = new TypeDiscoverer(baseTypes, logger);

            firstPass.AddInitialType(
                "IInspectable.Interface",
                "Silk.NET.Core",
                "IUnknown.Interface"
            );
            firstPass.AddInitialType(
                "IClassFactory.Interface",
                "Silk.NET.Core",
                "IUnknown.Interface"
            );
            firstPass.AddInitialType(
                "AsyncIUnknown.Interface",
                "Silk.NET.Core",
                "IUnknown.Interface"
            );
            firstPass.AddInitialType("IUnknown.Interface", "Silk.NET.Core", "");

            foreach (var comType in cfg.AdditionalCOMTypes ?? [])
            {
                firstPass.AddInitialType(
                    comType.Key,
                    comType.GetValue<string>("Namespace") ?? "Silk.NET",
                    comType.GetValue<string>("Parent") ?? string.Empty
                );
            }

            Dictionary<string, PropertyDeclarationSyntax> IIDs = [];
            ImmutableArray<DocumentId> docsToRemove = [];
            foreach (var docId in proj?.DocumentIds ?? [])
            {
                index++;
                var doc =
                    proj?.GetDocument(docId)
                    ?? throw new InvalidOperationException("Document missing");
                if (await doc.GetSyntaxRootAsync(ct) is not { } root)
                {
                    continue;
                }

                if (doc.Name == "IID.gen.cs")
                {
                    var IIDList = root.DescendantNodes().OfType<PropertyDeclarationSyntax>().Where(prop => prop.Type is not PointerTypeSyntax);

                    foreach(PropertyDeclarationSyntax prop in IIDList)
                    {
                        IIDs.Add(prop.Identifier.Text, prop);
                    }
                    docsToRemove = docsToRemove.Add(docId);
                }
                else
                {
                    firstPass.Visit(root);
                }
                progressService.SetProgress((float)index / count);
            }
            proj = proj?.RemoveDocuments(docsToRemove);

            //Cleanup our lists
            firstPass.FoundCOMTypes = firstPass
                .FoundCOMTypes.Where(val => val.Value.Item1)
                .ToDictionary();

            index = 0;
            count = proj?.DocumentIds.Count ?? 1;
            var rewriter = new Rewriter(firstPass.FoundCOMTypes, IIDs);

            progressService.SetTask("COM Object Rewrite");
            foreach (var docId in proj?.DocumentIds ?? [])
            {
                index++;
                var doc =
                    proj?.GetDocument(docId)
                    ?? throw new InvalidOperationException("Document missing");
                if (await doc.GetSyntaxRootAsync(ct) is not { } root)
                {
                    continue;
                }

                doc = doc.WithSyntaxRoot(rewriter.Visit(root).NormalizeWhitespace());

                proj = doc.Project;

                logger.LogDebug("COM Rewrite for {0} Complete ({1}/{2})", doc.Name, index, count);
                progressService.SetProgress((float)index / count);
            }
            ctx.SourceProject = proj;

            proj = ctx.TestProject;
            index = 0;
            count = proj?.DocumentIds.Count ?? 1;
            progressService.SetTask("Finding and Removing IID Tests");

            docsToRemove = docsToRemove.Clear();
            foreach (var docId in proj?.DocumentIds ?? [])
            {
                index++;
                var doc =
                    proj?.GetDocument(docId)
                    ?? throw new InvalidOperationException("Document missing");

                if (doc.Name == "IIDTests.gen.cs")
                {
                    docsToRemove = docsToRemove.Add(docId);
                }

                progressService.SetProgress((float)index / count);
            }
            proj = proj?.RemoveDocuments(docsToRemove);

            progressService.SetProgress(1);
            ctx.TestProject = proj;
        }

        /// <inheritdoc/>
        public void Transform(
            MethodDeclarationSyntax current,
            ITransformationContext ctx,
            Action<MethodDeclarationSyntax> next
        )
        {
            //pass along the original method
            next(current);

            if (current.Modifiers.Any(mod => mod.IsKind(SyntaxKind.PublicKeyword)))
            {
                int guidPtrIndex = -1;
                int voidPtrIndex = -1;

                List<ParameterSyntax> paramList = [];
                List<ArgumentSyntax> argList = [];
                AssignmentExpressionSyntax? assignment = null;

                //look for guid and void ptr
                for (var i = 0; i < current.ParameterList.Parameters.Count; i++)
                {
                    var param = current.ParameterList.Parameters[i];

                    if (voidPtrIndex == -1)
                    {
                        if (param.Type?.ToString() == "Guid*")
                        {
                            guidPtrIndex = i;
                        }
                        else if (guidPtrIndex != -1 && param.Type?.ToString() == "void**")
                        {
                            voidPtrIndex = i;

                            paramList.RemoveAt(guidPtrIndex);
                            argList[guidPtrIndex] = Argument(
                                MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    IdentifierName("TCom"),
                                    IdentifierName("NativeGuid")
                                )
                            );

                            paramList.Add(
                                Parameter(
                                        param.AttributeLists,
                                        param.Modifiers,
                                        ParseTypeName("TCom"),
                                        param.Identifier,
                                        null
                                    )
                                    .AddModifiers(Token(SyntaxKind.OutKeyword))
                            );
                            argList.Add(
                                Argument(
                                    InvocationExpression(
                                        MemberAccessExpression(
                                            SyntaxKind.SimpleMemberAccessExpression,
                                            IdentifierName(param.Identifier),
                                            IdentifierName("GetAddressOf")
                                        )
                                    )
                                )
                            );
                            assignment = AssignmentExpression(
                                SyntaxKind.SimpleAssignmentExpression,
                                IdentifierName(param.Identifier),
                                LiteralExpression(SyntaxKind.DefaultLiteralExpression)
                            );
                            continue;
                        }
                    }
                    argList.Add(Argument(IdentifierName(param.Identifier.Text)));
                    paramList.Add(param);
                }

                //if we found an available method we will have an assignment and should include that
                if (assignment is not null)
                {
                    next(
                        current
                            .AddTypeParameterListParameters(TypeParameter("TCom"))
                            .AddConstraintClauses(
                                TypeParameterConstraintClause(
                                    IdentifierName("TCom"),
                                    SeparatedList<TypeParameterConstraintSyntax>(
                                        [
                                            TypeConstraint(IdentifierName("unmanaged")),
                                            TypeConstraint(IdentifierName("IComVtbl")),
                                        ]
                                    )
                                )
                            )
                            .WithParameterList(ParameterList(SeparatedList(paramList)))
                            .WithExpressionBody(null)
                            .WithSemicolonToken(Token(SyntaxKind.None))
                            .WithBody(
                                Block(
                                    ExpressionStatement(assignment),
                                    ReturnStatement(
                                        InvocationExpression(
                                            IdentifierName(current.Identifier),
                                            ArgumentList(SeparatedList(argList))
                                        )
                                    )
                                )
                            )
                    );
                }
            }
        }

        class TypeDiscoverer : CSharpSyntaxWalker
        {
            private Dictionary<string, List<(string, SimpleNameSyntax[],  bool, NameSyntax)>> _interfaceParenting = [];

            /// <summary>
            /// The list of known COM interface types
            /// (name of type, is it a struct?, InheritanceTree)
            /// </summary>
            public Dictionary<string, (bool, KeyedStringTree<QualifiedNameSyntax>?)> FoundCOMTypes = [];

            private readonly Dictionary<string, string> _baseTypes;
            private ILogger<TransformCOM> _logger;

            private List<SimpleNameSyntax> _ObjectNames = [];

            public TypeDiscoverer(
                Dictionary<string, string> BaseTypes,
                ILogger<TransformCOM> logger
            )
            {
                _logger = logger;
                _baseTypes = BaseTypes;
                InheritanceTrees = new KeyedStringTree<QualifiedNameSyntax>[_baseTypes.Count];

                int i = 0;
                foreach (var baseType in BaseTypes)
                {
                    string[] splitName = baseType.Value.Split('.');
                    QualifiedNameSyntax name = QualifiedName(IdentifierName(splitName[0]), IdentifierName(splitName[1]));
                    for (int j = 2; j < splitName.Length; j++)
                    {
                        name = QualifiedName(name, IdentifierName(splitName[j]));
                    }

                    InheritanceTrees[i] = new(baseType.Key, name);
                    i++;
                }
            }

            public KeyedStringTree<QualifiedNameSyntax>[] InheritanceTrees;

            public override void VisitStructDeclaration(StructDeclarationSyntax node)
            {
                _ObjectNames.Add(IdentifierName(node.Identifier.Text));
                base.VisitStructDeclaration(node);
                _ObjectNames.RemoveAt(_ObjectNames.Count - 1);

                if (node.Identifier.Text == "Native")
                    return;

                var bases = node.BaseList;

                var fields = node.Members.OfType<FieldDeclarationSyntax>();

                if (
                    bases is null
                    || fields.Any(fds =>
                        !fds.Modifiers.Contains(Token(SyntaxKind.StaticKeyword))
                        && fds.Declaration.Type.ToString() != "Native*"
                        && !fds.Declaration.Type.ToString().StartsWith("delegate")
                        && fds.Declaration.Variables[0].Identifier.Text.ToLower() != "lpvtbl"
                    )
                    || !fields.Any(fds =>
                        fds.Declaration.Type.ToString() == "Native*"
                        && fds.Declaration.Variables[0].Identifier.Text.ToLower() == "lpvtbl"
                    )
                )
                {
                    return;
                }

                COMTypeCheck(node.Identifier.Text, bases, node.NamespaceFromSyntaxNode());
            }

            public override void VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
            {
                base.VisitInterfaceDeclaration(node);

                var bases = node.BaseList;

                if (bases is null)
                {
                    return;
                }

                COMTypeCheck(node.Identifier.Text, bases, node.NamespaceFromSyntaxNode());
            }

            public void COMTypeCheck(string typeName, BaseListSyntax bases, string typeNamespace)
            {
                var types = new SimpleNameSyntax[_ObjectNames.Count + 1];
                _ObjectNames.CopyTo(types, 0);
                types[types.Length - 1] = IdentifierName(typeName);

                if (_ObjectNames.Count > 0)
                    typeName = $"{string.Join('.', _ObjectNames)}.{typeName}";

                var namespaces = typeNamespace.Split('.');
                NameSyntax qualifiedNamespace = IdentifierName(namespaces[0]);
                if (namespaces.Length > 1)
                {
                    for (int i = 1; i < namespaces.Length; i++)
                    {
                        qualifiedNamespace = QualifiedName(qualifiedNamespace, IdentifierName(namespaces[i]));
                    }
                }

                CheckBases((typeName, types, !typeName.EndsWith(".Interface"), qualifiedNamespace), bases);
            }

            public void AddInitialType(string typeName, string _namespace, string? parentName)
            {
                if (parentName is null)
                {
                    FoundCOMTypes.Add(typeName, (true, null));
                    return;
                }
                KeyedStringTree<QualifiedNameSyntax>? tree = null;

                foreach (var inheritanceTree in InheritanceTrees)
                {
                    if (
                        inheritanceTree.TryAddNode(parentName, typeName.ToString(), QualifiedName(IdentifierName(_namespace), IdentifierName(typeName)))
                    )
                    {
                        tree = inheritanceTree;
                        break;
                    }
                }

                string[] namespaces = _namespace.Split('.');
                NameSyntax qualifiedNamespace = IdentifierName(namespaces[0]);
                if (namespaces.Length > 1)
                {
                    for (int i = 1; i < namespaces.Length; i++)
                    {
                        qualifiedNamespace = QualifiedName(qualifiedNamespace, IdentifierName(namespaces[i]));
                    }
                }

                var types = typeName.Split('.').Select(type => (SimpleNameSyntax)IdentifierName(type)).ToArray();
                if (tree is not null)
                {
                    COMTypeValidated(typeName, types, (false, tree), parentName, qualifiedNamespace);
                    return;
                }

                if (!_interfaceParenting.ContainsKey(parentName))
                    _interfaceParenting.Add(parentName, new());

                _interfaceParenting[parentName].Add((typeName, types, false, qualifiedNamespace));
            }

            private void CheckBases((string, SimpleNameSyntax[], bool, NameSyntax) typeName, BaseListSyntax bases)
            {
                foreach (BaseTypeSyntax baseType in bases.Types)
                {
                    string type = baseType.Type.ToString();
                    bool found = false;

                    int i = 0;
                    foreach (var BaseType in _baseTypes)
                    {
                        if (BaseType.Key == type)
                        {
                            COMTypeValidated(
                                typeName.Item1,
                                typeName.Item2,
                                (typeName.Item3, InheritanceTrees[i]),
                                BaseType.Key,
                                typeName.Item4
                            );
                            found = true;
                            break;
                        }
                    }

                    if (found)
                        break;

                    if (FoundCOMTypes.TryGetValue(type, out var val))
                    {
                        COMTypeValidated(
                            typeName.Item1,
                            typeName.Item2,
                            (typeName.Item3, InheritanceTrees[i]),
                            type,
                            typeName.Item4
                        );
                        break;
                    }
                }

                foreach (BaseTypeSyntax baseType in bases.Types)
                {
                    string fullName = $"{baseType.Type}";
                    if (!_interfaceParenting.ContainsKey(fullName))
                        _interfaceParenting.Add(fullName, new());

                    _interfaceParenting[fullName].Add(typeName);
                }
            }

            private void COMTypeValidated(
                string typeName,
                SimpleNameSyntax[] types,
                (bool, KeyedStringTree<QualifiedNameSyntax>?) value,
                string parentName,
                NameSyntax _namespace
            )
            {
                if (FoundCOMTypes.ContainsKey(typeName))
                {
                    return;
                }

                FoundCOMTypes.Add(typeName, value);

                QualifiedNameSyntax fullTypeName = QualifiedName(_namespace, types[0]);

                for (int i = 1; i < types.Length; i++)
                    fullTypeName = QualifiedName(fullTypeName, types[i]);

                if (
                    !value.Item2?.TryAddNode(parentName, typeName, fullTypeName)
                    ?? true
                )
                {
                    _logger.LogWarning(
                        "Failed to add {} to its Inheritence tree, casts will not generate properly",
                        typeName
                    );
                }

                if (
                    !_interfaceParenting.TryGetValue(
                        typeName,
                        out List<(string, SimpleNameSyntax[], bool, NameSyntax)>? children
                    )
                )
                    return;

                foreach ((string, SimpleNameSyntax[], bool, NameSyntax) childName in children)
                {
                    COMTypeValidated(
                        childName.Item1,
                        childName.Item2,
                        (childName.Item3, value.Item2),
                        typeName,
                        childName.Item4
                    );
                }
            }
        }

        class Rewriter(Dictionary<string, (bool, KeyedStringTree<QualifiedNameSyntax>?)> ComTypes,
            Dictionary<string, PropertyDeclarationSyntax> IIDs) : CSharpSyntaxRewriter
        {
            bool isInCom = false;
            bool disposeFound = false;
            string currentName = string.Empty;
            string iidName = string.Empty;

            public override SyntaxNode? VisitStructDeclaration(StructDeclarationSyntax node)
            {
                string parentIID = iidName;
                iidName = string.Empty;
                string name = currentName = node.Identifier.ToString();
                bool parentIsCom = isInCom;

                if (
                    ComTypes.TryGetValue(name, out var Value)
                    && Value.Item2 is not null
                    && Value.Item2.FindNode(name, out KeyedStringTree<QualifiedNameSyntax>.Node? treeNode)
                    && treeNode.Parent is not null
                )
                {
                    bool parentDispose = disposeFound;
                    isInCom = true;
                    disposeFound = false;
                    //visit and modify ComType Variables and internal usages first
                    node = (base.VisitStructDeclaration(node) as StructDeclarationSyntax)!;
                    node = node.AddBaseListTypes(SimpleBaseType(ParseTypeName("IDisposable")));

                    if (IIDs.ContainsKey(iidName))
                        node = node.AddMembers(IIDs[iidName].WithIdentifier(Identifier("IID")));

                    if (!disposeFound)
                    {
                        node = node.AddMembers(
                                MethodDeclaration(ParseTypeName("void"), "Dispose")
                                    .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                                    .WithExpressionBody(
                                        ArrowExpressionClause(
                                            InvocationExpression(IdentifierName("Release"))
                                        )
                                    )
                                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                            )
                            .WithLeadingTrivia(
                                Trivia(
                                    DocumentationCommentTrivia(
                                        SyntaxKind.SingleLineDocumentationCommentTrivia,
                                        List(
                                            new XmlNodeSyntax[]
                                            {
                                                XmlText("/// "),
                                                XmlElement(
                                                    XmlElementStartTag(XmlName("inheritdoc"))
                                                        .WithAttributes(
                                                            SingletonList<XmlAttributeSyntax>(
                                                                XmlCrefAttribute(
                                                                    NameMemberCref(
                                                                        IdentifierName(
                                                                            "IDisposable.Dispose"
                                                                        )
                                                                    )
                                                                )
                                                            )
                                                        ),
                                                    XmlElementEndTag(XmlName("inheritdoc"))
                                                ),
                                                XmlText("\n\t"),
                                            }
                                        )
                                    )
                                )
                            );
                    }

                    node = node.AddMembers(
                        MethodDeclaration(
                                GenericName("Ptr2D")
                                    .WithTypeArgumentList(
                                        TypeArgumentList(
                                            SingletonSeparatedList(
                                                ParseTypeName("TNativeInterface")
                                            )
                                        )
                                    ),
                                "GetAddressOf"
                            )
                            .WithModifiers(
                                TokenList(
                                    Token(SyntaxKind.PublicKeyword),
                                    Token(SyntaxKind.ReadOnlyKeyword)
                                )
                            )
                            .WithTypeParameterList(
                                TypeParameterList(
                                    SingletonSeparatedList(TypeParameter("TNativeInterface"))
                                )
                            )
                            .WithConstraintClauses(
                                List(
                                    [
                                        TypeParameterConstraintClause(
                                            IdentifierName("TNativeInterface"),
                                            SingletonSeparatedList<TypeParameterConstraintSyntax>(
                                                TypeConstraint(IdentifierName("unmanaged"))
                                            )
                                        ),
                                    ]
                                )
                            )
                            .WithExpressionBody(
                                ArrowExpressionClause(
                                    CastExpression(
                                        PointerType(PointerType(ParseTypeName("TNativeInterface"))),
                                        InvocationExpression(
                                            MemberAccessExpression(
                                                SyntaxKind.SimpleMemberAccessExpression,
                                                IdentifierName("Unsafe"),
                                                IdentifierName("AsPointer")
                                            ),
                                            ArgumentList(
                                                SingletonSeparatedList(
                                                    Argument(
                                                        RefExpression(
                                                            InvocationExpression(
                                                                MemberAccessExpression(
                                                                    SyntaxKind.SimpleMemberAccessExpression,
                                                                    IdentifierName("Unsafe"),
                                                                    IdentifierName("AsRef")
                                                                ),
                                                                ArgumentList(
                                                                    SingletonSeparatedList(
                                                                        Argument(ThisExpression())
                                                                            .WithRefKindKeyword(
                                                                                Token(
                                                                                    SyntaxKind.InKeyword
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
                                )
                            )
                            .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                            .WithLeadingTrivia(
                                Trivia(
                                    DocumentationCommentTrivia(
                                        SyntaxKind.SingleLineDocumentationCommentTrivia,
                                        List(
                                            new XmlNodeSyntax[]
                                            {
                                                XmlText("/// "),
                                                XmlElement(
                                                    XmlElementStartTag(XmlName("inheritdoc"))
                                                        .WithAttributes(
                                                            SingletonList<XmlAttributeSyntax>(
                                                                XmlCrefAttribute(
                                                                    NameMemberCref(
                                                                        IdentifierName(
                                                                            "IComVtbl.GetAddressOf{TNativeInterface}()"
                                                                        )
                                                                    )
                                                                )
                                                            )
                                                        ),
                                                    XmlElementEndTag(XmlName("inheritdoc"))
                                                ),
                                                XmlText("\n\t"),
                                            }
                                        )
                                    )
                                )
                            ),
                        MethodDeclaration(ParseTypeName("Ptr2D"), "GetAddressOf")
                            .WithModifiers(
                                TokenList(
                                    Token(SyntaxKind.PublicKeyword),
                                    Token(SyntaxKind.ReadOnlyKeyword)
                                )
                            )
                            .WithExpressionBody(
                                ArrowExpressionClause(
                                    CastExpression(
                                        PointerType(PointerType(ParseTypeName("void"))),
                                        InvocationExpression(
                                            MemberAccessExpression(
                                                SyntaxKind.SimpleMemberAccessExpression,
                                                IdentifierName("Unsafe"),
                                                IdentifierName("AsPointer")
                                            ),
                                            ArgumentList(
                                                SingletonSeparatedList(
                                                    Argument(
                                                        RefExpression(
                                                            InvocationExpression(
                                                                MemberAccessExpression(
                                                                    SyntaxKind.SimpleMemberAccessExpression,
                                                                    IdentifierName("Unsafe"),
                                                                    IdentifierName("AsRef")
                                                                ),
                                                                ArgumentList(
                                                                    SingletonSeparatedList(
                                                                        Argument(ThisExpression())
                                                                            .WithRefKindKeyword(
                                                                                Token(
                                                                                    SyntaxKind.InKeyword
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
                                )
                            )
                            .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                            .WithLeadingTrivia(
                                Trivia(
                                    DocumentationCommentTrivia(
                                        SyntaxKind.SingleLineDocumentationCommentTrivia,
                                        List(
                                            new XmlNodeSyntax[]
                                            {
                                                XmlText("/// "),
                                                XmlElement(
                                                    XmlElementStartTag(XmlName("inheritdoc"))
                                                        .WithAttributes(
                                                            SingletonList<XmlAttributeSyntax>(
                                                                XmlCrefAttribute(
                                                                    NameMemberCref(
                                                                        IdentifierName(
                                                                            "IComVtbl.GetAddressOf()"
                                                                        )
                                                                    )
                                                                )
                                                            )
                                                        ),
                                                    XmlElementEndTag(XmlName("inheritdoc"))
                                                ),
                                                XmlText("\n\t"),
                                            }
                                        )
                                    )
                                )
                            )
                    );

                    //Correct to the .Interface version which will always be our parent
                    treeNode = treeNode.Parent;

                    if (treeNode.Parent is not null)
                    {
                        node = generateUpcasts(node, IdentifierName(name), treeNode.Parent);
                    }

                    disposeFound = parentDispose;
                }
                else
                {
                    isInCom = false;
                    node = (base.VisitStructDeclaration(node) as StructDeclarationSyntax)!;
                }

                isInCom = parentIsCom;
                iidName = parentIID;

                return node;
            }

            public override SyntaxNode? VisitSimpleBaseType(SimpleBaseTypeSyntax node)
            {
                return isInCom && node.Type.ToString() == "INativeGuid"
                    ? SimpleBaseType(ParseTypeName($"IComVtbl<{currentName}>"))
                    : base.VisitSimpleBaseType(node);
            }

            public override SyntaxNode? VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
            {
                if (node.Expression.ToString() == "IID" && IIDs.ContainsKey(node.Name.ToString()))
                {
                    iidName = node.Name.ToString();
                    return IdentifierName("IID");
                }
                return base.VisitMemberAccessExpression(node);
            }

            public override SyntaxNode? VisitFieldDeclaration(FieldDeclarationSyntax node)
            {
                if (node.Declaration.Type.ToString() == "HResult" && node.Modifiers.Any(modifier => modifier.IsKind(SyntaxKind.ConstKeyword)))
                {
                    return base.VisitPropertyDeclaration(PropertyDeclaration(node.Declaration.Type, node.Declaration.Variables.First().Identifier)
                        .WithLeadingTrivia(node.GetLeadingTrivia())
                        .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.StaticKeyword)))
                        .WithExpressionBody(ArrowExpressionClause(node.Declaration.Variables.First().Initializer!.Value)).WithSemicolonToken(Token(SyntaxKind.SemicolonToken)));
                }
                return base.VisitFieldDeclaration(node);
            }

            public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node)
            {
                if (
                    isInCom
                    && node.Identifier.Text == "Dispose"
                    && node.ParameterList.Parameters.Count == 0
                )
                {
                    if (node.ExpressionBody is not null)
                    {
                        node = node.WithBody(
                                Block(
                                    ExpressionStatement(node.ExpressionBody.Expression),
                                    ExpressionStatement(
                                        InvocationExpression(IdentifierName("Release"))
                                    )
                                )
                            )
                            .WithExpressionBody(null);
                    }
                    else if (node.Body is not null)
                    {
                        node = node.WithBody(
                            Block(
                                node.Body.Statements.Append(
                                    ExpressionStatement(
                                        InvocationExpression(IdentifierName("Release"))
                                    )
                                )
                            )
                        );
                    }

                    node = node.WithLeadingTrivia(
                        Trivia(
                            DocumentationCommentTrivia(
                                SyntaxKind.SingleLineDocumentationCommentTrivia,
                                List(
                                    new XmlNodeSyntax[]
                                    {
                                        XmlText("/// "),
                                        XmlElement(
                                            XmlElementStartTag(XmlName("inheritdoc"))
                                                .WithAttributes(
                                                    SingletonList<XmlAttributeSyntax>(
                                                        XmlCrefAttribute(
                                                            NameMemberCref(
                                                                IdentifierName(
                                                                    "IDisposable.Dispose"
                                                                )
                                                            )
                                                        )
                                                    )
                                                ),
                                            XmlElementEndTag(XmlName("inheritdoc"))
                                        ),
                                        XmlText("\n\t"),
                                    }
                                )
                            )
                        )
                    );
                }

                return base.VisitMethodDeclaration(node);
            }

            private StructDeclarationSyntax generateUpcasts(
                StructDeclarationSyntax node,
                NameSyntax className,
                KeyedStringTree<QualifiedNameSyntax>.Node treeNode
            )
            {
                NameSyntax castName = InterfaceNameToStructName(treeNode.Value);

                node = node.AddMembers(GenerateCastDefinition(className, castName, false));
                node = node.AddMembers(GenerateCastDefinition(castName, className));

                if (treeNode.Parent is not null)
                {
                    return generateUpcasts(node, className, treeNode.Parent);
                }

                return node;
            }

            private NameSyntax InterfaceNameToStructName(QualifiedNameSyntax interfaceName) =>
                interfaceName.Right.ToString() == "Interface"
                    ? interfaceName.Left
                    : interfaceName;

            private ConversionOperatorDeclarationSyntax GenerateCastDefinition(
                NameSyntax className,
                NameSyntax castName,
                bool implicitCast = true
            )
            {
                return ConversionOperatorDeclaration(
                        Token(
                            implicitCast ? SyntaxKind.ImplicitKeyword : SyntaxKind.ExplicitKeyword
                        ),
                        className
                    )
                    .WithModifiers(
                        TokenList(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.StaticKeyword))
                    )
                    .WithParameterList(
                        ParameterList(
                            SingletonSeparatedList(
                                Parameter(Identifier("value")).WithType(castName)
                            )
                        )
                    )
                    .WithExpressionBody(
                        ArrowExpressionClause(
                            ObjectCreationExpression(className)
                                .WithArgumentList(
                                    ArgumentList(
                                        SingletonSeparatedList(
                                            Argument(
                                                CastExpression(
                                                    GenericName(Identifier("Ptr"), TypeArgumentList(SingletonSeparatedList<TypeSyntax>(QualifiedName(className, IdentifierName("Native"))))),
                                                    MemberAccessExpression(
                                                        SyntaxKind.SimpleMemberAccessExpression,
                                                        IdentifierName("value"),
                                                        IdentifierName("LpVtbl")
                                                    )
                                                )
                                            )
                                        )
                                    )
                                )
                        )
                    )
                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                    .WithLeadingTrivia(
                        TriviaList(
                            Trivia(
                                DocumentationCommentTrivia(
                                        SyntaxKind.SingleLineDocumentationCommentTrivia
                                    )
                                    .WithContent(
                                        List(
                                            new XmlNodeSyntax[]
                                            {
                                                XmlText()
                                                    .WithTextTokens(
                                                        TokenList(
                                                            XmlTextLiteral(
                                                                TriviaList(
                                                                    DocumentationCommentExterior(
                                                                        "/// "
                                                                    )
                                                                ),
                                                                " ",
                                                                " ",
                                                                TriviaList()
                                                            )
                                                        )
                                                    ),
                                                XmlElement(
                                                    XmlElementStartTag(XmlName("summary")),
                                                    List(
                                                        new XmlNodeSyntax[]
                                                        {
                                                            XmlText(
                                                                $"{(implicitCast ? "Up" : "Down")}casts "
                                                            ),
                                                            XmlEmptyElement(
                                                                XmlName("see"),
                                                                List<XmlAttributeSyntax>(
                                                                    new[]
                                                                    {
                                                                        XmlCrefAttribute(
                                                                            NameMemberCref(
                                                                                castName
                                                                            )
                                                                        ),
                                                                    }
                                                                )
                                                            ),
                                                            XmlText(" to "),
                                                            XmlEmptyElement(
                                                                XmlName("see"),
                                                                List<XmlAttributeSyntax>(
                                                                    new[]
                                                                    {
                                                                        XmlCrefAttribute(
                                                                            NameMemberCref(
                                                                                className
                                                                            )
                                                                        ),
                                                                    }
                                                                )
                                                            ),
                                                            XmlText("."),
                                                        }
                                                    ),
                                                    XmlElementEndTag(XmlName("summary"))
                                                ),
                                                XmlText()
                                                    .WithTextTokens(
                                                        TokenList(
                                                            XmlTextNewLine(
                                                                TriviaList(),
                                                                "\n",
                                                                "\n",
                                                                TriviaList()
                                                            )
                                                        )
                                                    ),
                                                XmlText()
                                                    .WithTextTokens(
                                                        TokenList(
                                                            XmlTextLiteral(
                                                                TriviaList(
                                                                    DocumentationCommentExterior(
                                                                        "/// "
                                                                    )
                                                                ),
                                                                " ",
                                                                " ",
                                                                TriviaList()
                                                            )
                                                        )
                                                    ),
                                                XmlElement(
                                                    XmlElementStartTag(XmlName("param"))
                                                        .WithAttributes(
                                                            SingletonList<XmlAttributeSyntax>(
                                                                XmlNameAttribute(
                                                                    XmlName("name"),
                                                                    Token(
                                                                        SyntaxKind.DoubleQuoteToken
                                                                    ),
                                                                    IdentifierName("value"),
                                                                    Token(
                                                                        SyntaxKind.DoubleQuoteToken
                                                                    )
                                                                )
                                                            )
                                                        ),
                                                    List(
                                                        new XmlNodeSyntax[]
                                                        {
                                                            XmlText("The "),
                                                            XmlEmptyElement(
                                                                XmlName("see"),
                                                                List<XmlAttributeSyntax>(
                                                                    new[]
                                                                    {
                                                                        XmlCrefAttribute(
                                                                            NameMemberCref(
                                                                                castName
                                                                            )
                                                                        ),
                                                                    }
                                                                )
                                                            ),
                                                            XmlText(" instance to be converted "),
                                                        }
                                                    ),
                                                    XmlElementEndTag(XmlName("param"))
                                                ),
                                                XmlText()
                                                    .WithTextTokens(
                                                        TokenList(
                                                            XmlTextNewLine(
                                                                TriviaList(),
                                                                "\n",
                                                                "\n",
                                                                TriviaList()
                                                            )
                                                        )
                                                    ),
                                            }
                                        )
                                    )
                            )
                        )
                    );
            }
        }
    }
}
