// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO"/> struct.</summary>
public static unsafe partial class DISPLAYCONFIG_GET_ADVANCED_COLOR_INFOTests
{
    /// <summary>Validates that the <see cref = "DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO>(),
            Is.EqualTo(sizeof(DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO))
        );
    }

    /// <summary>Validates that the <see cref = "DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO), Is.EqualTo(32));
    }
}
