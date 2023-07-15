// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "WTA_OPTIONS"/> struct.</summary>
public static unsafe partial class WTA_OPTIONSTests
{
    /// <summary>Validates that the <see cref = "WTA_OPTIONS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WTA_OPTIONS>(), Is.EqualTo(sizeof(WTA_OPTIONS)));
    }

    /// <summary>Validates that the <see cref = "WTA_OPTIONS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WTA_OPTIONS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WTA_OPTIONS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WTA_OPTIONS), Is.EqualTo(8));
    }
}