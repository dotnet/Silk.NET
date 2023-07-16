// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ISyncMgrSynchronize"/> struct.</summary>
public static unsafe partial class ISyncMgrSynchronizeTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ISyncMgrSynchronize"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISyncMgrSynchronize).GUID, Is.EqualTo(IID_ISyncMgrSynchronize));
    }

    /// <summary>Validates that the <see cref = "ISyncMgrSynchronize"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISyncMgrSynchronize>(), Is.EqualTo(sizeof(ISyncMgrSynchronize)));
    }

    /// <summary>Validates that the <see cref = "ISyncMgrSynchronize"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISyncMgrSynchronize).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ISyncMgrSynchronize"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISyncMgrSynchronize), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISyncMgrSynchronize), Is.EqualTo(4));
        }
    }
}