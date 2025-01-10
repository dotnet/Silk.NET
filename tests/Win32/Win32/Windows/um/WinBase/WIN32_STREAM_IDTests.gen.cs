// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "WIN32_STREAM_ID"/> struct.</summary>
public static unsafe partial class WIN32_STREAM_IDTests
{
    /// <summary>Validates that the <see cref = "WIN32_STREAM_ID"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WIN32_STREAM_ID>(), Is.EqualTo(sizeof(WIN32_STREAM_ID)));
    }

    /// <summary>Validates that the <see cref = "WIN32_STREAM_ID"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WIN32_STREAM_ID).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WIN32_STREAM_ID"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WIN32_STREAM_ID), Is.EqualTo(24));
    }
}
