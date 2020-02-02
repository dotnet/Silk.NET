// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Native;
using Ultz.SuperInvoke;
namespace Silk.NET.OpenAL.Extensions.Soft
{
    /// <summary>
    /// Exposes the public API of the OpenAL Soft Deferred Updates extension.
    /// </summary>
    [NativeApi(Prefix = "al")]
    public abstract class DeferredUpdates : NativeExtension<AL>
    {
        /// <inheritdoc cref="ExtensionBase" />
        protected DeferredUpdates(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }

        /// <inheritdoc />
        public abstract bool GetBoolean(DeferredStateBoolean param);

        /// <inheritdoc />
        public abstract void DeferUpdates();

        /// <inheritdoc />
        public abstract void ProcessUpdates();
    }
}
