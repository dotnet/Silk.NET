// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "KeyboardTrackingDescriptionFB"/> struct.</summary>
public static unsafe partial class XrKeyboardTrackingDescriptionFBTests
{
    /// <summary>Validates that the <see cref = "KeyboardTrackingDescriptionFB"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<KeyboardTrackingDescriptionFB>(),
            Is.EqualTo(sizeof(KeyboardTrackingDescriptionFB))
        );
    }

    /// <summary>Validates that the <see cref = "KeyboardTrackingDescriptionFB"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(KeyboardTrackingDescriptionFB).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "KeyboardTrackingDescriptionFB"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(KeyboardTrackingDescriptionFB), Is.EqualTo(160));
    }
}
