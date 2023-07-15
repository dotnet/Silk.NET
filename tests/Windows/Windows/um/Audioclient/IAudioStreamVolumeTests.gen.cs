// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IAudioStreamVolume"/> struct.</summary>
public static unsafe partial class IAudioStreamVolumeTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IAudioStreamVolume"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IAudioStreamVolume).GUID, Is.EqualTo(IID_IAudioStreamVolume));
    }

    /// <summary>Validates that the <see cref = "IAudioStreamVolume"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IAudioStreamVolume>(), Is.EqualTo(sizeof(IAudioStreamVolume)));
    }

    /// <summary>Validates that the <see cref = "IAudioStreamVolume"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IAudioStreamVolume).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IAudioStreamVolume"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IAudioStreamVolume), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IAudioStreamVolume), Is.EqualTo(4));
        }
    }
}