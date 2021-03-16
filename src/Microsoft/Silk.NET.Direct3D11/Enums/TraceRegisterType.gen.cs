// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_TRACE_REGISTER_TYPE")]
    public enum TraceRegisterType : int
    {
        [NativeName("Name", "D3D11_TRACE_OUTPUT_NULL_REGISTER")]
        TraceOutputNullRegister = 0x0,
        [NativeName("Name", "D3D11_TRACE_INPUT_REGISTER")]
        TraceInputRegister = 0x1,
        [NativeName("Name", "D3D11_TRACE_INPUT_PRIMITIVE_ID_REGISTER")]
        TraceInputPrimitiveIDRegister = 0x2,
        [NativeName("Name", "D3D11_TRACE_IMMEDIATE_CONSTANT_BUFFER")]
        TraceImmediateConstantBuffer = 0x3,
        [NativeName("Name", "D3D11_TRACE_TEMP_REGISTER")]
        TraceTempRegister = 0x4,
        [NativeName("Name", "D3D11_TRACE_INDEXABLE_TEMP_REGISTER")]
        TraceIndexableTempRegister = 0x5,
        [NativeName("Name", "D3D11_TRACE_OUTPUT_REGISTER")]
        TraceOutputRegister = 0x6,
        [NativeName("Name", "D3D11_TRACE_OUTPUT_DEPTH_REGISTER")]
        TraceOutputDepthRegister = 0x7,
        [NativeName("Name", "D3D11_TRACE_CONSTANT_BUFFER")]
        TraceConstantBuffer = 0x8,
        [NativeName("Name", "D3D11_TRACE_IMMEDIATE32")]
        TraceImmediate32 = 0x9,
        [NativeName("Name", "D3D11_TRACE_SAMPLER")]
        TraceSampler = 0xA,
        [NativeName("Name", "D3D11_TRACE_RESOURCE")]
        TraceResource = 0xB,
        [NativeName("Name", "D3D11_TRACE_RASTERIZER")]
        TraceRasterizer = 0xC,
        [NativeName("Name", "D3D11_TRACE_OUTPUT_COVERAGE_MASK")]
        TraceOutputCoverageMask = 0xD,
        [NativeName("Name", "D3D11_TRACE_STREAM")]
        TraceStream = 0xE,
        [NativeName("Name", "D3D11_TRACE_THIS_POINTER")]
        TraceThisPointer = 0xF,
        [NativeName("Name", "D3D11_TRACE_OUTPUT_CONTROL_POINT_ID_REGISTER")]
        TraceOutputControlPointIDRegister = 0x10,
        [NativeName("Name", "D3D11_TRACE_INPUT_FORK_INSTANCE_ID_REGISTER")]
        TraceInputForkInstanceIDRegister = 0x11,
        [NativeName("Name", "D3D11_TRACE_INPUT_JOIN_INSTANCE_ID_REGISTER")]
        TraceInputJoinInstanceIDRegister = 0x12,
        [NativeName("Name", "D3D11_TRACE_INPUT_CONTROL_POINT_REGISTER")]
        TraceInputControlPointRegister = 0x13,
        [NativeName("Name", "D3D11_TRACE_OUTPUT_CONTROL_POINT_REGISTER")]
        TraceOutputControlPointRegister = 0x14,
        [NativeName("Name", "D3D11_TRACE_INPUT_PATCH_CONSTANT_REGISTER")]
        TraceInputPatchConstantRegister = 0x15,
        [NativeName("Name", "D3D11_TRACE_INPUT_DOMAIN_POINT_REGISTER")]
        TraceInputDomainPointRegister = 0x16,
        [NativeName("Name", "D3D11_TRACE_UNORDERED_ACCESS_VIEW")]
        TraceUnorderedAccessView = 0x17,
        [NativeName("Name", "D3D11_TRACE_THREAD_GROUP_SHARED_MEMORY")]
        TraceThreadGroupSharedMemory = 0x18,
        [NativeName("Name", "D3D11_TRACE_INPUT_THREAD_ID_REGISTER")]
        TraceInputThreadIDRegister = 0x19,
        [NativeName("Name", "D3D11_TRACE_INPUT_THREAD_GROUP_ID_REGISTER")]
        TraceInputThreadGroupIDRegister = 0x1A,
        [NativeName("Name", "D3D11_TRACE_INPUT_THREAD_ID_IN_GROUP_REGISTER")]
        TraceInputThreadIDInGroupRegister = 0x1B,
        [NativeName("Name", "D3D11_TRACE_INPUT_COVERAGE_MASK_REGISTER")]
        TraceInputCoverageMaskRegister = 0x1C,
        [NativeName("Name", "D3D11_TRACE_INPUT_THREAD_ID_IN_GROUP_FLATTENED_REGISTER")]
        TraceInputThreadIDInGroupFlattenedRegister = 0x1D,
        [NativeName("Name", "D3D11_TRACE_INPUT_GS_INSTANCE_ID_REGISTER")]
        TraceInputGSInstanceIDRegister = 0x1E,
        [NativeName("Name", "D3D11_TRACE_OUTPUT_DEPTH_GREATER_EQUAL_REGISTER")]
        TraceOutputDepthGreaterEqualRegister = 0x1F,
        [NativeName("Name", "D3D11_TRACE_OUTPUT_DEPTH_LESS_EQUAL_REGISTER")]
        TraceOutputDepthLessEqualRegister = 0x20,
        [NativeName("Name", "D3D11_TRACE_IMMEDIATE64")]
        TraceImmediate64 = 0x21,
        [NativeName("Name", "D3D11_TRACE_INPUT_CYCLE_COUNTER_REGISTER")]
        TraceInputCycleCounterRegister = 0x22,
        [NativeName("Name", "D3D11_TRACE_INTERFACE_POINTER")]
        TraceInterfacePointer = 0x23,
    }
}
