// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/evntprov.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "EVENT_FILTER_LEVEL_KW"/> struct.</summary>
public static unsafe partial class EVENT_FILTER_LEVEL_KWTests
{
    /// <summary>Validates that the <see cref = "EVENT_FILTER_LEVEL_KW"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<EVENT_FILTER_LEVEL_KW>(), Is.EqualTo(sizeof(EVENT_FILTER_LEVEL_KW)));
    }

    /// <summary>Validates that the <see cref = "EVENT_FILTER_LEVEL_KW"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EVENT_FILTER_LEVEL_KW).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "EVENT_FILTER_LEVEL_KW"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(EVENT_FILTER_LEVEL_KW), Is.EqualTo(24));
    }
}