// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.graphics.imaging.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CLSID"/> class.</summary>
public static partial class CLSIDTests
{
    /// <summary>Validates that the value of the <see cref = "CLSID_SoftwareBitmapNativeFactory"/> property is correct.</summary>
    [Test]
    public static void CLSID_SoftwareBitmapNativeFactoryTest()
    {
        Assert.That(CLSID_SoftwareBitmapNativeFactory, Is.EqualTo(new Guid(0x84e65691, 0x8602, 0x4a84, 0xbe, 0x46, 0x70, 0x8b, 0xe9, 0xcd, 0x4b, 0x74)));
    }
}