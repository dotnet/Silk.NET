// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPresentTimeGOOGLE")]
public partial struct PresentTimeGOOGLE
{
    [NativeName("presentID")]
    public uint PresentID;

    [NativeName("desiredPresentTime")]
    public ulong DesiredPresentTime;
}
