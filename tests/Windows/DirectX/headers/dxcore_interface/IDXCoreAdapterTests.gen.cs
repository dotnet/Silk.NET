// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDXCoreAdapter"/> struct.</summary>
[SupportedOSPlatform("windows10.0.19041.0")]
public static unsafe partial class IDXCoreAdapterTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDXCoreAdapter"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDXCoreAdapter).GUID, Is.EqualTo(IID_IDXCoreAdapter));
    }

    /// <summary>Validates that the <see cref = "IDXCoreAdapter"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDXCoreAdapter>(), Is.EqualTo(sizeof(IDXCoreAdapter)));
    }

    /// <summary>Validates that the <see cref = "IDXCoreAdapter"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDXCoreAdapter).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDXCoreAdapter"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDXCoreAdapter), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDXCoreAdapter), Is.EqualTo(4));
        }
    }
}