// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "LARGE_INTEGER"/> struct.</summary>
public static unsafe partial class LARGE_INTEGERTests
{
    /// <summary>Validates that the <see cref = "LARGE_INTEGER"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<LARGE_INTEGER>(), Is.EqualTo(sizeof(LARGE_INTEGER)));
    }

    /// <summary>Validates that the <see cref = "LARGE_INTEGER"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutExplicitTest()
    {
        Assert.That(typeof(LARGE_INTEGER).IsExplicitLayout, Is.True);
    }

    /// <summary>Validates that the <see cref = "LARGE_INTEGER"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(LARGE_INTEGER), Is.EqualTo(8));
    }
}