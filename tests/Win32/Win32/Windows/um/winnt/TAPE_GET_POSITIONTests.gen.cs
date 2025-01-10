// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "TAPE_GET_POSITION"/> struct.</summary>
public static unsafe partial class TAPE_GET_POSITIONTests
{
    /// <summary>Validates that the <see cref = "TAPE_GET_POSITION"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TAPE_GET_POSITION>(), Is.EqualTo(sizeof(TAPE_GET_POSITION)));
    }

    /// <summary>Validates that the <see cref = "TAPE_GET_POSITION"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TAPE_GET_POSITION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TAPE_GET_POSITION"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TAPE_GET_POSITION), Is.EqualTo(16));
    }
}
