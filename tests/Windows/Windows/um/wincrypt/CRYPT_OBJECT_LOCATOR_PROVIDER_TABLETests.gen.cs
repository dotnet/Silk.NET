// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CRYPT_OBJECT_LOCATOR_PROVIDER_TABLE"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class CRYPT_OBJECT_LOCATOR_PROVIDER_TABLETests
{
    /// <summary>Validates that the <see cref = "CRYPT_OBJECT_LOCATOR_PROVIDER_TABLE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CRYPT_OBJECT_LOCATOR_PROVIDER_TABLE>(), Is.EqualTo(sizeof(CRYPT_OBJECT_LOCATOR_PROVIDER_TABLE)));
    }

    /// <summary>Validates that the <see cref = "CRYPT_OBJECT_LOCATOR_PROVIDER_TABLE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CRYPT_OBJECT_LOCATOR_PROVIDER_TABLE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CRYPT_OBJECT_LOCATOR_PROVIDER_TABLE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CRYPT_OBJECT_LOCATOR_PROVIDER_TABLE), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(CRYPT_OBJECT_LOCATOR_PROVIDER_TABLE), Is.EqualTo(24));
        }
    }
}