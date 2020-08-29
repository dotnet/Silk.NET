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
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch
{
    [Generator]
    public partial class NativeApiGenerator : ISourceGenerator
    {
        public void Initialize(InitializationContext context)
        {
            context.RegisterForSyntaxNotifications(() => new SyntaxReceiver());
        }

        public void Execute(SourceGeneratorContext context)
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

            marshalBuilder = new MarshalBuilder();

            marshalBuilder.Use(ParameterInitMiddleware);
            marshalBuilder.Use(StringMarshaller);
            marshalBuilder.Use(PinMiddleware);
            marshalBuilder.Use(SpanMarshaller);
            marshalBuilder.Use(BoolMarshaller);
            marshalBuilder.Use(PinObjectMarshaller);
            marshalBuilder.Use(DelegateMarshaller);

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
                    // File.WriteAllText(@"C:\SILK.NET\src\OpenGL\Silk.NET.OpenGL\" + name, s);
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
            SourceGeneratorContext sourceContext,
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

            var generateVTable = false;

            if (sourceContext.AnalyzerConfigOptions.GetOptions
                    (classDeclaration.SyntaxTree)
                .TryGetValue("silk_touch_vtable_generate", out var genvtablestr))
            {
                if (bool.TryParse(genvtablestr, out var v))
                    generateVTable = v;
            }

            var classAttribute = classSymbol.GetAttributes()
                .FirstOrDefault(x => SymbolEqualityComparer.Default.Equals(x.AttributeClass, nativeApiAttributeSymbol));

            var classNativeApiAttribute = classAttribute == default
                ? new NativeApiAttribute()
                : ToNativeApiAttribute(classAttribute);

            var newMembers = new List<MemberDeclarationSyntax>();

            int slotCount = 0;
            int gcCount = 0;
            var methods = classDeclaration.Members.Where
                    (x => x.IsKind(SyntaxKind.MethodDeclaration))
                .Select(x => (MethodDeclarationSyntax) x)
                .Select
                (
                    declaration => (declaration,
                        symbol: compilation.GetSemanticModel(declaration.SyntaxTree).GetDeclaredSymbol(declaration))
                )
                .Where(x => !(x.symbol is null))
                .Select
                (
                    x => (x.declaration, x.symbol,
                        attribute: x.symbol.GetAttributes()
                            .FirstOrDefault
                            (
                                x2 => SymbolEqualityComparer.Default.Equals(x2.AttributeClass, nativeApiAttributeSymbol)
                            ))
                )
                .Select(x => (x.declaration, x.symbol, ToNativeApiAttribute(x.attribute)))
                .Where
                (
                    x => x.declaration.Modifiers.Any
                        (x2 => x2.IsKind(SyntaxKind.PartialKeyword)) && x.symbol.PartialImplementationPart is null
                )
                .Select
                (
                    x => (declaration: x.declaration, symbol: x.symbol,
                        entryPoint: NativeApiAttribute.GetEntryPoint(x.Item3, classNativeApiAttribute, x.symbol.Name),
                        callingConvention: NativeApiAttribute.GetCallingConvention(x.Item3, classNativeApiAttribute))
                )
                .ToArray();
            List<string> entryPoints = new List<string>();
            foreach (var (declaration, symbol, entryPoint, callingConvention) in methods)
            {
                try
                {
                    var marshalBuilder = rootMarshalBuilder.Clone();

                    void BuildLoadInvoke(ref IMarshalContext ctx, Action next)
                    {
                        // this is terminal, we never call next

                        var parameters = ctx.ResolveAllLoadParameters();

                        var fPtrType = FunctionPointerType
                        (
                            Identifier(GetCallingConvention(callingConvention)),
                            SeparatedList
                            (
                                ctx.LoadTypes.Select
                                (
                                    x => Parameter
                                        (Identifier(x.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)))
                                )
                            )
                        );
                        if (!entryPoints.Contains(entryPoint))
                            entryPoints.Add(entryPoint);

                        // build load + invocation
                        Func<IMarshalContext, ExpressionSyntax> expression = ctx => InvocationExpression
                        (
                            ParenthesizedExpression
                            (
                                CastExpression
                                (
                                    fPtrType, InvocationExpression
                                    (
                                        IdentifierName("Load"), ArgumentList
                                        (
                                            SeparatedList
                                            (
                                                new[]
                                                {
                                                    Argument
                                                    (
                                                        LiteralExpression
                                                            (SyntaxKind.NumericLiteralExpression, Literal(ctx.Slot))
                                                    ),
                                                    Argument
                                                    (
                                                        LiteralExpression
                                                            (SyntaxKind.StringLiteralExpression, Literal(entryPoint))
                                                    )
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

                    marshalBuilder.Use(BuildLoadInvoke);

                    slotCount++;


                    var context = new MarshalContext(compilation, symbol, symbol.GetHashCode() ^ slotCount);

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
                        (
                            IdentifierName(symbol.ReturnType.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat))
                        );

                    // append to members
                    newMembers.Add(method);
                }
                catch (Exception ex)
                {
                    sourceContext.ReportDiagnostic
                        (Diagnostic.Create(Diagnostics.MethodClassFailure, declaration.GetLocation(), ex.ToString()));
                }
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
                var vTableMembers = new List<MemberDeclarationSyntax>();

                vTableMembers.Add
                (
                    FieldDeclaration
                    (
                        List<AttributeListSyntax>(), TokenList(Token(SyntaxKind.PrivateKeyword)),
                        VariableDeclaration
                        (
                            IdentifierName("Silk.NET.Core.Contexts.INativeContext"),
                            SingletonSeparatedList(VariableDeclarator("_ctx"))
                        )
                    )
                );

                vTableMembers.Add
                (
                    MethodDeclaration(PredefinedType(Token(SyntaxKind.VoidKeyword)), "Initialize")
                        .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                        .WithParameterList
                        (
                            ParameterList
                            (
                                SeparatedList
                                (
                                    new[]
                                    {
                                        Parameter
                                                (Identifier("ctx"))
                                            .WithType(IdentifierName("Silk.NET.Core.Contexts.INativeContext")),
                                        Parameter
                                                (Identifier("maxSlots"))
                                            .WithType(PredefinedType(Token(SyntaxKind.IntKeyword)))
                                    }
                                )
                            )
                        )
                        .WithBody
                        (
                            Block
                            (
                                ExpressionStatement
                                (
                                    AssignmentExpression
                                    (
                                        SyntaxKind.SimpleAssignmentExpression, IdentifierName("_ctx"),
                                        IdentifierName("ctx")
                                    )
                                )
                            )
                        )
                );

                List<VariableDeclaratorSyntax> slotVars = new List<VariableDeclaratorSyntax>();
                List<StatementSyntax> loadStatements = new List<StatementSyntax>();
                foreach (var entrypoint in entryPoints)
                {
                    var name = $"_{entrypoint}";
                    slotVars.Add(VariableDeclarator(name));
                    loadStatements.Add
                    (
                        IfStatement
                        (
                            BinaryExpression
                            (
                                SyntaxKind.EqualsExpression, IdentifierName("entryPoint"),
                                LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(entrypoint))
                            ),
                            Block
                            (
                                IfStatement
                                (
                                    BinaryExpression
                                    (
                                        SyntaxKind.NotEqualsExpression, IdentifierName(name),
                                        DefaultExpression(IdentifierName("System.IntPtr"))
                                    ), ReturnStatement(IdentifierName(name))
                                ),
                                ExpressionStatement
                                (
                                    AssignmentExpression
                                    (
                                        SyntaxKind.SimpleAssignmentExpression, IdentifierName(name),
                                        InvocationExpression
                                        (
                                            MemberAccessExpression
                                            (
                                                SyntaxKind.SimpleMemberAccessExpression, IdentifierName("_ctx"),
                                                IdentifierName("GetProcAddress")
                                            ),
                                            ArgumentList(SingletonSeparatedList(Argument(IdentifierName("entryPoint"))))
                                        )
                                    )
                                ), ReturnStatement(IdentifierName(name))
                            )
                        )
                    );
                }

                vTableMembers.Add
                (
                    MethodDeclaration
                            (PredefinedType(Token(SyntaxKind.VoidKeyword)), "GeneratedThrowHelperInvalidSlot")
                        .WithParameterList(ParameterList())
                        .WithModifiers(TokenList(Token(SyntaxKind.PrivateKeyword), Token(SyntaxKind.StaticKeyword)))
                        .WithBody
                        (
                            Block
                            (
                                ThrowStatement
                                (
                                    ObjectCreationExpression
                                        (
                                            QualifiedName
                                                (IdentifierName("System"), IdentifierName("InvalidOperationException"))
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
                                                        (
                                                            SyntaxKind.StringLiteralExpression, Literal("Invalid Slot")
                                                        )
                                                    )
                                                )
                                            )
                                        )
                                )
                            )
                        )
                );

                loadStatements.Add
                    (ExpressionStatement(InvocationExpression(IdentifierName("GeneratedThrowHelperInvalidSlot"))));
                loadStatements.Add(ReturnStatement(DefaultExpression(IdentifierName("System.IntPtr"))));

                vTableMembers.Add
                (
                    FieldDeclaration
                    (
                        List<AttributeListSyntax>(), TokenList(Token(SyntaxKind.PrivateKeyword)),
                        VariableDeclaration(IdentifierName("System.IntPtr"), SeparatedList(slotVars))
                    )
                );

                vTableMembers.Add
                (
                    MethodDeclaration(IdentifierName("System.IntPtr"), "Load")
                        .WithParameterList
                        (
                            ParameterList
                            (
                                SeparatedList
                                (
                                    new[]
                                    {
                                        Parameter
                                                (Identifier("slot"))
                                            .WithType(PredefinedType(Token(SyntaxKind.IntKeyword))),
                                        Parameter
                                                (Identifier("entryPoint"))
                                            .WithType(PredefinedType(Token(SyntaxKind.StringKeyword)))
                                    }
                                )
                            )
                        )
                        .WithBody(Block(loadStatements))
                        .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                );

                vTableMembers.Add
                (
                    MethodDeclaration(PredefinedType(Token(SyntaxKind.VoidKeyword)), "Purge")
                        .WithParameterList(ParameterList(SeparatedList<ParameterSyntax>()))
                        .WithBody
                        (
                            Block
                            (
                                entryPoints.Select
                                (
                                    x => ExpressionStatement
                                    (
                                        AssignmentExpression
                                        (
                                            SyntaxKind.SimpleAssignmentExpression, IdentifierName($"_{x}"),
                                            DefaultExpression(IdentifierName("System.IntPtr"))
                                        )
                                    )
                                )
                            )
                        )
                        .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                );

                vTableMembers.Add
                (
                    MethodDeclaration(PredefinedType(Token(SyntaxKind.VoidKeyword)), "Dispose")
                        .WithParameterList(ParameterList(SeparatedList<ParameterSyntax>()))
                        .WithBody(Block())
                        .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                );

                newMembers.Add
                (
                    ClassDeclaration
                    (
                        List<AttributeListSyntax>(),
                        TokenList(Token(SyntaxKind.PrivateKeyword), Token(SyntaxKind.SealedKeyword)),
                        Identifier("GeneratedVTable"), null,
                        BaseList
                        (
                            SingletonSeparatedList
                                ((BaseTypeSyntax) SimpleBaseType(IdentifierName("Silk.NET.Core.Native.IVTable")))
                        ), List<TypeParameterConstraintClauseSyntax>(), List(vTableMembers)
                    )
                );

                newMembers.Add
                (
                    MethodDeclaration(IdentifierName("IVTable"), Identifier("CreateVTable"))
                        .WithModifiers(TokenList(Token(SyntaxKind.ProtectedKeyword), Token(SyntaxKind.OverrideKeyword)))
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
            bool reportTelemetry = true;
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

        private static string GetCallingConvention(CallingConvention convention)
            => convention switch
            {
                // CallingConvention.Winapi => "", netstandard2.0 doesn't allow this
                CallingConvention.Cdecl => "cdecl",
                CallingConvention.ThisCall => "thiscall",
                CallingConvention.StdCall => "stdcall",
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
