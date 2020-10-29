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

    public interface IBodyBuilder
    {
        List<StatementSyntax> Statements { get; set; }
        NumericTargetType NumericType { get; }
        Dictionary<IValue, ExpressionSyntax> ResolvedValues { get; }
    }

    public class ScalarBodyBuilder : IBodyBuilder
    {
        public ScalarBodyBuilder(List<StatementSyntax> statements, NumericTargetType type)
        {
            Statements = statements;
            NumericType = type;
            ResolvedValues = new Dictionary<IValue, ExpressionSyntax>();
        }
        public List<StatementSyntax> Statements { get; set; }
        public NumericTargetType NumericType { get; }
        public Dictionary<IValue, ExpressionSyntax> ResolvedValues { get; }
    }

    public interface IValue : IEquatable<IValue>
    {
        Scope Scope { get; set; }
        IValue? Parent { get; set; }
        Type Type { get; }
        Optional<object> ConstantValue { get; }
        IEnumerable<IValue> Children { get; set; }
        int Step { get; }
        ExpressionSyntax BuildExpression
            (IBodyBuilder bodyBuilder, ImmutableArray<ExpressionSyntax> children);
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
        StatementSyntax BuildStatement(IBodyBuilder builder, ExpressionSyntax value);
    }

    public interface IVariableReference : IValue
    {
        
    }

    public interface IScopeable
    {
        
    }
    
    public sealed class Scope : IScopeable
    {
        public List<IScopeable> Scopeables = new List<IScopeable>();
        private IValue _condition;
        public Scope Parent { get; set; }

        public IValue Condition
        {
            get => _condition;
            set
            {
                if (value.Type != Type.Boolean)
                    throw new TypeMismatchException
                    (
                        $"Conditions type was {Enum.GetName(typeof(Type), value.Type)} but should be {nameof(Type.Boolean)}"
                    );
                _condition = value;
            }
        }

        [Conditional("DEBUG")]
        public void DebugWrite(TextWriter file, int indentation = 0)
        {
            static void Indent(TextWriter file, int count)
            {
                file.Write(new string(' ', count * 2));
            }

            static void DebugWriteValue(TextWriter writer, int indentation, IValue value)
            {
                switch (value)
                {
                    case AddValue addValue:
                        Indent(writer, indentation);
                        writer.WriteLine("BEGIN ADD");

                        indentation++;
                        DebugWriteValue(writer, indentation, addValue.Left);
                        DebugWriteValue(writer, indentation, addValue.Right);
                        indentation--;
                        break;
                    case DivideValue divideValue:
                        Indent(writer, indentation);
                        writer.WriteLine("BEGIN DIV");

                        indentation++;
                        DebugWriteValue(writer, indentation, divideValue.Left);
                        DebugWriteValue(writer, indentation, divideValue.Right);
                        indentation--;
                        break;
                    case MultiplyValue multiplyValue:
                        Indent(writer, indentation);
                        writer.WriteLine("BEGIN MUL");

                        indentation++;
                        DebugWriteValue(writer, indentation, multiplyValue.Left);
                        DebugWriteValue(writer, indentation, multiplyValue.Right);
                        indentation--;
                        break;
                    case SubtractValue subtractValue:
                        Indent(writer, indentation);
                        writer.WriteLine("BEGIN SUB");

                        indentation++;
                        DebugWriteValue(writer, indentation, subtractValue.Left);
                        DebugWriteValue(writer, indentation, subtractValue.Right);
                        indentation--;
                        break;
                    case NegateValue negateValue:
                        Indent(writer, indentation);
                        writer.WriteLine("BEGIN NEGATE");

                        indentation++;
                        DebugWriteValue(writer, indentation, negateValue.Child);
                        indentation--;
                        break;
                    case ParameterReferenceValue parameterReferenceValue:
                        Indent(writer, indentation);
                        writer.WriteLine($"PARAM REF {parameterReferenceValue.ParameterName}");
                        break;
                    case FieldReferenceValue fieldReferenceValue:
                        Indent(writer, indentation);
                        writer.WriteLine($"PARAM REF {fieldReferenceValue.Name}");
                        break;
                    case LiteralValue literalValue:
                        Indent(writer, indentation);
                        writer.WriteLine($"LITERAL {literalValue.ConstantValue.Value}");
                        break;
                    case LocalReferenceValue localReferenceValue:
                        Indent(writer, indentation);
                        writer.WriteLine($"LOCAL REF {localReferenceValue.Name}");
                        break;
                    case PropertyReferenceValue propertyReferenceValue:
                        Indent(writer, indentation);
                        writer.WriteLine($"PROPERTY REF {propertyReferenceValue.Name}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(value));
                }
            }
            
            Indent(file, indentation);
            file.WriteLine("BEGIN SCOPE");
            
            foreach (var scopeable in Scopeables)
            {
                if (scopeable is Scope s)
                {
                    s.DebugWrite(file, indentation + 1);
                }
                else if (scopeable is IVariable v)
                {
                    switch (v)
                    {
                        case LocalVariable localVariable:
                            indentation++;
                            
                            Indent(file, indentation);
                            file.WriteLine($"BEGIN LOCAL VAR {localVariable.OriginalName} REFC: {localVariable.References.Count}");
                            DebugWriteValue(file, indentation + 1, localVariable.Value);

                            indentation--;
                            break;
                        case ReturnVariable returnVariable:
                            indentation++;
                            
                            Indent(file, indentation);
                            file.WriteLine($"BEGIN RETURN REFC: {returnVariable.References.Count}");
                            DebugWriteValue(file, indentation + 1, returnVariable.Value);

                            indentation--;
                            break;
                        case AssignmentVariable assignmentVariable:
                            indentation++;

                            Indent(file, indentation);
                            file.WriteLine($"BEGIN ASSIGNMENT VAR {assignmentVariable.OriginalName} REFC: {assignmentVariable.References.Count}");
                            DebugWriteValue(file, indentation + 1, assignmentVariable.Value);

                            indentation--;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException(nameof(v));
                    }
                }
            }
        }
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
