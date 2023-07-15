// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "EXPLICIT_ACCESS_A"/> struct.</summary>
public static unsafe partial class EXPLICIT_ACCESS_ATests
{
    /// <summary>Validates that the <see cref = "EXPLICIT_ACCESS_A"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<EXPLICIT_ACCESS_A>(), Is.EqualTo(sizeof(EXPLICIT_ACCESS_A)));
    }

    /// <summary>Validates that the <see cref = "EXPLICIT_ACCESS_A"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EXPLICIT_ACCESS_A).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "EXPLICIT_ACCESS_A"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(EXPLICIT_ACCESS_A), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(EXPLICIT_ACCESS_A), Is.EqualTo(32));
        }
    }
}