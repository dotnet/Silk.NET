// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Native;
using Silk.NET.SilkTouch.NativeContextOverrides;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using static Silk.NET.SilkTouch.NameGenerator;

namespace Silk.NET.SilkTouch
{
    [Generator]
    public partial class NativeApiGenerator : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context)
        {
            context.RegisterForSyntaxNotifications(() => new SyntaxReceiver());
        }

        public void Execute(GeneratorExecutionContext context)
        {
            if (!context.Compilation.ReferencedAssemblyNames.Any
                (ai => ai.Name.Equals("Silk.NET.Core", StringComparison.OrdinalIgnoreCase)))
            {
                context.ReportDiagnostic(Diagnostic.Create(Diagnostics.SilkNetCoreMissing, Location.None));
                return;
            }

            if (context.SyntaxContextReceiver is not SyntaxReceiver receiver)
                return;

            var nativeApiAttribute = context.Compilation.GetTypeByMetadataName
                ("Silk.NET.Core.Native.NativeApiAttribute");

            if (nativeApiAttribute is null)
                return;

            var pInvokeAttribute = context.Compilation.GetTypeByMetadataName("Silk.NET.Core.Native.PInvokeOverride");

            if (pInvokeAttribute is null)
                return;

            var excludeFromOverrideAttribute = context.Compilation.GetTypeByMetadataName
                ("Silk.NET.Core.Native.ExcludeFromOverrideAttribute");

            if (excludeFromOverrideAttribute is null)
                return;


            var marshalBuilder = new MarshalBuilder();

            // begin            |           end
            marshalBuilder.Use(Middlewares.InjectMiddleware);
            marshalBuilder.Use(Middlewares.ParameterInitMiddleware);
            marshalBuilder.Use(Middlewares.StringMarshaller);
            marshalBuilder.Use(Middlewares.PinMiddleware);
            // post init        |           -
            marshalBuilder.Use(Middlewares.SpanMarshaller);
            marshalBuilder.Use(Middlewares.BoolMarshaller);
            marshalBuilder.Use(Middlewares.PinObjectMarshaller);
            // post pin
            marshalBuilder.Use(Middlewares.DelegateMarshaller);
            marshalBuilder.Use(Middlewares.GenericPointerMarshaller);
            // pre load         |           post load

            List<ITypeSymbol> processedSymbols = new List<ITypeSymbol>();

            var overrideLog = new List<(string Class, int Override)>();
            foreach (var group in receiver.ClassDeclarations.Select(x => (x.Item1, x.Item2, x.Item2.GetDeclaredSymbol(x.Item1)))
                .GroupBy(x => x.Item3, SymbolEqualityComparer.Default))
            {
                try
                {
                    var s = ProcessClassDeclaration
                    (
                        group.Select(x => (x.Item1, x.Item2)), context, nativeApiAttribute, marshalBuilder, ref processedSymbols,
                        excludeFromOverrideAttribute, (INamedTypeSymbol) group.Key, ref overrideLog, pInvokeAttribute
                    );

                    if (s is not { Length: > 0 }) continue;

                    Output(context, group.Key.Name, s);
                }
                catch (Exception ex)
                {
                    context.ReportDiagnostic
                    (
                        Diagnostic.Create
                            (Diagnostics.ProcessClassFailure, group.First().Item1.GetLocation(), ex.ToString().Replace("\n", " | "))
                    );
                }
            }
            if (overrideLog.Count > 0)
            {
                var standardProp = PropertyDeclaration
                    (
                        PredefinedType(Token(SyntaxKind.BoolKeyword)),
                        Identifier("HasLinkTimeSubstitutions")
                    )
                    .WithModifiers(TokenList(new[] { Token(SyntaxKind.InternalKeyword), Token(SyntaxKind.StaticKeyword) }))
                    .WithAccessorList
                    (
                        AccessorList
                        (
                            SingletonList
                            (
                                AccessorDeclaration(SyntaxKind.GetAccessorDeclaration).WithExpressionBody
                                (
                                    ArrowExpressionClause(LiteralExpression(SyntaxKind.FalseLiteralExpression))
                                ).WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                            )
                        )
                    );
                var otherProps = overrideLog.SelectMany
                (
                    log =>
                    {
                        var propName = $"{log.Class.Replace(".", "")}PInvokeOverride{log.Override}";
                        return new MemberDeclarationSyntax[]
                        {
                            FieldDeclaration
                            (
                                VariableDeclaration(PredefinedType(Token(SyntaxKind.BoolKeyword))).WithVariables
                                (
                                    SingletonSeparatedList
                                    (
                                        VariableDeclarator(Identifier($"_fold{propName}"))
                                            .WithInitializer
                                            (
                                                EqualsValueClause(LiteralExpression(SyntaxKind.FalseLiteralExpression))
                                            )
                                    )
                                )
                            ).WithModifiers
                            (
                                TokenList
                                (
                                    new[]
                                    {
                                        Token(SyntaxKind.PrivateKeyword),
                                        Token(SyntaxKind.StaticKeyword),
                                        Token(SyntaxKind.ReadOnlyKeyword)
                                    }
                                )
                            ),
                            PropertyDeclaration(PredefinedType(Token(SyntaxKind.BoolKeyword)),Identifier(propName))
                                .WithModifiers
                                (
                                    TokenList(new []{Token(SyntaxKind.InternalKeyword),Token(SyntaxKind.StaticKeyword)})
                                )
                                .WithAccessorList
                                (
                                    AccessorList
                                    (
                                        SingletonList
                                        (
                                            AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                                                .WithExpressionBody
                                                (
                                                    ArrowExpressionClause(IdentifierName($"_fold{propName}"))
                                                ).WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                                        )
                                    )
                                )
                        };
                    }
                );
                var ctor = ConstructorDeclaration(Identifier("SilkTouchRuntimeConfiguration"))
                    .WithModifiers(TokenList(Token(SyntaxKind.StaticKeyword)))
                    .WithBody
                    (
                        Block
                        (
                            SingletonList
                            (
                                IfStatement
                                (
                                    PrefixUnaryExpression
                                    (
                                        SyntaxKind.LogicalNotExpression,
                                        IdentifierName("HasLinkTimeSubstitutions")
                                    ),
                                    Block
                                    (
                                        List<StatementSyntax>
                                        (
                                            overrideLog.Select
                                            (
                                                (log, i) => ExpressionStatement
                                                (
                                                    AssignmentExpression
                                                    (
                                                        SyntaxKind.SimpleAssignmentExpression,
                                                        IdentifierName($"_fold{log.Class.Replace(".", "")}PInvokeOverride{log.Override}"),
                                                        BinaryExpression
                                                        (
                                                            SyntaxKind.LogicalAndExpression,
                                                            InvocationExpression
                                                            (
                                                                MemberAccessExpression
                                                                (
                                                                    SyntaxKind.SimpleMemberAccessExpression,
                                                                    MemberAccessExpression
                                                                    (
                                                                        SyntaxKind.SimpleMemberAccessExpression,
                                                                        AliasQualifiedName
                                                                        (
                                                                            IdentifierName(Token(SyntaxKind.GlobalKeyword)),
                                                                            IdentifierName("System")
                                                                        ),
                                                                        IdentifierName("AppContext")
                                                                    ),
                                                                    IdentifierName("TryGetSwitch")
                                                                )
                                                            ).WithArgumentList
                                                            (
                                                                ArgumentList
                                                                (
                                                                    SeparatedList<ArgumentSyntax>
                                                                    (
                                                                        new SyntaxNodeOrToken[]
                                                                        {
                                                                            Argument(LiteralExpression
                                                                            (
                                                                                SyntaxKind.StringLiteralExpression,
                                                                                Literal( $"{log.Class.Replace(".", "_").ToUpper()}_ENABLE_PINVOKE_OVERRIDE_{log.Override}"
                                                                            ))),
                                                                            Token(SyntaxKind.CommaToken),
                                                                            Argument(DeclarationExpression
                                                                            (
                                                                                IdentifierName
                                                                                (
                                                                                    Identifier
                                                                                    (
                                                                                        TriviaList(),
                                                                                        SyntaxKind.VarKeyword,
                                                                                        "var",
                                                                                        "var",
                                                                                        TriviaList()
                                                                                    )
                                                                                ),
                                                                                SingleVariableDesignation(Identifier($"e{i}"))))
                                                                                    .WithRefOrOutKeyword(Token(SyntaxKind.OutKeyword))
                                                                        }
                                                                    )
                                                                )
                                                            ),
                                                            IdentifierName($"e{i}")
                                                        )
                                                    )
                                                )
                                            )
                                        )
                                    )
                                )
                            )
                        )
                    );
                Output
                (
                    context,
                    "SilkTouchRuntimeConfiguration",
                    CompilationUnit().WithMembers
                    (
                        SingletonList<MemberDeclarationSyntax>
                        (
                            ClassDeclaration("SilkTouchRuntimeConfiguration")
                                .WithModifiers
                                (
                                    TokenList
                                    (
                                        new[] { Token(SyntaxKind.InternalKeyword), Token(SyntaxKind.StaticKeyword) }
                                    )
                                )
                                .WithMembers
                                (
                                    List
                                    (
                                        Enumerable.Repeat(standardProp, 1).Concat(otherProps).Concat(Enumerable.Repeat(ctor, 1))
                                    )
                                )
                        )
                    ).NormalizeWhitespace().ToFullString()
                );
            }
        }

        private static void Output(GeneratorExecutionContext context, string hintName, string s)
        {
            hintName = hintName.Select(x => char.IsLetterOrDigit(x) ? x : '_').ToArray().AsSpan().ToString();
            var name = $"{hintName}.{Guid.NewGuid()}.gen";
            context.AddSource(name, SourceText.From(s, Encoding.UTF8));
            // File.WriteAllText(@"C:\st\" + name, s);
        }

        private string ProcessClassDeclaration
        (
            IEnumerable<(ClassDeclarationSyntax, SemanticModel)> classDeclarations,
            GeneratorExecutionContext sourceContext,
            INamedTypeSymbol nativeApiAttributeSymbol,
            MarshalBuilder rootMarshalBuilder,
            ref List<ITypeSymbol> processedSymbols,
            INamedTypeSymbol excludeFromOverrideAttribute,
            INamedTypeSymbol sharedClassSymbol,
            ref List<(string Class, int Override)> overrideLog,
            INamedTypeSymbol pInvokeAttribute
        )
        {
            _nativeContextAttributes[pInvokeAttribute] = array => ((int) array[0].Value!,
                (string) array[1].Value! /* first return is just the lib target */, new PInvokeNativeContextOverride());
            var stopwatch = Stopwatch.StartNew();
            var compilation = sourceContext.Compilation;
            if (!classDeclarations.First().Item1.Modifiers.Any(x => x.IsKind(SyntaxKind.PartialKeyword)))
                return null;

            if (!classDeclarations.All(x => x.Item1.Parent.IsKind(SyntaxKind.NamespaceDeclaration)))
                return null;

            var namespaceDeclaration = (NamespaceDeclarationSyntax) classDeclarations.First().Item1.Parent;

            if (!namespaceDeclaration.Parent.IsKind(SyntaxKind.CompilationUnit))
                return null;

            var compilationUnit = (CompilationUnitSyntax) namespaceDeclaration.Parent;

            if (!compilation.HasImplicitConversion
                (sharedClassSymbol, compilation.GetTypeByMetadataName("Silk.NET.Core.Native.NativeApiContainer")))
                return null;

            var classIsSealed = classDeclarations.First().Item1.Modifiers.Any(x => x.Text == "sealed");
            var generateSeal = false;

            if (sourceContext.AnalyzerConfigOptions.GetOptions
                    (classDeclarations.First().Item1.SyntaxTree)
                .TryGetValue("silk_touch_sealed_vtable_creation", out var generateSealstr))
            {
                if (bool.TryParse(generateSealstr, out var v))
                    generateSeal = v;
            }

            bool compactFileFormat;

#if DEBUG
            compactFileFormat = true;
#else
            compactFileFormat = false;
#endif

            if (sourceContext.AnalyzerConfigOptions.GetOptions
                    (classDeclarations.First().Item1.SyntaxTree)
                .TryGetValue("silk_touch_compact_file_format", out var compactFileFormatStr))
            {
                if (bool.TryParse(compactFileFormatStr, out var v))
                    compactFileFormat = v;
            }


            var generateVTable = false;

            if (sourceContext.AnalyzerConfigOptions.GetOptions
                    (classDeclarations.First().Item1.SyntaxTree)
                .TryGetValue("silk_touch_vtable_generate", out var genvtablestr))
            {
                if (bool.TryParse(genvtablestr, out var v))
                    generateVTable = v;
            }

            var preloadVTable = false;

            if (sourceContext.AnalyzerConfigOptions.GetOptions
                    (classDeclarations.First().Item1.SyntaxTree)
                .TryGetValue("silk_touch_vtable_preload", out var vtablepreloadstr))
            {
                if (bool.TryParse(vtablepreloadstr, out var v))
                    preloadVTable = v;
            }

            var emitAssert = false;

            if (sourceContext.AnalyzerConfigOptions.GetOptions
                    (classDeclarations.First().Item1.SyntaxTree)
                .TryGetValue("silk_touch_vtable_tree_emit_assert", out var emitAssertStr))
            {
                if (bool.TryParse(emitAssertStr, out var v))
                    emitAssert = v;
            }

            var classAttribute = sharedClassSymbol.GetAttributes()
                .FirstOrDefault(x => SymbolEqualityComparer.Default.Equals(x.AttributeClass, nativeApiAttributeSymbol));

            var classNativeApiAttribute = classAttribute == default
                ? new NativeApiAttribute()
                : ToNativeApiAttribute(classAttribute);

            var newMembers = new List<MemberDeclarationSyntax>();

            int gcCount = 0;

            var generatedVTableName = NameGenerator.Name("GeneratedVTable");
            var entryPoints = new List<string>();
            var processedEntrypoints = new List<EntryPoint>();
            bool any = false;
            foreach (var (declaration, symbol, entryPoint, callingConvention) in from declaration in
                    from member in classDeclarations.SelectMany(x => x.Item1.Members.Select(x2 => (x2, x.Item2)))
                    where member.x2.IsKind(SyntaxKind.MethodDeclaration)
                    select ((MethodDeclarationSyntax) member.x2, member.Item2)
                let symbol = declaration.Item2.GetDeclaredSymbol(declaration.Item1)
                where symbol is not null
                let attribute = ToNativeApiAttribute
                (
                    symbol.GetAttributes()
                        .FirstOrDefault
                            (att => SymbolEqualityComparer.Default.Equals(att.AttributeClass, nativeApiAttributeSymbol))
                )
                where declaration.Item1.Modifiers.Any
                    (modifier => modifier.IsKind(SyntaxKind.PartialKeyword)) && symbol.PartialImplementationPart is null
                let entryPoint = NativeApiAttribute.GetEntryPoint(attribute, classNativeApiAttribute, symbol.Name)
                let callingConvention = NativeApiAttribute.GetCallingConvention(attribute, classNativeApiAttribute)
                select (declaration, symbol, entryPoint, callingConvention))
            {
                any = true;

                ProcessMethod
                (
                    sourceContext, rootMarshalBuilder, callingConvention, entryPoints, entryPoint, classIsSealed,
                    generateSeal, generateVTable, compactFileFormat, compilation, symbol, declaration.Item1, newMembers, ref gcCount,
                    processedEntrypoints, generatedVTableName, namespaceDeclaration, classDeclarations.First().Item1,
                    AddIfNotExists(compilationUnit.Usings, "Silk.NET.Core.Native", "Silk.NET.Core.Contexts")
                );
            }

            if (any)
            {
                if (!processedSymbols.Contains(sharedClassSymbol))
                {
                    newMembers.Add
                    (
                        MethodDeclaration
                        (
                            List<AttributeListSyntax>(),
                            TokenList(Token(SyntaxKind.ProtectedKeyword), Token(SyntaxKind.OverrideKeyword)),
                            PredefinedType(Token(SyntaxKind.IntKeyword)), null, Identifier("CoreGcSlotCount"), null,
                            ParameterList(), List<TypeParameterConstraintClauseSyntax>(), null,
                            ArrowExpressionClause
                            (
                                BinaryExpression
                                (
                                    SyntaxKind.AddExpression,
                                    LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(gcCount)),
                                    InvocationExpression
                                    (
                                        MemberAccessExpression
                                        (
                                            SyntaxKind.SimpleMemberAccessExpression, BaseExpression(),
                                            IdentifierName("CoreGcSlotCount")
                                        )
                                    )
                                )
                            ), Token(SyntaxKind.SemicolonToken)
                        )
                    );
                }

                processedSymbols.Add(sharedClassSymbol);
            }

            if (newMembers.Count == 0)
                return null;

            if (generateVTable && entryPoints.Count > 0)
            {
                newMembers.Add
                (
                    GenerateVTable
                    (
                        preloadVTable, entryPoints, emitAssert,
                        sourceContext.ParseOptions.PreprocessorSymbolNames.Any
                            (x => x is "NETCOREAPP" or "NET5" /* SEE INativeContext.cs in Core */),
                        generatedVTableName
                    )
                );
                newMembers.Add
                (
                    MethodDeclaration(IdentifierName("IVTable"), Identifier("CreateVTable"))
                        .WithModifiers
                        (
                            TokenList
                            (
                                generateSeal
                                    ? new[]
                                    {
                                        Token(SyntaxKind.ProtectedKeyword), Token(SyntaxKind.SealedKeyword),
                                        Token(SyntaxKind.OverrideKeyword)
                                    }
                                    : new[] { Token(SyntaxKind.ProtectedKeyword), Token(SyntaxKind.OverrideKeyword) }
                            )
                        )
                        .WithExpressionBody
                        (
                            ArrowExpressionClause
                            (
                                ObjectCreationExpression
                                    (IdentifierName(generatedVTableName))
                                .WithArgumentList(ArgumentList(SingletonSeparatedList(Argument(IdentifierName("_ctx")))))
                            )
                        )
                        .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                );
            }

            ProcessNativeContextOverrides
            (
                processedEntrypoints.ToArray(),
                ref newMembers,
                sharedClassSymbol,
                excludeFromOverrideAttribute,
                compilation,
                ref overrideLog
            );

            var newNamespace = namespaceDeclaration.WithMembers
                (
                    List
                    (
                        new MemberDeclarationSyntax[]
                        {
                            classDeclarations.First().Item1.WithMembers
                                (List(newMembers))
                            .WithAttributeLists(List<AttributeListSyntax>())
                        }
                    )
                )
                .WithUsings(AddIfNotExists(compilationUnit.Usings, "Silk.NET.Core.Native", "Silk.NET.Core.Contexts"));

            var result = newNamespace.NormalizeWhitespace().ToFullString();
            stopwatch.Stop();
            var reportTelemetry = true;

            reportTelemetry = sourceContext.AnalyzerConfigOptions.GetOptions(classDeclarations.First().Item1.SyntaxTree).TryGetValue
                ("silk_touch_telemetry", out var telstr) && bool.Parse(telstr);

            if (reportTelemetry)
                sourceContext.ReportDiagnostic
                (
                    Diagnostic.Create
                    (
                        Diagnostics.BuildInfo, classDeclarations.First().Item1.GetLocation(), gcCount,
                        stopwatch.ElapsedMilliseconds + "ms"
                    )
                );
            return result;
        }

        private static SyntaxList<UsingDirectiveSyntax> AddIfNotExists
            (SyntaxList<UsingDirectiveSyntax> list, params string[] usings)
        {
            foreach (var v in usings)
                if (!list.Any(x => x.Name is IdentifierNameSyntax a && a.Identifier.Text == v))
                    list = list.Add(UsingDirective(IdentifierName(v)));

            return list;
        }

        private static void ProcessMethod
        (
            GeneratorExecutionContext sourceContext,
            MarshalBuilder rootMarshalBuilder,
            CallingConvention callingConvention,
            List<string> entryPoints,
            string entryPoint,
            bool classIsSealed,
            bool generateSeal,
            bool generateVTable,
            bool compactFileFormat,
            Compilation compilation,
            IMethodSymbol symbol,
            MethodDeclarationSyntax declaration,
            List<MemberDeclarationSyntax> newMembers,
            ref int gcCount,
            List<EntryPoint> processedEntrypoints,
            string generatedVTableName,
            NamespaceDeclarationSyntax generationns,
            ClassDeclarationSyntax generationclass,
            SyntaxList<UsingDirectiveSyntax> generationusings
        )
        {
            const string invocationShimName = "StCall";

            static MemberAccessExpressionSyntax GetFuncPtrExpr
            (
                string generatedVTableName,
                string entryPoint
            ) => MemberAccessExpression
            (
                SyntaxKind.SimpleMemberAccessExpression,
                ParenthesizedExpression
                (
                    BinaryExpression
                    (
                        SyntaxKind.AsExpression, IdentifierName("CurrentVTable"),
                        IdentifierName(generatedVTableName)
                    )
                ), IdentifierSilk(entryPoint)
            );

            void BuildLoadInvoke(ref IMarshalContext ctx, Action next)
            {
                ctx.TransitionTo(SilkTouchStage.PreLoad);

                // this is terminal, we never call next

                var parameters = ctx.ResolveAllLoadParameters();


                entryPoints.Add(entryPoint);
                processedEntrypoints.Add
                (
                    new EntryPoint
                    (
                        entryPoint, callingConvention,
                        ctx.LoadTypes.Select
                            (
                                x => (TypeSyntax) IdentifierName
                                    (x.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat))
                            )
                            .ToArray(),
                        symbol
                    )
                );

                Func<IMarshalContext, ExpressionSyntax> expression;

                var hasFastWinapi = declaration.SyntaxTree.IsNet5OrGreater();
                var needsInvocationShim = callingConvention == CallingConvention.Winapi && !hasFastWinapi;

                if ((classIsSealed || generateSeal) && generateVTable)
                {
                    // build load + invocation
                    expression = ctx =>
                    {
                        var fPtrType = ctx.LoadTypes.GetFuncPtrType(callingConvention);
                        return InvocationExpression
                        (
                            needsInvocationShim ? IdentifierName(invocationShimName) : ParenthesizedExpression
                            (
                                CastExpression
                                (
                                    fPtrType,
                                    GetFuncPtrExpr(generatedVTableName, entryPoint)
                                )
                            ), ArgumentList(SeparatedList(parameters.Select(x => Argument(x.Value))))
                        );
                    };
                }
                else
                {
                    throw new Exception("FORCE-USE-VTABLE");
                }


                if (needsInvocationShim)
                {
                    ctx.AddSideEffect(ManualWinapiInvokeShim);
                }

                if (ctx.ReturnsVoid)
                {
                    var exp = expression(ctx); // this forces evaluation of everything until this point.
                    ctx.AddSideEffect(ctx => ExpressionStatement(exp));
                    ctx.ResultVariable = null;
                }
                else
                {
                    var id = ctx.DeclareVariable(ctx.ReturnLoadType, false);
                    ctx.ResultVariable = id;
                    ctx.SetVariable(id, expression);
                    _ = ctx.ResolveVariable(id).Value; // force evaluation of ret
                }

                ctx.CurrentResultType = ctx.ReturnLoadType;
                ctx.TransitionTo(SilkTouchStage.PostLoad);
            }

            try
            {
                var marshalBuilder = rootMarshalBuilder.Clone();

                marshalBuilder.Use(BuildLoadInvoke);

                var context = new MarshalContext(compilation, symbol, entryPoint);

                marshalBuilder.Run(context);

                var block = context.BuildFinalBlock();

                gcCount += context.GCCount;

                if (declaration.Modifiers.All(x => x.Text != "unsafe"))
                {
                    // this is not done as a middleware to allow middleware to prepend any variable declaration, even if it's unsafe
                    block = Block(UnsafeStatement(Token(SyntaxKind.UnsafeKeyword), block));
                }

                var method = declaration.WithBody(block)
                    .WithAttributeLists(default)
                    .WithSemicolonToken(default)
                    .WithParameterList
                    (
                        ParameterList
                        (
                            SeparatedList
                            (
                                declaration.ParameterList.Parameters.Select
                                (
                                    (x, i) => x.WithAttributeLists
                                            (default)
                                        .WithType
                                        (
                                            IdentifierName
                                            (
                                                symbol.Parameters[i]
                                                    .Type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)
                                            )
                                        )
                                )
                            )
                        )
                    )
                    .WithReturnType
                        (IdentifierName(symbol.ReturnType.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)));

                if (compactFileFormat)
                {
                    // append to members
                    newMembers.Add(method);
                }
                else
                {
                    // directly output
                    var newNamespace = generationns.WithMembers
                        (
                            List
                            (
                                new MemberDeclarationSyntax[]
                                {
                                    generationclass.WithMembers
                                        (List(new MemberDeclarationSyntax[] {method}))
                                    .WithAttributeLists(List<AttributeListSyntax>())
                                }
                            )
                        )
                        .WithUsings(generationusings);

                    var result = newNamespace.NormalizeWhitespace().ToFullString();
                    Output(sourceContext, symbol.ToDisplayString(), result);
                }
            }
            catch (Exception ex)
            {
                sourceContext.ReportDiagnostic
                    (Diagnostic.Create(Diagnostics.MethodClassFailure, declaration.GetLocation(), ex.ToString()));
            }

            InvocationExpressionSyntax ManualWinapiInvokeInnerExpr
            (
                IMarshalContext ctx,
                CallingConvention callingConvention
            ) => InvocationExpression
            (
                ParenthesizedExpression
                (
                    CastExpression
                    (
                        ctx.LoadTypes.GetFuncPtrType(callingConvention),
                        GetFuncPtrExpr(generatedVTableName, entryPoint)
                    )
                ),
                ArgumentList
                (
                    SeparatedList
                    (
                        Enumerable.Range
                                (0, ctx.LoadTypes.Length - 1)
                            .Select(x => Argument(IdentifierName($"arg{x}")))
                    )
                )
            );

            StatementSyntax ManualWinapiInvokeShim(IMarshalContext ctx)
            {
                var stdCallStmt = ManualWinapiInvokeInnerExpr(ctx, CallingConvention.StdCall);
                var cdeclStmt = ManualWinapiInvokeInnerExpr(ctx, CallingConvention.Cdecl);
                return LocalFunctionStatement
                    (
                        IdentifierName(ctx.ReturnLoadType.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)),
                        invocationShimName
                    )
                    .WithParameterList
                    (
                        ParameterList
                        (
                            SeparatedList
                            (
                                new ArraySegment<ITypeSymbol>(ctx.LoadTypes, 0, ctx.LoadTypes.Length - 1).Select
                                (
                                    (x, i) => Parameter(Identifier($"arg{i}"))
                                        .WithType
                                        (
                                            IdentifierName(x.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat))
                                        )
                                )
                            )
                        )
                    )
                    .WithBody
                    (
                        Block
                        (
                            IfStatement
                            (
                                MemberAccessExpression
                                (
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    MemberAccessExpression
                                    (
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        MemberAccessExpression
                                        (
                                            SyntaxKind.SimpleMemberAccessExpression,
                                            MemberAccessExpression
                                            (
                                                SyntaxKind.SimpleMemberAccessExpression,
                                                MemberAccessExpression
                                                (
                                                    SyntaxKind.SimpleMemberAccessExpression, IdentifierName("Silk"),
                                                    IdentifierName("NET")
                                                ), IdentifierName("Core")
                                            ), IdentifierName("Native")
                                        ), IdentifierName("SilkMarshal")
                                    ), IdentifierName("IsWinapiStdcall")
                                ),
                                Block
                                (
                                    ctx.ReturnsVoid
                                        ? ExpressionStatement(stdCallStmt)
                                            .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                                        : ReturnStatement(stdCallStmt)
                                            .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                                ),
                                ElseClause
                                (
                                    Block
                                    (
                                        ctx.ReturnsVoid
                                            ? ExpressionStatement(cdeclStmt)
                                                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                                            : ReturnStatement(cdeclStmt)
                                                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                                    )
                                )
                            )
                        )
                    )
                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
            }
        }

        private static NativeApiAttribute? ToNativeApiAttribute(AttributeData? attributeData)
        {
            if (attributeData is null)
                return null;

            var v = new NativeApiAttribute();
            var dictionary = attributeData.NamedArguments.ToDictionary(x => x.Key, x => x.Value);

            if (dictionary.TryGetValue(nameof(NativeApiAttribute.EntryPoint), out var entryPointConstant))
                v.EntryPoint = (string) entryPointConstant.Value;

            if (dictionary.TryGetValue(nameof(NativeApiAttribute.Prefix), out var prefixConstant))
                v.Prefix = (string) prefixConstant.Value;

            if (dictionary.TryGetValue(nameof(NativeApiAttribute.Convention), out var conventionConstant))
                v.Convention = (CallingConvention) conventionConstant.Value;

            return v;
        }
    }
}
