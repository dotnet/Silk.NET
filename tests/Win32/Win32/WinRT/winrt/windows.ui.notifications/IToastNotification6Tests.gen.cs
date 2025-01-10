// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IToastNotification6"/> struct.</summary>
public static unsafe partial class IToastNotification6Tests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IToastNotification6"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IToastNotification6).GUID, Is.EqualTo(IID_IToastNotification6));
    }

    /// <summary>Validates that the <see cref = "IToastNotification6"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IToastNotification6>(), Is.EqualTo(sizeof(IToastNotification6)));
    }

    /// <summary>Validates that the <see cref = "IToastNotification6"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IToastNotification6).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IToastNotification6"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IToastNotification6), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IToastNotification6), Is.EqualTo(4));
        }
    }
}
