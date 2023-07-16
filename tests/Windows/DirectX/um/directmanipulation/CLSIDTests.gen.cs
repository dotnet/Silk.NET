// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CLSID"/> class.</summary>
public static partial class CLSIDTests
{
    /// <summary>Validates that the value of the <see cref = "CLSID_VerticalIndicatorContent"/> property is correct.</summary>
    [Test]
    public static void CLSID_VerticalIndicatorContentTest()
    {
        Assert.That(CLSID_VerticalIndicatorContent, Is.EqualTo(new Guid(0xa10b5f17, 0xafe0, 0x4aa2, 0x91, 0xe9, 0x3e, 0x70, 0x1, 0xd2, 0xe6, 0xb4)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_HorizontalIndicatorContent"/> property is correct.</summary>
    [Test]
    public static void CLSID_HorizontalIndicatorContentTest()
    {
        Assert.That(CLSID_HorizontalIndicatorContent, Is.EqualTo(new Guid(0xe7d18cf5, 0x3ec7, 0x44d5, 0xa7, 0x6b, 0x37, 0x70, 0xf3, 0xcf, 0x90, 0x3d)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_VirtualViewportContent"/> property is correct.</summary>
    [Test]
    public static void CLSID_VirtualViewportContentTest()
    {
        Assert.That(CLSID_VirtualViewportContent, Is.EqualTo(new Guid(0x3206a19a, 0x86f0, 0x4cb4, 0xa7, 0xf3, 0x16, 0xe3, 0xb7, 0xe2, 0xd8, 0x52)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DragDropConfigurationBehavior"/> property is correct.</summary>
    [Test]
    public static void CLSID_DragDropConfigurationBehaviorTest()
    {
        Assert.That(CLSID_DragDropConfigurationBehavior, Is.EqualTo(new Guid(0x09b01b3e, 0xba6c, 0x454d, 0x82, 0xe8, 0x95, 0xe3, 0x52, 0x32, 0x9f, 0x23)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_AutoScrollBehavior"/> property is correct.</summary>
    [Test]
    public static void CLSID_AutoScrollBehaviorTest()
    {
        Assert.That(CLSID_AutoScrollBehavior, Is.EqualTo(new Guid(0x26126a51, 0x3c70, 0x4c9a, 0xae, 0xc2, 0x94, 0x88, 0x49, 0xee, 0xb0, 0x93)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DeferContactService"/> property is correct.</summary>
    [Test]
    public static void CLSID_DeferContactServiceTest()
    {
        Assert.That(CLSID_DeferContactService, Is.EqualTo(new Guid(0xd7b67cf4, 0x84bb, 0x434e, 0x86, 0xae, 0x65, 0x92, 0xbb, 0xc9, 0xab, 0xd9)));
    }
}