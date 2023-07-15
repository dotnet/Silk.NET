// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "NMTVDISPINFOEXW"/> struct.</summary>
public static unsafe partial class NMTVDISPINFOEXWTests
{
    /// <summary>Validates that the <see cref = "NMTVDISPINFOEXW"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<NMTVDISPINFOEXW>(), Is.EqualTo(sizeof(NMTVDISPINFOEXW)));
    }

    /// <summary>Validates that the <see cref = "NMTVDISPINFOEXW"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(NMTVDISPINFOEXW).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "NMTVDISPINFOEXW"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(NMTVDISPINFOEXW), Is.EqualTo(104));
        }
        else
        {
            Assert.That(sizeof(NMTVDISPINFOEXW), Is.EqualTo(72));
        }
    }
}