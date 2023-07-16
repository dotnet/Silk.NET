// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "ID2D1TransformNode"/> struct.</summary>
public static unsafe partial class ID2D1TransformNodeTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ID2D1TransformNode"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ID2D1TransformNode).GUID, Is.EqualTo(IID_ID2D1TransformNode));
    }

    /// <summary>Validates that the <see cref = "ID2D1TransformNode"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ID2D1TransformNode>(), Is.EqualTo(sizeof(ID2D1TransformNode)));
    }

    /// <summary>Validates that the <see cref = "ID2D1TransformNode"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ID2D1TransformNode).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ID2D1TransformNode"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ID2D1TransformNode), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ID2D1TransformNode), Is.EqualTo(4));
        }
    }
}