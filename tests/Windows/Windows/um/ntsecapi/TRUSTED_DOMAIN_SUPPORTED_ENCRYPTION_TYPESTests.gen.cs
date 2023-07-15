// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "TRUSTED_DOMAIN_SUPPORTED_ENCRYPTION_TYPES"/> struct.</summary>
public static unsafe partial class TRUSTED_DOMAIN_SUPPORTED_ENCRYPTION_TYPESTests
{
    /// <summary>Validates that the <see cref = "TRUSTED_DOMAIN_SUPPORTED_ENCRYPTION_TYPES"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TRUSTED_DOMAIN_SUPPORTED_ENCRYPTION_TYPES>(), Is.EqualTo(sizeof(TRUSTED_DOMAIN_SUPPORTED_ENCRYPTION_TYPES)));
    }

    /// <summary>Validates that the <see cref = "TRUSTED_DOMAIN_SUPPORTED_ENCRYPTION_TYPES"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TRUSTED_DOMAIN_SUPPORTED_ENCRYPTION_TYPES).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TRUSTED_DOMAIN_SUPPORTED_ENCRYPTION_TYPES"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TRUSTED_DOMAIN_SUPPORTED_ENCRYPTION_TYPES), Is.EqualTo(4));
    }
}