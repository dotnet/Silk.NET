// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InkPresenterDesktop.h and um/InkPresenterDesktop_i.c in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_IInkCommitRequestHandler"/> property is correct.</summary>
    [Test]
    public static void IID_IInkCommitRequestHandlerTest()
    {
        Assert.That(IID_IInkCommitRequestHandler, Is.EqualTo(new Guid(0xfabea3fc, 0xb108, 0x45b6, 0xa9, 0xfc, 0x8d, 0x08, 0xfa, 0x9f, 0x85, 0xcf)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IInkPresenterDesktop"/> property is correct.</summary>
    [Test]
    public static void IID_IInkPresenterDesktopTest()
    {
        Assert.That(IID_IInkPresenterDesktop, Is.EqualTo(new Guid(0x73f3c0d9, 0x2e8b, 0x48f3, 0x89, 0x5e, 0x20, 0xcb, 0xd2, 0x7b, 0x72, 0x3b)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IInkHostWorkItem"/> property is correct.</summary>
    [Test]
    public static void IID_IInkHostWorkItemTest()
    {
        Assert.That(IID_IInkHostWorkItem, Is.EqualTo(new Guid(0xccda0a9a, 0x1b78, 0x4632, 0xbb, 0x96, 0x97, 0x80, 0x06, 0x62, 0xe2, 0x6c)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IInkDesktopHost"/> property is correct.</summary>
    [Test]
    public static void IID_IInkDesktopHostTest()
    {
        Assert.That(IID_IInkDesktopHost, Is.EqualTo(new Guid(0x4ce7d875, 0xa981, 0x4140, 0xa1, 0xff, 0xad, 0x93, 0x25, 0x8e, 0x8d, 0x59)));
    }
}