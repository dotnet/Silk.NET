// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;

namespace Silk.NET.OpenAL.Extensions.EXT
{
    /// <summary>
    /// Exposes the multi-channel buffers extension by Creative Labs.
    /// </summary>
    [Extension("AL_EXT_vorbis")]
    [NativeApi(Prefix = "al")]
    public partial class VorbisFormat : FormatExtensionBase<VorbisBufferFormat>
    {
        /// <inheritdoc cref="ExtensionBase" />
        public VorbisFormat(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}