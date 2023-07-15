// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ISyncMgrConflictPresenter"/> struct.</summary>
public static unsafe partial class ISyncMgrConflictPresenterTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ISyncMgrConflictPresenter"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISyncMgrConflictPresenter).GUID, Is.EqualTo(IID_ISyncMgrConflictPresenter));
    }

    /// <summary>Validates that the <see cref = "ISyncMgrConflictPresenter"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISyncMgrConflictPresenter>(), Is.EqualTo(sizeof(ISyncMgrConflictPresenter)));
    }

    /// <summary>Validates that the <see cref = "ISyncMgrConflictPresenter"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISyncMgrConflictPresenter).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ISyncMgrConflictPresenter"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISyncMgrConflictPresenter), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISyncMgrConflictPresenter), Is.EqualTo(4));
        }
    }
}