// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Converters.Permutations
{
    public readonly struct ParameterOverloadContext
    {
        private readonly Func<int, string[], string> _addGenericParameter;
        private readonly Action<int, Parameter, ParameterPosition> _defineAdditionalParameter;
        public Parameter Parameter { get; }

        public ParameterOverloadContext(Parameter parameter, Func<int, string[], string> addGenericParameter, Action<int, Parameter, ParameterPosition> defineAdditionalParameter)
        {
            _addGenericParameter = addGenericParameter;
            _defineAdditionalParameter = defineAdditionalParameter;
            Parameter = parameter;
        }

        public string AddGenericParameter(int variant, params string[] constraints) => _addGenericParameter?.Invoke
            (variant, constraints);

        public void DefineBefore(int variant, Parameter parameter) => _defineAdditionalParameter.Invoke
            (variant, parameter, ParameterPosition.Before);

        public void DefineAfter(int variant, Parameter parameter) => _defineAdditionalParameter.Invoke
            (variant, parameter, ParameterPosition.After);
    }
}
