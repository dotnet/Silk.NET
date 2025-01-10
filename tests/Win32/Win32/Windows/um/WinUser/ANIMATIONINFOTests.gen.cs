// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "ANIMATIONINFO"/> struct.</summary>
public static unsafe partial class ANIMATIONINFOTests
{
    /// <summary>Validates that the <see cref = "ANIMATIONINFO"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ANIMATIONINFO>(), Is.EqualTo(sizeof(ANIMATIONINFO)));
    }

    /// <summary>Validates that the <see cref = "ANIMATIONINFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ANIMATIONINFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ANIMATIONINFO"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ANIMATIONINFO), Is.EqualTo(8));
    }
}
