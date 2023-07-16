// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MFVideoInfo"/> struct.</summary>
public static unsafe partial class MFVideoInfoTests
{
    /// <summary>Validates that the <see cref = "MFVideoInfo"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MFVideoInfo>(), Is.EqualTo(sizeof(MFVideoInfo)));
    }

    /// <summary>Validates that the <see cref = "MFVideoInfo"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MFVideoInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MFVideoInfo"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MFVideoInfo), Is.EqualTo(112));
    }
}