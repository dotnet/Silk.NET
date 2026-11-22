// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "SpatialComponentPlaneAlignmentListEXT"/> struct.</summary>
public static unsafe partial class XrSpatialComponentPlaneAlignmentListEXTTests
{
    /// <summary>Validates that the <see cref = "SpatialComponentPlaneAlignmentListEXT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SpatialComponentPlaneAlignmentListEXT>(),
            Is.EqualTo(sizeof(SpatialComponentPlaneAlignmentListEXT))
        );
    }

    /// <summary>Validates that the <see cref = "SpatialComponentPlaneAlignmentListEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SpatialComponentPlaneAlignmentListEXT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SpatialComponentPlaneAlignmentListEXT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SpatialComponentPlaneAlignmentListEXT), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(SpatialComponentPlaneAlignmentListEXT), Is.EqualTo(16));
        }
    }
}
