// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrInstanceProperties")]
[SupportedApiProfile("openxr")]
public unsafe partial struct InstanceProperties
{
    [NativeName("type")]
    [SupportedApiProfile("openxr")]
    public StructureType Type = StructureType.TypeInstanceProperties;

    [NativeName("next")]
    [SupportedApiProfile("openxr")]
    public void* Next;

    [NativeName("runtimeVersion")]
    [SupportedApiProfile("openxr")]
    public ulong RuntimeVersion;

    [NativeName("runtimeName")]
    [SupportedApiProfile("openxr")]
    public InstancePropertiesRuntimeName RuntimeName;

    [SupportedApiProfile("openxr")]
    public InstanceProperties() { }
}
