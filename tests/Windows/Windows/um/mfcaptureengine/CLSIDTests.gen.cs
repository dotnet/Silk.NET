// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CLSID"/> class.</summary>
public static partial class CLSIDTests
{
    /// <summary>Validates that the value of the <see cref = "CLSID_MFCaptureEngine"/> property is correct.</summary>
    [Test]
    public static void CLSID_MFCaptureEngineTest()
    {
        Assert.That(CLSID_MFCaptureEngine, Is.EqualTo(new Guid(0xefce38d3, 0x8914, 0x4674, 0xa7, 0xdf, 0xae, 0x1b, 0x3d, 0x65, 0x4b, 0x8a)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MFCaptureEngineClassFactory"/> property is correct.</summary>
    [Test]
    public static void CLSID_MFCaptureEngineClassFactoryTest()
    {
        Assert.That(CLSID_MFCaptureEngineClassFactory, Is.EqualTo(new Guid(0xefce38d3, 0x8914, 0x4674, 0xa7, 0xdf, 0xae, 0x1b, 0x3d, 0x65, 0x4b, 0x8a)));
    }
}