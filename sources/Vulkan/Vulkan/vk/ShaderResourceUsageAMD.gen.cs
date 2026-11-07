// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkShaderResourceUsageAMD")]
public partial struct ShaderResourceUsageAMD
{
    [NativeName("numUsedVgprs")]
    public uint NumUsedVgprs;

    [NativeName("numUsedSgprs")]
    public uint NumUsedSgprs;

    [NativeName("ldsSizePerLocalWorkGroup")]
    public uint LdsSizePerLocalWorkGroup;

    [NativeName("ldsUsageSizeInBytes")]
    public nuint LdsUsageSizeInBytes;

    [NativeName("scratchMemUsageInBytes")]
    public nuint ScratchMemUsageInBytes;
}
