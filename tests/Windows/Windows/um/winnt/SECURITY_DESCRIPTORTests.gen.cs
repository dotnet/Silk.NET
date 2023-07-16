// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SECURITY_DESCRIPTOR"/> struct.</summary>
public static unsafe partial class SECURITY_DESCRIPTORTests
{
    /// <summary>Validates that the <see cref = "SECURITY_DESCRIPTOR"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SECURITY_DESCRIPTOR>(), Is.EqualTo(sizeof(SECURITY_DESCRIPTOR)));
    }

    /// <summary>Validates that the <see cref = "SECURITY_DESCRIPTOR"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SECURITY_DESCRIPTOR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SECURITY_DESCRIPTOR"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SECURITY_DESCRIPTOR), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(SECURITY_DESCRIPTOR), Is.EqualTo(20));
        }
    }
}