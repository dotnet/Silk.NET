// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "SoundObstacleMaterialConfigBD"/> struct.</summary>
public static unsafe partial class XrSoundObstacleMaterialConfigBDTests
{
    /// <summary>Validates that the <see cref = "SoundObstacleMaterialConfigBD"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SoundObstacleMaterialConfigBD>(),
            Is.EqualTo(sizeof(SoundObstacleMaterialConfigBD))
        );
    }

    /// <summary>Validates that the <see cref = "SoundObstacleMaterialConfigBD"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SoundObstacleMaterialConfigBD).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SoundObstacleMaterialConfigBD"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SoundObstacleMaterialConfigBD), Is.EqualTo(56));
        }
        else
        {
            Assert.That(sizeof(SoundObstacleMaterialConfigBD), Is.EqualTo(32));
        }
    }
}
