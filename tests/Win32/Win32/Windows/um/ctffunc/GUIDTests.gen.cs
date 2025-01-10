// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.GUID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "GUID"/> class.</summary>
public static partial class GUIDTests
{
    /// <summary>Validates that the value of the <see cref = "GUID_INTEGRATIONSTYLE_SEARCHBOX"/> property is correct.</summary>

    [Test]
    public static void GUID_INTEGRATIONSTYLE_SEARCHBOXTest()
    {
        Assert.That(
            GUID_INTEGRATIONSTYLE_SEARCHBOX,
            Is.EqualTo(
                new Guid(0xe6d1bd11, 0x82f7, 0x4903, 0xae, 0x21, 0x1a, 0x63, 0x97, 0xcd, 0xe2, 0xeb)
            )
        );
    }
}
