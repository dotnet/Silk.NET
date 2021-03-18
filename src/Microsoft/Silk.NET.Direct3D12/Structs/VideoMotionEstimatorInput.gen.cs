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
    [NativeName("Name", "D3D12_VIDEO_MOTION_ESTIMATOR_INPUT")]
    public unsafe partial struct VideoMotionEstimatorInput
    {
        public VideoMotionEstimatorInput
        (
            ID3D12Resource* pInputTexture2D = null,
            uint? inputSubresourceIndex = null,
            ID3D12Resource* pReferenceTexture2D = null,
            uint? referenceSubresourceIndex = null,
            ID3D12VideoMotionVectorHeap* pHintMotionVectorHeap = null
        ) : this()
        {
            if (pInputTexture2D is not null)
            {
                PInputTexture2D = pInputTexture2D;
            }

            if (inputSubresourceIndex is not null)
            {
                InputSubresourceIndex = inputSubresourceIndex.Value;
            }

            if (pReferenceTexture2D is not null)
            {
                PReferenceTexture2D = pReferenceTexture2D;
            }

            if (referenceSubresourceIndex is not null)
            {
                ReferenceSubresourceIndex = referenceSubresourceIndex.Value;
            }

            if (pHintMotionVectorHeap is not null)
            {
                PHintMotionVectorHeap = pHintMotionVectorHeap;
            }
        }


        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "pInputTexture2D")]
        public ID3D12Resource* PInputTexture2D;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InputSubresourceIndex")]
        public uint InputSubresourceIndex;

        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "pReferenceTexture2D")]
        public ID3D12Resource* PReferenceTexture2D;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ReferenceSubresourceIndex")]
        public uint ReferenceSubresourceIndex;

        [NativeName("Type", "ID3D12VideoMotionVectorHeap *")]
        [NativeName("Type.Name", "ID3D12VideoMotionVectorHeap *")]
        [NativeName("Name", "pHintMotionVectorHeap")]
        public ID3D12VideoMotionVectorHeap* PHintMotionVectorHeap;
    }
}
