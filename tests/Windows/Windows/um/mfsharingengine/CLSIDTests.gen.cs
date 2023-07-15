// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CLSID"/> class.</summary>
public static partial class CLSIDTests
{
    /// <summary>Validates that the value of the <see cref = "CLSID_MFMediaSharingEngineClassFactory"/> property is correct.</summary>
    [Test]
    public static void CLSID_MFMediaSharingEngineClassFactoryTest()
    {
        Assert.That(CLSID_MFMediaSharingEngineClassFactory, Is.EqualTo(new Guid(0xf8e307fb, 0x6d45, 0x4ad3, 0x99, 0x93, 0x66, 0xcd, 0x5a, 0x52, 0x96, 0x59)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MFImageSharingEngineClassFactory"/> property is correct.</summary>
    [Test]
    public static void CLSID_MFImageSharingEngineClassFactoryTest()
    {
        Assert.That(CLSID_MFImageSharingEngineClassFactory, Is.EqualTo(new Guid(0xb22c3339, 0x87f3, 0x4059, 0xa0, 0xc5, 0x3, 0x7a, 0xa9, 0x70, 0x7e, 0xaf)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_PlayToSourceClassFactory"/> property is correct.</summary>
    [Test]
    public static void CLSID_PlayToSourceClassFactoryTest()
    {
        Assert.That(CLSID_PlayToSourceClassFactory, Is.EqualTo(new Guid(0xDA17539A, 0x3DC3, 0x42C1, 0xA7, 0x49, 0xA1, 0x83, 0xB5, 0x1F, 0x08, 0x5E)));
    }
}