// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "HISTOGRAM_BUCKET"/> struct.</summary>
public static unsafe partial class HISTOGRAM_BUCKETTests
{
    /// <summary>Validates that the <see cref = "HISTOGRAM_BUCKET"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HISTOGRAM_BUCKET>(), Is.EqualTo(sizeof(HISTOGRAM_BUCKET)));
    }

    /// <summary>Validates that the <see cref = "HISTOGRAM_BUCKET"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HISTOGRAM_BUCKET).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HISTOGRAM_BUCKET"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HISTOGRAM_BUCKET), Is.EqualTo(8));
    }
}
