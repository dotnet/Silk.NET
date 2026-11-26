// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "ScenePlaneMSFT"/> struct.</summary>
public static unsafe partial class XrScenePlaneMSFTTests
{
    /// <summary>Validates that the <see cref = "ScenePlaneMSFT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ScenePlaneMSFT>(), Is.EqualTo(sizeof(ScenePlaneMSFT)));
    }

    /// <summary>Validates that the <see cref = "ScenePlaneMSFT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ScenePlaneMSFT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ScenePlaneMSFT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ScenePlaneMSFT), Is.EqualTo(32));
    }
}
