// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "PLEX_READ_DATA_REQUEST"/> struct.</summary>
public static unsafe partial class PLEX_READ_DATA_REQUESTTests
{
    /// <summary>Validates that the <see cref = "PLEX_READ_DATA_REQUEST"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<PLEX_READ_DATA_REQUEST>(),
            Is.EqualTo(sizeof(PLEX_READ_DATA_REQUEST))
        );
    }

    /// <summary>Validates that the <see cref = "PLEX_READ_DATA_REQUEST"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PLEX_READ_DATA_REQUEST).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PLEX_READ_DATA_REQUEST"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(PLEX_READ_DATA_REQUEST), Is.EqualTo(16));
    }
}
