// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "WICJpegScanHeader"/> struct.</summary>
public static unsafe partial class WICJpegScanHeaderTests
{
    /// <summary>Validates that the <see cref = "WICJpegScanHeader"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WICJpegScanHeader>(), Is.EqualTo(sizeof(WICJpegScanHeader)));
    }

    /// <summary>Validates that the <see cref = "WICJpegScanHeader"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WICJpegScanHeader).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WICJpegScanHeader"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WICJpegScanHeader), Is.EqualTo(20));
    }
}