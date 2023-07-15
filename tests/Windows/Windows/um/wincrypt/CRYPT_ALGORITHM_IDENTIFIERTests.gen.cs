// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CRYPT_ALGORITHM_IDENTIFIER"/> struct.</summary>
public static unsafe partial class CRYPT_ALGORITHM_IDENTIFIERTests
{
    /// <summary>Validates that the <see cref = "CRYPT_ALGORITHM_IDENTIFIER"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CRYPT_ALGORITHM_IDENTIFIER>(), Is.EqualTo(sizeof(CRYPT_ALGORITHM_IDENTIFIER)));
    }

    /// <summary>Validates that the <see cref = "CRYPT_ALGORITHM_IDENTIFIER"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CRYPT_ALGORITHM_IDENTIFIER).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CRYPT_ALGORITHM_IDENTIFIER"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CRYPT_ALGORITHM_IDENTIFIER), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(CRYPT_ALGORITHM_IDENTIFIER), Is.EqualTo(12));
        }
    }
}