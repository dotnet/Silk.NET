// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_mem_android_native_buffer_host_ptr")]
public unsafe partial struct ClMemAndroidNativeBufferHostPtr
{
    [NativeName("ext_host_ptr")]
    public ClMemExtHostPtr ExtHostPtr;

    [NativeName("anb_ptr")]
    public void* AnbPtr;
}
