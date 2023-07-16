// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CLAIM_SECURITY_ATTRIBUTE_FQBN_VALUE"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class CLAIM_SECURITY_ATTRIBUTE_FQBN_VALUETests
{
    /// <summary>Validates that the <see cref = "CLAIM_SECURITY_ATTRIBUTE_FQBN_VALUE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CLAIM_SECURITY_ATTRIBUTE_FQBN_VALUE>(), Is.EqualTo(sizeof(CLAIM_SECURITY_ATTRIBUTE_FQBN_VALUE)));
    }

    /// <summary>Validates that the <see cref = "CLAIM_SECURITY_ATTRIBUTE_FQBN_VALUE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CLAIM_SECURITY_ATTRIBUTE_FQBN_VALUE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CLAIM_SECURITY_ATTRIBUTE_FQBN_VALUE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(CLAIM_SECURITY_ATTRIBUTE_FQBN_VALUE), Is.EqualTo(16));
    }
}