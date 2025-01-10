// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "ISocketActivityInformationStatics"/> struct.</summary>
public static unsafe partial class ISocketActivityInformationStaticsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ISocketActivityInformationStatics"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(ISocketActivityInformationStatics).GUID,
            Is.EqualTo(IID_ISocketActivityInformationStatics)
        );
    }

    /// <summary>Validates that the <see cref = "ISocketActivityInformationStatics"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ISocketActivityInformationStatics>(),
            Is.EqualTo(sizeof(ISocketActivityInformationStatics))
        );
    }

    /// <summary>Validates that the <see cref = "ISocketActivityInformationStatics"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISocketActivityInformationStatics).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ISocketActivityInformationStatics"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISocketActivityInformationStatics), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISocketActivityInformationStatics), Is.EqualTo(4));
        }
    }
}
