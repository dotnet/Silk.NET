// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MODLOAD_DATA"/> struct.</summary>
public static unsafe partial class MODLOAD_DATATests
{
    /// <summary>Validates that the <see cref = "MODLOAD_DATA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MODLOAD_DATA>(), Is.EqualTo(sizeof(MODLOAD_DATA)));
    }

    /// <summary>Validates that the <see cref = "MODLOAD_DATA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MODLOAD_DATA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MODLOAD_DATA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(MODLOAD_DATA), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(MODLOAD_DATA), Is.EqualTo(20));
        }
    }
}