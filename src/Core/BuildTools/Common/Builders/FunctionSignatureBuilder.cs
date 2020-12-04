// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Common.Builders
{
    // TODO: This should be renamed to FunctionBuilder since FunctionSignature was renamed to Function

    /// <summary>
    /// Acts as a builder for new instances of <see cref="Function" />s, based on existing instances.
    /// </summary>
    public sealed class FunctionSignatureBuilder
    {
        [NotNull] private readonly string _newDoc;
        [NotNull] private List<Attribute> _newAttributes;

        [NotNull] private IReadOnlyList<string> _newCategory;

        [NotNull] private string _newExtension;

        [NotNull] private IReadOnlyList<GenericTypeParameter> _newGenericTypeParameters;

        [NotNull] private string _newName;

        [NotNull] private string _newNativeEntrypoint;

        [NotNull] private IReadOnlyList<Parameter> _newParameters;

        [NotNull] private Type _newReturnType;

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionSignatureBuilder" /> class.
        /// </summary>
        /// <param name="functionSignature">The signature.</param>
        public FunctionSignatureBuilder([NotNull] Function functionSignature)
        {
            _newName = functionSignature.Name;
            _newNativeEntrypoint = functionSignature.NativeName;
            _newCategory = functionSignature.Categories;
            _newExtension = functionSignature.ExtensionName;
            _newAttributes = functionSignature.Attributes;
            _newParameters = functionSignature.Parameters;
            _newReturnType = functionSignature.ReturnType;
            _newGenericTypeParameters = functionSignature.GenericTypeParameters;
            _newDoc = functionSignature.Doc;
        }

        /// <summary>
        /// Sets a new name for the function.
        /// </summary>
        /// <param name="newName">The new name.</param>
        /// <returns>The builder, with the change applied.</returns>
        [NotNull]
        public FunctionSignatureBuilder WithName([NotNull] string newName)
        {
            _newName = newName;
            return this;
        }

        /// <summary>
        /// Sets a new native entrypoint for the function.
        /// </summary>
        /// <param name="newNativeEntrypoint">The new native entrypoint.</param>
        /// <returns>The builder, with the change applied.</returns>
        [NotNull]
        public FunctionSignatureBuilder WithNativeEntrypoint([NotNull] string newNativeEntrypoint)
        {
            _newNativeEntrypoint = newNativeEntrypoint;
            return this;
        }

        /// <summary>
        /// Sets new categories for the function.
        /// </summary>
        /// <param name="newCategories">The new categories.</param>
        /// <returns>The builder, with the change applied.</returns>
        [NotNull]
        public FunctionSignatureBuilder WithCategories([NotNull] IReadOnlyList<string> newCategories)
        {
            _newCategory = newCategories;
            return this;
        }

        /// <summary>
        /// Sets a new extension for the function.
        /// </summary>
        /// <param name="newExtension">The new extension.</param>
        /// <returns>The builder, with the change applied.</returns>
        [NotNull]
        public FunctionSignatureBuilder WithExtension([NotNull] string newExtension)
        {
            _newExtension = newExtension;
            return this;
        }

        /// <summary>
        /// Sets the attributes for the function.
        /// </summary>
        /// <param name="newAttributes">The new attributes.</param>
        /// <returns>The builder, with the change applied.</returns>
        [NotNull]
        public FunctionSignatureBuilder WithAttributes([NotNull] IReadOnlyList<Attribute> newAttributes)
        {
            _newAttributes = newAttributes.ToList();
            return this;
        }

        /// <summary>
        /// Sets new parameters for the function.
        /// </summary>
        /// <param name="newParameters">The new parameters.</param>
        /// <returns>The builder, with the change applied.</returns>
        [NotNull]
        public FunctionSignatureBuilder WithParameters([NotNull] IReadOnlyList<Parameter> newParameters)
        {
            _newParameters = newParameters;
            return this;
        }

        /// <summary>
        /// Sets new generic type parameters for the function.
        /// </summary>
        /// <param name="newGenericTypeParameters">The new generic type parameters.</param>
        /// <returns>The builder, with the change applied.</returns>
        [NotNull]
        public FunctionSignatureBuilder WithGenericTypeParameters
        (
            [NotNull] IReadOnlyList<GenericTypeParameter> newGenericTypeParameters
        )
        {
            _newGenericTypeParameters = newGenericTypeParameters;
            return this;
        }

        /// <summary>
        /// Sets a new return type for the function.
        /// </summary>
        /// <param name="newReturnType">The new return type.</param>
        /// <returns>The builder, with the change applied.</returns>
        [NotNull]
        public FunctionSignatureBuilder WithReturnType([NotNull] Type newReturnType)
        {
            _newReturnType = newReturnType;
            return this;
        }

        /// <summary>
        /// Builds the final instance.
        /// </summary>
        /// <returns>The instance.</returns>
        [NotNull]
        public Function Build()
        {
            return new Function
            {
                Name = _newName,
                NativeName = _newNativeEntrypoint,
                Categories = _newCategory?.ToList(),
                ExtensionName = _newExtension,
                ReturnType = _newReturnType,
                Parameters = _newParameters?.ToList(),
                GenericTypeParameters = _newGenericTypeParameters?.ToList() ?? new List<GenericTypeParameter>(),
                Attributes = _newAttributes, Doc = _newDoc
            };
        }
    }
}
