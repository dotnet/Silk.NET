// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.FindSymbols;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods
{
    /// <summary>
    /// A mod to modify COM interface structs into opaque structs that act like ComPtr objects
    /// </summary>
    [ModConfiguration<Config>]
    public class TransformCOM : Mod
    {
        /// <summary>
        /// The configuration for the <see cref="TransformCOM"/> mod.
        /// </summary>
        public class Config
        {

        }

        /// <inheritdoc />
        public override async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
        {
            await base.ExecuteAsync(ctx, ct);

            var firstPass = new TypeDiscoverer();
            var proj = ctx.SourceProject;
            if (proj is null)
            {
                return;
            }
            Compilation? comp = await proj.GetCompilationAsync();
            IEnumerable<ISymbol>? unknowns = comp?.GetSymbolsWithName("IUnknown");
            //foreach (var doc in ctx.SourceProject?.Documents ?? [])
            //{
            //    if (await doc.GetSyntaxRootAsync(ct) is { } root)
            //    {
            //        firstPass.Visit(root);
            //    }
            //}

            if (unknowns is null || unknowns.Count() == 0)
            {
                return;
            }

            IEnumerable<ISymbol>? symbols = await SymbolFinder.FindImplementationsAsync(unknowns.First(), proj.Solution, [proj], ct);
            
            List<(string, bool)> COMTypes = firstPass.FoundCOMTypes;

            Dictionary<string, CompilationUnitSyntax> duplicates = new();

            var rewriter = new Rewriter(COMTypes);
            foreach (var docId in proj?.DocumentIds ?? [])
            {
                var doc =
                    proj?.GetDocument(docId) ?? throw new InvalidOperationException("Document missing");
                if (await doc.GetSyntaxRootAsync(ct) is not { } root)
                {
                    continue;
                }

                doc = doc.WithSyntaxRoot(rewriter.Visit(root).NormalizeWhitespace());

                proj = doc.Project;
            }

            ctx.SourceProject = proj;
        }

        class TypeDiscoverer : CSharpSyntaxWalker
        {
            private Dictionary<string, List<(string, bool)>> _interfaceParenting = new Dictionary<string, List<(string, bool)>>();

            /// <summary>
            /// The list of known COM interface types
            /// (name of type, is it a struct?)
            /// </summary>
            public List<(string, bool)> FoundCOMTypes = [];

            public override void VisitStructDeclaration(StructDeclarationSyntax node)
            {
                base.VisitStructDeclaration(node);

                var bases = node.BaseList;

                if (bases is null)
                {
                    return;
                }

                var className = $"{node.Identifier}";

                CheckBases((className, true), bases);
            }


            public override void VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
            {
                base.VisitInterfaceDeclaration(node);

                var bases = node.BaseList;

                if (bases is null)
                {
                    return;
                }

                string name = $"{node.Identifier}";
                if (name == "Interface")
                {
                    var parent = node.Parent as StructDeclarationSyntax;
                    if (parent is not null)
                        name = $"{parent.Identifier}.{name}";
                }

                CheckBases((name, false), bases);
            }

            private void CheckBases((string, bool) className, BaseListSyntax bases)
            {
                if (bases.Types.Any(baseType => baseType.Type.ToString() == "IUnknown.Interface" || FoundCOMTypes.Any(val => val.Item1 == $"{baseType.Type}")))
                {
                    COMTypeValidated(className);
                    return;
                }

                foreach (BaseTypeSyntax baseType in bases.Types)
                {
                    string fullName = $"{baseType.Type}";
                    if (!_interfaceParenting.ContainsKey(fullName))
                        _interfaceParenting.Add(fullName, new());

                    _interfaceParenting[fullName].Add(className);
                }
            }

            private void COMTypeValidated((string, bool) typeName)
            {
                if (FoundCOMTypes.Contains(typeName))
                {
                    return;
                }

                FoundCOMTypes.Add(typeName);

                if (!_interfaceParenting.TryGetValue(typeName.Item1, out List<(string, bool)>? children))
                    return;

                foreach ((string, bool) childName in children)
                {
                    COMTypeValidated(childName);
                }
            }
        }

        class Rewriter(List<(string, bool)> ComTypes)
            : CSharpSyntaxRewriter
        {
            public override SyntaxNode? VisitPointerType(PointerTypeSyntax node)
            {
                for (int i = 0; i < ComTypes.Count; i++)
                {
                    (string, bool) val = ComTypes[i];
                    if (val.Item1 == node.ElementType.ToString() && val.Item2)
                    {
                        return IdentifierName(val.Item1);
                    }
                }

                return base.VisitPointerType(node);
            }

            public override SyntaxNode VisitGenericName(GenericNameSyntax node) => node;

            public override SyntaxNode? VisitIdentifierName(IdentifierNameSyntax node)
            {
                if (node.Identifier.ToString() == "lpVtbl")
                {
                    return ParenthesizedExpression(PrefixUnaryExpression(SyntaxKind.PointerIndirectionExpression, node));
                }

                return base.VisitIdentifierName(node);
            }

            public override SyntaxNode? VisitVariableDeclaration(VariableDeclarationSyntax node)
            {
                if (node.Type.ToString() == "void**" && node.Variables.First().Identifier.ToString() == "lpVtbl")
                {
                    return VariableDeclaration(PointerType(PointerType(PointerType(IdentifierName("void")))))
                        .AddVariables(VariableDeclarator("lpVtbl"));
                }

                return base.VisitVariableDeclaration(node);
            }

            public override SyntaxNode? VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
            {
                var ret = base.VisitInterfaceDeclaration(node);



                if (ret is InterfaceDeclarationSyntax inter && inter.BaseList is not null && inter.BaseList.Types.Any(baseType => baseType.Type.ToString().StartsWith("I") && baseType.Type.ToString().EndsWith(".Interface")))
                {
                    List<BaseTypeSyntax> baseTypes = [];
                    foreach (BaseTypeSyntax baseType in inter.BaseList.Types)
                    {
                        if (ComTypes.Any(com => $"{com.Item1}.Interface" == baseType.Type.ToString()))
                        {
                            baseTypes.Add(SimpleBaseType(IdentifierName(baseType.Type.ToString())));
                        }
                        else
                        {
                            baseTypes.Add(baseType);
                        }
                    }

                    ret = inter.WithBaseList(BaseList(SeparatedList(baseTypes)));
                }

                return ret;
            }

            public override SyntaxNode? VisitCastExpression(CastExpressionSyntax node)
            {
                var castType = node.Type.ToString();

                var expression = node.Expression.ToString();

                if (expression != "Unsafe.AsPointer(ref this)")
                {
                    return base.VisitCastExpression(node);
                }

                for (int i = 0; i < ComTypes.Count; i++)
                {
                    (string, bool) val = ComTypes[i];
                    if (castType == $"{val.Item1}*" && val.Item2)
                    {
                        return ThisExpression();
                    }
                }

                return base.VisitCastExpression(node);
            }
        }
    }
}
