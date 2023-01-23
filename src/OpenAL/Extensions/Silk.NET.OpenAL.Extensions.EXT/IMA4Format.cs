// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;
using Silk.NET.OpenAL.Extensions;

namespace Silk.NET.OpenAL.Native.Extensions.EXT
{
    /// <summary>
    /// Exposes the multi-channel buffers extension by Creative Labs.
    /// </summary>
    [Extension("AL_EXT_IMA4")]
    [NativeApi(Prefix = "al")]
    public partial class IMA4Format : FormatExtensionBase<IMA4BufferFormat>
    {
        /// <inheritdoc cref="ExtensionBase" />
        public IMA4Format(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}