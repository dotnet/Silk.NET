// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IVoipCallCoordinator"/> struct.</summary>
public static unsafe partial class IVoipCallCoordinatorTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IVoipCallCoordinator"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IVoipCallCoordinator).GUID, Is.EqualTo(IID_IVoipCallCoordinator));
    }

    /// <summary>Validates that the <see cref = "IVoipCallCoordinator"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IVoipCallCoordinator>(),
            Is.EqualTo(sizeof(IVoipCallCoordinator))
        );
    }

    /// <summary>Validates that the <see cref = "IVoipCallCoordinator"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IVoipCallCoordinator).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IVoipCallCoordinator"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IVoipCallCoordinator), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IVoipCallCoordinator), Is.EqualTo(4));
        }
    }
}
