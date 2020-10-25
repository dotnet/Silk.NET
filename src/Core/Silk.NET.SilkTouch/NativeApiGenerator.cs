// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

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
            MarshalBuilder marshalBuilder;

            if (!context.Compilation.ReferencedAssemblyNames.Any
                (ai => ai.Name.Equals("Silk.NET.Core", StringComparison.OrdinalIgnoreCase)))
            {
                context.ReportDiagnostic(Diagnostic.Create(Diagnostics.SilkNetCoreMissing, Location.None));
                return;
            }

            if (!(context.SyntaxReceiver is SyntaxReceiver receiver))
                return;

            var nativeApiAttribute = context.Compilation.GetTypeByMetadataName
                ("Silk.NET.Core.Native.NativeApiAttribute");

            if (nativeApiAttribute is null)
                return;
                
            var pInvokeAttribute = context.Compilation.GetTypeByMetadataName
                ("Silk.NET.Core.Native.PInvokeOverride");

            if (pInvokeAttribute is null)
                return;

            _nativeContextAttributes[pInvokeAttribute] = array => (
                (string) array[0].Value! /* first return is just the lib target */, new PInvokeNativeContextOverride());
            
            
            marshalBuilder = new MarshalBuilder();

            marshalBuilder.Use(Middlewares.ParameterInitMiddleware);
            marshalBuilder.Use(Middlewares.StringMarshaller);
            marshalBuilder.Use(Middlewares.PinMiddleware);
            marshalBuilder.Use(Middlewares.SpanMarshaller);
            marshalBuilder.Use(Middlewares.BoolMarshaller);
            marshalBuilder.Use(Middlewares.PinObjectMarshaller);
            marshalBuilder.Use(Middlewares.DelegateMarshaller);
            marshalBuilder.Use(Middlewares.GenericPointerMarshaller);

            List<ITypeSymbol> processedSymbols = new List<ITypeSymbol>();

            foreach (var receiverClassDeclaration in receiver.ClassDeclarations)
            {
                try
                {
                    var s = ProcessClassDeclaration
                        (receiverClassDeclaration, context, nativeApiAttribute, marshalBuilder, ref processedSymbols);

                    if (s is null) continue;

                    var name =
                        $"{receiverClassDeclaration.Identifier.Text}.{receiverClassDeclaration.GetHashCode()}.gen";
                    context.AddSource(name, SourceText.From(s, Encoding.UTF8));
                    // File.WriteAllText(@"C:\SILK.NET\src\Lab\" + name, s);
                }
                catch (Exception ex)
                {
                    context.ReportDiagnostic
                    (
                        Diagnostic.Create
                            (Diagnostics.ProcessClassFailure, receiverClassDeclaration.GetLocation(), ex.ToString())
                    );
                }
            }
        }

        private string ProcessClassDeclaration
        (
            ClassDeclarationSyntax classDeclaration,
            GeneratorExecutionContext sourceContext,
            INamedTypeSymbol nativeApiAttributeSymbol,
            MarshalBuilder rootMarshalBuilder,
            ref List<ITypeSymbol> processedSymbols
        )
        {
            var stopwatch = Stopwatch.StartNew();
            var compilation = sourceContext.Compilation;
            if (!classDeclaration.Modifiers.Any(x => x.IsKind(SyntaxKind.PartialKeyword)))
                return null;

            if (!classDeclaration.Parent.IsKind(SyntaxKind.NamespaceDeclaration))
                return null;
            var namespaceDeclaration = (NamespaceDeclarationSyntax) classDeclaration.Parent;

            if (!namespaceDeclaration.Parent.IsKind(SyntaxKind.CompilationUnit))
                return null;

            var compilationUnit = (CompilationUnitSyntax) namespaceDeclaration.Parent;

            var classSymbol = ModelExtensions.GetDeclaredSymbol
                (compilation.GetSemanticModel(classDeclaration.SyntaxTree), classDeclaration) as ITypeSymbol;

            if (!compilation.HasImplicitConversion
                (classSymbol, compilation.GetTypeByMetadataName("Silk.NET.Core.Native.NativeApiContainer")))
                return null;
            
            var classIsSealed = classDeclaration.Modifiers.Any(x => x.Text == "sealed");
            var generateSeal = false;

            if (sourceContext.AnalyzerConfigOptions.GetOptions
                    (classDeclaration.SyntaxTree)
                .TryGetValue("silk_touch_sealed_vtable_creation", out var generateSealstr))
            {
                if (bool.TryParse(generateSealstr, out var v))
                    generateSeal = v;
            }
            
            
            var generateVTable = false;

            if (sourceContext.AnalyzerConfigOptions.GetOptions
                    (classDeclaration.SyntaxTree)
                .TryGetValue("silk_touch_vtable_generate", out var genvtablestr))
            {
                if (bool.TryParse(genvtablestr, out var v))
                    generateVTable = v;
            }
            
            var preloadVTable = false;

            if (sourceContext.AnalyzerConfigOptions.GetOptions
                    (classDeclaration.SyntaxTree)
                .TryGetValue("silk_touch_vtable_preload", out var vtablepreloadstr))
            {
                if (bool.TryParse(vtablepreloadstr, out var v))
                    preloadVTable = v;
            }
            
            var emitAssert = false;

            if (sourceContext.AnalyzerConfigOptions.GetOptions
                    (classDeclaration.SyntaxTree)
                .TryGetValue("silk_touch_vtable_tree_emit_assert", out var emitAssertStr))
            {
                if (bool.TryParse(emitAssertStr, out var v))
                    emitAssert = v;
            }

            var classAttribute = classSymbol.GetAttributes()
                .FirstOrDefault(x => SymbolEqualityComparer.Default.Equals(x.AttributeClass, nativeApiAttributeSymbol));

            var classNativeApiAttribute = classAttribute == default
                ? new NativeApiAttribute()
                : ToNativeApiAttribute(classAttribute);

            var newMembers = new List<MemberDeclarationSyntax>();

            int slotCount = 0;
            int gcCount = 0;
            
            Dictionary<int, string> entryPoints = new Dictionary<int, string>();
            var processedEntrypoints = new List<EntryPoint>();
            foreach (var (declaration, symbol, entryPoint, callingConvention) in from declaration in
                    from member in classDeclaration.Members
                    where member.IsKind(SyntaxKind.MethodDeclaration)
                    select (MethodDeclarationSyntax) member
                let symbol = compilation.GetSemanticModel(declaration.SyntaxTree).GetDeclaredSymbol(declaration)
                where symbol is not null
                let attribute = ToNativeApiAttribute
                (
                    symbol.GetAttributes()
                        .FirstOrDefault
                            (att => SymbolEqualityComparer.Default.Equals(att.AttributeClass, nativeApiAttributeSymbol))
                )
                where declaration.Modifiers.Any
                    (modifier => modifier.IsKind(SyntaxKind.PartialKeyword)) && symbol.PartialImplementationPart is null
                let entryPoint = NativeApiAttribute.GetEntryPoint(attribute, classNativeApiAttribute, symbol.Name)
                let callingConvention = NativeApiAttribute.GetCallingConvention(attribute, classNativeApiAttribute)
                select (declaration, symbol, entryPoint, callingConvention))
            {
                var slot = slotCount++;
                ProcessMethod
                (
                    sourceContext, rootMarshalBuilder, callingConvention, entryPoints, entryPoint, classIsSealed,
                    generateSeal, generateVTable, slot, compilation, symbol, declaration, newMembers,
                    ref gcCount, processedEntrypoints
                );
            }

            if (slotCount > 0)
            {
                if (!processedSymbols.Contains(classSymbol))
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

                processedSymbols.Add(classSymbol);
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
                            (x => x == "NETCOREAPP" || x == "NET5" /* SEE INativeContext.cs in Core */)
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
                                    (IdentifierName("GeneratedVTable"))
                                .WithArgumentList(ArgumentList())
                            )
                        )
                        .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                );
            }

            ProcessNativeContextOverrides(processedEntrypoints.ToArray(), ref newMembers, classSymbol, classDeclaration);

            var newNamespace = namespaceDeclaration.WithMembers
                (
                    List
                    (
                        new MemberDeclarationSyntax[]
                        {
                            classDeclaration.WithMembers
                                (List(newMembers))
                            .WithAttributeLists(List<AttributeListSyntax>())
                        }
                    )
                )
                .WithUsings(compilationUnit.Usings);

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
                        Diagnostics.BuildInfo, classDeclaration.GetLocation(), slotCount, gcCount,
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
            List<EntryPoint> processedEntrypoints
        )
        {
            void BuildLoadInvoke(ref IMarshalContext ctx, Action next)
            {
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
                            .ToArray()
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
                                SyntaxKind.AsExpression, IdentifierName("CurrentVTable"), IdentifierName("GeneratedVTable")
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
            }

            try
            {
                var marshalBuilder = rootMarshalBuilder.Clone();

                marshalBuilder.Use(BuildLoadInvoke);

                var context = new MarshalContext(compilation, symbol, symbol.GetHashCode() ^ slot);

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
