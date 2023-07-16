// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ISyncMgrEventStore"/> struct.</summary>
public static unsafe partial class ISyncMgrEventStoreTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ISyncMgrEventStore"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISyncMgrEventStore).GUID, Is.EqualTo(IID_ISyncMgrEventStore));
    }

    /// <summary>Validates that the <see cref = "ISyncMgrEventStore"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISyncMgrEventStore>(), Is.EqualTo(sizeof(ISyncMgrEventStore)));
    }

    /// <summary>Validates that the <see cref = "ISyncMgrEventStore"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISyncMgrEventStore).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ISyncMgrEventStore"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISyncMgrEventStore), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISyncMgrEventStore), Is.EqualTo(4));
        }
    }
}