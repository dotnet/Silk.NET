// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEventDataViewConfigurationViewsChangedEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct EventDataViewConfigurationViewsChangedEXT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_EXT_view_configuration_views_change"])]
    public StructureType Type = StructureType.EventDataViewConfigurationViewsChangedEXT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_EXT_view_configuration_views_change"])]
    public void* Next;

    [NativeName("systemId")]
    [SupportedApiProfile("openxr", ["XR_EXT_view_configuration_views_change"])]
    public ulong SystemId;

    [NativeName("viewConfigurationType")]
    [SupportedApiProfile("openxr", ["XR_EXT_view_configuration_views_change"])]
    public ViewConfigurationType ViewConfigurationType;

    [SupportedApiProfile("openxr", ["XR_EXT_view_configuration_views_change"])]
    public EventDataViewConfigurationViewsChangedEXT() { }
}
