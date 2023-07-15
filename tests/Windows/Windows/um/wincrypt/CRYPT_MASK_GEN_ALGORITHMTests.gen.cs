// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CRYPT_MASK_GEN_ALGORITHM"/> struct.</summary>
public static unsafe partial class CRYPT_MASK_GEN_ALGORITHMTests
{
    /// <summary>Validates that the <see cref = "CRYPT_MASK_GEN_ALGORITHM"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CRYPT_MASK_GEN_ALGORITHM>(), Is.EqualTo(sizeof(CRYPT_MASK_GEN_ALGORITHM)));
    }

    /// <summary>Validates that the <see cref = "CRYPT_MASK_GEN_ALGORITHM"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CRYPT_MASK_GEN_ALGORITHM).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CRYPT_MASK_GEN_ALGORITHM"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CRYPT_MASK_GEN_ALGORITHM), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(CRYPT_MASK_GEN_ALGORITHM), Is.EqualTo(16));
        }
    }
}