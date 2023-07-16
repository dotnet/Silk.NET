// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDWriteTypography"/> struct.</summary>
public static unsafe partial class IDWriteTypographyTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDWriteTypography"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDWriteTypography).GUID, Is.EqualTo(IID_IDWriteTypography));
    }

    /// <summary>Validates that the <see cref = "IDWriteTypography"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDWriteTypography>(), Is.EqualTo(sizeof(IDWriteTypography)));
    }

    /// <summary>Validates that the <see cref = "IDWriteTypography"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDWriteTypography).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDWriteTypography"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDWriteTypography), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDWriteTypography), Is.EqualTo(4));
        }
    }
}