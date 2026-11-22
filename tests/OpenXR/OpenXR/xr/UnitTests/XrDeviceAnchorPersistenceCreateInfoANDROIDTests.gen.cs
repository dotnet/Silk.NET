// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "DeviceAnchorPersistenceCreateInfoANDROID"/> struct.</summary>
public static unsafe partial class XrDeviceAnchorPersistenceCreateInfoANDROIDTests
{
    /// <summary>Validates that the <see cref = "DeviceAnchorPersistenceCreateInfoANDROID"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DeviceAnchorPersistenceCreateInfoANDROID>(),
            Is.EqualTo(sizeof(DeviceAnchorPersistenceCreateInfoANDROID))
        );
    }

    /// <summary>Validates that the <see cref = "DeviceAnchorPersistenceCreateInfoANDROID"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DeviceAnchorPersistenceCreateInfoANDROID).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DeviceAnchorPersistenceCreateInfoANDROID"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DeviceAnchorPersistenceCreateInfoANDROID), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(DeviceAnchorPersistenceCreateInfoANDROID), Is.EqualTo(8));
        }
    }
}
