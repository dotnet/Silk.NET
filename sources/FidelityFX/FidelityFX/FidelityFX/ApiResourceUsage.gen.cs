// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from ffx-api and corresponding dependencies of FidelityFX.
// Original source is Copyright (C) 2024 Advanced Micro Devices, Inc. Licensed under the MIT license.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FidelityFX;

public enum ApiResourceUsage
{
    ReadOnly = 0,
    Rendertarget = (1 << 0),
    Uav = (1 << 1),
    Depthtarget = (1 << 2),
    Indirect = (1 << 3),
    Arrayview = (1 << 4),
    Stenciltarget = (1 << 5),
}
