// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "FIXED_INFO"/> struct.</summary>
public static unsafe partial class FIXED_INFOTests
{
    /// <summary>Validates that the <see cref = "FIXED_INFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FIXED_INFO>(), Is.EqualTo(sizeof(FIXED_INFO)));
    }

    /// <summary>Validates that the <see cref = "FIXED_INFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FIXED_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "FIXED_INFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(FIXED_INFO), Is.EqualTo(600));
        }
        else
        {
            Assert.That(sizeof(FIXED_INFO), Is.EqualTo(584));
        }
    }
}