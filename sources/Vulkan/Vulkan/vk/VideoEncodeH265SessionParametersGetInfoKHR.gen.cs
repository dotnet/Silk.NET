// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeH265SessionParametersGetInfoKHR")]
public unsafe partial struct VideoEncodeH265SessionParametersGetInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoEncodeH265SessionParametersGetInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("writeStdVPS")]
    public MaybeBool<uint> WriteStdVps;

    [NativeName("writeStdSPS")]
    public MaybeBool<uint> WriteStdSps;

    [NativeName("writeStdPPS")]
    public MaybeBool<uint> WriteStdPps;

    [NativeName("stdVPSId")]
    public uint StdVpsId;

    [NativeName("stdSPSId")]
    public uint StdSpsId;

    [NativeName("stdPPSId")]
    public uint StdPpsId;

    public VideoEncodeH265SessionParametersGetInfoKHR() { }
}
