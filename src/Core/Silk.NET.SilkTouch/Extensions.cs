// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch
{
    internal static class Extensions
    {
        public static TSyntax AddTrailingSpace<TSyntax>(this TSyntax node) where TSyntax : SyntaxNode
        {
            return node.WithTrailingTrivia(node.GetTrailingTrivia().Append(Space));
        }
        
        public static TSyntax AddLeadingSpace<TSyntax>(this TSyntax node) where TSyntax : SyntaxNode
        {
            return node.WithLeadingTrivia(node.GetLeadingTrivia().Append(Space));
        }
        
        public static SyntaxToken AddTrailingSpace(this SyntaxToken node)
        {
            return node.WithTrailingTrivia(node.TrailingTrivia.Add(Space));
        }
        
        public static SyntaxToken AddLeadingSpace(this SyntaxToken node)
        {
            return node.WithLeadingTrivia(node.LeadingTrivia.Add(Space));
        }
    }
}
