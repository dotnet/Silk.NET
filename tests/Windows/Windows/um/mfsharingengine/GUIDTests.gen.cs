// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.GUID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "GUID"/> class.</summary>
public static partial class GUIDTests
{
    /// <summary>Validates that the value of the <see cref = "GUID_PlayToService"/> property is correct.</summary>
    [Test]
    public static void GUID_PlayToServiceTest()
    {
        Assert.That(GUID_PlayToService, Is.EqualTo(new Guid(0xf6a8ff9d, 0x9e14, 0x41c9, 0xbf, 0x0f, 0x12, 0x0a, 0x2b, 0x3c, 0xe1, 0x20)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_NativeDeviceService"/> property is correct.</summary>
    [Test]
    public static void GUID_NativeDeviceServiceTest()
    {
        Assert.That(GUID_NativeDeviceService, Is.EqualTo(new Guid(0xef71e53c, 0x52f4, 0x43c5, 0xb8, 0x6a, 0xad, 0x6c, 0xb2, 0x16, 0xa6, 0x1e)));
    }
}