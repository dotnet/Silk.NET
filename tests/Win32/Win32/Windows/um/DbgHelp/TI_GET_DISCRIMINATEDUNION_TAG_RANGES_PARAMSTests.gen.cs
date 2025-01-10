// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "TI_GET_DISCRIMINATEDUNION_TAG_RANGES_PARAMS"/> struct.</summary>
public static unsafe partial class TI_GET_DISCRIMINATEDUNION_TAG_RANGES_PARAMSTests
{
    /// <summary>Validates that the <see cref = "TI_GET_DISCRIMINATEDUNION_TAG_RANGES_PARAMS"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<TI_GET_DISCRIMINATEDUNION_TAG_RANGES_PARAMS>(),
            Is.EqualTo(sizeof(TI_GET_DISCRIMINATEDUNION_TAG_RANGES_PARAMS))
        );
    }

    /// <summary>Validates that the <see cref = "TI_GET_DISCRIMINATEDUNION_TAG_RANGES_PARAMS"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(
            typeof(TI_GET_DISCRIMINATEDUNION_TAG_RANGES_PARAMS).IsLayoutSequential,
            Is.True
        );
    }

    /// <summary>Validates that the <see cref = "TI_GET_DISCRIMINATEDUNION_TAG_RANGES_PARAMS"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TI_GET_DISCRIMINATEDUNION_TAG_RANGES_PARAMS), Is.EqualTo(28));
    }
}
