// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DIDEVICEOBJECTDATA"/> struct.</summary>
public static unsafe partial class DIDEVICEOBJECTDATATests
{
    /// <summary>Validates that the <see cref = "DIDEVICEOBJECTDATA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DIDEVICEOBJECTDATA>(), Is.EqualTo(sizeof(DIDEVICEOBJECTDATA)));
    }

    /// <summary>Validates that the <see cref = "DIDEVICEOBJECTDATA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DIDEVICEOBJECTDATA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DIDEVICEOBJECTDATA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DIDEVICEOBJECTDATA), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(DIDEVICEOBJECTDATA), Is.EqualTo(20));
        }
    }
}