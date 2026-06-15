// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrApplicationInfo")]
[SupportedApiProfile("openxr")]
public partial struct ApplicationInfo
{
    [NativeName("applicationName")]
    [SupportedApiProfile("openxr")]
    public ApplicationInfoApplicationName ApplicationName;

    [NativeName("applicationVersion")]
    [SupportedApiProfile("openxr")]
    public uint ApplicationVersion;

    [NativeName("engineName")]
    [SupportedApiProfile("openxr")]
    public ApplicationInfoEngineName EngineName;

    [NativeName("engineVersion")]
    [SupportedApiProfile("openxr")]
    public uint EngineVersion;

    [NativeName("apiVersion")]
    [SupportedApiProfile("openxr")]
    public Version ApiVersion;
}
