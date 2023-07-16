// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "HW_PROFILE_INFOW"/> struct.</summary>
public static unsafe partial class HW_PROFILE_INFOWTests
{
    /// <summary>Validates that the <see cref = "HW_PROFILE_INFOW"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HW_PROFILE_INFOW>(), Is.EqualTo(sizeof(HW_PROFILE_INFOW)));
    }

    /// <summary>Validates that the <see cref = "HW_PROFILE_INFOW"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HW_PROFILE_INFOW).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HW_PROFILE_INFOW"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HW_PROFILE_INFOW), Is.EqualTo(244));
    }
}