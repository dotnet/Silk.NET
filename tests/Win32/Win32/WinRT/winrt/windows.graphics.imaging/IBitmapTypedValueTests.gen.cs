// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IBitmapTypedValue"/> struct.</summary>
public static unsafe partial class IBitmapTypedValueTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IBitmapTypedValue"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IBitmapTypedValue).GUID, Is.EqualTo(IID_IBitmapTypedValue));
    }

    /// <summary>Validates that the <see cref = "IBitmapTypedValue"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IBitmapTypedValue>(), Is.EqualTo(sizeof(IBitmapTypedValue)));
    }

    /// <summary>Validates that the <see cref = "IBitmapTypedValue"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IBitmapTypedValue).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IBitmapTypedValue"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IBitmapTypedValue), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IBitmapTypedValue), Is.EqualTo(4));
        }
    }
}
