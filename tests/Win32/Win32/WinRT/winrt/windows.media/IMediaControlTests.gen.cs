// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IMediaControl"/> struct.</summary>
public static unsafe partial class IMediaControlTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMediaControl"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMediaControl).GUID, Is.EqualTo(IID_WinRT_IMediaControl));
    }

    /// <summary>Validates that the <see cref = "IMediaControl"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMediaControl>(), Is.EqualTo(sizeof(IMediaControl)));
    }

    /// <summary>Validates that the <see cref = "IMediaControl"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMediaControl).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMediaControl"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMediaControl), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMediaControl), Is.EqualTo(4));
        }
    }
}
