// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ACCESS_ALLOWED_ACE"/> struct.</summary>
public static unsafe partial class ACCESS_ALLOWED_ACETests
{
    /// <summary>Validates that the <see cref = "ACCESS_ALLOWED_ACE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ACCESS_ALLOWED_ACE>(), Is.EqualTo(sizeof(ACCESS_ALLOWED_ACE)));
    }

    /// <summary>Validates that the <see cref = "ACCESS_ALLOWED_ACE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ACCESS_ALLOWED_ACE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ACCESS_ALLOWED_ACE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ACCESS_ALLOWED_ACE), Is.EqualTo(12));
    }
}