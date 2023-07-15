// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ITfKeystrokeMgr"/> struct.</summary>
public static unsafe partial class ITfKeystrokeMgrTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ITfKeystrokeMgr"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ITfKeystrokeMgr).GUID, Is.EqualTo(IID_ITfKeystrokeMgr));
    }

    /// <summary>Validates that the <see cref = "ITfKeystrokeMgr"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ITfKeystrokeMgr>(), Is.EqualTo(sizeof(ITfKeystrokeMgr)));
    }

    /// <summary>Validates that the <see cref = "ITfKeystrokeMgr"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ITfKeystrokeMgr).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ITfKeystrokeMgr"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ITfKeystrokeMgr), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ITfKeystrokeMgr), Is.EqualTo(4));
        }
    }
}