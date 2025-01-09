// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from ffx-api and corresponding dependencies of FidelityFX.
// Original source is Copyright (C) 2024 Advanced Micro Devices, Inc. Licensed under the MIT license.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.FidelityFX.UnitTests;

/// <summary>Provides validation of the <see cref = "QueryDescFrameGenerationGetGPUMemoryUsage"/> struct.</summary>
public static unsafe partial class ffxQueryDescFrameGenerationGetGPUMemoryUsageTests
{
    /// <summary>Validates that the <see cref = "QueryDescFrameGenerationGetGPUMemoryUsage"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<QueryDescFrameGenerationGetGPUMemoryUsage>(),
            Is.EqualTo(sizeof(QueryDescFrameGenerationGetGPUMemoryUsage))
        );
    }

    /// <summary>Validates that the <see cref = "QueryDescFrameGenerationGetGPUMemoryUsage"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(QueryDescFrameGenerationGetGPUMemoryUsage).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "QueryDescFrameGenerationGetGPUMemoryUsage"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(QueryDescFrameGenerationGetGPUMemoryUsage), Is.EqualTo(24));
    }
}
