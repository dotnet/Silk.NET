// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from ffx-api and corresponding dependencies of FidelityFX.
// Original source is Copyright (C) 2024 Advanced Micro Devices, Inc. Licensed under the MIT license.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FidelityFX;

public unsafe partial struct DispatchDescUpscale
{
    [NativeTypeName("ffxDispatchDescHeader")]
    public ApiHeader Header;
    public void* CommandList;

    [NativeTypeName("struct FfxApiResource")]
    public ApiResource Color;

    [NativeTypeName("struct FfxApiResource")]
    public ApiResource Depth;

    [NativeTypeName("struct FfxApiResource")]
    public ApiResource MotionVectors;

    [NativeTypeName("struct FfxApiResource")]
    public ApiResource Exposure;

    [NativeTypeName("struct FfxApiResource")]
    public ApiResource Reactive;

    [NativeTypeName("struct FfxApiResource")]
    public ApiResource TransparencyAndComposition;

    [NativeTypeName("struct FfxApiResource")]
    public ApiResource Output;

    [NativeTypeName("struct FfxApiFloatCoords2D")]
    public ApiFloatCoords2D JitterOffset;

    [NativeTypeName("struct FfxApiFloatCoords2D")]
    public ApiFloatCoords2D MotionVectorScale;

    [NativeTypeName("struct FfxApiDimensions2D")]
    public ApiDimensions2D RenderSize;

    [NativeTypeName("struct FfxApiDimensions2D")]
    public ApiDimensions2D UpscaleSize;

    [NativeTypeName("bool")]
    public byte EnableSharpening;
    public float Sharpness;
    public float FrameTimeDelta;
    public float PreExposure;

    [NativeTypeName("bool")]
    public byte Reset;
    public float CameraNear;
    public float CameraFar;
    public float CameraFovAngleVertical;
    public float ViewSpaceToMetersFactor;

    [NativeTypeName("uint32_t")]
    public uint Flags;
}
