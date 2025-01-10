// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DXCoreEngineNamePropertyInput"/> struct.</summary>
public static unsafe partial class DXCoreEngineNamePropertyInputTests
{
    /// <summary>Validates that the <see cref = "DXCoreEngineNamePropertyInput"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DXCoreEngineNamePropertyInput>(),
            Is.EqualTo(sizeof(DXCoreEngineNamePropertyInput))
        );
    }

    /// <summary>Validates that the <see cref = "DXCoreEngineNamePropertyInput"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DXCoreEngineNamePropertyInput).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DXCoreEngineNamePropertyInput"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DXCoreEngineNamePropertyInput), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(DXCoreEngineNamePropertyInput), Is.EqualTo(16));
        }
    }
}
