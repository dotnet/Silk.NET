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
    /// <summary>
    /// Acts as a builder for new instances of <see cref="TypeSignature" />s, based on existing instances.
    /// </summary>
    public sealed class TypeSignatureBuilder
    {
        private int _newArrayDimensions;

        private int _newIndirectionLevel;

        private bool _newIsByRef;

        private bool _newIsOut;

        private bool _newIsIn;

        private string _newOriginalName;

        [NotNull] private string _newName;

        private List<Type> _newGenericTypes;

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeSignatureBuilder" /> class.
        /// </summary>
        /// <param name="typeSignature">The signature.</param>
        public TypeSignatureBuilder([NotNull] Type typeSignature)
        {
            _newName = typeSignature.Name;
            _newIndirectionLevel = typeSignature.IndirectionLevels;
            _newArrayDimensions = typeSignature.ArrayDimensions;
            _newIsByRef = typeSignature.IsByRef;
            _newIsIn = typeSignature.IsIn;
            _newIsOut = typeSignature.IsOut;
            _newOriginalName = typeSignature.OriginalName;
            _newGenericTypes = typeSignature.GenericTypes;
        }

        /// <summary>
        /// Sets a new name for the type signature.
        /// </summary>
        /// <param name="newName">The new name.</param>
        /// <returns>The builder, with the name.</returns>
        [NotNull]
        public TypeSignatureBuilder WithName([NotNull] string newName)
        {
            _newName = newName;
            return this;
        }

        /// <summary>
        /// Sets a new indirection level for the type signature.
        /// </summary>
        /// <param name="newIndirectionLevel">The new indirection level.</param>
        /// <returns>The builder, with the level.</returns>
        [NotNull]
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
        [NotNull]
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
        [NotNull]
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
        [NotNull]
        public TypeSignatureBuilder WithIsOut(bool isOut)
        {
            _newIsOut = isOut;
            return this;
        }

        /// <summary>
        /// Builds the final instance.
        /// </summary>
        /// <returns>The instance.</returns>
        [NotNull]
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
                OriginalName = _newOriginalName
            };
        }

        public TypeSignatureBuilder WithIsIn(bool b)
        {
            _newIsIn = b;
            return this;
        }

        public TypeSignatureBuilder WithGenericTypes(List<Type> parameters)
        {
            _newGenericTypes = parameters;
            return this;
        }

        public TypeSignatureBuilder WithGenericTypes(params Type[] parameters)
        {
            _newGenericTypes = parameters.ToList();
            return this;
        }
    }
}
