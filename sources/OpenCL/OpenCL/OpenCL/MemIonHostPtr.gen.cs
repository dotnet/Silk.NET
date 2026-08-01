// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_mem_ion_host_ptr")]
public unsafe partial struct MemIonHostPtr
{
    [NativeName("ext_host_ptr")]
    public MemExtHostPtr ExtHostPtr;

    [NativeName("ion_filedesc")]
    public int IonFiledesc;

    [NativeName("ion_hostptr")]
    public void* IonHostptr;
}
