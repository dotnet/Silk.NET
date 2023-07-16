// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MSChapp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SAMPR_ENCRYPTED_USER_PASSWORD"/> struct.</summary>
public static unsafe partial class SAMPR_ENCRYPTED_USER_PASSWORDTests
{
    /// <summary>Validates that the <see cref = "SAMPR_ENCRYPTED_USER_PASSWORD"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SAMPR_ENCRYPTED_USER_PASSWORD>(), Is.EqualTo(sizeof(SAMPR_ENCRYPTED_USER_PASSWORD)));
    }

    /// <summary>Validates that the <see cref = "SAMPR_ENCRYPTED_USER_PASSWORD"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SAMPR_ENCRYPTED_USER_PASSWORD).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SAMPR_ENCRYPTED_USER_PASSWORD"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SAMPR_ENCRYPTED_USER_PASSWORD), Is.EqualTo(516));
    }
}