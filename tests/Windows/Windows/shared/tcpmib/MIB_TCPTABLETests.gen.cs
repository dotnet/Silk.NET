// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MIB_TCPTABLE"/> struct.</summary>
public static unsafe partial class MIB_TCPTABLETests
{
    /// <summary>Validates that the <see cref = "MIB_TCPTABLE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MIB_TCPTABLE>(), Is.EqualTo(sizeof(MIB_TCPTABLE)));
    }

    /// <summary>Validates that the <see cref = "MIB_TCPTABLE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MIB_TCPTABLE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MIB_TCPTABLE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MIB_TCPTABLE), Is.EqualTo(24));
    }
}