// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IWICImagingFactory"/> struct.</summary>
public static unsafe partial class IWICImagingFactoryTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IWICImagingFactory"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IWICImagingFactory).GUID, Is.EqualTo(IID_IWICImagingFactory));
    }

    /// <summary>Validates that the <see cref = "IWICImagingFactory"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IWICImagingFactory>(), Is.EqualTo(sizeof(IWICImagingFactory)));
    }

    /// <summary>Validates that the <see cref = "IWICImagingFactory"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IWICImagingFactory).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IWICImagingFactory"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IWICImagingFactory), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IWICImagingFactory), Is.EqualTo(4));
        }
    }
}