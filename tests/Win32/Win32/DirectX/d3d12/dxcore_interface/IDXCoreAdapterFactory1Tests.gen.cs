// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "IDXCoreAdapterFactory1"/> struct.</summary>
public static unsafe partial class IDXCoreAdapterFactory1Tests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDXCoreAdapterFactory1"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDXCoreAdapterFactory1).GUID, Is.EqualTo(IID_IDXCoreAdapterFactory1));
    }

    /// <summary>Validates that the <see cref = "IDXCoreAdapterFactory1"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IDXCoreAdapterFactory1>(),
            Is.EqualTo(sizeof(IDXCoreAdapterFactory1))
        );
    }

    /// <summary>Validates that the <see cref = "IDXCoreAdapterFactory1"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDXCoreAdapterFactory1).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDXCoreAdapterFactory1"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDXCoreAdapterFactory1), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDXCoreAdapterFactory1), Is.EqualTo(4));
        }
    }
}
