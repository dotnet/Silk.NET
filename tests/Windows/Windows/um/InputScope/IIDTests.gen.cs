// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InputScope.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_ITfInputScope"/> property is correct.</summary>
    [Test]
    public static void IID_ITfInputScopeTest()
    {
        Assert.That(IID_ITfInputScope, Is.EqualTo(new Guid(0xfde1eaee, 0x6924, 0x4cdf, 0x91, 0xe7, 0xda, 0x38, 0xcf, 0xf5, 0x55, 0x9d)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ITfInputScope2"/> property is correct.</summary>
    [Test]
    public static void IID_ITfInputScope2Test()
    {
        Assert.That(IID_ITfInputScope2, Is.EqualTo(new Guid(0x5731eaa0, 0x6bc2, 0x4681, 0xa5, 0x32, 0x92, 0xfb, 0xb7, 0x4d, 0x7c, 0x41)));
    }
}