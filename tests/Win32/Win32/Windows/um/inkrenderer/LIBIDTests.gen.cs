// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/inkrenderer.h and um/inkrenderer_i.c in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.LIBID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "LIBID"/> class.</summary>
public static partial class LIBIDTests
{
    /// <summary>Validates that the value of the <see cref = "LIBID_InkD2DRendererLib"/> property is correct.</summary>

    [Test]
    public static void LIBID_InkD2DRendererLibTest()
    {
        Assert.That(
            LIBID_InkD2DRendererLib,
            Is.EqualTo(
                new Guid(0x390d0ab0, 0x19e2, 0x46bb, 0x86, 0x2e, 0xb0, 0x9f, 0x3c, 0xdc, 0xf8, 0xb9)
            )
        );
    }
}
