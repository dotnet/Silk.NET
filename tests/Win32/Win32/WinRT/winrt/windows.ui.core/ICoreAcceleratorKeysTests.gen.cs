// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "ICoreAcceleratorKeys"/> struct.</summary>
public static unsafe partial class ICoreAcceleratorKeysTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ICoreAcceleratorKeys"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ICoreAcceleratorKeys).GUID, Is.EqualTo(IID_ICoreAcceleratorKeys));
    }

    /// <summary>Validates that the <see cref = "ICoreAcceleratorKeys"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ICoreAcceleratorKeys>(),
            Is.EqualTo(sizeof(ICoreAcceleratorKeys))
        );
    }

    /// <summary>Validates that the <see cref = "ICoreAcceleratorKeys"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ICoreAcceleratorKeys).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ICoreAcceleratorKeys"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ICoreAcceleratorKeys), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ICoreAcceleratorKeys), Is.EqualTo(4));
        }
    }
}
