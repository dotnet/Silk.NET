// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "SpatialComponentMesh3DListEXT"/> struct.</summary>
public static unsafe partial class XrSpatialComponentMesh3DListEXTTests
{
    /// <summary>Validates that the <see cref = "SpatialComponentMesh3DListEXT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SpatialComponentMesh3DListEXT>(),
            Is.EqualTo(sizeof(SpatialComponentMesh3DListEXT))
        );
    }

    /// <summary>Validates that the <see cref = "SpatialComponentMesh3DListEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SpatialComponentMesh3DListEXT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SpatialComponentMesh3DListEXT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SpatialComponentMesh3DListEXT), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(SpatialComponentMesh3DListEXT), Is.EqualTo(16));
        }
    }
}
