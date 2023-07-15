// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "ID2D1SvgAttribute"/> struct.</summary>
public static unsafe partial class ID2D1SvgAttributeTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ID2D1SvgAttribute"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ID2D1SvgAttribute).GUID, Is.EqualTo(IID_ID2D1SvgAttribute));
    }

    /// <summary>Validates that the <see cref = "ID2D1SvgAttribute"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ID2D1SvgAttribute>(), Is.EqualTo(sizeof(ID2D1SvgAttribute)));
    }

    /// <summary>Validates that the <see cref = "ID2D1SvgAttribute"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ID2D1SvgAttribute).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ID2D1SvgAttribute"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ID2D1SvgAttribute), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ID2D1SvgAttribute), Is.EqualTo(4));
        }
    }
}