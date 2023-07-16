// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "PRJ_CALLBACK_DATA"/> struct.</summary>
[SupportedOSPlatform("windows10.0.17763.0")]
public static unsafe partial class PRJ_CALLBACK_DATATests
{
    /// <summary>Validates that the <see cref = "PRJ_CALLBACK_DATA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PRJ_CALLBACK_DATA>(), Is.EqualTo(sizeof(PRJ_CALLBACK_DATA)));
    }

    /// <summary>Validates that the <see cref = "PRJ_CALLBACK_DATA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PRJ_CALLBACK_DATA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PRJ_CALLBACK_DATA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PRJ_CALLBACK_DATA), Is.EqualTo(96));
        }
        else
        {
            Assert.That(sizeof(PRJ_CALLBACK_DATA), Is.EqualTo(68));
        }
    }
}