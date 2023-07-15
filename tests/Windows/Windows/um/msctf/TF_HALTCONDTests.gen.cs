// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "TF_HALTCOND"/> struct.</summary>
public static unsafe partial class TF_HALTCONDTests
{
    /// <summary>Validates that the <see cref = "TF_HALTCOND"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TF_HALTCOND>(), Is.EqualTo(sizeof(TF_HALTCOND)));
    }

    /// <summary>Validates that the <see cref = "TF_HALTCOND"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TF_HALTCOND).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TF_HALTCOND"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(TF_HALTCOND), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(TF_HALTCOND), Is.EqualTo(12));
        }
    }
}