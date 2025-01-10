// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "D3DDEVICE_CREATION_PARAMETERS"/> struct.</summary>
public static unsafe partial class D3DDEVICE_CREATION_PARAMETERSTests
{
    /// <summary>Validates that the <see cref = "D3DDEVICE_CREATION_PARAMETERS"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<D3DDEVICE_CREATION_PARAMETERS>(),
            Is.EqualTo(sizeof(D3DDEVICE_CREATION_PARAMETERS))
        );
    }

    /// <summary>Validates that the <see cref = "D3DDEVICE_CREATION_PARAMETERS"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3DDEVICE_CREATION_PARAMETERS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "D3DDEVICE_CREATION_PARAMETERS"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(D3DDEVICE_CREATION_PARAMETERS), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(D3DDEVICE_CREATION_PARAMETERS), Is.EqualTo(16));
        }
    }
}
