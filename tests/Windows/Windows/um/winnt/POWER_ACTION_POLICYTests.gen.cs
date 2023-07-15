// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "POWER_ACTION_POLICY"/> struct.</summary>
public static unsafe partial class POWER_ACTION_POLICYTests
{
    /// <summary>Validates that the <see cref = "POWER_ACTION_POLICY"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<POWER_ACTION_POLICY>(), Is.EqualTo(sizeof(POWER_ACTION_POLICY)));
    }

    /// <summary>Validates that the <see cref = "POWER_ACTION_POLICY"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(POWER_ACTION_POLICY).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "POWER_ACTION_POLICY"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(POWER_ACTION_POLICY), Is.EqualTo(12));
    }
}