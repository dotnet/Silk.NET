// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IRemoteSystemKindFilterFactory"/> struct.</summary>
public static unsafe partial class IRemoteSystemKindFilterFactoryTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IRemoteSystemKindFilterFactory"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IRemoteSystemKindFilterFactory).GUID,
            Is.EqualTo(IID_IRemoteSystemKindFilterFactory)
        );
    }

    /// <summary>Validates that the <see cref = "IRemoteSystemKindFilterFactory"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IRemoteSystemKindFilterFactory>(),
            Is.EqualTo(sizeof(IRemoteSystemKindFilterFactory))
        );
    }

    /// <summary>Validates that the <see cref = "IRemoteSystemKindFilterFactory"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IRemoteSystemKindFilterFactory).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IRemoteSystemKindFilterFactory"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IRemoteSystemKindFilterFactory), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IRemoteSystemKindFilterFactory), Is.EqualTo(4));
        }
    }
}
