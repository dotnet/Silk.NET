// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDWriteFontFace"/> struct.</summary>
public static unsafe partial class IDWriteFontFaceTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDWriteFontFace"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDWriteFontFace).GUID, Is.EqualTo(IID_IDWriteFontFace));
    }

    /// <summary>Validates that the <see cref = "IDWriteFontFace"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDWriteFontFace>(), Is.EqualTo(sizeof(IDWriteFontFace)));
    }

    /// <summary>Validates that the <see cref = "IDWriteFontFace"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDWriteFontFace).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDWriteFontFace"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDWriteFontFace), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDWriteFontFace), Is.EqualTo(4));
        }
    }
}