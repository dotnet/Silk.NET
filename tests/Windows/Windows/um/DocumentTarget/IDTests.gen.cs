// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocumentTarget.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.ID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ID"/> class.</summary>
public static partial class IDTests
{
    /// <summary>Validates that the value of the <see cref = "ID_DOCUMENTPACKAGETARGET_MSXPS"/> property is correct.</summary>
    [Test]
    public static void ID_DOCUMENTPACKAGETARGET_MSXPSTest()
    {
        Assert.That(ID_DOCUMENTPACKAGETARGET_MSXPS, Is.EqualTo(new Guid(0x9cae40a8, 0xded1, 0x41c9, 0xa9, 0xfd, 0xd7, 0x35, 0xef, 0x33, 0xae, 0xda)));
    }

    /// <summary>Validates that the value of the <see cref = "ID_DOCUMENTPACKAGETARGET_OPENXPS"/> property is correct.</summary>
    [Test]
    public static void ID_DOCUMENTPACKAGETARGET_OPENXPSTest()
    {
        Assert.That(ID_DOCUMENTPACKAGETARGET_OPENXPS, Is.EqualTo(new Guid(0x0056bb72, 0x8c9c, 0x4612, 0xbd, 0x0f, 0x93, 0x01, 0x2a, 0x87, 0x09, 0x9d)));
    }

    /// <summary>Validates that the value of the <see cref = "ID_DOCUMENTPACKAGETARGET_OPENXPS_WITH_3D"/> property is correct.</summary>
    [Test]
    public static void ID_DOCUMENTPACKAGETARGET_OPENXPS_WITH_3DTest()
    {
        Assert.That(ID_DOCUMENTPACKAGETARGET_OPENXPS_WITH_3D, Is.EqualTo(new Guid(0x63dbd720, 0x8b14, 0x4577, 0xb0, 0x74, 0x7b, 0xb1, 0x1b, 0x59, 0x6d, 0x28)));
    }
}