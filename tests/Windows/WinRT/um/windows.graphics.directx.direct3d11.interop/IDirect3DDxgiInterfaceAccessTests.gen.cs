// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.graphics.directx.direct3d11.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "IDirect3DDxgiInterfaceAccess"/> struct.</summary>
public static unsafe partial class IDirect3DDxgiInterfaceAccessTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDirect3DDxgiInterfaceAccess"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDirect3DDxgiInterfaceAccess).GUID, Is.EqualTo(IID_IDirect3DDxgiInterfaceAccess));
    }

    /// <summary>Validates that the <see cref = "IDirect3DDxgiInterfaceAccess"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDirect3DDxgiInterfaceAccess>(), Is.EqualTo(sizeof(IDirect3DDxgiInterfaceAccess)));
    }

    /// <summary>Validates that the <see cref = "IDirect3DDxgiInterfaceAccess"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDirect3DDxgiInterfaceAccess).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDirect3DDxgiInterfaceAccess"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDirect3DDxgiInterfaceAccess), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDirect3DDxgiInterfaceAccess), Is.EqualTo(4));
        }
    }
}