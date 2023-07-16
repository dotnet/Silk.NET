// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "NMLVDISPINFOA"/> struct.</summary>
public static unsafe partial class NMLVDISPINFOATests
{
    /// <summary>Validates that the <see cref = "NMLVDISPINFOA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<NMLVDISPINFOA>(), Is.EqualTo(sizeof(NMLVDISPINFOA)));
    }

    /// <summary>Validates that the <see cref = "NMLVDISPINFOA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(NMLVDISPINFOA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "NMLVDISPINFOA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(NMLVDISPINFOA), Is.EqualTo(112));
        }
        else
        {
            Assert.That(sizeof(NMLVDISPINFOA), Is.EqualTo(72));
        }
    }
}