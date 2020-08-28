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
            
            if (!(context.SyntaxReceiver is SyntaxReceiver receiver))
                return;

            var nativeApiAttribute = context.Compilation.GetTypeByMetadataName("Silk.NET.Core.Native.NativeApiAttribute");
            
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
                    (
                        receiverClassDeclaration, context, nativeApiAttribute, marshalBuilder,
                        ref processedSymbols
                    );

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
                        Diagnostic.Create(Diagnostics.ProcessClassFailure, receiverClassDeclaration.GetLocation(), ex.ToString())
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

            var classAttribute = classSymbol.GetAttributes()
                .FirstOrDefault(x => SymbolEqualityComparer.Default.Equals(x.AttributeClass, nativeApiAttributeSymbol));

            var classNativeApiAttribute = classAttribute == default
                ? new NativeApiAttribute()
                : ToNativeApiAttribute(classAttribute);

            var newMembers = new List<MemberDeclarationSyntax>();

            int slotCount = 0;
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
                .Where(x => x.declaration.Modifiers.Any(x2 => x2.IsKind(SyntaxKind.PartialKeyword)) && x.symbol.PartialImplementationPart is null)
                .Select
                (
                    x => (declaration: x.declaration, symbol: x.symbol,
                        entryPoint: NativeApiAttribute.GetEntryPoint(x.Item3, classNativeApiAttribute, x.symbol.Name),
                        callingConvention: NativeApiAttribute.GetCallingConvention(x.Item3, classNativeApiAttribute))
                )
                .ToArray();
            foreach (var (declaration, symbol, entryPoint, callingConvention) in methods)
            {
                try
                {
                    var marshalBuilder = rootMarshalBuilder.Clone();

                    void BuildLoadInvoke(ref IMarshalContext ctx, Action next)
                    {
                        // this is terminal, we never call next

                        var parameters = ctx.ResolveAllLoadParameters();
                        // build load + invocation
                        Func<IMarshalContext, ExpressionSyntax> expression = ctx => InvocationExpression
                        (
                            ParenthesizedExpression
                            (
                                CastExpression
                                (
                                    FunctionPointerType
                                    (
                                        Identifier(GetCallingConvention(callingConvention)),
                                        SeparatedList
                                        (
                                            ctx.LoadTypes.Select
                                            (
                                                x => Parameter
                                                (
                                                    Identifier
                                                        (x.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat))
                                                )
                                            )
                                        )
                                    ), InvocationExpression
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
                    (
                        Diagnostic.Create(Diagnostics.MethodClassFailure, declaration.GetLocation(), ex.ToString())
                    );
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
                }
                processedSymbols.Add(classSymbol);
            }

            if (newMembers.Count == 0)
                return null;

            var newNamespace = namespaceDeclaration.WithMembers
                (List(new MemberDeclarationSyntax[] {classDeclaration.WithMembers(List(newMembers)).WithAttributeLists(List<AttributeListSyntax>())})).WithUsings(compilationUnit.Usings);
            
            return newNamespace.NormalizeWhitespace().ToFullString();
        }

        private static string GetCallingConvention(CallingConvention convention) =>
            convention switch
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
