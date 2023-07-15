// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MIB_MFE_STATS_TABLE_EX_XP"/> struct.</summary>
public static unsafe partial class MIB_MFE_STATS_TABLE_EX_XPTests
{
    /// <summary>Validates that the <see cref = "MIB_MFE_STATS_TABLE_EX_XP"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MIB_MFE_STATS_TABLE_EX_XP>(), Is.EqualTo(sizeof(MIB_MFE_STATS_TABLE_EX_XP)));
    }

    /// <summary>Validates that the <see cref = "MIB_MFE_STATS_TABLE_EX_XP"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MIB_MFE_STATS_TABLE_EX_XP).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MIB_MFE_STATS_TABLE_EX_XP"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(MIB_MFE_STATS_TABLE_EX_XP), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(MIB_MFE_STATS_TABLE_EX_XP), Is.EqualTo(8));
        }
    }
}