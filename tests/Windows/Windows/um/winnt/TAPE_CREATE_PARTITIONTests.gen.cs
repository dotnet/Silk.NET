// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "TAPE_CREATE_PARTITION"/> struct.</summary>
public static unsafe partial class TAPE_CREATE_PARTITIONTests
{
    /// <summary>Validates that the <see cref = "TAPE_CREATE_PARTITION"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TAPE_CREATE_PARTITION>(), Is.EqualTo(sizeof(TAPE_CREATE_PARTITION)));
    }

    /// <summary>Validates that the <see cref = "TAPE_CREATE_PARTITION"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TAPE_CREATE_PARTITION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TAPE_CREATE_PARTITION"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TAPE_CREATE_PARTITION), Is.EqualTo(12));
    }
}