// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "IBitmapData"/> struct.</summary>
[SupportedOSPlatform("windows10.0.14393.0")]
public static unsafe partial class IBitmapDataTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IBitmapData"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IBitmapData).GUID, Is.EqualTo(IID_IBitmapData));
    }

    /// <summary>Validates that the <see cref = "IBitmapData"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IBitmapData>(), Is.EqualTo(sizeof(IBitmapData)));
    }

    /// <summary>Validates that the <see cref = "IBitmapData"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IBitmapData).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IBitmapData"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IBitmapData), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IBitmapData), Is.EqualTo(4));
        }
    }
}