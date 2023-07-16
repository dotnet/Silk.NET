// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/TextStor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "TS_TEXTCHANGE"/> struct.</summary>
public static unsafe partial class TS_TEXTCHANGETests
{
    /// <summary>Validates that the <see cref = "TS_TEXTCHANGE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TS_TEXTCHANGE>(), Is.EqualTo(sizeof(TS_TEXTCHANGE)));
    }

    /// <summary>Validates that the <see cref = "TS_TEXTCHANGE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TS_TEXTCHANGE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TS_TEXTCHANGE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TS_TEXTCHANGE), Is.EqualTo(12));
    }
}