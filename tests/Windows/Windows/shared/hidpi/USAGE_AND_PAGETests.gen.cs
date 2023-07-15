// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "USAGE_AND_PAGE"/> struct.</summary>
public static unsafe partial class USAGE_AND_PAGETests
{
    /// <summary>Validates that the <see cref = "USAGE_AND_PAGE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<USAGE_AND_PAGE>(), Is.EqualTo(sizeof(USAGE_AND_PAGE)));
    }

    /// <summary>Validates that the <see cref = "USAGE_AND_PAGE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(USAGE_AND_PAGE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "USAGE_AND_PAGE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(USAGE_AND_PAGE), Is.EqualTo(4));
    }
}