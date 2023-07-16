// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ADDRINFOEX5"/> struct.</summary>
public static unsafe partial class ADDRINFOEX5Tests
{
    /// <summary>Validates that the <see cref = "ADDRINFOEX5"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ADDRINFOEX5>(), Is.EqualTo(sizeof(ADDRINFOEX5)));
    }

    /// <summary>Validates that the <see cref = "ADDRINFOEX5"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ADDRINFOEX5).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ADDRINFOEX5"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ADDRINFOEX5), Is.EqualTo(112));
        }
        else
        {
            Assert.That(sizeof(ADDRINFOEX5), Is.EqualTo(64));
        }
    }
}