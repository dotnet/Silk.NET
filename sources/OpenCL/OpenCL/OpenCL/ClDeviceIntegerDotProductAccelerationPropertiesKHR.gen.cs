// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
namespace Silk.NET.OpenCL;

[NativeName("_cl_device_integer_dot_product_acceleration_properties_khr")]
public partial struct ClDeviceIntegerDotProductAccelerationPropertiesKHR
{
    [NativeName("signed_accelerated")]
    public uint SignedAccelerated;

    [NativeName("unsigned_accelerated")]
    public uint UnsignedAccelerated;

    [NativeName("mixed_signedness_accelerated")]
    public uint MixedSignednessAccelerated;

    [NativeName("accumulating_saturating_signed_accelerated")]
    public uint AccumulatingSaturatingSignedAccelerated;

    [NativeName("accumulating_saturating_unsigned_accelerated")]
    public uint AccumulatingSaturatingUnsignedAccelerated;

    [NativeName("accumulating_saturating_mixed_signedness_accelerated")]
    public uint AccumulatingSaturatingMixedSignednessAccelerated;
}
