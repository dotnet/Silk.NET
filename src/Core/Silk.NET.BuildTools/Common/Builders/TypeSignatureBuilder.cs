// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Common.Builders
{
    // TODO: This should be renamed to TypeBuilder since TypeSignature was renamed to Type
    
    /// <summary>
    /// Acts as a builder for new instances of <see cref="Type" />s, based on existing instances.
    /// </summary>
    public sealed class TypeSignatureBuilder
    {
        private int _newArrayDimensions;

        private int _newIndirectionLevel;

        private bool _newIsByRef;

        private bool _newIsOut;

        private bool _newIsIn;

        private bool _newIsGenericType;

        private readonly string _newOriginalName;

        private readonly string _newOriginalGroup;

        private readonly string _newOriginalClass;

        private string _newName;
        
        private Function _newFunctionPointerSignature;

        private List<Type> _newGenericParams;
        
        private bool _newIsIntAsPtr;

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeSignatureBuilder" /> class.
        /// </summary>
        /// <param name="typeSignature">The signature.</param>
        public TypeSignatureBuilder(Type typeSignature)
        {
            _newName = typeSignature.Name;
            _newIndirectionLevel = typeSignature.IndirectionLevels;
            _newArrayDimensions = typeSignature.ArrayDimensions;
            _newIsByRef = typeSignature.IsByRef;
            _newIsIn = typeSignature.IsIn;
            _newIsOut = typeSignature.IsOut;
            _newOriginalName = typeSignature.OriginalName;
            _newOriginalGroup = typeSignature.OriginalGroup;
            _newOriginalClass = typeSignature.OriginalClass;
            _newIsGenericType = typeSignature.IsGenericTypeParameterReference;
            _newFunctionPointerSignature = typeSignature.FunctionPointerSignature;
            _newGenericParams = typeSignature.GenericTypes;
            _newIsIntAsPtr = typeSignature.IsIntAsPtr;
        }

        /// <summary>
        /// Sets a new name for the type signature.
        /// </summary>
        /// <param name="newName">The new name.</param>
        /// <returns>The builder, with the name.</returns>
        public TypeSignatureBuilder WithName(string newName)
        {
            _newName = newName;
            return this;
        }

        /// <summary>
        /// Sets a new indirection level for the type signature.
        /// </summary>
        /// <param name="newIndirectionLevel">The new indirection level.</param>
        /// <returns>The builder, with the level.</returns>
        public TypeSignatureBuilder WithIndirectionLevel(int newIndirectionLevel)
        {
            _newIndirectionLevel = newIndirectionLevel;
            return this;
        }

        /// <summary>
        /// Sets a new array dimension for the type signature.
        /// </summary>
        /// <param name="newArrayDimensions">The new array dimension.</param>
        /// <returns>The builder, with the name.</returns>
        public TypeSignatureBuilder WithArrayDimensions(int newArrayDimensions)
        {
            _newArrayDimensions = newArrayDimensions;
            return this;
        }

        /// <summary>
        /// Sets a new by-ref value for the type signature.
        /// </summary>
        /// <param name="isByRef">The new by-ref value.</param>
        /// <returns>The builder, with the by-ref value.</returns>
        public TypeSignatureBuilder WithByRef(bool isByRef)
        {
            _newIsByRef = isByRef;
            return this;
        }

        /// <summary>
        /// Sets a new is-out value for the type signature.
        /// </summary>
        /// <param name="isOut">The new is-out value.</param>
        /// <returns>The builder, with the is-out value.</returns>
        public TypeSignatureBuilder WithIsOut(bool isOut)
        {
            _newIsOut = isOut;
            return this;
        }

        /// <summary>
        /// Sets a new IsGenericType value for the type signature.
        /// </summary>
        /// <param name="isGenericType">The new IsGenericType value.</param>
        /// <returns>The builder, with the IsGenericType value.</returns>
        public TypeSignatureBuilder WithIsGenericType(bool isGenericType)
        {
            _newIsGenericType = isGenericType;
            return this;
        }

        /// <summary>
        /// Builds the final instance.
        /// </summary>
        /// <returns>The instance.</returns>
        public Type Build()
        {
            return new Type
            {
                Name = _newName,
                IndirectionLevels = _newIndirectionLevel,
                ArrayDimensions = _newArrayDimensions,
                IsByRef = _newIsByRef,
                IsOut = _newIsOut,
                IsIn = _newIsIn,
                OriginalName = _newOriginalName,
                OriginalGroup = _newOriginalGroup,
                OriginalClass = _newOriginalClass,
                IsGenericTypeParameterReference = _newIsGenericType,
                GenericTypes = _newGenericParams,
                IsIntAsPtr = _newIsIntAsPtr
            };
        }

        /// <summary>
        /// Sets a new is-in value for the type signature.
        /// </summary>
        /// <param name="isIn">The new is-in value.</param>
        /// <returns>The builder, with the is-in value.</returns>
        public TypeSignatureBuilder WithIsIn(bool isIn)
        {
            _newIsIn = isIn;
            return this;
        }
        
        /// <summary>
        /// Sets a new function pointer signature for the type.
        /// </summary>
        /// <param name="function">The new function pointer signature.</param>
        /// <returns>The current instance for chaining purposes.</returns>
        public TypeSignatureBuilder WithFunctionPointerSignature(Function function)
        {
            _newFunctionPointerSignature = function;
            return this;
        }

        // TODO: Implement these
        // ReSharper disable UnusedParameter.Global
        /// <summary>
        /// Sets the list of generic types for the type signature.
        /// </summary>
        /// <param name="parameters">The new generic types.</param>
        /// <returns>The builder, with the new generic types.</returns>
        public TypeSignatureBuilder WithGenericTypes(List<Type> parameters)
        {
            _newGenericParams = parameters;
            return this;
        }

        /// <summary>
        /// Sets the list of generic types for the type signature.
        /// </summary>
        /// <param name="parameters">The new generic types.</param>
        /// <returns>The builder, with the new generic types.</returns>
        public TypeSignatureBuilder WithGenericTypes(params Type[] parameters)
        {
            _newGenericParams = parameters.ToList();
            return this;
        }

        public TypeSignatureBuilder WithIsIntAsPtr(bool isIntAsPtr)
        {
            _newIsIntAsPtr = isIntAsPtr;
            return this;
        }
        // ReSharper restore UnusedParameter.Global
    }
}
