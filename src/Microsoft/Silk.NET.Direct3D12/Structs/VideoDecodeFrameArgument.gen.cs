// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
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
            VideoDecodeArgumentType type = default,
            uint size = default,
            void* pData = default
        )
        {
            Type = type;
            Size = size;
            PData = pData;
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
