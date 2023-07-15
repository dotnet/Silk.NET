// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "APPINFODATA"/> struct.</summary>
public static unsafe partial class APPINFODATATests
{
    /// <summary>Validates that the <see cref = "APPINFODATA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<APPINFODATA>(), Is.EqualTo(sizeof(APPINFODATA)));
    }

    /// <summary>Validates that the <see cref = "APPINFODATA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(APPINFODATA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "APPINFODATA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(APPINFODATA), Is.EqualTo(152));
        }
        else
        {
            Assert.That(sizeof(APPINFODATA), Is.EqualTo(80));
        }
    }
}