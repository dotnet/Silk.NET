// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IAppResourceGroupInfo"/> struct.</summary>
public static unsafe partial class IAppResourceGroupInfoTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IAppResourceGroupInfo"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IAppResourceGroupInfo).GUID, Is.EqualTo(IID_IAppResourceGroupInfo));
    }

    /// <summary>Validates that the <see cref = "IAppResourceGroupInfo"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IAppResourceGroupInfo>(),
            Is.EqualTo(sizeof(IAppResourceGroupInfo))
        );
    }

    /// <summary>Validates that the <see cref = "IAppResourceGroupInfo"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IAppResourceGroupInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IAppResourceGroupInfo"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IAppResourceGroupInfo), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IAppResourceGroupInfo), Is.EqualTo(4));
        }
    }
}
