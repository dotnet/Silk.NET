// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrApplicationInfo")]
public partial struct ApplicationInfo
{
    [NativeName("applicationName")]
    public ApplicationInfoApplicationName ApplicationName;

    [NativeName("applicationVersion")]
    public uint ApplicationVersion;

    [NativeName("engineName")]
    public ApplicationInfoEngineName EngineName;

    [NativeName("engineVersion")]
    public uint EngineVersion;

    [NativeName("apiVersion")]
    public ulong ApiVersion;
}
