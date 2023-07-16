// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "REMOVE_ELEMENT_AND_TRUNCATE_REQUEST"/> struct.</summary>
public static unsafe partial class REMOVE_ELEMENT_AND_TRUNCATE_REQUESTTests
{
    /// <summary>Validates that the <see cref = "REMOVE_ELEMENT_AND_TRUNCATE_REQUEST"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<REMOVE_ELEMENT_AND_TRUNCATE_REQUEST>(), Is.EqualTo(sizeof(REMOVE_ELEMENT_AND_TRUNCATE_REQUEST)));
    }

    /// <summary>Validates that the <see cref = "REMOVE_ELEMENT_AND_TRUNCATE_REQUEST"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(REMOVE_ELEMENT_AND_TRUNCATE_REQUEST).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "REMOVE_ELEMENT_AND_TRUNCATE_REQUEST"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(REMOVE_ELEMENT_AND_TRUNCATE_REQUEST), Is.EqualTo(24));
    }
}