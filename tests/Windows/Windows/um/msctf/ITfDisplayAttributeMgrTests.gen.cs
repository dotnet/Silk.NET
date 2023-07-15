// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ITfDisplayAttributeMgr"/> struct.</summary>
public static unsafe partial class ITfDisplayAttributeMgrTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ITfDisplayAttributeMgr"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ITfDisplayAttributeMgr).GUID, Is.EqualTo(IID_ITfDisplayAttributeMgr));
    }

    /// <summary>Validates that the <see cref = "ITfDisplayAttributeMgr"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ITfDisplayAttributeMgr>(), Is.EqualTo(sizeof(ITfDisplayAttributeMgr)));
    }

    /// <summary>Validates that the <see cref = "ITfDisplayAttributeMgr"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ITfDisplayAttributeMgr).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ITfDisplayAttributeMgr"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ITfDisplayAttributeMgr), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ITfDisplayAttributeMgr), Is.EqualTo(4));
        }
    }
}