// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "FILE_REGION_INPUT"/> struct.</summary>
public static unsafe partial class FILE_REGION_INPUTTests
{
    /// <summary>Validates that the <see cref = "FILE_REGION_INPUT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FILE_REGION_INPUT>(), Is.EqualTo(sizeof(FILE_REGION_INPUT)));
    }

    /// <summary>Validates that the <see cref = "FILE_REGION_INPUT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FILE_REGION_INPUT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "FILE_REGION_INPUT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(FILE_REGION_INPUT), Is.EqualTo(24));
    }
}