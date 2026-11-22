// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "Extent2Df"/> struct.</summary>
public static unsafe partial class XrExtent2DfTests
{
    /// <summary>Validates that the <see cref = "Extent2Df"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<Extent2Df>(), Is.EqualTo(sizeof(Extent2Df)));
    }

    /// <summary>Validates that the <see cref = "Extent2Df"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(Extent2Df).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "Extent2Df"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(Extent2Df), Is.EqualTo(8));
    }
}
