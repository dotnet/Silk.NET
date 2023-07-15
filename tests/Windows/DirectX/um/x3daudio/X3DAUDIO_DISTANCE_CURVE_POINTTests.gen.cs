// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/x3daudio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "X3DAUDIO_DISTANCE_CURVE_POINT"/> struct.</summary>
public static unsafe partial class X3DAUDIO_DISTANCE_CURVE_POINTTests
{
    /// <summary>Validates that the <see cref = "X3DAUDIO_DISTANCE_CURVE_POINT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<X3DAUDIO_DISTANCE_CURVE_POINT>(), Is.EqualTo(sizeof(X3DAUDIO_DISTANCE_CURVE_POINT)));
    }

    /// <summary>Validates that the <see cref = "X3DAUDIO_DISTANCE_CURVE_POINT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(X3DAUDIO_DISTANCE_CURVE_POINT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "X3DAUDIO_DISTANCE_CURVE_POINT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(X3DAUDIO_DISTANCE_CURVE_POINT), Is.EqualTo(8));
    }
}