// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "FILE_LAYOUT_NAME_ENTRY"/> struct.</summary>
public static unsafe partial class FILE_LAYOUT_NAME_ENTRYTests
{
    /// <summary>Validates that the <see cref = "FILE_LAYOUT_NAME_ENTRY"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FILE_LAYOUT_NAME_ENTRY>(), Is.EqualTo(sizeof(FILE_LAYOUT_NAME_ENTRY)));
    }

    /// <summary>Validates that the <see cref = "FILE_LAYOUT_NAME_ENTRY"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FILE_LAYOUT_NAME_ENTRY).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "FILE_LAYOUT_NAME_ENTRY"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(FILE_LAYOUT_NAME_ENTRY), Is.EqualTo(32));
    }
}