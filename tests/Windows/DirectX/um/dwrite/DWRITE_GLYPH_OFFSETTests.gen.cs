// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DWRITE_GLYPH_OFFSET"/> struct.</summary>
public static unsafe partial class DWRITE_GLYPH_OFFSETTests
{
    /// <summary>Validates that the <see cref = "DWRITE_GLYPH_OFFSET"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DWRITE_GLYPH_OFFSET>(), Is.EqualTo(sizeof(DWRITE_GLYPH_OFFSET)));
    }

    /// <summary>Validates that the <see cref = "DWRITE_GLYPH_OFFSET"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DWRITE_GLYPH_OFFSET).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DWRITE_GLYPH_OFFSET"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DWRITE_GLYPH_OFFSET), Is.EqualTo(8));
    }
}