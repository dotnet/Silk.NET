// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CRYPT_PKCS12_PBE_PARAMS"/> struct.</summary>
public static unsafe partial class CRYPT_PKCS12_PBE_PARAMSTests
{
    /// <summary>Validates that the <see cref = "CRYPT_PKCS12_PBE_PARAMS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CRYPT_PKCS12_PBE_PARAMS>(), Is.EqualTo(sizeof(CRYPT_PKCS12_PBE_PARAMS)));
    }

    /// <summary>Validates that the <see cref = "CRYPT_PKCS12_PBE_PARAMS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CRYPT_PKCS12_PBE_PARAMS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CRYPT_PKCS12_PBE_PARAMS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(CRYPT_PKCS12_PBE_PARAMS), Is.EqualTo(8));
    }
}