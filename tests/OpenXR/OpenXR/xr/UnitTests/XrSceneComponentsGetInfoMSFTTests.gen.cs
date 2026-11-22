// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "SceneComponentsGetInfoMSFT"/> struct.</summary>
public static unsafe partial class XrSceneComponentsGetInfoMSFTTests
{
    /// <summary>Validates that the <see cref = "SceneComponentsGetInfoMSFT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SceneComponentsGetInfoMSFT>(),
            Is.EqualTo(sizeof(SceneComponentsGetInfoMSFT))
        );
    }

    /// <summary>Validates that the <see cref = "SceneComponentsGetInfoMSFT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SceneComponentsGetInfoMSFT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SceneComponentsGetInfoMSFT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SceneComponentsGetInfoMSFT), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(SceneComponentsGetInfoMSFT), Is.EqualTo(12));
        }
    }
}
