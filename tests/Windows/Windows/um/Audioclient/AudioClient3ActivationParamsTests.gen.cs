// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "AudioClient3ActivationParams"/> struct.</summary>
public static unsafe partial class AudioClient3ActivationParamsTests
{
    /// <summary>Validates that the <see cref = "AudioClient3ActivationParams"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AudioClient3ActivationParams>(), Is.EqualTo(sizeof(AudioClient3ActivationParams)));
    }

    /// <summary>Validates that the <see cref = "AudioClient3ActivationParams"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AudioClient3ActivationParams).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "AudioClient3ActivationParams"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AudioClient3ActivationParams), Is.EqualTo(16));
    }
}