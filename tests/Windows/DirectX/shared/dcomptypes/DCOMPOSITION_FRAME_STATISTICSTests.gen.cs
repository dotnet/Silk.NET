// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DCOMPOSITION_FRAME_STATISTICS"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class DCOMPOSITION_FRAME_STATISTICSTests
{
    /// <summary>Validates that the <see cref = "DCOMPOSITION_FRAME_STATISTICS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DCOMPOSITION_FRAME_STATISTICS>(), Is.EqualTo(sizeof(DCOMPOSITION_FRAME_STATISTICS)));
    }

    /// <summary>Validates that the <see cref = "DCOMPOSITION_FRAME_STATISTICS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DCOMPOSITION_FRAME_STATISTICS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DCOMPOSITION_FRAME_STATISTICS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DCOMPOSITION_FRAME_STATISTICS), Is.EqualTo(40));
    }
}