// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "ID2D1RectangleGeometry"/> struct.</summary>
public static unsafe partial class ID2D1RectangleGeometryTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ID2D1RectangleGeometry"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ID2D1RectangleGeometry).GUID, Is.EqualTo(IID_ID2D1RectangleGeometry));
    }

    /// <summary>Validates that the <see cref = "ID2D1RectangleGeometry"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ID2D1RectangleGeometry>(), Is.EqualTo(sizeof(ID2D1RectangleGeometry)));
    }

    /// <summary>Validates that the <see cref = "ID2D1RectangleGeometry"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ID2D1RectangleGeometry).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ID2D1RectangleGeometry"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ID2D1RectangleGeometry), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ID2D1RectangleGeometry), Is.EqualTo(4));
        }
    }
}