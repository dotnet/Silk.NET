// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "POLICY_MACHINE_ACCT_INFO2"/> struct.</summary>
public static unsafe partial class POLICY_MACHINE_ACCT_INFO2Tests
{
    /// <summary>Validates that the <see cref = "POLICY_MACHINE_ACCT_INFO2"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<POLICY_MACHINE_ACCT_INFO2>(), Is.EqualTo(sizeof(POLICY_MACHINE_ACCT_INFO2)));
    }

    /// <summary>Validates that the <see cref = "POLICY_MACHINE_ACCT_INFO2"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(POLICY_MACHINE_ACCT_INFO2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "POLICY_MACHINE_ACCT_INFO2"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(POLICY_MACHINE_ACCT_INFO2), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(POLICY_MACHINE_ACCT_INFO2), Is.EqualTo(24));
        }
    }
}