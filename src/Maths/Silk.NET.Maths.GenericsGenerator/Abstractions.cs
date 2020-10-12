// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using GenericMathsGenerator.ValueTypes;
using GenericMathsGenerator.VariableTypes;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace GenericMathsGenerator
{
    public enum TargetType
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
        public static TypeSyntax GetTypeSyntax(this TargetType targetType) => targetType switch
        {
            TargetType.Byte => PredefinedType(Token(SyntaxKind.ByteKeyword)),
            TargetType.SByte => PredefinedType(Token(SyntaxKind.SByteKeyword)),
            TargetType.UShort => PredefinedType(Token(SyntaxKind.UShortKeyword)),
            TargetType.Short => PredefinedType(Token(SyntaxKind.ShortKeyword)),
            TargetType.UInt => PredefinedType(Token(SyntaxKind.UIntKeyword)),
            TargetType.Int => PredefinedType(Token(SyntaxKind.IntKeyword)),
            TargetType.ULong => PredefinedType(Token(SyntaxKind.ULongKeyword)),
            TargetType.Long => PredefinedType(Token(SyntaxKind.LongKeyword)),
            TargetType.Single => PredefinedType(Token(SyntaxKind.FloatKeyword)),
            TargetType.Double => PredefinedType(Token(SyntaxKind.DoubleKeyword)),
            _ => throw new ArgumentOutOfRangeException(nameof(targetType))
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
        IEnumerable<IVariable> Process(IEnumerable<IVariable> variables);
    }

    public interface IBodyBuilder
    {
        List<StatementSyntax> Statements { get; set; }
        TargetType Type { get; }
        Dictionary<IValue, ExpressionSyntax> ResolvedValues { get; }
        ExpressionSyntax ResolveValue(IValue value);
    }

    public class ScalarBodyBuilder : IBodyBuilder
    {
        private readonly Func<IValue, IBodyBuilder, ExpressionSyntax> _resolveCallback;
        
        public ScalarBodyBuilder(List<StatementSyntax> statements, TargetType type, Func<IValue, IBodyBuilder, ExpressionSyntax> resolveCallback)
        {
            Statements = statements;
            Type = type;
            _resolveCallback = resolveCallback;
            ResolvedValues = new Dictionary<IValue, ExpressionSyntax>();
        }
        public List<StatementSyntax> Statements { get; set; }
        public TargetType Type { get; }
        public Dictionary<IValue, ExpressionSyntax> ResolvedValues { get; }
        public ExpressionSyntax ResolveValue(IValue value) => _resolveCallback(value, this);
    }

    public interface IValue : IEquatable<IValue>
    {
        Optional<float> ConstantValue { get; }
        IEnumerable<IValue> Children { get; set; }
        int Step { get; }
        ExpressionSyntax BuildExpression
            (IBodyBuilder bodyBuilder, ImmutableArray<ExpressionSyntax> children);
    }

    public interface IVariable : IEquatable<IVariable>
    {
        IValue Value { get; set; }
    }

    public static class Extensions
    {
        public static IValue WithChildren(this IValue value, IEnumerable<IValue> children)
        {
            value.Children = children;
            return value;
        }

        public static IVariable WithValue(this IVariable variable, IValue value)
        {
            variable.Value = value;
            return variable;
        }
    }
}
