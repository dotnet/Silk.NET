// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using GenericMathsGenerator.ValueTypes;
using GenericMathsGenerator.VariableTypes;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace GenericMathsGenerator
{
    [Generator]
    public class Generator : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context) 
            => context.RegisterForSyntaxNotifications(() => new SyntaxReceiver());

        public void Execute(GeneratorExecutionContext context)
        {
            const string genericParameter = "T";
            try
            {
                var attributeSourceText = SourceText.From
                (
                    @"
using System;

namespace GenericMaths
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Struct)]
    internal class GenericMathsAttribute : Attribute
    {
        /// <summary>Indicates whether to generate specialized versions, like ""NAME_Byte"". Defaults to false</summary>
        public bool GenerateSpecialized { get; set; } = false;
        /// <summary>Indicates whether to generate a generic version, like ""NAME<T>"". Defaults to true</summary>
        public bool GenerateGeneric { get; set;  } = true;
    }
}", Encoding.UTF8
                );
                context.AddSource
                (
                    "attribute", attributeSourceText
                );

                if (!(context.SyntaxReceiver is SyntaxReceiver sr))
                    return;

                var compilation = context.Compilation as CSharpCompilation;
                compilation = compilation.AddSyntaxTrees(CSharpSyntaxTree.ParseText(attributeSourceText, context.ParseOptions as CSharpParseOptions));
                
                var methods = sr.Methods.Select
                    (
                        x => (x,
                            ModelExtensions.GetDeclaredSymbol
                                (compilation.GetSemanticModel(x.SyntaxTree), x) as IMethodSymbol)
                    )
                    .Select
                    (
                        x => (x.x, x.Item2,
                            x.Item2.GetAttributes().FirstOrDefault(x2 => x2.AttributeClass.Name == "GenericMathsAttribute"))
                    )
                    .Where(att => att.Item3 is not null)
                    .ToArray();

                var types = sr.Types.Select
                    (
                        x => (x,
                            ModelExtensions.GetDeclaredSymbol
                                (compilation.GetSemanticModel(x.SyntaxTree), x) as ITypeSymbol)
                    )
                    .Select
                    (
                        x => (x.x, x.Item2,
                            x.Item2.GetAttributes().FirstOrDefault(x2 => x2.AttributeClass.Name == "GenericMathsAttribute"))
                    )
                    .Where(att => att.Item3 is not null)
                    .ToArray();
                foreach (var (declaration, symbol, attribute) in methods)
                {
                    try
                    {
                        var attributeParams = attribute.NamedArguments.ToDictionary(x => x.Key, x => x.Value);
                        bool generateSpecialized = false;
                        if (attributeParams.TryGetValue("GenerateSpecialized", out var g))
                            generateSpecialized = (bool)g.Value;
                        
                        bool generateGeneric = true;
                        if (attributeParams.TryGetValue("GenerateGeneric", out var g1))
                            generateGeneric = (bool)g1.Value;
                        
                        if (declaration.Parent is TypeDeclarationSyntax tds)
                        {
                            if (!tds.Modifiers.Any(x => x.IsKind(SyntaxKind.PartialKeyword)))
                                throw new DiagnosticException
                                    (Diagnostic.Create(Diagnostics.TypeNotPartial, tds.GetLocation()));

                            if (tds.Parent is NamespaceDeclarationSyntax nds)
                            {
                                var semanticModel = compilation.GetSemanticModel(nds.SyntaxTree);
                                var methodSymbol = semanticModel.GetDeclaredSymbol(declaration) as IMethodSymbol;
                                if (methodSymbol is null)
                                    continue;

                                if (methodSymbol.ReturnType.SpecialType != SpecialType.System_Single)
                                    continue;

                                if (methodSymbol.Parameters.Any(x => x.Type.SpecialType != SpecialType.System_Single))
                                    continue;

                                List<MethodDeclarationSyntax>? methodResultDeclarations;
                                if (declaration.Body is not null)
                                    methodResultDeclarations = ProcessMethod
                                    (
                                        context, semanticModel, declaration.Body, declaration.Identifier.Text, false,
                                        genericParameter, generateGeneric, default, declaration.Modifiers, declaration.TypeParameterList, declaration.ExplicitInterfaceSpecifier, declaration.ParameterList, declaration.ConstraintClauses, generateSpecialized
                                    );
                                else
                                    methodResultDeclarations = ProcessMethod
                                    (
                                        context, semanticModel, declaration.ExpressionBody!,
                                        declaration.Identifier.Text, generateGeneric, genericParameter, default, declaration.Modifiers, declaration.TypeParameterList, declaration.ExplicitInterfaceSpecifier, declaration.ParameterList, declaration.ConstraintClauses, generateSpecialized
                                    );

                                if (methodResultDeclarations is null)
                                    continue;

                                var newType = tds.WithMembers(List<MemberDeclarationSyntax>(methodResultDeclarations));
                                var newNamespace = nds.WithMembers(SingletonList<MemberDeclarationSyntax>(newType));
                                newNamespace = nds.SyntaxTree.GetCompilationUnitRoot()
                                    .Usings.Aggregate
                                    (
                                        newNamespace,
                                        (current, usingDirectiveSyntax) => current.AddUsings(usingDirectiveSyntax)
                                    );
                                var str = newNamespace.NormalizeWhitespace().ToFullString();
                                var name = $"{tds.Identifier.Text}_Maths.cs";
                                context.AddSource(name, str);
                            }
                        }
                    }
                    catch (DiagnosticException ex)
                    {
                        context.ReportDiagnostic(ex.Diagnostic);
                    }
                }
                
                foreach (var (tds, symbol, attribute) in types)
                    if (tds.Parent is NamespaceDeclarationSyntax nds)
                    {
                        var attributeParams = attribute.NamedArguments.ToDictionary(x => x.Key, x => x.Value);
                        bool generateSpecialized = false;
                        if (attributeParams.TryGetValue("GenerateSpecialized", out var g))
                            generateSpecialized = (bool)g.Value;
                        
                        bool generateGeneric = true;
                        if (attributeParams.TryGetValue("GenerateGeneric", out var g1))
                            generateGeneric = (bool)g1.Value;

                        if (generateSpecialized)
                        {
                            Dictionary<TargetType, string> typeNames = TargetTypes.ToDictionary
                                (x => x, x => tds.Identifier.Text + "_" + Enum.GetName(typeof(TargetType), x));
                            foreach (var targetType in TargetTypes)
                            {
                                try
                                {
                                    var newType = SpecializeType(context, tds, targetType)
                                        .WithIdentifier(Identifier(typeNames[targetType]));

                                    var newNamespace = nds.WithMembers(SingletonList<MemberDeclarationSyntax>(newType));
                                    newNamespace = nds.SyntaxTree.GetCompilationUnitRoot()
                                        .Usings.Aggregate
                                        (
                                            newNamespace,
                                            (current, usingDirectiveSyntax) => current.AddUsings(usingDirectiveSyntax)
                                        );
                                    var str = newNamespace.NormalizeWhitespace().ToFullString();
                                    var name =
                                        $"{tds.Identifier.Text}_Maths_{typeNames[targetType]}_{Guid.NewGuid()}.cs";
                                    context.AddSource(name, str);
                                }
                                catch (DiagnosticException ex)
                                {
                                    context.ReportDiagnostic(ex.Diagnostic);
                                }
                            }
                        }

                        if (generateGeneric)
                        {
                            try
                            {
                                var newType = MakeGenericType(context, tds, genericParameter, TargetTypes);
                                var newNamespace = nds.WithMembers(SingletonList(newType));
                                newNamespace = nds.SyntaxTree.GetCompilationUnitRoot()
                                    .Usings.Aggregate
                                    (
                                        newNamespace,
                                        (current, usingDirectiveSyntax) => current.AddUsings(usingDirectiveSyntax)
                                    );
                                var str = newNamespace.NormalizeWhitespace().ToFullString();
                                var name = $"{tds.Identifier.Text}_Maths_Generic_{Guid.NewGuid()}.cs";
                                context.AddSource(name, str);
                            }
                            catch (DiagnosticException ex)
                            {
                                context.ReportDiagnostic(ex.Diagnostic);
                            }
                        }
                    }
            }
            catch (DiagnosticException ex)
            {
                context.ReportDiagnostic(ex.Diagnostic);
            }
            #if DEBUG
            catch (Exception ex)
            {
                Debugger.Launch();
                Debugger.Break();
                throw;
            }
            #endif
        }

        private MemberDeclarationSyntax MakeGenericType
        (
            GeneratorExecutionContext context,
            TypeDeclarationSyntax sourceType,
            string genericParameter,
            IEnumerable<TargetType> targetTypes
        )
        {
            var throwHelper = "M_THROW_HELPER";
            var model = context.Compilation.GetSemanticModel(sourceType.SyntaxTree);
            var resultMembers = new List<MemberDeclarationSyntax>();
            var t = IdentifierName(genericParameter);

            resultMembers
                .Add // private static void M_THROW_HELPER() => throw new InvalidOperationException($"{typeof(T)}");
                (
                    MethodDeclaration(PredefinedType(Token(SyntaxKind.VoidKeyword)), Identifier("M_THROW_HELPER"))
                        .WithModifiers(TokenList(Token(SyntaxKind.PrivateKeyword), Token(SyntaxKind.StaticKeyword)))
                        .WithExpressionBody
                        (
                            ArrowExpressionClause
                            (
                                ThrowExpression
                                (
                                    ObjectCreationExpression
                                            (IdentifierName("InvalidOperationException"))
                                        .WithArgumentList
                                        (
                                            ArgumentList
                                            (
                                                SingletonSeparatedList<ArgumentSyntax>
                                                (
                                                    Argument
                                                    (
                                                        InterpolatedStringExpression
                                                                (Token(SyntaxKind.InterpolatedStringStartToken))
                                                            .WithContents
                                                            (
                                                                SingletonList<InterpolatedStringContentSyntax>
                                                                (
                                                                    Interpolation(TypeOfExpression(IdentifierName("T")))
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
                );
            
            foreach (var member in sourceType.Members)
            {
                switch (member)
                {
                    case MethodDeclarationSyntax method:
                        if (!(model.GetDeclaredSymbol
                                (method) is { ReturnType: { SpecialType: SpecialType.System_Single } }) ||
                            method.ParameterList.Parameters.Any
                            (
                                x => !(model.GetDeclaredSymbol(method.ReturnType) is ITypeSymbol ts &&
                                       ts.SpecialType == SpecialType.System_Single)
                            ))
                        {
                            resultMembers.Add(method);
                            continue;
                        }

                        var methodOperation = method.Body is not null
                            ? model.GetOperation(method.Body)
                            : model.GetOperation(method.ExpressionBody!);

                        if (methodOperation is null)
                        {
                            resultMembers.Add(method);
                            continue;
                        }

                        var targets = targetTypes.Select
                            (x => (x, $"{method.Identifier.Text}_S_{Enum.GetName(typeof(TargetType), x)}")).ToArray();
                        resultMembers.AddRange(ProcessMethodOperation
                        (
                            context, methodOperation, false, false, null,
                            targets,
                            throwHelper, null, method.AttributeLists, method.Modifiers,
                            method.TypeParameterList, method.ExplicitInterfaceSpecifier, method.ParameterList,
                            method.ConstraintClauses, true
                        ));
                        resultMembers.Add(BuildGenericMethod(method, t, targets, throwHelper));
                        break;
                    case FieldDeclarationSyntax field:
                        resultMembers.Add(field.WithDeclaration(field.Declaration.WithType(t)));
                        break;
                    case PropertyDeclarationSyntax property:
                        resultMembers.Add(property.WithType(t));
                        break;
                }
            }

            return sourceType.WithMembers
                    (List(resultMembers))
                .WithAttributeLists(default)
                .WithTypeParameterList
                (
                    (sourceType.TypeParameterList ?? TypeParameterList()).AddParameters(TypeParameter(genericParameter))
                )
                .WithConstraintClauses
                (
                    sourceType.ConstraintClauses.Add
                    (
                        TypeParameterConstraintClause
                                (genericParameter)
                            .WithConstraints
                            (
                                SingletonSeparatedList
                                (
                                    (TypeParameterConstraintSyntax) TypeConstraint
                                        (IdentifierName("unmanaged"))
                                )
                            )
                    )
                );
        }

        private MethodDeclarationSyntax BuildGenericMethod(MethodDeclarationSyntax method, TypeSyntax t, IEnumerable<(TargetType x, string)> targets, string throwHelper)
        {
            StatementSyntax lastStatement = Block
                (ExpressionStatement(InvocationExpression(IdentifierName(throwHelper))), ReturnStatement(DefaultExpression(t)));

            foreach (var (type, name) in targets)
            {
                var resolvedT = type.GetTypeSyntax();
                lastStatement = IfStatement
                (
                    BinaryExpression(SyntaxKind.EqualsExpression, TypeOfExpression(t), TypeOfExpression(resolvedT)),
                    ReturnStatement
                    (
                        CastExpression
                        (
                            t,
                            CastExpression
                            (
                                PredefinedType(Token(SyntaxKind.ObjectKeyword)),
                                InvocationExpression
                                (
                                    IdentifierName(name),
                                    ArgumentList
                                    (
                                        SeparatedList
                                        (
                                            method.ParameterList.Parameters.Select
                                            (
                                                x => Argument
                                                (
                                                    CastExpression
                                                    (
                                                        resolvedT,
                                                        CastExpression
                                                        (
                                                            PredefinedType(Token(SyntaxKind.ObjectKeyword)),
                                                            IdentifierName(x.Identifier.Text)
                                                        )
                                                    )
                                                )
                                            )
                                        )
                                    )
                                )
                            )
                        )
                    ), ElseClause(lastStatement)
                );
            }

            return method.WithReturnType(t)
                .WithParameterList
                (
                    method.ParameterList.WithParameters
                        (SeparatedList(method.ParameterList.Parameters.Select(x => x.WithType(t))))
                )
                .WithBody(Block(lastStatement))
                // [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)768)]
                // equivalent to AggressiveOptimization | AggressiveInlining
                .WithAttributeLists
                (
                    SingletonList
                    (
                        AttributeList
                        (
                            SingletonSeparatedList
                            (
                                Attribute
                                    (
                                        QualifiedName
                                        (
                                            QualifiedName
                                            (
                                                QualifiedName(IdentifierName("System"), IdentifierName("Runtime")),
                                                IdentifierName("CompilerServices")
                                            ), IdentifierName("MethodImpl")
                                        )
                                    )
                                    .WithArgumentList
                                    (
                                        AttributeArgumentList
                                        (
                                            SingletonSeparatedList
                                            (
                                                AttributeArgument
                                                (
                                                    CastExpression
                                                    (
                                                        QualifiedName
                                                        (
                                                            QualifiedName
                                                            (
                                                                QualifiedName
                                                                (
                                                                    IdentifierName("System"), IdentifierName("Runtime")
                                                                ),
                                                                IdentifierName("CompilerServices")
                                                            ), IdentifierName("MethodImplOptions")
                                                        ),
                                                        LiteralExpression
                                                            (SyntaxKind.NumericLiteralExpression, Literal(768))
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

        private static TypeDeclarationSyntax SpecializeType(
            GeneratorExecutionContext context,
            TypeDeclarationSyntax tds,
            TargetType targetType
        )
        {
            var model = context.Compilation.GetSemanticModel(tds.SyntaxTree);
            var resolvedT = targetType.GetTypeSyntax();
            var targetTypeName = Enum.GetName(typeof(TargetType), targetType);
            var resultDeclarations = new List<MemberDeclarationSyntax>();
            foreach (var member in tds.Members)
            {
                switch (member)
                {
                    case MethodDeclarationSyntax method:
                    {
                        if (!(model.GetDeclaredSymbol
                                (method) is { ReturnType: { SpecialType: SpecialType.System_Single } }) ||
                            method.ParameterList.Parameters.Any
                            (
                                x => !(model.GetDeclaredSymbol(method.ReturnType) is ITypeSymbol ts &&
                                       ts.SpecialType == SpecialType.System_Single)
                            ))
                        {
                            resultDeclarations.Add(method);
                            continue;
                        }

                        var methodOperation = method.Body is not null
                            ? model.GetOperation(method.Body)
                            : model.GetOperation(method.ExpressionBody!);

                        if (methodOperation is null)
                        {
                            resultDeclarations.Add(method);
                            continue;
                        }

                        var m = ProcessMethodOperation
                        (
                            context, methodOperation, false, false, null, new[]
                            {
                                (targetType, method.Identifier.Text)
                            }, $"THROW_HELPER_{method.Identifier}", null, method.AttributeLists, method.Modifiers, method.TypeParameterList, method.ExplicitInterfaceSpecifier, method.ParameterList, method.ConstraintClauses, false
                        );

                        resultDeclarations.AddRange(m);
                        break;
                    }
                    case FieldDeclarationSyntax field:
                        resultDeclarations.Add(field.WithDeclaration(field.Declaration.WithType(resolvedT)));
                        break;
                    case PropertyDeclarationSyntax property:
                        resultDeclarations.Add(property.WithType(resolvedT));
                        break;
                    default:
                        context.ReportDiagnostic
                        (
                            Diagnostic.Create
                                (Diagnostics.UnsupportedMember, member.GetLocation(), member.GetType().Name)
                        );
                        break;
                }
            }

            return tds.WithMembers(List(resultDeclarations)).WithAttributeLists(default);
        }

        public static List<MethodDeclarationSyntax>? ProcessMethod
        (
            GeneratorExecutionContext context,
            SemanticModel model,
            BlockSyntax body,
            string identifier,
            bool makeGenericDefinitionGenericRoot,
            string genericParameter,
            bool generateGenericMethod,
            SyntaxList<AttributeListSyntax> attributeLists,
            SyntaxTokenList modifiers,
            TypeParameterListSyntax? typeParameterList,
            ExplicitInterfaceSpecifierSyntax? explicitInterfaceSpecifier,
            ParameterListSyntax parameterList,
            SyntaxList<TypeParameterConstraintClauseSyntax> constraintClauses,
            bool privatizeNonGeneric
        )
        {
            var op = model.GetOperation(body);
            if (op is null)
                return null;
            return ProcessMethodOperation
            (
                context, op, makeGenericDefinitionGenericRoot, generateGenericMethod, identifier,
                TargetTypes.Select(x => (x, $"{identifier}_{Enum.GetName(typeof(TargetType), x)}")),
                $"ThrowHelper_M_{identifier}", genericParameter, attributeLists, modifiers, typeParameterList, explicitInterfaceSpecifier, parameterList, constraintClauses, privatizeNonGeneric
            );
        }

        public static List<MethodDeclarationSyntax>? ProcessMethod
        (
            GeneratorExecutionContext context,
            SemanticModel model,
            ArrowExpressionClauseSyntax body,
            string identifier,
            bool makeGenericDefinitionGenericRoot,
            string genericParameter,
            SyntaxList<AttributeListSyntax> attributeLists,
            SyntaxTokenList modifiers,
            TypeParameterListSyntax? typeParameterList,
            ExplicitInterfaceSpecifierSyntax? explicitInterfaceSpecifier,
            ParameterListSyntax parameterList,
            SyntaxList<TypeParameterConstraintClauseSyntax> constraintClauses,
            bool privatizeNonGeneric
        )
        {
            var op = model.GetOperation(body);
            if (op is null)
                return null;
            return ProcessMethodOperation
            (
                context, op, makeGenericDefinitionGenericRoot, true, identifier,
                TargetTypes.Select(x => (x, $"{identifier}_{Enum.GetName(typeof(TargetType), x)}")),
                $"ThrowHelper_M_{identifier}", genericParameter, attributeLists, modifiers, typeParameterList, explicitInterfaceSpecifier, parameterList, constraintClauses, privatizeNonGeneric
            );
        }

        private static readonly IValueProcessor[] _valueProcessors = {
            new ConstantFolder(),
        };

        private static readonly IVariableProcessor[] _variableProcessors = {
            new VariableInliner()
        };

        private static List<MethodDeclarationSyntax> ProcessMethodOperation
        (
            GeneratorExecutionContext context,
            IOperation operation,
            bool makeGenericDefinitionGenericRoot,
            bool generateGenericMethod,
            string? genericMethodName,
            IEnumerable<(TargetType, string)> targetTypes,
            string throwHelperName,
            string genericParameter,
            SyntaxList<AttributeListSyntax> attributeLists,
            SyntaxTokenList modifiers,
            TypeParameterListSyntax? typeParameterList,
            ExplicitInterfaceSpecifierSyntax? explicitInterfaceSpecifier,
            ParameterListSyntax parameterList,
            SyntaxList<TypeParameterConstraintClauseSyntax> constraintClauses,
            bool privatizeNonGeneric
        )
        {
            if (!generateGenericMethod)
                Debug.Assert(!makeGenericDefinitionGenericRoot);
            Debug.Assert(generateGenericMethod == genericMethodName is not null);
            
            var scope = new OperationWalker().RootVisit(context, operation);

            if (scope is null)
                return null;

            scope = ProcessScope(scope);

            // this implies we only care for the first return variable.
            // this also implies that we assume all calls to be pure.
            var firstReturn = scope.Variables.FirstOrDefault(x => x is ReturnVariable);

            if (firstReturn is null)
                throw new DiagnosticException(Diagnostic.Create(Diagnostics.NoReturn, null));

            GetBucketsAndParameters(firstReturn.Value, out List<ParameterReferenceValue> parameters, out ImmutableSortedDictionary<int, List<IValue>> sortedBuckets);

            var methods = GetMethods(firstReturn.Value, makeGenericDefinitionGenericRoot, generateGenericMethod, genericMethodName, targetTypes, throwHelperName, genericParameter, privatizeNonGeneric, parameters, sortedBuckets, attributeLists, modifiers, typeParameterList, explicitInterfaceSpecifier, parameterList, constraintClauses);

            return methods;
        }

        private static IScope ProcessScope(IScope scope)
        {
            IEnumerable<IVariable> variables = scope.Variables;
            variables = _variableProcessors
                .Aggregate(variables, (current, variableProcessor) => variableProcessor.Process(current)).ToArray();

            static IValue ValueProcessRec(IValueProcessor processor, IValue value)
            {
                if (!value.Children.Any())
                    return value;
                return value.WithChildren(value.Children.Select(x
                    => processor.Process(x, () => ValueProcessRec(processor, x))));
            }

            variables = variables.Select(x => x.WithValue(_valueProcessors.Aggregate(x.Value,
                (current, valueProcessor) => valueProcessor.Process(current, () => ValueProcessRec(valueProcessor, current)))));

            scope.Variables = variables.ToArray();
            scope.Children = scope.Children.Select(ProcessScope).ToArray();
            return scope;
        }

        private static List<MethodDeclarationSyntax> GetMethods(
            IValue value,
            bool makeGenericDefinitionGenericRoot,
            bool generateGenericMethod,
            string? genericMethodName,
            IEnumerable<(TargetType, string)> targetTypes,
            string throwHelperName,
            string genericParameter,
            bool privatizeNonGeneric,
            List<ParameterReferenceValue> parameters,
            ImmutableSortedDictionary<int, List<IValue>> sortedBuckets,
            SyntaxList<AttributeListSyntax> attributeLists,
            SyntaxTokenList modifiers,
            TypeParameterListSyntax? typeParameterList,
            ExplicitInterfaceSpecifierSyntax? explicitInterfaceSpecifier,
            ParameterListSyntax parameterList,
            SyntaxList<TypeParameterConstraintClauseSyntax> constraintClauses
        )
        {
            var methods = new List<MethodDeclarationSyntax>();
            StatementSyntax lastStatement = default;
            if (generateGenericMethod)
            {
                methods.Add(MethodDeclaration(PredefinedType(Token(SyntaxKind.VoidKeyword)), throwHelperName)
                    .WithExpressionBody(ArrowExpressionClause(ThrowExpression(
                        ObjectCreationExpression(QualifiedName(IdentifierName(nameof(System)),
                            IdentifierName(nameof(ArgumentOutOfRangeException)))).WithArgumentList(
                            ArgumentList(SingletonSeparatedList(Argument(LiteralExpression(SyntaxKind.StringLiteralExpression,
                                Literal(genericParameter)))))))))
                    .WithModifiers(TokenList(Token(SyntaxKind.PrivateKeyword), Token(SyntaxKind.StaticKeyword)))
                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)));

                lastStatement = Block(ExpressionStatement(InvocationExpression(IdentifierName(throwHelperName))),
                    ReturnStatement(DefaultExpression(IdentifierName(genericParameter))));
            }

            foreach (var (targetType, mId) in targetTypes)
            {
                var resolvedT = targetType.GetTypeSyntax();

                var m = MethodDeclaration(attributeLists, modifiers, resolvedT, explicitInterfaceSpecifier, Identifier(mId),
                    typeParameterList,
                    ParameterList(
                        SeparatedList(parameters.Select(x => Parameter(Identifier(x.ParameterName)).WithType(resolvedT)))),
                    constraintClauses, BuildMethodBody(sortedBuckets, value, targetType), null);
                if (privatizeNonGeneric)
                {
                    var v = m.Modifiers.Select(x => new SyntaxToken?(x)).FirstOrDefault
                    (
                        x => x.HasValue && (x.Value.IsKind(SyntaxKind.PublicKeyword) || x.Value.IsKind(SyntaxKind.InternalKeyword) || x.Value.IsKind
                            (SyntaxKind.ProtectedKeyword))
                    );
                    
                    if (v is not null)
                        m.WithModifiers(m.Modifiers.Replace(v.Value, Token(SyntaxKind.PrivateKeyword)));
                }
                methods.Add(m);

                if (generateGenericMethod)
                {
                    lastStatement =
                        IfStatement(
                                BinaryExpression(SyntaxKind.EqualsExpression,
                                    TypeOfExpression(IdentifierName(genericParameter)),
                                    TypeOfExpression(resolvedT)),
                                ReturnStatement(CastExpression(IdentifierName(genericParameter),
                                    CastExpression(PredefinedType(Token(SyntaxKind.ObjectKeyword)),
                                        InvocationExpression(IdentifierName(mId)).WithArgumentList(
                                            ArgumentList(SeparatedList(parameters.Select(x
                                                => Argument(CastExpression(resolvedT,
                                                    CastExpression(PredefinedType(Token(SyntaxKind.ObjectKeyword)),
                                                        IdentifierName(x.ParameterName))))))))))))
                            .WithElse(ElseClause(lastStatement!));
                }
            }

            if (generateGenericMethod)
            {
                if (makeGenericDefinitionGenericRoot)
                {
                    typeParameterList ??= TypeParameterList();
                    typeParameterList = typeParameterList.AddParameters(TypeParameter(genericParameter));

                    constraintClauses = constraintClauses.Add(TypeParameterConstraintClause(IdentifierName(genericParameter),
                        SeparatedList(new TypeParameterConstraintSyntax[] {TypeConstraint(IdentifierName("unmanaged"))})));
                }

                methods.Add
                (
                    MethodDeclaration
                    (
                        attributeLists, modifiers, IdentifierName(genericParameter), explicitInterfaceSpecifier,
                        Identifier(genericMethodName), typeParameterList,
                        parameterList.WithParameters
                        (
                            SeparatedList
                                (parameterList.Parameters.Select(x => x.WithType(IdentifierName(genericParameter))))
                        ), constraintClauses, Block(lastStatement!), null
                    )
                );
            }

            return methods;
        }

        private static void GetBucketsAndParameters(
            IValue value,
            out List<ParameterReferenceValue> parameters,
            out ImmutableSortedDictionary<int, List<IValue>> sortedBuckets)
        {
            var stack = new Stack<IValue>();
            stack.Push(value);

            parameters = new List<ParameterReferenceValue>();
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

            parameters = parameters.Distinct().ToList();
            sortedBuckets = buckets.ToImmutableSortedDictionary(x => x.Key, x => x.Value, Comparer<int>.Default);
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
            (ImmutableSortedDictionary<int, List<IValue>> sortedBuckets, IValue sourceValue, TargetType targetType)
        {
            static ExpressionSyntax ResolveCallback(IValue value, IBodyBuilder builder)
            {
                GetBucketsAndParameters(value, out var parameters, out var sortedBuckets);
                ResolveBuckets(sortedBuckets, builder.Type, builder);
                return builder.ResolvedValues[value];
            }
            
            var extraStatements = new List<StatementSyntax>();

            var bodyBuilder = new ScalarBodyBuilder(extraStatements, targetType, ResolveCallback);
            ResolveBuckets(sortedBuckets, targetType, bodyBuilder);

            extraStatements = bodyBuilder.Statements;
            extraStatements.Add(ReturnStatement(bodyBuilder.ResolvedValues[sourceValue]));
            return Block(extraStatements);
        }

        private static void ResolveBuckets(
            ImmutableSortedDictionary<int, List<IValue>> sortedBuckets,
            TargetType targetType,
            IBodyBuilder bodyBuilder
        )
        {
            foreach (var bucket in sortedBuckets)
            {
                foreach (var value in bucket.Value)
                {
                    var children = value.Children.Select(x => bodyBuilder.ResolvedValues[x]);
                    bodyBuilder.ResolvedValues[value] = ParenthesizedExpression(CastExpression(targetType.GetTypeSyntax(),
                        ParenthesizedExpression(value.BuildExpression(bodyBuilder, children.ToImmutableArray()))));
                }
            }
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
                possibleTypes.AddRange(possibleTypesStr.Split(',').Select(t => ParseTypeName(t)));
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
