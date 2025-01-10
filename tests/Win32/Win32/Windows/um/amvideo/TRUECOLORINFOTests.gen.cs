// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "TRUECOLORINFO"/> struct.</summary>
public static unsafe partial class TRUECOLORINFOTests
{
    /// <summary>Validates that the <see cref = "TRUECOLORINFO"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TRUECOLORINFO>(), Is.EqualTo(sizeof(TRUECOLORINFO)));
    }

    /// <summary>Validates that the <see cref = "TRUECOLORINFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TRUECOLORINFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TRUECOLORINFO"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TRUECOLORINFO), Is.EqualTo(1036));
    }
}
