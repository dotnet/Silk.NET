// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxdiag.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DXDIAG_INIT_PARAMS"/> struct.</summary>
public static unsafe partial class DXDIAG_INIT_PARAMSTests
{
    /// <summary>Validates that the <see cref = "DXDIAG_INIT_PARAMS"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DXDIAG_INIT_PARAMS>(), Is.EqualTo(sizeof(DXDIAG_INIT_PARAMS)));
    }

    /// <summary>Validates that the <see cref = "DXDIAG_INIT_PARAMS"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DXDIAG_INIT_PARAMS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DXDIAG_INIT_PARAMS"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DXDIAG_INIT_PARAMS), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(DXDIAG_INIT_PARAMS), Is.EqualTo(16));
        }
    }
}
