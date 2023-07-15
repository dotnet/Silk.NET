// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleauto.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "INTERFACEDATA"/> struct.</summary>
public static unsafe partial class INTERFACEDATATests
{
    /// <summary>Validates that the <see cref = "INTERFACEDATA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<INTERFACEDATA>(), Is.EqualTo(sizeof(INTERFACEDATA)));
    }

    /// <summary>Validates that the <see cref = "INTERFACEDATA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(INTERFACEDATA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "INTERFACEDATA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(INTERFACEDATA), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(INTERFACEDATA), Is.EqualTo(8));
        }
    }
}