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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_DECODE_FRAME_ARGUMENT")]
    public unsafe partial struct VideoDecodeFrameArgument
    {
        public VideoDecodeFrameArgument
        (
            VideoDecodeArgumentType? type = null,
            uint? size = null,
            void* pData = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }

            if (pData is not null)
            {
                PData = pData;
            }
        }


        [NativeName("Type", "D3D12_VIDEO_DECODE_ARGUMENT_TYPE")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODE_ARGUMENT_TYPE")]
        [NativeName("Name", "Type")]
        public VideoDecodeArgumentType Type;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Size")]
        public uint Size;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "pData")]
        public void* PData;
    }
}
