// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "CSV_QUERY_MDS_PATH"/> struct.</summary>
public static unsafe partial class CSV_QUERY_MDS_PATHTests
{
    /// <summary>Validates that the <see cref = "CSV_QUERY_MDS_PATH"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CSV_QUERY_MDS_PATH>(), Is.EqualTo(sizeof(CSV_QUERY_MDS_PATH)));
    }

    /// <summary>Validates that the <see cref = "CSV_QUERY_MDS_PATH"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CSV_QUERY_MDS_PATH).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CSV_QUERY_MDS_PATH"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(CSV_QUERY_MDS_PATH), Is.EqualTo(16));
    }
}
