// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypesbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "BYTE_BLOB"/> struct.</summary>
public static unsafe partial class BYTE_BLOBTests
{
    /// <summary>Validates that the <see cref = "BYTE_BLOB"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<BYTE_BLOB>(), Is.EqualTo(sizeof(BYTE_BLOB)));
    }

    /// <summary>Validates that the <see cref = "BYTE_BLOB"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(BYTE_BLOB).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "BYTE_BLOB"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(BYTE_BLOB), Is.EqualTo(8));
    }
}