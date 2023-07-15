// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "AudioExtensionParams"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class AudioExtensionParamsTests
{
    /// <summary>Validates that the <see cref = "AudioExtensionParams"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AudioExtensionParams>(), Is.EqualTo(sizeof(AudioExtensionParams)));
    }

    /// <summary>Validates that the <see cref = "AudioExtensionParams"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AudioExtensionParams).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "AudioExtensionParams"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(AudioExtensionParams), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(AudioExtensionParams), Is.EqualTo(16));
        }
    }
}