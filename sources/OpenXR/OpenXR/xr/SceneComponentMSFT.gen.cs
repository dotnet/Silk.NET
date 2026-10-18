// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSceneComponentMSFT")]
[SupportedApiProfile("openxr")]
public partial struct SceneComponentMSFT
{
    [NativeName("componentType")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public SceneComponentTypeMSFT ComponentType;

    [NativeName("id")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public UuidMSFT Id;

    [NativeName("parentId")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public UuidMSFT ParentId;

    [NativeName("updateTime")]
    [SupportedApiProfile("openxr", ["XR_MSFT_scene_understanding"])]
    public long UpdateTime;
}
