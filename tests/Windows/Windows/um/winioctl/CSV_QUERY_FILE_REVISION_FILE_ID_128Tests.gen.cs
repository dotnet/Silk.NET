// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CSV_QUERY_FILE_REVISION_FILE_ID_128"/> struct.</summary>
public static unsafe partial class CSV_QUERY_FILE_REVISION_FILE_ID_128Tests
{
    /// <summary>Validates that the <see cref = "CSV_QUERY_FILE_REVISION_FILE_ID_128"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CSV_QUERY_FILE_REVISION_FILE_ID_128>(), Is.EqualTo(sizeof(CSV_QUERY_FILE_REVISION_FILE_ID_128)));
    }

    /// <summary>Validates that the <see cref = "CSV_QUERY_FILE_REVISION_FILE_ID_128"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CSV_QUERY_FILE_REVISION_FILE_ID_128).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CSV_QUERY_FILE_REVISION_FILE_ID_128"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(CSV_QUERY_FILE_REVISION_FILE_ID_128), Is.EqualTo(40));
    }
}