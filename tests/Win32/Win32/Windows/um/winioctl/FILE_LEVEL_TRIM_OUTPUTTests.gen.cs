// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "FILE_LEVEL_TRIM_OUTPUT"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class FILE_LEVEL_TRIM_OUTPUTTests
{
    /// <summary>Validates that the <see cref = "FILE_LEVEL_TRIM_OUTPUT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<FILE_LEVEL_TRIM_OUTPUT>(),
            Is.EqualTo(sizeof(FILE_LEVEL_TRIM_OUTPUT))
        );
    }

    /// <summary>Validates that the <see cref = "FILE_LEVEL_TRIM_OUTPUT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FILE_LEVEL_TRIM_OUTPUT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "FILE_LEVEL_TRIM_OUTPUT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(FILE_LEVEL_TRIM_OUTPUT), Is.EqualTo(4));
    }
}
