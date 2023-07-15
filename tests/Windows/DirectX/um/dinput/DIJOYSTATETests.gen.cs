// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DIJOYSTATE"/> struct.</summary>
public static unsafe partial class DIJOYSTATETests
{
    /// <summary>Validates that the <see cref = "DIJOYSTATE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DIJOYSTATE>(), Is.EqualTo(sizeof(DIJOYSTATE)));
    }

    /// <summary>Validates that the <see cref = "DIJOYSTATE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DIJOYSTATE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DIJOYSTATE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DIJOYSTATE), Is.EqualTo(80));
    }
}