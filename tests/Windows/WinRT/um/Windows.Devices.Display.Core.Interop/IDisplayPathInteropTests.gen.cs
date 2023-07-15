// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Windows.Devices.Display.Core.Interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "IDisplayPathInterop"/> struct.</summary>
public static unsafe partial class IDisplayPathInteropTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDisplayPathInterop"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDisplayPathInterop).GUID, Is.EqualTo(IID_IDisplayPathInterop));
    }

    /// <summary>Validates that the <see cref = "IDisplayPathInterop"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDisplayPathInterop>(), Is.EqualTo(sizeof(IDisplayPathInterop)));
    }

    /// <summary>Validates that the <see cref = "IDisplayPathInterop"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDisplayPathInterop).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDisplayPathInterop"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDisplayPathInterop), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDisplayPathInterop), Is.EqualTo(4));
        }
    }
}