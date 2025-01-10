// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "EMRCREATECOLORSPACE"/> struct.</summary>
public static unsafe partial class EMRCREATECOLORSPACETests
{
    /// <summary>Validates that the <see cref = "EMRCREATECOLORSPACE"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<EMRCREATECOLORSPACE>(), Is.EqualTo(sizeof(EMRCREATECOLORSPACE)));
    }

    /// <summary>Validates that the <see cref = "EMRCREATECOLORSPACE"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EMRCREATECOLORSPACE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "EMRCREATECOLORSPACE"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(EMRCREATECOLORSPACE), Is.EqualTo(340));
    }
}
