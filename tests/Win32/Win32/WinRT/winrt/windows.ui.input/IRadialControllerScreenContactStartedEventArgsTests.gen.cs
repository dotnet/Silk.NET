// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IRadialControllerScreenContactStartedEventArgs"/> struct.</summary>
public static unsafe partial class IRadialControllerScreenContactStartedEventArgsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IRadialControllerScreenContactStartedEventArgs"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IRadialControllerScreenContactStartedEventArgs).GUID,
            Is.EqualTo(IID_IRadialControllerScreenContactStartedEventArgs)
        );
    }

    /// <summary>Validates that the <see cref = "IRadialControllerScreenContactStartedEventArgs"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IRadialControllerScreenContactStartedEventArgs>(),
            Is.EqualTo(sizeof(IRadialControllerScreenContactStartedEventArgs))
        );
    }

    /// <summary>Validates that the <see cref = "IRadialControllerScreenContactStartedEventArgs"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(
            typeof(IRadialControllerScreenContactStartedEventArgs).IsLayoutSequential,
            Is.True
        );
    }

    /// <summary>Validates that the <see cref = "IRadialControllerScreenContactStartedEventArgs"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IRadialControllerScreenContactStartedEventArgs), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IRadialControllerScreenContactStartedEventArgs), Is.EqualTo(4));
        }
    }
}
