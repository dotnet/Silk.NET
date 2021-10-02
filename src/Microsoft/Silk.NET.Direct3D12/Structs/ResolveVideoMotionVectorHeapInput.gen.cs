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
    [NativeName("Name", "D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT")]
    public unsafe partial struct ResolveVideoMotionVectorHeapInput
    {
        public ResolveVideoMotionVectorHeapInput
        (
            ID3D12VideoMotionVectorHeap* pMotionVectorHeap = null,
            uint? pixelWidth = null,
            uint? pixelHeight = null
        ) : this()
        {
            if (pMotionVectorHeap is not null)
            {
                PMotionVectorHeap = pMotionVectorHeap;
            }

            if (pixelWidth is not null)
            {
                PixelWidth = pixelWidth.Value;
            }

            if (pixelHeight is not null)
            {
                PixelHeight = pixelHeight.Value;
            }
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
