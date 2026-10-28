// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceShaderIntegerDotProductProperties")]
public unsafe partial struct PhysicalDeviceShaderIntegerDotProductProperties
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceShaderIntegerDotProductProperties;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("integerDotProduct8BitUnsignedAccelerated")]
    public MaybeBool<uint> IntegerDotProduct8BitUnsignedAccelerated;

    [NativeName("integerDotProduct8BitSignedAccelerated")]
    public MaybeBool<uint> IntegerDotProduct8BitSignedAccelerated;

    [NativeName("integerDotProduct8BitMixedSignednessAccelerated")]
    public MaybeBool<uint> IntegerDotProduct8BitMixedSignednessAccelerated;

    [NativeName("integerDotProduct4x8BitPackedUnsignedAccelerated")]
    public MaybeBool<uint> IntegerDotProduct4x8BitPackedUnsignedAccelerated;

    [NativeName("integerDotProduct4x8BitPackedSignedAccelerated")]
    public MaybeBool<uint> IntegerDotProduct4x8BitPackedSignedAccelerated;

    [NativeName("integerDotProduct4x8BitPackedMixedSignednessAccelerated")]
    public MaybeBool<uint> IntegerDotProduct4x8BitPackedMixedSignednessAccelerated;

    [NativeName("integerDotProduct16BitUnsignedAccelerated")]
    public MaybeBool<uint> IntegerDotProduct16BitUnsignedAccelerated;

    [NativeName("integerDotProduct16BitSignedAccelerated")]
    public MaybeBool<uint> IntegerDotProduct16BitSignedAccelerated;

    [NativeName("integerDotProduct16BitMixedSignednessAccelerated")]
    public MaybeBool<uint> IntegerDotProduct16BitMixedSignednessAccelerated;

    [NativeName("integerDotProduct32BitUnsignedAccelerated")]
    public MaybeBool<uint> IntegerDotProduct32BitUnsignedAccelerated;

    [NativeName("integerDotProduct32BitSignedAccelerated")]
    public MaybeBool<uint> IntegerDotProduct32BitSignedAccelerated;

    [NativeName("integerDotProduct32BitMixedSignednessAccelerated")]
    public MaybeBool<uint> IntegerDotProduct32BitMixedSignednessAccelerated;

    [NativeName("integerDotProduct64BitUnsignedAccelerated")]
    public MaybeBool<uint> IntegerDotProduct64BitUnsignedAccelerated;

    [NativeName("integerDotProduct64BitSignedAccelerated")]
    public MaybeBool<uint> IntegerDotProduct64BitSignedAccelerated;

    [NativeName("integerDotProduct64BitMixedSignednessAccelerated")]
    public MaybeBool<uint> IntegerDotProduct64BitMixedSignednessAccelerated;

    [NativeName("integerDotProductAccumulatingSaturating8BitUnsignedAccelerated")]
    public MaybeBool<uint> IntegerDotProductAccumulatingSaturating8BitUnsignedAccelerated;

    [NativeName("integerDotProductAccumulatingSaturating8BitSignedAccelerated")]
    public MaybeBool<uint> IntegerDotProductAccumulatingSaturating8BitSignedAccelerated;

    [NativeName("integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated")]
    public MaybeBool<uint> IntegerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;

    [NativeName("integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated")]
    public MaybeBool<uint> IntegerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;

    [NativeName("integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated")]
    public MaybeBool<uint> IntegerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;

    [NativeName("integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated")]
    public MaybeBool<uint> IntegerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;

    [NativeName("integerDotProductAccumulatingSaturating16BitUnsignedAccelerated")]
    public MaybeBool<uint> IntegerDotProductAccumulatingSaturating16BitUnsignedAccelerated;

    [NativeName("integerDotProductAccumulatingSaturating16BitSignedAccelerated")]
    public MaybeBool<uint> IntegerDotProductAccumulatingSaturating16BitSignedAccelerated;

    [NativeName("integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated")]
    public MaybeBool<uint> IntegerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;

    [NativeName("integerDotProductAccumulatingSaturating32BitUnsignedAccelerated")]
    public MaybeBool<uint> IntegerDotProductAccumulatingSaturating32BitUnsignedAccelerated;

    [NativeName("integerDotProductAccumulatingSaturating32BitSignedAccelerated")]
    public MaybeBool<uint> IntegerDotProductAccumulatingSaturating32BitSignedAccelerated;

    [NativeName("integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated")]
    public MaybeBool<uint> IntegerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;

    [NativeName("integerDotProductAccumulatingSaturating64BitUnsignedAccelerated")]
    public MaybeBool<uint> IntegerDotProductAccumulatingSaturating64BitUnsignedAccelerated;

    [NativeName("integerDotProductAccumulatingSaturating64BitSignedAccelerated")]
    public MaybeBool<uint> IntegerDotProductAccumulatingSaturating64BitSignedAccelerated;

    [NativeName("integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated")]
    public MaybeBool<uint> IntegerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;

    public PhysicalDeviceShaderIntegerDotProductProperties() { }
}
