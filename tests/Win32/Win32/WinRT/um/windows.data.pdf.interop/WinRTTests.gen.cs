// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.data.pdf.interop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using Silk.NET.DirectX;
using static Silk.NET.WinRT.WinRT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "WinRT"/> class.</summary>
public static unsafe partial class WinRTTests
{
    /// <summary>Validates that the value of the <see cref = "sc_PdfRenderParamsDefaultSrcRect"/> property is correct.</summary>

    [Test]
    public static void sc_PdfRenderParamsDefaultSrcRectTest()
    {
        Assert.That(sc_PdfRenderParamsDefaultSrcRect.left, Is.EqualTo(0.0f));
        Assert.That(sc_PdfRenderParamsDefaultSrcRect.top, Is.EqualTo(0.0f));
        Assert.That(sc_PdfRenderParamsDefaultSrcRect.right, Is.EqualTo(0.0f));
        Assert.That(sc_PdfRenderParamsDefaultSrcRect.bottom, Is.EqualTo(0.0f));
    }

    /// <summary>Validates that the value of the <see cref = "sc_PdfRenderParamsDefaultBkColor"/> property is correct.</summary>

    [Test]
    public static void sc_PdfRenderParamsDefaultBkColorTest()
    {
        Assert.That(sc_PdfRenderParamsDefaultBkColor.r, Is.EqualTo(1.0f));
        Assert.That(sc_PdfRenderParamsDefaultBkColor.g, Is.EqualTo(1.0f));
        Assert.That(sc_PdfRenderParamsDefaultBkColor.b, Is.EqualTo(1.0f));
        Assert.That(sc_PdfRenderParamsDefaultBkColor.a, Is.EqualTo(1.0f));
    }
}
