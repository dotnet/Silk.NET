// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "REBARBANDINFOA"/> struct.</summary>
public static unsafe partial class REBARBANDINFOATests
{
    /// <summary>Validates that the <see cref = "REBARBANDINFOA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<REBARBANDINFOA>(), Is.EqualTo(sizeof(REBARBANDINFOA)));
    }

    /// <summary>Validates that the <see cref = "REBARBANDINFOA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(REBARBANDINFOA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "REBARBANDINFOA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(REBARBANDINFOA), Is.EqualTo(128));
        }
        else
        {
            Assert.That(sizeof(REBARBANDINFOA), Is.EqualTo(100));
        }
    }
}