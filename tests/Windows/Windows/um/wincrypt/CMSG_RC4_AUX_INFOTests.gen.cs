// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CMSG_RC4_AUX_INFO"/> struct.</summary>
public static unsafe partial class CMSG_RC4_AUX_INFOTests
{
    /// <summary>Validates that the <see cref = "CMSG_RC4_AUX_INFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CMSG_RC4_AUX_INFO>(), Is.EqualTo(sizeof(CMSG_RC4_AUX_INFO)));
    }

    /// <summary>Validates that the <see cref = "CMSG_RC4_AUX_INFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CMSG_RC4_AUX_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CMSG_RC4_AUX_INFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(CMSG_RC4_AUX_INFO), Is.EqualTo(8));
    }
}