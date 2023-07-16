// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdipluseffects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Gdiplus.UnitTests;
/// <summary>Provides validation of the <see cref = "ColorCurveParams"/> struct.</summary>
public static unsafe partial class ColorCurveParamsTests
{
    /// <summary>Validates that the <see cref = "ColorCurveParams"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ColorCurveParams>(), Is.EqualTo(sizeof(ColorCurveParams)));
    }

    /// <summary>Validates that the <see cref = "ColorCurveParams"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ColorCurveParams).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ColorCurveParams"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ColorCurveParams), Is.EqualTo(12));
    }
}