// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "EMRSCALEVIEWPORTEXTEX"/> struct.</summary>
public static unsafe partial class EMRSCALEVIEWPORTEXTEXTests
{
    /// <summary>Validates that the <see cref = "EMRSCALEVIEWPORTEXTEX"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<EMRSCALEVIEWPORTEXTEX>(), Is.EqualTo(sizeof(EMRSCALEVIEWPORTEXTEX)));
    }

    /// <summary>Validates that the <see cref = "EMRSCALEVIEWPORTEXTEX"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EMRSCALEVIEWPORTEXTEX).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "EMRSCALEVIEWPORTEXTEX"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(EMRSCALEVIEWPORTEXTEX), Is.EqualTo(24));
    }
}