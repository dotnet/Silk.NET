// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/manipulations.h and um/manipulations_i.c in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.LIBID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "LIBID"/> class.</summary>
public static partial class LIBIDTests
{
    /// <summary>Validates that the value of the <see cref = "LIBID_ManipulationsLib"/> property is correct.</summary>
    [Test]
    public static void LIBID_ManipulationsLibTest()
    {
        Assert.That(LIBID_ManipulationsLib, Is.EqualTo(new Guid(0x935610b3, 0x6f81, 0x450f, 0x85, 0xd5, 0x42, 0xd3, 0xd2, 0x6c, 0x5c, 0x11)));
    }
}