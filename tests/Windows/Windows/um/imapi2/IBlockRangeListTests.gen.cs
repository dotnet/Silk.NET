// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IBlockRangeList"/> struct.</summary>
public static unsafe partial class IBlockRangeListTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IBlockRangeList"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IBlockRangeList).GUID, Is.EqualTo(IID_IBlockRangeList));
    }

    /// <summary>Validates that the <see cref = "IBlockRangeList"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IBlockRangeList>(), Is.EqualTo(sizeof(IBlockRangeList)));
    }

    /// <summary>Validates that the <see cref = "IBlockRangeList"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IBlockRangeList).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IBlockRangeList"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IBlockRangeList), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IBlockRangeList), Is.EqualTo(4));
        }
    }
}