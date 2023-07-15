// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UserEnv.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "RSOP_TARGET"/> struct.</summary>
public static unsafe partial class RSOP_TARGETTests
{
    /// <summary>Validates that the <see cref = "RSOP_TARGET"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<RSOP_TARGET>(), Is.EqualTo(sizeof(RSOP_TARGET)));
    }

    /// <summary>Validates that the <see cref = "RSOP_TARGET"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(RSOP_TARGET).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "RSOP_TARGET"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(RSOP_TARGET), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(RSOP_TARGET), Is.EqualTo(24));
        }
    }
}