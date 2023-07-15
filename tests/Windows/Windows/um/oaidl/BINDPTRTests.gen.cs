// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "BINDPTR"/> struct.</summary>
public static unsafe partial class BINDPTRTests
{
    /// <summary>Validates that the <see cref = "BINDPTR"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<BINDPTR>(), Is.EqualTo(sizeof(BINDPTR)));
    }

    /// <summary>Validates that the <see cref = "BINDPTR"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutExplicitTest()
    {
        Assert.That(typeof(BINDPTR).IsExplicitLayout, Is.True);
    }

    /// <summary>Validates that the <see cref = "BINDPTR"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(BINDPTR), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(BINDPTR), Is.EqualTo(4));
        }
    }
}