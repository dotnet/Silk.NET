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
    [NativeName("Name", "D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT")]
    public unsafe partial struct ResolveVideoMotionVectorHeapInput
    {
        public ResolveVideoMotionVectorHeapInput
        (
            ID3D12VideoMotionVectorHeap* pMotionVectorHeap = default,
            uint pixelWidth = default,
            uint pixelHeight = default
        )
        {
            PMotionVectorHeap = pMotionVectorHeap;
            PixelWidth = pixelWidth;
            PixelHeight = pixelHeight;
        }


        [NativeName("Type", "ID3D12VideoMotionVectorHeap *")]
        [NativeName("Type.Name", "ID3D12VideoMotionVectorHeap *")]
        [NativeName("Name", "pMotionVectorHeap")]
        public ID3D12VideoMotionVectorHeap* PMotionVectorHeap;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "PixelWidth")]
        public uint PixelWidth;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "PixelHeight")]
        public uint PixelHeight;
    }
}
