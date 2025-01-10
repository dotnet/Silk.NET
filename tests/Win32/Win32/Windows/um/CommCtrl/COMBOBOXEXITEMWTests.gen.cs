// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "COMBOBOXEXITEMW"/> struct.</summary>
public static unsafe partial class COMBOBOXEXITEMWTests
{
    /// <summary>Validates that the <see cref = "COMBOBOXEXITEMW"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<COMBOBOXEXITEMW>(), Is.EqualTo(sizeof(COMBOBOXEXITEMW)));
    }

    /// <summary>Validates that the <see cref = "COMBOBOXEXITEMW"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(COMBOBOXEXITEMW).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "COMBOBOXEXITEMW"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(COMBOBOXEXITEMW), Is.EqualTo(56));
        }
        else
        {
            Assert.That(sizeof(COMBOBOXEXITEMW), Is.EqualTo(36));
        }
    }
}
