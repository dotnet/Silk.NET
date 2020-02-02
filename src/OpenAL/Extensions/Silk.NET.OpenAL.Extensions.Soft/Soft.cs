// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;
namespace Silk.NET.OpenAL.Extensions.Soft
{
    /// <summary>
    /// Exposes the public API of functions added by OpenAL Soft.
    /// </summary>
    [NativeApi(Prefix = "al")]
    public abstract class Soft : NativeExtension<AL>
    {
        /// <inheritdoc cref="ExtensionBase" />
        protected Soft(ref NativeApiContext ctx)
            : base(ref ctx)
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
