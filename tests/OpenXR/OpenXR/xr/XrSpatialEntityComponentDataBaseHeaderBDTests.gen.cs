// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "SpatialEntityComponentDataBaseHeaderBD"/> struct.</summary>
public static unsafe partial class XrSpatialEntityComponentDataBaseHeaderBDTests
{
    /// <summary>Validates that the <see cref = "SpatialEntityComponentDataBaseHeaderBD"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SpatialEntityComponentDataBaseHeaderBD>(),
            Is.EqualTo(sizeof(SpatialEntityComponentDataBaseHeaderBD))
        );
    }

    /// <summary>Validates that the <see cref = "SpatialEntityComponentDataBaseHeaderBD"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SpatialEntityComponentDataBaseHeaderBD).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SpatialEntityComponentDataBaseHeaderBD"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SpatialEntityComponentDataBaseHeaderBD), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(SpatialEntityComponentDataBaseHeaderBD), Is.EqualTo(8));
        }
    }
}
