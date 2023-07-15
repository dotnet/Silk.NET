// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "HEAP_OPTIMIZE_RESOURCES_INFORMATION"/> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class HEAP_OPTIMIZE_RESOURCES_INFORMATIONTests
{
    /// <summary>Validates that the <see cref = "HEAP_OPTIMIZE_RESOURCES_INFORMATION"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HEAP_OPTIMIZE_RESOURCES_INFORMATION>(), Is.EqualTo(sizeof(HEAP_OPTIMIZE_RESOURCES_INFORMATION)));
    }

    /// <summary>Validates that the <see cref = "HEAP_OPTIMIZE_RESOURCES_INFORMATION"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HEAP_OPTIMIZE_RESOURCES_INFORMATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HEAP_OPTIMIZE_RESOURCES_INFORMATION"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HEAP_OPTIMIZE_RESOURCES_INFORMATION), Is.EqualTo(8));
    }
}