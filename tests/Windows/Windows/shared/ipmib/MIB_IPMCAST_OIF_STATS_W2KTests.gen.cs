// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MIB_IPMCAST_OIF_STATS_W2K"/> struct.</summary>
public static unsafe partial class MIB_IPMCAST_OIF_STATS_W2KTests
{
    /// <summary>Validates that the <see cref = "MIB_IPMCAST_OIF_STATS_W2K"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MIB_IPMCAST_OIF_STATS_W2K>(), Is.EqualTo(sizeof(MIB_IPMCAST_OIF_STATS_W2K)));
    }

    /// <summary>Validates that the <see cref = "MIB_IPMCAST_OIF_STATS_W2K"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MIB_IPMCAST_OIF_STATS_W2K).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MIB_IPMCAST_OIF_STATS_W2K"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(MIB_IPMCAST_OIF_STATS_W2K), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(MIB_IPMCAST_OIF_STATS_W2K), Is.EqualTo(28));
        }
    }
}