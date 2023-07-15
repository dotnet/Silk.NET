// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ProfInfo.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "PROFILEINFOW"/> struct.</summary>
public static unsafe partial class PROFILEINFOWTests
{
    /// <summary>Validates that the <see cref = "PROFILEINFOW"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PROFILEINFOW>(), Is.EqualTo(sizeof(PROFILEINFOW)));
    }

    /// <summary>Validates that the <see cref = "PROFILEINFOW"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PROFILEINFOW).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PROFILEINFOW"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PROFILEINFOW), Is.EqualTo(56));
        }
        else
        {
            Assert.That(sizeof(PROFILEINFOW), Is.EqualTo(32));
        }
    }
}