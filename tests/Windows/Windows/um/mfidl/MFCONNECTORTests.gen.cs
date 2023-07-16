// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.MFCONNECTOR;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MFCONNECTOR"/> class.</summary>
public static partial class MFCONNECTORTests
{
    /// <summary>Validates that the value of the <see cref = "MFCONNECTOR_SPDIF"/> property is correct.</summary>
    [Test]
    public static void MFCONNECTOR_SPDIFTest()
    {
        Assert.That(MFCONNECTOR_SPDIF, Is.EqualTo(new Guid(0xb94a712, 0xad3e, 0x4cee, 0x83, 0xce, 0xce, 0x32, 0xe3, 0xdb, 0x65, 0x22)));
    }

    /// <summary>Validates that the value of the <see cref = "MFCONNECTOR_UNKNOWN"/> property is correct.</summary>
    [Test]
    public static void MFCONNECTOR_UNKNOWNTest()
    {
        Assert.That(MFCONNECTOR_UNKNOWN, Is.EqualTo(new Guid(0xac3aef5c, 0xce43, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
    }

    /// <summary>Validates that the value of the <see cref = "MFCONNECTOR_PCI"/> property is correct.</summary>
    [Test]
    public static void MFCONNECTOR_PCITest()
    {
        Assert.That(MFCONNECTOR_PCI, Is.EqualTo(new Guid(0xac3aef5d, 0xce43, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
    }

    /// <summary>Validates that the value of the <see cref = "MFCONNECTOR_PCIX"/> property is correct.</summary>
    [Test]
    public static void MFCONNECTOR_PCIXTest()
    {
        Assert.That(MFCONNECTOR_PCIX, Is.EqualTo(new Guid(0xac3aef5e, 0xce43, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
    }

    /// <summary>Validates that the value of the <see cref = "MFCONNECTOR_PCI_Express"/> property is correct.</summary>
    [Test]
    public static void MFCONNECTOR_PCI_ExpressTest()
    {
        Assert.That(MFCONNECTOR_PCI_Express, Is.EqualTo(new Guid(0xac3aef5f, 0xce43, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
    }

    /// <summary>Validates that the value of the <see cref = "MFCONNECTOR_AGP"/> property is correct.</summary>
    [Test]
    public static void MFCONNECTOR_AGPTest()
    {
        Assert.That(MFCONNECTOR_AGP, Is.EqualTo(new Guid(0xac3aef60, 0xce43, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
    }

    /// <summary>Validates that the value of the <see cref = "MFCONNECTOR_VGA"/> property is correct.</summary>
    [Test]
    public static void MFCONNECTOR_VGATest()
    {
        Assert.That(MFCONNECTOR_VGA, Is.EqualTo(new Guid(0x57cd5968, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
    }

    /// <summary>Validates that the value of the <see cref = "MFCONNECTOR_SVIDEO"/> property is correct.</summary>
    [Test]
    public static void MFCONNECTOR_SVIDEOTest()
    {
        Assert.That(MFCONNECTOR_SVIDEO, Is.EqualTo(new Guid(0x57cd5969, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
    }

    /// <summary>Validates that the value of the <see cref = "MFCONNECTOR_COMPOSITE"/> property is correct.</summary>
    [Test]
    public static void MFCONNECTOR_COMPOSITETest()
    {
        Assert.That(MFCONNECTOR_COMPOSITE, Is.EqualTo(new Guid(0x57cd596a, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
    }

    /// <summary>Validates that the value of the <see cref = "MFCONNECTOR_COMPONENT"/> property is correct.</summary>
    [Test]
    public static void MFCONNECTOR_COMPONENTTest()
    {
        Assert.That(MFCONNECTOR_COMPONENT, Is.EqualTo(new Guid(0x57cd596b, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
    }

    /// <summary>Validates that the value of the <see cref = "MFCONNECTOR_DVI"/> property is correct.</summary>
    [Test]
    public static void MFCONNECTOR_DVITest()
    {
        Assert.That(MFCONNECTOR_DVI, Is.EqualTo(new Guid(0x57cd596c, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
    }

    /// <summary>Validates that the value of the <see cref = "MFCONNECTOR_HDMI"/> property is correct.</summary>
    [Test]
    public static void MFCONNECTOR_HDMITest()
    {
        Assert.That(MFCONNECTOR_HDMI, Is.EqualTo(new Guid(0x57cd596d, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
    }

    /// <summary>Validates that the value of the <see cref = "MFCONNECTOR_LVDS"/> property is correct.</summary>
    [Test]
    public static void MFCONNECTOR_LVDSTest()
    {
        Assert.That(MFCONNECTOR_LVDS, Is.EqualTo(new Guid(0x57cd596e, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
    }

    /// <summary>Validates that the value of the <see cref = "MFCONNECTOR_D_JPN"/> property is correct.</summary>
    [Test]
    public static void MFCONNECTOR_D_JPNTest()
    {
        Assert.That(MFCONNECTOR_D_JPN, Is.EqualTo(new Guid(0x57cd5970, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
    }

    /// <summary>Validates that the value of the <see cref = "MFCONNECTOR_SDI"/> property is correct.</summary>
    [Test]
    public static void MFCONNECTOR_SDITest()
    {
        Assert.That(MFCONNECTOR_SDI, Is.EqualTo(new Guid(0x57cd5971, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
    }

    /// <summary>Validates that the value of the <see cref = "MFCONNECTOR_DISPLAYPORT_EXTERNAL"/> property is correct.</summary>
    [Test]
    public static void MFCONNECTOR_DISPLAYPORT_EXTERNALTest()
    {
        Assert.That(MFCONNECTOR_DISPLAYPORT_EXTERNAL, Is.EqualTo(new Guid(0x57cd5972, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
    }

    /// <summary>Validates that the value of the <see cref = "MFCONNECTOR_DISPLAYPORT_EMBEDDED"/> property is correct.</summary>
    [Test]
    public static void MFCONNECTOR_DISPLAYPORT_EMBEDDEDTest()
    {
        Assert.That(MFCONNECTOR_DISPLAYPORT_EMBEDDED, Is.EqualTo(new Guid(0x57cd5973, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
    }

    /// <summary>Validates that the value of the <see cref = "MFCONNECTOR_UDI_EXTERNAL"/> property is correct.</summary>
    [Test]
    public static void MFCONNECTOR_UDI_EXTERNALTest()
    {
        Assert.That(MFCONNECTOR_UDI_EXTERNAL, Is.EqualTo(new Guid(0x57cd5974, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
    }

    /// <summary>Validates that the value of the <see cref = "MFCONNECTOR_UDI_EMBEDDED"/> property is correct.</summary>
    [Test]
    public static void MFCONNECTOR_UDI_EMBEDDEDTest()
    {
        Assert.That(MFCONNECTOR_UDI_EMBEDDED, Is.EqualTo(new Guid(0x57cd5975, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
    }

    /// <summary>Validates that the value of the <see cref = "MFCONNECTOR_MIRACAST"/> property is correct.</summary>
    [Test]
    public static void MFCONNECTOR_MIRACASTTest()
    {
        Assert.That(MFCONNECTOR_MIRACAST, Is.EqualTo(new Guid(0x57cd5977, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
    }

    /// <summary>Validates that the value of the <see cref = "MFCONNECTOR_TRANSPORT_AGNOSTIC_DIGITAL_MODE_A"/> property is correct.</summary>
    [Test]
    public static void MFCONNECTOR_TRANSPORT_AGNOSTIC_DIGITAL_MODE_ATest()
    {
        Assert.That(MFCONNECTOR_TRANSPORT_AGNOSTIC_DIGITAL_MODE_A, Is.EqualTo(new Guid(0x57cd5978, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
    }

    /// <summary>Validates that the value of the <see cref = "MFCONNECTOR_TRANSPORT_AGNOSTIC_DIGITAL_MODE_B"/> property is correct.</summary>
    [Test]
    public static void MFCONNECTOR_TRANSPORT_AGNOSTIC_DIGITAL_MODE_BTest()
    {
        Assert.That(MFCONNECTOR_TRANSPORT_AGNOSTIC_DIGITAL_MODE_B, Is.EqualTo(new Guid(0x57cd5979, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
    }
}