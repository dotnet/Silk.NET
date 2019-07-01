//
// Soft.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using AdvancedDLSupport;
using OpenToolkit.Core.Extensions;

namespace OpenToolkit.OpenAL.Extensions.Soft
{
    /// <summary>
    /// Exposes the public API of functions added by OpenAL Soft.
    /// </summary>
    public abstract class Soft : ExtensionBase, IStateSoft
    {
        /// <inheritdoc cref="ExtensionBase" />
        protected Soft(string path, ImplementationOptions options)
            : base(path, options)
        {
        }

        /// <inheritdoc />
        public abstract bool GetBoolean(SoftStateBoolean param);

        /// <inheritdoc />
        public abstract double GetDouble(SoftStateDouble param);

        /// <inheritdoc />
        public abstract float GetFloat(SoftStateFloat param);

        /// <inheritdoc />
        public abstract int GetInteger(SoftStateInteger param);

        /// <inheritdoc />
        public abstract IntPtr GetPointer(StatePointer param);
    }
}
