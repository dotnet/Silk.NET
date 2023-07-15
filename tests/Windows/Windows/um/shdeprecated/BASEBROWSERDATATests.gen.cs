// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "BASEBROWSERDATA"/> struct.</summary>
public static unsafe partial class BASEBROWSERDATATests
{
    /// <summary>Validates that the <see cref = "BASEBROWSERDATA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<BASEBROWSERDATA>(), Is.EqualTo(sizeof(BASEBROWSERDATA)));
    }

    /// <summary>Validates that the <see cref = "BASEBROWSERDATA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(BASEBROWSERDATA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "BASEBROWSERDATA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(BASEBROWSERDATA), Is.EqualTo(216));
        }
        else
        {
            Assert.That(sizeof(BASEBROWSERDATA), Is.EqualTo(132));
        }
    }
}