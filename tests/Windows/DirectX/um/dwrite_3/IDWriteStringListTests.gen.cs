// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDWriteStringList"/> struct.</summary>
public static unsafe partial class IDWriteStringListTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDWriteStringList"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDWriteStringList).GUID, Is.EqualTo(IID_IDWriteStringList));
    }

    /// <summary>Validates that the <see cref = "IDWriteStringList"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDWriteStringList>(), Is.EqualTo(sizeof(IDWriteStringList)));
    }

    /// <summary>Validates that the <see cref = "IDWriteStringList"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDWriteStringList).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDWriteStringList"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDWriteStringList), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDWriteStringList), Is.EqualTo(4));
        }
    }
}