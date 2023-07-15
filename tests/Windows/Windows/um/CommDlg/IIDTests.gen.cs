// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_IPrintDialogCallback"/> property is correct.</summary>
    [Test]
    public static void IID_IPrintDialogCallbackTest()
    {
        Assert.That(IID_IPrintDialogCallback, Is.EqualTo(new Guid(0x5852a2c3, 0x6530, 0x11d1, 0xb6, 0xa3, 0x0, 0x0, 0xf8, 0x75, 0x7b, 0xf9)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IPrintDialogServices"/> property is correct.</summary>
    [Test]
    public static void IID_IPrintDialogServicesTest()
    {
        Assert.That(IID_IPrintDialogServices, Is.EqualTo(new Guid(0x509aaeda, 0x5639, 0x11d1, 0xb6, 0xa1, 0x0, 0x0, 0xf8, 0x75, 0x7b, 0xf9)));
    }
}