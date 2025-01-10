// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "ACTCTX_SECTION_KEYED_DATA_2600"/> struct.</summary>
public static unsafe partial class ACTCTX_SECTION_KEYED_DATA_2600Tests
{
    /// <summary>Validates that the <see cref = "ACTCTX_SECTION_KEYED_DATA_2600"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ACTCTX_SECTION_KEYED_DATA_2600>(),
            Is.EqualTo(sizeof(ACTCTX_SECTION_KEYED_DATA_2600))
        );
    }

    /// <summary>Validates that the <see cref = "ACTCTX_SECTION_KEYED_DATA_2600"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ACTCTX_SECTION_KEYED_DATA_2600).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ACTCTX_SECTION_KEYED_DATA_2600"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ACTCTX_SECTION_KEYED_DATA_2600), Is.EqualTo(72));
        }
        else
        {
            Assert.That(sizeof(ACTCTX_SECTION_KEYED_DATA_2600), Is.EqualTo(40));
        }
    }
}
