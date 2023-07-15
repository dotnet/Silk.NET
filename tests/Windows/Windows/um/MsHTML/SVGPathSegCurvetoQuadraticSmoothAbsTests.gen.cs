// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SVGPathSegCurvetoQuadraticSmoothAbs"/> struct.</summary>
public static unsafe partial class SVGPathSegCurvetoQuadraticSmoothAbsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "SVGPathSegCurvetoQuadraticSmoothAbs"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(SVGPathSegCurvetoQuadraticSmoothAbs).GUID, Is.EqualTo(IID_SVGPathSegCurvetoQuadraticSmoothAbs));
    }

    /// <summary>Validates that the <see cref = "SVGPathSegCurvetoQuadraticSmoothAbs"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SVGPathSegCurvetoQuadraticSmoothAbs>(), Is.EqualTo(sizeof(SVGPathSegCurvetoQuadraticSmoothAbs)));
    }

    /// <summary>Validates that the <see cref = "SVGPathSegCurvetoQuadraticSmoothAbs"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SVGPathSegCurvetoQuadraticSmoothAbs).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SVGPathSegCurvetoQuadraticSmoothAbs"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SVGPathSegCurvetoQuadraticSmoothAbs), Is.EqualTo(1));
    }
}