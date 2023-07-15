// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "ICompositorInterop"/> struct.</summary>
public static unsafe partial class ICompositorInteropTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ICompositorInterop"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ICompositorInterop).GUID, Is.EqualTo(IID_ICompositorInterop));
    }

    /// <summary>Validates that the <see cref = "ICompositorInterop"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ICompositorInterop>(), Is.EqualTo(sizeof(ICompositorInterop)));
    }

    /// <summary>Validates that the <see cref = "ICompositorInterop"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ICompositorInterop).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ICompositorInterop"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ICompositorInterop), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ICompositorInterop), Is.EqualTo(4));
        }
    }
}