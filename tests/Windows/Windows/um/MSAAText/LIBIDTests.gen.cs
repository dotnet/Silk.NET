// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.LIBID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "LIBID"/> class.</summary>
public static partial class LIBIDTests
{
    /// <summary>Validates that the value of the <see cref = "LIBID_MSAATEXTLib"/> property is correct.</summary>
    [Test]
    public static void LIBID_MSAATEXTLibTest()
    {
        Assert.That(LIBID_MSAATEXTLib, Is.EqualTo(new Guid(0x150E2D7A, 0xDAC1, 0x4582, 0x94, 0x7D, 0x2A, 0x8F, 0xD7, 0x8B, 0x82, 0xCD)));
    }
}