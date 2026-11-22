// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "SpatialDiscoveryPersistenceUuidFilterEXT"/> struct.</summary>
public static unsafe partial class XrSpatialDiscoveryPersistenceUuidFilterEXTTests
{
    /// <summary>Validates that the <see cref = "SpatialDiscoveryPersistenceUuidFilterEXT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SpatialDiscoveryPersistenceUuidFilterEXT>(),
            Is.EqualTo(sizeof(SpatialDiscoveryPersistenceUuidFilterEXT))
        );
    }

    /// <summary>Validates that the <see cref = "SpatialDiscoveryPersistenceUuidFilterEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SpatialDiscoveryPersistenceUuidFilterEXT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SpatialDiscoveryPersistenceUuidFilterEXT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SpatialDiscoveryPersistenceUuidFilterEXT), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(SpatialDiscoveryPersistenceUuidFilterEXT), Is.EqualTo(16));
        }
    }
}
