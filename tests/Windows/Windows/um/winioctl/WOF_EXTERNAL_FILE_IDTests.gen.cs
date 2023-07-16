// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "WOF_EXTERNAL_FILE_ID"/> struct.</summary>
public static unsafe partial class WOF_EXTERNAL_FILE_IDTests
{
    /// <summary>Validates that the <see cref = "WOF_EXTERNAL_FILE_ID"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WOF_EXTERNAL_FILE_ID>(), Is.EqualTo(sizeof(WOF_EXTERNAL_FILE_ID)));
    }

    /// <summary>Validates that the <see cref = "WOF_EXTERNAL_FILE_ID"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WOF_EXTERNAL_FILE_ID).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WOF_EXTERNAL_FILE_ID"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WOF_EXTERNAL_FILE_ID), Is.EqualTo(16));
    }
}