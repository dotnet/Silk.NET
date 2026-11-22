// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "SceneMeshSnapshotCreateInfoANDROID"/> struct.</summary>
public static unsafe partial class XrSceneMeshSnapshotCreateInfoANDROIDTests
{
    /// <summary>Validates that the <see cref = "SceneMeshSnapshotCreateInfoANDROID"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SceneMeshSnapshotCreateInfoANDROID>(),
            Is.EqualTo(sizeof(SceneMeshSnapshotCreateInfoANDROID))
        );
    }

    /// <summary>Validates that the <see cref = "SceneMeshSnapshotCreateInfoANDROID"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SceneMeshSnapshotCreateInfoANDROID).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SceneMeshSnapshotCreateInfoANDROID"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SceneMeshSnapshotCreateInfoANDROID), Is.EqualTo(72));
        }
        else
        {
            Assert.That(sizeof(SceneMeshSnapshotCreateInfoANDROID), Is.EqualTo(64));
        }
    }
}
