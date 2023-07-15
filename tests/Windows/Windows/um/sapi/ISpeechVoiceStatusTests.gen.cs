// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ISpeechVoiceStatus"/> struct.</summary>
public static unsafe partial class ISpeechVoiceStatusTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ISpeechVoiceStatus"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISpeechVoiceStatus).GUID, Is.EqualTo(IID_ISpeechVoiceStatus));
    }

    /// <summary>Validates that the <see cref = "ISpeechVoiceStatus"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISpeechVoiceStatus>(), Is.EqualTo(sizeof(ISpeechVoiceStatus)));
    }

    /// <summary>Validates that the <see cref = "ISpeechVoiceStatus"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISpeechVoiceStatus).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ISpeechVoiceStatus"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISpeechVoiceStatus), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISpeechVoiceStatus), Is.EqualTo(4));
        }
    }
}