// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "REGISTERWORDW"/> struct.</summary>
public static unsafe partial class REGISTERWORDWTests
{
    /// <summary>Validates that the <see cref = "REGISTERWORDW"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<REGISTERWORDW>(), Is.EqualTo(sizeof(REGISTERWORDW)));
    }

    /// <summary>Validates that the <see cref = "REGISTERWORDW"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(REGISTERWORDW).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "REGISTERWORDW"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(REGISTERWORDW), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(REGISTERWORDW), Is.EqualTo(8));
        }
    }
}