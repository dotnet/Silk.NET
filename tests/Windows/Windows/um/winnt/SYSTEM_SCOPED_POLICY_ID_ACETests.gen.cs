// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SYSTEM_SCOPED_POLICY_ID_ACE"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class SYSTEM_SCOPED_POLICY_ID_ACETests
{
    /// <summary>Validates that the <see cref = "SYSTEM_SCOPED_POLICY_ID_ACE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SYSTEM_SCOPED_POLICY_ID_ACE>(), Is.EqualTo(sizeof(SYSTEM_SCOPED_POLICY_ID_ACE)));
    }

    /// <summary>Validates that the <see cref = "SYSTEM_SCOPED_POLICY_ID_ACE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SYSTEM_SCOPED_POLICY_ID_ACE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SYSTEM_SCOPED_POLICY_ID_ACE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SYSTEM_SCOPED_POLICY_ID_ACE), Is.EqualTo(12));
    }
}