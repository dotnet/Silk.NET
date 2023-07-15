// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MFP_PLAYBACK_ENDED_EVENT"/> struct.</summary>
public static unsafe partial class MFP_PLAYBACK_ENDED_EVENTTests
{
    /// <summary>Validates that the <see cref = "MFP_PLAYBACK_ENDED_EVENT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MFP_PLAYBACK_ENDED_EVENT>(), Is.EqualTo(sizeof(MFP_PLAYBACK_ENDED_EVENT)));
    }

    /// <summary>Validates that the <see cref = "MFP_PLAYBACK_ENDED_EVENT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MFP_PLAYBACK_ENDED_EVENT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MFP_PLAYBACK_ENDED_EVENT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(MFP_PLAYBACK_ENDED_EVENT), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(MFP_PLAYBACK_ENDED_EVENT), Is.EqualTo(24));
        }
    }
}