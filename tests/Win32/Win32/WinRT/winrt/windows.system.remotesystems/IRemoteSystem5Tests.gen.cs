// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IRemoteSystem5"/> struct.</summary>
public static unsafe partial class IRemoteSystem5Tests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IRemoteSystem5"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IRemoteSystem5).GUID, Is.EqualTo(IID_IRemoteSystem5));
    }

    /// <summary>Validates that the <see cref = "IRemoteSystem5"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IRemoteSystem5>(), Is.EqualTo(sizeof(IRemoteSystem5)));
    }

    /// <summary>Validates that the <see cref = "IRemoteSystem5"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IRemoteSystem5).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IRemoteSystem5"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IRemoteSystem5), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IRemoteSystem5), Is.EqualTo(4));
        }
    }
}
