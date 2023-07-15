// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IXAudio2SubmixVoice"/> struct.</summary>
public static unsafe partial class IXAudio2SubmixVoiceTests
{
    /// <summary>Validates that the <see cref = "IXAudio2SubmixVoice"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IXAudio2SubmixVoice>(), Is.EqualTo(sizeof(IXAudio2SubmixVoice)));
    }

    /// <summary>Validates that the <see cref = "IXAudio2SubmixVoice"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IXAudio2SubmixVoice).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IXAudio2SubmixVoice"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IXAudio2SubmixVoice), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IXAudio2SubmixVoice), Is.EqualTo(4));
        }
    }
}