// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "NUMA_NODE_RELATIONSHIP"/> struct.</summary>
public static unsafe partial class NUMA_NODE_RELATIONSHIPTests
{
    /// <summary>Validates that the <see cref = "NUMA_NODE_RELATIONSHIP"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<NUMA_NODE_RELATIONSHIP>(), Is.EqualTo(sizeof(NUMA_NODE_RELATIONSHIP)));
    }

    /// <summary>Validates that the <see cref = "NUMA_NODE_RELATIONSHIP"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(NUMA_NODE_RELATIONSHIP).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "NUMA_NODE_RELATIONSHIP"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(NUMA_NODE_RELATIONSHIP), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(NUMA_NODE_RELATIONSHIP), Is.EqualTo(36));
        }
    }
}