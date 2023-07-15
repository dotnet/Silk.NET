// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "AM_ExactRateChange"/> struct.</summary>
public static unsafe partial class AM_ExactRateChangeTests
{
    /// <summary>Validates that the <see cref = "AM_ExactRateChange"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AM_ExactRateChange>(), Is.EqualTo(sizeof(AM_ExactRateChange)));
    }

    /// <summary>Validates that the <see cref = "AM_ExactRateChange"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AM_ExactRateChange).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "AM_ExactRateChange"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AM_ExactRateChange), Is.EqualTo(16));
    }
}