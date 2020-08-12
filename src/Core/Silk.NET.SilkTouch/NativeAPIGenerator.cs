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
    public class NativeAPIGenerator : ISourceGenerator
    {
        private static volatile int _slot = 0;
        
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
                .Where(x => x.declaration.Modifiers.Any(x => x.IsKind(SyntaxKind.PartialKeyword)))
                .Select
                (
                    x => (declaration: x.declaration, symbol: x.symbol,
                        entryPoint: NativeApiAttribute.GetEntryPoint(x.Item3, classNativeApiAttribute, x.symbol.Name),
                        callingConvention: NativeApiAttribute.GetCallingConvention(x.Item3, classNativeApiAttribute))
                )
                .ToArray();
            foreach (var (declaration, symbol, entryPoint, callingConvention) in methods)
            {
                // NOTE: This function is sort of backwards, because we first generate the Load + call and then wrap it in blocks generated from parameters

                var slot = Interlocked.Increment(ref _slot);

                var marshalled =

                // build parameter-marshaller pairs
                symbol.Parameters.Select(x => (parameter: x, marshaller: GetParameterMarshaller(x)))

                // marshal parameters
                .Select
                (
                    (x, i) =>
                    {
                        var applyStatements = x.marshaller.Marshal
                            (x.parameter, i, out var loadType, out var invokeParameter);

                        return (applyStatements, loadType, invokeParameter);
                    }
                ).ToArray();


                ParameterSyntax returnLoadType;
                Func<InvocationExpressionSyntax, BlockSyntax> buildBlock;
                
                // marshal return
                if (!symbol.ReturnsVoid)
                {
                    var marshaller = GetReturnMarshaller(symbol.ReturnType);
                    buildBlock = marshaller.Marshal(symbol.ReturnType, out returnLoadType);
                }
                else
                {
                    returnLoadType = Parameter(Identifier("void"));
                    buildBlock = load => Block(ExpressionStatement(load));
                }

                // build load + invocation
                var loadExpression = InvocationExpression
                (
                    ParenthesizedExpression
                    (
                        CastExpression
                        (
                            FunctionPointerType
                            (
                                Identifier(GetCallingConvention(callingConvention)),
                                SeparatedList(marshalled.Select(x => x.loadType).Append(returnLoadType))
                            ), InvocationExpression
                            (
                                IdentifierName("Load"), ArgumentList
                                (
                                    SeparatedList
                                    (
                                        new[]
                                        {
                                            Argument
                                                (LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(slot))),
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
                            marshalled.Select
                                (x => Argument(x.invokeParameter))
                        )
                    )
                );
                
                BlockSyntax block;

                if (symbol.ReturnsVoid)
                    // build loest block (LOADEXPR)
                    block = Block(ExpressionStatement(loadExpression));
                else
                    // build lowest block
                    block = buildBlock(loadExpression);

                // apply parameter marshalling
                block = marshalled.Aggregate(block, (current, parameter) => parameter.applyStatements(current));

                block = Block(UnsafeStatement(Token(SyntaxKind.UnsafeKeyword), block));

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

        private const string ResultName = "res";
        
        private static IParameterMarshaller GetParameterMarshaller(IParameterSymbol parameterSymbol)
        {
            return new BaseParameterMarshaller();
        }
        
        private static IReturnMarshaller GetReturnMarshaller(ITypeSymbol typeSymbol)
        {
            if (typeSymbol.SpecialType == SpecialType.System_Boolean)
                return new BoolReturnMarshaller();
            
            return new BaseReturnMarshaller();
        }

        private interface IReturnMarshaller
        {
            Func<InvocationExpressionSyntax, BlockSyntax> Marshal(ITypeSymbol parameter, out ParameterSyntax loadType);
        }
        
        private class BaseReturnMarshaller : IReturnMarshaller
        {
            public virtual Func<InvocationExpressionSyntax, BlockSyntax> Marshal(ITypeSymbol parameter, out ParameterSyntax loadType)
            {
                loadType = Parameter(Identifier(parameter.ToDisplayString()));

                return load => Block
                (
                    ReturnStatement(load)
                );
            }
        }
        
        private class BoolReturnMarshaller : IReturnMarshaller
        {
            public Func<InvocationExpressionSyntax, BlockSyntax> Marshal(ITypeSymbol parameter, out ParameterSyntax loadType)
            {
                loadType = Parameter(Identifier("byte"));

                return load => Block
                (
                    ReturnStatement
                    (
                        BinaryExpression
                        (
                            SyntaxKind.EqualsExpression, load,
                            LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(1))
                        )
                    )
                );
            }
        }

        private interface IParameterMarshaller
        {
            Func<BlockSyntax, BlockSyntax> Marshal(IParameterSymbol parameter, int id, out ParameterSyntax loadType, out ExpressionSyntax invokeParameter);
        }
        
        private class BaseParameterMarshaller : IParameterMarshaller
        {
            public virtual Func<BlockSyntax, BlockSyntax> Marshal(IParameterSymbol parameter, int id, out ParameterSyntax loadType, out ExpressionSyntax invokeParameter)
            {
                Func<BlockSyntax, BlockSyntax> func;
                var name = $"p{id}";
                switch (parameter.RefKind)
                {
                    case RefKind.None:
                        func = child => Block
                        (
                            LocalDeclarationStatement
                            (
                                VariableDeclaration
                                (
                                    IdentifierName("var"), SeparatedList
                                    (
                                        new[]
                                        {
                                            VariableDeclarator
                                            (
                                                Identifier(name), null,
                                                EqualsValueClause(IdentifierName(FormatName(parameter.Name)))
                                            )
                                        }
                                    )
                                )
                            ), child
                        );
                        loadType = Parameter(Identifier(parameter.Type.ToDisplayString()));
                        break;
                    case RefKind.In:
                    case RefKind.Out:
                    case RefKind.Ref:
                        func = child => Block
                        (
                            FixedStatement
                            (
                                VariableDeclaration
                                (
                                    IdentifierName(parameter.Type.ToDisplayString() + "*"), SeparatedList
                                    (
                                        new[]
                                        {
                                            VariableDeclarator(Identifier(name), default, EqualsValueClause(PrefixUnaryExpression(SyntaxKind.AddressOfExpression, IdentifierName(FormatName(parameter.Name)))))
                                        }
                                    )
                                ), child
                            )
                        );
                        loadType = Parameter(Identifier(parameter.Type.ToDisplayString() + "*"));
                        break;
                    default:
                        throw new Exception();
                }

                invokeParameter = IdentifierName(name);
                
                return func;
            }
        }

        private static string FormatName(string name)
        {
            if (CSharpKeywords.Contains(name))
                return "@" + name;
            return name;
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

        public class SyntaxReceiver : ISyntaxReceiver
        {
            public List<ClassDeclarationSyntax> ClassDeclarations = new List<ClassDeclarationSyntax>();
            
            public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
            {
                if (syntaxNode is ClassDeclarationSyntax cds) ClassDeclarations.Add(cds);
            }
        }
        
        public static List<string> CSharpKeywords => new List<string>
        {
            "abstract",
            "event",
            "new",
            "struct",
            "as",
            "explicit",
            "null",
            "switch",
            "base",
            "extern",
            "object",
            "this",
            "bool",
            "false",
            "operator",
            "throw",
            "break",
            "finally",
            "out",
            "true",
            "byte",
            "fixed",
            "override",
            "try",
            "case",
            "float",
            "params",
            "typeof",
            "catch",
            "for",
            "private",
            "uint",
            "char",
            "foreach",
            "protected",
            "ulong",
            "checked",
            "goto",
            "public",
            "unchecked",
            "class",
            "if",
            "readonly",
            "unsafe",
            "const",
            "implicit",
            "ref",
            "ushort",
            "continue",
            "in",
            "return",
            "using",
            "decimal",
            "int",
            "sbyte",
            "virtual",
            "default",
            "interface",
            "sealed",
            "volatile",
            "delegate",
            "internal",
            "short",
            "void",
            "do",
            "is",
            "sizeof",
            "while",
            "double",
            "lock",
            "stackalloc",
            "else",
            "long",
            "static",
            "enum",
            "namespace",
            "string"
        };
    }
}
