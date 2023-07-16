// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/HLink.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "HLBWINFO"/> struct.</summary>
public static unsafe partial class HLBWINFOTests
{
    /// <summary>Validates that the <see cref = "HLBWINFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HLBWINFO>(), Is.EqualTo(sizeof(HLBWINFO)));
    }

    /// <summary>Validates that the <see cref = "HLBWINFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HLBWINFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HLBWINFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HLBWINFO), Is.EqualTo(60));
    }
}