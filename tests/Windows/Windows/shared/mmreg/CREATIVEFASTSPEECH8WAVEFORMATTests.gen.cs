// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CREATIVEFASTSPEECH8WAVEFORMAT"/> struct.</summary>
public static unsafe partial class CREATIVEFASTSPEECH8WAVEFORMATTests
{
    /// <summary>Validates that the <see cref = "CREATIVEFASTSPEECH8WAVEFORMAT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CREATIVEFASTSPEECH8WAVEFORMAT>(), Is.EqualTo(sizeof(CREATIVEFASTSPEECH8WAVEFORMAT)));
    }

    /// <summary>Validates that the <see cref = "CREATIVEFASTSPEECH8WAVEFORMAT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CREATIVEFASTSPEECH8WAVEFORMAT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CREATIVEFASTSPEECH8WAVEFORMAT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(CREATIVEFASTSPEECH8WAVEFORMAT), Is.EqualTo(20));
    }
}