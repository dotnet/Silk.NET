// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "PKCS12_PBES2_EXPORT_PARAMS"/> struct.</summary>
public static unsafe partial class PKCS12_PBES2_EXPORT_PARAMSTests
{
    /// <summary>Validates that the <see cref = "PKCS12_PBES2_EXPORT_PARAMS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PKCS12_PBES2_EXPORT_PARAMS>(), Is.EqualTo(sizeof(PKCS12_PBES2_EXPORT_PARAMS)));
    }

    /// <summary>Validates that the <see cref = "PKCS12_PBES2_EXPORT_PARAMS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PKCS12_PBES2_EXPORT_PARAMS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PKCS12_PBES2_EXPORT_PARAMS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PKCS12_PBES2_EXPORT_PARAMS), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(PKCS12_PBES2_EXPORT_PARAMS), Is.EqualTo(12));
        }
    }
}