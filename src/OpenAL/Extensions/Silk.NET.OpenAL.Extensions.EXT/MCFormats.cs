// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;
using Silk.NET.OpenAL.Extensions.EXT.Enums;

namespace Silk.NET.OpenAL.Extensions.EXT
{

    /// <summary>
    /// Exposes the OpenAL multi-channel buffers extension.
    /// </summary>
    [Extension("AL_EXT_MCFORMATS")]
    [NativeApi(Prefix = "al")]
    public partial class MCFormats : FormatExtensionBase<MCBufferFormat>
    {
        /// <inheritdoc cref="ExtensionBase" />
        public MCFormats(INativeContext ctx)
            : base(ctx)
        {
        }
    }

}
