// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/manipulations.h and um/manipulations_i.c in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID__IManipulationEvents"/> property is correct.</summary>

    [Test]
    public static void IID__IManipulationEventsTest()
    {
        Assert.That(
            IID__IManipulationEvents,
            Is.EqualTo(
                new Guid(0x4f62c8da, 0x9c53, 0x4b22, 0x93, 0xdf, 0x92, 0x7a, 0x86, 0x2b, 0xbb, 0x03)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IInertiaProcessor"/> property is correct.</summary>

    [Test]
    public static void IID_IInertiaProcessorTest()
    {
        Assert.That(
            IID_IInertiaProcessor,
            Is.EqualTo(
                new Guid(0x18b00c6d, 0xc5ee, 0x41b1, 0x90, 0xa9, 0x9d, 0x4a, 0x92, 0x90, 0x95, 0xad)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IManipulationProcessor"/> property is correct.</summary>

    [Test]
    public static void IID_IManipulationProcessorTest()
    {
        Assert.That(
            IID_IManipulationProcessor,
            Is.EqualTo(
                new Guid(0xA22AC519, 0x8300, 0x48a0, 0xBE, 0xF4, 0xF1, 0xBE, 0x87, 0x37, 0xDB, 0xA4)
            )
        );
    }
}
