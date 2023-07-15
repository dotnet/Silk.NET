// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmp2dlna.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CLSID"/> class.</summary>
public static partial class CLSIDTests
{
    /// <summary>Validates that the value of the <see cref = "CLSID_MPEG2DLNASink"/> property is correct.</summary>
    [Test]
    public static void CLSID_MPEG2DLNASinkTest()
    {
        Assert.That(CLSID_MPEG2DLNASink, Is.EqualTo(new Guid(0xfa5fe7c5, 0x6a1d, 0x4b11, 0xb4, 0x1f, 0xf9, 0x59, 0xd6, 0xc7, 0x65, 0x00)));
    }
}