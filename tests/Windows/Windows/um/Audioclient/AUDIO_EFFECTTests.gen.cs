// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "AUDIO_EFFECT"/> struct.</summary>
[SupportedOSPlatform("windows10.0.22621.0")]
public static unsafe partial class AUDIO_EFFECTTests
{
    /// <summary>Validates that the <see cref = "AUDIO_EFFECT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AUDIO_EFFECT>(), Is.EqualTo(sizeof(AUDIO_EFFECT)));
    }

    /// <summary>Validates that the <see cref = "AUDIO_EFFECT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AUDIO_EFFECT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "AUDIO_EFFECT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AUDIO_EFFECT), Is.EqualTo(24));
    }
}