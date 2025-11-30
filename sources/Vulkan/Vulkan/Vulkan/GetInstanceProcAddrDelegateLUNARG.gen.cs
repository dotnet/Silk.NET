// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "LUNARG", 0)]
[NameAffix("Suffix", "Delegate", 1)]
[NativeName("PFN_vkGetInstanceProcAddrLUNARG")]
[SupportedApiProfile("vulkan")]
public unsafe delegate GetInstanceProcAddrLunargP2 GetInstanceProcAddrDelegateLUNARG(
    InstanceHandle arg0,
    sbyte* arg1
);
