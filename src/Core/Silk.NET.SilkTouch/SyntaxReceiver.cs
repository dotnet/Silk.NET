// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Silk.NET.SilkTouch
{
    public partial class NativeApiGenerator
    {
        public class SyntaxReceiver : ISyntaxContextReceiver
        {
            public List<(ClassDeclarationSyntax, SemanticModel)> ClassDeclarations = new();

            public void OnVisitSyntaxNode(GeneratorSyntaxContext context)
            {
                if (context.Node is ClassDeclarationSyntax cds)
                {
                    ClassDeclarations.Add((cds, context.SemanticModel));
                }
            }
        }
    }
}
