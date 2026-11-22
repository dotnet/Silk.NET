// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "SpatialCapabilityConfigurationObjectTrackingANDROID"/> struct.</summary>
public static unsafe partial class XrSpatialCapabilityConfigurationObjectTrackingANDROIDTests
{
    /// <summary>Validates that the <see cref = "SpatialCapabilityConfigurationObjectTrackingANDROID"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SpatialCapabilityConfigurationObjectTrackingANDROID>(),
            Is.EqualTo(sizeof(SpatialCapabilityConfigurationObjectTrackingANDROID))
        );
    }

    /// <summary>Validates that the <see cref = "SpatialCapabilityConfigurationObjectTrackingANDROID"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(
            typeof(SpatialCapabilityConfigurationObjectTrackingANDROID).IsLayoutSequential,
            Is.True
        );
    }

    /// <summary>Validates that the <see cref = "SpatialCapabilityConfigurationObjectTrackingANDROID"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(
                sizeof(SpatialCapabilityConfigurationObjectTrackingANDROID),
                Is.EqualTo(48)
            );
        }
        else
        {
            Assert.That(
                sizeof(SpatialCapabilityConfigurationObjectTrackingANDROID),
                Is.EqualTo(28)
            );
        }
    }
}
