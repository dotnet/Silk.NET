// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "BITMAPV5HEADER"/> struct.</summary>
public static unsafe partial class BITMAPV5HEADERTests
{
    /// <summary>Validates that the <see cref = "BITMAPV5HEADER"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<BITMAPV5HEADER>(), Is.EqualTo(sizeof(BITMAPV5HEADER)));
    }

    /// <summary>Validates that the <see cref = "BITMAPV5HEADER"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(BITMAPV5HEADER).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "BITMAPV5HEADER"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(BITMAPV5HEADER), Is.EqualTo(124));
    }
}