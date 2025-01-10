// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlGuid.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.SID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "SID"/> struct.</summary>
public static unsafe partial class SIDTests
{
    /// <summary>Validates that the value of the <see cref = "SID_DefView"/> property is correct.</summary>

    [Test]
    public static void SID_DefViewTest()
    {
        Assert.That(
            SID_DefView,
            Is.EqualTo(
                new Guid(0x6D12FE80, 0x7911, 0x11CF, 0x95, 0x34, 0x00, 0x00, 0xC0, 0x5B, 0xAE, 0x0B)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "SID_SInPlaceBrowser"/> property is correct.</summary>

    [Test]
    public static void SID_SInPlaceBrowserTest()
    {
        Assert.That(
            SID_SInPlaceBrowser,
            Is.EqualTo(
                new Guid(0x1D2AE02B, 0x3655, 0x46CC, 0xB6, 0x3A, 0x28, 0x59, 0x88, 0x15, 0x3B, 0xCA)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "SID_SSearchBoxInfo"/> property is correct.</summary>

    [Test]
    public static void SID_SSearchBoxInfoTest()
    {
        Assert.That(
            SID_SSearchBoxInfo,
            Is.EqualTo(
                new Guid(0x142daa61, 0x516b, 0x4713, 0xb4, 0x9c, 0xfb, 0x98, 0x5e, 0xf8, 0x29, 0x98)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "SID_CommandsPropertyBag"/> property is correct.</summary>

    [Test]
    public static void SID_CommandsPropertyBagTest()
    {
        Assert.That(
            SID_CommandsPropertyBag,
            Is.EqualTo(
                new Guid(0x6e043250, 0x4416, 0x485c, 0xb1, 0x43, 0xe6, 0x2a, 0x76, 0x0d, 0x9f, 0xe5)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "SID_STopLevelBrowser"/> property is correct.</summary>

    [Test]
    public static void SID_STopLevelBrowserTest()
    {
        Assert.That(
            SID_STopLevelBrowser,
            Is.EqualTo(
                new Guid(0x4C96BE40, 0x915C, 0x11CF, 0x99, 0xD3, 0x00, 0xAA, 0x00, 0x4A, 0xE8, 0x37)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "SID_STopWindow"/> property is correct.</summary>

    [Test]
    public static void SID_STopWindowTest()
    {
        Assert.That(
            SID_STopWindow,
            Is.EqualTo(
                new Guid(0x49e1b500, 0x4636, 0x11d3, 0x97, 0xf7, 0x0, 0xc0, 0x4f, 0x45, 0xd0, 0xb3)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "SID_SGetViewFromViewDual"/> property is correct.</summary>

    [Test]
    public static void SID_SGetViewFromViewDualTest()
    {
        Assert.That(
            SID_SGetViewFromViewDual,
            Is.EqualTo(
                new Guid(0x889A935D, 0x971E, 0x4B12, 0xB9, 0x0C, 0x24, 0xDF, 0xC9, 0xE1, 0xE5, 0xE8)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "SID_CtxQueryAssociations"/> property is correct.</summary>

    [Test]
    public static void SID_CtxQueryAssociationsTest()
    {
        Assert.That(
            SID_CtxQueryAssociations,
            Is.EqualTo(
                new Guid(0xfaadfc40, 0xb777, 0x4b69, 0xaa, 0x81, 0x77, 0x03, 0x5e, 0xf0, 0xe6, 0xe8)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "SID_SMenuBandChild"/> property is correct.</summary>

    [Test]
    public static void SID_SMenuBandChildTest()
    {
        Assert.That(
            SID_SMenuBandChild,
            Is.EqualTo(
                new Guid(0xed9cc020, 0x8b9, 0x11d1, 0x98, 0x23, 0x0, 0xc0, 0x4f, 0xd9, 0x19, 0x72)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "SID_SMenuBandParent"/> property is correct.</summary>

    [Test]
    public static void SID_SMenuBandParentTest()
    {
        Assert.That(
            SID_SMenuBandParent,
            Is.EqualTo(
                new Guid(0x8c278eec, 0x3eab, 0x11d1, 0x8c, 0xb0, 0x0, 0xc0, 0x4f, 0xd9, 0x18, 0xd0)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "SID_SMenuPopup"/> property is correct.</summary>

    [Test]
    public static void SID_SMenuPopupTest()
    {
        Assert.That(
            SID_SMenuPopup,
            Is.EqualTo(
                new Guid(0xD1E7AFEB, 0x6A2E, 0x11d0, 0x8C, 0x78, 0x0, 0xC0, 0x4F, 0xD9, 0x18, 0xB4)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "SID_SMenuBandBottomSelected"/> property is correct.</summary>

    [Test]
    public static void SID_SMenuBandBottomSelectedTest()
    {
        Assert.That(
            SID_SMenuBandBottomSelected,
            Is.EqualTo(
                new Guid(0x165ebaf4, 0x6d51, 0x11d2, 0x83, 0xad, 0x0, 0xc0, 0x4f, 0xd9, 0x18, 0xd0)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "SID_SMenuBandBottom"/> property is correct.</summary>

    [Test]
    public static void SID_SMenuBandBottomTest()
    {
        Assert.That(
            SID_SMenuBandBottom,
            Is.EqualTo(
                new Guid(0x743ca664, 0xdeb, 0x11d1, 0x98, 0x25, 0x0, 0xc0, 0x4f, 0xd9, 0x19, 0x72)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "SID_MenuShellFolder"/> property is correct.</summary>

    [Test]
    public static void SID_MenuShellFolderTest()
    {
        Assert.That(
            SID_MenuShellFolder,
            Is.EqualTo(
                new Guid(0xa6c17eb4, 0x2d65, 0x11d2, 0x83, 0x8f, 0x0, 0xc0, 0x4f, 0xd9, 0x18, 0xd0)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "SID_SMenuBandContextMenuModifier"/> property is correct.</summary>

    [Test]
    public static void SID_SMenuBandContextMenuModifierTest()
    {
        Assert.That(
            SID_SMenuBandContextMenuModifier,
            Is.EqualTo(
                new Guid(0x39545874, 0x7162, 0x465e, 0xb7, 0x83, 0x2a, 0xa1, 0x87, 0x4f, 0xef, 0x81)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "SID_SMenuBandBKContextMenu"/> property is correct.</summary>

    [Test]
    public static void SID_SMenuBandBKContextMenuTest()
    {
        Assert.That(
            SID_SMenuBandBKContextMenu,
            Is.EqualTo(
                new Guid(0x164bbd86, 0x1d0d, 0x4de0, 0x9a, 0x3b, 0xd9, 0x72, 0x96, 0x47, 0xc2, 0xb8)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "SID_SMenuBandTop"/> property is correct.</summary>

    [Test]
    public static void SID_SMenuBandTopTest()
    {
        Assert.That(
            SID_SMenuBandTop,
            Is.EqualTo(
                new Guid(0x9493a810, 0xec38, 0x11d0, 0xbc, 0x46, 0x0, 0xaa, 0x0, 0x6c, 0xe2, 0xf5)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "SID_SCommDlgBrowser"/> property is correct.</summary>

    [Test]
    public static void SID_SCommDlgBrowserTest()
    {
        Assert.That(
            SID_SCommDlgBrowser,
            Is.EqualTo(
                new Guid(0x80f30233, 0xb7df, 0x11d2, 0xa3, 0x3b, 0x0, 0x60, 0x97, 0xdf, 0x5b, 0xd4)
            )
        );
    }
}
