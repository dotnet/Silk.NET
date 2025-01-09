// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from ffx-api and corresponding dependencies of FidelityFX.
// Original source is Copyright (C) 2024 Advanced Micro Devices, Inc. Licensed under the MIT license.
namespace Silk.NET.FidelityFX;

public unsafe partial struct CallbackDescFrameGenerationPresent
{
    [NativeTypeName("ffxDispatchDescHeader")]
    public ApiHeader Header;
    public void* Device;
    public void* CommandList;

    [NativeTypeName("struct FfxApiResource")]
    public ApiResource CurrentBackBuffer;

    [NativeTypeName("struct FfxApiResource")]
    public ApiResource CurrentUI;

    [NativeTypeName("struct FfxApiResource")]
    public ApiResource OutputSwapChainBuffer;

    [NativeTypeName("bool")]
    public byte IsGeneratedFrame;

    [NativeTypeName("uint64_t")]
    public ulong FrameID;
}
