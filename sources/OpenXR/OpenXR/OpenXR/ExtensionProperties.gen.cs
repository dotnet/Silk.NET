// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrExtensionProperties")]
[SupportedApiProfile("openxr")]
public unsafe partial struct ExtensionProperties
{
    [NativeName("type")]
    [SupportedApiProfile("openxr")]
    public StructureType Type = StructureType.ExtensionProperties;

    [NativeName("next")]
    [SupportedApiProfile("openxr")]
    public void* Next;

    [NativeName("extensionName")]
    [SupportedApiProfile("openxr")]
    public ExtensionPropertiesExtensionName ExtensionName;

    [NativeName("extensionVersion")]
    [SupportedApiProfile("openxr")]
    public uint ExtensionVersion;

    [SupportedApiProfile("openxr")]
    public ExtensionProperties() { }
}
