// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "COPYFILE2_CREATE_OPLOCK_KEYS"/> struct.</summary>
public static unsafe partial class COPYFILE2_CREATE_OPLOCK_KEYSTests
{
    /// <summary>Validates that the <see cref = "COPYFILE2_CREATE_OPLOCK_KEYS"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<COPYFILE2_CREATE_OPLOCK_KEYS>(),
            Is.EqualTo(sizeof(COPYFILE2_CREATE_OPLOCK_KEYS))
        );
    }

    /// <summary>Validates that the <see cref = "COPYFILE2_CREATE_OPLOCK_KEYS"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(COPYFILE2_CREATE_OPLOCK_KEYS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "COPYFILE2_CREATE_OPLOCK_KEYS"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(COPYFILE2_CREATE_OPLOCK_KEYS), Is.EqualTo(32));
    }
}
