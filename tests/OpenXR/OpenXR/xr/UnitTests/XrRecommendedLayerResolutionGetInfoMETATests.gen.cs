// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "RecommendedLayerResolutionGetInfoMETA"/> struct.</summary>
public static unsafe partial class XrRecommendedLayerResolutionGetInfoMETATests
{
    /// <summary>Validates that the <see cref = "RecommendedLayerResolutionGetInfoMETA"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<RecommendedLayerResolutionGetInfoMETA>(),
            Is.EqualTo(sizeof(RecommendedLayerResolutionGetInfoMETA))
        );
    }

    /// <summary>Validates that the <see cref = "RecommendedLayerResolutionGetInfoMETA"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(RecommendedLayerResolutionGetInfoMETA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "RecommendedLayerResolutionGetInfoMETA"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(RecommendedLayerResolutionGetInfoMETA), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(RecommendedLayerResolutionGetInfoMETA), Is.EqualTo(24));
        }
    }
}
