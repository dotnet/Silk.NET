// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SVGPatternElement"/> struct.</summary>
public static unsafe partial class SVGPatternElementTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "SVGPatternElement"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(SVGPatternElement).GUID, Is.EqualTo(IID_SVGPatternElement));
    }

    /// <summary>Validates that the <see cref = "SVGPatternElement"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SVGPatternElement>(), Is.EqualTo(sizeof(SVGPatternElement)));
    }

    /// <summary>Validates that the <see cref = "SVGPatternElement"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SVGPatternElement).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SVGPatternElement"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SVGPatternElement), Is.EqualTo(1));
    }
}