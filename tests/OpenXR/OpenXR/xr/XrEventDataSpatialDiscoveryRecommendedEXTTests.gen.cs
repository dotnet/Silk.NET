// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "EventDataSpatialDiscoveryRecommendedEXT"/> struct.</summary>
public static unsafe partial class XrEventDataSpatialDiscoveryRecommendedEXTTests
{
    /// <summary>Validates that the <see cref = "EventDataSpatialDiscoveryRecommendedEXT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<EventDataSpatialDiscoveryRecommendedEXT>(),
            Is.EqualTo(sizeof(EventDataSpatialDiscoveryRecommendedEXT))
        );
    }

    /// <summary>Validates that the <see cref = "EventDataSpatialDiscoveryRecommendedEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EventDataSpatialDiscoveryRecommendedEXT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "EventDataSpatialDiscoveryRecommendedEXT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(EventDataSpatialDiscoveryRecommendedEXT), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(EventDataSpatialDiscoveryRecommendedEXT), Is.EqualTo(12));
        }
    }
}
