// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/control.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CLSID"/> class.</summary>
public static partial class CLSIDTests
{
    /// <summary>Validates that the value of the <see cref = "CLSID_FilgraphManager"/> property is correct.</summary>
    [Test]
    public static void CLSID_FilgraphManagerTest()
    {
        Assert.That(CLSID_FilgraphManager, Is.EqualTo(new Guid(0xe436ebb3, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
    }
}