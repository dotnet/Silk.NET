// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SCHANNEL_CERT_HASH_STORE"/> struct.</summary>
public static unsafe partial class SCHANNEL_CERT_HASH_STORETests
{
    /// <summary>Validates that the <see cref = "SCHANNEL_CERT_HASH_STORE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SCHANNEL_CERT_HASH_STORE>(), Is.EqualTo(sizeof(SCHANNEL_CERT_HASH_STORE)));
    }

    /// <summary>Validates that the <see cref = "SCHANNEL_CERT_HASH_STORE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SCHANNEL_CERT_HASH_STORE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SCHANNEL_CERT_HASH_STORE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SCHANNEL_CERT_HASH_STORE), Is.EqualTo(296));
        }
        else
        {
            Assert.That(sizeof(SCHANNEL_CERT_HASH_STORE), Is.EqualTo(288));
        }
    }
}