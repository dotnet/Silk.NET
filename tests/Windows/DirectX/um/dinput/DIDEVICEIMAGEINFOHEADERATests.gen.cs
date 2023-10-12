// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DIDEVICEIMAGEINFOHEADERA"/> struct.</summary>
public static unsafe partial class DIDEVICEIMAGEINFOHEADERATests
{
    /// <summary>Validates that the <see cref = "DIDEVICEIMAGEINFOHEADERA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DIDEVICEIMAGEINFOHEADERA>(), Is.EqualTo(sizeof(DIDEVICEIMAGEINFOHEADERA)));
    }

    /// <summary>Validates that the <see cref = "DIDEVICEIMAGEINFOHEADERA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DIDEVICEIMAGEINFOHEADERA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DIDEVICEIMAGEINFOHEADERA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DIDEVICEIMAGEINFOHEADERA), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(DIDEVICEIMAGEINFOHEADERA), Is.EqualTo(36));
        }
    }
}