// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CROSS_SLIDE_PARAMETER"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class CROSS_SLIDE_PARAMETERTests
{
    /// <summary>Validates that the <see cref = "CROSS_SLIDE_PARAMETER"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CROSS_SLIDE_PARAMETER>(), Is.EqualTo(sizeof(CROSS_SLIDE_PARAMETER)));
    }

    /// <summary>Validates that the <see cref = "CROSS_SLIDE_PARAMETER"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CROSS_SLIDE_PARAMETER).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CROSS_SLIDE_PARAMETER"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(CROSS_SLIDE_PARAMETER), Is.EqualTo(8));
    }
}