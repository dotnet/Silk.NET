// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from ffx-api and corresponding dependencies of FidelityFX.
// Original source is Copyright (C) 2024 Advanced Micro Devices, Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.FidelityFX.UnitTests;

/// <summary>Provides validation of the <see cref = "QueryDescUpscaleGetUpscaleRatioFromQualityMode"/> struct.</summary>
public static unsafe partial class ffxQueryDescUpscaleGetUpscaleRatioFromQualityModeTests
{
    /// <summary>Validates that the <see cref = "QueryDescUpscaleGetUpscaleRatioFromQualityMode"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<QueryDescUpscaleGetUpscaleRatioFromQualityMode>(),
            Is.EqualTo(sizeof(QueryDescUpscaleGetUpscaleRatioFromQualityMode))
        );
    }

    /// <summary>Validates that the <see cref = "QueryDescUpscaleGetUpscaleRatioFromQualityMode"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(
            typeof(QueryDescUpscaleGetUpscaleRatioFromQualityMode).IsLayoutSequential,
            Is.True
        );
    }

    /// <summary>Validates that the <see cref = "QueryDescUpscaleGetUpscaleRatioFromQualityMode"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(QueryDescUpscaleGetUpscaleRatioFromQualityMode), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(QueryDescUpscaleGetUpscaleRatioFromQualityMode), Is.EqualTo(24));
        }
    }
}
