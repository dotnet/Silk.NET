// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDXCoreAdapterFactory"/> struct.</summary>
[SupportedOSPlatform("windows10.0.19041.0")]
public static unsafe partial class IDXCoreAdapterFactoryTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDXCoreAdapterFactory"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDXCoreAdapterFactory).GUID, Is.EqualTo(IID_IDXCoreAdapterFactory));
    }

    /// <summary>Validates that the <see cref = "IDXCoreAdapterFactory"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDXCoreAdapterFactory>(), Is.EqualTo(sizeof(IDXCoreAdapterFactory)));
    }

    /// <summary>Validates that the <see cref = "IDXCoreAdapterFactory"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDXCoreAdapterFactory).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDXCoreAdapterFactory"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDXCoreAdapterFactory), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDXCoreAdapterFactory), Is.EqualTo(4));
        }
    }
}