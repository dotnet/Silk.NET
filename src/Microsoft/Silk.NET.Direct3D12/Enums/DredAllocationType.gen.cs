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
        [Obsolete("Deprecated in favour of \"CommandQueue\"")]
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_COMMAND_QUEUE")]
        DredAllocationTypeCommandQueue = 0x13,
        [Obsolete("Deprecated in favour of \"CommandAllocator\"")]
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_COMMAND_ALLOCATOR")]
        DredAllocationTypeCommandAllocator = 0x14,
        [Obsolete("Deprecated in favour of \"PipelineState\"")]
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_PIPELINE_STATE")]
        DredAllocationTypePipelineState = 0x15,
        [Obsolete("Deprecated in favour of \"CommandList\"")]
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_COMMAND_LIST")]
        DredAllocationTypeCommandList = 0x16,
        [Obsolete("Deprecated in favour of \"Fence\"")]
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_FENCE")]
        DredAllocationTypeFence = 0x17,
        [Obsolete("Deprecated in favour of \"DescriptorHeap\"")]
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_DESCRIPTOR_HEAP")]
        DredAllocationTypeDescriptorHeap = 0x18,
        [Obsolete("Deprecated in favour of \"Heap\"")]
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_HEAP")]
        DredAllocationTypeHeap = 0x19,
        [Obsolete("Deprecated in favour of \"QueryHeap\"")]
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_QUERY_HEAP")]
        DredAllocationTypeQueryHeap = 0x1B,
        [Obsolete("Deprecated in favour of \"CommandSignature\"")]
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_COMMAND_SIGNATURE")]
        DredAllocationTypeCommandSignature = 0x1C,
        [Obsolete("Deprecated in favour of \"PipelineLibrary\"")]
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_PIPELINE_LIBRARY")]
        DredAllocationTypePipelineLibrary = 0x1D,
        [Obsolete("Deprecated in favour of \"VideoDecoder\"")]
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_VIDEO_DECODER")]
        DredAllocationTypeVideoDecoder = 0x1E,
        [Obsolete("Deprecated in favour of \"VideoProcessor\"")]
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_VIDEO_PROCESSOR")]
        DredAllocationTypeVideoProcessor = 0x20,
        [Obsolete("Deprecated in favour of \"Resource\"")]
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_RESOURCE")]
        DredAllocationTypeResource = 0x22,
        [Obsolete("Deprecated in favour of \"Pass\"")]
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_PASS")]
        DredAllocationTypePass = 0x23,
        [Obsolete("Deprecated in favour of \"Cryptosession\"")]
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_CRYPTOSESSION")]
        DredAllocationTypeCryptosession = 0x24,
        [Obsolete("Deprecated in favour of \"Cryptosessionpolicy\"")]
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_CRYPTOSESSIONPOLICY")]
        DredAllocationTypeCryptosessionpolicy = 0x25,
        [Obsolete("Deprecated in favour of \"Protectedresourcesession\"")]
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_PROTECTEDRESOURCESESSION")]
        DredAllocationTypeProtectedresourcesession = 0x26,
        [Obsolete("Deprecated in favour of \"VideoDecoderHeap\"")]
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_VIDEO_DECODER_HEAP")]
        DredAllocationTypeVideoDecoderHeap = 0x27,
        [Obsolete("Deprecated in favour of \"CommandPool\"")]
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_COMMAND_POOL")]
        DredAllocationTypeCommandPool = 0x28,
        [Obsolete("Deprecated in favour of \"CommandRecorder\"")]
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_COMMAND_RECORDER")]
        DredAllocationTypeCommandRecorder = 0x29,
        [Obsolete("Deprecated in favour of \"StateObject\"")]
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_STATE_OBJECT")]
        DredAllocationTypeStateObject = 0x2A,
        [Obsolete("Deprecated in favour of \"Metacommand\"")]
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_METACOMMAND")]
        DredAllocationTypeMetacommand = 0x2B,
        [Obsolete("Deprecated in favour of \"Schedulinggroup\"")]
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_SCHEDULINGGROUP")]
        DredAllocationTypeSchedulinggroup = 0x2C,
        [Obsolete("Deprecated in favour of \"VideoMotionEstimator\"")]
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_VIDEO_MOTION_ESTIMATOR")]
        DredAllocationTypeVideoMotionEstimator = 0x2D,
        [Obsolete("Deprecated in favour of \"VideoMotionVectorHeap\"")]
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_VIDEO_MOTION_VECTOR_HEAP")]
        DredAllocationTypeVideoMotionVectorHeap = 0x2E,
        [Obsolete("Deprecated in favour of \"VideoExtensionCommand\"")]
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_VIDEO_EXTENSION_COMMAND")]
        DredAllocationTypeVideoExtensionCommand = 0x2F,
        [Obsolete("Deprecated in favour of \"VideoEncoder\"")]
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_VIDEO_ENCODER")]
        DredAllocationTypeVideoEncoder = 0x30,
        [Obsolete("Deprecated in favour of \"VideoEncoderHeap\"")]
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_VIDEO_ENCODER_HEAP")]
        DredAllocationTypeVideoEncoderHeap = 0x31,
        [Obsolete("Deprecated in favour of \"Invalid\"")]
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_INVALID")]
        DredAllocationTypeInvalid = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_COMMAND_QUEUE")]
        CommandQueue = 0x13,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_COMMAND_ALLOCATOR")]
        CommandAllocator = 0x14,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_PIPELINE_STATE")]
        PipelineState = 0x15,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_COMMAND_LIST")]
        CommandList = 0x16,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_FENCE")]
        Fence = 0x17,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_DESCRIPTOR_HEAP")]
        DescriptorHeap = 0x18,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_HEAP")]
        Heap = 0x19,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_QUERY_HEAP")]
        QueryHeap = 0x1B,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_COMMAND_SIGNATURE")]
        CommandSignature = 0x1C,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_PIPELINE_LIBRARY")]
        PipelineLibrary = 0x1D,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_VIDEO_DECODER")]
        VideoDecoder = 0x1E,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_VIDEO_PROCESSOR")]
        VideoProcessor = 0x20,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_RESOURCE")]
        Resource = 0x22,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_PASS")]
        Pass = 0x23,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_CRYPTOSESSION")]
        Cryptosession = 0x24,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_CRYPTOSESSIONPOLICY")]
        Cryptosessionpolicy = 0x25,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_PROTECTEDRESOURCESESSION")]
        Protectedresourcesession = 0x26,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_VIDEO_DECODER_HEAP")]
        VideoDecoderHeap = 0x27,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_COMMAND_POOL")]
        CommandPool = 0x28,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_COMMAND_RECORDER")]
        CommandRecorder = 0x29,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_STATE_OBJECT")]
        StateObject = 0x2A,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_METACOMMAND")]
        Metacommand = 0x2B,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_SCHEDULINGGROUP")]
        Schedulinggroup = 0x2C,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_VIDEO_MOTION_ESTIMATOR")]
        VideoMotionEstimator = 0x2D,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_VIDEO_MOTION_VECTOR_HEAP")]
        VideoMotionVectorHeap = 0x2E,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_VIDEO_EXTENSION_COMMAND")]
        VideoExtensionCommand = 0x2F,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_VIDEO_ENCODER")]
        VideoEncoder = 0x30,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_VIDEO_ENCODER_HEAP")]
        VideoEncoderHeap = 0x31,
        [NativeName("Name", "D3D12_DRED_ALLOCATION_TYPE_INVALID")]
        Invalid = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
