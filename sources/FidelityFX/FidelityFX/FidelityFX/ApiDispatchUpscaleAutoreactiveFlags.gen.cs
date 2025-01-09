// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from ffx-api and corresponding dependencies of FidelityFX.
// Original source is Copyright (C) 2024 Advanced Micro Devices, Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.FidelityFX;

public enum ApiDispatchUpscaleAutoreactiveFlags
{
    ApplyTonemap = (1 << 0),
    ApplyInversetonemap = (1 << 1),
    ApplyThreshold = (1 << 2),
    UseComponentsMax = (1 << 3),
}
