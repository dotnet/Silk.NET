// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "ICompositionGraphicsDeviceInterop"/> struct.</summary>
public static unsafe partial class ICompositionGraphicsDeviceInteropTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ICompositionGraphicsDeviceInterop"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ICompositionGraphicsDeviceInterop).GUID, Is.EqualTo(IID_ICompositionGraphicsDeviceInterop));
    }

    /// <summary>Validates that the <see cref = "ICompositionGraphicsDeviceInterop"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ICompositionGraphicsDeviceInterop>(), Is.EqualTo(sizeof(ICompositionGraphicsDeviceInterop)));
    }

    /// <summary>Validates that the <see cref = "ICompositionGraphicsDeviceInterop"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ICompositionGraphicsDeviceInterop).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ICompositionGraphicsDeviceInterop"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ICompositionGraphicsDeviceInterop), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ICompositionGraphicsDeviceInterop), Is.EqualTo(4));
        }
    }
}