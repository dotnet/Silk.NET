// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ISyncMgrSyncCallback"/> struct.</summary>
public static unsafe partial class ISyncMgrSyncCallbackTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ISyncMgrSyncCallback"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISyncMgrSyncCallback).GUID, Is.EqualTo(IID_ISyncMgrSyncCallback));
    }

    /// <summary>Validates that the <see cref = "ISyncMgrSyncCallback"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISyncMgrSyncCallback>(), Is.EqualTo(sizeof(ISyncMgrSyncCallback)));
    }

    /// <summary>Validates that the <see cref = "ISyncMgrSyncCallback"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISyncMgrSyncCallback).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ISyncMgrSyncCallback"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISyncMgrSyncCallback), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISyncMgrSyncCallback), Is.EqualTo(4));
        }
    }
}