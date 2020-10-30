// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.IO;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.Maths.GenericsGenerator.Scopes
{
    public sealed class Block : IScope
    {
        public List<IScopeable> Scopeables { get; set; } = new List<IScopeable>();
        public IScope Parent { get; set; }

        public void DebugWrite(TextWriter writer, int indentation = 0)
        {
            Helpers.Indent(writer, indentation);
            writer.WriteLine("BEGIN BLOCK");

            foreach (var scopeable in Scopeables)
            {
                scopeable.DebugWrite(writer, indentation + 1);
            }
        }

        public void BuildStatement(IScopeBuilder sourceScopeBuilder)
        {
            var scopeBuilder = sourceScopeBuilder.CreateSubBuilder();

            foreach (var scopeable in Scopeables)
            {
                scopeable.BuildStatement(scopeBuilder);
            }

            sourceScopeBuilder.Statements.Add(Block(scopeBuilder.Statements));
        }
    }
}
