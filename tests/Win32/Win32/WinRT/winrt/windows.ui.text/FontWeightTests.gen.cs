// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "FontWeight"/> struct.</summary>
public static unsafe partial class FontWeightTests
{
    /// <summary>Validates that the <see cref = "FontWeight"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FontWeight>(), Is.EqualTo(sizeof(FontWeight)));
    }

    /// <summary>Validates that the <see cref = "FontWeight"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FontWeight).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "FontWeight"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(FontWeight), Is.EqualTo(2));
    }
}
