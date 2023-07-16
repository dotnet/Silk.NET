// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/nldef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "NL_INTERFACE_OFFLOAD_ROD"/> struct.</summary>
public static unsafe partial class NL_INTERFACE_OFFLOAD_RODTests
{
    /// <summary>Validates that the <see cref = "NL_INTERFACE_OFFLOAD_ROD"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<NL_INTERFACE_OFFLOAD_ROD>(), Is.EqualTo(sizeof(NL_INTERFACE_OFFLOAD_ROD)));
    }

    /// <summary>Validates that the <see cref = "NL_INTERFACE_OFFLOAD_ROD"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(NL_INTERFACE_OFFLOAD_ROD).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "NL_INTERFACE_OFFLOAD_ROD"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(NL_INTERFACE_OFFLOAD_ROD), Is.EqualTo(1));
    }
}