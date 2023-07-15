// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CLSID"/> class.</summary>
public static partial class CLSIDTests
{
    /// <summary>Validates that the value of the <see cref = "CLSID_MFReadWriteClassFactory"/> property is correct.</summary>
    [Test]
    public static void CLSID_MFReadWriteClassFactoryTest()
    {
        Assert.That(CLSID_MFReadWriteClassFactory, Is.EqualTo(new Guid(0x48e2ed0f, 0x98c2, 0x4a37, 0xbe, 0xd5, 0x16, 0x63, 0x12, 0xdd, 0xd8, 0x3f)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MFSourceReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_MFSourceReaderTest()
    {
        Assert.That(CLSID_MFSourceReader, Is.EqualTo(new Guid(0x1777133c, 0x0881, 0x411b, 0xa5, 0x77, 0xad, 0x54, 0x5f, 0x07, 0x14, 0xc4)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MFSinkWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_MFSinkWriterTest()
    {
        Assert.That(CLSID_MFSinkWriter, Is.EqualTo(new Guid(0xa3bbfb17, 0x8273, 0x4e52, 0x9e, 0x0e, 0x97, 0x39, 0xdc, 0x88, 0x79, 0x90)));
    }
}