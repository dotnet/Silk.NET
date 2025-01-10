// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "INetworkInformationStatics"/> struct.</summary>
public static unsafe partial class INetworkInformationStaticsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "INetworkInformationStatics"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(INetworkInformationStatics).GUID,
            Is.EqualTo(IID_INetworkInformationStatics)
        );
    }

    /// <summary>Validates that the <see cref = "INetworkInformationStatics"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<INetworkInformationStatics>(),
            Is.EqualTo(sizeof(INetworkInformationStatics))
        );
    }

    /// <summary>Validates that the <see cref = "INetworkInformationStatics"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(INetworkInformationStatics).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "INetworkInformationStatics"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(INetworkInformationStatics), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(INetworkInformationStatics), Is.EqualTo(4));
        }
    }
}
