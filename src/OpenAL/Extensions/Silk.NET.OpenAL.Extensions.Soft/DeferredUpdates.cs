// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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
