// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe delegate MaybeBool<uint> PFNVkDebugReportCallbackEXTDelegate(
    DebugReportFlagsEXT arg0,
    DebugReportObjectTypeEXT arg1,
    ulong arg2,
    nuint arg3,
    int arg4,
    sbyte* arg5,
    sbyte* arg6,
    void* arg7
);
