// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "POLICY_DEFAULT_QUOTA_INFO"/> struct.</summary>
public static unsafe partial class POLICY_DEFAULT_QUOTA_INFOTests
{
    /// <summary>Validates that the <see cref = "POLICY_DEFAULT_QUOTA_INFO"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<POLICY_DEFAULT_QUOTA_INFO>(),
            Is.EqualTo(sizeof(POLICY_DEFAULT_QUOTA_INFO))
        );
    }

    /// <summary>Validates that the <see cref = "POLICY_DEFAULT_QUOTA_INFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(POLICY_DEFAULT_QUOTA_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "POLICY_DEFAULT_QUOTA_INFO"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(POLICY_DEFAULT_QUOTA_INFO), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(POLICY_DEFAULT_QUOTA_INFO), Is.EqualTo(32));
        }
    }
}
