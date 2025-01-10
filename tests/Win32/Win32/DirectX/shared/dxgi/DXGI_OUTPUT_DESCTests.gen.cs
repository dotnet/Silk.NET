// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DXGI_OUTPUT_DESC"/> struct.</summary>
public static unsafe partial class DXGI_OUTPUT_DESCTests
{
    /// <summary>Validates that the <see cref = "DXGI_OUTPUT_DESC"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DXGI_OUTPUT_DESC>(), Is.EqualTo(sizeof(DXGI_OUTPUT_DESC)));
    }

    /// <summary>Validates that the <see cref = "DXGI_OUTPUT_DESC"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DXGI_OUTPUT_DESC).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DXGI_OUTPUT_DESC"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DXGI_OUTPUT_DESC), Is.EqualTo(96));
        }
        else
        {
            Assert.That(sizeof(DXGI_OUTPUT_DESC), Is.EqualTo(92));
        }
    }
}
