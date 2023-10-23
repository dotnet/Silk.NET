// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrPassthroughColorLutDataMETA")]
    public unsafe partial struct PassthroughColorLutDataMETA
    {
        public PassthroughColorLutDataMETA
        (
            uint? bufferSize = null,
            byte* buffer = null
        ) : this()
        {
            if (bufferSize is not null)
            {
                BufferSize = bufferSize.Value;
            }

            if (buffer is not null)
            {
                Buffer = buffer;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "bufferSize")]
        public uint BufferSize;
/// <summary></summary>
        [NativeName("Type", "uint8_t*")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "buffer")]
        public byte* Buffer;
    }
}
