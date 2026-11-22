// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "SceneObjectMSFT"/> struct.</summary>
public static unsafe partial class XrSceneObjectMSFTTests
{
    /// <summary>Validates that the <see cref = "SceneObjectMSFT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SceneObjectMSFT>(), Is.EqualTo(sizeof(SceneObjectMSFT)));
    }

    /// <summary>Validates that the <see cref = "SceneObjectMSFT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SceneObjectMSFT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SceneObjectMSFT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SceneObjectMSFT), Is.EqualTo(4));
    }
}
