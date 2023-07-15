// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MIDIHDR"/> struct.</summary>
public static unsafe partial class MIDIHDRTests
{
    /// <summary>Validates that the <see cref = "MIDIHDR"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MIDIHDR>(), Is.EqualTo(sizeof(MIDIHDR)));
    }

    /// <summary>Validates that the <see cref = "MIDIHDR"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MIDIHDR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MIDIHDR"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(MIDIHDR), Is.EqualTo(112));
        }
        else
        {
            Assert.That(sizeof(MIDIHDR), Is.EqualTo(64));
        }
    }
}