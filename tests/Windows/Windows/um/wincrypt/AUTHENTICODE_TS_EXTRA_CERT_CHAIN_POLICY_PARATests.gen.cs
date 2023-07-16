// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "AUTHENTICODE_TS_EXTRA_CERT_CHAIN_POLICY_PARA"/> struct.</summary>
public static unsafe partial class AUTHENTICODE_TS_EXTRA_CERT_CHAIN_POLICY_PARATests
{
    /// <summary>Validates that the <see cref = "AUTHENTICODE_TS_EXTRA_CERT_CHAIN_POLICY_PARA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AUTHENTICODE_TS_EXTRA_CERT_CHAIN_POLICY_PARA>(), Is.EqualTo(sizeof(AUTHENTICODE_TS_EXTRA_CERT_CHAIN_POLICY_PARA)));
    }

    /// <summary>Validates that the <see cref = "AUTHENTICODE_TS_EXTRA_CERT_CHAIN_POLICY_PARA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AUTHENTICODE_TS_EXTRA_CERT_CHAIN_POLICY_PARA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "AUTHENTICODE_TS_EXTRA_CERT_CHAIN_POLICY_PARA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AUTHENTICODE_TS_EXTRA_CERT_CHAIN_POLICY_PARA), Is.EqualTo(12));
    }
}