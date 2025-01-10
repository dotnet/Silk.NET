// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.protection.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IHdcpSession"/> struct.</summary>
public static unsafe partial class IHdcpSessionTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IHdcpSession"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IHdcpSession).GUID, Is.EqualTo(IID_IHdcpSession));
    }

    /// <summary>Validates that the <see cref = "IHdcpSession"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IHdcpSession>(), Is.EqualTo(sizeof(IHdcpSession)));
    }

    /// <summary>Validates that the <see cref = "IHdcpSession"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IHdcpSession).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IHdcpSession"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IHdcpSession), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IHdcpSession), Is.EqualTo(4));
        }
    }
}
