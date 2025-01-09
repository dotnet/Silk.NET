// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from ffx-api and corresponding dependencies of FidelityFX.
// Original source is Copyright (C) 2024 Advanced Micro Devices, Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.FidelityFX;

public unsafe partial struct DispatchDescFrameGeneration
{
    [NativeTypeName("ffxDispatchDescHeader")]
    public ApiHeader Header;
    public void* CommandList;

    [NativeTypeName("struct FfxApiResource")]
    public ApiResource PresentColor;

    [NativeTypeName("struct FfxApiResource[4]")]
    public DispatchDescFrameGenerationOutputs Outputs;

    [NativeTypeName("uint32_t")]
    public uint NumGeneratedFrames;

    [NativeTypeName("bool")]
    public byte Reset;

    [NativeTypeName("uint32_t")]
    public uint BackbufferTransferFunction;

    [NativeTypeName("float[2]")]
    public DispatchDescFrameGenerationMinMaxLuminance MinMaxLuminance;

    [NativeTypeName("struct FfxApiRect2D")]
    public ApiRect2D GenerationRect;

    [NativeTypeName("uint64_t")]
    public ulong FrameID;
}
