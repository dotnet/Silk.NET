// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrLoaderInitInfoPropertiesEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct LoaderInitInfoPropertiesEXT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_EXT_loader_init_properties"])]
    public StructureType Type = StructureType.LoaderInitInfoPropertiesEXT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_EXT_loader_init_properties"])]
    public void* Next;

    [NativeName("propertyValueCount")]
    [SupportedApiProfile("openxr", ["XR_EXT_loader_init_properties"])]
    public uint PropertyValueCount;

    [NativeName("propertyValues")]
    [SupportedApiProfile("openxr", ["XR_EXT_loader_init_properties"])]
    public LoaderInitPropertyValueEXT* PropertyValues;

    [SupportedApiProfile("openxr", ["XR_EXT_loader_init_properties"])]
    public LoaderInitInfoPropertiesEXT() { }
}
