// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.media.core.interop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.CLSID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "CLSID"/> class.</summary>
public static partial class CLSIDTests
{
    /// <summary>Validates that the value of the <see cref = "CLSID_AudioFrameNativeFactory"/> property is correct.</summary>

    [Test]
    public static void CLSID_AudioFrameNativeFactoryTest()
    {
        Assert.That(
            CLSID_AudioFrameNativeFactory,
            Is.EqualTo(
                new Guid(0x16a0a3b9, 0x9f65, 0x4102, 0x93, 0x67, 0x2c, 0xda, 0x3a, 0x4f, 0x37, 0x2a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_VideoFrameNativeFactory"/> property is correct.</summary>

    [Test]
    public static void CLSID_VideoFrameNativeFactoryTest()
    {
        Assert.That(
            CLSID_VideoFrameNativeFactory,
            Is.EqualTo(
                new Guid(0xd194386a, 0x4e3, 0x4814, 0x81, 0x0, 0xb2, 0xb0, 0xae, 0x6d, 0x78, 0xc7)
            )
        );
    }
}
