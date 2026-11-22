// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "SpatialEntityComponentDataBoundingBox2DBD"/> struct.</summary>
public static unsafe partial class XrSpatialEntityComponentDataBoundingBox2DBDTests
{
    /// <summary>Validates that the <see cref = "SpatialEntityComponentDataBoundingBox2DBD"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SpatialEntityComponentDataBoundingBox2DBD>(),
            Is.EqualTo(sizeof(SpatialEntityComponentDataBoundingBox2DBD))
        );
    }

    /// <summary>Validates that the <see cref = "SpatialEntityComponentDataBoundingBox2DBD"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SpatialEntityComponentDataBoundingBox2DBD).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SpatialEntityComponentDataBoundingBox2DBD"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SpatialEntityComponentDataBoundingBox2DBD), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(SpatialEntityComponentDataBoundingBox2DBD), Is.EqualTo(24));
        }
    }
}
