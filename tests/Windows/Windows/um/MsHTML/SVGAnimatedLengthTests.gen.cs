// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SVGAnimatedLength"/> struct.</summary>
public static unsafe partial class SVGAnimatedLengthTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "SVGAnimatedLength"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(SVGAnimatedLength).GUID, Is.EqualTo(IID_SVGAnimatedLength));
    }

    /// <summary>Validates that the <see cref = "SVGAnimatedLength"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SVGAnimatedLength>(), Is.EqualTo(sizeof(SVGAnimatedLength)));
    }

    /// <summary>Validates that the <see cref = "SVGAnimatedLength"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SVGAnimatedLength).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SVGAnimatedLength"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SVGAnimatedLength), Is.EqualTo(1));
    }
}