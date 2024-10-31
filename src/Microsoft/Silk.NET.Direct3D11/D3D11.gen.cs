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

namespace Silk.NET.Direct3D11
{
    public unsafe partial class D3D11 : NativeAPI
    {
        [NativeName("Type", "")]
        [NativeName("Name", "InterfaceName_Windows_Graphics_DirectX_Direct3D11_IDirect3DDevice")]
        public const string InterfaceNameWindowsGraphicsDirectXDirect3D11IDirect3DDevice = unchecked((string) "Windows.Graphics.DirectX.Direct3D11.IDirect3DDevice");
        [NativeName("Type", "")]
        [NativeName("Name", "InterfaceName_Windows_Graphics_DirectX_Direct3D11_IDirect3DSurface")]
        public const string InterfaceNameWindowsGraphicsDirectXDirect3D11IDirect3DSurface = unchecked((string) "Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface");
        [NativeName("Type", "int")]
        [NativeName("Name", "__REQUIRED_RPCNDR_H_VERSION__")]
        public const int RequiredRpcndrHVersion = unchecked((int) 0x1F4);
        [NativeName("Type", "int")]
        [NativeName("Name", "__REQUIRED_RPCSAL_H_VERSION__")]
        public const int RequiredRpcsalHVersion = unchecked((int) 0x64);
        [NativeName("Type", "")]
        [NativeName("Name", "CHECK_NS_PREFIX_STATE")]
        public const string CheckNSPrefixState = unchecked((string) "always");
        [NativeName("Type", "int")]
        [NativeName("Name", "WINDOWS_FOUNDATION_FOUNDATIONCONTRACT_VERSION")]
        public const int WindowsFoundationFoundationcontractVersion = unchecked((int) 0x40000);
        [NativeName("Type", "int")]
        [NativeName("Name", "WINDOWS_FOUNDATION_UNIVERSALAPICONTRACT_VERSION")]
        public const int WindowsFoundationUniversalapicontractVersion = unchecked((int) 0x130000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_SDK_LAYERS_VERSION")]
        public const int SdkLayersVersion = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DEBUG_FEATURE_FLUSH_PER_RENDER_OP")]
        public const int DebugFeatureFlushPerRenderOp = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DEBUG_FEATURE_FINISH_PER_RENDER_OP")]
        public const int DebugFeatureFinishPerRenderOp = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DEBUG_FEATURE_PRESENT_PER_RENDER_OP")]
        public const int DebugFeaturePresentPerRenderOp = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DEBUG_FEATURE_ALWAYS_DISCARD_OFFERED_RESOURCE")]
        public const int DebugFeatureAlwaysDiscardOfferedResource = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DEBUG_FEATURE_NEVER_DISCARD_OFFERED_RESOURCE")]
        public const int DebugFeatureNeverDiscardOfferedResource = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DEBUG_FEATURE_AVOID_BEHAVIOR_CHANGING_DEBUG_AIDS")]
        public const int DebugFeatureAvoidBehaviorChangingDebugAids = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DEBUG_FEATURE_DISABLE_TILED_RESOURCE_MAPPING_TRACKING_AND_VALIDATION")]
        public const int DebugFeatureDisableTiledResourceMappingTrackingAndValidation = unchecked((int) 0x80);
        [NativeName("Type", "")]
        [NativeName("Name", "D3D11_REGKEY_PATH")]
        public const string RegkeyPath = unchecked((string) "Software\\Microsoft\\Direct3D");
        [NativeName("Type", "")]
        [NativeName("Name", "D3D11_MUTE_DEBUG_OUTPUT")]
        public const string MuteDebugOutput = unchecked((string) "MuteDebugOutput");
        [NativeName("Type", "")]
        [NativeName("Name", "D3D11_ENABLE_BREAK_ON_MESSAGE")]
        public const string EnableBreakOnMessage = unchecked((string) "EnableBreakOnMessage");
        [NativeName("Type", "")]
        [NativeName("Name", "D3D11_INFOQUEUE_STORAGE_FILTER_OVERRIDE")]
        public const string InfoqueueStorageFilterOverride = unchecked((string) "InfoQueueStorageFilterOverride");
        [NativeName("Type", "")]
        [NativeName("Name", "D3D11_MUTE_CATEGORY")]
        public const string MuteCategory = unchecked((string) "Mute_CATEGORY_%s");
        [NativeName("Type", "")]
        [NativeName("Name", "D3D11_MUTE_SEVERITY")]
        public const string MuteSeverity = unchecked((string) "Mute_SEVERITY_%s");
        [NativeName("Type", "")]
        [NativeName("Name", "D3D11_MUTE_ID_STRING")]
        public const string MuteIDString = unchecked((string) "Mute_ID_%s");
        [NativeName("Type", "")]
        [NativeName("Name", "D3D11_MUTE_ID_DECIMAL")]
        public const string MuteIDDecimal = unchecked((string) "Mute_ID_%d");
        [NativeName("Type", "")]
        [NativeName("Name", "D3D11_UNMUTE_SEVERITY_INFO")]
        public const string UnmuteSeverityInfo = unchecked((string) "Unmute_SEVERITY_INFO");
        [NativeName("Type", "")]
        [NativeName("Name", "D3D11_BREAKON_CATEGORY")]
        public const string BreakonCategory = unchecked((string) "BreakOn_CATEGORY_%s");
        [NativeName("Type", "")]
        [NativeName("Name", "D3D11_BREAKON_SEVERITY")]
        public const string BreakonSeverity = unchecked((string) "BreakOn_SEVERITY_%s");
        [NativeName("Type", "")]
        [NativeName("Name", "D3D11_BREAKON_ID_STRING")]
        public const string BreakonIDString = unchecked((string) "BreakOn_ID_%s");
        [NativeName("Type", "")]
        [NativeName("Name", "D3D11_BREAKON_ID_DECIMAL")]
        public const string BreakonIDDecimal = unchecked((string) "BreakOn_ID_%d");
        [NativeName("Type", "")]
        [NativeName("Name", "D3D11_APPSIZE_STRING")]
        public const string AppsizeString = unchecked((string) "Size");
        [NativeName("Type", "")]
        [NativeName("Name", "D3D11_APPNAME_STRING")]
        public const string AppnameString = unchecked((string) "Name");
        [NativeName("Type", "")]
        [NativeName("Name", "D3D11_FORCE_DEBUGGABLE")]
        public const string ForceDebuggable = unchecked((string) "ForceDebuggable");
        [NativeName("Type", "")]
        [NativeName("Name", "D3D11_FORCE_SHADER_SKIP_OPTIMIZATION")]
        public const string ForceShaderSkipOptimization = unchecked((string) "ForceShaderSkipOptimization");
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_INFO_QUEUE_DEFAULT_MESSAGE_COUNT_LIMIT")]
        public const int InfoQueueDefaultMessageCountLimit = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_TRACE_COMPONENT_X")]
        public const int TraceComponentX = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_TRACE_COMPONENT_Y")]
        public const int TraceComponentY = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_TRACE_COMPONENT_Z")]
        public const int TraceComponentZ = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_TRACE_COMPONENT_W")]
        public const int TraceComponentW = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_SHADER_TRACE_FLAG_RECORD_REGISTER_WRITES")]
        public const int ShaderTraceFlagRecordRegisterWrites = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_SHADER_TRACE_FLAG_RECORD_REGISTER_READS")]
        public const int ShaderTraceFlagRecordRegisterReads = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_TRACE_REGISTER_FLAGS_RELATIVE_INDEXING")]
        public const int TraceRegisterFlagsRelativeIndexing = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_TRACE_MISC_GS_EMIT")]
        public const int TraceMiscGSEmit = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_TRACE_MISC_GS_CUT")]
        public const int TraceMiscGSCut = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_TRACE_MISC_PS_DISCARD")]
        public const int TraceMiscPSDiscard = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_TRACE_MISC_GS_EMIT_STREAM")]
        public const int TraceMiscGSEmitStream = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_TRACE_MISC_GS_CUT_STREAM")]
        public const int TraceMiscGSCutStream = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_TRACE_MISC_HALT")]
        public const int TraceMiscHalt = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_TRACE_MISC_MESSAGE")]
        public const int TraceMiscMessage = unchecked((int) 0x40);
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
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D11_PACKED_TILE")]
        public const uint PackedTile = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_16BIT_INDEX_STRIP_CUT_VALUE")]
        public const int D3D1116BitIndexStripCutValue = unchecked((int) 0xFFFF);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D11_32BIT_INDEX_STRIP_CUT_VALUE")]
        public const uint D3D1132BitIndexStripCutValue = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_8BIT_INDEX_STRIP_CUT_VALUE")]
        public const int D3D118BitIndexStripCutValue = unchecked((int) 0xFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_ARRAY_AXIS_ADDRESS_RANGE_BIT_COUNT")]
        public const int ArrayAxisAddressRangeBitCount = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CLIP_OR_CULL_DISTANCE_COUNT")]
        public const int ClipOrCullDistanceCount = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CLIP_OR_CULL_DISTANCE_ELEMENT_COUNT")]
        public const int ClipOrCullDistanceElementCount = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT")]
        public const int CommonshaderConstantBufferApiSlotCount = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_CONSTANT_BUFFER_COMPONENTS")]
        public const int CommonshaderConstantBufferComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_CONSTANT_BUFFER_COMPONENT_BIT_COUNT")]
        public const int CommonshaderConstantBufferComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_CONSTANT_BUFFER_HW_SLOT_COUNT")]
        public const int CommonshaderConstantBufferHWSlotCount = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_CONSTANT_BUFFER_PARTIAL_UPDATE_EXTENTS_BYTE_ALIGNMENT")]
        public const int CommonshaderConstantBufferPartialUpdateExtentsByteAlignment = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COMPONENTS")]
        public const int CommonshaderConstantBufferRegisterComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COUNT")]
        public const int CommonshaderConstantBufferRegisterCount = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READS_PER_INST")]
        public const int CommonshaderConstantBufferRegisterReadsPerInst = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READ_PORTS")]
        public const int CommonshaderConstantBufferRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_FLOWCONTROL_NESTING_LIMIT")]
        public const int CommonshaderFlowcontrolNestingLimit = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COMPONENTS")]
        public const int CommonshaderImmediateConstantBufferRegisterComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COUNT")]
        public const int CommonshaderImmediateConstantBufferRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READS_PER_INST")]
        public const int CommonshaderImmediateConstantBufferRegisterReadsPerInst = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READ_PORTS")]
        public const int CommonshaderImmediateConstantBufferRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_IMMEDIATE_VALUE_COMPONENT_BIT_COUNT")]
        public const int CommonshaderImmediateValueComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_COMPONENTS")]
        public const int CommonshaderInputResourceRegisterComponents = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_COUNT")]
        public const int CommonshaderInputResourceRegisterCount = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_READS_PER_INST")]
        public const int CommonshaderInputResourceRegisterReadsPerInst = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_READ_PORTS")]
        public const int CommonshaderInputResourceRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT")]
        public const int CommonshaderInputResourceSlotCount = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_SAMPLER_REGISTER_COMPONENTS")]
        public const int CommonshaderSamplerRegisterComponents = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_SAMPLER_REGISTER_COUNT")]
        public const int CommonshaderSamplerRegisterCount = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_SAMPLER_REGISTER_READS_PER_INST")]
        public const int CommonshaderSamplerRegisterReadsPerInst = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_SAMPLER_REGISTER_READ_PORTS")]
        public const int CommonshaderSamplerRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT")]
        public const int CommonshaderSamplerSlotCount = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_SUBROUTINE_NESTING_LIMIT")]
        public const int CommonshaderSubroutineNestingLimit = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_TEMP_REGISTER_COMPONENTS")]
        public const int CommonshaderTempRegisterComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_TEMP_REGISTER_COMPONENT_BIT_COUNT")]
        public const int CommonshaderTempRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_TEMP_REGISTER_COUNT")]
        public const int CommonshaderTempRegisterCount = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_TEMP_REGISTER_READS_PER_INST")]
        public const int CommonshaderTempRegisterReadsPerInst = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_TEMP_REGISTER_READ_PORTS")]
        public const int CommonshaderTempRegisterReadPorts = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MAX")]
        public const int CommonshaderTexcoordRangeReductionMax = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMMONSHADER_TEXEL_OFFSET_MAX_POSITIVE")]
        public const int CommonshaderTexelOffsetMaxPositive = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET00_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket00MaxBytesTgsmWritablePerThread = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET00_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket00MaxNumThreadsPerGroup = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET01_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket01MaxBytesTgsmWritablePerThread = unchecked((int) 0xF0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET01_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket01MaxNumThreadsPerGroup = unchecked((int) 0x44);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET02_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket02MaxBytesTgsmWritablePerThread = unchecked((int) 0xE0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET02_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket02MaxNumThreadsPerGroup = unchecked((int) 0x48);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET03_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket03MaxBytesTgsmWritablePerThread = unchecked((int) 0xD0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET03_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket03MaxNumThreadsPerGroup = unchecked((int) 0x4C);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET04_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket04MaxBytesTgsmWritablePerThread = unchecked((int) 0xC0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET04_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket04MaxNumThreadsPerGroup = unchecked((int) 0x54);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET05_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket05MaxBytesTgsmWritablePerThread = unchecked((int) 0xB0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET05_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket05MaxNumThreadsPerGroup = unchecked((int) 0x5C);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET06_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket06MaxBytesTgsmWritablePerThread = unchecked((int) 0xA0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET06_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket06MaxNumThreadsPerGroup = unchecked((int) 0x64);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET07_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket07MaxBytesTgsmWritablePerThread = unchecked((int) 0x90);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET07_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket07MaxNumThreadsPerGroup = unchecked((int) 0x70);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET08_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket08MaxBytesTgsmWritablePerThread = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET08_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket08MaxNumThreadsPerGroup = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET09_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket09MaxBytesTgsmWritablePerThread = unchecked((int) 0x70);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET09_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket09MaxNumThreadsPerGroup = unchecked((int) 0x90);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET10_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket10MaxBytesTgsmWritablePerThread = unchecked((int) 0x60);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET10_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket10MaxNumThreadsPerGroup = unchecked((int) 0xA8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET11_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket11MaxBytesTgsmWritablePerThread = unchecked((int) 0x50);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET11_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket11MaxNumThreadsPerGroup = unchecked((int) 0xCC);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET12_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket12MaxBytesTgsmWritablePerThread = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET12_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket12MaxNumThreadsPerGroup = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET13_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket13MaxBytesTgsmWritablePerThread = unchecked((int) 0x30);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET13_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket13MaxNumThreadsPerGroup = unchecked((int) 0x154);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET14_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket14MaxBytesTgsmWritablePerThread = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET14_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket14MaxNumThreadsPerGroup = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET15_MAX_BYTES_TGSM_WRITABLE_PER_THREAD")]
        public const int CS4XBucket15MaxBytesTgsmWritablePerThread = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_BUCKET15_MAX_NUM_THREADS_PER_GROUP")]
        public const int CS4XBucket15MaxNumThreadsPerGroup = unchecked((int) 0x300);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_DISPATCH_MAX_THREAD_GROUPS_IN_Z_DIMENSION")]
        public const int CS4XDispatchMaxThreadGroupsInZDimension = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_RAW_UAV_BYTE_ALIGNMENT")]
        public const int CS4XRawUavByteAlignment = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_THREAD_GROUP_MAX_THREADS_PER_GROUP")]
        public const int CS4XThreadGroupMaxThreadsPerGroup = unchecked((int) 0x300);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_THREAD_GROUP_MAX_X")]
        public const int CS4XThreadGroupMaxX = unchecked((int) 0x300);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_THREAD_GROUP_MAX_Y")]
        public const int CS4XThreadGroupMaxY = unchecked((int) 0x300);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_4_X_UAV_REGISTER_COUNT")]
        public const int CS4XUavRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_DISPATCH_MAX_THREAD_GROUPS_PER_DIMENSION")]
        public const int CSDispatchMaxThreadGroupsPerDimension = unchecked((int) 0xFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_TGSM_REGISTER_COUNT")]
        public const int CSTgsmRegisterCount = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_TGSM_REGISTER_READS_PER_INST")]
        public const int CSTgsmRegisterReadsPerInst = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_TGSM_RESOURCE_REGISTER_COMPONENTS")]
        public const int CSTgsmResourceRegisterComponents = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_TGSM_RESOURCE_REGISTER_READ_PORTS")]
        public const int CSTgsmResourceRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_THREADGROUPID_REGISTER_COMPONENTS")]
        public const int CSThreadgroupidRegisterComponents = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_THREADGROUPID_REGISTER_COUNT")]
        public const int CSThreadgroupidRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_THREADIDINGROUPFLATTENED_REGISTER_COMPONENTS")]
        public const int CSThreadidingroupflattenedRegisterComponents = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_THREADIDINGROUPFLATTENED_REGISTER_COUNT")]
        public const int CSThreadidingroupflattenedRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_THREADIDINGROUP_REGISTER_COMPONENTS")]
        public const int CSThreadidingroupRegisterComponents = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_THREADIDINGROUP_REGISTER_COUNT")]
        public const int CSThreadidingroupRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_THREADID_REGISTER_COMPONENTS")]
        public const int CSThreadidRegisterComponents = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_THREADID_REGISTER_COUNT")]
        public const int CSThreadidRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_THREAD_GROUP_MAX_THREADS_PER_GROUP")]
        public const int CSThreadGroupMaxThreadsPerGroup = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_THREAD_GROUP_MAX_X")]
        public const int CSThreadGroupMaxX = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_THREAD_GROUP_MAX_Y")]
        public const int CSThreadGroupMaxY = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_THREAD_GROUP_MAX_Z")]
        public const int CSThreadGroupMaxZ = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_THREAD_GROUP_MIN_X")]
        public const int CSThreadGroupMinX = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_THREAD_GROUP_MIN_Y")]
        public const int CSThreadGroupMinY = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_THREAD_GROUP_MIN_Z")]
        public const int CSThreadGroupMinZ = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_CS_THREAD_LOCAL_TEMP_REGISTER_POOL")]
        public const int CSThreadLocalTempRegisterPool = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DEFAULT_DEPTH_BIAS")]
        public const int DefaultDepthBias = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DEFAULT_MAX_ANISOTROPY")]
        public const int DefaultMaxAnisotropy = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DEFAULT_RENDER_TARGET_ARRAY_INDEX")]
        public const int DefaultRenderTargetArrayIndex = unchecked((int) 0x0);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D11_DEFAULT_SAMPLE_MASK")]
        public const uint DefaultSampleMask = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DEFAULT_SCISSOR_ENDX")]
        public const int DefaultScissorEndx = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DEFAULT_SCISSOR_ENDY")]
        public const int DefaultScissorEndy = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DEFAULT_SCISSOR_STARTX")]
        public const int DefaultScissorStartx = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DEFAULT_SCISSOR_STARTY")]
        public const int DefaultScissorStarty = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DEFAULT_STENCIL_READ_MASK")]
        public const int DefaultStencilReadMask = unchecked((int) 0xFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DEFAULT_STENCIL_REFERENCE")]
        public const int DefaultStencilReference = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DEFAULT_STENCIL_WRITE_MASK")]
        public const int DefaultStencilWriteMask = unchecked((int) 0xFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DEFAULT_VIEWPORT_AND_SCISSORRECT_INDEX")]
        public const int DefaultViewportAndScissorrectIndex = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DEFAULT_VIEWPORT_HEIGHT")]
        public const int DefaultViewportHeight = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DEFAULT_VIEWPORT_TOPLEFTX")]
        public const int DefaultViewportTopleftx = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DEFAULT_VIEWPORT_TOPLEFTY")]
        public const int DefaultViewportToplefty = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DEFAULT_VIEWPORT_WIDTH")]
        public const int DefaultViewportWidth = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DS_INPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS")]
        public const int DSInputControlPointsMaxTotalScalars = unchecked((int) 0xF80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENTS")]
        public const int DSInputControlPointRegisterComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT")]
        public const int DSInputControlPointRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DS_INPUT_CONTROL_POINT_REGISTER_COUNT")]
        public const int DSInputControlPointRegisterCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DS_INPUT_CONTROL_POINT_REGISTER_READS_PER_INST")]
        public const int DSInputControlPointRegisterReadsPerInst = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DS_INPUT_CONTROL_POINT_REGISTER_READ_PORTS")]
        public const int DSInputControlPointRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENTS")]
        public const int DSInputDomainPointRegisterComponents = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENT_BIT_COUNT")]
        public const int DSInputDomainPointRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_COUNT")]
        public const int DSInputDomainPointRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_READS_PER_INST")]
        public const int DSInputDomainPointRegisterReadsPerInst = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DS_INPUT_DOMAIN_POINT_REGISTER_READ_PORTS")]
        public const int DSInputDomainPointRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENTS")]
        public const int DSInputPatchConstantRegisterComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT")]
        public const int DSInputPatchConstantRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_COUNT")]
        public const int DSInputPatchConstantRegisterCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST")]
        public const int DSInputPatchConstantRegisterReadsPerInst = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DS_INPUT_PATCH_CONSTANT_REGISTER_READ_PORTS")]
        public const int DSInputPatchConstantRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS")]
        public const int DSInputPrimitiveIDRegisterComponents = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT")]
        public const int DSInputPrimitiveIDRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_COUNT")]
        public const int DSInputPrimitiveIDRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST")]
        public const int DSInputPrimitiveIDRegisterReadsPerInst = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS")]
        public const int DSInputPrimitiveIDRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DS_OUTPUT_REGISTER_COMPONENTS")]
        public const int DSOutputRegisterComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT")]
        public const int DSOutputRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_DS_OUTPUT_REGISTER_COUNT")]
        public const int DSOutputRegisterCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_GS_INPUT_INSTANCE_ID_READS_PER_INST")]
        public const int GSInputInstanceIDReadsPerInst = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_GS_INPUT_INSTANCE_ID_READ_PORTS")]
        public const int GSInputInstanceIDReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENTS")]
        public const int GSInputInstanceIDRegisterComponents = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT")]
        public const int GSInputInstanceIDRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_GS_INPUT_INSTANCE_ID_REGISTER_COUNT")]
        public const int GSInputInstanceIDRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_GS_INPUT_PRIM_CONST_REGISTER_COMPONENTS")]
        public const int GSInputPrimConstRegisterComponents = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_GS_INPUT_PRIM_CONST_REGISTER_COMPONENT_BIT_COUNT")]
        public const int GSInputPrimConstRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_GS_INPUT_PRIM_CONST_REGISTER_COUNT")]
        public const int GSInputPrimConstRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_GS_INPUT_PRIM_CONST_REGISTER_READS_PER_INST")]
        public const int GSInputPrimConstRegisterReadsPerInst = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_GS_INPUT_PRIM_CONST_REGISTER_READ_PORTS")]
        public const int GSInputPrimConstRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_GS_INPUT_REGISTER_COMPONENTS")]
        public const int GSInputRegisterComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_GS_INPUT_REGISTER_COMPONENT_BIT_COUNT")]
        public const int GSInputRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_GS_INPUT_REGISTER_COUNT")]
        public const int GSInputRegisterCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_GS_INPUT_REGISTER_READS_PER_INST")]
        public const int GSInputRegisterReadsPerInst = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_GS_INPUT_REGISTER_READ_PORTS")]
        public const int GSInputRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_GS_INPUT_REGISTER_VERTICES")]
        public const int GSInputRegisterVertices = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_GS_MAX_INSTANCE_COUNT")]
        public const int GSMaxInstanceCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_GS_MAX_OUTPUT_VERTEX_COUNT_ACROSS_INSTANCES")]
        public const int GSMaxOutputVertexCountAcrossInstances = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_GS_OUTPUT_ELEMENTS")]
        public const int GSOutputElements = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_GS_OUTPUT_REGISTER_COMPONENTS")]
        public const int GSOutputRegisterComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_GS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT")]
        public const int GSOutputRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_GS_OUTPUT_REGISTER_COUNT")]
        public const int GSOutputRegisterCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_CONTROL_POINT_PHASE_INPUT_REGISTER_COUNT")]
        public const int HSControlPointPhaseInputRegisterCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_CONTROL_POINT_PHASE_OUTPUT_REGISTER_COUNT")]
        public const int HSControlPointPhaseOutputRegisterCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_CONTROL_POINT_REGISTER_COMPONENTS")]
        public const int HSControlPointRegisterComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT")]
        public const int HSControlPointRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_CONTROL_POINT_REGISTER_READS_PER_INST")]
        public const int HSControlPointRegisterReadsPerInst = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_CONTROL_POINT_REGISTER_READ_PORTS")]
        public const int HSControlPointRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D11_HS_FORK_PHASE_INSTANCE_COUNT_UPPER_BOUND")]
        public const uint HSForkPhaseInstanceCountUpperBound = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENTS")]
        public const int HSInputForkInstanceIDRegisterComponents = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT")]
        public const int HSInputForkInstanceIDRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COUNT")]
        public const int HSInputForkInstanceIDRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READS_PER_INST")]
        public const int HSInputForkInstanceIDRegisterReadsPerInst = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READ_PORTS")]
        public const int HSInputForkInstanceIDRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENTS")]
        public const int HSInputJoinInstanceIDRegisterComponents = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT")]
        public const int HSInputJoinInstanceIDRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COUNT")]
        public const int HSInputJoinInstanceIDRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READS_PER_INST")]
        public const int HSInputJoinInstanceIDRegisterReadsPerInst = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READ_PORTS")]
        public const int HSInputJoinInstanceIDRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS")]
        public const int HSInputPrimitiveIDRegisterComponents = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT")]
        public const int HSInputPrimitiveIDRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_COUNT")]
        public const int HSInputPrimitiveIDRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST")]
        public const int HSInputPrimitiveIDRegisterReadsPerInst = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS")]
        public const int HSInputPrimitiveIDRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D11_HS_JOIN_PHASE_INSTANCE_COUNT_UPPER_BOUND")]
        public const uint HSJoinPhaseInstanceCountUpperBound = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_OUTPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS")]
        public const int HSOutputControlPointsMaxTotalScalars = unchecked((int) 0xF80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENTS")]
        public const int HSOutputControlPointIDRegisterComponents = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENT_BIT_COUNT")]
        public const int HSOutputControlPointIDRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COUNT")]
        public const int HSOutputControlPointIDRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READS_PER_INST")]
        public const int HSOutputControlPointIDRegisterReadsPerInst = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READ_PORTS")]
        public const int HSOutputControlPointIDRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENTS")]
        public const int HSOutputPatchConstantRegisterComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT")]
        public const int HSOutputPatchConstantRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COUNT")]
        public const int HSOutputPatchConstantRegisterCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST")]
        public const int HSOutputPatchConstantRegisterReadsPerInst = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READ_PORTS")]
        public const int HSOutputPatchConstantRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_HS_OUTPUT_PATCH_CONSTANT_REGISTER_SCALAR_COMPONENTS")]
        public const int HSOutputPatchConstantRegisterScalarComponents = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_IA_DEFAULT_INDEX_BUFFER_OFFSET_IN_BYTES")]
        public const int IADefaultIndexBufferOffsetInBytes = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_IA_DEFAULT_PRIMITIVE_TOPOLOGY")]
        public const int IADefaultPrimitiveTopology = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_IA_DEFAULT_VERTEX_BUFFER_OFFSET_IN_BYTES")]
        public const int IADefaultVertexBufferOffsetInBytes = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_IA_INDEX_INPUT_RESOURCE_SLOT_COUNT")]
        public const int IAIndexInputResourceSlotCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_IA_INSTANCE_ID_BIT_COUNT")]
        public const int IAInstanceIDBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_IA_INTEGER_ARITHMETIC_BIT_COUNT")]
        public const int IAIntegerArithmeticBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_IA_PATCH_MAX_CONTROL_POINT_COUNT")]
        public const int IAPatchMaxControlPointCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_IA_PRIMITIVE_ID_BIT_COUNT")]
        public const int IAPrimitiveIDBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_IA_VERTEX_ID_BIT_COUNT")]
        public const int IAVertexIDBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT")]
        public const int IAVertexInputResourceSlotCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_IA_VERTEX_INPUT_STRUCTURE_ELEMENTS_COMPONENTS")]
        public const int IAVertexInputStructureElementsComponents = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_IA_VERTEX_INPUT_STRUCTURE_ELEMENT_COUNT")]
        public const int IAVertexInputStructureElementCount = unchecked((int) 0x20);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D11_INTEGER_DIVIDE_BY_ZERO_QUOTIENT")]
        public const uint IntegerDivideByZeroQuotient = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D11_INTEGER_DIVIDE_BY_ZERO_REMAINDER")]
        public const uint IntegerDivideByZeroRemainder = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D11_KEEP_RENDER_TARGETS_AND_DEPTH_STENCIL")]
        public const uint KeepRenderTargetsAndDepthStencil = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D11_KEEP_UNORDERED_ACCESS_VIEWS")]
        public const uint KeepUnorderedAccessViews = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_MAJOR_VERSION")]
        public const int MajorVersion = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_MAX_MAXANISOTROPY")]
        public const int MaxMaxanisotropy = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_MAX_MULTISAMPLE_SAMPLE_COUNT")]
        public const int MaxMultisampleSampleCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_MAX_TEXTURE_DIMENSION_2_TO_EXP")]
        public const int MaxTextureDimension2ToExp = unchecked((int) 0x11);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_MINOR_VERSION")]
        public const int MinorVersion = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_MIN_MAXANISOTROPY")]
        public const int MinMaxanisotropy = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_MIP_LOD_FRACTIONAL_BIT_COUNT")]
        public const int MipLodFractionalBitCount = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_MIP_LOD_RANGE_BIT_COUNT")]
        public const int MipLodRangeBitCount = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_NONSAMPLE_FETCH_OUT_OF_RANGE_ACCESS_RESULT")]
        public const int NonsampleFetchOutOfRangeAccessResult = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_PIXEL_ADDRESS_RANGE_BIT_COUNT")]
        public const int PixelAddressRangeBitCount = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_PRE_SCISSOR_PIXEL_ADDRESS_RANGE_BIT_COUNT")]
        public const int PreScissorPixelAddressRangeBitCount = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_PS_CS_UAV_REGISTER_COMPONENTS")]
        public const int PSCSUavRegisterComponents = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_PS_CS_UAV_REGISTER_COUNT")]
        public const int PSCSUavRegisterCount = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_PS_CS_UAV_REGISTER_READS_PER_INST")]
        public const int PSCSUavRegisterReadsPerInst = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_PS_CS_UAV_REGISTER_READ_PORTS")]
        public const int PSCSUavRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D11_PS_FRONTFACING_DEFAULT_VALUE")]
        public const uint PSFrontfacingDefaultValue = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_PS_FRONTFACING_FALSE_VALUE")]
        public const int PSFrontfacingFalseValue = unchecked((int) 0x0);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D11_PS_FRONTFACING_TRUE_VALUE")]
        public const uint PSFrontfacingTrueValue = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_PS_INPUT_REGISTER_COMPONENTS")]
        public const int PSInputRegisterComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_PS_INPUT_REGISTER_COMPONENT_BIT_COUNT")]
        public const int PSInputRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_PS_INPUT_REGISTER_COUNT")]
        public const int PSInputRegisterCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_PS_INPUT_REGISTER_READS_PER_INST")]
        public const int PSInputRegisterReadsPerInst = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_PS_INPUT_REGISTER_READ_PORTS")]
        public const int PSInputRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_PS_OUTPUT_DEPTH_REGISTER_COMPONENTS")]
        public const int PSOutputDepthRegisterComponents = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_PS_OUTPUT_DEPTH_REGISTER_COMPONENT_BIT_COUNT")]
        public const int PSOutputDepthRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_PS_OUTPUT_DEPTH_REGISTER_COUNT")]
        public const int PSOutputDepthRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_PS_OUTPUT_MASK_REGISTER_COMPONENTS")]
        public const int PSOutputMaskRegisterComponents = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_PS_OUTPUT_MASK_REGISTER_COMPONENT_BIT_COUNT")]
        public const int PSOutputMaskRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_PS_OUTPUT_MASK_REGISTER_COUNT")]
        public const int PSOutputMaskRegisterCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_PS_OUTPUT_REGISTER_COMPONENTS")]
        public const int PSOutputRegisterComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_PS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT")]
        public const int PSOutputRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_PS_OUTPUT_REGISTER_COUNT")]
        public const int PSOutputRegisterCount = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_RAW_UAV_SRV_BYTE_ALIGNMENT")]
        public const int RawUavSrvByteAlignment = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_REQ_BLEND_OBJECT_COUNT_PER_DEVICE")]
        public const int ReqBlendObjectCountPerDevice = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_REQ_BUFFER_RESOURCE_TEXEL_COUNT_2_TO_EXP")]
        public const int ReqBufferResourceTexelCount2ToExp = unchecked((int) 0x1B);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_REQ_CONSTANT_BUFFER_ELEMENT_COUNT")]
        public const int ReqConstantBufferElementCount = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_REQ_DEPTH_STENCIL_OBJECT_COUNT_PER_DEVICE")]
        public const int ReqDepthStencilObjectCountPerDevice = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_REQ_DRAWINDEXED_INDEX_COUNT_2_TO_EXP")]
        public const int ReqDrawindexedIndexCount2ToExp = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_REQ_DRAW_VERTEX_COUNT_2_TO_EXP")]
        public const int ReqDrawVertexCount2ToExp = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_REQ_FILTERING_HW_ADDRESSABLE_RESOURCE_DIMENSION")]
        public const int ReqFilteringHWAddressableResourceDimension = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_REQ_GS_INVOCATION_32BIT_OUTPUT_COMPONENT_LIMIT")]
        public const int ReqGSInvocation32BitOutputComponentLimit = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_REQ_IMMEDIATE_CONSTANT_BUFFER_ELEMENT_COUNT")]
        public const int ReqImmediateConstantBufferElementCount = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_REQ_MAXANISOTROPY")]
        public const int ReqMaxanisotropy = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_REQ_MIP_LEVELS")]
        public const int ReqMipLevels = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_REQ_MULTI_ELEMENT_STRUCTURE_SIZE_IN_BYTES")]
        public const int ReqMultiElementStructureSizeInBytes = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_REQ_RASTERIZER_OBJECT_COUNT_PER_DEVICE")]
        public const int ReqRasterizerObjectCountPerDevice = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_REQ_RENDER_TO_BUFFER_WINDOW_WIDTH")]
        public const int ReqRenderToBufferWindowWidth = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_A_TERM")]
        public const int ReqResourceSizeInMegabytesExpressionATerm = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_C_TERM")]
        public const int ReqResourceSizeInMegabytesExpressionCTerm = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_REQ_RESOURCE_VIEW_COUNT_PER_DEVICE_2_TO_EXP")]
        public const int ReqResourceViewCountPerDevice2ToExp = unchecked((int) 0x14);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_REQ_SAMPLER_OBJECT_COUNT_PER_DEVICE")]
        public const int ReqSamplerObjectCountPerDevice = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_REQ_TEXTURE1D_ARRAY_AXIS_DIMENSION")]
        public const int ReqTexture1DArrayAxisDimension = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_REQ_TEXTURE1D_U_DIMENSION")]
        public const int ReqTexture1DUDimension = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_REQ_TEXTURE2D_ARRAY_AXIS_DIMENSION")]
        public const int ReqTexture2DArrayAxisDimension = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_REQ_TEXTURE2D_U_OR_V_DIMENSION")]
        public const int ReqTexture2DUOrVDimension = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_REQ_TEXTURE3D_U_V_OR_W_DIMENSION")]
        public const int ReqTexture3DUVOrWDimension = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_REQ_TEXTURECUBE_DIMENSION")]
        public const int ReqTexturecubeDimension = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_RESINFO_INSTRUCTION_MISSING_COMPONENT_RETVAL")]
        public const int ResinfoInstructionMissingComponentRetval = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_SHADER_MAJOR_VERSION")]
        public const int ShaderMajorVersion = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_SHADER_MAX_INSTANCES")]
        public const int ShaderMaxInstances = unchecked((int) 0xFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_SHADER_MAX_INTERFACES")]
        public const int ShaderMaxInterfaces = unchecked((int) 0xFD);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_SHADER_MAX_INTERFACE_CALL_SITES")]
        public const int ShaderMaxInterfaceCallSites = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_SHADER_MAX_TYPES")]
        public const int ShaderMaxTypes = unchecked((int) 0xFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_SHADER_MINOR_VERSION")]
        public const int ShaderMinorVersion = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_SHIFT_INSTRUCTION_PAD_VALUE")]
        public const int ShiftInstructionPadValue = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_SHIFT_INSTRUCTION_SHIFT_VALUE_BIT_COUNT")]
        public const int ShiftInstructionShiftValueBitCount = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_SIMULTANEOUS_RENDER_TARGET_COUNT")]
        public const int SimultaneousRenderTargetCount = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_SO_BUFFER_MAX_STRIDE_IN_BYTES")]
        public const int SOBufferMaxStrideInBytes = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_SO_BUFFER_MAX_WRITE_WINDOW_IN_BYTES")]
        public const int SOBufferMaxWriteWindowInBytes = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_SO_BUFFER_SLOT_COUNT")]
        public const int SOBufferSlotCount = unchecked((int) 0x4);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D11_SO_DDI_REGISTER_INDEX_DENOTING_GAP")]
        public const uint SODdiRegisterIndexDenotingGap = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D11_SO_NO_RASTERIZED_STREAM")]
        public const uint SONoRasterizedStream = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_SO_OUTPUT_COMPONENT_COUNT")]
        public const int SOOutputComponentCount = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_SO_STREAM_COUNT")]
        public const int SOStreamCount = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_SPEC_DATE_DAY")]
        public const int SpecDateDay = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_SPEC_DATE_MONTH")]
        public const int SpecDateMonth = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_SPEC_DATE_YEAR")]
        public const int SpecDateYear = unchecked((int) 0x7DB);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_STANDARD_COMPONENT_BIT_COUNT")]
        public const int StandardComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_STANDARD_COMPONENT_BIT_COUNT_DOUBLED")]
        public const int StandardComponentBitCountDoubled = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_STANDARD_MAXIMUM_ELEMENT_ALIGNMENT_BYTE_MULTIPLE")]
        public const int StandardMaximumElementAlignmentByteMultiple = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_STANDARD_PIXEL_COMPONENT_COUNT")]
        public const int StandardPixelComponentCount = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_STANDARD_PIXEL_ELEMENT_COUNT")]
        public const int StandardPixelElementCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_STANDARD_VECTOR_SIZE")]
        public const int StandardVectorSize = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_STANDARD_VERTEX_ELEMENT_COUNT")]
        public const int StandardVertexElementCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_STANDARD_VERTEX_TOTAL_COMPONENT_COUNT")]
        public const int StandardVertexTotalComponentCount = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_SUBPIXEL_FRACTIONAL_BIT_COUNT")]
        public const int SubpixelFractionalBitCount = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_SUBTEXEL_FRACTIONAL_BIT_COUNT")]
        public const int SubtexelFractionalBitCount = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_TESSELLATOR_MAX_EVEN_TESSELLATION_FACTOR")]
        public const int TessellatorMaxEvenTessellationFactor = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_TESSELLATOR_MAX_ISOLINE_DENSITY_TESSELLATION_FACTOR")]
        public const int TessellatorMaxIsolineDensityTessellationFactor = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_TESSELLATOR_MAX_ODD_TESSELLATION_FACTOR")]
        public const int TessellatorMaxOddTessellationFactor = unchecked((int) 0x3F);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_TESSELLATOR_MAX_TESSELLATION_FACTOR")]
        public const int TessellatorMaxTessellationFactor = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_TESSELLATOR_MIN_EVEN_TESSELLATION_FACTOR")]
        public const int TessellatorMinEvenTessellationFactor = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_TESSELLATOR_MIN_ISOLINE_DENSITY_TESSELLATION_FACTOR")]
        public const int TessellatorMinIsolineDensityTessellationFactor = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_TESSELLATOR_MIN_ODD_TESSELLATION_FACTOR")]
        public const int TessellatorMinOddTessellationFactor = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_TEXEL_ADDRESS_RANGE_BIT_COUNT")]
        public const int TexelAddressRangeBitCount = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_UNBOUND_MEMORY_ACCESS_RESULT")]
        public const int UnboundMemoryAccessResult = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_VIEWPORT_AND_SCISSORRECT_MAX_INDEX")]
        public const int ViewportAndScissorrectMaxIndex = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE")]
        public const int ViewportAndScissorrectObjectCountPerPipeline = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_VIEWPORT_BOUNDS_MAX")]
        public const int ViewportBoundsMax = unchecked((int) 0x7FFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_VS_INPUT_REGISTER_COMPONENTS")]
        public const int VSInputRegisterComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_VS_INPUT_REGISTER_COMPONENT_BIT_COUNT")]
        public const int VSInputRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_VS_INPUT_REGISTER_COUNT")]
        public const int VSInputRegisterCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_VS_INPUT_REGISTER_READS_PER_INST")]
        public const int VSInputRegisterReadsPerInst = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_VS_INPUT_REGISTER_READ_PORTS")]
        public const int VSInputRegisterReadPorts = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_VS_OUTPUT_REGISTER_COMPONENTS")]
        public const int VSOutputRegisterComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_VS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT")]
        public const int VSOutputRegisterComponentBitCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_VS_OUTPUT_REGISTER_COUNT")]
        public const int VSOutputRegisterCount = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_WHQL_CONTEXT_COUNT_FOR_RESOURCE_LIMIT")]
        public const int WhqlContextCountForResourceLimit = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_WHQL_DRAWINDEXED_INDEX_COUNT_2_TO_EXP")]
        public const int WhqlDrawindexedIndexCount2ToExp = unchecked((int) 0x19);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_WHQL_DRAW_VERTEX_COUNT_2_TO_EXP")]
        public const int WhqlDrawVertexCount2ToExp = unchecked((int) 0x19);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_1_UAV_SLOT_COUNT")]
        public const int D3D111UavSlotCount = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_2_TILED_RESOURCE_TILE_SIZE_IN_BYTES")]
        public const int D3D112TiledResourceTileSizeInBytes = unchecked((int) 0x10000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_4_VIDEO_DECODER_MAX_HISTOGRAM_COMPONENTS")]
        public const int D3D114VideoDecoderMaxHistogramComponents = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_4_VIDEO_DECODER_HISTOGRAM_OFFSET_ALIGNMENT")]
        public const int D3D114VideoDecoderHistogramOffsetAlignment = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "_FACD3D11")]
        public const int Facd3D11 = unchecked((int) 0x87C);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "D3D11_APPEND_ALIGNED_ELEMENT")]
        public const uint AppendAlignedElement = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_FILTER_REDUCTION_TYPE_MASK")]
        public const int FilterReductionTypeMask = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_FILTER_REDUCTION_TYPE_SHIFT")]
        public const int FilterReductionTypeShift = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_FILTER_TYPE_MASK")]
        public const int FilterTypeMask = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_MIN_FILTER_SHIFT")]
        public const int MinFilterShift = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_MAG_FILTER_SHIFT")]
        public const int MagFilterShift = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_MIP_FILTER_SHIFT")]
        public const int MipFilterShift = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_COMPARISON_FILTERING_BIT")]
        public const int ComparisonFilteringBit = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_ANISOTROPIC_FILTERING_BIT")]
        public const int AnisotropicFilteringBit = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D11_SDK_VERSION")]
        public const int SdkVersion = unchecked((int) 0x7);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15, Column 8 in windows.graphics.directx.direct3d11.interop.h")]
        [NativeApi(EntryPoint = "CreateDirect3D11DeviceFromDXGIDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDirect3D11DeviceFromDXGIDevice(Silk.NET.DXGI.IDXGIDevice* dxgiDevice, Silk.NET.Core.Native.IInspectable** graphicsDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15, Column 8 in windows.graphics.directx.direct3d11.interop.h")]
        [NativeApi(EntryPoint = "CreateDirect3D11DeviceFromDXGIDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDirect3D11DeviceFromDXGIDevice(Silk.NET.DXGI.IDXGIDevice* dxgiDevice, ref Silk.NET.Core.Native.IInspectable* graphicsDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15, Column 8 in windows.graphics.directx.direct3d11.interop.h")]
        [NativeApi(EntryPoint = "CreateDirect3D11DeviceFromDXGIDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDirect3D11DeviceFromDXGIDevice(ref Silk.NET.DXGI.IDXGIDevice dxgiDevice, Silk.NET.Core.Native.IInspectable** graphicsDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15, Column 8 in windows.graphics.directx.direct3d11.interop.h")]
        [NativeApi(EntryPoint = "CreateDirect3D11DeviceFromDXGIDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDirect3D11DeviceFromDXGIDevice(ref Silk.NET.DXGI.IDXGIDevice dxgiDevice, ref Silk.NET.Core.Native.IInspectable* graphicsDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 19, Column 8 in windows.graphics.directx.direct3d11.interop.h")]
        [NativeApi(EntryPoint = "CreateDirect3D11SurfaceFromDXGISurface", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDirect3D11SurfaceFromDXGISurface(Silk.NET.DXGI.IDXGISurface* dgxiSurface, Silk.NET.Core.Native.IInspectable** graphicsSurface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 19, Column 8 in windows.graphics.directx.direct3d11.interop.h")]
        [NativeApi(EntryPoint = "CreateDirect3D11SurfaceFromDXGISurface", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDirect3D11SurfaceFromDXGISurface(Silk.NET.DXGI.IDXGISurface* dgxiSurface, ref Silk.NET.Core.Native.IInspectable* graphicsSurface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 19, Column 8 in windows.graphics.directx.direct3d11.interop.h")]
        [NativeApi(EntryPoint = "CreateDirect3D11SurfaceFromDXGISurface", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDirect3D11SurfaceFromDXGISurface(ref Silk.NET.DXGI.IDXGISurface dgxiSurface, Silk.NET.Core.Native.IInspectable** graphicsSurface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 19, Column 8 in windows.graphics.directx.direct3d11.interop.h")]
        [NativeApi(EntryPoint = "CreateDirect3D11SurfaceFromDXGISurface", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDirect3D11SurfaceFromDXGISurface(ref Silk.NET.DXGI.IDXGISurface dgxiSurface, ref Silk.NET.Core.Native.IInspectable* graphicsSurface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 571, Column 1 in d3d11shadertracing.h")]
        [NativeApi(EntryPoint = "D3DDisassemble11Trace", Convention = CallingConvention.StdCall)]
        public unsafe partial int D3DDisassemble11Trace([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSize, ID3D11ShaderTrace* pTrace, uint StartStep, uint NumSteps, uint Flags, Silk.NET.Core.Native.ID3D10Blob** ppDisassembly);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 571, Column 1 in d3d11shadertracing.h")]
        [NativeApi(EntryPoint = "D3DDisassemble11Trace", Convention = CallingConvention.StdCall)]
        public unsafe partial int D3DDisassemble11Trace([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSize, ID3D11ShaderTrace* pTrace, uint StartStep, uint NumSteps, uint Flags, ref Silk.NET.Core.Native.ID3D10Blob* ppDisassembly);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 571, Column 1 in d3d11shadertracing.h")]
        [NativeApi(EntryPoint = "D3DDisassemble11Trace", Convention = CallingConvention.StdCall)]
        public unsafe partial int D3DDisassemble11Trace([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSize, ref ID3D11ShaderTrace pTrace, uint StartStep, uint NumSteps, uint Flags, Silk.NET.Core.Native.ID3D10Blob** ppDisassembly);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 571, Column 1 in d3d11shadertracing.h")]
        [NativeApi(EntryPoint = "D3DDisassemble11Trace", Convention = CallingConvention.StdCall)]
        public unsafe partial int D3DDisassemble11Trace([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSize, ref ID3D11ShaderTrace pTrace, uint StartStep, uint NumSteps, uint Flags, ref Silk.NET.Core.Native.ID3D10Blob* ppDisassembly);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 571, Column 1 in d3d11shadertracing.h")]
        [NativeApi(EntryPoint = "D3DDisassemble11Trace", Convention = CallingConvention.StdCall)]
        public unsafe partial int D3DDisassemble11Trace<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, nuint SrcDataSize, ID3D11ShaderTrace* pTrace, uint StartStep, uint NumSteps, uint Flags, Silk.NET.Core.Native.ID3D10Blob** ppDisassembly) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 571, Column 1 in d3d11shadertracing.h")]
        [NativeApi(EntryPoint = "D3DDisassemble11Trace", Convention = CallingConvention.StdCall)]
        public unsafe partial int D3DDisassemble11Trace<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, nuint SrcDataSize, ID3D11ShaderTrace* pTrace, uint StartStep, uint NumSteps, uint Flags, ref Silk.NET.Core.Native.ID3D10Blob* ppDisassembly) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 571, Column 1 in d3d11shadertracing.h")]
        [NativeApi(EntryPoint = "D3DDisassemble11Trace", Convention = CallingConvention.StdCall)]
        public unsafe partial int D3DDisassemble11Trace<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, nuint SrcDataSize, ref ID3D11ShaderTrace pTrace, uint StartStep, uint NumSteps, uint Flags, Silk.NET.Core.Native.ID3D10Blob** ppDisassembly) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 571, Column 1 in d3d11shadertracing.h")]
        [NativeApi(EntryPoint = "D3DDisassemble11Trace", Convention = CallingConvention.StdCall)]
        public unsafe partial int D3DDisassemble11Trace<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, nuint SrcDataSize, ref ID3D11ShaderTrace pTrace, uint StartStep, uint NumSteps, uint Flags, ref Silk.NET.Core.Native.ID3D10Blob* ppDisassembly) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(Silk.NET.DXGI.IDXGIAdapter* pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ID3D11Device** ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ID3D11DeviceContext** ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        [NativeApi(EntryPoint = "D3D11CreateDeviceAndSwapChain", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDeviceAndSwapChain(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15, Column 8 in windows.graphics.directx.direct3d11.interop.h")]
        public unsafe int CreateDirect3D11DeviceFromDXGIDevice<TI0>(Silk.NET.DXGI.IDXGIDevice* dxgiDevice, ref ComPtr<TI0> graphicsDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IInspectable>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDirect3D11DeviceFromDXGIDevice(dxgiDevice, (Silk.NET.Core.Native.IInspectable**) graphicsDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15, Column 8 in windows.graphics.directx.direct3d11.interop.h")]
        public unsafe int CreateDirect3D11DeviceFromDXGIDevice<TI0>(ref Silk.NET.DXGI.IDXGIDevice dxgiDevice, ref ComPtr<TI0> graphicsDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IInspectable>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDirect3D11DeviceFromDXGIDevice(ref dxgiDevice, (Silk.NET.Core.Native.IInspectable**) graphicsDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 19, Column 8 in windows.graphics.directx.direct3d11.interop.h")]
        public unsafe int CreateDirect3D11SurfaceFromDXGISurface<TI0>(Silk.NET.DXGI.IDXGISurface* dgxiSurface, ref ComPtr<TI0> graphicsSurface) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IInspectable>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDirect3D11SurfaceFromDXGISurface(dgxiSurface, (Silk.NET.Core.Native.IInspectable**) graphicsSurface.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 19, Column 8 in windows.graphics.directx.direct3d11.interop.h")]
        public unsafe int CreateDirect3D11SurfaceFromDXGISurface<TI0>(ref Silk.NET.DXGI.IDXGISurface dgxiSurface, ref ComPtr<TI0> graphicsSurface) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IInspectable>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDirect3D11SurfaceFromDXGISurface(ref dgxiSurface, (Silk.NET.Core.Native.IInspectable**) graphicsSurface.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 571, Column 1 in d3d11shadertracing.h")]
        public unsafe int D3DDisassemble11Trace<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSize, ComPtr<TI0> pTrace, uint StartStep, uint NumSteps, uint Flags, ref ComPtr<TI1> ppDisassembly) where TI0 : unmanaged, IComVtbl<ID3D11ShaderTrace>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return D3DDisassemble11Trace(pSrcData, SrcDataSize, (ID3D11ShaderTrace*) pTrace.Handle, StartStep, NumSteps, Flags, (Silk.NET.Core.Native.ID3D10Blob**) ppDisassembly.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 571, Column 1 in d3d11shadertracing.h")]
        public unsafe int D3DDisassemble11Trace<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSize, ComPtr<TI0> pTrace, uint StartStep, uint NumSteps, uint Flags, ref Silk.NET.Core.Native.ID3D10Blob* ppDisassembly) where TI0 : unmanaged, IComVtbl<ID3D11ShaderTrace>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return D3DDisassemble11Trace(pSrcData, SrcDataSize, (ID3D11ShaderTrace*) pTrace.Handle, StartStep, NumSteps, Flags, ref ppDisassembly);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 571, Column 1 in d3d11shadertracing.h")]
        public unsafe int D3DDisassemble11Trace<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, nuint SrcDataSize, ref ID3D11ShaderTrace pTrace, uint StartStep, uint NumSteps, uint Flags, ref ComPtr<TI0> ppDisassembly) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return D3DDisassemble11Trace(pSrcData, SrcDataSize, ref pTrace, StartStep, NumSteps, Flags, (Silk.NET.Core.Native.ID3D10Blob**) ppDisassembly.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 571, Column 1 in d3d11shadertracing.h")]
        public unsafe int D3DDisassemble11Trace<T0, TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, nuint SrcDataSize, ComPtr<TI0> pTrace, uint StartStep, uint NumSteps, uint Flags, ref ComPtr<TI1> ppDisassembly) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11ShaderTrace>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return D3DDisassemble11Trace(in pSrcData, SrcDataSize, (ID3D11ShaderTrace*) pTrace.Handle, StartStep, NumSteps, Flags, (Silk.NET.Core.Native.ID3D10Blob**) ppDisassembly.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 571, Column 1 in d3d11shadertracing.h")]
        public unsafe int D3DDisassemble11Trace<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, nuint SrcDataSize, ComPtr<TI0> pTrace, uint StartStep, uint NumSteps, uint Flags, ref Silk.NET.Core.Native.ID3D10Blob* ppDisassembly) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D11ShaderTrace>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return D3DDisassemble11Trace(in pSrcData, SrcDataSize, (ID3D11ShaderTrace*) pTrace.Handle, StartStep, NumSteps, Flags, ref ppDisassembly);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 571, Column 1 in d3d11shadertracing.h")]
        public unsafe int D3DDisassemble11Trace<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcData, nuint SrcDataSize, ref ID3D11ShaderTrace pTrace, uint StartStep, uint NumSteps, uint Flags, ref ComPtr<TI0> ppDisassembly) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return D3DDisassemble11Trace(in pSrcData, SrcDataSize, ref pTrace, StartStep, NumSteps, Flags, (Silk.NET.Core.Native.ID3D10Blob**) ppDisassembly.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public unsafe int CreateDevice<TI0, TI1, TI2>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ComPtr<TI1> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI2> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDevice((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public unsafe int CreateDevice<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ComPtr<TI1> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDevice((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public unsafe int CreateDevice<TI0, TI1, TI2>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ComPtr<TI1> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI2> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDevice((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public unsafe int CreateDevice<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ComPtr<TI1> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDevice((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public unsafe int CreateDevice<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDevice((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public unsafe int CreateDevice<TI0>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDevice((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public unsafe int CreateDevice<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDevice((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public unsafe int CreateDevice<TI0>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDevice((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public unsafe int CreateDevice<TI0, TI1, TI2>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ComPtr<TI1> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI2> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDevice((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public unsafe int CreateDevice<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ComPtr<TI1> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDevice((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public unsafe int CreateDevice<TI0, TI1, TI2>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ComPtr<TI1> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI2> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDevice((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public unsafe int CreateDevice<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ComPtr<TI1> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDevice((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public unsafe int CreateDevice<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDevice((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public unsafe int CreateDevice<TI0>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDevice((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public unsafe int CreateDevice<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDevice((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public unsafe int CreateDevice<TI0>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDevice((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public unsafe int CreateDevice<TI0, TI1>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ComPtr<TI0> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDevice(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public unsafe int CreateDevice<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ComPtr<TI0> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDevice(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public unsafe int CreateDevice<TI0, TI1>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ComPtr<TI0> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDevice(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public unsafe int CreateDevice<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ComPtr<TI0> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDevice(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public unsafe int CreateDevice<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI0> ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDevice(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public unsafe int CreateDevice<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI0> ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDevice(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public unsafe int CreateDevice<TI0, TI1>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ComPtr<TI0> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDevice(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public unsafe int CreateDevice<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ComPtr<TI0> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDevice(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public unsafe int CreateDevice<TI0, TI1>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ComPtr<TI0> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDevice(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public unsafe int CreateDevice<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ComPtr<TI0> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDevice(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public unsafe int CreateDevice<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI0> ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDevice(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15060, Column 16 in d3d11.h")]
        public unsafe int CreateDevice<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI0> ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDevice(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, ref ppDevice, ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2, TI3>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ComPtr<TI2> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI3> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI2> where TI3 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI3>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ComPtr<TI2> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2, TI3>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ComPtr<TI2> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI3> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI2> where TI3 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI3>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ComPtr<TI2> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI2> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI2> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI1> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI2> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI1> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI1> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI2> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI1> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2, TI3>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ComPtr<TI2> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI3> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI2> where TI3 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI3>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ComPtr<TI2> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2, TI3>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ComPtr<TI2> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI3> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI2> where TI3 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI3>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ComPtr<TI2> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI2> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI2> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI1> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI2> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI1> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI1> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI2> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI1> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2, TI3>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ComPtr<TI2> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI3> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI2> where TI3 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI3>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ComPtr<TI2> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2, TI3>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ComPtr<TI2> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI3> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI2> where TI3 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI3>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ComPtr<TI2> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI2> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI2> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI1> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI2> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI1> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI1> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI2> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI1> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2, TI3>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ComPtr<TI2> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI3> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI2> where TI3 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI3>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ComPtr<TI2> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2, TI3>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ComPtr<TI2> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI3> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI2> where TI3 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI3>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ComPtr<TI2> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI2> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI2> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI1> ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI1> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI2> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI1> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI1> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI2> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI1> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ComPtr<TI0> pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain((Silk.NET.DXGI.IDXGIAdapter*) pAdapter.Handle, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ComPtr<TI1> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI2> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ComPtr<TI1> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ComPtr<TI1> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI2> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ComPtr<TI1> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI0> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI0> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI0> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI0> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI0> ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI0> ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ComPtr<TI1> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI2> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ComPtr<TI1> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ComPtr<TI1> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI2> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ComPtr<TI1> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI0> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI0> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI0> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI0> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI0> ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI0> ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ComPtr<TI1> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI2> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ComPtr<TI1> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ComPtr<TI1> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI2> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ComPtr<TI1> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI0> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI0> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI0> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI0> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI0> ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.SwapChainDesc* pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI0> ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ComPtr<TI1> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI2> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ComPtr<TI1> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1, TI2>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ComPtr<TI1> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI2> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI2>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ComPtr<TI1> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref ComPtr<TI0> ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf(), ref ppDevice, ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI0> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI0> ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0, TI1>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI0> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI1> ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ComPtr<TI0> ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ID3D11DeviceContext* ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11Device>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, ref ppSwapChain, (ID3D11Device**) ppDevice.GetAddressOf(), ref pFeatureLevel, ref ppImmediateContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, Silk.NET.Core.Native.D3DFeatureLevel* pFeatureLevel, ref ComPtr<TI0> ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, ref ppSwapChain, ref ppDevice, pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 15134, Column 16 in d3d11.h")]
        public unsafe int CreateDeviceAndSwapChain<TI0>(ref Silk.NET.DXGI.IDXGIAdapter pAdapter, Silk.NET.Core.Native.D3DDriverType DriverType, nint Software, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevels, uint FeatureLevels, uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.DXGI.SwapChainDesc pSwapChainDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain, ref ID3D11Device* ppDevice, ref Silk.NET.Core.Native.D3DFeatureLevel pFeatureLevel, ref ComPtr<TI0> ppImmediateContext) where TI0 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDeviceAndSwapChain(ref pAdapter, DriverType, Software, Flags, in pFeatureLevels, FeatureLevels, SDKVersion, in pSwapChainDesc, ref ppSwapChain, ref ppDevice, ref pFeatureLevel, (ID3D11DeviceContext**) ppImmediateContext.GetAddressOf());
        }


        public D3D11(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

