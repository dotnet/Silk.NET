// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IWICBitmapClipper"/> struct.</summary>
public static unsafe partial class IWICBitmapClipperTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IWICBitmapClipper"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IWICBitmapClipper).GUID, Is.EqualTo(IID_IWICBitmapClipper));
    }

    /// <summary>Validates that the <see cref = "IWICBitmapClipper"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IWICBitmapClipper>(), Is.EqualTo(sizeof(IWICBitmapClipper)));
    }

    /// <summary>Validates that the <see cref = "IWICBitmapClipper"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IWICBitmapClipper).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IWICBitmapClipper"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IWICBitmapClipper), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IWICBitmapClipper), Is.EqualTo(4));
        }
    }
}