// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "STORAGE_QUERY_DEPENDENT_VOLUME_RESPONSE"/> struct.</summary>
public static unsafe partial class STORAGE_QUERY_DEPENDENT_VOLUME_RESPONSETests
{
    /// <summary>Validates that the <see cref = "STORAGE_QUERY_DEPENDENT_VOLUME_RESPONSE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<STORAGE_QUERY_DEPENDENT_VOLUME_RESPONSE>(), Is.EqualTo(sizeof(STORAGE_QUERY_DEPENDENT_VOLUME_RESPONSE)));
    }

    /// <summary>Validates that the <see cref = "STORAGE_QUERY_DEPENDENT_VOLUME_RESPONSE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(STORAGE_QUERY_DEPENDENT_VOLUME_RESPONSE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "STORAGE_QUERY_DEPENDENT_VOLUME_RESPONSE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(STORAGE_QUERY_DEPENDENT_VOLUME_RESPONSE), Is.EqualTo(76));
    }
}