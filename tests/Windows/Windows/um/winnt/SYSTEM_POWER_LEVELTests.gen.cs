// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SYSTEM_POWER_LEVEL"/> struct.</summary>
public static unsafe partial class SYSTEM_POWER_LEVELTests
{
    /// <summary>Validates that the <see cref = "SYSTEM_POWER_LEVEL"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SYSTEM_POWER_LEVEL>(), Is.EqualTo(sizeof(SYSTEM_POWER_LEVEL)));
    }

    /// <summary>Validates that the <see cref = "SYSTEM_POWER_LEVEL"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SYSTEM_POWER_LEVEL).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SYSTEM_POWER_LEVEL"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SYSTEM_POWER_LEVEL), Is.EqualTo(24));
    }
}