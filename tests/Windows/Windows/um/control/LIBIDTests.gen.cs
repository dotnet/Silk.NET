// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/control.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.LIBID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "LIBID"/> class.</summary>
public static partial class LIBIDTests
{
    /// <summary>Validates that the value of the <see cref = "LIBID_QuartzTypeLib"/> property is correct.</summary>
    [Test]
    public static void LIBID_QuartzTypeLibTest()
    {
        Assert.That(LIBID_QuartzTypeLib, Is.EqualTo(new Guid(0x56a868b0, 0x0ad4, 0x11ce, 0xb0, 0x3a, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
    }
}