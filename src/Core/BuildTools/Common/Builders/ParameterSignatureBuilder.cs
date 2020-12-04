// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using JetBrains.Annotations;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Common.Builders
{
    // TODO: This should be renamed to ParameterBuilder since ParameterSignature was renamed to Parameter

    /// <summary>
    /// Acts as a builder for new instances of <see cref="Parameter" />s, based on existing instances.
    /// </summary>
    public class ParameterSignatureBuilder
    {
        [CanBeNull] private Count _newCount;

        private FlowDirection _newFlow;

        [NotNull] private string _newName;

        [NotNull] private Type _newType;

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterSignatureBuilder" /> class.
        /// </summary>
        /// <param name="parameterSignature">The signature.</param>
        public ParameterSignatureBuilder([NotNull] Parameter parameterSignature)
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
        [NotNull]
        public ParameterSignatureBuilder WithName([NotNull] string newName)
        {
            _newName = newName;
            return this;
        }

        /// <summary>
        /// Sets a new type for the parameter.
        /// </summary>
        /// <param name="newType">The new type.</param>
        /// <returns>The builder, with the change applied.</returns>
        [NotNull]
        public ParameterSignatureBuilder WithType([NotNull] Type newType)
        {
            _newType = newType;
            return this;
        }

        /// <summary>
        /// Sets a new flow for the parameter.
        /// </summary>
        /// <param name="newFlow">The new flow.</param>
        /// <returns>The builder, with the change applied.</returns>
        [NotNull]
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
        [NotNull]
        public ParameterSignatureBuilder WithCount([CanBeNull] Count newCount)
        {
            _newCount = newCount;
            return this;
        }

        /// <summary>
        /// Builds the final instance.
        /// </summary>
        /// <returns>The instance.</returns>
        [NotNull]
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
