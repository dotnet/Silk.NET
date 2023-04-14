// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRVReflect
{
    [NativeName("Name", "SpvExecutionMode_")]
    public enum ExecutionMode : int
    {
        [NativeName("Name", "SpvExecutionModeInvocations")]
        Invocations = 0x0,
        [NativeName("Name", "SpvExecutionModeSpacingEqual")]
        SpacingEqual = 0x1,
        [NativeName("Name", "SpvExecutionModeSpacingFractionalEven")]
        SpacingFractionalEven = 0x2,
        [NativeName("Name", "SpvExecutionModeSpacingFractionalOdd")]
        SpacingFractionalOdd = 0x3,
        [NativeName("Name", "SpvExecutionModeVertexOrderCw")]
        VertexOrderCw = 0x4,
        [NativeName("Name", "SpvExecutionModeVertexOrderCcw")]
        VertexOrderCcw = 0x5,
        [NativeName("Name", "SpvExecutionModePixelCenterInteger")]
        PixelCenterInteger = 0x6,
        [NativeName("Name", "SpvExecutionModeOriginUpperLeft")]
        OriginUpperLeft = 0x7,
        [NativeName("Name", "SpvExecutionModeOriginLowerLeft")]
        OriginLowerLeft = 0x8,
        [NativeName("Name", "SpvExecutionModeEarlyFragmentTests")]
        EarlyFragmentTests = 0x9,
        [NativeName("Name", "SpvExecutionModePointMode")]
        PointMode = 0xA,
        [NativeName("Name", "SpvExecutionModeXfb")]
        Xfb = 0xB,
        [NativeName("Name", "SpvExecutionModeDepthReplacing")]
        DepthReplacing = 0xC,
        [NativeName("Name", "SpvExecutionModeDepthGreater")]
        DepthGreater = 0xE,
        [NativeName("Name", "SpvExecutionModeDepthLess")]
        DepthLess = 0xF,
        [NativeName("Name", "SpvExecutionModeDepthUnchanged")]
        DepthUnchanged = 0x10,
        [NativeName("Name", "SpvExecutionModeLocalSize")]
        LocalSize = 0x11,
        [NativeName("Name", "SpvExecutionModeLocalSizeHint")]
        LocalSizeHint = 0x12,
        [NativeName("Name", "SpvExecutionModeInputPoints")]
        InputPoints = 0x13,
        [NativeName("Name", "SpvExecutionModeInputLines")]
        InputLines = 0x14,
        [NativeName("Name", "SpvExecutionModeInputLinesAdjacency")]
        InputLinesAdjacency = 0x15,
        [NativeName("Name", "SpvExecutionModeTriangles")]
        Triangles = 0x16,
        [NativeName("Name", "SpvExecutionModeInputTrianglesAdjacency")]
        InputTrianglesAdjacency = 0x17,
        [NativeName("Name", "SpvExecutionModeQuads")]
        Quads = 0x18,
        [NativeName("Name", "SpvExecutionModeIsolines")]
        Isolines = 0x19,
        [NativeName("Name", "SpvExecutionModeOutputVertices")]
        OutputVertices = 0x1A,
        [NativeName("Name", "SpvExecutionModeOutputPoints")]
        OutputPoints = 0x1B,
        [NativeName("Name", "SpvExecutionModeOutputLineStrip")]
        OutputLineStrip = 0x1C,
        [NativeName("Name", "SpvExecutionModeOutputTriangleStrip")]
        OutputTriangleStrip = 0x1D,
        [NativeName("Name", "SpvExecutionModeVecTypeHint")]
        VecTypeHint = 0x1E,
        [NativeName("Name", "SpvExecutionModeContractionOff")]
        ContractionOff = 0x1F,
        [NativeName("Name", "SpvExecutionModeInitializer")]
        Initializer = 0x21,
        [NativeName("Name", "SpvExecutionModeFinalizer")]
        Finalizer = 0x22,
        [NativeName("Name", "SpvExecutionModeSubgroupSize")]
        SubgroupSize = 0x23,
        [NativeName("Name", "SpvExecutionModeSubgroupsPerWorkgroup")]
        SubgroupsPerWorkgroup = 0x24,
        [NativeName("Name", "SpvExecutionModeSubgroupsPerWorkgroupId")]
        SubgroupsPerWorkgroupId = 0x25,
        [NativeName("Name", "SpvExecutionModeLocalSizeId")]
        LocalSizeId = 0x26,
        [NativeName("Name", "SpvExecutionModeLocalSizeHintId")]
        LocalSizeHintId = 0x27,
        [NativeName("Name", "SpvExecutionModeSubgroupUniformControlFlowKHR")]
        SubgroupUniformControlFlowKhr = 0x1145,
        [NativeName("Name", "SpvExecutionModePostDepthCoverage")]
        PostDepthCoverage = 0x115E,
        [NativeName("Name", "SpvExecutionModeDenormPreserve")]
        DenormPreserve = 0x116B,
        [NativeName("Name", "SpvExecutionModeDenormFlushToZero")]
        DenormFlushToZero = 0x116C,
        [NativeName("Name", "SpvExecutionModeSignedZeroInfNanPreserve")]
        SignedZeroInfNanPreserve = 0x116D,
        [NativeName("Name", "SpvExecutionModeRoundingModeRTE")]
        RoundingModeRte = 0x116E,
        [NativeName("Name", "SpvExecutionModeRoundingModeRTZ")]
        RoundingModeRtz = 0x116F,
        [NativeName("Name", "SpvExecutionModeStencilRefReplacingEXT")]
        StencilRefReplacingExt = 0x13A3,
        [NativeName("Name", "SpvExecutionModeOutputLinesNV")]
        OutputLinesNV = 0x1495,
        [NativeName("Name", "SpvExecutionModeOutputPrimitivesNV")]
        OutputPrimitivesNV = 0x1496,
        [NativeName("Name", "SpvExecutionModeDerivativeGroupQuadsNV")]
        DerivativeGroupQuadsNV = 0x14A9,
        [NativeName("Name", "SpvExecutionModeDerivativeGroupLinearNV")]
        DerivativeGroupLinearNV = 0x14AA,
        [NativeName("Name", "SpvExecutionModeOutputTrianglesNV")]
        OutputTrianglesNV = 0x14B2,
        [NativeName("Name", "SpvExecutionModePixelInterlockOrderedEXT")]
        PixelInterlockOrderedExt = 0x14F6,
        [NativeName("Name", "SpvExecutionModePixelInterlockUnorderedEXT")]
        PixelInterlockUnorderedExt = 0x14F7,
        [NativeName("Name", "SpvExecutionModeSampleInterlockOrderedEXT")]
        SampleInterlockOrderedExt = 0x14F8,
        [NativeName("Name", "SpvExecutionModeSampleInterlockUnorderedEXT")]
        SampleInterlockUnorderedExt = 0x14F9,
        [NativeName("Name", "SpvExecutionModeShadingRateInterlockOrderedEXT")]
        ShadingRateInterlockOrderedExt = 0x14FA,
        [NativeName("Name", "SpvExecutionModeShadingRateInterlockUnorderedEXT")]
        ShadingRateInterlockUnorderedExt = 0x14FB,
        [NativeName("Name", "SpvExecutionModeSharedLocalMemorySizeINTEL")]
        SharedLocalMemorySizeIntel = 0x15F2,
        [NativeName("Name", "SpvExecutionModeRoundingModeRTPINTEL")]
        RoundingModeRtpintel = 0x15F4,
        [NativeName("Name", "SpvExecutionModeRoundingModeRTNINTEL")]
        RoundingModeRtnintel = 0x15F5,
        [NativeName("Name", "SpvExecutionModeFloatingPointModeALTINTEL")]
        FloatingPointModeAltintel = 0x15F6,
        [NativeName("Name", "SpvExecutionModeFloatingPointModeIEEEINTEL")]
        FloatingPointModeIeeeintel = 0x15F7,
        [NativeName("Name", "SpvExecutionModeMaxWorkgroupSizeINTEL")]
        MaxWorkgroupSizeIntel = 0x1705,
        [NativeName("Name", "SpvExecutionModeMaxWorkDimINTEL")]
        MaxWorkDimIntel = 0x1706,
        [NativeName("Name", "SpvExecutionModeNoGlobalOffsetINTEL")]
        NoGlobalOffsetIntel = 0x1707,
        [NativeName("Name", "SpvExecutionModeNumSIMDWorkitemsINTEL")]
        NumSimdworkitemsIntel = 0x1708,
        [NativeName("Name", "SpvExecutionModeSchedulerTargetFmaxMhzINTEL")]
        SchedulerTargetFmaxMhzIntel = 0x170F,
        [NativeName("Name", "SpvExecutionModeNamedBarrierCountINTEL")]
        NamedBarrierCountIntel = 0x1911,
        [NativeName("Name", "SpvExecutionModeMax")]
        Max = 0x7FFFFFFF,
    }
}
