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
        IEnumerable<IVariable> Process(IEnumerable<IVariable> variable);
    }

    public interface IBodyBuilder
    {
        List<StatementSyntax> Statements { get; set; }
        TargetType Type { get; }
        Dictionary<IValue, ExpressionSyntax> ResolvedValues { get; }
        List<IVariable> ResolvedVariables { get; }
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
            ResolvedVariables = new List<IVariable>();
        }
        public List<StatementSyntax> Statements { get; set; }
        public TargetType Type { get; }
        public Dictionary<IValue, ExpressionSyntax> ResolvedValues { get; }
        public List<IVariable> ResolvedVariables { get; }
        public ExpressionSyntax ResolveValue(IValue value) => _resolveCallback(value, this);
    }

    public interface IValue : IEquatable<IValue>
    {
        IValue? Parent { get; set; }
        Optional<float> ConstantValue { get; }
        IEnumerable<IValue> Children { get; set; }
        int Step { get; }
        ExpressionSyntax BuildExpression
            (IBodyBuilder bodyBuilder, ImmutableArray<ExpressionSyntax> children);
    }

    public interface IVariable : IScopable, IEquatable<IVariable>
    {
        IValue Value { get; set; }
        List<IVariableReference> References { get; set; }
        int ExtraReferences { get; set; }
    }

    public interface IVariableReference : IValue
    {
        
    }

    public interface IScopable
    {
        
    }
    
    public sealed class Scope : IScopable
    {
        public List<IScopable> Scopables = new List<IScopable>();
        public Scope Parent { get; set; }

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
            
            foreach (var scopable in Scopables)
            {
                if (scopable is Scope s)
                {
                    s.DebugWrite(file, indentation + 1);
                }
                else if (scopable is IVariable v)
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
