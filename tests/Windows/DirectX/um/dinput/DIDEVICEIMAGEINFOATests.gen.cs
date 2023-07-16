// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DIDEVICEIMAGEINFOA"/> struct.</summary>
public static unsafe partial class DIDEVICEIMAGEINFOATests
{
    /// <summary>Validates that the <see cref = "DIDEVICEIMAGEINFOA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DIDEVICEIMAGEINFOA>(), Is.EqualTo(sizeof(DIDEVICEIMAGEINFOA)));
    }

    /// <summary>Validates that the <see cref = "DIDEVICEIMAGEINFOA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DIDEVICEIMAGEINFOA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DIDEVICEIMAGEINFOA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DIDEVICEIMAGEINFOA), Is.EqualTo(352));
    }
}