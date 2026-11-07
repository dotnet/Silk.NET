// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceSparseProperties")]
public partial struct PhysicalDeviceSparseProperties
{
    [NativeName("residencyStandard2DBlockShape")]
    public MaybeBool<uint> ResidencyStandard2DBlockShape;

    [NativeName("residencyStandard2DMultisampleBlockShape")]
    public MaybeBool<uint> ResidencyStandard2DMultisampleBlockShape;

    [NativeName("residencyStandard3DBlockShape")]
    public MaybeBool<uint> ResidencyStandard3DBlockShape;

    [NativeName("residencyAlignedMipSize")]
    public MaybeBool<uint> ResidencyAlignedMipSize;

    [NativeName("residencyNonResidentStrict")]
    public MaybeBool<uint> ResidencyNonResidentStrict;
}
