// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "PassthroughLayerMeshANDROID"/> struct.</summary>
public static unsafe partial class XrPassthroughLayerMeshANDROIDTests
{
    /// <summary>Validates that the <see cref = "PassthroughLayerMeshANDROID"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<PassthroughLayerMeshANDROID>(),
            Is.EqualTo(sizeof(PassthroughLayerMeshANDROID))
        );
    }

    /// <summary>Validates that the <see cref = "PassthroughLayerMeshANDROID"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PassthroughLayerMeshANDROID).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PassthroughLayerMeshANDROID"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PassthroughLayerMeshANDROID), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(PassthroughLayerMeshANDROID), Is.EqualTo(28));
        }
    }
}
