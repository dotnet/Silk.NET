// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DIDEVICEOBJECTINSTANCE"/> struct.</summary>
public static unsafe partial class DIDEVICEOBJECTINSTANCETests
{
    /// <summary>Validates that the <see cref = "DIDEVICEOBJECTINSTANCE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DIDEVICEOBJECTINSTANCE>(), Is.EqualTo(sizeof(DIDEVICEOBJECTINSTANCE)));
    }

    /// <summary>Validates that the <see cref = "DIDEVICEOBJECTINSTANCE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DIDEVICEOBJECTINSTANCE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DIDEVICEOBJECTINSTANCE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DIDEVICEOBJECTINSTANCE), Is.EqualTo(576));
    }
}