// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SHITEMID"/> struct.</summary>
public static unsafe partial class SHITEMIDTests
{
    /// <summary>Validates that the <see cref = "SHITEMID"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SHITEMID>(), Is.EqualTo(sizeof(SHITEMID)));
    }

    /// <summary>Validates that the <see cref = "SHITEMID"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SHITEMID).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SHITEMID"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SHITEMID), Is.EqualTo(3));
    }
}