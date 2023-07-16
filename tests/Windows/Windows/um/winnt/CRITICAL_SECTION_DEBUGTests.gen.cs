// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CRITICAL_SECTION_DEBUG"/> struct.</summary>
public static unsafe partial class CRITICAL_SECTION_DEBUGTests
{
    /// <summary>Validates that the <see cref = "CRITICAL_SECTION_DEBUG"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CRITICAL_SECTION_DEBUG>(), Is.EqualTo(sizeof(CRITICAL_SECTION_DEBUG)));
    }

    /// <summary>Validates that the <see cref = "CRITICAL_SECTION_DEBUG"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CRITICAL_SECTION_DEBUG).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CRITICAL_SECTION_DEBUG"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CRITICAL_SECTION_DEBUG), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(CRITICAL_SECTION_DEBUG), Is.EqualTo(32));
        }
    }
}