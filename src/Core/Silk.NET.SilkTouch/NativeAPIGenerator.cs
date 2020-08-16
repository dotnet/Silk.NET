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
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Silk.NET.Core.Native;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch
{
    [Generator]
    public partial class NativeAPIGenerator : ISourceGenerator
    {
        private static volatile int _slot = 0;
        private MarshalBuilder _marshalBuilder;
        public void Initialize(InitializationContext context)
        {
            context.RegisterForSyntaxNotifications(() => new SyntaxReceiver());
        }

        public void Execute(SourceGeneratorContext context)
        {
            Debugger.Launch();
            if (!(context.SyntaxReceiver is SyntaxReceiver receiver))
                return;

            var nativeApiAttribute = context.Compilation.GetTypeByMetadataName("Silk.NET.Core.Native.NativeApiAttribute");
            
            if (nativeApiAttribute is null)
                return;
            
            _marshalBuilder = new MarshalBuilder();

            _marshalBuilder.Use(ParameterInitMiddleware);
            _marshalBuilder.Use(StringMarshaller);
            _marshalBuilder.Use(PinMiddleware);
            _marshalBuilder.Use(SpanMarshaller);
            _marshalBuilder.Use(BoolMarshaller);
            _marshalBuilder.Use(DelegateMarshaller);
            _marshalBuilder.Use(PinObjectMarshaller);

            foreach (var receiverClassDeclaration in receiver.ClassDeclarations)
            {
                var s = ProcessClassDeclaration(receiverClassDeclaration, context.Compilation, nativeApiAttribute);
                
                if (s is null) continue;

                var name = $"{receiverClassDeclaration.Identifier.Text}.gen.cs.gen";
                context.AddSource(name, SourceText.From(s, Encoding.UTF8));
                File.WriteAllText(@"C:\SILK.NET\src\OpenGL\Silk.NET.OpenGL\" + name, s);
            }
        }

        private string ProcessClassDeclaration
        (
            ClassDeclarationSyntax classDeclaration,
            Compilation compilation,
            INamedTypeSymbol nativeApiAttributeSymbol
        )
        {
            if (!classDeclaration.Modifiers.Any(x => x.IsKind(SyntaxKind.PartialKeyword)))
                return null;

            if (!classDeclaration.Parent.IsKind(SyntaxKind.NamespaceDeclaration))
                return null;
            var namespaceDeclaration = (NamespaceDeclarationSyntax) classDeclaration.Parent;

            if (!namespaceDeclaration.Parent.IsKind(SyntaxKind.CompilationUnit))
                return null;
            var compilationUnit = (CompilationUnitSyntax) namespaceDeclaration.Parent;

            var classSymbol = ModelExtensions.GetDeclaredSymbol
                (compilation.GetSemanticModel(classDeclaration.SyntaxTree), classDeclaration);

            var classAttribute = classSymbol.GetAttributes()
                .FirstOrDefault(x => SymbolEqualityComparer.Default.Equals(x.AttributeClass, nativeApiAttributeSymbol));

            var classNativeApiAttribute = classAttribute == default
                ? new NativeApiAttribute()
                : ToNativeApiAttribute(classAttribute);

            var newMembers = new List<MemberDeclarationSyntax>();

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
                .Where(x => x.attribute != default)
                .Select(x => (x.declaration, x.symbol, ToNativeApiAttribute(x.attribute)))
                .Where(x => x.declaration.Modifiers.Any(x2 => x2.IsKind(SyntaxKind.PartialKeyword)))
                .Select
                (
                    x => (declaration: x.declaration, symbol: x.symbol,
                        entryPoint: NativeApiAttribute.GetEntryPoint(x.Item3, classNativeApiAttribute, x.symbol.Name),
                        callingConvention: NativeApiAttribute.GetCallingConvention(x.Item3, classNativeApiAttribute))
                )
                .ToArray();
            foreach (var (declaration, symbol, entryPoint, callingConvention) in methods)
            {
                var marshalBuilder = _marshalBuilder.Clone();

                void BuildLoadInvoke(ref MarshalContext ctx, Action next)
                {
                    // this is terminal, we never call next
                    
                    // build load + invocation
                    var expression = InvocationExpression
                    (
                        ParenthesizedExpression
                        (
                            CastExpression
                            (
                                FunctionPointerType
                                (
                                    Identifier(GetCallingConvention(callingConvention)),
                                    SeparatedList(ctx.LoadTypes.Select(x => Parameter(Identifier(x.ToDisplayString()))))
                                ), InvocationExpression
                                (
                                    IdentifierName("Load"), ArgumentList
                                    (
                                        SeparatedList
                                        (
                                            new[]
                                            {
                                                Argument
                                                    (LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(ctx.Slot))),
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
                        ),
                        ArgumentList
                        (
                            SeparatedList
                            (
                                ctx.ParameterExpressions.Select(Argument)
                            )
                        )
                    );

                    StatementSyntax statement;
                    
                    if (ctx.ReturnsVoid)
                    {
                        statement = ExpressionStatement(expression);
                        ctx.ResultExpression = null;
                    }
                    else
                    {
                        // declare variable in outer scope
                        var name = $"res{ctx.Slot}";
                        
                        ctx.DeclareVariable(ctx.ReturnLoadType, name);

                        ctx.ResultExpression = IdentifierName(name);

                        statement = ExpressionStatement(AssignmentExpression
                            (SyntaxKind.SimpleAssignmentExpression, ctx.ResultExpression, expression));
                    }

                    ctx.CurrentStatements = ctx.CurrentStatements.Append(statement);
                    ctx.CurrentResultType = ctx.ReturnLoadType;
                }
                
                marshalBuilder.Use(BuildLoadInvoke);

                var slot = Interlocked.Increment(ref _slot);

               var context = new MarshalContext(compilation, symbol, slot);

               marshalBuilder.Run(context);
               context.ApplyPostProcessing();

               if (!context.ReturnsVoid)
                   context.CurrentStatements = context.CurrentStatements.Append(ReturnStatement(context.ResultExpression));

               var block = Block(context.CurrentStatements);
               
               if (declaration.Modifiers.All(x => x.Text != "unsafe"))
               {
                   // this is not done as a middleware to allow middlewares to prepend any variable declaration, even if it's unsafe
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
                               (declaration.ParameterList.Parameters.Select(x => x.WithAttributeLists(default)))
                       )
                   );

               // append to members
                newMembers.Add
                (
                    method
                );
            }
                           
            if (newMembers.Count == 0)
                return null;

            var newNamespace = namespaceDeclaration.WithMembers
                (List(new MemberDeclarationSyntax[] {classDeclaration.WithMembers(List(newMembers))})).WithUsings(compilationUnit.Usings);

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

        private static NativeApiAttribute ToNativeApiAttribute(AttributeData attributeData)
        {
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
