// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from ffx-api and corresponding dependencies of FidelityFX.
// Original source is Copyright (C) 2024 Advanced Micro Devices, Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.FidelityFX;

public partial struct ApiEffectMemoryUsage
{
    [NativeTypeName("uint64_t")]
    public ulong TotalUsageInBytes;

    [NativeTypeName("uint64_t")]
    public ulong AliasableUsageInBytes;
}
