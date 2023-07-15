// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InkPresenterDesktop.h and um/InkPresenterDesktop_i.c in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.LIBID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "LIBID"/> class.</summary>
public static partial class LIBIDTests
{
    /// <summary>Validates that the value of the <see cref = "LIBID_InkDesktopHostLib"/> property is correct.</summary>
    [Test]
    public static void LIBID_InkDesktopHostLibTest()
    {
        Assert.That(LIBID_InkDesktopHostLib, Is.EqualTo(new Guid(0x2aef0967, 0xc833, 0x4f38, 0x91, 0xf3, 0x16, 0xe6, 0x7d, 0x55, 0xd7, 0x17)));
    }
}