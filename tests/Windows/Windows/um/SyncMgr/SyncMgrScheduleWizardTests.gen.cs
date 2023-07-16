// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SyncMgrScheduleWizard"/> struct.</summary>
public static unsafe partial class SyncMgrScheduleWizardTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "SyncMgrScheduleWizard"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(SyncMgrScheduleWizard).GUID, Is.EqualTo(IID_SyncMgrScheduleWizard));
    }

    /// <summary>Validates that the <see cref = "SyncMgrScheduleWizard"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SyncMgrScheduleWizard>(), Is.EqualTo(sizeof(SyncMgrScheduleWizard)));
    }

    /// <summary>Validates that the <see cref = "SyncMgrScheduleWizard"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SyncMgrScheduleWizard).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SyncMgrScheduleWizard"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SyncMgrScheduleWizard), Is.EqualTo(1));
    }
}