// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "KERB_CLOUD_KERBEROS_DEBUG_DATA"/> struct.</summary>
public static unsafe partial class KERB_CLOUD_KERBEROS_DEBUG_DATATests
{
    /// <summary>Validates that the <see cref = "KERB_CLOUD_KERBEROS_DEBUG_DATA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<KERB_CLOUD_KERBEROS_DEBUG_DATA>(), Is.EqualTo(sizeof(KERB_CLOUD_KERBEROS_DEBUG_DATA)));
    }

    /// <summary>Validates that the <see cref = "KERB_CLOUD_KERBEROS_DEBUG_DATA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(KERB_CLOUD_KERBEROS_DEBUG_DATA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "KERB_CLOUD_KERBEROS_DEBUG_DATA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(KERB_CLOUD_KERBEROS_DEBUG_DATA), Is.EqualTo(4));
    }
}