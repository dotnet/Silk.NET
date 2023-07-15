// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "OUTPUT_DEBUG_STRING_INFO"/> struct.</summary>
public static unsafe partial class OUTPUT_DEBUG_STRING_INFOTests
{
    /// <summary>Validates that the <see cref = "OUTPUT_DEBUG_STRING_INFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<OUTPUT_DEBUG_STRING_INFO>(), Is.EqualTo(sizeof(OUTPUT_DEBUG_STRING_INFO)));
    }

    /// <summary>Validates that the <see cref = "OUTPUT_DEBUG_STRING_INFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(OUTPUT_DEBUG_STRING_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "OUTPUT_DEBUG_STRING_INFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(OUTPUT_DEBUG_STRING_INFO), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(OUTPUT_DEBUG_STRING_INFO), Is.EqualTo(8));
        }
    }
}