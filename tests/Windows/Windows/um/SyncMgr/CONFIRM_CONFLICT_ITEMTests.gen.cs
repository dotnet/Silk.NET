// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CONFIRM_CONFLICT_ITEM"/> struct.</summary>
public static unsafe partial class CONFIRM_CONFLICT_ITEMTests
{
    /// <summary>Validates that the <see cref = "CONFIRM_CONFLICT_ITEM"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CONFIRM_CONFLICT_ITEM>(), Is.EqualTo(sizeof(CONFIRM_CONFLICT_ITEM)));
    }

    /// <summary>Validates that the <see cref = "CONFIRM_CONFLICT_ITEM"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CONFIRM_CONFLICT_ITEM).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CONFIRM_CONFLICT_ITEM"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CONFIRM_CONFLICT_ITEM), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(CONFIRM_CONFLICT_ITEM), Is.EqualTo(24));
        }
    }
}