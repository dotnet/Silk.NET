// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ACTCTX_SECTION_KEYED_DATA"/> struct.</summary>
public static unsafe partial class ACTCTX_SECTION_KEYED_DATATests
{
    /// <summary>Validates that the <see cref = "ACTCTX_SECTION_KEYED_DATA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ACTCTX_SECTION_KEYED_DATA>(), Is.EqualTo(sizeof(ACTCTX_SECTION_KEYED_DATA)));
    }

    /// <summary>Validates that the <see cref = "ACTCTX_SECTION_KEYED_DATA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ACTCTX_SECTION_KEYED_DATA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ACTCTX_SECTION_KEYED_DATA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ACTCTX_SECTION_KEYED_DATA), Is.EqualTo(112));
        }
        else
        {
            Assert.That(sizeof(ACTCTX_SECTION_KEYED_DATA), Is.EqualTo(64));
        }
    }
}