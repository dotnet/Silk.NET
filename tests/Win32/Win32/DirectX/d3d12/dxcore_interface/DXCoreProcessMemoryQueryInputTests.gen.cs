// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DXCoreProcessMemoryQueryInput"/> struct.</summary>
public static unsafe partial class DXCoreProcessMemoryQueryInputTests
{
    /// <summary>Validates that the <see cref = "DXCoreProcessMemoryQueryInput"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DXCoreProcessMemoryQueryInput>(),
            Is.EqualTo(sizeof(DXCoreProcessMemoryQueryInput))
        );
    }

    /// <summary>Validates that the <see cref = "DXCoreProcessMemoryQueryInput"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DXCoreProcessMemoryQueryInput).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DXCoreProcessMemoryQueryInput"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DXCoreProcessMemoryQueryInput), Is.EqualTo(12));
    }
}
