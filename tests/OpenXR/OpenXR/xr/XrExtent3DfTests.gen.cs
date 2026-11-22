// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "Extent3Df"/> struct.</summary>
public static unsafe partial class XrExtent3DfTests
{
    /// <summary>Validates that the <see cref = "Extent3Df"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<Extent3Df>(), Is.EqualTo(sizeof(Extent3Df)));
    }

    /// <summary>Validates that the <see cref = "Extent3Df"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(Extent3Df).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "Extent3Df"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(Extent3Df), Is.EqualTo(12));
    }
}
