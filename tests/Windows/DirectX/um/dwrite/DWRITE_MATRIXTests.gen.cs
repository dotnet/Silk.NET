// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DWRITE_MATRIX"/> struct.</summary>
public static unsafe partial class DWRITE_MATRIXTests
{
    /// <summary>Validates that the <see cref = "DWRITE_MATRIX"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DWRITE_MATRIX>(), Is.EqualTo(sizeof(DWRITE_MATRIX)));
    }

    /// <summary>Validates that the <see cref = "DWRITE_MATRIX"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DWRITE_MATRIX).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DWRITE_MATRIX"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DWRITE_MATRIX), Is.EqualTo(24));
    }
}