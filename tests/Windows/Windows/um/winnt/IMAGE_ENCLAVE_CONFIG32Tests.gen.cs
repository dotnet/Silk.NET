// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMAGE_ENCLAVE_CONFIG32"/> struct.</summary>
[SupportedOSPlatform("windows10.0.16299.0")]
public static unsafe partial class IMAGE_ENCLAVE_CONFIG32Tests
{
    /// <summary>Validates that the <see cref = "IMAGE_ENCLAVE_CONFIG32"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMAGE_ENCLAVE_CONFIG32>(), Is.EqualTo(sizeof(IMAGE_ENCLAVE_CONFIG32)));
    }

    /// <summary>Validates that the <see cref = "IMAGE_ENCLAVE_CONFIG32"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMAGE_ENCLAVE_CONFIG32).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMAGE_ENCLAVE_CONFIG32"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IMAGE_ENCLAVE_CONFIG32), Is.EqualTo(76));
    }
}