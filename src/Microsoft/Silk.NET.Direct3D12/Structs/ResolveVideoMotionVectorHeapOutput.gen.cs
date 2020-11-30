// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT")]
    public unsafe partial struct ResolveVideoMotionVectorHeapOutput
    {
        public ResolveVideoMotionVectorHeapOutput
        (
            ID3D12Resource* pMotionVectorTexture2D = null,
            ResourceCoordinate? motionVectorCoordinate = null
        ) : this()
        {
            if (pMotionVectorTexture2D is not null)
            {
                PMotionVectorTexture2D = pMotionVectorTexture2D;
            }

            if (motionVectorCoordinate is not null)
            {
                MotionVectorCoordinate = motionVectorCoordinate.Value;
            }
        }


        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "pMotionVectorTexture2D")]
        public ID3D12Resource* PMotionVectorTexture2D;

        [NativeName("Type", "D3D12_RESOURCE_COORDINATE")]
        [NativeName("Type.Name", "D3D12_RESOURCE_COORDINATE")]
        [NativeName("Name", "MotionVectorCoordinate")]
        public ResourceCoordinate MotionVectorCoordinate;
    }
}
