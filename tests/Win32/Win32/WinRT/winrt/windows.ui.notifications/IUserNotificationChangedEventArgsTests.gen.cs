// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IUserNotificationChangedEventArgs"/> struct.</summary>
public static unsafe partial class IUserNotificationChangedEventArgsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IUserNotificationChangedEventArgs"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IUserNotificationChangedEventArgs).GUID,
            Is.EqualTo(IID_IUserNotificationChangedEventArgs)
        );
    }

    /// <summary>Validates that the <see cref = "IUserNotificationChangedEventArgs"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IUserNotificationChangedEventArgs>(),
            Is.EqualTo(sizeof(IUserNotificationChangedEventArgs))
        );
    }

    /// <summary>Validates that the <see cref = "IUserNotificationChangedEventArgs"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IUserNotificationChangedEventArgs).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IUserNotificationChangedEventArgs"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IUserNotificationChangedEventArgs), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IUserNotificationChangedEventArgs), Is.EqualTo(4));
        }
    }
}
