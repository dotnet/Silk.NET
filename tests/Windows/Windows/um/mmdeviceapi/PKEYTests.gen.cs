// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.PKEY;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "PKEY"/> class.</summary>
public static partial class PKEYTests
{
    /// <summary>Validates that the value of the <see cref = "PKEY_AudioEndpoint_FormFactor"/> property is correct.</summary>
    [Test]
    public static void PKEY_AudioEndpoint_FormFactorTest()
    {
        Assert.That(PKEY_AudioEndpoint_FormFactor.fmtid, Is.EqualTo(new Guid(0x1da5d803, 0xd492, 0x4edd, 0x8c, 0x23, 0xe0, 0xc0, 0xff, 0xee, 0x7f, 0x0e)));
        Assert.That(PKEY_AudioEndpoint_FormFactor.pid, Is.EqualTo(0));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_AudioEndpoint_ControlPanelPageProvider"/> property is correct.</summary>
    [Test]
    public static void PKEY_AudioEndpoint_ControlPanelPageProviderTest()
    {
        Assert.That(PKEY_AudioEndpoint_ControlPanelPageProvider.fmtid, Is.EqualTo(new Guid(0x1da5d803, 0xd492, 0x4edd, 0x8c, 0x23, 0xe0, 0xc0, 0xff, 0xee, 0x7f, 0x0e)));
        Assert.That(PKEY_AudioEndpoint_ControlPanelPageProvider.pid, Is.EqualTo(1));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_AudioEndpoint_Association"/> property is correct.</summary>
    [Test]
    public static void PKEY_AudioEndpoint_AssociationTest()
    {
        Assert.That(PKEY_AudioEndpoint_Association.fmtid, Is.EqualTo(new Guid(0x1da5d803, 0xd492, 0x4edd, 0x8c, 0x23, 0xe0, 0xc0, 0xff, 0xee, 0x7f, 0x0e)));
        Assert.That(PKEY_AudioEndpoint_Association.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_AudioEndpoint_PhysicalSpeakers"/> property is correct.</summary>
    [Test]
    public static void PKEY_AudioEndpoint_PhysicalSpeakersTest()
    {
        Assert.That(PKEY_AudioEndpoint_PhysicalSpeakers.fmtid, Is.EqualTo(new Guid(0x1da5d803, 0xd492, 0x4edd, 0x8c, 0x23, 0xe0, 0xc0, 0xff, 0xee, 0x7f, 0x0e)));
        Assert.That(PKEY_AudioEndpoint_PhysicalSpeakers.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_AudioEndpoint_GUID"/> property is correct.</summary>
    [Test]
    public static void PKEY_AudioEndpoint_GUIDTest()
    {
        Assert.That(PKEY_AudioEndpoint_GUID.fmtid, Is.EqualTo(new Guid(0x1da5d803, 0xd492, 0x4edd, 0x8c, 0x23, 0xe0, 0xc0, 0xff, 0xee, 0x7f, 0x0e)));
        Assert.That(PKEY_AudioEndpoint_GUID.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_AudioEndpoint_Disable_SysFx"/> property is correct.</summary>
    [Test]
    public static void PKEY_AudioEndpoint_Disable_SysFxTest()
    {
        Assert.That(PKEY_AudioEndpoint_Disable_SysFx.fmtid, Is.EqualTo(new Guid(0x1da5d803, 0xd492, 0x4edd, 0x8c, 0x23, 0xe0, 0xc0, 0xff, 0xee, 0x7f, 0x0e)));
        Assert.That(PKEY_AudioEndpoint_Disable_SysFx.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_AudioEndpoint_FullRangeSpeakers"/> property is correct.</summary>
    [Test]
    public static void PKEY_AudioEndpoint_FullRangeSpeakersTest()
    {
        Assert.That(PKEY_AudioEndpoint_FullRangeSpeakers.fmtid, Is.EqualTo(new Guid(0x1da5d803, 0xd492, 0x4edd, 0x8c, 0x23, 0xe0, 0xc0, 0xff, 0xee, 0x7f, 0x0e)));
        Assert.That(PKEY_AudioEndpoint_FullRangeSpeakers.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_AudioEndpoint_Supports_EventDriven_Mode"/> property is correct.</summary>
    [Test]
    public static void PKEY_AudioEndpoint_Supports_EventDriven_ModeTest()
    {
        Assert.That(PKEY_AudioEndpoint_Supports_EventDriven_Mode.fmtid, Is.EqualTo(new Guid(0x1da5d803, 0xd492, 0x4edd, 0x8c, 0x23, 0xe0, 0xc0, 0xff, 0xee, 0x7f, 0x0e)));
        Assert.That(PKEY_AudioEndpoint_Supports_EventDriven_Mode.pid, Is.EqualTo(7));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_AudioEndpoint_JackSubType"/> property is correct.</summary>
    [Test]
    public static void PKEY_AudioEndpoint_JackSubTypeTest()
    {
        Assert.That(PKEY_AudioEndpoint_JackSubType.fmtid, Is.EqualTo(new Guid(0x1da5d803, 0xd492, 0x4edd, 0x8c, 0x23, 0xe0, 0xc0, 0xff, 0xee, 0x7f, 0x0e)));
        Assert.That(PKEY_AudioEndpoint_JackSubType.pid, Is.EqualTo(8));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_AudioEndpoint_Default_VolumeInDb"/> property is correct.</summary>
    [Test]
    public static void PKEY_AudioEndpoint_Default_VolumeInDbTest()
    {
        Assert.That(PKEY_AudioEndpoint_Default_VolumeInDb.fmtid, Is.EqualTo(new Guid(0x1da5d803, 0xd492, 0x4edd, 0x8c, 0x23, 0xe0, 0xc0, 0xff, 0xee, 0x7f, 0x0e)));
        Assert.That(PKEY_AudioEndpoint_Default_VolumeInDb.pid, Is.EqualTo(9));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_AudioEngine_DeviceFormat"/> property is correct.</summary>
    [Test]
    public static void PKEY_AudioEngine_DeviceFormatTest()
    {
        Assert.That(PKEY_AudioEngine_DeviceFormat.fmtid, Is.EqualTo(new Guid(0xf19f064d, 0x82c, 0x4e27, 0xbc, 0x73, 0x68, 0x82, 0xa1, 0xbb, 0x8e, 0x4c)));
        Assert.That(PKEY_AudioEngine_DeviceFormat.pid, Is.EqualTo(0));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_AudioEngine_OEMFormat"/> property is correct.</summary>
    [Test]
    public static void PKEY_AudioEngine_OEMFormatTest()
    {
        Assert.That(PKEY_AudioEngine_OEMFormat.fmtid, Is.EqualTo(new Guid(0xe4870e26, 0x3cc5, 0x4cd2, 0xba, 0x46, 0xca, 0xa, 0x9a, 0x70, 0xed, 0x4)));
        Assert.That(PKEY_AudioEngine_OEMFormat.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_AudioEndpointLogo_IconEffects"/> property is correct.</summary>
    [Test]
    public static void PKEY_AudioEndpointLogo_IconEffectsTest()
    {
        Assert.That(PKEY_AudioEndpointLogo_IconEffects.fmtid, Is.EqualTo(new Guid(0xf1ab780d, 0x2010, 0x4ed3, 0xa3, 0xa6, 0x8b, 0x87, 0xf0, 0xf0, 0xc4, 0x76)));
        Assert.That(PKEY_AudioEndpointLogo_IconEffects.pid, Is.EqualTo(0));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_AudioEndpointLogo_IconPath"/> property is correct.</summary>
    [Test]
    public static void PKEY_AudioEndpointLogo_IconPathTest()
    {
        Assert.That(PKEY_AudioEndpointLogo_IconPath.fmtid, Is.EqualTo(new Guid(0xf1ab780d, 0x2010, 0x4ed3, 0xa3, 0xa6, 0x8b, 0x87, 0xf0, 0xf0, 0xc4, 0x76)));
        Assert.That(PKEY_AudioEndpointLogo_IconPath.pid, Is.EqualTo(1));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_AudioEndpointSettings_MenuText"/> property is correct.</summary>
    [Test]
    public static void PKEY_AudioEndpointSettings_MenuTextTest()
    {
        Assert.That(PKEY_AudioEndpointSettings_MenuText.fmtid, Is.EqualTo(new Guid(0x14242002, 0x0320, 0x4de4, 0x95, 0x55, 0xa7, 0xd8, 0x2b, 0x73, 0xc2, 0x86)));
        Assert.That(PKEY_AudioEndpointSettings_MenuText.pid, Is.EqualTo(0));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_AudioEndpointSettings_LaunchContract"/> property is correct.</summary>
    [Test]
    public static void PKEY_AudioEndpointSettings_LaunchContractTest()
    {
        Assert.That(PKEY_AudioEndpointSettings_LaunchContract.fmtid, Is.EqualTo(new Guid(0x14242002, 0x0320, 0x4de4, 0x95, 0x55, 0xa7, 0xd8, 0x2b, 0x73, 0xc2, 0x86)));
        Assert.That(PKEY_AudioEndpointSettings_LaunchContract.pid, Is.EqualTo(1));
    }
}