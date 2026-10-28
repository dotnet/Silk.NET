// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeH264SessionParametersGetInfoKHR")]
public unsafe partial struct VideoEncodeH264SessionParametersGetInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoEncodeH264SessionParametersGetInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("writeStdSPS")]
    public MaybeBool<uint> WriteStdSps;

    [NativeName("writeStdPPS")]
    public MaybeBool<uint> WriteStdPps;

    [NativeName("stdSPSId")]
    public uint StdSpsId;

    [NativeName("stdPPSId")]
    public uint StdPpsId;

    public VideoEncodeH264SessionParametersGetInfoKHR() { }
}
