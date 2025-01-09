// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from ffx-api and corresponding dependencies of FidelityFX.
// Original source is Copyright (C) 2024 Advanced Micro Devices, Inc. Licensed under the MIT license.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FidelityFX;

public enum ApiResourceState
{
    Common = (1 << 0),
    UnorderedAccess = (1 << 1),
    ComputeRead = (1 << 2),
    PixelRead = (1 << 3),
    PixelComputeRead = (PixelRead | ComputeRead),
    CopySrc = (1 << 4),
    CopyDest = (1 << 5),
    GenericRead = (CopySrc | ComputeRead),
    IndirectArgument = (1 << 6),
    Present = (1 << 7),
    RenderTarget = (1 << 8),
}
