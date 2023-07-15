// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SIERRAADPCMWAVEFORMAT"/> struct.</summary>
public static unsafe partial class SIERRAADPCMWAVEFORMATTests
{
    /// <summary>Validates that the <see cref = "SIERRAADPCMWAVEFORMAT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SIERRAADPCMWAVEFORMAT>(), Is.EqualTo(sizeof(SIERRAADPCMWAVEFORMAT)));
    }

    /// <summary>Validates that the <see cref = "SIERRAADPCMWAVEFORMAT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SIERRAADPCMWAVEFORMAT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SIERRAADPCMWAVEFORMAT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SIERRAADPCMWAVEFORMAT), Is.EqualTo(20));
    }
}