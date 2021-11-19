// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE")]
    public enum DredAllocationType : int
    {
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_COMMAND_QUEUE")]
        DredAllocationTypeCommandQueue = 0x13,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_COMMAND_ALLOCATOR")]
        DredAllocationTypeCommandAllocator = 0x14,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_PIPELINE_STATE")]
        DredAllocationTypePipelineState = 0x15,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_COMMAND_LIST")]
        DredAllocationTypeCommandList = 0x16,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_FENCE")]
        DredAllocationTypeFence = 0x17,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_DESCRIPTOR_HEAP")]
        DredAllocationTypeDescriptorHeap = 0x18,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_HEAP")]
        DredAllocationTypeHeap = 0x19,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_QUERY_HEAP")]
        DredAllocationTypeQueryHeap = 0x1B,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_COMMAND_SIGNATURE")]
        DredAllocationTypeCommandSignature = 0x1C,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_PIPELINE_LIBRARY")]
        DredAllocationTypePipelineLibrary = 0x1D,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_VIDEO_DECODER")]
        DredAllocationTypeVideoDecoder = 0x1E,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_VIDEO_PROCESSOR")]
        DredAllocationTypeVideoProcessor = 0x20,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_RESOURCE")]
        DredAllocationTypeResource = 0x22,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_PASS")]
        DredAllocationTypePass = 0x23,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_CRYPTOSESSION")]
        DredAllocationTypeCryptosession = 0x24,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_CRYPTOSESSIONPOLICY")]
        DredAllocationTypeCryptosessionpolicy = 0x25,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_PROTECTEDRESOURCESESSION")]
        DredAllocationTypeProtectedresourcesession = 0x26,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_VIDEO_DECODER_HEAP")]
        DredAllocationTypeVideoDecoderHeap = 0x27,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_COMMAND_POOL")]
        DredAllocationTypeCommandPool = 0x28,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_COMMAND_RECORDER")]
        DredAllocationTypeCommandRecorder = 0x29,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_STATE_OBJECT")]
        DredAllocationTypeStateObject = 0x2A,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_METACOMMAND")]
        DredAllocationTypeMetacommand = 0x2B,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_SCHEDULINGGROUP")]
        DredAllocationTypeSchedulinggroup = 0x2C,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_VIDEO_MOTION_ESTIMATOR")]
        DredAllocationTypeVideoMotionEstimator = 0x2D,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_VIDEO_MOTION_VECTOR_HEAP")]
        DredAllocationTypeVideoMotionVectorHeap = 0x2E,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_VIDEO_EXTENSION_COMMAND")]
        DredAllocationTypeVideoExtensionCommand = 0x2F,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_VIDEO_ENCODER")]
        DredAllocationTypeVideoEncoder = 0x30,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_VIDEO_ENCODER_HEAP")]
        DredAllocationTypeVideoEncoderHeap = 0x31,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_INVALID")]
        DredAllocationTypeInvalid = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
