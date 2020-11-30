// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_MOTION_ESTIMATOR_OUTPUT")]
    public unsafe partial struct VideoMotionEstimatorOutput
    {
        public VideoMotionEstimatorOutput
        (
            ID3D12VideoMotionVectorHeap* pMotionVectorHeap = null
        ) : this()
        {
            if (pMotionVectorHeap is not null)
            {
                PMotionVectorHeap = pMotionVectorHeap;
            }
        }


        [NativeName("Type", "ID3D12VideoMotionVectorHeap *")]
        [NativeName("Type.Name", "ID3D12VideoMotionVectorHeap *")]
        [NativeName("Name", "pMotionVectorHeap")]
        public ID3D12VideoMotionVectorHeap* PMotionVectorHeap;
    }
}
