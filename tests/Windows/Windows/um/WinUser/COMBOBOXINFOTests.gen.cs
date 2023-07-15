// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "COMBOBOXINFO"/> struct.</summary>
public static unsafe partial class COMBOBOXINFOTests
{
    /// <summary>Validates that the <see cref = "COMBOBOXINFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<COMBOBOXINFO>(), Is.EqualTo(sizeof(COMBOBOXINFO)));
    }

    /// <summary>Validates that the <see cref = "COMBOBOXINFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(COMBOBOXINFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "COMBOBOXINFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(COMBOBOXINFO), Is.EqualTo(64));
        }
        else
        {
            Assert.That(sizeof(COMBOBOXINFO), Is.EqualTo(52));
        }
    }
}