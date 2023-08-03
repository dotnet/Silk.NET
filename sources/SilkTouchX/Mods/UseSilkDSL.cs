using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace SilkTouchX.Mods;

/// <summary>
/// Mods the bindings to use the Silk.NET.Core pointer types.
/// </summary>
public class UseSilkDSL : IMod
{
    class Rewriter : CSharpSyntaxRewriter
    {
        private HashSet<string>? _parameterIdentifiers = null;
        private bool _doReplacement = false;
        private bool _returnTypeReplaceable = false;

        public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            Debug.Assert(!_returnTypeReplaceable);
            Debug.Assert(_parameterIdentifiers is null);

            // Make sure the function either has a body or is an extern function
            var consider = node.Body is not null || node.Modifiers.Any(x => x.IsKind(SyntaxKind.ExternKeyword));
            if (!consider)
            {
                return base.VisitMethodDeclaration(node);
            }

            // Get the list of DSL applicable parameters
            var paramsToChange = node.ParameterList.Parameters
                .Where(x => x.Type is not null && IsDSLApplicable(x.Type))
                .ToArray();
            _parameterIdentifiers = paramsToChange.Select(x => x.Identifier.ToString()).ToHashSet();
            _returnTypeReplaceable = IsDSLApplicable(node.ReturnType);

            // VisitParameter and VisitIdentifierName will change the parameter types and replace any references of
            // the parameter with the "inner identifier" - the name of the variable yielded from the fixed statement
            // that we're yet to generate.
            if (base.VisitMethodDeclaration(node) is not MethodDeclarationSyntax methWithReplacementsButNoFixed)
            {
                return null;
            }

            // If we didn't do any replacements and aren't doing anything to the return type, don't do anything
            if (paramsToChange.Length == 0 && !_returnTypeReplaceable)
            {
                return methWithReplacementsButNoFixed;
            }

            // If body is null, it would only be because the original body was null which must've meant we passed the
            // "extern" check when determining whether to consider this function, ergo we need to make a P/Invoke
            // wrapper.
            var hasRet = node.ReturnType.IsEquivalentTo(PredefinedType(Token(SyntaxKind.VoidKeyword)));
            var body = (StatementSyntax?)methWithReplacementsButNoFixed.Body;
            if (body is null)
            {
                var ident = IdentToPInvokeIdent(node.Identifier);
                // Declare the P/Invoke function
                var fun = LocalFunctionStatement(
                    node.AttributeLists,
                    TokenList(node.Modifiers.Where(x => x.Kind() switch {
                        SyntaxKind.PublicKeyword or SyntaxKind.PrivateKeyword or SyntaxKind.InternalKeyword
                            or SyntaxKind.ProtectedKeyword => true,
                        _ => false
                    })), node.ReturnType, ident, TypeParameterList(),
                    node.ParameterList, List<TypeParameterConstraintClauseSyntax>(), node.Body,
                    node.ExpressionBody);

                // Call the P/Invoke function with the converted values
                var inv = InvocationExpression(IdentifierName(ident),
                    ArgumentList(SeparatedList(node.ParameterList.Parameters.Select(x =>
                        Argument(IdentifierName(x.Type is not null && IsDSLApplicable(x.Type)
                            ? IdentToInnerIdent(x.Identifier)
                            : x.Identifier))))));
                body = Block(fun, hasRet ? ReturnStatement(inv) : ExpressionStatement(inv));
            }

            // Convert expression bodies to statement bodies
            if (body is ExpressionStatementSyntax expr)
            {
                body = Block(hasRet ? ExpressionStatement(expr.Expression) : ReturnStatement(expr.Expression));
            }

            // Generate the fixed blocks for the "inner idents"
            Debug.Assert(body is BlockSyntax);
            foreach (var param in paramsToChange)
            {
                Debug.Assert(param.Type is not null);
                body = Block(FixedStatement(
                    VariableDeclaration(param.Type,
                        SingletonSeparatedList(VariableDeclarator(IdentToInnerIdent(param.Identifier))
                            .WithInitializer(EqualsValueClause(IdentifierName(param.Identifier))))), body));
            }

            // Need to check on the return type, but assume that there's an implicit conversion in the DSL
            if (_returnTypeReplaceable)
            {
                _returnTypeReplaceable = false;
                methWithReplacementsButNoFixed =
                    methWithReplacementsButNoFixed.WithReturnType(GetDSLType(node.ReturnType, node.AttributeLists,
                        SyntaxKind.ReturnKeyword));
            }

            return methWithReplacementsButNoFixed.WithBody((BlockSyntax)body);
        }

        public override SyntaxNode? VisitParameter(ParameterSyntax node)
        {
            Debug.Assert(!_doReplacement);
            var ret = base.VisitParameter(node) as ParameterSyntax;
            if (_doReplacement && ret is { Type: not null })
            {
                _doReplacement = false;
                return ret.WithType(GetDSLType(ret.Type, node.AttributeLists, null));
            }

            return ret;
        }

        public override SyntaxNode? VisitIdentifierName(IdentifierNameSyntax node)
        {
            var ret = base.VisitIdentifierName(node) as IdentifierNameSyntax;
            if (ret is null)
            {
                return ret;
            }

            if (!(_parameterIdentifiers?.Contains(node.Identifier.ToString()) ?? false))
            {
                return ret;
            }

            if (node.Parent is not ParameterSyntax)
            {
                return IdentifierName(IdentToInnerIdent(ret.Identifier)).WithTriviaFrom(ret);
            }

            _doReplacement = true;
            return ret;
        }

        public override SyntaxNode? VisitAttribute(AttributeSyntax node)
        {
            if ((_parameterIdentifiers?.Count).GetValueOrDefault() == 0 && !_returnTypeReplaceable)
            {
                return base.VisitAttribute(node);
            }

            var sep = node.Name.ToString().Split("::")[1];
            return sep == "DllImport" || sep == "DllImportAttribute" ||
                   sep.EndsWith("System.Runtime.InteropServices.DllImport") ||
                   sep.EndsWith("System.Runtime.InteropServices.DllImportAttribute")
                ? null // Remove the attribute as it is being moved to a local function
                : base.VisitAttribute(node);
        }

        private static SyntaxToken IdentToInnerIdent(SyntaxToken token)
        {
            Debug.Assert(token.IsKind(SyntaxKind.IdentifierToken));
            return Identifier($"__dsl_{token}");
        }

        private static SyntaxToken IdentToPInvokeIdent(SyntaxToken token)
        {
            Debug.Assert(token.IsKind(SyntaxKind.IdentifierToken));
            return Identifier($"__DSL_{token}");
        }


        private static bool IsDSLApplicable(TypeSyntax syn) => syn is PointerTypeSyntax;

        private static TypeSyntax GetDSLType(TypeSyntax syntax, IEnumerable<AttributeListSyntax?>? attrLists, SyntaxKind? target)
        {
            var indirectionLevels = 0;
            while (syntax is PointerTypeSyntax inner)
            {
                indirectionLevels++;
                syntax = inner.ElementType;
            }

            if (indirectionLevels > 2)
            {
                throw new ArgumentOutOfRangeException(nameof(syntax),
                    "Indirection levels greater than 2 are currently unsupported by SilkDSL.");
            }

            var isConst = false;
            if (attrLists is not null)
            {
                foreach (var attrs in attrLists)
                {
                    if (attrs is null ||
                        (target is not null && !(attrs.Target?.Identifier.IsKind(target.Value)).GetValueOrDefault()) ||
                        (target is null && attrs.Target is not null))
                    {
                        continue;
                    }
                    foreach (var attributeSyntax in attrs.Attributes)
                    {
                        if (attributeSyntax.Name.ToString() == "NativeTypeName" &&
                            attributeSyntax.ArgumentList?.Arguments.FirstOrDefault()?.Expression is
                                LiteralExpressionSyntax lit && lit.Token.ToString().StartsWith("const "))
                        {
                            isConst = true;
                        }
                    }
                }
            }

            return GenericName(Identifier(isConst switch {
                true when indirectionLevels > 1 => $"ConstPtr{indirectionLevels}D",
                true => "ConstPtr",
                false when indirectionLevels > 1 => $"Ptr{indirectionLevels}D",
                false => "Ptr"
            })).WithTypeArgumentList(TypeArgumentList(SingletonSeparatedList(syntax)));
        }
    }
}
