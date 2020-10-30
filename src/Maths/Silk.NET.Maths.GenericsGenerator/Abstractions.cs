// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Silk.NET.Maths.GenericsGenerator.ValueTypes;
using Silk.NET.Maths.GenericsGenerator.VariableTypes;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.Maths.GenericsGenerator
{
    public enum NumericTargetType
    {
        Byte,
        SByte,
        UShort,
        Short,
        UInt,
        Int,
        ULong,
        Long,
        Single,
        Double
    }

    public static class TargetTypeUtils
    {
        public static TypeSyntax GetTypeSyntax(this NumericTargetType numericTargetType) => numericTargetType switch
        {
            NumericTargetType.Byte => PredefinedType(Token(SyntaxKind.ByteKeyword)),
            NumericTargetType.SByte => PredefinedType(Token(SyntaxKind.SByteKeyword)),
            NumericTargetType.UShort => PredefinedType(Token(SyntaxKind.UShortKeyword)),
            NumericTargetType.Short => PredefinedType(Token(SyntaxKind.ShortKeyword)),
            NumericTargetType.UInt => PredefinedType(Token(SyntaxKind.UIntKeyword)),
            NumericTargetType.Int => PredefinedType(Token(SyntaxKind.IntKeyword)),
            NumericTargetType.ULong => PredefinedType(Token(SyntaxKind.ULongKeyword)),
            NumericTargetType.Long => PredefinedType(Token(SyntaxKind.LongKeyword)),
            NumericTargetType.Single => PredefinedType(Token(SyntaxKind.FloatKeyword)),
            NumericTargetType.Double => PredefinedType(Token(SyntaxKind.DoubleKeyword)),
            _ => throw new ArgumentOutOfRangeException(nameof(numericTargetType))
        };
    }
    
    public interface IValueProcessor
    {
        IValue Process(IValue value, Func<IValue> next);
    }

    /// <summary>
    /// Variable Processors process the raw Variables one after another. They are run before <see cref="IValueProcessor"/>
    /// These aren't needed in most cases. use <see cref="IValueProcessor"/> wherever possible
    /// </summary>
    /// <seealso cref="IValueProcessor"/>
    public interface IVariableProcessor
    {
        IEnumerable<IVariable> Process(IEnumerable<IVariable> variable);
    }

    public interface IScopeBuilder
    {
        List<StatementSyntax> Statements { get; set; }
        NumericTargetType NumericType { get; }
        ExpressionSyntax Resolve(IValue value);
        IScopeBuilder CreateSubBuilder();
    }

    public sealed class ScalarScopeBuilder : IScopeBuilder
    {
        public ScalarScopeBuilder(NumericTargetType type)
        {
            Statements = new List<StatementSyntax>();
            NumericType = type;
            ResolvedValues = new Dictionary<IValue, ExpressionSyntax>();
        }
        public List<StatementSyntax> Statements { get; set; }
        public NumericTargetType NumericType { get; }

        public ExpressionSyntax Resolve(IValue value)
        {
            if (ResolvedValues.TryGetValue(value, out var v))
                return v;

            var exp = value.BuildExpression(this, value.Children.Select(Resolve).ToImmutableArray());
            return ResolvedValues[value] = value.Type switch
            {
                Type.Numeric => ParenthesizedExpression
                    (CastExpression(NumericType.GetTypeSyntax(), ParenthesizedExpression(exp))),
                Type.Boolean => ParenthesizedExpression
                    (CastExpression(PredefinedType(Token(SyntaxKind.BoolKeyword)), ParenthesizedExpression(exp))),
                _ => throw new ArgumentOutOfRangeException
                    (nameof(value.Type), $"Unknown Type {Enum.GetName(typeof(Type), value.Type)}")
            };
        }

        public IScopeBuilder CreateSubBuilder()
        {
            return new ScalarScopeBuilder(NumericType);
        }

        private Dictionary<IValue, ExpressionSyntax> ResolvedValues { get; }
    }

    public interface IValue : IEquatable<IValue>, IDebugWriteable
    {
        IScope Scope { get; set; }
        IValue? Parent { get; set; }
        Type Type { get; }
        Optional<object> ConstantValue { get; }
        IEnumerable<IValue> Children { get; set; }
        int Step { get; }
        ExpressionSyntax BuildExpression
            (IScopeBuilder scopeBuilder, ImmutableArray<ExpressionSyntax> children);
    }

    public enum Type
    {
        Unknown = default,
        Numeric,
        Boolean,
    }

    public interface IVariable : IScopeable, IEquatable<IVariable>
    {
        IValue Value { get; set; }
        List<IVariableReference> References { get; set; }
        int ExtraReferences { get; set; }
    }

    public interface IVariableReference : IValue
    {
        
    }

    public interface IDebugWriteable
    {
        void DebugWrite(TextWriter writer, int indentation = 0);
    }

    public interface IScopeable : IDebugWriteable
    {
        void BuildStatement(IScopeBuilder builder);
    }

    public interface IScope : IScopeable
    {
        List<IScopeable> Scopeables { get; set; }
        IScope Parent { get; set; }
    }

    public static class Extensions
    {
        public static IValue WithChildren(this IValue value, IEnumerable<IValue> children)
        {
            value.Children = children;
            return value;
        }

        public static void AddChild(this IValue value, IValue child)
        {
            value.Children = value.Children.Where(x => x is not null).Append(child);
        }
        
        public static IVariable WithValue(this IVariable variable, IValue value)
        {
            variable.Value = value;
            return variable;
        }
    }
}
