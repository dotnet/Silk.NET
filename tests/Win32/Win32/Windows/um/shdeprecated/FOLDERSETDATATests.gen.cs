// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "FOLDERSETDATA"/> struct.</summary>
public static unsafe partial class FOLDERSETDATATests
{
    /// <summary>Validates that the <see cref = "FOLDERSETDATA"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FOLDERSETDATA>(), Is.EqualTo(sizeof(FOLDERSETDATA)));
    }

    /// <summary>Validates that the <see cref = "FOLDERSETDATA"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FOLDERSETDATA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "FOLDERSETDATA"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(FOLDERSETDATA), Is.EqualTo(28));
    }
}
