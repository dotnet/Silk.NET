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
    public unsafe partial class D3D12 : NativeAPI
    {
        [NativeName("Type", "int")]
        [NativeName("Name", "__REQUIRED_RPCNDR_H_VERSION__")]
        public const int RequiredRpcndrHVersion = unchecked((int) 0x1F4);
        [NativeName("Type", "int")]
        [NativeName("Name", "__REQUIRED_RPCSAL_H_VERSION__")]
        public const int RequiredRpcsalHVersion = unchecked((int) 0x64);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_INFO_QUEUE_DEFAULT_MESSAGE_COUNT_LIMIT")]
        public const int InfoQueueDefaultMessageCountLimit = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_DOUBLES")]
        public const int D3DShaderRequiresDoubles = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_EARLY_DEPTH_STENCIL")]
        public const int D3DShaderRequiresEarlyDepthStencil = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_UAVS_AT_EVERY_STAGE")]
        public const int D3DShaderRequiresUavsATEveryStage = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_64_UAVS")]
        public const int D3DShaderRequires64Uavs = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_MINIMUM_PRECISION")]
        public const int D3DShaderRequiresMinimumPrecision = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_11_1_DOUBLE_EXTENSIONS")]
        public const int D3DShaderRequires111DoubleExtensions = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_11_1_SHADER_EXTENSIONS")]
        public const int D3DShaderRequires111ShaderExtensions = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_LEVEL_9_COMPARISON_FILTERING")]
        public const int D3DShaderRequiresLevel9ComparisonFiltering = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_TILED_RESOURCES")]
        public const int D3DShaderRequiresTiledResources = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_STENCIL_REF")]
        public const int D3DShaderRequiresStencilRef = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_INNER_COVERAGE")]
        public const int D3DShaderRequiresInnerCoverage = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_TYPED_UAV_LOAD_ADDITIONAL_FORMATS")]
        public const int D3DShaderRequiresTypedUavLoadAdditionalFormats = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_ROVS")]
        public const int D3DShaderRequiresRovs = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_VIEWPORT_AND_RT_ARRAY_INDEX_FROM_ANY_SHADER_FEEDING_RASTERIZER")]
        public const int D3DShaderRequiresViewportAndRTArrayIndexFromAnyShaderFeedingRasterizer = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_WAVE_OPS")]
        public const int D3DShaderRequiresWaveOps = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_INT64_OPS")]
        public const int D3DShaderRequiresInt64Ops = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_VIEW_ID")]
        public const int D3DShaderRequiresViewID = unchecked((int) 0x10000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_BARYCENTRICS")]
        public const int D3DShaderRequiresBarycentrics = unchecked((int) 0x20000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_NATIVE_16BIT_OPS")]
        public const int D3DShaderRequiresNative16BitOps = unchecked((int) 0x40000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_SHADING_RATE")]
        public const int D3DShaderRequiresShadingRate = unchecked((int) 0x80000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_RAYTRACING_TIER_1_1")]
        public const int D3DShaderRequiresRaytracingTier11 = unchecked((int) 0x100000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_SAMPLER_FEEDBACK")]
        public const int D3DShaderRequiresSamplerFeedback = unchecked((int) 0x200000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_ATOMIC_INT64_ON_TYPED_RESOURCE")]
        public const int D3DShaderRequiresAtomicInt64OnTypedResource = unchecked((int) 0x400000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_ATOMIC_INT64_ON_GROUP_SHARED")]
        public const int D3DShaderRequiresAtomicInt64OnGroupShared = unchecked((int) 0x800000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_DERIVATIVES_IN_MESH_AND_AMPLIFICATION_SHADERS")]
        public const int D3DShaderRequiresDerivativesInMeshAndAmplificationShaders = unchecked((int) 0x1000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_RESOURCE_DESCRIPTOR_HEAP_INDEXING")]
        public const int D3DShaderRequiresResourceDescriptorHeapIndexing = unchecked((int) 0x2000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_SAMPLER_DESCRIPTOR_HEAP_INDEXING")]
        public const int D3DShaderRequiresSamplerDescriptorHeapIndexing = unchecked((int) 0x4000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_WAVE_MMA")]
        public const int D3DShaderRequiresWaveMma = unchecked((int) 0x8000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_ATOMIC_INT64_ON_DESCRIPTOR_HEAP_RESOURCE")]
        public const int D3DShaderRequiresAtomicInt64OnDescriptorHeapResource = unchecked((int) 0x10000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_ADVANCED_TEXTURE_OPS")]
        public const int D3DShaderRequiresAdvancedTextureOps = unchecked((int) 0x20000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_WRITEABLE_MSAA_TEXTURES")]
        public const int D3DShaderRequiresWriteableMsaaTextures = unchecked((int) 0x40000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_SAMPLE_CMP_GRADIENT_OR_BIAS")]
        public const uint D3DShaderRequiresSampleCmpGradientOrBias = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "unsigned long long")]
        [NativeName("Name", "D3D_SHADER_REQUIRES_EXTENDED_COMMAND_INFO")]
        public const ulong D3DShaderRequiresExtendedCommandInfo = unchecked((ulong) 0x100000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_16BIT_INDEX_STRIP_CUT_VALUE")]
        public const int D3D1216BitIndexStripCutValue = unchecked((int) 0xFFFF);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D12_32BIT_INDEX_STRIP_CUT_VALUE")]
        public const uint D3D1232BitIndexStripCutValue = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_8BIT_INDEX_STRIP_CUT_VALUE")]
        public const int D3D128BitIndexStripCutValue = unchecked((int) 0xFF);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D12_APPEND_ALIGNED_ELEMENT")]
        public const uint AppendAlignedElement = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_ARRAY_AXIS_ADDRESS_RANGE_BIT_COUNT")]
        public const int ArrayAxisAddressRangeBitCount = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CLIP_OR_CULL_DISTANCE_COUNT")]
        public const int ClipOrCullDistanceCount = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CLIP_OR_CULL_DISTANCE_ELEMENT_COUNT")]
        public const int ClipOrCullDistanceElementCount = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT")]
        public const int CommonshaderConstantBufferApiSlotCount = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_CONSTANT_BUFFER_COMPONENTS")]
        public const int CommonshaderConstantBufferComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_CONSTANT_BUFFER_COMPONENT_BIT_COUNT")]
        public const int CommonshaderConstantBufferComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_CONSTANT_BUFFER_HW_SLOT_COUNT")]
        public const int CommonshaderConstantBufferHWSlotCount = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_CONSTANT_BUFFER_PARTIAL_UPDATE_EXTENTS_BYTE_ALIGNMENT")]
        public const int CommonshaderConstantBufferPartialUpdateExtentsByteAlignment = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COMPONENTS")]
        public const int CommonshaderConstantBufferRegisterComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COUNT")]
        public const int CommonshaderConstantBufferRegisterCount = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READS_PER_INST")]
        public const int CommonshaderConstantBufferRegisterReadsPerInst = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READ_PORTS")]
        public const int CommonshaderConstantBufferRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_FLOWCONTROL_NESTING_LIMIT")]
        public const int CommonshaderFlowcontrolNestingLimit = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COMPONENTS")]
        public const int CommonshaderImmediateConstantBufferRegisterComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COUNT")]
        public const int CommonshaderImmediateConstantBufferRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READS_PER_INST")]
        public const int CommonshaderImmediateConstantBufferRegisterReadsPerInst = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READ_PORTS")]
        public const int CommonshaderImmediateConstantBufferRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_IMMEDIATE_VALUE_COMPONENT_BIT_COUNT")]
        public const int CommonshaderImmediateValueComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_INPUT_RESOURCE_REGISTER_COMPONENTS")]
        public const int CommonshaderInputResourceRegisterComponents = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_INPUT_RESOURCE_REGISTER_COUNT")]
        public const int CommonshaderInputResourceRegisterCount = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_INPUT_RESOURCE_REGISTER_READS_PER_INST")]
        public const int CommonshaderInputResourceRegisterReadsPerInst = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_INPUT_RESOURCE_REGISTER_READ_PORTS")]
        public const int CommonshaderInputResourceRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT")]
        public const int CommonshaderInputResourceSlotCount = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_SAMPLER_REGISTER_COMPONENTS")]
        public const int CommonshaderSamplerRegisterComponents = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_SAMPLER_REGISTER_COUNT")]
        public const int CommonshaderSamplerRegisterCount = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_SAMPLER_REGISTER_READS_PER_INST")]
        public const int CommonshaderSamplerRegisterReadsPerInst = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_SAMPLER_REGISTER_READ_PORTS")]
        public const int CommonshaderSamplerRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_SAMPLER_SLOT_COUNT")]
        public const int CommonshaderSamplerSlotCount = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_SUBROUTINE_NESTING_LIMIT")]
        public const int CommonshaderSubroutineNestingLimit = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_TEMP_REGISTER_COMPONENTS")]
        public const int CommonshaderTempRegisterComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_TEMP_REGISTER_COMPONENT_BIT_COUNT")]
        public const int CommonshaderTempRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_TEMP_REGISTER_COUNT")]
        public const int CommonshaderTempRegisterCount = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_TEMP_REGISTER_READS_PER_INST")]
        public const int CommonshaderTempRegisterReadsPerInst = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_TEMP_REGISTER_READ_PORTS")]
        public const int CommonshaderTempRegisterReadPorts = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MAX")]
        public const int CommonshaderTexcoordRangeReductionMax = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_COMMONSHADER_TEXEL_OFFSET_MAX_POSITIVE")]
        public const int CommonshaderTexelOffsetMaxPositive = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CONSTANT_BUFFER_DATA_PLACEMENT_ALIGNMENT")]
        public const int ConstantBufferDataPlacementAlignment = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET00_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket00MaxBytesTgsmWritablePerThread = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET00_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket00MaxNumThreadsPerGroup = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET01_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket01MaxBytesTgsmWritablePerThread = unchecked((int) 0xF0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET01_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket01MaxNumThreadsPerGroup = unchecked((int) 0x44);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET02_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket02MaxBytesTgsmWritablePerThread = unchecked((int) 0xE0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET02_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket02MaxNumThreadsPerGroup = unchecked((int) 0x48);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET03_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket03MaxBytesTgsmWritablePerThread = unchecked((int) 0xD0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET03_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket03MaxNumThreadsPerGroup = unchecked((int) 0x4C);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET04_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket04MaxBytesTgsmWritablePerThread = unchecked((int) 0xC0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET04_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket04MaxNumThreadsPerGroup = unchecked((int) 0x54);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET05_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket05MaxBytesTgsmWritablePerThread = unchecked((int) 0xB0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET05_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket05MaxNumThreadsPerGroup = unchecked((int) 0x5C);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET06_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket06MaxBytesTgsmWritablePerThread = unchecked((int) 0xA0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET06_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket06MaxNumThreadsPerGroup = unchecked((int) 0x64);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET07_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket07MaxBytesTgsmWritablePerThread = unchecked((int) 0x90);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET07_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket07MaxNumThreadsPerGroup = unchecked((int) 0x70);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET08_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket08MaxBytesTgsmWritablePerThread = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET08_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket08MaxNumThreadsPerGroup = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET09_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket09MaxBytesTgsmWritablePerThread = unchecked((int) 0x70);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET09_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket09MaxNumThreadsPerGroup = unchecked((int) 0x90);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET10_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket10MaxBytesTgsmWritablePerThread = unchecked((int) 0x60);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET10_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket10MaxNumThreadsPerGroup = unchecked((int) 0xA8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET11_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket11MaxBytesTgsmWritablePerThread = unchecked((int) 0x50);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET11_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket11MaxNumThreadsPerGroup = unchecked((int) 0xCC);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET12_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket12MaxBytesTgsmWritablePerThread = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET12_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket12MaxNumThreadsPerGroup = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET13_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket13MaxBytesTgsmWritablePerThread = unchecked((int) 0x30);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET13_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket13MaxNumThreadsPerGroup = unchecked((int) 0x154);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET14_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket14MaxBytesTgsmWritablePerThread = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET14_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket14MaxNumThreadsPerGroup = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET15_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket15MaxBytesTgsmWritablePerThread = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_BUCKET15_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket15MaxNumThreadsPerGroup = unchecked((int) 0x300);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_DISPATCH_MAX_THREAD_GROUPS_IN_Z_DIMENSION")]
        public const int CS4XDispatchMaxThreadGroupsInZDimension = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_RAW_UAV_BYTE_ALIGNMENT")]
        public const int CS4XRawUavByteAlignment = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_THREAD_GROUP_MAX_THREADS_PER_GROUP")]
        public const int CS4XThreadGroupMaxThreadsPerGroup = unchecked((int) 0x300);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_THREAD_GROUP_MAX_X")]
        public const int CS4XThreadGroupMaxX = unchecked((int) 0x300);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_THREAD_GROUP_MAX_Y")]
        public const int CS4XThreadGroupMaxY = unchecked((int) 0x300);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_4_X_UAV_REGISTER_COUNT")]
        public const int CS4XUavRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_DISPATCH_MAX_THREAD_GROUPS_PER_DIMENSION")]
        public const int CSDispatchMaxThreadGroupsPerDimension = unchecked((int) 0xFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_TGSM_REGISTER_COUNT")]
        public const int CSTgsmRegisterCount = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_TGSM_REGISTER_READS_PER_INST")]
        public const int CSTgsmRegisterReadsPerInst = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_TGSM_RESOURCE_REGISTER_COMPONENTS")]
        public const int CSTgsmResourceRegisterComponents = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_TGSM_RESOURCE_REGISTER_READ_PORTS")]
        public const int CSTgsmResourceRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_THREADGROUPID_REGISTER_COMPONENTS")]
        public const int CSThreadgroupidRegisterComponents = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_THREADGROUPID_REGISTER_COUNT")]
        public const int CSThreadgroupidRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_THREADIDINGROUPFLATTENED_REGISTER_COMPONENTS")]
        public const int CSThreadidingroupflattenedRegisterComponents = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_THREADIDINGROUPFLATTENED_REGISTER_COUNT")]
        public const int CSThreadidingroupflattenedRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_THREADIDINGROUP_REGISTER_COMPONENTS")]
        public const int CSThreadidingroupRegisterComponents = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_THREADIDINGROUP_REGISTER_COUNT")]
        public const int CSThreadidingroupRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_THREADID_REGISTER_COMPONENTS")]
        public const int CSThreadidRegisterComponents = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_THREADID_REGISTER_COUNT")]
        public const int CSThreadidRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_THREAD_GROUP_MAX_THREADS_PER_GROUP")]
        public const int CSThreadGroupMaxThreadsPerGroup = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_THREAD_GROUP_MAX_X")]
        public const int CSThreadGroupMaxX = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_THREAD_GROUP_MAX_Y")]
        public const int CSThreadGroupMaxY = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_THREAD_GROUP_MAX_Z")]
        public const int CSThreadGroupMaxZ = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_THREAD_GROUP_MIN_X")]
        public const int CSThreadGroupMinX = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_THREAD_GROUP_MIN_Y")]
        public const int CSThreadGroupMinY = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_THREAD_GROUP_MIN_Z")]
        public const int CSThreadGroupMinZ = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_CS_THREAD_LOCAL_TEMP_REGISTER_POOL")]
        public const int CSThreadLocalTempRegisterPool = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DEFAULT_DEPTH_BIAS")]
        public const int DefaultDepthBias = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DEFAULT_MAX_ANISOTROPY")]
        public const int DefaultMaxAnisotropy = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DEFAULT_MSAA_RESOURCE_PLACEMENT_ALIGNMENT")]
        public const int DefaultMsaaResourcePlacementAlignment = unchecked((int) 0x400000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DEFAULT_RENDER_TARGET_ARRAY_INDEX")]
        public const int DefaultRenderTargetArrayIndex = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DEFAULT_RESOURCE_PLACEMENT_ALIGNMENT")]
        public const int DefaultResourcePlacementAlignment = unchecked((int) 0x10000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D12_DEFAULT_SAMPLE_MASK")]
        public const uint DefaultSampleMask = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DEFAULT_SCISSOR_ENDX")]
        public const int DefaultScissorEndx = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DEFAULT_SCISSOR_ENDY")]
        public const int DefaultScissorEndy = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DEFAULT_SCISSOR_STARTX")]
        public const int DefaultScissorStartx = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DEFAULT_SCISSOR_STARTY")]
        public const int DefaultScissorStarty = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DEFAULT_STENCIL_READ_MASK")]
        public const int DefaultStencilReadMask = unchecked((int) 0xFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DEFAULT_STENCIL_REFERENCE")]
        public const int DefaultStencilReference = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DEFAULT_STENCIL_WRITE_MASK")]
        public const int DefaultStencilWriteMask = unchecked((int) 0xFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DEFAULT_VIEWPORT_AND_SCISSORRECT_INDEX")]
        public const int DefaultViewportAndScissorrectIndex = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DEFAULT_VIEWPORT_HEIGHT")]
        public const int DefaultViewportHeight = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DEFAULT_VIEWPORT_TOPLEFTX")]
        public const int DefaultViewportTopleftx = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DEFAULT_VIEWPORT_TOPLEFTY")]
        public const int DefaultViewportToplefty = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DEFAULT_VIEWPORT_WIDTH")]
        public const int DefaultViewportWidth = unchecked((int) 0x0);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D12_DESCRIPTOR_RANGE_OFFSET_APPEND")]
        public const uint DescriptorRangeOffsetAppend = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D12_DRIVER_RESERVED_REGISTER_SPACE_VALUES_END")]
        public const uint DriverReservedRegisterSpaceValuesEnd = unchecked((uint) 0xFFFFFFFFFFFFFFF7);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D12_DRIVER_RESERVED_REGISTER_SPACE_VALUES_START")]
        public const uint DriverReservedRegisterSpaceValuesStart = unchecked((uint) 0xFFFFFFFFFFFFFFF0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DS_INPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS")]
        public const int DSInputControlPointsMaxTotalScalars = unchecked((int) 0xF80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENTS")]
        public const int DSInputControlPointRegisterComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT")]
        public const int DSInputControlPointRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DS_INPUT_CONTROL_POINT_REGISTER_COUNT")]
        public const int DSInputControlPointRegisterCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DS_INPUT_CONTROL_POINT_REGISTER_READS_PER_INST")]
        public const int DSInputControlPointRegisterReadsPerInst = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DS_INPUT_CONTROL_POINT_REGISTER_READ_PORTS")]
        public const int DSInputControlPointRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENTS")]
        public const int DSInputDomainPointRegisterComponents = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENT_BIT_COUNT")]
        public const int DSInputDomainPointRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DS_INPUT_DOMAIN_POINT_REGISTER_COUNT")]
        public const int DSInputDomainPointRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DS_INPUT_DOMAIN_POINT_REGISTER_READS_PER_INST")]
        public const int DSInputDomainPointRegisterReadsPerInst = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DS_INPUT_DOMAIN_POINT_REGISTER_READ_PORTS")]
        public const int DSInputDomainPointRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENTS")]
        public const int DSInputPatchConstantRegisterComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT")]
        public const int DSInputPatchConstantRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DS_INPUT_PATCH_CONSTANT_REGISTER_COUNT")]
        public const int DSInputPatchConstantRegisterCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DS_INPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST")]
        public const int DSInputPatchConstantRegisterReadsPerInst = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DS_INPUT_PATCH_CONSTANT_REGISTER_READ_PORTS")]
        public const int DSInputPatchConstantRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS")]
        public const int DSInputPrimitiveIDRegisterComponents = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT")]
        public const int DSInputPrimitiveIDRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DS_INPUT_PRIMITIVE_ID_REGISTER_COUNT")]
        public const int DSInputPrimitiveIDRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST")]
        public const int DSInputPrimitiveIDRegisterReadsPerInst = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS")]
        public const int DSInputPrimitiveIDRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DS_OUTPUT_REGISTER_COMPONENTS")]
        public const int DSOutputRegisterComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT")]
        public const int DSOutputRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_DS_OUTPUT_REGISTER_COUNT")]
        public const int DSOutputRegisterCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_GS_INPUT_INSTANCE_ID_READS_PER_INST")]
        public const int GSInputInstanceIDReadsPerInst = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_GS_INPUT_INSTANCE_ID_READ_PORTS")]
        public const int GSInputInstanceIDReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENTS")]
        public const int GSInputInstanceIDRegisterComponents = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT")]
        public const int GSInputInstanceIDRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_GS_INPUT_INSTANCE_ID_REGISTER_COUNT")]
        public const int GSInputInstanceIDRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_GS_INPUT_PRIM_CONST_REGISTER_COMPONENTS")]
        public const int GSInputPrimConstRegisterComponents = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_GS_INPUT_PRIM_CONST_REGISTER_COMPONENT_BIT_COUNT")]
        public const int GSInputPrimConstRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_GS_INPUT_PRIM_CONST_REGISTER_COUNT")]
        public const int GSInputPrimConstRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_GS_INPUT_PRIM_CONST_REGISTER_READS_PER_INST")]
        public const int GSInputPrimConstRegisterReadsPerInst = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_GS_INPUT_PRIM_CONST_REGISTER_READ_PORTS")]
        public const int GSInputPrimConstRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_GS_INPUT_REGISTER_COMPONENTS")]
        public const int GSInputRegisterComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_GS_INPUT_REGISTER_COMPONENT_BIT_COUNT")]
        public const int GSInputRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_GS_INPUT_REGISTER_COUNT")]
        public const int GSInputRegisterCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_GS_INPUT_REGISTER_READS_PER_INST")]
        public const int GSInputRegisterReadsPerInst = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_GS_INPUT_REGISTER_READ_PORTS")]
        public const int GSInputRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_GS_INPUT_REGISTER_VERTICES")]
        public const int GSInputRegisterVertices = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_GS_MAX_INSTANCE_COUNT")]
        public const int GSMaxInstanceCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_GS_MAX_OUTPUT_VERTEX_COUNT_ACROSS_INSTANCES")]
        public const int GSMaxOutputVertexCountAcrossInstances = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_GS_OUTPUT_ELEMENTS")]
        public const int GSOutputElements = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_GS_OUTPUT_REGISTER_COMPONENTS")]
        public const int GSOutputRegisterComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_GS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT")]
        public const int GSOutputRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_GS_OUTPUT_REGISTER_COUNT")]
        public const int GSOutputRegisterCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_CONTROL_POINT_PHASE_INPUT_REGISTER_COUNT")]
        public const int HSControlPointPhaseInputRegisterCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_CONTROL_POINT_PHASE_OUTPUT_REGISTER_COUNT")]
        public const int HSControlPointPhaseOutputRegisterCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_CONTROL_POINT_REGISTER_COMPONENTS")]
        public const int HSControlPointRegisterComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT")]
        public const int HSControlPointRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_CONTROL_POINT_REGISTER_READS_PER_INST")]
        public const int HSControlPointRegisterReadsPerInst = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_CONTROL_POINT_REGISTER_READ_PORTS")]
        public const int HSControlPointRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D12_HS_FORK_PHASE_INSTANCE_COUNT_UPPER_BOUND")]
        public const uint HSForkPhaseInstanceCountUpperBound = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENTS")]
        public const int HSInputForkInstanceIDRegisterComponents = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT")]
        public const int HSInputForkInstanceIDRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COUNT")]
        public const int HSInputForkInstanceIDRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READS_PER_INST")]
        public const int HSInputForkInstanceIDRegisterReadsPerInst = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READ_PORTS")]
        public const int HSInputForkInstanceIDRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENTS")]
        public const int HSInputJoinInstanceIDRegisterComponents = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT")]
        public const int HSInputJoinInstanceIDRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COUNT")]
        public const int HSInputJoinInstanceIDRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READS_PER_INST")]
        public const int HSInputJoinInstanceIDRegisterReadsPerInst = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READ_PORTS")]
        public const int HSInputJoinInstanceIDRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS")]
        public const int HSInputPrimitiveIDRegisterComponents = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT")]
        public const int HSInputPrimitiveIDRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_INPUT_PRIMITIVE_ID_REGISTER_COUNT")]
        public const int HSInputPrimitiveIDRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST")]
        public const int HSInputPrimitiveIDRegisterReadsPerInst = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS")]
        public const int HSInputPrimitiveIDRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D12_HS_JOIN_PHASE_INSTANCE_COUNT_UPPER_BOUND")]
        public const uint HSJoinPhaseInstanceCountUpperBound = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_OUTPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS")]
        public const int HSOutputControlPointsMaxTotalScalars = unchecked((int) 0xF80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENTS")]
        public const int HSOutputControlPointIDRegisterComponents = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENT_BIT_COUNT")]
        public const int HSOutputControlPointIDRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COUNT")]
        public const int HSOutputControlPointIDRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READS_PER_INST")]
        public const int HSOutputControlPointIDRegisterReadsPerInst = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READ_PORTS")]
        public const int HSOutputControlPointIDRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENTS")]
        public const int HSOutputPatchConstantRegisterComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT")]
        public const int HSOutputPatchConstantRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COUNT")]
        public const int HSOutputPatchConstantRegisterCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST")]
        public const int HSOutputPatchConstantRegisterReadsPerInst = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READ_PORTS")]
        public const int HSOutputPatchConstantRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_HS_OUTPUT_PATCH_CONSTANT_REGISTER_SCALAR_COMPONENTS")]
        public const int HSOutputPatchConstantRegisterScalarComponents = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_IA_DEFAULT_INDEX_BUFFER_OFFSET_IN_BYTES")]
        public const int IADefaultIndexBufferOffsetInBytes = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_IA_DEFAULT_PRIMITIVE_TOPOLOGY")]
        public const int IADefaultPrimitiveTopology = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_IA_DEFAULT_VERTEX_BUFFER_OFFSET_IN_BYTES")]
        public const int IADefaultVertexBufferOffsetInBytes = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_IA_INDEX_INPUT_RESOURCE_SLOT_COUNT")]
        public const int IAIndexInputResourceSlotCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_IA_INSTANCE_ID_BIT_COUNT")]
        public const int IAInstanceIDBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_IA_INTEGER_ARITHMETIC_BIT_COUNT")]
        public const int IAIntegerArithmeticBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_IA_PATCH_MAX_CONTROL_POINT_COUNT")]
        public const int IAPatchMaxControlPointCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_IA_PRIMITIVE_ID_BIT_COUNT")]
        public const int IAPrimitiveIDBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_IA_VERTEX_ID_BIT_COUNT")]
        public const int IAVertexIDBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT")]
        public const int IAVertexInputResourceSlotCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_IA_VERTEX_INPUT_STRUCTURE_ELEMENTS_COMPONENTS")]
        public const int IAVertexInputStructureElementsComponents = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_IA_VERTEX_INPUT_STRUCTURE_ELEMENT_COUNT")]
        public const int IAVertexInputStructureElementCount = unchecked((int) 0x20);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D12_INTEGER_DIVIDE_BY_ZERO_QUOTIENT")]
        public const uint IntegerDivideByZeroQuotient = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D12_INTEGER_DIVIDE_BY_ZERO_REMAINDER")]
        public const uint IntegerDivideByZeroRemainder = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D12_KEEP_RENDER_TARGETS_AND_DEPTH_STENCIL")]
        public const uint KeepRenderTargetsAndDepthStencil = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D12_KEEP_UNORDERED_ACCESS_VIEWS")]
        public const uint KeepUnorderedAccessViews = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_MAJOR_VERSION")]
        public const int MajorVersion = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_MAX_LIVE_STATIC_SAMPLERS")]
        public const int MaxLiveStaticSamplers = unchecked((int) 0x7F0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_MAX_MAXANISOTROPY")]
        public const int MaxMaxanisotropy = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_MAX_MULTISAMPLE_SAMPLE_COUNT")]
        public const int MaxMultisampleSampleCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_MAX_ROOT_COST")]
        public const int MaxRootCost = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_MAX_SHADER_VISIBLE_DESCRIPTOR_HEAP_SIZE_TIER_1")]
        public const int MaxShaderVisibleDescriptorHeapSizeTier1 = unchecked((int) 0xF4240);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_MAX_SHADER_VISIBLE_DESCRIPTOR_HEAP_SIZE_TIER_2")]
        public const int MaxShaderVisibleDescriptorHeapSizeTier2 = unchecked((int) 0xF4240);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_MAX_SHADER_VISIBLE_SAMPLER_HEAP_SIZE")]
        public const int MaxShaderVisibleSamplerHeapSize = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_MAX_TEXTURE_DIMENSION_2_TO_EXP")]
        public const int MaxTextureDimension2ToExp = unchecked((int) 0x11);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_MAX_VIEW_INSTANCE_COUNT")]
        public const int MaxViewInstanceCount = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_MINOR_VERSION")]
        public const int MinorVersion = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_MIN_MAXANISOTROPY")]
        public const int MinMaxanisotropy = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_MIP_LOD_FRACTIONAL_BIT_COUNT")]
        public const int MipLodFractionalBitCount = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_MIP_LOD_RANGE_BIT_COUNT")]
        public const int MipLodRangeBitCount = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_NONSAMPLE_FETCH_OUT_OF_RANGE_ACCESS_RESULT")]
        public const int NonsampleFetchOutOfRangeAccessResult = unchecked((int) 0x0);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D12_OS_RESERVED_REGISTER_SPACE_VALUES_END")]
        public const uint OSReservedRegisterSpaceValuesEnd = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D12_OS_RESERVED_REGISTER_SPACE_VALUES_START")]
        public const uint OSReservedRegisterSpaceValuesStart = unchecked((uint) 0xFFFFFFFFFFFFFFF8);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D12_PACKED_TILE")]
        public const uint PackedTile = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_PIXEL_ADDRESS_RANGE_BIT_COUNT")]
        public const int PixelAddressRangeBitCount = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_PREVIEW_SDK_VERSION")]
        public const int PreviewSdkVersion = unchecked((int) 0x2C9);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_PRE_SCISSOR_PIXEL_ADDRESS_RANGE_BIT_COUNT")]
        public const int PreScissorPixelAddressRangeBitCount = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_PS_CS_UAV_REGISTER_COMPONENTS")]
        public const int PSCSUavRegisterComponents = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_PS_CS_UAV_REGISTER_COUNT")]
        public const int PSCSUavRegisterCount = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_PS_CS_UAV_REGISTER_READS_PER_INST")]
        public const int PSCSUavRegisterReadsPerInst = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_PS_CS_UAV_REGISTER_READ_PORTS")]
        public const int PSCSUavRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D12_PS_FRONTFACING_DEFAULT_VALUE")]
        public const uint PSFrontfacingDefaultValue = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_PS_FRONTFACING_FALSE_VALUE")]
        public const int PSFrontfacingFalseValue = unchecked((int) 0x0);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D12_PS_FRONTFACING_TRUE_VALUE")]
        public const uint PSFrontfacingTrueValue = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_PS_INPUT_REGISTER_COMPONENTS")]
        public const int PSInputRegisterComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_PS_INPUT_REGISTER_COMPONENT_BIT_COUNT")]
        public const int PSInputRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_PS_INPUT_REGISTER_COUNT")]
        public const int PSInputRegisterCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_PS_INPUT_REGISTER_READS_PER_INST")]
        public const int PSInputRegisterReadsPerInst = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_PS_INPUT_REGISTER_READ_PORTS")]
        public const int PSInputRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_PS_OUTPUT_DEPTH_REGISTER_COMPONENTS")]
        public const int PSOutputDepthRegisterComponents = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_PS_OUTPUT_DEPTH_REGISTER_COMPONENT_BIT_COUNT")]
        public const int PSOutputDepthRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_PS_OUTPUT_DEPTH_REGISTER_COUNT")]
        public const int PSOutputDepthRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_PS_OUTPUT_MASK_REGISTER_COMPONENTS")]
        public const int PSOutputMaskRegisterComponents = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_PS_OUTPUT_MASK_REGISTER_COMPONENT_BIT_COUNT")]
        public const int PSOutputMaskRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_PS_OUTPUT_MASK_REGISTER_COUNT")]
        public const int PSOutputMaskRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_PS_OUTPUT_REGISTER_COMPONENTS")]
        public const int PSOutputRegisterComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_PS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT")]
        public const int PSOutputRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_PS_OUTPUT_REGISTER_COUNT")]
        public const int PSOutputRegisterCount = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_RAW_UAV_SRV_BYTE_ALIGNMENT")]
        public const int RawUavSrvByteAlignment = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_RAYTRACING_AABB_BYTE_ALIGNMENT")]
        public const int RaytracingAabbByteAlignment = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BYTE_ALIGNMENT")]
        public const int RaytracingAccelerationStructureByteAlignment = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_RAYTRACING_INSTANCE_DESCS_BYTE_ALIGNMENT")]
        public const int RaytracingInstanceDescsByteAlignment = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_RAYTRACING_MAX_ATTRIBUTE_SIZE_IN_BYTES")]
        public const int RaytracingMaxAttributeSizeInBytes = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_RAYTRACING_MAX_DECLARABLE_TRACE_RECURSION_DEPTH")]
        public const int RaytracingMaxDeclarableTraceRecursionDepth = unchecked((int) 0x1F);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_RAYTRACING_MAX_GEOMETRIES_PER_BOTTOM_LEVEL_ACCELERATION_STRUCTURE")]
        public const int RaytracingMaxGeometriesPerBottomLevelAccelerationStructure = unchecked((int) 0x1000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_RAYTRACING_MAX_INSTANCES_PER_TOP_LEVEL_ACCELERATION_STRUCTURE")]
        public const int RaytracingMaxInstancesPerTopLevelAccelerationStructure = unchecked((int) 0x1000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_RAYTRACING_MAX_PRIMITIVES_PER_BOTTOM_LEVEL_ACCELERATION_STRUCTURE")]
        public const int RaytracingMaxPrimitivesPerBottomLevelAccelerationStructure = unchecked((int) 0x20000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_RAYTRACING_MAX_RAY_GENERATION_SHADER_THREADS")]
        public const int RaytracingMaxRayGenerationShaderThreads = unchecked((int) 0x40000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_RAYTRACING_MAX_SHADER_RECORD_STRIDE")]
        public const int RaytracingMaxShaderRecordStride = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_RAYTRACING_SHADER_RECORD_BYTE_ALIGNMENT")]
        public const int RaytracingShaderRecordByteAlignment = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_RAYTRACING_SHADER_TABLE_BYTE_ALIGNMENT")]
        public const int RaytracingShaderTableByteAlignment = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_RAYTRACING_TRANSFORM3X4_BYTE_ALIGNMENT")]
        public const int RaytracingTransform3X4ByteAlignment = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_REQ_BLEND_OBJECT_COUNT_PER_DEVICE")]
        public const int ReqBlendObjectCountPerDevice = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_REQ_BUFFER_RESOURCE_TEXEL_COUNT_2_TO_EXP")]
        public const int ReqBufferResourceTexelCount2ToExp = unchecked((int) 0x1B);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_REQ_CONSTANT_BUFFER_ELEMENT_COUNT")]
        public const int ReqConstantBufferElementCount = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_REQ_DEPTH_STENCIL_OBJECT_COUNT_PER_DEVICE")]
        public const int ReqDepthStencilObjectCountPerDevice = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_REQ_DRAWINDEXED_INDEX_COUNT_2_TO_EXP")]
        public const int ReqDrawindexedIndexCount2ToExp = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_REQ_DRAW_VERTEX_COUNT_2_TO_EXP")]
        public const int ReqDrawVertexCount2ToExp = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_REQ_FILTERING_HW_ADDRESSABLE_RESOURCE_DIMENSION")]
        public const int ReqFilteringHWAddressableResourceDimension = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_REQ_GS_INVOCATION_32BIT_OUTPUT_COMPONENT_LIMIT")]
        public const int ReqGSInvocation32BitOutputComponentLimit = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_REQ_IMMEDIATE_CONSTANT_BUFFER_ELEMENT_COUNT")]
        public const int ReqImmediateConstantBufferElementCount = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_REQ_MAXANISOTROPY")]
        public const int ReqMaxanisotropy = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_REQ_MIP_LEVELS")]
        public const int ReqMipLevels = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_REQ_MULTI_ELEMENT_STRUCTURE_SIZE_IN_BYTES")]
        public const int ReqMultiElementStructureSizeInBytes = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_REQ_RASTERIZER_OBJECT_COUNT_PER_DEVICE")]
        public const int ReqRasterizerObjectCountPerDevice = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_REQ_RENDER_TO_BUFFER_WINDOW_WIDTH")]
        public const int ReqRenderToBufferWindowWidth = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_A_TERM")]
        public const int ReqResourceSizeInMegabytesExpressionATerm = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_C_TERM")]
        public const int ReqResourceSizeInMegabytesExpressionCTerm = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_REQ_RESOURCE_VIEW_COUNT_PER_DEVICE_2_TO_EXP")]
        public const int ReqResourceViewCountPerDevice2ToExp = unchecked((int) 0x14);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_REQ_SAMPLER_OBJECT_COUNT_PER_DEVICE")]
        public const int ReqSamplerObjectCountPerDevice = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_REQ_SUBRESOURCES")]
        public const int ReqSubresources = unchecked((int) 0x7800);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_REQ_TEXTURE1D_ARRAY_AXIS_DIMENSION")]
        public const int ReqTexture1DArrayAxisDimension = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_REQ_TEXTURE1D_U_DIMENSION")]
        public const int ReqTexture1DUDimension = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_REQ_TEXTURE2D_ARRAY_AXIS_DIMENSION")]
        public const int ReqTexture2DArrayAxisDimension = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_REQ_TEXTURE2D_U_OR_V_DIMENSION")]
        public const int ReqTexture2DUOrVDimension = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_REQ_TEXTURE3D_U_V_OR_W_DIMENSION")]
        public const int ReqTexture3DUVOrWDimension = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_REQ_TEXTURECUBE_DIMENSION")]
        public const int ReqTexturecubeDimension = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_RESINFO_INSTRUCTION_MISSING_COMPONENT_RETVAL")]
        public const int ResinfoInstructionMissingComponentRetval = unchecked((int) 0x0);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D12_RESOURCE_BARRIER_ALL_SUBRESOURCES")]
        public const uint ResourceBarrierAllSubresources = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_RS_SET_SHADING_RATE_COMBINER_COUNT")]
        public const int RSSetShadingRateCombinerCount = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_SDK_VERSION")]
        public const int SdkVersion = unchecked((int) 0x264);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_SHADER_IDENTIFIER_SIZE_IN_BYTES")]
        public const int ShaderIdentifierSizeInBytes = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_SHADER_MAJOR_VERSION")]
        public const int ShaderMajorVersion = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_SHADER_MAX_INSTANCES")]
        public const int ShaderMaxInstances = unchecked((int) 0xFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_SHADER_MAX_INTERFACES")]
        public const int ShaderMaxInterfaces = unchecked((int) 0xFD);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_SHADER_MAX_INTERFACE_CALL_SITES")]
        public const int ShaderMaxInterfaceCallSites = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_SHADER_MAX_TYPES")]
        public const int ShaderMaxTypes = unchecked((int) 0xFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_SHADER_MINOR_VERSION")]
        public const int ShaderMinorVersion = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_SHIFT_INSTRUCTION_PAD_VALUE")]
        public const int ShiftInstructionPadValue = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_SHIFT_INSTRUCTION_SHIFT_VALUE_BIT_COUNT")]
        public const int ShiftInstructionShiftValueBitCount = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_SIMULTANEOUS_RENDER_TARGET_COUNT")]
        public const int SimultaneousRenderTargetCount = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_SMALL_MSAA_RESOURCE_PLACEMENT_ALIGNMENT")]
        public const int SmallMsaaResourcePlacementAlignment = unchecked((int) 0x10000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_SMALL_RESOURCE_PLACEMENT_ALIGNMENT")]
        public const int SmallResourcePlacementAlignment = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_SO_BUFFER_MAX_STRIDE_IN_BYTES")]
        public const int SOBufferMaxStrideInBytes = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_SO_BUFFER_MAX_WRITE_WINDOW_IN_BYTES")]
        public const int SOBufferMaxWriteWindowInBytes = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_SO_BUFFER_SLOT_COUNT")]
        public const int SOBufferSlotCount = unchecked((int) 0x4);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D12_SO_DDI_REGISTER_INDEX_DENOTING_GAP")]
        public const uint SODdiRegisterIndexDenotingGap = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D12_SO_NO_RASTERIZED_STREAM")]
        public const uint SONoRasterizedStream = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_SO_OUTPUT_COMPONENT_COUNT")]
        public const int SOOutputComponentCount = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_SO_STREAM_COUNT")]
        public const int SOStreamCount = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_SPEC_DATE_DAY")]
        public const int SpecDateDay = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_SPEC_DATE_MONTH")]
        public const int SpecDateMonth = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_SPEC_DATE_YEAR")]
        public const int SpecDateYear = unchecked((int) 0x7DE);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_STANDARD_COMPONENT_BIT_COUNT")]
        public const int StandardComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_STANDARD_COMPONENT_BIT_COUNT_DOUBLED")]
        public const int StandardComponentBitCountDoubled = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_STANDARD_MAXIMUM_ELEMENT_ALIGNMENT_BYTE_MULTIPLE")]
        public const int StandardMaximumElementAlignmentByteMultiple = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_STANDARD_PIXEL_COMPONENT_COUNT")]
        public const int StandardPixelComponentCount = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_STANDARD_PIXEL_ELEMENT_COUNT")]
        public const int StandardPixelElementCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_STANDARD_VECTOR_SIZE")]
        public const int StandardVectorSize = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_STANDARD_VERTEX_ELEMENT_COUNT")]
        public const int StandardVertexElementCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_STANDARD_VERTEX_TOTAL_COMPONENT_COUNT")]
        public const int StandardVertexTotalComponentCount = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_SUBPIXEL_FRACTIONAL_BIT_COUNT")]
        public const int SubpixelFractionalBitCount = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_SUBTEXEL_FRACTIONAL_BIT_COUNT")]
        public const int SubtexelFractionalBitCount = unchecked((int) 0x8);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D12_SYSTEM_RESERVED_REGISTER_SPACE_VALUES_END")]
        public const uint SystemReservedRegisterSpaceValuesEnd = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D12_SYSTEM_RESERVED_REGISTER_SPACE_VALUES_START")]
        public const uint SystemReservedRegisterSpaceValuesStart = unchecked((uint) 0xFFFFFFFFFFFFFFF0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_TESSELLATOR_MAX_EVEN_TESSELLATION_FACTOR")]
        public const int TessellatorMaxEvenTessellationFactor = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_TESSELLATOR_MAX_ISOLINE_DENSITY_TESSELLATION_FACTOR")]
        public const int TessellatorMaxIsolineDensityTessellationFactor = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_TESSELLATOR_MAX_ODD_TESSELLATION_FACTOR")]
        public const int TessellatorMaxOddTessellationFactor = unchecked((int) 0x3F);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_TESSELLATOR_MAX_TESSELLATION_FACTOR")]
        public const int TessellatorMaxTessellationFactor = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_TESSELLATOR_MIN_EVEN_TESSELLATION_FACTOR")]
        public const int TessellatorMinEvenTessellationFactor = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_TESSELLATOR_MIN_ISOLINE_DENSITY_TESSELLATION_FACTOR")]
        public const int TessellatorMinIsolineDensityTessellationFactor = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_TESSELLATOR_MIN_ODD_TESSELLATION_FACTOR")]
        public const int TessellatorMinOddTessellationFactor = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_TEXEL_ADDRESS_RANGE_BIT_COUNT")]
        public const int TexelAddressRangeBitCount = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_TEXTURE_DATA_PITCH_ALIGNMENT")]
        public const int TextureDataPitchAlignment = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_TEXTURE_DATA_PLACEMENT_ALIGNMENT")]
        public const int TextureDataPlacementAlignment = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_TILED_RESOURCE_TILE_SIZE_IN_BYTES")]
        public const int TiledResourceTileSizeInBytes = unchecked((int) 0x10000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_TRACKED_WORKLOAD_MAX_INSTANCES")]
        public const int TrackedWorkloadMaxInstances = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_UAV_COUNTER_PLACEMENT_ALIGNMENT")]
        public const int UavCounterPlacementAlignment = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_UAV_SLOT_COUNT")]
        public const int UavSlotCount = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_UNBOUND_MEMORY_ACCESS_RESULT")]
        public const int UnboundMemoryAccessResult = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_VIDEO_DECODE_MAX_ARGUMENTS")]
        public const int VideoDecodeMaxArguments = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_VIDEO_DECODE_MAX_HISTOGRAM_COMPONENTS")]
        public const int VideoDecodeMaxHistogramComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_VIDEO_DECODE_MIN_BITSTREAM_OFFSET_ALIGNMENT")]
        public const int VideoDecodeMinBitstreamOffsetAlignment = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_VIDEO_DECODE_MIN_HISTOGRAM_OFFSET_ALIGNMENT")]
        public const int VideoDecodeMinHistogramOffsetAlignment = unchecked((int) 0x100);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D12_VIDEO_DECODE_STATUS_MACROBLOCKS_AFFECTED_UNKNOWN")]
        public const uint VideoDecodeStatusMacroblocksAffectedUnknown = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_INVALID_DPB_RESOURCE_INDEX")]
        public const int VideoEncoderAV1InvalidDpbResourceIndex = unchecked((int) 0xFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_MAX_TILE_COLS")]
        public const int VideoEncoderAV1MaxTileCols = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_MAX_TILE_ROWS")]
        public const int VideoEncoderAV1MaxTileRows = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SUPERRES_DENOM_MIN")]
        public const int VideoEncoderAV1SuperresDenomMin = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_SUPERRES_NUM")]
        public const int VideoEncoderAV1SuperresNum = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_MAX_FILTERS")]
        public const int VideoProcessMaxFilters = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_STEREO_VIEWS")]
        public const int VideoProcessStereoViews = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_VIEWPORT_AND_SCISSORRECT_MAX_INDEX")]
        public const int ViewportAndScissorrectMaxIndex = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE")]
        public const int ViewportAndScissorrectObjectCountPerPipeline = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_VIEWPORT_BOUNDS_MAX")]
        public const int ViewportBoundsMax = unchecked((int) 0x7FFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_VS_INPUT_REGISTER_COMPONENTS")]
        public const int VSInputRegisterComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_VS_INPUT_REGISTER_COMPONENT_BIT_COUNT")]
        public const int VSInputRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_VS_INPUT_REGISTER_COUNT")]
        public const int VSInputRegisterCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_VS_INPUT_REGISTER_READS_PER_INST")]
        public const int VSInputRegisterReadsPerInst = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_VS_INPUT_REGISTER_READ_PORTS")]
        public const int VSInputRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_VS_OUTPUT_REGISTER_COMPONENTS")]
        public const int VSOutputRegisterComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_VS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT")]
        public const int VSOutputRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_VS_OUTPUT_REGISTER_COUNT")]
        public const int VSOutputRegisterCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_WHQL_CONTEXT_COUNT_FOR_RESOURCE_LIMIT")]
        public const int WhqlContextCountForResourceLimit = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_WHQL_DRAWINDEXED_INDEX_COUNT_2_TO_EXP")]
        public const int WhqlDrawindexedIndexCount2ToExp = unchecked((int) 0x19);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_WHQL_DRAW_VERTEX_COUNT_2_TO_EXP")]
        public const int WhqlDrawVertexCount2ToExp = unchecked((int) 0x19);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_WORK_GRAPHS_MAX_NODE_DEPTH")]
        public const int WorkGraphsMaxNodeDepth = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_SHADER_COMPONENT_MAPPING_MASK")]
        public const int ShaderComponentMappingMask = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_SHADER_COMPONENT_MAPPING_SHIFT")]
        public const int ShaderComponentMappingShift = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_FILTER_REDUCTION_TYPE_MASK")]
        public const int FilterReductionTypeMask = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_FILTER_REDUCTION_TYPE_SHIFT")]
        public const int FilterReductionTypeShift = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_FILTER_TYPE_MASK")]
        public const int FilterTypeMask = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_MIN_FILTER_SHIFT")]
        public const int MinFilterShift = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_MAG_FILTER_SHIFT")]
        public const int MagFilterShift = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_MIP_FILTER_SHIFT")]
        public const int MipFilterShift = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_ANISOTROPIC_FILTERING_BIT")]
        public const int AnisotropicFilteringBit = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_SHADING_RATE_X_AXIS_SHIFT")]
        public const int ShadingRateXAxisShift = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D12_SHADING_RATE_VALID_MASK")]
        public const int ShadingRateValidMask = unchecked((int) 0x3);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4322, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeRootSignature", Convention = CallingConvention.StdCall)]
        public unsafe partial int SerializeRootSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] RootSignatureDesc* pRootSignature, D3DRootSignatureVersion Version, Silk.NET.Core.Native.ID3D10Blob** ppBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4322, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeRootSignature", Convention = CallingConvention.StdCall)]
        public unsafe partial int SerializeRootSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] RootSignatureDesc* pRootSignature, D3DRootSignatureVersion Version, Silk.NET.Core.Native.ID3D10Blob** ppBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4322, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeRootSignature", Convention = CallingConvention.StdCall)]
        public unsafe partial int SerializeRootSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] RootSignatureDesc* pRootSignature, D3DRootSignatureVersion Version, ref Silk.NET.Core.Native.ID3D10Blob* ppBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4322, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeRootSignature", Convention = CallingConvention.StdCall)]
        public unsafe partial int SerializeRootSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] RootSignatureDesc* pRootSignature, D3DRootSignatureVersion Version, ref Silk.NET.Core.Native.ID3D10Blob* ppBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4322, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeRootSignature", Convention = CallingConvention.StdCall)]
        public unsafe partial int SerializeRootSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RootSignatureDesc pRootSignature, D3DRootSignatureVersion Version, Silk.NET.Core.Native.ID3D10Blob** ppBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4322, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeRootSignature", Convention = CallingConvention.StdCall)]
        public unsafe partial int SerializeRootSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RootSignatureDesc pRootSignature, D3DRootSignatureVersion Version, Silk.NET.Core.Native.ID3D10Blob** ppBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4322, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeRootSignature", Convention = CallingConvention.StdCall)]
        public unsafe partial int SerializeRootSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RootSignatureDesc pRootSignature, D3DRootSignatureVersion Version, ref Silk.NET.Core.Native.ID3D10Blob* ppBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4322, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeRootSignature", Convention = CallingConvention.StdCall)]
        public unsafe partial int SerializeRootSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RootSignatureDesc pRootSignature, D3DRootSignatureVersion Version, ref Silk.NET.Core.Native.ID3D10Blob* ppBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4334, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateRootSignatureDeserializer", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateRootSignatureDeserializer([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSizeInBytes, Guid* pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4334, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateRootSignatureDeserializer", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateRootSignatureDeserializer([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSizeInBytes, Guid* pRootSignatureDeserializerInterface, ref void* ppRootSignatureDeserializer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4334, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateRootSignatureDeserializer", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateRootSignatureDeserializer([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSizeInBytes, ref Guid pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4334, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateRootSignatureDeserializer", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateRootSignatureDeserializer([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSizeInBytes, ref Guid pRootSignatureDeserializerInterface, ref void* ppRootSignatureDeserializer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4334, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateRootSignatureDeserializer", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateRootSignatureDeserializer<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, nuint SrcDataSizeInBytes, Guid* pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4334, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateRootSignatureDeserializer", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateRootSignatureDeserializer<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, nuint SrcDataSizeInBytes, Guid* pRootSignatureDeserializerInterface, ref void* ppRootSignatureDeserializer) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4334, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateRootSignatureDeserializer", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateRootSignatureDeserializer<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, nuint SrcDataSizeInBytes, ref Guid pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4334, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateRootSignatureDeserializer", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateRootSignatureDeserializer<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, nuint SrcDataSizeInBytes, ref Guid pRootSignatureDeserializerInterface, ref void* ppRootSignatureDeserializer) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4345, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeVersionedRootSignature", Convention = CallingConvention.StdCall)]
        public unsafe partial int SerializeVersionedRootSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] VersionedRootSignatureDesc* pRootSignature, Silk.NET.Core.Native.ID3D10Blob** ppBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4345, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeVersionedRootSignature", Convention = CallingConvention.StdCall)]
        public unsafe partial int SerializeVersionedRootSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] VersionedRootSignatureDesc* pRootSignature, Silk.NET.Core.Native.ID3D10Blob** ppBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4345, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeVersionedRootSignature", Convention = CallingConvention.StdCall)]
        public unsafe partial int SerializeVersionedRootSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] VersionedRootSignatureDesc* pRootSignature, ref Silk.NET.Core.Native.ID3D10Blob* ppBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4345, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeVersionedRootSignature", Convention = CallingConvention.StdCall)]
        public unsafe partial int SerializeVersionedRootSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] VersionedRootSignatureDesc* pRootSignature, ref Silk.NET.Core.Native.ID3D10Blob* ppBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4345, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeVersionedRootSignature", Convention = CallingConvention.StdCall)]
        public unsafe partial int SerializeVersionedRootSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VersionedRootSignatureDesc pRootSignature, Silk.NET.Core.Native.ID3D10Blob** ppBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4345, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeVersionedRootSignature", Convention = CallingConvention.StdCall)]
        public unsafe partial int SerializeVersionedRootSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VersionedRootSignatureDesc pRootSignature, Silk.NET.Core.Native.ID3D10Blob** ppBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4345, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeVersionedRootSignature", Convention = CallingConvention.StdCall)]
        public unsafe partial int SerializeVersionedRootSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VersionedRootSignatureDesc pRootSignature, ref Silk.NET.Core.Native.ID3D10Blob* ppBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4345, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12SerializeVersionedRootSignature", Convention = CallingConvention.StdCall)]
        public unsafe partial int SerializeVersionedRootSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VersionedRootSignatureDesc pRootSignature, ref Silk.NET.Core.Native.ID3D10Blob* ppBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4356, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateVersionedRootSignatureDeserializer", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateVersionedRootSignatureDeserializer([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSizeInBytes, Guid* pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4356, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateVersionedRootSignatureDeserializer", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateVersionedRootSignatureDeserializer([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSizeInBytes, Guid* pRootSignatureDeserializerInterface, ref void* ppRootSignatureDeserializer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4356, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateVersionedRootSignatureDeserializer", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateVersionedRootSignatureDeserializer([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSizeInBytes, ref Guid pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4356, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateVersionedRootSignatureDeserializer", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateVersionedRootSignatureDeserializer([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSizeInBytes, ref Guid pRootSignatureDeserializerInterface, ref void* ppRootSignatureDeserializer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4356, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateVersionedRootSignatureDeserializer", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateVersionedRootSignatureDeserializer<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, nuint SrcDataSizeInBytes, Guid* pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4356, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateVersionedRootSignatureDeserializer", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateVersionedRootSignatureDeserializer<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, nuint SrcDataSizeInBytes, Guid* pRootSignatureDeserializerInterface, ref void* ppRootSignatureDeserializer) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4356, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateVersionedRootSignatureDeserializer", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateVersionedRootSignatureDeserializer<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, nuint SrcDataSizeInBytes, ref Guid pRootSignatureDeserializerInterface, void** ppRootSignatureDeserializer) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4356, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateVersionedRootSignatureDeserializer", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateVersionedRootSignatureDeserializer<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, nuint SrcDataSizeInBytes, ref Guid pRootSignatureDeserializerInterface, ref void* ppRootSignatureDeserializer) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28655, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(Silk.NET.Core.Native.IUnknown* pAdapter, Silk.NET.Core.Native.D3DFeatureLevel MinimumFeatureLevel, Guid* riid, void** ppDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28655, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(Silk.NET.Core.Native.IUnknown* pAdapter, Silk.NET.Core.Native.D3DFeatureLevel MinimumFeatureLevel, Guid* riid, ref void* ppDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28655, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(Silk.NET.Core.Native.IUnknown* pAdapter, Silk.NET.Core.Native.D3DFeatureLevel MinimumFeatureLevel, ref Guid riid, void** ppDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28655, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(Silk.NET.Core.Native.IUnknown* pAdapter, Silk.NET.Core.Native.D3DFeatureLevel MinimumFeatureLevel, ref Guid riid, ref void* ppDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28655, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(ref Silk.NET.Core.Native.IUnknown pAdapter, Silk.NET.Core.Native.D3DFeatureLevel MinimumFeatureLevel, Guid* riid, void** ppDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28655, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(ref Silk.NET.Core.Native.IUnknown pAdapter, Silk.NET.Core.Native.D3DFeatureLevel MinimumFeatureLevel, Guid* riid, ref void* ppDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28655, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(ref Silk.NET.Core.Native.IUnknown pAdapter, Silk.NET.Core.Native.D3DFeatureLevel MinimumFeatureLevel, ref Guid riid, void** ppDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28655, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(ref Silk.NET.Core.Native.IUnknown pAdapter, Silk.NET.Core.Native.D3DFeatureLevel MinimumFeatureLevel, ref Guid riid, ref void* ppDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28664, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12GetDebugInterface", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetDebugInterface(Guid* riid, void** ppvDebug);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28664, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12GetDebugInterface", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetDebugInterface(Guid* riid, ref void* ppvDebug);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28664, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12GetDebugInterface", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetDebugInterface(ref Guid riid, void** ppvDebug);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28664, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12GetDebugInterface", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetDebugInterface(ref Guid riid, ref void* ppvDebug);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28690, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12EnableExperimentalFeatures", Convention = CallingConvention.StdCall)]
        public unsafe partial int EnableExperimentalFeatures(uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pIIDs, void* pConfigurationStructs, uint* pConfigurationStructSizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28690, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12EnableExperimentalFeatures", Convention = CallingConvention.StdCall)]
        public unsafe partial int EnableExperimentalFeatures(uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pIIDs, void* pConfigurationStructs, ref uint pConfigurationStructSizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28690, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12EnableExperimentalFeatures", Convention = CallingConvention.StdCall)]
        public unsafe partial int EnableExperimentalFeatures<T0>(uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pIIDs, ref T0 pConfigurationStructs, uint* pConfigurationStructSizes) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28690, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12EnableExperimentalFeatures", Convention = CallingConvention.StdCall)]
        public unsafe partial int EnableExperimentalFeatures<T0>(uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pIIDs, ref T0 pConfigurationStructs, ref uint pConfigurationStructSizes) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28690, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12EnableExperimentalFeatures", Convention = CallingConvention.StdCall)]
        public unsafe partial int EnableExperimentalFeatures(uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pIIDs, void* pConfigurationStructs, uint* pConfigurationStructSizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28690, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12EnableExperimentalFeatures", Convention = CallingConvention.StdCall)]
        public unsafe partial int EnableExperimentalFeatures(uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pIIDs, void* pConfigurationStructs, ref uint pConfigurationStructSizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28690, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12EnableExperimentalFeatures", Convention = CallingConvention.StdCall)]
        public unsafe partial int EnableExperimentalFeatures<T0>(uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pIIDs, ref T0 pConfigurationStructs, uint* pConfigurationStructSizes) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28690, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12EnableExperimentalFeatures", Convention = CallingConvention.StdCall)]
        public partial int EnableExperimentalFeatures<T0>(uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pIIDs, ref T0 pConfigurationStructs, ref uint pConfigurationStructSizes) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28740, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12GetInterface", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetInterface(Guid* rclsid, Guid* riid, void** ppvDebug);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28740, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12GetInterface", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetInterface(Guid* rclsid, Guid* riid, ref void* ppvDebug);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28740, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12GetInterface", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetInterface(Guid* rclsid, ref Guid riid, void** ppvDebug);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28740, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12GetInterface", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetInterface(Guid* rclsid, ref Guid riid, ref void* ppvDebug);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28740, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12GetInterface", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetInterface(ref Guid rclsid, Guid* riid, void** ppvDebug);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28740, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12GetInterface", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetInterface(ref Guid rclsid, Guid* riid, ref void* ppvDebug);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28740, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12GetInterface", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetInterface(ref Guid rclsid, ref Guid riid, void** ppvDebug);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28740, Column 16 in d3d12.h")]
        [NativeApi(EntryPoint = "D3D12GetInterface", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetInterface(ref Guid rclsid, ref Guid riid, ref void* ppvDebug);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4322, Column 16 in d3d12.h")]
        public unsafe int SerializeRootSignature<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] RootSignatureDesc* pRootSignature, D3DRootSignatureVersion Version, ref ComPtr<TI0> ppBlob, ref ComPtr<TI1> ppErrorBlob) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return SerializeRootSignature(pRootSignature, Version, (Silk.NET.Core.Native.ID3D10Blob**) ppBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBlob.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4322, Column 16 in d3d12.h")]
        public unsafe int SerializeRootSignature<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] RootSignatureDesc* pRootSignature, D3DRootSignatureVersion Version, ref ComPtr<TI0> ppBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBlob) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return SerializeRootSignature(pRootSignature, Version, (Silk.NET.Core.Native.ID3D10Blob**) ppBlob.GetAddressOf(), ref ppErrorBlob);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4322, Column 16 in d3d12.h")]
        public unsafe int SerializeRootSignature<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] RootSignatureDesc* pRootSignature, D3DRootSignatureVersion Version, ref Silk.NET.Core.Native.ID3D10Blob* ppBlob, ref ComPtr<TI0> ppErrorBlob) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return SerializeRootSignature(pRootSignature, Version, ref ppBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBlob.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4322, Column 16 in d3d12.h")]
        public unsafe int SerializeRootSignature<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RootSignatureDesc pRootSignature, D3DRootSignatureVersion Version, ref ComPtr<TI0> ppBlob, ref ComPtr<TI1> ppErrorBlob) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return SerializeRootSignature(in pRootSignature, Version, (Silk.NET.Core.Native.ID3D10Blob**) ppBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBlob.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4322, Column 16 in d3d12.h")]
        public unsafe int SerializeRootSignature<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RootSignatureDesc pRootSignature, D3DRootSignatureVersion Version, ref ComPtr<TI0> ppBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBlob) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return SerializeRootSignature(in pRootSignature, Version, (Silk.NET.Core.Native.ID3D10Blob**) ppBlob.GetAddressOf(), ref ppErrorBlob);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4322, Column 16 in d3d12.h")]
        public unsafe int SerializeRootSignature<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RootSignatureDesc pRootSignature, D3DRootSignatureVersion Version, ref Silk.NET.Core.Native.ID3D10Blob* ppBlob, ref ComPtr<TI0> ppErrorBlob) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return SerializeRootSignature(in pRootSignature, Version, ref ppBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBlob.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4334, Column 16 in d3d12.h")]
        public unsafe int CreateRootSignatureDeserializer<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSizeInBytes, out ComPtr<TI0> ppRootSignatureDeserializer) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // ComPtrOverloader
            ppRootSignatureDeserializer = default;
            return CreateRootSignatureDeserializer(pSrcData, SrcDataSizeInBytes, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppRootSignatureDeserializer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4334, Column 16 in d3d12.h")]
        public unsafe int CreateRootSignatureDeserializer<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, nuint SrcDataSizeInBytes, out ComPtr<TI0> ppRootSignatureDeserializer) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            // ComPtrOverloader
            ppRootSignatureDeserializer = default;
            return CreateRootSignatureDeserializer(in pSrcData, SrcDataSizeInBytes, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppRootSignatureDeserializer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4345, Column 16 in d3d12.h")]
        public unsafe int SerializeVersionedRootSignature<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VersionedRootSignatureDesc* pRootSignature, ref ComPtr<TI0> ppBlob, ref ComPtr<TI1> ppErrorBlob) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return SerializeVersionedRootSignature(pRootSignature, (Silk.NET.Core.Native.ID3D10Blob**) ppBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBlob.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4345, Column 16 in d3d12.h")]
        public unsafe int SerializeVersionedRootSignature<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VersionedRootSignatureDesc* pRootSignature, ref ComPtr<TI0> ppBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBlob) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return SerializeVersionedRootSignature(pRootSignature, (Silk.NET.Core.Native.ID3D10Blob**) ppBlob.GetAddressOf(), ref ppErrorBlob);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4345, Column 16 in d3d12.h")]
        public unsafe int SerializeVersionedRootSignature<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VersionedRootSignatureDesc* pRootSignature, ref Silk.NET.Core.Native.ID3D10Blob* ppBlob, ref ComPtr<TI0> ppErrorBlob) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return SerializeVersionedRootSignature(pRootSignature, ref ppBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBlob.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4345, Column 16 in d3d12.h")]
        public unsafe int SerializeVersionedRootSignature<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VersionedRootSignatureDesc pRootSignature, ref ComPtr<TI0> ppBlob, ref ComPtr<TI1> ppErrorBlob) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return SerializeVersionedRootSignature(in pRootSignature, (Silk.NET.Core.Native.ID3D10Blob**) ppBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBlob.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4345, Column 16 in d3d12.h")]
        public unsafe int SerializeVersionedRootSignature<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VersionedRootSignatureDesc pRootSignature, ref ComPtr<TI0> ppBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBlob) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return SerializeVersionedRootSignature(in pRootSignature, (Silk.NET.Core.Native.ID3D10Blob**) ppBlob.GetAddressOf(), ref ppErrorBlob);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4345, Column 16 in d3d12.h")]
        public unsafe int SerializeVersionedRootSignature<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VersionedRootSignatureDesc pRootSignature, ref Silk.NET.Core.Native.ID3D10Blob* ppBlob, ref ComPtr<TI0> ppErrorBlob) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return SerializeVersionedRootSignature(in pRootSignature, ref ppBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBlob.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4356, Column 16 in d3d12.h")]
        public unsafe int CreateVersionedRootSignatureDeserializer<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSizeInBytes, out ComPtr<TI0> ppRootSignatureDeserializer) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // ComPtrOverloader
            ppRootSignatureDeserializer = default;
            return CreateVersionedRootSignatureDeserializer(pSrcData, SrcDataSizeInBytes, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppRootSignatureDeserializer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4356, Column 16 in d3d12.h")]
        public unsafe int CreateVersionedRootSignatureDeserializer<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, nuint SrcDataSizeInBytes, out ComPtr<TI0> ppRootSignatureDeserializer) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            // ComPtrOverloader
            ppRootSignatureDeserializer = default;
            return CreateVersionedRootSignatureDeserializer(in pSrcData, SrcDataSizeInBytes, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppRootSignatureDeserializer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28655, Column 16 in d3d12.h")]
        public unsafe int CreateDevice<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DFeatureLevel MinimumFeatureLevel, out ComPtr<TI1> ppDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            // ComPtrOverloader
            ppDevice = default;
            return CreateDevice((Silk.NET.Core.Native.IUnknown*) pAdapter.Handle, MinimumFeatureLevel, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28655, Column 16 in d3d12.h")]
        public unsafe int CreateDevice<TI0>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DFeatureLevel MinimumFeatureLevel, Guid* riid, ref void* ppDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDevice((Silk.NET.Core.Native.IUnknown*) pAdapter.Handle, MinimumFeatureLevel, riid, ref ppDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28655, Column 16 in d3d12.h")]
        public unsafe int CreateDevice<TI0>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DFeatureLevel MinimumFeatureLevel, ref Guid riid, void** ppDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDevice((Silk.NET.Core.Native.IUnknown*) pAdapter.Handle, MinimumFeatureLevel, ref riid, ppDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28655, Column 16 in d3d12.h")]
        public unsafe int CreateDevice<TI0>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DFeatureLevel MinimumFeatureLevel, ref Guid riid, ref void* ppDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDevice((Silk.NET.Core.Native.IUnknown*) pAdapter.Handle, MinimumFeatureLevel, ref riid, ref ppDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28655, Column 16 in d3d12.h")]
        public unsafe int CreateDevice<TI0>(ref Silk.NET.Core.Native.IUnknown pAdapter, Silk.NET.Core.Native.D3DFeatureLevel MinimumFeatureLevel, out ComPtr<TI0> ppDevice) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // ComPtrOverloader
            ppDevice = default;
            return CreateDevice(ref pAdapter, MinimumFeatureLevel, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28664, Column 16 in d3d12.h")]
        public unsafe int GetDebugInterface<TI0>(out ComPtr<TI0> ppvDebug) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // ComPtrOverloader
            ppvDebug = default;
            return GetDebugInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDebug.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28740, Column 16 in d3d12.h")]
        public unsafe int GetInterface<TI0>(Guid* rclsid, out ComPtr<TI0> ppvDebug) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // ComPtrOverloader
            ppvDebug = default;
            return GetInterface(rclsid, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDebug.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28740, Column 16 in d3d12.h")]
        public unsafe int GetInterface<TI0>(ref Guid rclsid, out ComPtr<TI0> ppvDebug) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // ComPtrOverloader
            ppvDebug = default;
            return GetInterface(ref rclsid, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDebug.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4334, Column 16 in d3d12.h")]
        public unsafe ComPtr<TI0> CreateRootSignatureDeserializer<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSizeInBytes) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(CreateRootSignatureDeserializer(pSrcData, SrcDataSizeInBytes, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4334, Column 16 in d3d12.h")]
        public unsafe ComPtr<TI0> CreateRootSignatureDeserializer<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, nuint SrcDataSizeInBytes) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(CreateRootSignatureDeserializer(in pSrcData, SrcDataSizeInBytes, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4356, Column 16 in d3d12.h")]
        public unsafe ComPtr<TI0> CreateVersionedRootSignatureDeserializer<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSizeInBytes) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(CreateVersionedRootSignatureDeserializer(pSrcData, SrcDataSizeInBytes, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4356, Column 16 in d3d12.h")]
        public unsafe ComPtr<TI0> CreateVersionedRootSignatureDeserializer<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, nuint SrcDataSizeInBytes) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(CreateVersionedRootSignatureDeserializer(in pSrcData, SrcDataSizeInBytes, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28655, Column 16 in d3d12.h")]
        public unsafe ComPtr<TI1> CreateDevice<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DFeatureLevel MinimumFeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(CreateDevice(pAdapter, MinimumFeatureLevel, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28655, Column 16 in d3d12.h")]
        public unsafe ComPtr<TI0> CreateDevice<TI0>(ref Silk.NET.Core.Native.IUnknown pAdapter, Silk.NET.Core.Native.D3DFeatureLevel MinimumFeatureLevel) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(CreateDevice(ref pAdapter, MinimumFeatureLevel, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28664, Column 16 in d3d12.h")]
        public unsafe ComPtr<TI0> GetDebugInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(GetDebugInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28740, Column 16 in d3d12.h")]
        public unsafe ComPtr<TI0> GetInterface<TI0>(Guid* rclsid) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(GetInterface(rclsid, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 28740, Column 16 in d3d12.h")]
        public unsafe ComPtr<TI0> GetInterface<TI0>(ref Guid rclsid) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(GetInterface(ref rclsid, out ComPtr<TI0> silkRet));
            return silkRet;
        }


        public D3D12(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

