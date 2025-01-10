// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DWRITE_LINE_BREAKPOINT"/> struct.</summary>
public static unsafe partial class DWRITE_LINE_BREAKPOINTTests
{
    /// <summary>Validates that the <see cref = "DWRITE_LINE_BREAKPOINT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DWRITE_LINE_BREAKPOINT>(),
            Is.EqualTo(sizeof(DWRITE_LINE_BREAKPOINT))
        );
    }

    /// <summary>Validates that the <see cref = "DWRITE_LINE_BREAKPOINT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DWRITE_LINE_BREAKPOINT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DWRITE_LINE_BREAKPOINT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DWRITE_LINE_BREAKPOINT), Is.EqualTo(1));
    }
}
