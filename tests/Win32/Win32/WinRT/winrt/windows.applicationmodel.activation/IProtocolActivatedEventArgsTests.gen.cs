// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.activation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IProtocolActivatedEventArgs"/> struct.</summary>
public static unsafe partial class IProtocolActivatedEventArgsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IProtocolActivatedEventArgs"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IProtocolActivatedEventArgs).GUID,
            Is.EqualTo(IID_IProtocolActivatedEventArgs)
        );
    }

    /// <summary>Validates that the <see cref = "IProtocolActivatedEventArgs"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IProtocolActivatedEventArgs>(),
            Is.EqualTo(sizeof(IProtocolActivatedEventArgs))
        );
    }

    /// <summary>Validates that the <see cref = "IProtocolActivatedEventArgs"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IProtocolActivatedEventArgs).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IProtocolActivatedEventArgs"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IProtocolActivatedEventArgs), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IProtocolActivatedEventArgs), Is.EqualTo(4));
        }
    }
}
