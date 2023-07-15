// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDWriteInMemoryFontFileLoader"/> struct.</summary>
public static unsafe partial class IDWriteInMemoryFontFileLoaderTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDWriteInMemoryFontFileLoader"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDWriteInMemoryFontFileLoader).GUID, Is.EqualTo(IID_IDWriteInMemoryFontFileLoader));
    }

    /// <summary>Validates that the <see cref = "IDWriteInMemoryFontFileLoader"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDWriteInMemoryFontFileLoader>(), Is.EqualTo(sizeof(IDWriteInMemoryFontFileLoader)));
    }

    /// <summary>Validates that the <see cref = "IDWriteInMemoryFontFileLoader"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDWriteInMemoryFontFileLoader).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDWriteInMemoryFontFileLoader"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDWriteInMemoryFontFileLoader), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDWriteInMemoryFontFileLoader), Is.EqualTo(4));
        }
    }
}