// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDXGIDisplayControl"/> struct.</summary>
public static unsafe partial class IDXGIDisplayControlTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDXGIDisplayControl"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDXGIDisplayControl).GUID, Is.EqualTo(IID_IDXGIDisplayControl));
    }

    /// <summary>Validates that the <see cref = "IDXGIDisplayControl"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDXGIDisplayControl>(), Is.EqualTo(sizeof(IDXGIDisplayControl)));
    }

    /// <summary>Validates that the <see cref = "IDXGIDisplayControl"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDXGIDisplayControl).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDXGIDisplayControl"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDXGIDisplayControl), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDXGIDisplayControl), Is.EqualTo(4));
        }
    }
}