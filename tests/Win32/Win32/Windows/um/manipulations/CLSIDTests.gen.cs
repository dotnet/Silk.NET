// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/manipulations.h and um/manipulations_i.c in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.CLSID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "CLSID"/> class.</summary>
public static partial class CLSIDTests
{
    /// <summary>Validates that the value of the <see cref = "CLSID_InertiaProcessor"/> property is correct.</summary>

    [Test]
    public static void CLSID_InertiaProcessorTest()
    {
        Assert.That(
            CLSID_InertiaProcessor,
            Is.EqualTo(
                new Guid(0xabb27087, 0x4ce0, 0x4e58, 0xa0, 0xcb, 0xe2, 0x4d, 0xf9, 0x68, 0x14, 0xbe)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_ManipulationProcessor"/> property is correct.</summary>

    [Test]
    public static void CLSID_ManipulationProcessorTest()
    {
        Assert.That(
            CLSID_ManipulationProcessor,
            Is.EqualTo(
                new Guid(0x597D4FB0, 0x47FD, 0x4aff, 0x89, 0xB9, 0xC6, 0xCF, 0xAE, 0x8C, 0xF0, 0x8E)
            )
        );
    }
}
