// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DXCoreFrequencyQueryOutput"/> struct.</summary>
public static unsafe partial class DXCoreFrequencyQueryOutputTests
{
    /// <summary>Validates that the <see cref = "DXCoreFrequencyQueryOutput"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DXCoreFrequencyQueryOutput>(),
            Is.EqualTo(sizeof(DXCoreFrequencyQueryOutput))
        );
    }

    /// <summary>Validates that the <see cref = "DXCoreFrequencyQueryOutput"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DXCoreFrequencyQueryOutput).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DXCoreFrequencyQueryOutput"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DXCoreFrequencyQueryOutput), Is.EqualTo(24));
    }
}
