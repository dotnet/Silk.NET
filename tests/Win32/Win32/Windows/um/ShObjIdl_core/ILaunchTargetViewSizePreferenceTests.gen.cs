// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "ILaunchTargetViewSizePreference"/> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class ILaunchTargetViewSizePreferenceTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ILaunchTargetViewSizePreference"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(ILaunchTargetViewSizePreference).GUID,
            Is.EqualTo(IID_ILaunchTargetViewSizePreference)
        );
    }

    /// <summary>Validates that the <see cref = "ILaunchTargetViewSizePreference"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ILaunchTargetViewSizePreference>(),
            Is.EqualTo(sizeof(ILaunchTargetViewSizePreference))
        );
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
