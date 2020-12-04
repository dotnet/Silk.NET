// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;

namespace Silk.NET.OpenAL.Extensions.Soft
{
    /// <summary>
    /// Exposes the public API of the OpenAL Soft Deferred Updates extension.
    /// </summary>
    [NativeApi(Prefix = "al")]
    public partial class DeferredUpdates : NativeExtension<AL>
    {
        /// <inheritdoc cref="ExtensionBase" />
        protected DeferredUpdates(INativeContext ctx)
            : base(ctx)
        {
        }

        /// <inheritdoc />
        public partial bool GetBoolean(DeferredStateBoolean param);

        /// <inheritdoc />
        public partial void DeferUpdates();

        /// <inheritdoc />
        public partial void ProcessUpdates();
    }
}
