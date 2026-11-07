// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkImportMemoryFdInfoKHR")]
public unsafe partial struct ImportMemoryFdInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.ImportMemoryFdInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("handleType")]
    public ExternalMemoryHandleTypeFlags HandleType;

    [NativeName("fd")]
    public int Fd;

    public ImportMemoryFdInfoKHR() { }
}
