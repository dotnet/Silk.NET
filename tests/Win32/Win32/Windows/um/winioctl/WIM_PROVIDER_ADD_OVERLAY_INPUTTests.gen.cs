// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "WIM_PROVIDER_ADD_OVERLAY_INPUT"/> struct.</summary>
public static unsafe partial class WIM_PROVIDER_ADD_OVERLAY_INPUTTests
{
    /// <summary>Validates that the <see cref = "WIM_PROVIDER_ADD_OVERLAY_INPUT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<WIM_PROVIDER_ADD_OVERLAY_INPUT>(),
            Is.EqualTo(sizeof(WIM_PROVIDER_ADD_OVERLAY_INPUT))
        );
    }

    /// <summary>Validates that the <see cref = "WIM_PROVIDER_ADD_OVERLAY_INPUT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WIM_PROVIDER_ADD_OVERLAY_INPUT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WIM_PROVIDER_ADD_OVERLAY_INPUT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WIM_PROVIDER_ADD_OVERLAY_INPUT), Is.EqualTo(16));
    }
}
