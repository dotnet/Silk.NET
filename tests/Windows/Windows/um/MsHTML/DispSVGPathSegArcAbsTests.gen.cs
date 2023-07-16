// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "DispSVGPathSegArcAbs"/> struct.</summary>
public static unsafe partial class DispSVGPathSegArcAbsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "DispSVGPathSegArcAbs"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(DispSVGPathSegArcAbs).GUID, Is.EqualTo(IID_DispSVGPathSegArcAbs));
    }

    /// <summary>Validates that the <see cref = "DispSVGPathSegArcAbs"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DispSVGPathSegArcAbs>(), Is.EqualTo(sizeof(DispSVGPathSegArcAbs)));
    }

    /// <summary>Validates that the <see cref = "DispSVGPathSegArcAbs"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DispSVGPathSegArcAbs).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DispSVGPathSegArcAbs"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DispSVGPathSegArcAbs), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(DispSVGPathSegArcAbs), Is.EqualTo(4));
        }
    }
}