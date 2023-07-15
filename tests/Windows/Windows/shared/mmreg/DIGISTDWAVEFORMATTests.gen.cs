// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "DIGISTDWAVEFORMAT"/> struct.</summary>
public static unsafe partial class DIGISTDWAVEFORMATTests
{
    /// <summary>Validates that the <see cref = "DIGISTDWAVEFORMAT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DIGISTDWAVEFORMAT>(), Is.EqualTo(sizeof(DIGISTDWAVEFORMAT)));
    }

    /// <summary>Validates that the <see cref = "DIGISTDWAVEFORMAT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DIGISTDWAVEFORMAT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DIGISTDWAVEFORMAT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DIGISTDWAVEFORMAT), Is.EqualTo(18));
    }
}