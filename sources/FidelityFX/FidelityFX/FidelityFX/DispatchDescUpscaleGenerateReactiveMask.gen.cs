// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from ffx-api and corresponding dependencies of FidelityFX.
// Original source is Copyright (C) 2024 Advanced Micro Devices, Inc. Licensed under the MIT license.
namespace Silk.NET.FidelityFX;

public unsafe partial struct DispatchDescUpscaleGenerateReactiveMask
{
    [NativeTypeName("ffxDispatchDescHeader")]
    public ApiHeader Header;
    public void* CommandList;

    [NativeTypeName("struct FfxApiResource")]
    public ApiResource ColorOpaqueOnly;

    [NativeTypeName("struct FfxApiResource")]
    public ApiResource ColorPreUpscale;

    [NativeTypeName("struct FfxApiResource")]
    public ApiResource OutReactive;

    [NativeTypeName("struct FfxApiDimensions2D")]
    public ApiDimensions2D RenderSize;
    public float Scale;
    public float CutoffThreshold;
    public float BinaryValue;

    [NativeTypeName("uint32_t")]
    public uint Flags;
}
