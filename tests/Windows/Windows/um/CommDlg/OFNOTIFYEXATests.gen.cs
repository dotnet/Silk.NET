// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "OFNOTIFYEXA"/> struct.</summary>
public static unsafe partial class OFNOTIFYEXATests
{
    /// <summary>Validates that the <see cref = "OFNOTIFYEXA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<OFNOTIFYEXA>(), Is.EqualTo(sizeof(OFNOTIFYEXA)));
    }

    /// <summary>Validates that the <see cref = "OFNOTIFYEXA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(OFNOTIFYEXA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "OFNOTIFYEXA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(OFNOTIFYEXA), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(OFNOTIFYEXA), Is.EqualTo(24));
        }
    }
}