// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from ffx-api and corresponding dependencies of FidelityFX.
// Original source is Copyright (C) 2024 Advanced Micro Devices, Inc. Licensed under the MIT license.
namespace Silk.NET.FidelityFX;

public enum ApiCreateContextUpscaleFlags
{
    HighDynamicRange = (1 << 0),
    DisplayResolutionMotionVectors = (1 << 1),
    MotionVectorsJitterCancellation = (1 << 2),
    DepthInverted = (1 << 3),
    DepthInfinite = (1 << 4),
    AutoExposure = (1 << 5),
    DynamicResolution = (1 << 6),
    DebugChecking = (1 << 7),
    NonLinearColorspace = (1 << 8),
}
