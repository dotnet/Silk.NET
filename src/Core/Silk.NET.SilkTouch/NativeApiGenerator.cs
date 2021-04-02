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

            _nativeContextAttributes[pInvokeAttribute] = array => ((int) array[0].Value!,
                (string) array[1].Value! /* first return is just the lib target */, new PInvokeNativeContextOverride());


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


            foreach (var group in receiver.ClassDeclarations.Select(x => (x.Item1, x.Item2, x.Item2.GetDeclaredSymbol(x.Item1)))
                .GroupBy(x => x.Item3, SymbolEqualityComparer.Default))
            {
                try
                {
                    var s = ProcessClassDeclaration
                    (
                        group.Select(x => (x.Item1, x.Item2)), context, nativeApiAttribute, marshalBuilder, ref processedSymbols,
                        excludeFromOverrideAttribute, (INamedTypeSymbol)group.Key
                    );

                    if (s is null) continue;

                    var name =
                        $"{group.Key.Name}.{Guid.NewGuid()}.gen";
                    context.AddSource(name, SourceText.From(s, Encoding.UTF8));
                    // File.WriteAllText(@"C:\SILK.NET\src\Lab\" + name, s);
                }
                catch (Exception ex)
                {
                    context.ReportDiagnostic
                    (
                        Diagnostic.Create
                            (Diagnostics.ProcessClassFailure, group.First().Item1.GetLocation(), ex.ToString())
                    );
                }
            }
        }

        private string ProcessClassDeclaration
        (
            IEnumerable<(ClassDeclarationSyntax, SemanticModel)> classDeclarations,
            GeneratorExecutionContext sourceContext,
            INamedTypeSymbol nativeApiAttributeSymbol,
            MarshalBuilder rootMarshalBuilder,
            ref List<ITypeSymbol> processedSymbols,
            INamedTypeSymbol excludeFromOverrideAttribute,
            INamedTypeSymbol sharedClassSymbol
        )
        {
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

            int slotCount = 0;
            int gcCount = 0;
            
            var generatedVTableName = NameGenerator.Name("GeneratedVTable");
            Dictionary<int, string> entryPoints = new Dictionary<int, string>();
            var processedEntrypoints = new List<EntryPoint>();
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
                var slot = slotCount++; // even though technically that somehow makes slots defined behavior, THEY ARE NOT
                // SLOTS ARE UNDEFINED BEHAVIOR
                ProcessMethod
                (
                    sourceContext, rootMarshalBuilder, callingConvention, entryPoints, entryPoint, classIsSealed,
                    generateSeal, generateVTable, slot, compilation, symbol, declaration.Item1, newMembers,
                    ref gcCount, processedEntrypoints, generatedVTableName
                );
            }

            if (slotCount > 0)
            {
                if (!processedSymbols.Contains(sharedClassSymbol))
                {
                    newMembers.Add
                    (
                        MethodDeclaration
                        (
                            List<AttributeListSyntax>(),
                            TokenList(Token(SyntaxKind.ProtectedKeyword), Token(SyntaxKind.OverrideKeyword)),
                            PredefinedType(Token(SyntaxKind.IntKeyword)), null, Identifier("CoreGetSlotCount"), null,
                            ParameterList(), List<TypeParameterConstraintClauseSyntax>(), null,
                            ArrowExpressionClause
                            (
                                BinaryExpression
                                (
                                    SyntaxKind.AddExpression,
                                    LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(slotCount)),
                                    InvocationExpression
                                    (
                                        MemberAccessExpression
                                        (
                                            SyntaxKind.SimpleMemberAccessExpression, BaseExpression(),
                                            IdentifierName("CoreGetSlotCount")
                                        )
                                    )
                                )
                            ), Token(SyntaxKind.SemicolonToken)
                        )
                    );
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
                            (x => x == "NETCOREAPP" || x == "NET5" /* SEE INativeContext.cs in Core */),
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
                                    : new[] {Token(SyntaxKind.ProtectedKeyword), Token(SyntaxKind.OverrideKeyword)}
                            )
                        )
                        .WithExpressionBody
                        (
                            ArrowExpressionClause
                            (
                                ObjectCreationExpression
                                    (IdentifierName(generatedVTableName))
                                .WithArgumentList(ArgumentList())
                            )
                        )
                        .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                );
            }

            ProcessNativeContextOverrides(processedEntrypoints.ToArray(), ref newMembers, sharedClassSymbol, excludeFromOverrideAttribute);
            
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
                .WithUsings(compilationUnit.Usings.Add(UsingDirective(IdentifierName("Silk.NET.Core.Native"))).Add(UsingDirective(IdentifierName("Silk.NET.Core.Contexts"))));

            var result = newNamespace.NormalizeWhitespace().ToFullString();
            stopwatch.Stop();
            var reportTelemetry = true;
#if !DEBUG
            reportTelemetry = sourceContext.AnalyzerConfigOptions.GlobalOptions.TryGetValue
                ("silk_touch_telemetry", out var telstr) && bool.Parse(telstr);
#endif
            if (reportTelemetry)
                sourceContext.ReportDiagnostic
                (
                    Diagnostic.Create
                    (
                        Diagnostics.BuildInfo, classDeclarations.First().Item1.GetLocation(), slotCount, gcCount,
                        stopwatch.ElapsedMilliseconds + "ms"
                    )
                );
            return result;
        }

        private static void ProcessMethod
        (
            GeneratorExecutionContext sourceContext,
            MarshalBuilder rootMarshalBuilder,
            CallingConvention callingConvention,
            Dictionary<int, string> entryPoints,
            string entryPoint,
            bool classIsSealed,
            bool generateSeal,
            bool generateVTable,
            int slot,
            Compilation compilation,
            IMethodSymbol symbol,
            MethodDeclarationSyntax declaration,
            List<MemberDeclarationSyntax> newMembers,
            ref int gcCount,
            List<EntryPoint> processedEntrypoints,
            string generatedVTableName
        )
        {
            void BuildLoadInvoke(ref IMarshalContext ctx, Action next)
            {
                ctx.TransitionTo(SilkTouchStage.PreLoad);

                // this is terminal, we never call next

                var parameters = ctx.ResolveAllLoadParameters();

                var fPtrType = FunctionPointerType
                (
                    FunctionPointerCallingConvention
                    (
                        Token(SyntaxKind.UnmanagedKeyword),
                        FunctionPointerUnmanagedCallingConventionList
                        (
                            SingletonSeparatedList
                            (
                                FunctionPointerUnmanagedCallingConvention
                                    (Identifier(GetCallingConvention(callingConvention)))
                            )
                        )
                    ),
                    FunctionPointerParameterList
                    (
                        SeparatedList
                        (
                            ctx.LoadTypes.Select
                            (
                                x => FunctionPointerParameter
                                    (IdentifierName(x.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)))
                            )
                        )
                    )
                );
                entryPoints[ctx.Slot] = entryPoint;
                processedEntrypoints.Add
                (
                    new EntryPoint
                    (
                        entryPoint, ctx.Slot, callingConvention,
                        ctx.LoadTypes.Select
                            (
                                x => (TypeSyntax) IdentifierName
                                    (x.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat))
                            )
                            .ToArray(),
                        symbol
                    )
                );

                ExpressionSyntax loadCallTarget;

                if ((classIsSealed || generateSeal) && generateVTable)
                {
                    loadCallTarget = MemberAccessExpression
                    (
                        SyntaxKind.SimpleMemberAccessExpression,
                        ParenthesizedExpression
                        (
                            BinaryExpression
                            (
                                SyntaxKind.AsExpression, IdentifierName("CurrentVTable"), IdentifierName(generatedVTableName)
                            )
                        ), IdentifierName("Load")
                    );
                }
                else
                {
                    loadCallTarget = IdentifierName("Load");
                }

                // build load + invocation
                Func<IMarshalContext, ExpressionSyntax> expression = ctx => InvocationExpression
                (
                    ParenthesizedExpression
                    (
                        CastExpression
                        (
                            fPtrType, InvocationExpression
                            (
                                loadCallTarget, ArgumentList
                                (
                                    SeparatedList
                                    (
                                        new[]
                                        {
                                            Argument
                                                (LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(ctx.Slot))),
                                            Argument
                                                (LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(entryPoint)))
                                        }
                                    )
                                )
                            )
                        )
                    ), ArgumentList(SeparatedList(parameters.Select(x => Argument(x.Value))))
                );

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

                var context = new MarshalContext(compilation, symbol, slot);

                marshalBuilder.Run(context);

                var block = context.BuildFinalBlock();

                gcCount += context.GCCount;

                if (declaration.Modifiers.All(x => x.Text != "unsafe"))
                {
                    // this is not done as a middleware to allow middleware to prepend any variable declaration, even if it's unsafe
                    block = Block(UnsafeStatement(Token(SyntaxKind.UnsafeKeyword), block));
                }

                var method = declaration.WithBody
                        (block)
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

                // append to members
                newMembers.Add(method);
            }
            catch (Exception ex)
            {
                sourceContext.ReportDiagnostic
                    (Diagnostic.Create(Diagnostics.MethodClassFailure, declaration.GetLocation(), ex.ToString()));
            }
        }

        private static string GetCallingConvention(CallingConvention convention)
            => convention switch
            {
                // CallingConvention.Winapi => "", netstandard2.0 doesn't allow this
                CallingConvention.Cdecl => "Cdecl",
                CallingConvention.ThisCall => "Thiscall",
                CallingConvention.StdCall => "Stdcall",
                CallingConvention.FastCall => "Fastcall",
                _ => throw new ArgumentException("convention is invalid", nameof(convention))
            };

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
