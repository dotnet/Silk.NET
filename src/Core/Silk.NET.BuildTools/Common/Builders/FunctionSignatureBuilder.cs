// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Common.Builders
{
    // TODO: This should be renamed to FunctionBuilder since FunctionSignature was renamed to Function
    
    /// <summary>
    /// Acts as a builder for new instances of <see cref="Function" />s, based on existing instances.
    /// </summary>
    public sealed class FunctionSignatureBuilder
    {
        private readonly string _newDoc;
        private List<Attribute> _newAttributes;

        private IReadOnlyList<string> _newCategory;

        private string _newExtension;

        private IReadOnlyList<GenericTypeParameter> _newGenericTypeParameters;

        private string _newName;

        private string _newNativeEntrypoint;

        private IReadOnlyList<Parameter> _newParameters;

        private Type _newReturnType;

        private Accessibility _newAccessibility;

        private SignatureKind _newKind;

        private CallingConvention _newCallingConvention;

        private string? _invocationPrefix;

        private bool _isReadOnly;

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionSignatureBuilder" /> class.
        /// </summary>
        /// <param name="functionSignature">The signature.</param>
        public FunctionSignatureBuilder(Function functionSignature)
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
            _newAccessibility = functionSignature.Accessibility;
            _newKind = functionSignature.Kind;
            _newCallingConvention = functionSignature.Convention;
            _invocationPrefix = functionSignature.InvocationPrefix;
            _isReadOnly = functionSignature.IsReadOnly;
        }

        /// <summary>
        /// Sets a new name for the function.
        /// </summary>
        /// <param name="newName">The new name.</param>
        /// <returns>The builder, with the change applied.</returns>
        public FunctionSignatureBuilder WithName(string newName)
        {
            _newName = newName;
            return this;
        }

        /// <summary>
        /// Sets a new native entrypoint for the function.
        /// </summary>
        /// <param name="newNativeEntrypoint">The new native entrypoint.</param>
        /// <returns>The builder, with the change applied.</returns>
        public FunctionSignatureBuilder WithNativeEntrypoint(string newNativeEntrypoint)
        {
            _newNativeEntrypoint = newNativeEntrypoint;
            return this;
        }

        /// <summary>
        /// Sets new categories for the function.
        /// </summary>
        /// <param name="newCategories">The new categories.</param>
        /// <returns>The builder, with the change applied.</returns>
        public FunctionSignatureBuilder WithCategories(IReadOnlyList<string> newCategories)
        {
            _newCategory = newCategories;
            return this;
        }

        /// <summary>
        /// Sets a new extension for the function.
        /// </summary>
        /// <param name="newExtension">The new extension.</param>
        /// <returns>The builder, with the change applied.</returns>
        public FunctionSignatureBuilder WithExtension(string newExtension)
        {
            _newExtension = newExtension;
            return this;
        }

        /// <summary>
        /// Sets the attributes for the function.
        /// </summary>
        /// <param name="newAttributes">The new attributes.</param>
        /// <returns>The builder, with the change applied.</returns>
        public FunctionSignatureBuilder WithAttributes(IReadOnlyList<Attribute> newAttributes)
        {
            _newAttributes = newAttributes.ToList();
            return this;
        }

        /// <summary>
        /// Sets new parameters for the function.
        /// </summary>
        /// <param name="newParameters">The new parameters.</param>
        /// <returns>The builder, with the change applied.</returns>
        public FunctionSignatureBuilder WithParameters(IReadOnlyList<Parameter> newParameters)
        {
            _newParameters = newParameters;
            return this;
        }

        /// <summary>
        /// Sets new generic type parameters for the function.
        /// </summary>
        /// <param name="newGenericTypeParameters">The new generic type parameters.</param>
        /// <returns>The builder, with the change applied.</returns>
        public FunctionSignatureBuilder WithGenericTypeParameters
        (
            IReadOnlyList<GenericTypeParameter> newGenericTypeParameters
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
        public FunctionSignatureBuilder WithReturnType(Type newReturnType)
        {
            _newReturnType = newReturnType;
            return this;
        }

        /// <summary>
        /// Sets a new accessibility for the function.
        /// </summary>
        /// <param name="newAccessibility">The new accessibility.</param>
        /// <returns>The builder, with the change applied.</returns>
        public FunctionSignatureBuilder WithReturnType(Accessibility newAccessibility)
        {
            _newAccessibility = newAccessibility;
            return this;
        }

        /// <summary>
        /// Sets a new function signature kind.
        /// </summary>
        /// <param name="kind">The new signature kind.</param>
        /// <returns>The builder, with the change applied.</returns>
        public FunctionSignatureBuilder WithKind(SignatureKind kind)
        {
            _newKind = kind;
            return this;
        }

        /// <summary>
        /// Sets a new function calling convention.
        /// </summary>
        /// <param name="kind">The new calling convention.</param>
        /// <returns>The builder, with the change applied.</returns>
        public FunctionSignatureBuilder WithCallingConvention(CallingConvention callingConvention)
        {
            _newCallingConvention = callingConvention;
            return this;
        }

        /// <summary>
        /// Builds the final instance.
        /// </summary>
        /// <returns>The instance.</returns>
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
                Attributes = _newAttributes.ToList(),
                Doc = _newDoc,
                Accessibility = _newAccessibility,
                Kind = _newKind,
                Convention = _newCallingConvention,
                InvocationPrefix = _invocationPrefix,
                IsReadOnly = _isReadOnly
            };
        }
    }
}
