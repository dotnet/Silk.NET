// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SYNCMGRITEM"/> struct.</summary>
public static unsafe partial class SYNCMGRITEMTests
{
    /// <summary>Validates that the <see cref = "SYNCMGRITEM"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SYNCMGRITEM>(), Is.EqualTo(sizeof(SYNCMGRITEM)));
    }

    /// <summary>Validates that the <see cref = "SYNCMGRITEM"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SYNCMGRITEM).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SYNCMGRITEM"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SYNCMGRITEM), Is.EqualTo(304));
        }
        else
        {
            Assert.That(sizeof(SYNCMGRITEM), Is.EqualTo(296));
        }
    }
}