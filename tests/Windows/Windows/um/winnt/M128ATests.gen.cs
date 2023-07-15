// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "M128A"/> struct.</summary>
public static unsafe partial class M128ATests
{
    /// <summary>Validates that the <see cref = "M128A"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<M128A>(), Is.EqualTo(sizeof(M128A)));
    }

    /// <summary>Validates that the <see cref = "M128A"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(M128A).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "M128A"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(M128A), Is.EqualTo(16));
    }
}