// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IRemoteSystemConnectionInfoStatics"/> struct.</summary>
public static unsafe partial class IRemoteSystemConnectionInfoStaticsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IRemoteSystemConnectionInfoStatics"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IRemoteSystemConnectionInfoStatics).GUID,
            Is.EqualTo(IID_IRemoteSystemConnectionInfoStatics)
        );
    }

    /// <summary>Validates that the <see cref = "IRemoteSystemConnectionInfoStatics"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IRemoteSystemConnectionInfoStatics>(),
            Is.EqualTo(sizeof(IRemoteSystemConnectionInfoStatics))
        );
    }

    /// <summary>Validates that the <see cref = "IRemoteSystemConnectionInfoStatics"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IRemoteSystemConnectionInfoStatics).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IRemoteSystemConnectionInfoStatics"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IRemoteSystemConnectionInfoStatics), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IRemoteSystemConnectionInfoStatics), Is.EqualTo(4));
        }
    }
}
