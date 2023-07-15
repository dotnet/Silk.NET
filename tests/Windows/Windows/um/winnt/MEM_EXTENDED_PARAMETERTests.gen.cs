// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MEM_EXTENDED_PARAMETER"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class MEM_EXTENDED_PARAMETERTests
{
    /// <summary>Validates that the <see cref = "MEM_EXTENDED_PARAMETER"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MEM_EXTENDED_PARAMETER>(), Is.EqualTo(sizeof(MEM_EXTENDED_PARAMETER)));
    }

    /// <summary>Validates that the <see cref = "MEM_EXTENDED_PARAMETER"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MEM_EXTENDED_PARAMETER).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MEM_EXTENDED_PARAMETER"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MEM_EXTENDED_PARAMETER), Is.EqualTo(16));
    }
}