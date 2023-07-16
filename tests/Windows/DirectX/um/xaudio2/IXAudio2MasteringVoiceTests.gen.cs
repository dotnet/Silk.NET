// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IXAudio2MasteringVoice"/> struct.</summary>
public static unsafe partial class IXAudio2MasteringVoiceTests
{
    /// <summary>Validates that the <see cref = "IXAudio2MasteringVoice"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IXAudio2MasteringVoice>(), Is.EqualTo(sizeof(IXAudio2MasteringVoice)));
    }

    /// <summary>Validates that the <see cref = "IXAudio2MasteringVoice"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IXAudio2MasteringVoice).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IXAudio2MasteringVoice"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IXAudio2MasteringVoice), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IXAudio2MasteringVoice), Is.EqualTo(4));
        }
    }
}