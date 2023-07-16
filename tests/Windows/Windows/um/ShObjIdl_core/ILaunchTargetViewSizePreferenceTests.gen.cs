// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ILaunchTargetViewSizePreference"/> struct.</summary>
public static unsafe partial class ILaunchTargetViewSizePreferenceTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ILaunchTargetViewSizePreference"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ILaunchTargetViewSizePreference).GUID, Is.EqualTo(IID_ILaunchTargetViewSizePreference));
    }

    /// <summary>Validates that the <see cref = "ILaunchTargetViewSizePreference"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ILaunchTargetViewSizePreference>(), Is.EqualTo(sizeof(ILaunchTargetViewSizePreference)));
    }

    /// <summary>Validates that the <see cref = "ILaunchTargetViewSizePreference"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ILaunchTargetViewSizePreference).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ILaunchTargetViewSizePreference"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ILaunchTargetViewSizePreference), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ILaunchTargetViewSizePreference), Is.EqualTo(4));
        }
    }
}