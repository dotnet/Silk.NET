// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using GenericMathsGenerator.ValueTypes;
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
        IEnumerable<IVariable> Process(IEnumerable<IVariable> variables);
    }

    public interface IValue : IEquatable<IValue>
    {
        Optional<float> ConstantValue { get; }
        IEnumerable<IValue> Children { get; set; }
        int Step { get; }
        ExpressionSyntax BuildExpression
            (ImmutableArray<ExpressionSyntax> children, ref List<StatementSyntax> statements, TargetType type);
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
