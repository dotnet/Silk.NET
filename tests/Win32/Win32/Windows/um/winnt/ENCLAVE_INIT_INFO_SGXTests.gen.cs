// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "ENCLAVE_INIT_INFO_SGX"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class ENCLAVE_INIT_INFO_SGXTests
{
    /// <summary>Validates that the <see cref = "ENCLAVE_INIT_INFO_SGX"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ENCLAVE_INIT_INFO_SGX>(),
            Is.EqualTo(sizeof(ENCLAVE_INIT_INFO_SGX))
        );
    }

    /// <summary>Validates that the <see cref = "ENCLAVE_INIT_INFO_SGX"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ENCLAVE_INIT_INFO_SGX).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ENCLAVE_INIT_INFO_SGX"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ENCLAVE_INIT_INFO_SGX), Is.EqualTo(4096));
    }
}
