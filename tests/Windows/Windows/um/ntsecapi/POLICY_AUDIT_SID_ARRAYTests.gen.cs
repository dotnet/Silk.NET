// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "POLICY_AUDIT_SID_ARRAY"/> struct.</summary>
public static unsafe partial class POLICY_AUDIT_SID_ARRAYTests
{
    /// <summary>Validates that the <see cref = "POLICY_AUDIT_SID_ARRAY"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<POLICY_AUDIT_SID_ARRAY>(), Is.EqualTo(sizeof(POLICY_AUDIT_SID_ARRAY)));
    }

    /// <summary>Validates that the <see cref = "POLICY_AUDIT_SID_ARRAY"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(POLICY_AUDIT_SID_ARRAY).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "POLICY_AUDIT_SID_ARRAY"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(POLICY_AUDIT_SID_ARRAY), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(POLICY_AUDIT_SID_ARRAY), Is.EqualTo(8));
        }
    }
}