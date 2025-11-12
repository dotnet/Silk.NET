// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoH265HrdParameters
{
    [SupportedApiProfile("vulkan")]
    public StdVideoH265HrdFlags Flags;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte TickDivisorMinus2;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte DuCpbRemovalDelayIncrementLengthMinus1;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte DpbOutputDelayDuLengthMinus1;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte BitRateScale;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte CpbSizeScale;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte CpbSizeDuScale;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte InitialCpbRemovalDelayLengthMinus1;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte AuCpbRemovalDelayLengthMinus1;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte DpbOutputDelayLengthMinus1;

    [NativeTypeName("uint8_t[7]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265HrdParametersCpbCntMinus1 CpbCntMinus1;

    [NativeTypeName("uint16_t[7]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265HrdParametersElementalDurationInTcMinus1 ElementalDurationInTcMinus1;

    [NativeTypeName("uint16_t[3]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265HrdParametersReserved Reserved;

    [NativeTypeName("const StdVideoH265SubLayerHrdParameters *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265SubLayerHrdParameters* PSubLayerHrdParametersNal;

    [NativeTypeName("const StdVideoH265SubLayerHrdParameters *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265SubLayerHrdParameters* PSubLayerHrdParametersVcl;
}
