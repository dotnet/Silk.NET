// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CAT_MEMBERINFO"/> struct.</summary>
public static unsafe partial class CAT_MEMBERINFOTests
{
    /// <summary>Validates that the <see cref = "CAT_MEMBERINFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CAT_MEMBERINFO>(), Is.EqualTo(sizeof(CAT_MEMBERINFO)));
    }

    /// <summary>Validates that the <see cref = "CAT_MEMBERINFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CAT_MEMBERINFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CAT_MEMBERINFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CAT_MEMBERINFO), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(CAT_MEMBERINFO), Is.EqualTo(8));
        }
    }
}