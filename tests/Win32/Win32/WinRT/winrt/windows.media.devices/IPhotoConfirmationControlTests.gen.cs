// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IPhotoConfirmationControl"/> struct.</summary>
public static unsafe partial class IPhotoConfirmationControlTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IPhotoConfirmationControl"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IPhotoConfirmationControl).GUID,
            Is.EqualTo(IID_IPhotoConfirmationControl)
        );
    }

    /// <summary>Validates that the <see cref = "IPhotoConfirmationControl"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IPhotoConfirmationControl>(),
            Is.EqualTo(sizeof(IPhotoConfirmationControl))
        );
    }

    /// <summary>Validates that the <see cref = "IPhotoConfirmationControl"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IPhotoConfirmationControl).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IPhotoConfirmationControl"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IPhotoConfirmationControl), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IPhotoConfirmationControl), Is.EqualTo(4));
        }
    }
}
