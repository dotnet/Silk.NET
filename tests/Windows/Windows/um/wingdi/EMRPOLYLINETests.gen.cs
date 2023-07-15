// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "EMRPOLYLINE"/> struct.</summary>
public static unsafe partial class EMRPOLYLINETests
{
    /// <summary>Validates that the <see cref = "EMRPOLYLINE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<EMRPOLYLINE>(), Is.EqualTo(sizeof(EMRPOLYLINE)));
    }

    /// <summary>Validates that the <see cref = "EMRPOLYLINE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EMRPOLYLINE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "EMRPOLYLINE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(EMRPOLYLINE), Is.EqualTo(36));
    }
}