// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ACTCTXW"/> struct.</summary>
public static unsafe partial class ACTCTXWTests
{
    /// <summary>Validates that the <see cref = "ACTCTXW"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ACTCTXW>(), Is.EqualTo(sizeof(ACTCTXW)));
    }

    /// <summary>Validates that the <see cref = "ACTCTXW"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ACTCTXW).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ACTCTXW"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ACTCTXW), Is.EqualTo(56));
        }
        else
        {
            Assert.That(sizeof(ACTCTXW), Is.EqualTo(32));
        }
    }
}