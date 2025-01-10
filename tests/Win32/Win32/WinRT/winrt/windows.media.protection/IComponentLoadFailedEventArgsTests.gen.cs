// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.protection.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IComponentLoadFailedEventArgs"/> struct.</summary>
public static unsafe partial class IComponentLoadFailedEventArgsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IComponentLoadFailedEventArgs"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IComponentLoadFailedEventArgs).GUID,
            Is.EqualTo(IID_IComponentLoadFailedEventArgs)
        );
    }

    /// <summary>Validates that the <see cref = "IComponentLoadFailedEventArgs"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IComponentLoadFailedEventArgs>(),
            Is.EqualTo(sizeof(IComponentLoadFailedEventArgs))
        );
    }

    /// <summary>Validates that the <see cref = "IComponentLoadFailedEventArgs"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IComponentLoadFailedEventArgs).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IComponentLoadFailedEventArgs"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IComponentLoadFailedEventArgs), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IComponentLoadFailedEventArgs), Is.EqualTo(4));
        }
    }
}
