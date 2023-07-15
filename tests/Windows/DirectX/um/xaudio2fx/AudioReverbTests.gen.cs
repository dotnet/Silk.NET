// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2fx.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "AudioReverb"/> struct.</summary>
public static unsafe partial class AudioReverbTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "AudioReverb"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(AudioReverb).GUID, Is.EqualTo(CLSID_AudioReverb));
    }

    /// <summary>Validates that the <see cref = "AudioReverb"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AudioReverb>(), Is.EqualTo(sizeof(AudioReverb)));
    }

    /// <summary>Validates that the <see cref = "AudioReverb"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AudioReverb).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "AudioReverb"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AudioReverb), Is.EqualTo(1));
    }
}