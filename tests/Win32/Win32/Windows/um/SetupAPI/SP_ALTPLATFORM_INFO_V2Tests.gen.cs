// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "SP_ALTPLATFORM_INFO_V2"/> struct.</summary>
public static unsafe partial class SP_ALTPLATFORM_INFO_V2Tests
{
    /// <summary>Validates that the <see cref = "SP_ALTPLATFORM_INFO_V2"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SP_ALTPLATFORM_INFO_V2>(),
            Is.EqualTo(sizeof(SP_ALTPLATFORM_INFO_V2))
        );
    }

    /// <summary>Validates that the <see cref = "SP_ALTPLATFORM_INFO_V2"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SP_ALTPLATFORM_INFO_V2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SP_ALTPLATFORM_INFO_V2"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SP_ALTPLATFORM_INFO_V2), Is.EqualTo(28));
    }
}
