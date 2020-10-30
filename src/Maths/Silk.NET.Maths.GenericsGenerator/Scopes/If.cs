// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.IO;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.Maths.GenericsGenerator.Scopes
{
    public sealed class If : IScope
    {
        public If(IValue condition)
        {
            if (condition.Type != Type.Boolean)
                throw new TypeMismatchException("Conditions have to be of type Boolean");

            Condition = condition;
        }

        public IValue Condition { get; }

        public List<IScopeable> Scopeables { get; set; } = new List<IScopeable>();
        public IScope Parent { get; set; }

        public void DebugWrite(TextWriter writer, int indentation = 0)
        {
            Helpers.Indent(writer, indentation);
            writer.WriteLine("BEGIN IF");
            Helpers.Indent(writer, indentation + 1);
            writer.WriteLine("BEGIN CONDITION");
            Condition.DebugWrite(writer, indentation + 2);
            Helpers.Indent(writer, indentation + 1);
            writer.WriteLine("BEGIN BODY");

            foreach (var scopeable in Scopeables)
            {
                scopeable.DebugWrite(writer, indentation + 2);
            }
        }

        public void BuildStatement(IScopeBuilder sourceScopeBuilder)
        {
            if (Condition.ConstantValue.HasValue)
            {
                if (!(bool) Condition.ConstantValue.Value)
                    return;
            }

            var scopeBuilder = sourceScopeBuilder.CreateSubBuilder();

            foreach (var scopeable in Scopeables)
            {
                scopeable.BuildStatement(scopeBuilder);
            }

            if (scopeBuilder.Statements.Count < 1)
                return;


            if (Condition.ConstantValue.HasValue)
            {
                if ((bool) Condition.ConstantValue.Value)
                {
                    sourceScopeBuilder.Statements.Add(Block(scopeBuilder.Statements));
                    return;
                }
            }

            sourceScopeBuilder.Statements.Add
                (IfStatement(scopeBuilder.Resolve(Condition), Block(scopeBuilder.Statements)));
        }
    }
}
