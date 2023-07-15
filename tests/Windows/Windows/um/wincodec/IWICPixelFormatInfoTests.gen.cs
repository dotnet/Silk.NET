// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IWICPixelFormatInfo"/> struct.</summary>
public static unsafe partial class IWICPixelFormatInfoTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IWICPixelFormatInfo"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IWICPixelFormatInfo).GUID, Is.EqualTo(IID_IWICPixelFormatInfo));
    }

    /// <summary>Validates that the <see cref = "IWICPixelFormatInfo"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IWICPixelFormatInfo>(), Is.EqualTo(sizeof(IWICPixelFormatInfo)));
    }

    /// <summary>Validates that the <see cref = "IWICPixelFormatInfo"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IWICPixelFormatInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IWICPixelFormatInfo"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IWICPixelFormatInfo), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IWICPixelFormatInfo), Is.EqualTo(4));
        }
    }
}