// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "WMAUDIO2WAVEFORMAT"/> struct.</summary>
public static unsafe partial class WMAUDIO2WAVEFORMATTests
{
    /// <summary>Validates that the <see cref = "WMAUDIO2WAVEFORMAT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WMAUDIO2WAVEFORMAT>(), Is.EqualTo(sizeof(WMAUDIO2WAVEFORMAT)));
    }

    /// <summary>Validates that the <see cref = "WMAUDIO2WAVEFORMAT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WMAUDIO2WAVEFORMAT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WMAUDIO2WAVEFORMAT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WMAUDIO2WAVEFORMAT), Is.EqualTo(28));
    }
}