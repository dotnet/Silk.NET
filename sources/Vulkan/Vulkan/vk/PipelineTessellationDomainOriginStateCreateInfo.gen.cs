// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPipelineTessellationDomainOriginStateCreateInfo")]
public unsafe partial struct PipelineTessellationDomainOriginStateCreateInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PipelineTessellationDomainOriginStateCreateInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("domainOrigin")]
    public TessellationDomainOrigin DomainOrigin;

    public PipelineTessellationDomainOriginStateCreateInfo() { }
}
