// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MF_SINK_WRITER_STATISTICS"/> struct.</summary>
public static unsafe partial class MF_SINK_WRITER_STATISTICSTests
{
    /// <summary>Validates that the <see cref = "MF_SINK_WRITER_STATISTICS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MF_SINK_WRITER_STATISTICS>(), Is.EqualTo(sizeof(MF_SINK_WRITER_STATISTICS)));
    }

    /// <summary>Validates that the <see cref = "MF_SINK_WRITER_STATISTICS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MF_SINK_WRITER_STATISTICS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MF_SINK_WRITER_STATISTICS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MF_SINK_WRITER_STATISTICS), Is.EqualTo(112));
    }
}