// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrVirtualKeyboardTextureDataMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct VirtualKeyboardTextureDataMETA
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public StructureType Type = StructureType.VirtualKeyboardTextureDataMETA;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public void* Next;

    [NativeName("textureWidth")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public uint TextureWidth;

    [NativeName("textureHeight")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public uint TextureHeight;

    [NativeName("bufferCapacityInput")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public uint BufferCapacityInput;

    [NativeName("bufferCountOutput")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public uint BufferCountOutput;

    [NativeName("buffer")]
    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public byte* Buffer;

    [SupportedApiProfile("openxr", ["XR_META_virtual_keyboard"])]
    public VirtualKeyboardTextureDataMETA() { }
}
