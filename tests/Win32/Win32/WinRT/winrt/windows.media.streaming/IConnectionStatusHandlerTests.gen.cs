// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IConnectionStatusHandler"/> struct.</summary>
public static unsafe partial class IConnectionStatusHandlerTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IConnectionStatusHandler"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IConnectionStatusHandler).GUID,
            Is.EqualTo(IID_IConnectionStatusHandler)
        );
    }

    /// <summary>Validates that the <see cref = "IConnectionStatusHandler"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IConnectionStatusHandler>(),
            Is.EqualTo(sizeof(IConnectionStatusHandler))
        );
    }

    /// <summary>Validates that the <see cref = "IConnectionStatusHandler"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IConnectionStatusHandler).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IConnectionStatusHandler"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IConnectionStatusHandler), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IConnectionStatusHandler), Is.EqualTo(4));
        }
    }
}
