// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effects_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CLSID"/> class.</summary>
public static partial class CLSIDTests
{
    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1YCbCr"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1YCbCrTest()
    {
        Assert.That(CLSID_D2D1YCbCr, Is.EqualTo(new Guid(0x99503cc1, 0x66c7, 0x45c9, 0xa8, 0x75, 0x8a, 0xd8, 0xa7, 0x91, 0x44, 0x01)));
    }
}