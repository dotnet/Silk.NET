// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "FoveationProfileCreateInfoFB"/> struct.</summary>
public static unsafe partial class XrFoveationProfileCreateInfoFBTests
{
    /// <summary>Validates that the <see cref = "FoveationProfileCreateInfoFB"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<FoveationProfileCreateInfoFB>(),
            Is.EqualTo(sizeof(FoveationProfileCreateInfoFB))
        );
    }

    /// <summary>Validates that the <see cref = "FoveationProfileCreateInfoFB"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FoveationProfileCreateInfoFB).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "FoveationProfileCreateInfoFB"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(FoveationProfileCreateInfoFB), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(FoveationProfileCreateInfoFB), Is.EqualTo(8));
        }
    }
}
