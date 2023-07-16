// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "KERB_AUTH_DATA"/> struct.</summary>
public static unsafe partial class KERB_AUTH_DATATests
{
    /// <summary>Validates that the <see cref = "KERB_AUTH_DATA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<KERB_AUTH_DATA>(), Is.EqualTo(sizeof(KERB_AUTH_DATA)));
    }

    /// <summary>Validates that the <see cref = "KERB_AUTH_DATA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(KERB_AUTH_DATA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "KERB_AUTH_DATA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(KERB_AUTH_DATA), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(KERB_AUTH_DATA), Is.EqualTo(12));
        }
    }
}