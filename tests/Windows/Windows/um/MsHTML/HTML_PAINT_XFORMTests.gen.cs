// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "HTML_PAINT_XFORM"/> struct.</summary>
public static unsafe partial class HTML_PAINT_XFORMTests
{
    /// <summary>Validates that the <see cref = "HTML_PAINT_XFORM"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HTML_PAINT_XFORM>(), Is.EqualTo(sizeof(HTML_PAINT_XFORM)));
    }

    /// <summary>Validates that the <see cref = "HTML_PAINT_XFORM"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HTML_PAINT_XFORM).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HTML_PAINT_XFORM"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HTML_PAINT_XFORM), Is.EqualTo(24));
    }
}