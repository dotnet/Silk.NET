// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;

namespace Silk.NET.OpenAL.Extensions.Creative
{
    /// <summary>
    /// Exposes the multi-channel buffers extension by Creative Labs.
    /// </summary>
    [Extension("AL_EXT_MCFORMATS")]
    [NativeApi(Prefix = "al")]
    public partial class MultiChannelBuffers : FormatExtensionBase<MultiChannelBufferFormat>
    {
        /// <inheritdoc cref="ExtensionBase" />
        public MultiChannelBuffers(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}