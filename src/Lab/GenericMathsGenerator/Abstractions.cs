// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using GenericMathsGenerator.ValueTypes;
using Microsoft.CodeAnalysis;

namespace GenericMathsGenerator
{
    public interface IValueProcessor
    {
        IEnumerable<IVariable> Process(IEnumerable<IVariable> variables);
    }
    
    /*
     * y = 2 * x
     * Step[0]
     *     Inputs[0] = x
     *     Expressions[0] = Mul(2, x)
     */

    public interface IValue
    {
        Optional<float> ConstantValue { get; }
        IEnumerable<IValue> Children { get; set; }
        int Step { get; }
    }

    public interface IVariable
    {
        IValue Value { get; set; }
        List<LocalReferenceValue> References { get; set; }
    }

    public interface IStep
    {
        IReadOnlyCollection<IValue> Input { get; }
        IReadOnlyCollection<IValue> Output { get; }
    }

    public class Step : IStep
    {
        public IReadOnlyCollection<IValue> Input { get; }
        public IReadOnlyCollection<IValue> Output { get; }

        public Step(IReadOnlyCollection<IValue> input, IReadOnlyCollection<IValue> output)
        {
            Input = input;
            Output = output;
        }
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
