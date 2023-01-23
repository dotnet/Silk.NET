// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Common.Builders
{
    // TODO: This should be renamed to ParameterBuilder since ParameterSignature was renamed to Parameter
    
    /// <summary>
    /// Acts as a builder for new instances of <see cref="Parameter" />s, based on existing instances.
    /// </summary>
    public class ParameterSignatureBuilder
    {
        private Count? _newCount;

        private FlowDirection _newFlow;

        private string _newName;

        private Type _newType;

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterSignatureBuilder" /> class.
        /// </summary>
        /// <param name="parameterSignature">The signature.</param>
        public ParameterSignatureBuilder(Parameter parameterSignature)
        {
            _newName = parameterSignature.Name;
            _newType = parameterSignature.Type;
            _newFlow = parameterSignature.Flow;
            _newCount = parameterSignature.Count;
        }

        /// <summary>
        /// Sets a new name for the parameter.
        /// </summary>
        /// <param name="newName">The new name.</param>
        /// <returns>The builder, with the change applied.</returns>
        public ParameterSignatureBuilder WithName(string newName)
        {
            _newName = newName;
            return this;
        }

        /// <summary>
        /// Sets a new type for the parameter.
        /// </summary>
        /// <param name="newType">The new type.</param>
        /// <returns>The builder, with the change applied.</returns>
        public ParameterSignatureBuilder WithType(Type newType)
        {
            _newType = newType;
            return this;
        }

        /// <summary>
        /// Sets a new flow for the parameter.
        /// </summary>
        /// <param name="newFlow">The new flow.</param>
        /// <returns>The builder, with the change applied.</returns>
        public ParameterSignatureBuilder WithFlow(FlowDirection newFlow)
        {
            _newFlow = newFlow;
            return this;
        }

        /// <summary>
        /// Sets a new count for the parameter.
        /// </summary>
        /// <param name="newCount">The new count.</param>
        /// <returns>The builder, with the change applied.</returns>
        public ParameterSignatureBuilder WithCount(Count? newCount)
        {
            _newCount = newCount;
            return this;
        }

        /// <summary>
        /// Builds the final instance.
        /// </summary>
        /// <returns>The instance.</returns>
        public Parameter Build()
        {
            return new Parameter
            {
                Name = Utilities.CSharpKeywords.Contains(_newName) ? $"@{_newName}" : _newName,
                Count = _newCount,
                Flow = _newFlow,
                Type = _newType
            };
        }
    }
}
