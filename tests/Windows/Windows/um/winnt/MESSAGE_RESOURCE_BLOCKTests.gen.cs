// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MESSAGE_RESOURCE_BLOCK"/> struct.</summary>
public static unsafe partial class MESSAGE_RESOURCE_BLOCKTests
{
    /// <summary>Validates that the <see cref = "MESSAGE_RESOURCE_BLOCK"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MESSAGE_RESOURCE_BLOCK>(), Is.EqualTo(sizeof(MESSAGE_RESOURCE_BLOCK)));
    }

    /// <summary>Validates that the <see cref = "MESSAGE_RESOURCE_BLOCK"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MESSAGE_RESOURCE_BLOCK).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MESSAGE_RESOURCE_BLOCK"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MESSAGE_RESOURCE_BLOCK), Is.EqualTo(12));
    }
}