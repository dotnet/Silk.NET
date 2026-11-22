// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "HandTrackingAimStateFB"/> struct.</summary>
public static unsafe partial class XrHandTrackingAimStateFBTests
{
    /// <summary>Validates that the <see cref = "HandTrackingAimStateFB"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<HandTrackingAimStateFB>(),
            Is.EqualTo(sizeof(HandTrackingAimStateFB))
        );
    }

    /// <summary>Validates that the <see cref = "HandTrackingAimStateFB"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HandTrackingAimStateFB).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HandTrackingAimStateFB"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(HandTrackingAimStateFB), Is.EqualTo(72));
        }
        else
        {
            Assert.That(sizeof(HandTrackingAimStateFB), Is.EqualTo(64));
        }
    }
}
