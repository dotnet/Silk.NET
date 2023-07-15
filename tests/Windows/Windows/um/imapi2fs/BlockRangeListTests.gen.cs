// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "BlockRangeList"/> struct.</summary>
public static unsafe partial class BlockRangeListTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "BlockRangeList"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(BlockRangeList).GUID, Is.EqualTo(CLSID_BlockRangeList));
    }

    /// <summary>Validates that the <see cref = "BlockRangeList"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<BlockRangeList>(), Is.EqualTo(sizeof(BlockRangeList)));
    }

    /// <summary>Validates that the <see cref = "BlockRangeList"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(BlockRangeList).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "BlockRangeList"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(BlockRangeList), Is.EqualTo(1));
    }
}