// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CLSID"/> class.</summary>
public static partial class CLSIDTests
{
    /// <summary>Validates that the value of the <see cref = "CLSID_DirectDraw"/> property is correct.</summary>
    [Test]
    public static void CLSID_DirectDrawTest()
    {
        Assert.That(CLSID_DirectDraw, Is.EqualTo(new Guid(0xD7B70EE0, 0x4340, 0x11CF, 0xB0, 0x63, 0x00, 0x20, 0xAF, 0xC2, 0xCD, 0x35)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DirectDraw7"/> property is correct.</summary>
    [Test]
    public static void CLSID_DirectDraw7Test()
    {
        Assert.That(CLSID_DirectDraw7, Is.EqualTo(new Guid(0x3c305196, 0x50db, 0x11d3, 0x9c, 0xfe, 0x00, 0xc0, 0x4f, 0xd9, 0x30, 0xc5)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DirectDrawClipper"/> property is correct.</summary>
    [Test]
    public static void CLSID_DirectDrawClipperTest()
    {
        Assert.That(CLSID_DirectDrawClipper, Is.EqualTo(new Guid(0x593817A0, 0x7DB3, 0x11CF, 0xA2, 0xDE, 0x00, 0xAA, 0x00, 0xb9, 0x33, 0x56)));
    }
}