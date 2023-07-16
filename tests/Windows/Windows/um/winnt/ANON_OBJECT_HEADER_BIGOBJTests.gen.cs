// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ANON_OBJECT_HEADER_BIGOBJ"/> struct.</summary>
public static unsafe partial class ANON_OBJECT_HEADER_BIGOBJTests
{
    /// <summary>Validates that the <see cref = "ANON_OBJECT_HEADER_BIGOBJ"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ANON_OBJECT_HEADER_BIGOBJ>(), Is.EqualTo(sizeof(ANON_OBJECT_HEADER_BIGOBJ)));
    }

    /// <summary>Validates that the <see cref = "ANON_OBJECT_HEADER_BIGOBJ"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ANON_OBJECT_HEADER_BIGOBJ).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ANON_OBJECT_HEADER_BIGOBJ"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ANON_OBJECT_HEADER_BIGOBJ), Is.EqualTo(56));
    }
}