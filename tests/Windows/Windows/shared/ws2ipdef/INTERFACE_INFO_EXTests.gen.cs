// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "INTERFACE_INFO_EX"/> struct.</summary>
public static unsafe partial class INTERFACE_INFO_EXTests
{
    /// <summary>Validates that the <see cref = "INTERFACE_INFO_EX"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<INTERFACE_INFO_EX>(), Is.EqualTo(sizeof(INTERFACE_INFO_EX)));
    }

    /// <summary>Validates that the <see cref = "INTERFACE_INFO_EX"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(INTERFACE_INFO_EX).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "INTERFACE_INFO_EX"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(INTERFACE_INFO_EX), Is.EqualTo(56));
        }
        else
        {
            Assert.That(sizeof(INTERFACE_INFO_EX), Is.EqualTo(28));
        }
    }
}