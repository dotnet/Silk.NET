// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SE_IMPERSONATION_STATE"/> struct.</summary>
public static unsafe partial class SE_IMPERSONATION_STATETests
{
    /// <summary>Validates that the <see cref = "SE_IMPERSONATION_STATE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SE_IMPERSONATION_STATE>(), Is.EqualTo(sizeof(SE_IMPERSONATION_STATE)));
    }

    /// <summary>Validates that the <see cref = "SE_IMPERSONATION_STATE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SE_IMPERSONATION_STATE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SE_IMPERSONATION_STATE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SE_IMPERSONATION_STATE), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(SE_IMPERSONATION_STATE), Is.EqualTo(12));
        }
    }
}