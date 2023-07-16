// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlGuid.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.FMTID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "FMTID"/> class.</summary>
public static partial class FMTIDTests
{
    /// <summary>Validates that the value of the <see cref = "FMTID_Intshcut"/> property is correct.</summary>
    [Test]
    public static void FMTID_IntshcutTest()
    {
        Assert.That(FMTID_Intshcut, Is.EqualTo(new Guid(0x000214A0, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "FMTID_InternetSite"/> property is correct.</summary>
    [Test]
    public static void FMTID_InternetSiteTest()
    {
        Assert.That(FMTID_InternetSite, Is.EqualTo(new Guid(0x000214A1, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "FMTID_ShellDetails"/> property is correct.</summary>
    [Test]
    public static void FMTID_ShellDetailsTest()
    {
        Assert.That(FMTID_ShellDetails, Is.EqualTo(new Guid(0x28636aa6, 0x953d, 0x11d2, 0xb5, 0xd6, 0x0, 0xc0, 0x4f, 0xd9, 0x18, 0xd0)));
    }

    /// <summary>Validates that the value of the <see cref = "FMTID_Storage"/> property is correct.</summary>
    [Test]
    public static void FMTID_StorageTest()
    {
        Assert.That(FMTID_Storage, Is.EqualTo(new Guid(0xb725f130, 0x47ef, 0x101a, 0xa5, 0xf1, 0x02, 0x60, 0x8c, 0x9e, 0xeb, 0xac)));
    }

    /// <summary>Validates that the value of the <see cref = "FMTID_ImageProperties"/> property is correct.</summary>
    [Test]
    public static void FMTID_ImagePropertiesTest()
    {
        Assert.That(FMTID_ImageProperties, Is.EqualTo(new Guid(0x14b81da1, 0x0135, 0x4d31, 0x96, 0xd9, 0x6c, 0xbf, 0xc9, 0x67, 0x1a, 0x99)));
    }

    /// <summary>Validates that the value of the <see cref = "FMTID_CustomImageProperties"/> property is correct.</summary>
    [Test]
    public static void FMTID_CustomImagePropertiesTest()
    {
        Assert.That(FMTID_CustomImageProperties, Is.EqualTo(new Guid(0x7ecd8b0e, 0xc136, 0x4a9b, 0x94, 0x11, 0x4e, 0xbd, 0x66, 0x73, 0xcc, 0xc3)));
    }

    /// <summary>Validates that the value of the <see cref = "FMTID_LibraryProperties"/> property is correct.</summary>
    [Test]
    public static void FMTID_LibraryPropertiesTest()
    {
        Assert.That(FMTID_LibraryProperties, Is.EqualTo(new Guid(0x5d76b67f, 0x9b3d, 0x44bb, 0xb6, 0xae, 0x25, 0xda, 0x4f, 0x63, 0x8a, 0x67)));
    }

    /// <summary>Validates that the value of the <see cref = "FMTID_Displaced"/> property is correct.</summary>
    [Test]
    public static void FMTID_DisplacedTest()
    {
        Assert.That(FMTID_Displaced, Is.EqualTo(new Guid(0x9b174b33, 0x40ff, 0x11d2, 0xa2, 0x7e, 0x0, 0xc0, 0x4f, 0xc3, 0x8, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "FMTID_Briefcase"/> property is correct.</summary>
    [Test]
    public static void FMTID_BriefcaseTest()
    {
        Assert.That(FMTID_Briefcase, Is.EqualTo(new Guid(0x328d8b21, 0x7729, 0x4bfc, 0x95, 0x4c, 0x90, 0x2b, 0x32, 0x9d, 0x56, 0xb0)));
    }

    /// <summary>Validates that the value of the <see cref = "FMTID_Misc"/> property is correct.</summary>
    [Test]
    public static void FMTID_MiscTest()
    {
        Assert.That(FMTID_Misc, Is.EqualTo(new Guid(0x9b174b34, 0x40ff, 0x11d2, 0xa2, 0x7e, 0x0, 0xc0, 0x4f, 0xc3, 0x8, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "FMTID_WebView"/> property is correct.</summary>
    [Test]
    public static void FMTID_WebViewTest()
    {
        Assert.That(FMTID_WebView, Is.EqualTo(new Guid(0xf2275480, 0xf782, 0x4291, 0xbd, 0x94, 0xf1, 0x36, 0x93, 0x51, 0x3a, 0xec)));
    }

    /// <summary>Validates that the value of the <see cref = "FMTID_MUSIC"/> property is correct.</summary>
    [Test]
    public static void FMTID_MUSICTest()
    {
        Assert.That(FMTID_MUSIC, Is.EqualTo(new Guid(0x56a3372e, 0xce9c, 0x11d2, 0x9f, 0xe, 0x0, 0x60, 0x97, 0xc6, 0x86, 0xf6)));
    }

    /// <summary>Validates that the value of the <see cref = "FMTID_DRM"/> property is correct.</summary>
    [Test]
    public static void FMTID_DRMTest()
    {
        Assert.That(FMTID_DRM, Is.EqualTo(new Guid(0xaeac19e4, 0x89ae, 0x4508, 0xb9, 0xb7, 0xbb, 0x86, 0x7a, 0xbe, 0xe2, 0xed)));
    }

    /// <summary>Validates that the value of the <see cref = "FMTID_Volume"/> property is correct.</summary>
    [Test]
    public static void FMTID_VolumeTest()
    {
        Assert.That(FMTID_Volume, Is.EqualTo(new Guid(0x9b174b35, 0x40ff, 0x11d2, 0xa2, 0x7e, 0x0, 0xc0, 0x4f, 0xc3, 0x8, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "FMTID_Query"/> property is correct.</summary>
    [Test]
    public static void FMTID_QueryTest()
    {
        Assert.That(FMTID_Query, Is.EqualTo(new Guid(0x49691c90, 0x7e17, 0x101a, 0xa9, 0x1c, 0x08, 0x00, 0x2b, 0x2e, 0xcd, 0xa9)));
    }
}