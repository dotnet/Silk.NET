// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using GenericMathsGenerator.ValueTypes;
using GenericMathsGenerator.VariableTypes;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.Text;
using Priority_Queue;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace GenericMathsGenerator
{
    [Generator]
    public class Generator : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context)
        {
            context.RegisterForSyntaxNotifications(() => new SyntaxReceiver());
        }

        public void Execute(GeneratorExecutionContext context)
        {
            try
            {
                context.AddSource
                (
                    "attribute", SourceText.From
                    (
                        @"
using System;

namespace GenericMaths
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Struct)]
    public class GenericMathsAttribute : Attribute
    {
        
    }
}
", Encoding.UTF8
                    )
                );

                if (!(context.SyntaxReceiver is SyntaxReceiver sr))
                    return;

                var methods = sr.Methods.Select
                    (
                        x => (x,
                            ModelExtensions.GetDeclaredSymbol
                                (context.Compilation.GetSemanticModel(x.SyntaxTree), x) as IMethodSymbol)
                    )
                    .Select
                    (
                        x => (x.x, x.Item2,
                            x.Item2.GetAttributes().FirstOrDefault(x2 => x2.AttributeClass.Name == "GenericMaths"))
                    )
                    .Where(att => att.Item3 is not null)
                    .ToArray();
                
                var types = sr.Types.Select
                    (
                        x => (x,
                            ModelExtensions.GetDeclaredSymbol
                                (context.Compilation.GetSemanticModel(x.SyntaxTree), x) as ITypeSymbol)
                    )
                    .Select
                    (
                        x => (x.x, x.Item2,
                            x.Item2.GetAttributes().FirstOrDefault(x2 => x2.AttributeClass.Name == "GenericMaths"))
                    )
                    .Where(att => att.Item3 is not null)
                    .ToArray();

                foreach (var (declaration, symbol, attribute) in methods)
                {
                    if (declaration.Parent is TypeDeclarationSyntax tds)
                    {
                        if (!tds.Modifiers.Any(x => x.IsKind(SyntaxKind.PartialKeyword)))
                            throw new DiagnosticException(Diagnostic.Create(Diagnostics.TypeNotPartial, tds.GetLocation()));
                        
                        if (tds.Parent is NamespaceDeclarationSyntax nds)
                        {
                            var resultDeclarations = ProcessMethod
                            (
                                context, context.Compilation.GetSemanticModel(declaration.SyntaxTree), declaration.Body,
                                declaration.Identifier.Text, default, declaration.Modifiers,
                                declaration.TypeParameterList, declaration.ExplicitInterfaceSpecifier,
                                declaration.ParameterList, declaration.ConstraintClauses, true
                            );

                            if (resultDeclarations is null)
                                continue;

                            var newType = tds.WithMembers(List<MemberDeclarationSyntax>(resultDeclarations));
                            var newNamespace = nds.WithMembers(SingletonList<MemberDeclarationSyntax>(newType));
                            newNamespace = nds.SyntaxTree.GetCompilationUnitRoot()
                                .Usings.Aggregate
                                (
                                    newNamespace,
                                    (current, usingDirectiveSyntax) => current.AddUsings(usingDirectiveSyntax)
                                );
                            var str = newNamespace.NormalizeWhitespace().ToFullString();
                            var name = $"{tds.Identifier.Text}_Maths.cs";
                            Debugger.Break();
                            File.WriteAllText(@"C:\SILK.NET\src\Lab\GenericMaths\" + name, str);
                            context.AddSource(name, str);
                        }
                    }
                }

                foreach (var (tds, symbol, attribute) in types)
                {
                    if (!tds.Modifiers.Any(x => x.IsKind(SyntaxKind.PartialKeyword)))
                        throw new DiagnosticException(Diagnostic.Create(Diagnostics.TypeNotPartial, tds.GetLocation()));

                    if (tds.Parent is NamespaceDeclarationSyntax nds)
                    {
                        var resultDeclarations = new List<MemberDeclarationSyntax>();
                        foreach (var member in tds.Members)
                        {
                            if (member is MethodDeclarationSyntax declaration)
                            {

                                var methodResultDeclarations = ProcessMethod
                                (
                                    context, context.Compilation.GetSemanticModel(declaration.SyntaxTree),
                                    declaration.Body, declaration.Identifier.Text, default, declaration.Modifiers,
                                    declaration.TypeParameterList, declaration.ExplicitInterfaceSpecifier,
                                    declaration.ParameterList, declaration.ConstraintClauses,
                                    false
                                );

                                if (methodResultDeclarations is null)
                                    continue;

                                resultDeclarations.AddRange(methodResultDeclarations);
                            }
                        }

                        var newType = tds.WithMembers
                                (List(resultDeclarations))
                            .WithTypeParameterList
                                ((tds.TypeParameterList ?? TypeParameterList()).AddParameters(TypeParameter("T")))
                            .WithConstraintClauses
                            (
                                tds.ConstraintClauses.Add
                                (
                                    TypeParameterConstraintClause
                                            ("T")
                                        .WithConstraints
                                        (
                                            SeparatedList
                                            (
                                                new TypeParameterConstraintSyntax[]
                                                    {TypeConstraint(IdentifierName("unmanaged"))}
                                            )
                                        )
                                )
                            );
                        var newNamespace = nds.WithMembers(SingletonList<MemberDeclarationSyntax>(newType));
                        newNamespace = nds.SyntaxTree.GetCompilationUnitRoot()
                            .Usings.Aggregate
                            (
                                newNamespace, (current, usingDirectiveSyntax) => current.AddUsings(usingDirectiveSyntax)
                            );
                        var str = newNamespace.NormalizeWhitespace().ToFullString();
                        var name = $"{tds.Identifier.Text}_Maths_{Guid.NewGuid()}.cs";
                        Debugger.Break();
                        File.WriteAllText(@"C:\SILK.NET\src\Lab\GenericMaths\" + name, str);
                        context.AddSource(name, str);
                    }
                }
            }
            catch (DiagnosticException ex)
            {
                context.ReportDiagnostic(ex.Diagnostic);
            }
            catch (Exception ex)
            {
                Debugger.Launch();
                Debugger.Break();
                throw;
            }
        }

        public static List<MethodDeclarationSyntax>? ProcessMethod
        (
            GeneratorExecutionContext context,
            SemanticModel model,
            BlockSyntax body,
            string identifier,
            SyntaxList<AttributeListSyntax> attributeLists,
            SyntaxTokenList modifiers,
            TypeParameterListSyntax? typeParameterList,
            ExplicitInterfaceSpecifierSyntax? explicitInterfaceSpecifier,
            ParameterListSyntax parameterList,
            SyntaxList<TypeParameterConstraintClauseSyntax> constraintClauses,
            bool makeGenericDefinitionGenericRoot
        )
        {
            var op = model.GetOperation(body);
            if (op is null)
                return null;
            return ProcessMethodOperation
            (
                context, model, op, identifier, attributeLists, modifiers, typeParameterList,
                explicitInterfaceSpecifier, parameterList, constraintClauses, makeGenericDefinitionGenericRoot
            );
        }

        public static List<MethodDeclarationSyntax>? ProcessMethod
        (
            GeneratorExecutionContext context,
            SemanticModel model,
            ArrowExpressionClauseSyntax body,
            string identifier,
            SyntaxList<AttributeListSyntax> attributeLists,
            SyntaxTokenList modifiers,
            TypeParameterListSyntax? typeParameterList,
            ExplicitInterfaceSpecifierSyntax? explicitInterfaceSpecifier,
            ParameterListSyntax parameterList,
            SyntaxList<TypeParameterConstraintClauseSyntax> constraintClauses,
            bool makeGenericDefinitionGenericRoot
        )
        {
            var op = model.GetOperation(body);
            if (op is null)
                return null;
            return ProcessMethodOperation
            (
                context, model, op, identifier, attributeLists, modifiers, typeParameterList,
                explicitInterfaceSpecifier, parameterList, constraintClauses, makeGenericDefinitionGenericRoot
            );
        }

        private static IValueProcessor[] _valueProcessors = {
            new ConstantFolder(),
            new VariableInliner(),
        };

        private static List<MethodDeclarationSyntax> ProcessMethodOperation
        (
            GeneratorExecutionContext context,
            SemanticModel model,
            IOperation operation,
            string identifier,
            SyntaxList<AttributeListSyntax> attributeLists,
            SyntaxTokenList modifiers,
            TypeParameterListSyntax? typeParameterList,
            ExplicitInterfaceSpecifierSyntax? explicitInterfaceSpecifier,
            ParameterListSyntax parameterList,
            SyntaxList<TypeParameterConstraintClauseSyntax> constraintClauses,
            bool makeGenericDefinitionGenericRoot
        )
        {
            Debugger.Launch();
            var variables = new OperationWalker().RootVisit(context, operation);

            variables = _valueProcessors.Aggregate
                    (variables, (current, valueProcessor) => valueProcessor.Process(current))
                .ToArray();


            var stack = new Stack<IValue>();
            // this implies we only care for the first return variable.
            // this also implies that we assume all calls to be pure.
            var firstReturn = variables.FirstOrDefault(x => x is ReturnVariable);

            if (firstReturn is null)
                throw new DiagnosticException(Diagnostic.Create(Diagnostics.NoReturn, null));

            stack.Push(firstReturn.Value);

            var parameters = new List<ParameterReferenceValue>();
            var buckets = new Dictionary<int, List<IValue>>();
            while (stack.Count != 0)
            {
                var current = stack.Pop();
                foreach (var child in current.Children)
                {
                    stack.Push(child);
                }

                if (buckets.TryGetValue(current.Step, out var list))
                    list.Add(current);
                else
                    buckets[current.Step] = new List<IValue> {current};

                if (current is ParameterReferenceValue prv)
                    parameters.Add(prv);
            }

            Debugger.Break();
            parameters = parameters.Distinct().ToList();

            stack = null; // no longer need that
            var sortedBuckets = buckets.ToImmutableSortedDictionary(x => x.Key, x => x.Value, Comparer<int>.Default);
            buckets = null; // no need for the dictionary anymore

            const string GenericParameter = "T";
            string throwHelper = $"ThrowHelper_M_{identifier}";
            var methods = new List<MethodDeclarationSyntax>();
            methods.Add
            (
                MethodDeclaration
                        (PredefinedType(Token(SyntaxKind.VoidKeyword)), throwHelper)
                    .WithExpressionBody
                    (
                        ArrowExpressionClause
                        (
                            ThrowExpression
                            (
                                ObjectCreationExpression
                                    (
                                        QualifiedName
                                        (
                                            IdentifierName(nameof(System)),
                                            IdentifierName(nameof(System.ArgumentOutOfRangeException))
                                        )
                                    )
                                    .WithArgumentList
                                    (
                                        ArgumentList
                                        (
                                            SingletonSeparatedList
                                            (
                                                Argument
                                                (
                                                    LiteralExpression
                                                        (SyntaxKind.StringLiteralExpression, Literal(GenericParameter))
                                                )
                                            )
                                        )
                                    )
                            )
                        )
                    )
                    .WithModifiers(TokenList(Token(SyntaxKind.PrivateKeyword), Token(SyntaxKind.StaticKeyword)))
                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
            );

            StatementSyntax lastStatement = Block
            (
                ExpressionStatement(InvocationExpression(IdentifierName(throwHelper))),
                ReturnStatement(DefaultExpression(IdentifierName(GenericParameter)))
            );
            foreach (var targetType in TargetTypes)
            {
                var resolvedT = targetType.GetTypeSyntax();
                var targetTypeName = Enum.GetName(typeof(TargetType), targetType);

                methods.Add
                (
                    MethodDeclaration
                    (
                        attributeLists, modifiers, resolvedT, explicitInterfaceSpecifier,
                        Identifier($"{identifier}_{targetTypeName}"), typeParameterList,
                        ParameterList
                        (
                            SeparatedList
                                (parameters.Select(x => Parameter(Identifier(x.ParameterName)).WithType(resolvedT)))
                        ), constraintClauses, BuildMethodBody(sortedBuckets, firstReturn, targetType), null
                    )
                );

                lastStatement = IfStatement
                    (
                        BinaryExpression
                        (
                            SyntaxKind.EqualsExpression, TypeOfExpression(IdentifierName(GenericParameter)),
                            TypeOfExpression(resolvedT)
                        ),
                        ReturnStatement
                        (
                            CastExpression
                            (
                                IdentifierName(GenericParameter),
                                CastExpression
                                (
                                    PredefinedType(Token(SyntaxKind.ObjectKeyword)),
                                    InvocationExpression(IdentifierName($"{identifier}_{targetTypeName}"))
                                        .WithArgumentList
                                        (
                                            ArgumentList
                                            (
                                                SeparatedList
                                                (
                                                    parameters.Select
                                                    (
                                                        x => Argument
                                                        (
                                                            CastExpression
                                                            (
                                                                resolvedT,
                                                                CastExpression
                                                                (
                                                                    PredefinedType(Token(SyntaxKind.ObjectKeyword)),
                                                                    IdentifierName(x.ParameterName)
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
                    .WithElse(ElseClause(lastStatement));
            }

            if (makeGenericDefinitionGenericRoot)
            {
                typeParameterList ??= TypeParameterList();
                typeParameterList = typeParameterList.AddParameters(TypeParameter(GenericParameter));

                constraintClauses = constraintClauses.Add
                (
                    TypeParameterConstraintClause
                    (
                        IdentifierName(GenericParameter), SeparatedList
                        (
                            new TypeParameterConstraintSyntax[]
                            {
                                TypeConstraint(IdentifierName("unmanaged"))
                            }
                        )
                    )
                );
            }

            methods.Add
            (
                MethodDeclaration
                (
                    attributeLists, modifiers, IdentifierName(GenericParameter), explicitInterfaceSpecifier,
                    Identifier(identifier), typeParameterList, parameterList, constraintClauses, Block(lastStatement),
                    null
                )
            );

            Debugger.Break();
            return methods;
        }

        private static IEnumerable<TargetType> TargetTypes = new[]
        {
            TargetType.Byte,
            TargetType.SByte,
            TargetType.UShort,
            TargetType.Short,
            TargetType.UInt,
            TargetType.Int,
            TargetType.ULong,
            TargetType.Long,
            TargetType.Single,
            TargetType.Double
        };

        private static BlockSyntax BuildMethodBody
            (ImmutableSortedDictionary<int, List<IValue>> sortedBuckets, IVariable firstReturn, TargetType targetType)
        {
            var resolvedValues = new Dictionary<IValue, ExpressionSyntax>();
            var extraStatements = new List<StatementSyntax>();
            foreach (var bucket in sortedBuckets)
            {
                foreach (var value in bucket.Value)
                {
                    resolvedValues[value] = ParenthesizedExpression
                    (
                        CastExpression
                        (
                            targetType.GetTypeSyntax(),
                            ParenthesizedExpression
                            (
                                value.BuildExpression
                                (
                                    value.Children.Select(x => resolvedValues[x]).ToImmutableArray(),
                                    ref extraStatements, targetType
                                )
                            )
                        )
                    );
                }
            }

            extraStatements.Add(ReturnStatement(resolvedValues[firstReturn.Value]));
            return Block(extraStatements);
        }

        private static IReadOnlyCollection<IVariable> GetDependencies(IVariable variable)
        {
            var list = new List<IVariable>();
            var stack = new Stack<IValue>();
            stack.Push(variable.Value);

            while (stack.Count > 0)
            {
                var current = stack.Pop();

                if (current is LocalReferenceValue { LocalVariable: { } loc })
                    list.Add(loc);

                foreach (var child in current.Children)
                    stack.Push(child);
            }

            return list;
        }

        private static List<TypeSyntax> GetPossibleTypes(GeneratorExecutionContext context, SyntaxTree syntaxTree)
        {
            var options = context.AnalyzerConfigOptions.GetOptions(syntaxTree);

            var possibleTypes = new List<TypeSyntax>();
            if (options.TryGetValue
                    ("generic_maths_possible_types", out var possibleTypesStr) &&
                !string.IsNullOrWhiteSpace(possibleTypesStr))
            {
                foreach (var t in possibleTypesStr.Split(','))
                {
                    var parsed = ParseTypeName(t);
                    if (!(parsed is null))
                        possibleTypes.Add(parsed);
                }
            }

            if (possibleTypes.Count == 0)
            {
                possibleTypes.AddRange
                (
                    new TypeSyntax[]
                    {
                        IdentifierName(nameof(System) + "." + nameof(Byte)),
                        IdentifierName(nameof(System) + "." + nameof(SByte)),
                        IdentifierName(nameof(System) + "." + nameof(Int16)),
                        IdentifierName(nameof(System) + "." + nameof(UInt16)),
                        IdentifierName(nameof(System) + "." + nameof(Int32)),
                        IdentifierName(nameof(System) + "." + nameof(UInt32)),
                        IdentifierName(nameof(System) + "." + nameof(Int64)),
                        IdentifierName(nameof(System) + "." + nameof(UInt64)),
                    }
                );
            }

            return possibleTypes;
        }
        
        public class SyntaxReceiver : ISyntaxReceiver
        {
            public List<TypeDeclarationSyntax> Types = new List<TypeDeclarationSyntax>();
            public List<MethodDeclarationSyntax> Methods = new List<MethodDeclarationSyntax>();

            public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
            {
                switch (syntaxNode)
                {
                    case TypeDeclarationSyntax tds:
                        Types.Add(tds);
                        break;
                    case MethodDeclarationSyntax mds:
                        Methods.Add(mds);
                        break;
                }
            }
        }
    }
}
