// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DWRITE_COLOR_GLYPH_RUN"/> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class DWRITE_COLOR_GLYPH_RUNTests
{
    /// <summary>Validates that the <see cref = "DWRITE_COLOR_GLYPH_RUN"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DWRITE_COLOR_GLYPH_RUN>(), Is.EqualTo(sizeof(DWRITE_COLOR_GLYPH_RUN)));
    }

    /// <summary>Validates that the <see cref = "DWRITE_COLOR_GLYPH_RUN"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DWRITE_COLOR_GLYPH_RUN).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DWRITE_COLOR_GLYPH_RUN"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DWRITE_COLOR_GLYPH_RUN), Is.EqualTo(88));
        }
        else
        {
            Assert.That(sizeof(DWRITE_COLOR_GLYPH_RUN), Is.EqualTo(64));
        }
    }
}