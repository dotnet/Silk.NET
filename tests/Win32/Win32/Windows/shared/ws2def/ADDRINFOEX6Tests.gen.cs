// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "ADDRINFOEX6"/> struct.</summary>
public static unsafe partial class ADDRINFOEX6Tests
{
    /// <summary>Validates that the <see cref = "ADDRINFOEX6"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ADDRINFOEX6>(), Is.EqualTo(sizeof(ADDRINFOEX6)));
    }

    /// <summary>Validates that the <see cref = "ADDRINFOEX6"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ADDRINFOEX6).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ADDRINFOEX6"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ADDRINFOEX6), Is.EqualTo(128));
        }
        else
        {
            Assert.That(sizeof(ADDRINFOEX6), Is.EqualTo(80));
        }
    }
}
