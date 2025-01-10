// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "ENCLAVE_CREATE_INFO_VBS"/> struct.</summary>
[SupportedOSPlatform("windows10.0.16299.0")]
public static unsafe partial class ENCLAVE_CREATE_INFO_VBSTests
{
    /// <summary>Validates that the <see cref = "ENCLAVE_CREATE_INFO_VBS"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ENCLAVE_CREATE_INFO_VBS>(),
            Is.EqualTo(sizeof(ENCLAVE_CREATE_INFO_VBS))
        );
    }

    /// <summary>Validates that the <see cref = "ENCLAVE_CREATE_INFO_VBS"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ENCLAVE_CREATE_INFO_VBS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ENCLAVE_CREATE_INFO_VBS"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ENCLAVE_CREATE_INFO_VBS), Is.EqualTo(36));
    }
}
