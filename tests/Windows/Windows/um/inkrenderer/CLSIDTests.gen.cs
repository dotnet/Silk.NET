// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/inkrenderer.h and um/inkrenderer_i.c in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CLSID"/> class.</summary>
public static partial class CLSIDTests
{
    /// <summary>Validates that the value of the <see cref = "CLSID_InkD2DRenderer"/> property is correct.</summary>
    [Test]
    public static void CLSID_InkD2DRendererTest()
    {
        Assert.That(CLSID_InkD2DRenderer, Is.EqualTo(new Guid(0x4044e60c, 0x7b01, 0x4671, 0xa9, 0x7c, 0x04, 0xe0, 0x21, 0x0a, 0x07, 0xa5)));
    }
}