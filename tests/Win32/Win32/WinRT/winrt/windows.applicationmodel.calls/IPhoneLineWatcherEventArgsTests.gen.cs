// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IPhoneLineWatcherEventArgs"/> struct.</summary>
public static unsafe partial class IPhoneLineWatcherEventArgsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IPhoneLineWatcherEventArgs"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IPhoneLineWatcherEventArgs).GUID,
            Is.EqualTo(IID_IPhoneLineWatcherEventArgs)
        );
    }

    /// <summary>Validates that the <see cref = "IPhoneLineWatcherEventArgs"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IPhoneLineWatcherEventArgs>(),
            Is.EqualTo(sizeof(IPhoneLineWatcherEventArgs))
        );
    }

    /// <summary>Validates that the <see cref = "IPhoneLineWatcherEventArgs"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IPhoneLineWatcherEventArgs).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IPhoneLineWatcherEventArgs"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IPhoneLineWatcherEventArgs), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IPhoneLineWatcherEventArgs), Is.EqualTo(4));
        }
    }
}
