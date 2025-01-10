// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/rendezvoussession.h and um/rendezvoussession_i.c in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.CLSID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "CLSID"/> class.</summary>
public static partial class CLSIDTests
{
    /// <summary>Validates that the value of the <see cref = "CLSID_RendezvousApplication"/> property is correct.</summary>

    [Test]
    public static void CLSID_RendezvousApplicationTest()
    {
        Assert.That(
            CLSID_RendezvousApplication,
            Is.EqualTo(
                new Guid(0x0B7E019A, 0xB5DE, 0x47fa, 0x89, 0x66, 0x90, 0x82, 0xF8, 0x2F, 0xB1, 0x92)
            )
        );
    }
}
