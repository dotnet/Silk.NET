// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MEMORYSTATUS"/> struct.</summary>
public static unsafe partial class MEMORYSTATUSTests
{
    /// <summary>Validates that the <see cref = "MEMORYSTATUS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MEMORYSTATUS>(), Is.EqualTo(sizeof(MEMORYSTATUS)));
    }

    /// <summary>Validates that the <see cref = "MEMORYSTATUS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MEMORYSTATUS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MEMORYSTATUS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(MEMORYSTATUS), Is.EqualTo(56));
        }
        else
        {
            Assert.That(sizeof(MEMORYSTATUS), Is.EqualTo(32));
        }
    }
}