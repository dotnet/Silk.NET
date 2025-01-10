// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/rendezvoussession.h and um/rendezvoussession_i.c in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_IRendezvousSession"/> property is correct.</summary>

    [Test]
    public static void IID_IRendezvousSessionTest()
    {
        Assert.That(
            IID_IRendezvousSession,
            Is.EqualTo(
                new Guid(0x9BA4B1DD, 0x8B0C, 0x48B7, 0x9E, 0x7C, 0x2F, 0x25, 0x85, 0x7C, 0x8D, 0xF5)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IRendezvousApplication"/> property is correct.</summary>

    [Test]
    public static void IID_IRendezvousApplicationTest()
    {
        Assert.That(
            IID_IRendezvousApplication,
            Is.EqualTo(
                new Guid(0x4F4D070B, 0xA275, 0x49FB, 0xB1, 0x0D, 0x8E, 0xC2, 0x63, 0x87, 0xB5, 0x0D)
            )
        );
    }
}
