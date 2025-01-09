// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from ffx-api and corresponding dependencies of FidelityFX.
// Original source is Copyright (C) 2024 Advanced Micro Devices, Inc. Licensed under the MIT license.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FidelityFX;

public unsafe partial struct ConfigureDescFrameGeneration
{
    [NativeTypeName("ffxConfigureDescHeader")]
    public ApiHeader Header;
    public void* SwapChain;

    [NativeTypeName("FfxApiPresentCallbackFunc")]
    public ApiPresentCallbackFunc PresentCallback;
    public void* PresentCallbackUserContext;

    [NativeTypeName("FfxApiFrameGenerationDispatchFunc")]
    public ApiFrameGenerationDispatchFunc FrameGenerationCallback;
    public void* FrameGenerationCallbackUserContext;

    [NativeTypeName("bool")]
    public byte FrameGenerationEnabled;

    [NativeTypeName("bool")]
    public byte AllowAsyncWorkloads;

    [NativeTypeName("struct FfxApiResource")]
    public ApiResource HUDLessColor;

    [NativeTypeName("uint32_t")]
    public uint Flags;

    [NativeTypeName("bool")]
    public byte OnlyPresentGenerated;

    [NativeTypeName("struct FfxApiRect2D")]
    public ApiRect2D GenerationRect;

    [NativeTypeName("uint64_t")]
    public ulong FrameID;
}
