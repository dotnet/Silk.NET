// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_TRACE_REGISTER_TYPE")]
    public enum TraceRegisterType : int
    {
        [Obsolete("Deprecated in favour of \"OutputNullRegister\"")]
        [NativeName("Name", "D3D11_TRACE_OUTPUT_NULL_REGISTER")]
        TraceOutputNullRegister = 0x0,
        [Obsolete("Deprecated in favour of \"InputRegister\"")]
        [NativeName("Name", "D3D11_TRACE_INPUT_REGISTER")]
        TraceInputRegister = 0x1,
        [Obsolete("Deprecated in favour of \"InputPrimitiveIDRegister\"")]
        [NativeName("Name", "D3D11_TRACE_INPUT_PRIMITIVE_ID_REGISTER")]
        TraceInputPrimitiveIDRegister = 0x2,
        [Obsolete("Deprecated in favour of \"ImmediateConstantBuffer\"")]
        [NativeName("Name", "D3D11_TRACE_IMMEDIATE_CONSTANT_BUFFER")]
        TraceImmediateConstantBuffer = 0x3,
        [Obsolete("Deprecated in favour of \"TempRegister\"")]
        [NativeName("Name", "D3D11_TRACE_TEMP_REGISTER")]
        TraceTempRegister = 0x4,
        [Obsolete("Deprecated in favour of \"IndexableTempRegister\"")]
        [NativeName("Name", "D3D11_TRACE_INDEXABLE_TEMP_REGISTER")]
        TraceIndexableTempRegister = 0x5,
        [Obsolete("Deprecated in favour of \"OutputRegister\"")]
        [NativeName("Name", "D3D11_TRACE_OUTPUT_REGISTER")]
        TraceOutputRegister = 0x6,
        [Obsolete("Deprecated in favour of \"OutputDepthRegister\"")]
        [NativeName("Name", "D3D11_TRACE_OUTPUT_DEPTH_REGISTER")]
        TraceOutputDepthRegister = 0x7,
        [Obsolete("Deprecated in favour of \"ConstantBuffer\"")]
        [NativeName("Name", "D3D11_TRACE_CONSTANT_BUFFER")]
        TraceConstantBuffer = 0x8,
        [Obsolete("Deprecated in favour of \"Immediate32\"")]
        [NativeName("Name", "D3D11_TRACE_IMMEDIATE32")]
        TraceImmediate32 = 0x9,
        [Obsolete("Deprecated in favour of \"Sampler\"")]
        [NativeName("Name", "D3D11_TRACE_SAMPLER")]
        TraceSampler = 0xA,
        [Obsolete("Deprecated in favour of \"Resource\"")]
        [NativeName("Name", "D3D11_TRACE_RESOURCE")]
        TraceResource = 0xB,
        [Obsolete("Deprecated in favour of \"Rasterizer\"")]
        [NativeName("Name", "D3D11_TRACE_RASTERIZER")]
        TraceRasterizer = 0xC,
        [Obsolete("Deprecated in favour of \"OutputCoverageMask\"")]
        [NativeName("Name", "D3D11_TRACE_OUTPUT_COVERAGE_MASK")]
        TraceOutputCoverageMask = 0xD,
        [Obsolete("Deprecated in favour of \"Stream\"")]
        [NativeName("Name", "D3D11_TRACE_STREAM")]
        TraceStream = 0xE,
        [Obsolete("Deprecated in favour of \"ThisPointer\"")]
        [NativeName("Name", "D3D11_TRACE_THIS_POINTER")]
        TraceThisPointer = 0xF,
        [Obsolete("Deprecated in favour of \"OutputControlPointIDRegister\"")]
        [NativeName("Name", "D3D11_TRACE_OUTPUT_CONTROL_POINT_ID_REGISTER")]
        TraceOutputControlPointIDRegister = 0x10,
        [Obsolete("Deprecated in favour of \"InputForkInstanceIDRegister\"")]
        [NativeName("Name", "D3D11_TRACE_INPUT_FORK_INSTANCE_ID_REGISTER")]
        TraceInputForkInstanceIDRegister = 0x11,
        [Obsolete("Deprecated in favour of \"InputJoinInstanceIDRegister\"")]
        [NativeName("Name", "D3D11_TRACE_INPUT_JOIN_INSTANCE_ID_REGISTER")]
        TraceInputJoinInstanceIDRegister = 0x12,
        [Obsolete("Deprecated in favour of \"InputControlPointRegister\"")]
        [NativeName("Name", "D3D11_TRACE_INPUT_CONTROL_POINT_REGISTER")]
        TraceInputControlPointRegister = 0x13,
        [Obsolete("Deprecated in favour of \"OutputControlPointRegister\"")]
        [NativeName("Name", "D3D11_TRACE_OUTPUT_CONTROL_POINT_REGISTER")]
        TraceOutputControlPointRegister = 0x14,
        [Obsolete("Deprecated in favour of \"InputPatchConstantRegister\"")]
        [NativeName("Name", "D3D11_TRACE_INPUT_PATCH_CONSTANT_REGISTER")]
        TraceInputPatchConstantRegister = 0x15,
        [Obsolete("Deprecated in favour of \"InputDomainPointRegister\"")]
        [NativeName("Name", "D3D11_TRACE_INPUT_DOMAIN_POINT_REGISTER")]
        TraceInputDomainPointRegister = 0x16,
        [Obsolete("Deprecated in favour of \"UnorderedAccessView\"")]
        [NativeName("Name", "D3D11_TRACE_UNORDERED_ACCESS_VIEW")]
        TraceUnorderedAccessView = 0x17,
        [Obsolete("Deprecated in favour of \"ThreadGroupSharedMemory\"")]
        [NativeName("Name", "D3D11_TRACE_THREAD_GROUP_SHARED_MEMORY")]
        TraceThreadGroupSharedMemory = 0x18,
        [Obsolete("Deprecated in favour of \"InputThreadIDRegister\"")]
        [NativeName("Name", "D3D11_TRACE_INPUT_THREAD_ID_REGISTER")]
        TraceInputThreadIDRegister = 0x19,
        [Obsolete("Deprecated in favour of \"InputThreadGroupIDRegister\"")]
        [NativeName("Name", "D3D11_TRACE_INPUT_THREAD_GROUP_ID_REGISTER")]
        TraceInputThreadGroupIDRegister = 0x1A,
        [Obsolete("Deprecated in favour of \"InputThreadIDInGroupRegister\"")]
        [NativeName("Name", "D3D11_TRACE_INPUT_THREAD_ID_IN_GROUP_REGISTER")]
        TraceInputThreadIDInGroupRegister = 0x1B,
        [Obsolete("Deprecated in favour of \"InputCoverageMaskRegister\"")]
        [NativeName("Name", "D3D11_TRACE_INPUT_COVERAGE_MASK_REGISTER")]
        TraceInputCoverageMaskRegister = 0x1C,
        [Obsolete("Deprecated in favour of \"InputThreadIDInGroupFlattenedRegister\"")]
        [NativeName("Name", "D3D11_TRACE_INPUT_THREAD_ID_IN_GROUP_FLATTENED_REGISTER")]
        TraceInputThreadIDInGroupFlattenedRegister = 0x1D,
        [Obsolete("Deprecated in favour of \"InputGSInstanceIDRegister\"")]
        [NativeName("Name", "D3D11_TRACE_INPUT_GS_INSTANCE_ID_REGISTER")]
        TraceInputGSInstanceIDRegister = 0x1E,
        [Obsolete("Deprecated in favour of \"OutputDepthGreaterEqualRegister\"")]
        [NativeName("Name", "D3D11_TRACE_OUTPUT_DEPTH_GREATER_EQUAL_REGISTER")]
        TraceOutputDepthGreaterEqualRegister = 0x1F,
        [Obsolete("Deprecated in favour of \"OutputDepthLessEqualRegister\"")]
        [NativeName("Name", "D3D11_TRACE_OUTPUT_DEPTH_LESS_EQUAL_REGISTER")]
        TraceOutputDepthLessEqualRegister = 0x20,
        [Obsolete("Deprecated in favour of \"Immediate64\"")]
        [NativeName("Name", "D3D11_TRACE_IMMEDIATE64")]
        TraceImmediate64 = 0x21,
        [Obsolete("Deprecated in favour of \"InputCycleCounterRegister\"")]
        [NativeName("Name", "D3D11_TRACE_INPUT_CYCLE_COUNTER_REGISTER")]
        TraceInputCycleCounterRegister = 0x22,
        [Obsolete("Deprecated in favour of \"InterfacePointer\"")]
        [NativeName("Name", "D3D11_TRACE_INTERFACE_POINTER")]
        TraceInterfacePointer = 0x23,
        [NativeName("Name", "D3D11_TRACE_OUTPUT_NULL_REGISTER")]
        OutputNullRegister = 0x0,
        [NativeName("Name", "D3D11_TRACE_INPUT_REGISTER")]
        InputRegister = 0x1,
        [NativeName("Name", "D3D11_TRACE_INPUT_PRIMITIVE_ID_REGISTER")]
        InputPrimitiveIDRegister = 0x2,
        [NativeName("Name", "D3D11_TRACE_IMMEDIATE_CONSTANT_BUFFER")]
        ImmediateConstantBuffer = 0x3,
        [NativeName("Name", "D3D11_TRACE_TEMP_REGISTER")]
        TempRegister = 0x4,
        [NativeName("Name", "D3D11_TRACE_INDEXABLE_TEMP_REGISTER")]
        IndexableTempRegister = 0x5,
        [NativeName("Name", "D3D11_TRACE_OUTPUT_REGISTER")]
        OutputRegister = 0x6,
        [NativeName("Name", "D3D11_TRACE_OUTPUT_DEPTH_REGISTER")]
        OutputDepthRegister = 0x7,
        [NativeName("Name", "D3D11_TRACE_CONSTANT_BUFFER")]
        ConstantBuffer = 0x8,
        [NativeName("Name", "D3D11_TRACE_IMMEDIATE32")]
        Immediate32 = 0x9,
        [NativeName("Name", "D3D11_TRACE_SAMPLER")]
        Sampler = 0xA,
        [NativeName("Name", "D3D11_TRACE_RESOURCE")]
        Resource = 0xB,
        [NativeName("Name", "D3D11_TRACE_RASTERIZER")]
        Rasterizer = 0xC,
        [NativeName("Name", "D3D11_TRACE_OUTPUT_COVERAGE_MASK")]
        OutputCoverageMask = 0xD,
        [NativeName("Name", "D3D11_TRACE_STREAM")]
        Stream = 0xE,
        [NativeName("Name", "D3D11_TRACE_THIS_POINTER")]
        ThisPointer = 0xF,
        [NativeName("Name", "D3D11_TRACE_OUTPUT_CONTROL_POINT_ID_REGISTER")]
        OutputControlPointIDRegister = 0x10,
        [NativeName("Name", "D3D11_TRACE_INPUT_FORK_INSTANCE_ID_REGISTER")]
        InputForkInstanceIDRegister = 0x11,
        [NativeName("Name", "D3D11_TRACE_INPUT_JOIN_INSTANCE_ID_REGISTER")]
        InputJoinInstanceIDRegister = 0x12,
        [NativeName("Name", "D3D11_TRACE_INPUT_CONTROL_POINT_REGISTER")]
        InputControlPointRegister = 0x13,
        [NativeName("Name", "D3D11_TRACE_OUTPUT_CONTROL_POINT_REGISTER")]
        OutputControlPointRegister = 0x14,
        [NativeName("Name", "D3D11_TRACE_INPUT_PATCH_CONSTANT_REGISTER")]
        InputPatchConstantRegister = 0x15,
        [NativeName("Name", "D3D11_TRACE_INPUT_DOMAIN_POINT_REGISTER")]
        InputDomainPointRegister = 0x16,
        [NativeName("Name", "D3D11_TRACE_UNORDERED_ACCESS_VIEW")]
        UnorderedAccessView = 0x17,
        [NativeName("Name", "D3D11_TRACE_THREAD_GROUP_SHARED_MEMORY")]
        ThreadGroupSharedMemory = 0x18,
        [NativeName("Name", "D3D11_TRACE_INPUT_THREAD_ID_REGISTER")]
        InputThreadIDRegister = 0x19,
        [NativeName("Name", "D3D11_TRACE_INPUT_THREAD_GROUP_ID_REGISTER")]
        InputThreadGroupIDRegister = 0x1A,
        [NativeName("Name", "D3D11_TRACE_INPUT_THREAD_ID_IN_GROUP_REGISTER")]
        InputThreadIDInGroupRegister = 0x1B,
        [NativeName("Name", "D3D11_TRACE_INPUT_COVERAGE_MASK_REGISTER")]
        InputCoverageMaskRegister = 0x1C,
        [NativeName("Name", "D3D11_TRACE_INPUT_THREAD_ID_IN_GROUP_FLATTENED_REGISTER")]
        InputThreadIDInGroupFlattenedRegister = 0x1D,
        [NativeName("Name", "D3D11_TRACE_INPUT_GS_INSTANCE_ID_REGISTER")]
        InputGSInstanceIDRegister = 0x1E,
        [NativeName("Name", "D3D11_TRACE_OUTPUT_DEPTH_GREATER_EQUAL_REGISTER")]
        OutputDepthGreaterEqualRegister = 0x1F,
        [NativeName("Name", "D3D11_TRACE_OUTPUT_DEPTH_LESS_EQUAL_REGISTER")]
        OutputDepthLessEqualRegister = 0x20,
        [NativeName("Name", "D3D11_TRACE_IMMEDIATE64")]
        Immediate64 = 0x21,
        [NativeName("Name", "D3D11_TRACE_INPUT_CYCLE_COUNTER_REGISTER")]
        InputCycleCounterRegister = 0x22,
        [NativeName("Name", "D3D11_TRACE_INTERFACE_POINTER")]
        InterfacePointer = 0x23,
    }
}
