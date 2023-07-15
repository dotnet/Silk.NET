// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "TF_LBBALLOONINFO"/> struct.</summary>
public static unsafe partial class TF_LBBALLOONINFOTests
{
    /// <summary>Validates that the <see cref = "TF_LBBALLOONINFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TF_LBBALLOONINFO>(), Is.EqualTo(sizeof(TF_LBBALLOONINFO)));
    }

    /// <summary>Validates that the <see cref = "TF_LBBALLOONINFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TF_LBBALLOONINFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TF_LBBALLOONINFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(TF_LBBALLOONINFO), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(TF_LBBALLOONINFO), Is.EqualTo(8));
        }
    }
}