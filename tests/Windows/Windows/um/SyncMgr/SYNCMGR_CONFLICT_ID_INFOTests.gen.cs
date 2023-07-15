// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SYNCMGR_CONFLICT_ID_INFO"/> struct.</summary>
public static unsafe partial class SYNCMGR_CONFLICT_ID_INFOTests
{
    /// <summary>Validates that the <see cref = "SYNCMGR_CONFLICT_ID_INFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SYNCMGR_CONFLICT_ID_INFO>(), Is.EqualTo(sizeof(SYNCMGR_CONFLICT_ID_INFO)));
    }

    /// <summary>Validates that the <see cref = "SYNCMGR_CONFLICT_ID_INFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SYNCMGR_CONFLICT_ID_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SYNCMGR_CONFLICT_ID_INFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SYNCMGR_CONFLICT_ID_INFO), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(SYNCMGR_CONFLICT_ID_INFO), Is.EqualTo(8));
        }
    }
}