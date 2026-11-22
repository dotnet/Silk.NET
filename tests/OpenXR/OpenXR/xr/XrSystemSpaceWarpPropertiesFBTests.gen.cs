// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "SystemSpaceWarpPropertiesFB"/> struct.</summary>
public static unsafe partial class XrSystemSpaceWarpPropertiesFBTests
{
    /// <summary>Validates that the <see cref = "SystemSpaceWarpPropertiesFB"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SystemSpaceWarpPropertiesFB>(),
            Is.EqualTo(sizeof(SystemSpaceWarpPropertiesFB))
        );
    }

    /// <summary>Validates that the <see cref = "SystemSpaceWarpPropertiesFB"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SystemSpaceWarpPropertiesFB).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SystemSpaceWarpPropertiesFB"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SystemSpaceWarpPropertiesFB), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(SystemSpaceWarpPropertiesFB), Is.EqualTo(16));
        }
    }
}
