// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdipluseffects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Gdiplus.UnitTests;
/// <summary>Provides validation of the <see cref = "ColorCurve"/> struct.</summary>
public static unsafe partial class ColorCurveTests
{
    /// <summary>Validates that the <see cref = "ColorCurve"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ColorCurve>(), Is.EqualTo(sizeof(ColorCurve)));
    }

    /// <summary>Validates that the <see cref = "ColorCurve"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ColorCurve).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ColorCurve"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ColorCurve), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(ColorCurve), Is.EqualTo(20));
        }
    }
}