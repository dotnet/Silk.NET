// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using AdvancedDLSupport;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;

namespace Silk.NET.OpenAL.Extensions.Soft
{
    /// <summary>
    /// Exposes the public API of functions added by OpenAL Soft.
    /// </summary>
    public abstract class Soft : NativeExtension<AL>, IStateSoft
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

        public abstract SearchPathContainer SearchPaths { get; }
        public abstract bool IsExtensionPresent(string name);
        public abstract IntPtr GetProcAddress(string name);
        public abstract int GetEnumValue(string name);
    }
}
