// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MIDIOUTCAPS2A"/> struct.</summary>
public static unsafe partial class MIDIOUTCAPS2ATests
{
    /// <summary>Validates that the <see cref = "MIDIOUTCAPS2A"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MIDIOUTCAPS2A>(), Is.EqualTo(sizeof(MIDIOUTCAPS2A)));
    }

    /// <summary>Validates that the <see cref = "MIDIOUTCAPS2A"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MIDIOUTCAPS2A).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MIDIOUTCAPS2A"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MIDIOUTCAPS2A), Is.EqualTo(100));
    }
}