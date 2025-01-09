// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from ffx-api and corresponding dependencies of FidelityFX.
// Original source is Copyright (C) 2024 Advanced Micro Devices, Inc. Licensed under the MIT license.
namespace Silk.NET.FidelityFX;

public unsafe partial struct DispatchDescFrameGenerationPrepare
{
    [NativeTypeName("ffxDispatchDescHeader")]
    public ApiHeader Header;

    [NativeTypeName("uint64_t")]
    public ulong FrameID;

    [NativeTypeName("uint32_t")]
    public uint Flags;
    public void* CommandList;

    [NativeTypeName("struct FfxApiDimensions2D")]
    public ApiDimensions2D RenderSize;

    [NativeTypeName("struct FfxApiFloatCoords2D")]
    public ApiFloatCoords2D JitterOffset;

    [NativeTypeName("struct FfxApiFloatCoords2D")]
    public ApiFloatCoords2D MotionVectorScale;
    public float FrameTimeDelta;

    [NativeTypeName("bool")]
    public byte UnusedReset;
    public float CameraNear;
    public float CameraFar;
    public float CameraFovAngleVertical;
    public float ViewSpaceToMetersFactor;

    [NativeTypeName("struct FfxApiResource")]
    public ApiResource Depth;

    [NativeTypeName("struct FfxApiResource")]
    public ApiResource MotionVectors;
}
