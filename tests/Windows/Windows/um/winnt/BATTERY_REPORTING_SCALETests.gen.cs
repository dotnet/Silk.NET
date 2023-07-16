// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "BATTERY_REPORTING_SCALE"/> struct.</summary>
public static unsafe partial class BATTERY_REPORTING_SCALETests
{
    /// <summary>Validates that the <see cref = "BATTERY_REPORTING_SCALE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<BATTERY_REPORTING_SCALE>(), Is.EqualTo(sizeof(BATTERY_REPORTING_SCALE)));
    }

    /// <summary>Validates that the <see cref = "BATTERY_REPORTING_SCALE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(BATTERY_REPORTING_SCALE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "BATTERY_REPORTING_SCALE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(BATTERY_REPORTING_SCALE), Is.EqualTo(8));
    }
}