// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.graphics.imaging.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "ISoftwareBitmapNative"/> struct.</summary>
public static unsafe partial class ISoftwareBitmapNativeTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ISoftwareBitmapNative"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISoftwareBitmapNative).GUID, Is.EqualTo(IID_ISoftwareBitmapNative));
    }

    /// <summary>Validates that the <see cref = "ISoftwareBitmapNative"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISoftwareBitmapNative>(), Is.EqualTo(sizeof(ISoftwareBitmapNative)));
    }

    /// <summary>Validates that the <see cref = "ISoftwareBitmapNative"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISoftwareBitmapNative).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ISoftwareBitmapNative"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISoftwareBitmapNative), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISoftwareBitmapNative), Is.EqualTo(4));
        }
    }
}