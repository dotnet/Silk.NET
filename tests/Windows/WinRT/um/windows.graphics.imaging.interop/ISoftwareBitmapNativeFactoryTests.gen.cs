// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.graphics.imaging.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "ISoftwareBitmapNativeFactory"/> struct.</summary>
public static unsafe partial class ISoftwareBitmapNativeFactoryTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ISoftwareBitmapNativeFactory"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISoftwareBitmapNativeFactory).GUID, Is.EqualTo(IID_ISoftwareBitmapNativeFactory));
    }

    /// <summary>Validates that the <see cref = "ISoftwareBitmapNativeFactory"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISoftwareBitmapNativeFactory>(), Is.EqualTo(sizeof(ISoftwareBitmapNativeFactory)));
    }

    /// <summary>Validates that the <see cref = "ISoftwareBitmapNativeFactory"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISoftwareBitmapNativeFactory).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ISoftwareBitmapNativeFactory"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISoftwareBitmapNativeFactory), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISoftwareBitmapNativeFactory), Is.EqualTo(4));
        }
    }
}