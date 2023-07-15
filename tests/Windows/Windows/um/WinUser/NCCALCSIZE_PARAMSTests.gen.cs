// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "NCCALCSIZE_PARAMS"/> struct.</summary>
public static unsafe partial class NCCALCSIZE_PARAMSTests
{
    /// <summary>Validates that the <see cref = "NCCALCSIZE_PARAMS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<NCCALCSIZE_PARAMS>(), Is.EqualTo(sizeof(NCCALCSIZE_PARAMS)));
    }

    /// <summary>Validates that the <see cref = "NCCALCSIZE_PARAMS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(NCCALCSIZE_PARAMS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "NCCALCSIZE_PARAMS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(NCCALCSIZE_PARAMS), Is.EqualTo(56));
        }
        else
        {
            Assert.That(sizeof(NCCALCSIZE_PARAMS), Is.EqualTo(52));
        }
    }
}