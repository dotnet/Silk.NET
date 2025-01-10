// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "ISystemPhotoProperties"/> struct.</summary>
public static unsafe partial class ISystemPhotoPropertiesTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ISystemPhotoProperties"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISystemPhotoProperties).GUID, Is.EqualTo(IID_ISystemPhotoProperties));
    }

    /// <summary>Validates that the <see cref = "ISystemPhotoProperties"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ISystemPhotoProperties>(),
            Is.EqualTo(sizeof(ISystemPhotoProperties))
        );
    }

    /// <summary>Validates that the <see cref = "ISystemPhotoProperties"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISystemPhotoProperties).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ISystemPhotoProperties"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISystemPhotoProperties), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISystemPhotoProperties), Is.EqualTo(4));
        }
    }
}
