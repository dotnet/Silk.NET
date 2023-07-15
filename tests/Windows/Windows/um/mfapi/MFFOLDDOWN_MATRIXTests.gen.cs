// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MFFOLDDOWN_MATRIX"/> struct.</summary>
public static unsafe partial class MFFOLDDOWN_MATRIXTests
{
    /// <summary>Validates that the <see cref = "MFFOLDDOWN_MATRIX"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MFFOLDDOWN_MATRIX>(), Is.EqualTo(sizeof(MFFOLDDOWN_MATRIX)));
    }

    /// <summary>Validates that the <see cref = "MFFOLDDOWN_MATRIX"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MFFOLDDOWN_MATRIX).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MFFOLDDOWN_MATRIX"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MFFOLDDOWN_MATRIX), Is.EqualTo(272));
    }
}