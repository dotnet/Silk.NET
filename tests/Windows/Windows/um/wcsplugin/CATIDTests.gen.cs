// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wcsplugin.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.CATID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CATID"/> class.</summary>
public static partial class CATIDTests
{
    /// <summary>Validates that the value of the <see cref = "CATID_WcsPlugin"/> property is correct.</summary>
    [Test]
    public static void CATID_WcsPluginTest()
    {
        Assert.That(CATID_WcsPlugin, Is.EqualTo(new Guid(0xa0b402e0, 0x8240, 0x405f, 0x8a, 0x16, 0x8a, 0x5b, 0x4d, 0xf2, 0xf0, 0xdd)));
    }
}