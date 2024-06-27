// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Options;
using Microsoft.VisualBasic;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Naming;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods
{
    /// <summary>
    /// A mod to modify COM interface structs into opaque structs that act like ComPtr objects
    /// </summary>
    [ModConfiguration<Config>]
    public class AddOpaqueCOM : Mod
    {
        /// <summary>
        /// The configuration for the <see cref="AddOpaqueCOM"/> mod.
        /// </summary>
        public class Config
        {

        }

        /// <inheritdoc />
        public override Task<GeneratedSyntax> AfterScrapeAsync(string key, GeneratedSyntax syntax)
        {
            var firstPass = new TypeDiscoverer();
            foreach (var (_, node) in syntax.Files)
            {
                firstPass.Visit(node);
            }

            List<(string, bool)> COMTypes = firstPass.FoundCOMTypes;


            var rewriter = new Rewriter(COMTypes);
            syntax = syntax with {
                Files = syntax.Files.ToDictionary(
                    x => {
                        var effectiveName = ModUtils.GetEffectiveName(x.Key).ToString();
                        if (!COMTypes.Any(val => val.Item1 == effectiveName))
                        {
                            return x.Key;
                        }

                        syntax.Files.Remove(x.Key);
                        return x.Key.Replace(effectiveName, $"{effectiveName.Substring(1)}");
                    },
                    x => rewriter.Visit(x.Value)
                )
            };

            return Task.FromResult(syntax);
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
            /// <summary>
            /// The current scope i.e. fully qualified type name.
            /// </summary>
            private string _currentScope = string.Empty;

            //private bool _isPointerType;
            //private bool _derefPtr;

            private string GetNewName(string comName)
            {
                return comName.Substring(1);
            }

            private SyntaxNode? VisitType<T>(T type, SyntaxToken identifier, Func<T, SyntaxNode?> @base)
                where T : SyntaxNode
            {
                var before = _currentScope;
                _currentScope = string.IsNullOrWhiteSpace(_currentScope)
                    ? $"{type.NamespaceFromSyntaxNode()}.{identifier}"
                    : $"{_currentScope}.{identifier}";
                var ret = @base(type);
                _currentScope = before;
                return ret;
            }

            public override SyntaxNode? VisitPointerType(PointerTypeSyntax node)
            {
                for (int i = 0; i < ComTypes.Count; i++)
                {
                    (string, bool) val = ComTypes[i];
                    if (val.Item1 == node.ElementType.ToString() && val.Item2)
                    {
                        return IdentifierName(GetNewName(val.Item1));
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

            public override SyntaxNode? VisitStructDeclaration(StructDeclarationSyntax node)
            {
                var ret = base.VisitStructDeclaration(node);

                var structDecl = ret as StructDeclarationSyntax;

                if (structDecl is null)
                {
                    return ret;
                }

                var name = structDecl.Identifier.ToString();
                for (int i = 0; i < ComTypes.Count; i++)
                {
                    (string, bool) val = ComTypes[i];
                    if (name == val.Item1 && val.Item2)
                    {
                        return structDecl.WithIdentifier(Identifier(GetNewName(val.Item1)));
                    }
                }

                return ret;
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
