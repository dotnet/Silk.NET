// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "OPENFILENAMEW"/> struct.</summary>
public static unsafe partial class OPENFILENAMEWTests
{
    /// <summary>Validates that the <see cref = "OPENFILENAMEW"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<OPENFILENAMEW>(), Is.EqualTo(sizeof(OPENFILENAMEW)));
    }

    /// <summary>Validates that the <see cref = "OPENFILENAMEW"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(OPENFILENAMEW).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "OPENFILENAMEW"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(OPENFILENAMEW), Is.EqualTo(152));
        }
        else
        {
            Assert.That(sizeof(OPENFILENAMEW), Is.EqualTo(88));
        }
    }
}