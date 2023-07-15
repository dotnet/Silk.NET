// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxgicommon.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DXGI_RATIONAL"/> struct.</summary>
public static unsafe partial class DXGI_RATIONALTests
{
    /// <summary>Validates that the <see cref = "DXGI_RATIONAL"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DXGI_RATIONAL>(), Is.EqualTo(sizeof(DXGI_RATIONAL)));
    }

    /// <summary>Validates that the <see cref = "DXGI_RATIONAL"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DXGI_RATIONAL).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DXGI_RATIONAL"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DXGI_RATIONAL), Is.EqualTo(8));
    }
}