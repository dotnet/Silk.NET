// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/inkrenderer.h and um/inkrenderer_i.c in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_IInkD2DRenderer"/> property is correct.</summary>
    [Test]
    public static void IID_IInkD2DRendererTest()
    {
        Assert.That(IID_IInkD2DRenderer, Is.EqualTo(new Guid(0x407fb1de, 0xf85a, 0x4150, 0x97, 0xcf, 0xb7, 0xfb, 0x27, 0x4f, 0xb4, 0xf8)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IInkD2DRenderer2"/> property is correct.</summary>
    [Test]
    public static void IID_IInkD2DRenderer2Test()
    {
        Assert.That(IID_IInkD2DRenderer2, Is.EqualTo(new Guid(0x0a95dcd9, 0x4578, 0x4b71, 0xb2, 0x0b, 0xbf, 0x66, 0x4d, 0x4b, 0xfe, 0xee)));
    }
}