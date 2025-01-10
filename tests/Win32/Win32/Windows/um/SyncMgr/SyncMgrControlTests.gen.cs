// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "SyncMgrControl"/> struct.</summary>
public static unsafe partial class SyncMgrControlTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "SyncMgrControl"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(SyncMgrControl).GUID, Is.EqualTo(IID_SyncMgrControl));
    }

    /// <summary>Validates that the <see cref = "SyncMgrControl"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SyncMgrControl>(), Is.EqualTo(sizeof(SyncMgrControl)));
    }

    /// <summary>Validates that the <see cref = "SyncMgrControl"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SyncMgrControl).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SyncMgrControl"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SyncMgrControl), Is.EqualTo(1));
    }
}
