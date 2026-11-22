// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "CompositionLayerCylinderKHR"/> struct.</summary>
public static unsafe partial class XrCompositionLayerCylinderKHRTests
{
    /// <summary>Validates that the <see cref = "CompositionLayerCylinderKHR"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<CompositionLayerCylinderKHR>(),
            Is.EqualTo(sizeof(CompositionLayerCylinderKHR))
        );
    }

    /// <summary>Validates that the <see cref = "CompositionLayerCylinderKHR"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CompositionLayerCylinderKHR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CompositionLayerCylinderKHR"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CompositionLayerCylinderKHR), Is.EqualTo(112));
        }
        else
        {
            Assert.That(sizeof(CompositionLayerCylinderKHR), Is.EqualTo(88));
        }
    }
}
