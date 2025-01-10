// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "s_RIFFWAVE_inst"/> struct.</summary>
public static unsafe partial class s_RIFFWAVE_instTests
{
    /// <summary>Validates that the <see cref = "s_RIFFWAVE_inst"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<s_RIFFWAVE_inst>(), Is.EqualTo(sizeof(s_RIFFWAVE_inst)));
    }

    /// <summary>Validates that the <see cref = "s_RIFFWAVE_inst"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(s_RIFFWAVE_inst).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "s_RIFFWAVE_inst"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(s_RIFFWAVE_inst), Is.EqualTo(7));
    }
}
