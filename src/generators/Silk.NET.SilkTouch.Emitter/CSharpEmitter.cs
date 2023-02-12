// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Silk.NET.SilkTouch.Symbols;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Emitter;

/// <summary>
/// The primary entrypoint for all C# related emission
/// </summary>
public sealed class CSharpEmitter
{
    /// <summary>
    /// Create a new <see cref="CSharpEmitter"/> from dependencies. This should generally be called by DI.
    /// </summary>
    public CSharpEmitter()
    {
        
    }

    /// <summary>
    /// Transforms the given <see cref="Silk.NET.SilkTouch.Symbols.Symbol"/> into a <see cref="CSharpSyntaxNode"/>
    /// </summary>
    /// <param name="symbol">The symbol to transform</param>
    /// <param name="typeStore">The <see cref="TypeStore"/> used</param>
    /// <returns>A syntax node, containing syntax depending on the symbol. The syntax node should produce valid C# code.</returns>
    /// <remarks>
    /// The returned syntax node may not be ideal and is not optimized for code size.
    /// In general it will contain code that is optimized for performance and clarity, this is not a guarantee though.
    /// It may contain comments that may be stripped for better code size.
    /// The returned node will never contain line comments, but other C# language feature may still rely on whitespace and/or newlines.
    /// Note that (block) comments will never be used to replace such whitespace, even if this is valid to allow a potential comment stripping to be a simple as possible.
    /// </remarks>
    public CSharpSyntaxNode Transform(Symbol symbol, TypeStore typeStore)
    {
        var visitor = new Visitor(Whitespace("    "), typeStore);
        visitor.Visit(symbol); // the result is ignored. This allows us to optimize the visitor in some cases.
        var syntax = visitor.Syntax;
        if (syntax is null)
            throw new NotImplementedException
                ("Resulting Syntax was null. This suggests some unimplemented root Symbol in the Visitor.");
        return syntax;
    }
    
    private class Visitor : Silk.NET.SilkTouch.Symbols.SymbolVisitor
    {
        private readonly SyntaxTrivia _indentation;
        public CSharpSyntaxNode? Syntax => _syntax;
        private CSharpSyntaxNode? _syntax = null;
        private SyntaxToken? _syntaxToken = null;
        private int _indentationCount = 0;

        private IEnumerable<SyntaxTrivia> Indentation => Enumerable.Repeat(_indentation, _indentationCount);
        private IEnumerable<SyntaxTrivia> NewLine => Indentation.Prepend(LineFeed);

        public Visitor(SyntaxTrivia indentation, TypeStore typeStore) : base(typeStore)
        {
            _indentation = indentation;
        }

        private void Indent() => _indentationCount++;
        private void Outdent() => _indentationCount--;

        protected override StructSymbol VisitStruct(StructSymbol structSymbol)
        {
            AssertClearState();
            
            VisitIdentifier(structSymbol.Identifier);
            if (_syntaxToken is not { } identifierToken)
                throw new InvalidOperationException("Field Identifier was not visited correctly");
            ClearState();

            Indent();
            var members = new List<MemberDeclarationSyntax>(structSymbol.Members.Length);
            
            foreach (var member in structSymbol.Members)
            {
                switch (member)
                {
                    case MethodSymbol method:
                    {
                        throw new NotImplementedException("Struct methods not implemented");
                    }

                    case FieldSymbol field:
                    {
                        VisitField(field);
                        if (_syntax is not MemberDeclarationSyntax memberDeclarationSyntax)
                            throw new InvalidOperationException("Member was not visited correctly");
                        ClearState();
                        memberDeclarationSyntax = memberDeclarationSyntax.WithLeadingTrivia(NewLine);
                        members.Add(memberDeclarationSyntax);
                        break;
                    }
                }
            }
            
            Outdent();
            
            var modifiers = TokenList(Token(SyntaxTriviaList.Empty, SyntaxKind.PublicKeyword, TriviaList(Space)));
            _syntax = StructDeclaration
                (
                    default, modifiers, identifierToken, null, null, List<TypeParameterConstraintClauseSyntax>(),
                    List(members)
                )
                .WithKeyword(Token(SyntaxTriviaList.Empty, SyntaxKind.StructKeyword, TriviaList(Space)))
                .WithOpenBraceToken(Token(TriviaList(NewLine), SyntaxKind.OpenBraceToken, SyntaxTriviaList.Empty))
                .WithCloseBraceToken(Token(TriviaList(NewLine), SyntaxKind.CloseBraceToken, SyntaxTriviaList.Empty));
            return structSymbol;
        }

        protected override ClassSymbol VisitClass(ClassSymbol classSymbol)
        {
            AssertClearState();

            VisitIdentifier(classSymbol.Identifier);
            if (_syntaxToken is not {} identifierSyntaxToken)
                throw new InvalidOperationException("Identifier was not visited correctly");
            ClearState();

            Indent();

            var members = new List<MemberDeclarationSyntax>();
            foreach (var member in classSymbol.Members)
            {
                switch (member)
                {
                    case MethodSymbol method:
                    {
                        VisitMethod(method);
                        if (_syntax is not MethodDeclarationSyntax mds)
                            throw new InvalidOperationException("Method not visited correctly");
                        ClearState();
                        members.Add(mds.WithLeadingTrivia(NewLine));
                        break;
                    }
                    case FieldSymbol field:
                    {
                        throw new NotImplementedException("Class fields not implemented");
                    }
                }
            }
            Outdent();

            _syntax = ClassDeclaration(identifierSyntaxToken.WithLeadingTrivia(Space))
                .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                .WithKeyword(Token(SyntaxKind.ClassKeyword).WithLeadingTrivia(Space))
                .WithOpenBraceToken(Token(SyntaxKind.OpenBraceToken).WithLeadingTrivia(NewLine))
                .WithCloseBraceToken(Token(SyntaxKind.CloseBraceToken).WithLeadingTrivia(NewLine))
                .WithMembers(List(members));
            
            return classSymbol;
        }

        protected override FieldSymbol VisitField(FieldSymbol fieldSymbol)
        {
            AssertClearState();
            
            VisitTypeReference(fieldSymbol.Type);
            if (_syntax is not IdentifierNameSyntax typeIdentifierSyntax)
                throw new InvalidOperationException("Field type Identifier was not visited correctly");
            ClearState();
            
            VisitIdentifier(fieldSymbol.Identifier);
            if (_syntaxToken is not { } identifierToken)
                throw new InvalidOperationException("Field Identifier was not visited correctly");
            ClearState();

            _syntax = FieldDeclaration
            (
                List<AttributeListSyntax>(),
                TokenList(Token(SyntaxTriviaList.Empty, SyntaxKind.PublicKeyword, TriviaList(Space))),
                VariableDeclaration
                (
                    typeIdentifierSyntax,
                    SingletonSeparatedList
                    (
                        VariableDeclarator
                            (identifierToken.WithLeadingTrivia(TriviaList(Space)))
                    )
                )
            );
            return fieldSymbol;
        }

        protected override NamespaceSymbol VisitNamespace(NamespaceSymbol namespaceSymbol)
        {
            AssertClearState();

            VisitIdentifier(namespaceSymbol.Identifier);
            if (_syntax is not IdentifierNameSyntax namespaceIdentifierSyntax)
                throw new InvalidOperationException("Namespace Identifier was not visited correctly");
            ClearState();

            Indent();
            var types = namespaceSymbol.Types.Select(x =>
            {
                VisitType(x);
                if (_syntax is not TypeDeclarationSyntax typeSyntax)
                    throw new InvalidOperationException("Namespace Member was not visited correctly");
                
                ClearState();
                return typeSyntax.WithLeadingTrivia(NewLine);
            }).ToArray();
            Outdent();

            _syntax = NamespaceDeclaration
                (
                    List<AttributeListSyntax>(), TokenList(), namespaceIdentifierSyntax.WithLeadingTrivia(TriviaList(Space)),
                    List<ExternAliasDirectiveSyntax>(), List<UsingDirectiveSyntax>(), List<MemberDeclarationSyntax>(types)
                )
                .WithOpenBraceToken(Token(TriviaList(NewLine),   SyntaxKind.OpenBraceToken, SyntaxTriviaList.Empty))
                .WithCloseBraceToken(Token(TriviaList(NewLine),  SyntaxKind.CloseBraceToken, SyntaxTriviaList.Empty));
            return namespaceSymbol;
        }

        protected override InternalTypeReference VisitInternalTypeReference(InternalTypeReference typeReference)
        {
            AssertClearState();
            
            if (!TypeStore.TryResolve(typeReference.ReferencedTypeId, out var type))
            {
                throw new NotImplementedException("Cannot handle unresolvable type ID");
            }

            // TODO: Fully resolve types
            VisitIdentifier(type!.Identifier);

            return typeReference;
        }

        protected override PointerTypeReference VisitPointerTypeReference(PointerTypeReference pointerTypeReference)
        {
            AssertClearState();

            VisitTypeReference(pointerTypeReference.Underlying);
            if (_syntaxToken is not {} innerToken)
                throw new InvalidOperationException("Type Reference was not visited correctly");
            ClearState();
            
            _syntaxToken = Identifier(innerToken.Text + "*");
            _syntax = IdentifierName(_syntaxToken.Value);
            
            return pointerTypeReference;
        }

        protected override FunctionPointerTypeReference VisitFunctionPointerTypeReference
            (FunctionPointerTypeReference functionPointerTypeReference)
        {
            AssertClearState();

            var paramList = functionPointerTypeReference.ParameterTypes
                .Append(functionPointerTypeReference.ReturnType)
                .Select
                (
                    (x, i) =>
                    {
                        VisitTypeReference(x);
                        if (_syntax is not TypeSyntax typeSyntax)
                            throw new InvalidOperationException("TypeReference did not return TypeSyntax");
                        ClearState();

                        if (i == 0 || i > functionPointerTypeReference.ParameterTypes.Length)
                            return typeSyntax;
                        else
                            return typeSyntax.WithLeadingTrivia(Space); // not ideal, but the easiest way to do this
                    }
                )
                .Select(FunctionPointerParameter)
                .ToImmutableArray();

            _syntax = FunctionPointerType
            (
                Token(SyntaxKind.DelegateKeyword),
                Token(SyntaxKind.AsteriskToken),
                FunctionPointerCallingConvention(Token(SyntaxKind.UnmanagedKeyword)).WithLeadingTrivia(Space),
                FunctionPointerParameterList
                (
                    SeparatedList(paramList)
                )
            );
            
            return functionPointerTypeReference;
        }

        protected override ExternalTypeReference VisitExternalTypeReference(ExternalTypeReference typeReference)
        {
            AssertClearState();

            if (typeReference.Namespace is null)
            {
                // if namespace is null, the reference is just equivalent to the type identifier
                VisitIdentifier(typeReference.TypeIdentifier);
            }
            else
            {
                VisitIdentifier(typeReference.Namespace);
                if (_syntaxToken is not {} @namespace)
                    throw new InvalidOperationException("Namespace Identifier was not visited correctly");
                ClearState();
                
                VisitIdentifier(typeReference.TypeIdentifier);

                if (_syntaxToken is not {} typeIdentifier)
                    throw new InvalidOperationException("External Type Identifier was not visited correctly");
                ClearState();

                _syntaxToken = Identifier(@namespace.Text + "." + typeIdentifier.Text);
                _syntax = IdentifierName(_syntaxToken.Value);
                return typeReference;
            }
            
            return typeReference;
        }

        protected override StaticExternalMethodSymbol VisitStaticExternalMethod(StaticExternalMethodSymbol staticExternalMethodSymbol)
        {
            AssertClearState();

            VisitTypeReference(staticExternalMethodSymbol.ReturnType);
            if (_syntax is not TypeSyntax returnSyntaxToken)
                throw new InvalidOperationException("Type Reference not correctly visited");
            ClearState();

            VisitIdentifier(staticExternalMethodSymbol.Identifier);
            if (_syntaxToken is not {} identifierToken)
                throw new InvalidOperationException("Type Reference not correctly visited");  
            ClearState();

            var parameters = staticExternalMethodSymbol.Parameters.Select
            (
                x =>
                {
                    VisitTypeReference(x.TypeReference);
                    if (_syntax is not TypeSyntax resultToken)
                        throw new InvalidOperationException("Type Reference not correctly visited");
                    ClearState();

                    VisitIdentifier(x.Identifier);
                    if (_syntaxToken is not {} identifierToken2)
                        throw new InvalidOperationException("Syntax Token was not correctly visited");
                    ClearState();

                    return Parameter(identifierToken2.WithLeadingTrivia(Space)).WithType(resultToken);
                }
            ).ToImmutableArray();

            _syntax = MethodDeclaration(returnSyntaxToken.WithLeadingTrivia(Space), identifierToken.WithLeadingTrivia(Space))
                .WithModifiers
                (
                    TokenList
                    (
                        Token(SyntaxKind.PublicKeyword),
                        Token(SyntaxKind.StaticKeyword).WithLeadingTrivia(Space),
                        Token(SyntaxKind.ExternKeyword).WithLeadingTrivia(Space)
                    )
                )
                .WithParameterList(ParameterList(SeparatedList(parameters)))
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));

            return staticExternalMethodSymbol;
        }

        protected override IdentifierSymbol VisitIdentifier(IdentifierSymbol identifierSymbol)
        {
            AssertClearState();
            
            _syntaxToken = Identifier(SyntaxTriviaList.Empty, identifierSymbol.Value, SyntaxTriviaList.Empty);
            _syntax = IdentifierName(_syntaxToken.Value);
            return identifierSymbol;
        }

        [Conditional("DEBUG")]
        private void AssertClearState()
        {
            Debug.Assert(_syntax is null);
            Debug.Assert(!_syntaxToken.HasValue);
        }

        private void ClearState()
        {
            _syntax = null;
            _syntaxToken = null;
        }
    }
}
