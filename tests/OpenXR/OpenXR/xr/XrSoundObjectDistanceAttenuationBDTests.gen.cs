// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "SoundObjectDistanceAttenuationBD"/> struct.</summary>
public static unsafe partial class XrSoundObjectDistanceAttenuationBDTests
{
    /// <summary>Validates that the <see cref = "SoundObjectDistanceAttenuationBD"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SoundObjectDistanceAttenuationBD>(),
            Is.EqualTo(sizeof(SoundObjectDistanceAttenuationBD))
        );
    }

    /// <summary>Validates that the <see cref = "SoundObjectDistanceAttenuationBD"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SoundObjectDistanceAttenuationBD).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SoundObjectDistanceAttenuationBD"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SoundObjectDistanceAttenuationBD), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(SoundObjectDistanceAttenuationBD), Is.EqualTo(32));
        }
    }
}
