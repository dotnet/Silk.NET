// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propkey.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.PKEY;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "PKEY"/> class.</summary>
public static partial class PKEYTests
{
    /// <summary>Validates that the value of the <see cref = "PKEY_Address_Country"/> property is correct.</summary>
    [Test]
    public static void PKEY_Address_CountryTest()
    {
        Assert.That(PKEY_Address_Country.fmtid, Is.EqualTo(new Guid(0xC07B4199, 0xE1DF, 0x4493, 0xB1, 0xE1, 0xDE, 0x59, 0x46, 0xFB, 0x58, 0xF8)));
        Assert.That(PKEY_Address_Country.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Address_CountryCode"/> property is correct.</summary>
    [Test]
    public static void PKEY_Address_CountryCodeTest()
    {
        Assert.That(PKEY_Address_CountryCode.fmtid, Is.EqualTo(new Guid(0xC07B4199, 0xE1DF, 0x4493, 0xB1, 0xE1, 0xDE, 0x59, 0x46, 0xFB, 0x58, 0xF8)));
        Assert.That(PKEY_Address_CountryCode.pid, Is.EqualTo(101));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Address_Region"/> property is correct.</summary>
    [Test]
    public static void PKEY_Address_RegionTest()
    {
        Assert.That(PKEY_Address_Region.fmtid, Is.EqualTo(new Guid(0xC07B4199, 0xE1DF, 0x4493, 0xB1, 0xE1, 0xDE, 0x59, 0x46, 0xFB, 0x58, 0xF8)));
        Assert.That(PKEY_Address_Region.pid, Is.EqualTo(102));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Address_RegionCode"/> property is correct.</summary>
    [Test]
    public static void PKEY_Address_RegionCodeTest()
    {
        Assert.That(PKEY_Address_RegionCode.fmtid, Is.EqualTo(new Guid(0xC07B4199, 0xE1DF, 0x4493, 0xB1, 0xE1, 0xDE, 0x59, 0x46, 0xFB, 0x58, 0xF8)));
        Assert.That(PKEY_Address_RegionCode.pid, Is.EqualTo(103));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Address_Town"/> property is correct.</summary>
    [Test]
    public static void PKEY_Address_TownTest()
    {
        Assert.That(PKEY_Address_Town.fmtid, Is.EqualTo(new Guid(0xC07B4199, 0xE1DF, 0x4493, 0xB1, 0xE1, 0xDE, 0x59, 0x46, 0xFB, 0x58, 0xF8)));
        Assert.That(PKEY_Address_Town.pid, Is.EqualTo(104));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Audio_ChannelCount"/> property is correct.</summary>
    [Test]
    public static void PKEY_Audio_ChannelCountTest()
    {
        Assert.That(PKEY_Audio_ChannelCount.fmtid, Is.EqualTo(new Guid(0x64440490, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Audio_ChannelCount.pid, Is.EqualTo(7));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Audio_Compression"/> property is correct.</summary>
    [Test]
    public static void PKEY_Audio_CompressionTest()
    {
        Assert.That(PKEY_Audio_Compression.fmtid, Is.EqualTo(new Guid(0x64440490, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Audio_Compression.pid, Is.EqualTo(10));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Audio_EncodingBitrate"/> property is correct.</summary>
    [Test]
    public static void PKEY_Audio_EncodingBitrateTest()
    {
        Assert.That(PKEY_Audio_EncodingBitrate.fmtid, Is.EqualTo(new Guid(0x64440490, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Audio_EncodingBitrate.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Audio_Format"/> property is correct.</summary>
    [Test]
    public static void PKEY_Audio_FormatTest()
    {
        Assert.That(PKEY_Audio_Format.fmtid, Is.EqualTo(new Guid(0x64440490, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Audio_Format.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Audio_IsVariableBitRate"/> property is correct.</summary>
    [Test]
    public static void PKEY_Audio_IsVariableBitRateTest()
    {
        Assert.That(PKEY_Audio_IsVariableBitRate.fmtid, Is.EqualTo(new Guid(0xE6822FEE, 0x8C17, 0x4D62, 0x82, 0x3C, 0x8E, 0x9C, 0xFC, 0xBD, 0x1D, 0x5C)));
        Assert.That(PKEY_Audio_IsVariableBitRate.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Audio_PeakValue"/> property is correct.</summary>
    [Test]
    public static void PKEY_Audio_PeakValueTest()
    {
        Assert.That(PKEY_Audio_PeakValue.fmtid, Is.EqualTo(new Guid(0x2579E5D0, 0x1116, 0x4084, 0xBD, 0x9A, 0x9B, 0x4F, 0x7C, 0xB4, 0xDF, 0x5E)));
        Assert.That(PKEY_Audio_PeakValue.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Audio_SampleRate"/> property is correct.</summary>
    [Test]
    public static void PKEY_Audio_SampleRateTest()
    {
        Assert.That(PKEY_Audio_SampleRate.fmtid, Is.EqualTo(new Guid(0x64440490, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Audio_SampleRate.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Audio_SampleSize"/> property is correct.</summary>
    [Test]
    public static void PKEY_Audio_SampleSizeTest()
    {
        Assert.That(PKEY_Audio_SampleSize.fmtid, Is.EqualTo(new Guid(0x64440490, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Audio_SampleSize.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Audio_StreamName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Audio_StreamNameTest()
    {
        Assert.That(PKEY_Audio_StreamName.fmtid, Is.EqualTo(new Guid(0x64440490, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Audio_StreamName.pid, Is.EqualTo(9));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Audio_StreamNumber"/> property is correct.</summary>
    [Test]
    public static void PKEY_Audio_StreamNumberTest()
    {
        Assert.That(PKEY_Audio_StreamNumber.fmtid, Is.EqualTo(new Guid(0x64440490, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Audio_StreamNumber.pid, Is.EqualTo(8));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Calendar_Duration"/> property is correct.</summary>
    [Test]
    public static void PKEY_Calendar_DurationTest()
    {
        Assert.That(PKEY_Calendar_Duration.fmtid, Is.EqualTo(new Guid(0x293CA35A, 0x09AA, 0x4DD2, 0xB1, 0x80, 0x1F, 0xE2, 0x45, 0x72, 0x8A, 0x52)));
        Assert.That(PKEY_Calendar_Duration.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Calendar_IsOnline"/> property is correct.</summary>
    [Test]
    public static void PKEY_Calendar_IsOnlineTest()
    {
        Assert.That(PKEY_Calendar_IsOnline.fmtid, Is.EqualTo(new Guid(0xBFEE9149, 0xE3E2, 0x49A7, 0xA8, 0x62, 0xC0, 0x59, 0x88, 0x14, 0x5C, 0xEC)));
        Assert.That(PKEY_Calendar_IsOnline.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Calendar_IsRecurring"/> property is correct.</summary>
    [Test]
    public static void PKEY_Calendar_IsRecurringTest()
    {
        Assert.That(PKEY_Calendar_IsRecurring.fmtid, Is.EqualTo(new Guid(0x315B9C8D, 0x80A9, 0x4EF9, 0xAE, 0x16, 0x8E, 0x74, 0x6D, 0xA5, 0x1D, 0x70)));
        Assert.That(PKEY_Calendar_IsRecurring.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Calendar_Location"/> property is correct.</summary>
    [Test]
    public static void PKEY_Calendar_LocationTest()
    {
        Assert.That(PKEY_Calendar_Location.fmtid, Is.EqualTo(new Guid(0xF6272D18, 0xCECC, 0x40B1, 0xB2, 0x6A, 0x39, 0x11, 0x71, 0x7A, 0xA7, 0xBD)));
        Assert.That(PKEY_Calendar_Location.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Calendar_OptionalAttendeeAddresses"/> property is correct.</summary>
    [Test]
    public static void PKEY_Calendar_OptionalAttendeeAddressesTest()
    {
        Assert.That(PKEY_Calendar_OptionalAttendeeAddresses.fmtid, Is.EqualTo(new Guid(0xD55BAE5A, 0x3892, 0x417A, 0xA6, 0x49, 0xC6, 0xAC, 0x5A, 0xAA, 0xEA, 0xB3)));
        Assert.That(PKEY_Calendar_OptionalAttendeeAddresses.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Calendar_OptionalAttendeeNames"/> property is correct.</summary>
    [Test]
    public static void PKEY_Calendar_OptionalAttendeeNamesTest()
    {
        Assert.That(PKEY_Calendar_OptionalAttendeeNames.fmtid, Is.EqualTo(new Guid(0x09429607, 0x582D, 0x437F, 0x84, 0xC3, 0xDE, 0x93, 0xA2, 0xB2, 0x4C, 0x3C)));
        Assert.That(PKEY_Calendar_OptionalAttendeeNames.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Calendar_OrganizerAddress"/> property is correct.</summary>
    [Test]
    public static void PKEY_Calendar_OrganizerAddressTest()
    {
        Assert.That(PKEY_Calendar_OrganizerAddress.fmtid, Is.EqualTo(new Guid(0x744C8242, 0x4DF5, 0x456C, 0xAB, 0x9E, 0x01, 0x4E, 0xFB, 0x90, 0x21, 0xE3)));
        Assert.That(PKEY_Calendar_OrganizerAddress.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Calendar_OrganizerName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Calendar_OrganizerNameTest()
    {
        Assert.That(PKEY_Calendar_OrganizerName.fmtid, Is.EqualTo(new Guid(0xAAA660F9, 0x9865, 0x458E, 0xB4, 0x84, 0x01, 0xBC, 0x7F, 0xE3, 0x97, 0x3E)));
        Assert.That(PKEY_Calendar_OrganizerName.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Calendar_ReminderTime"/> property is correct.</summary>
    [Test]
    public static void PKEY_Calendar_ReminderTimeTest()
    {
        Assert.That(PKEY_Calendar_ReminderTime.fmtid, Is.EqualTo(new Guid(0x72FC5BA4, 0x24F9, 0x4011, 0x9F, 0x3F, 0xAD, 0xD2, 0x7A, 0xFA, 0xD8, 0x18)));
        Assert.That(PKEY_Calendar_ReminderTime.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Calendar_RequiredAttendeeAddresses"/> property is correct.</summary>
    [Test]
    public static void PKEY_Calendar_RequiredAttendeeAddressesTest()
    {
        Assert.That(PKEY_Calendar_RequiredAttendeeAddresses.fmtid, Is.EqualTo(new Guid(0x0BA7D6C3, 0x568D, 0x4159, 0xAB, 0x91, 0x78, 0x1A, 0x91, 0xFB, 0x71, 0xE5)));
        Assert.That(PKEY_Calendar_RequiredAttendeeAddresses.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Calendar_RequiredAttendeeNames"/> property is correct.</summary>
    [Test]
    public static void PKEY_Calendar_RequiredAttendeeNamesTest()
    {
        Assert.That(PKEY_Calendar_RequiredAttendeeNames.fmtid, Is.EqualTo(new Guid(0xB33AF30B, 0xF552, 0x4584, 0x93, 0x6C, 0xCB, 0x93, 0xE5, 0xCD, 0xA2, 0x9F)));
        Assert.That(PKEY_Calendar_RequiredAttendeeNames.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Calendar_Resources"/> property is correct.</summary>
    [Test]
    public static void PKEY_Calendar_ResourcesTest()
    {
        Assert.That(PKEY_Calendar_Resources.fmtid, Is.EqualTo(new Guid(0x00F58A38, 0xC54B, 0x4C40, 0x86, 0x96, 0x97, 0x23, 0x59, 0x80, 0xEA, 0xE1)));
        Assert.That(PKEY_Calendar_Resources.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Calendar_ResponseStatus"/> property is correct.</summary>
    [Test]
    public static void PKEY_Calendar_ResponseStatusTest()
    {
        Assert.That(PKEY_Calendar_ResponseStatus.fmtid, Is.EqualTo(new Guid(0x188C1F91, 0x3C40, 0x4132, 0x9E, 0xC5, 0xD8, 0xB0, 0x3B, 0x72, 0xA8, 0xA2)));
        Assert.That(PKEY_Calendar_ResponseStatus.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Calendar_ShowTimeAs"/> property is correct.</summary>
    [Test]
    public static void PKEY_Calendar_ShowTimeAsTest()
    {
        Assert.That(PKEY_Calendar_ShowTimeAs.fmtid, Is.EqualTo(new Guid(0x5BF396D4, 0x5EB2, 0x466F, 0xBD, 0xE9, 0x2F, 0xB3, 0xF2, 0x36, 0x1D, 0x6E)));
        Assert.That(PKEY_Calendar_ShowTimeAs.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Calendar_ShowTimeAsText"/> property is correct.</summary>
    [Test]
    public static void PKEY_Calendar_ShowTimeAsTextTest()
    {
        Assert.That(PKEY_Calendar_ShowTimeAsText.fmtid, Is.EqualTo(new Guid(0x53DA57CF, 0x62C0, 0x45C4, 0x81, 0xDE, 0x76, 0x10, 0xBC, 0xEF, 0xD7, 0xF5)));
        Assert.That(PKEY_Calendar_ShowTimeAsText.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Communication_AccountName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Communication_AccountNameTest()
    {
        Assert.That(PKEY_Communication_AccountName.fmtid, Is.EqualTo(new Guid(0xE3E0584C, 0xB788, 0x4A5A, 0xBB, 0x20, 0x7F, 0x5A, 0x44, 0xC9, 0xAC, 0xDD)));
        Assert.That(PKEY_Communication_AccountName.pid, Is.EqualTo(9));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Communication_DateItemExpires"/> property is correct.</summary>
    [Test]
    public static void PKEY_Communication_DateItemExpiresTest()
    {
        Assert.That(PKEY_Communication_DateItemExpires.fmtid, Is.EqualTo(new Guid(0x428040AC, 0xA177, 0x4C8A, 0x97, 0x60, 0xF6, 0xF7, 0x61, 0x22, 0x7F, 0x9A)));
        Assert.That(PKEY_Communication_DateItemExpires.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Communication_Direction"/> property is correct.</summary>
    [Test]
    public static void PKEY_Communication_DirectionTest()
    {
        Assert.That(PKEY_Communication_Direction.fmtid, Is.EqualTo(new Guid(0x8E531030, 0xB960, 0x4346, 0xAE, 0x0D, 0x66, 0xBC, 0x9A, 0x86, 0xFB, 0x94)));
        Assert.That(PKEY_Communication_Direction.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Communication_FollowupIconIndex"/> property is correct.</summary>
    [Test]
    public static void PKEY_Communication_FollowupIconIndexTest()
    {
        Assert.That(PKEY_Communication_FollowupIconIndex.fmtid, Is.EqualTo(new Guid(0x83A6347E, 0x6FE4, 0x4F40, 0xBA, 0x9C, 0xC4, 0x86, 0x52, 0x40, 0xD1, 0xF4)));
        Assert.That(PKEY_Communication_FollowupIconIndex.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Communication_HeaderItem"/> property is correct.</summary>
    [Test]
    public static void PKEY_Communication_HeaderItemTest()
    {
        Assert.That(PKEY_Communication_HeaderItem.fmtid, Is.EqualTo(new Guid(0xC9C34F84, 0x2241, 0x4401, 0xB6, 0x07, 0xBD, 0x20, 0xED, 0x75, 0xAE, 0x7F)));
        Assert.That(PKEY_Communication_HeaderItem.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Communication_PolicyTag"/> property is correct.</summary>
    [Test]
    public static void PKEY_Communication_PolicyTagTest()
    {
        Assert.That(PKEY_Communication_PolicyTag.fmtid, Is.EqualTo(new Guid(0xEC0B4191, 0xAB0B, 0x4C66, 0x90, 0xB6, 0xC6, 0x63, 0x7C, 0xDE, 0xBB, 0xAB)));
        Assert.That(PKEY_Communication_PolicyTag.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Communication_SecurityFlags"/> property is correct.</summary>
    [Test]
    public static void PKEY_Communication_SecurityFlagsTest()
    {
        Assert.That(PKEY_Communication_SecurityFlags.fmtid, Is.EqualTo(new Guid(0x8619A4B6, 0x9F4D, 0x4429, 0x8C, 0x0F, 0xB9, 0x96, 0xCA, 0x59, 0xE3, 0x35)));
        Assert.That(PKEY_Communication_SecurityFlags.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Communication_Suffix"/> property is correct.</summary>
    [Test]
    public static void PKEY_Communication_SuffixTest()
    {
        Assert.That(PKEY_Communication_Suffix.fmtid, Is.EqualTo(new Guid(0x807B653A, 0x9E91, 0x43EF, 0x8F, 0x97, 0x11, 0xCE, 0x04, 0xEE, 0x20, 0xC5)));
        Assert.That(PKEY_Communication_Suffix.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Communication_TaskStatus"/> property is correct.</summary>
    [Test]
    public static void PKEY_Communication_TaskStatusTest()
    {
        Assert.That(PKEY_Communication_TaskStatus.fmtid, Is.EqualTo(new Guid(0xBE1A72C6, 0x9A1D, 0x46B7, 0xAF, 0xE7, 0xAF, 0xAF, 0x8C, 0xEF, 0x49, 0x99)));
        Assert.That(PKEY_Communication_TaskStatus.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Communication_TaskStatusText"/> property is correct.</summary>
    [Test]
    public static void PKEY_Communication_TaskStatusTextTest()
    {
        Assert.That(PKEY_Communication_TaskStatusText.fmtid, Is.EqualTo(new Guid(0xA6744477, 0xC237, 0x475B, 0xA0, 0x75, 0x54, 0xF3, 0x44, 0x98, 0x29, 0x2A)));
        Assert.That(PKEY_Communication_TaskStatusText.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Computer_DecoratedFreeSpace"/> property is correct.</summary>
    [Test]
    public static void PKEY_Computer_DecoratedFreeSpaceTest()
    {
        Assert.That(PKEY_Computer_DecoratedFreeSpace.fmtid, Is.EqualTo(new Guid(0x9B174B35, 0x40FF, 0x11D2, 0xA2, 0x7E, 0x00, 0xC0, 0x4F, 0xC3, 0x08, 0x71)));
        Assert.That(PKEY_Computer_DecoratedFreeSpace.pid, Is.EqualTo(7));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_AccountPictureDynamicVideo"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_AccountPictureDynamicVideoTest()
    {
        Assert.That(PKEY_Contact_AccountPictureDynamicVideo.fmtid, Is.EqualTo(new Guid(0x0B8BB018, 0x2725, 0x4B44, 0x92, 0xBA, 0x79, 0x33, 0xAE, 0xB2, 0xDD, 0xE7)));
        Assert.That(PKEY_Contact_AccountPictureDynamicVideo.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_AccountPictureLarge"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_AccountPictureLargeTest()
    {
        Assert.That(PKEY_Contact_AccountPictureLarge.fmtid, Is.EqualTo(new Guid(0x0B8BB018, 0x2725, 0x4B44, 0x92, 0xBA, 0x79, 0x33, 0xAE, 0xB2, 0xDD, 0xE7)));
        Assert.That(PKEY_Contact_AccountPictureLarge.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_AccountPictureSmall"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_AccountPictureSmallTest()
    {
        Assert.That(PKEY_Contact_AccountPictureSmall.fmtid, Is.EqualTo(new Guid(0x0B8BB018, 0x2725, 0x4B44, 0x92, 0xBA, 0x79, 0x33, 0xAE, 0xB2, 0xDD, 0xE7)));
        Assert.That(PKEY_Contact_AccountPictureSmall.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_Anniversary"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_AnniversaryTest()
    {
        Assert.That(PKEY_Contact_Anniversary.fmtid, Is.EqualTo(new Guid(0x9AD5BADB, 0xCEA7, 0x4470, 0xA0, 0x3D, 0xB8, 0x4E, 0x51, 0xB9, 0x94, 0x9E)));
        Assert.That(PKEY_Contact_Anniversary.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_AssistantName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_AssistantNameTest()
    {
        Assert.That(PKEY_Contact_AssistantName.fmtid, Is.EqualTo(new Guid(0xCD102C9C, 0x5540, 0x4A88, 0xA6, 0xF6, 0x64, 0xE4, 0x98, 0x1C, 0x8C, 0xD1)));
        Assert.That(PKEY_Contact_AssistantName.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_AssistantTelephone"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_AssistantTelephoneTest()
    {
        Assert.That(PKEY_Contact_AssistantTelephone.fmtid, Is.EqualTo(new Guid(0x9A93244D, 0xA7AD, 0x4FF8, 0x9B, 0x99, 0x45, 0xEE, 0x4C, 0xC0, 0x9A, 0xF6)));
        Assert.That(PKEY_Contact_AssistantTelephone.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_Birthday"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_BirthdayTest()
    {
        Assert.That(PKEY_Contact_Birthday.fmtid, Is.EqualTo(new Guid(0x176DC63C, 0x2688, 0x4E89, 0x81, 0x43, 0xA3, 0x47, 0x80, 0x0F, 0x25, 0xE9)));
        Assert.That(PKEY_Contact_Birthday.pid, Is.EqualTo(47));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_BusinessAddress"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_BusinessAddressTest()
    {
        Assert.That(PKEY_Contact_BusinessAddress.fmtid, Is.EqualTo(new Guid(0x730FB6DD, 0xCF7C, 0x426B, 0xA0, 0x3F, 0xBD, 0x16, 0x6C, 0xC9, 0xEE, 0x24)));
        Assert.That(PKEY_Contact_BusinessAddress.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_BusinessAddress1Country"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_BusinessAddress1CountryTest()
    {
        Assert.That(PKEY_Contact_BusinessAddress1Country.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_BusinessAddress1Country.pid, Is.EqualTo(119));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_BusinessAddress1Locality"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_BusinessAddress1LocalityTest()
    {
        Assert.That(PKEY_Contact_BusinessAddress1Locality.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_BusinessAddress1Locality.pid, Is.EqualTo(117));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_BusinessAddress1PostalCode"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_BusinessAddress1PostalCodeTest()
    {
        Assert.That(PKEY_Contact_BusinessAddress1PostalCode.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_BusinessAddress1PostalCode.pid, Is.EqualTo(120));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_BusinessAddress1Region"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_BusinessAddress1RegionTest()
    {
        Assert.That(PKEY_Contact_BusinessAddress1Region.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_BusinessAddress1Region.pid, Is.EqualTo(118));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_BusinessAddress1Street"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_BusinessAddress1StreetTest()
    {
        Assert.That(PKEY_Contact_BusinessAddress1Street.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_BusinessAddress1Street.pid, Is.EqualTo(116));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_BusinessAddress2Country"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_BusinessAddress2CountryTest()
    {
        Assert.That(PKEY_Contact_BusinessAddress2Country.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_BusinessAddress2Country.pid, Is.EqualTo(124));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_BusinessAddress2Locality"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_BusinessAddress2LocalityTest()
    {
        Assert.That(PKEY_Contact_BusinessAddress2Locality.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_BusinessAddress2Locality.pid, Is.EqualTo(122));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_BusinessAddress2PostalCode"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_BusinessAddress2PostalCodeTest()
    {
        Assert.That(PKEY_Contact_BusinessAddress2PostalCode.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_BusinessAddress2PostalCode.pid, Is.EqualTo(125));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_BusinessAddress2Region"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_BusinessAddress2RegionTest()
    {
        Assert.That(PKEY_Contact_BusinessAddress2Region.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_BusinessAddress2Region.pid, Is.EqualTo(123));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_BusinessAddress2Street"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_BusinessAddress2StreetTest()
    {
        Assert.That(PKEY_Contact_BusinessAddress2Street.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_BusinessAddress2Street.pid, Is.EqualTo(121));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_BusinessAddress3Country"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_BusinessAddress3CountryTest()
    {
        Assert.That(PKEY_Contact_BusinessAddress3Country.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_BusinessAddress3Country.pid, Is.EqualTo(129));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_BusinessAddress3Locality"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_BusinessAddress3LocalityTest()
    {
        Assert.That(PKEY_Contact_BusinessAddress3Locality.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_BusinessAddress3Locality.pid, Is.EqualTo(127));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_BusinessAddress3PostalCode"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_BusinessAddress3PostalCodeTest()
    {
        Assert.That(PKEY_Contact_BusinessAddress3PostalCode.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_BusinessAddress3PostalCode.pid, Is.EqualTo(130));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_BusinessAddress3Region"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_BusinessAddress3RegionTest()
    {
        Assert.That(PKEY_Contact_BusinessAddress3Region.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_BusinessAddress3Region.pid, Is.EqualTo(128));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_BusinessAddress3Street"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_BusinessAddress3StreetTest()
    {
        Assert.That(PKEY_Contact_BusinessAddress3Street.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_BusinessAddress3Street.pid, Is.EqualTo(126));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_BusinessAddressCity"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_BusinessAddressCityTest()
    {
        Assert.That(PKEY_Contact_BusinessAddressCity.fmtid, Is.EqualTo(new Guid(0x402B5934, 0xEC5A, 0x48C3, 0x93, 0xE6, 0x85, 0xE8, 0x6A, 0x2D, 0x93, 0x4E)));
        Assert.That(PKEY_Contact_BusinessAddressCity.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_BusinessAddressCountry"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_BusinessAddressCountryTest()
    {
        Assert.That(PKEY_Contact_BusinessAddressCountry.fmtid, Is.EqualTo(new Guid(0xB0B87314, 0xFCF6, 0x4FEB, 0x8D, 0xFF, 0xA5, 0x0D, 0xA6, 0xAF, 0x56, 0x1C)));
        Assert.That(PKEY_Contact_BusinessAddressCountry.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_BusinessAddressPostalCode"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_BusinessAddressPostalCodeTest()
    {
        Assert.That(PKEY_Contact_BusinessAddressPostalCode.fmtid, Is.EqualTo(new Guid(0xE1D4A09E, 0xD758, 0x4CD1, 0xB6, 0xEC, 0x34, 0xA8, 0xB5, 0xA7, 0x3F, 0x80)));
        Assert.That(PKEY_Contact_BusinessAddressPostalCode.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_BusinessAddressPostOfficeBox"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_BusinessAddressPostOfficeBoxTest()
    {
        Assert.That(PKEY_Contact_BusinessAddressPostOfficeBox.fmtid, Is.EqualTo(new Guid(0xBC4E71CE, 0x17F9, 0x48D5, 0xBE, 0xE9, 0x02, 0x1D, 0xF0, 0xEA, 0x54, 0x09)));
        Assert.That(PKEY_Contact_BusinessAddressPostOfficeBox.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_BusinessAddressState"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_BusinessAddressStateTest()
    {
        Assert.That(PKEY_Contact_BusinessAddressState.fmtid, Is.EqualTo(new Guid(0x446F787F, 0x10C4, 0x41CB, 0xA6, 0xC4, 0x4D, 0x03, 0x43, 0x55, 0x15, 0x97)));
        Assert.That(PKEY_Contact_BusinessAddressState.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_BusinessAddressStreet"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_BusinessAddressStreetTest()
    {
        Assert.That(PKEY_Contact_BusinessAddressStreet.fmtid, Is.EqualTo(new Guid(0xDDD1460F, 0xC0BF, 0x4553, 0x8C, 0xE4, 0x10, 0x43, 0x3C, 0x90, 0x8F, 0xB0)));
        Assert.That(PKEY_Contact_BusinessAddressStreet.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_BusinessEmailAddresses"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_BusinessEmailAddressesTest()
    {
        Assert.That(PKEY_Contact_BusinessEmailAddresses.fmtid, Is.EqualTo(new Guid(0xF271C659, 0x7E5E, 0x471F, 0xBA, 0x25, 0x7F, 0x77, 0xB2, 0x86, 0xF8, 0x36)));
        Assert.That(PKEY_Contact_BusinessEmailAddresses.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_BusinessFaxNumber"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_BusinessFaxNumberTest()
    {
        Assert.That(PKEY_Contact_BusinessFaxNumber.fmtid, Is.EqualTo(new Guid(0x91EFF6F3, 0x2E27, 0x42CA, 0x93, 0x3E, 0x7C, 0x99, 0x9F, 0xBE, 0x31, 0x0B)));
        Assert.That(PKEY_Contact_BusinessFaxNumber.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_BusinessHomePage"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_BusinessHomePageTest()
    {
        Assert.That(PKEY_Contact_BusinessHomePage.fmtid, Is.EqualTo(new Guid(0x56310920, 0x2491, 0x4919, 0x99, 0xCE, 0xEA, 0xDB, 0x06, 0xFA, 0xFD, 0xB2)));
        Assert.That(PKEY_Contact_BusinessHomePage.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_BusinessTelephone"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_BusinessTelephoneTest()
    {
        Assert.That(PKEY_Contact_BusinessTelephone.fmtid, Is.EqualTo(new Guid(0x6A15E5A0, 0x0A1E, 0x4CD7, 0xBB, 0x8C, 0xD2, 0xF1, 0xB0, 0xC9, 0x29, 0xBC)));
        Assert.That(PKEY_Contact_BusinessTelephone.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_CallbackTelephone"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_CallbackTelephoneTest()
    {
        Assert.That(PKEY_Contact_CallbackTelephone.fmtid, Is.EqualTo(new Guid(0xBF53D1C3, 0x49E0, 0x4F7F, 0x85, 0x67, 0x5A, 0x82, 0x1D, 0x8A, 0xC5, 0x42)));
        Assert.That(PKEY_Contact_CallbackTelephone.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_CarTelephone"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_CarTelephoneTest()
    {
        Assert.That(PKEY_Contact_CarTelephone.fmtid, Is.EqualTo(new Guid(0x8FDC6DEA, 0xB929, 0x412B, 0xBA, 0x90, 0x39, 0x7A, 0x25, 0x74, 0x65, 0xFE)));
        Assert.That(PKEY_Contact_CarTelephone.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_Children"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_ChildrenTest()
    {
        Assert.That(PKEY_Contact_Children.fmtid, Is.EqualTo(new Guid(0xD4729704, 0x8EF1, 0x43EF, 0x90, 0x24, 0x2B, 0xD3, 0x81, 0x18, 0x7F, 0xD5)));
        Assert.That(PKEY_Contact_Children.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_CompanyMainTelephone"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_CompanyMainTelephoneTest()
    {
        Assert.That(PKEY_Contact_CompanyMainTelephone.fmtid, Is.EqualTo(new Guid(0x8589E481, 0x6040, 0x473D, 0xB1, 0x71, 0x7F, 0xA8, 0x9C, 0x27, 0x08, 0xED)));
        Assert.That(PKEY_Contact_CompanyMainTelephone.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_ConnectedServiceDisplayName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_ConnectedServiceDisplayNameTest()
    {
        Assert.That(PKEY_Contact_ConnectedServiceDisplayName.fmtid, Is.EqualTo(new Guid(0x39B77F4F, 0xA104, 0x4863, 0xB3, 0x95, 0x2D, 0xB2, 0xAD, 0x8F, 0x7B, 0xC1)));
        Assert.That(PKEY_Contact_ConnectedServiceDisplayName.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_ConnectedServiceIdentities"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_ConnectedServiceIdentitiesTest()
    {
        Assert.That(PKEY_Contact_ConnectedServiceIdentities.fmtid, Is.EqualTo(new Guid(0x80F41EB8, 0xAFC4, 0x4208, 0xAA, 0x5F, 0xCC, 0xE2, 0x1A, 0x62, 0x72, 0x81)));
        Assert.That(PKEY_Contact_ConnectedServiceIdentities.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_ConnectedServiceName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_ConnectedServiceNameTest()
    {
        Assert.That(PKEY_Contact_ConnectedServiceName.fmtid, Is.EqualTo(new Guid(0xB5C84C9E, 0x5927, 0x46B5, 0xA3, 0xCC, 0x93, 0x3C, 0x21, 0xB7, 0x84, 0x69)));
        Assert.That(PKEY_Contact_ConnectedServiceName.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_ConnectedServiceSupportedActions"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_ConnectedServiceSupportedActionsTest()
    {
        Assert.That(PKEY_Contact_ConnectedServiceSupportedActions.fmtid, Is.EqualTo(new Guid(0xA19FB7A9, 0x024B, 0x4371, 0xA8, 0xBF, 0x4D, 0x29, 0xC3, 0xE4, 0xE9, 0xC9)));
        Assert.That(PKEY_Contact_ConnectedServiceSupportedActions.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_DataSuppliers"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_DataSuppliersTest()
    {
        Assert.That(PKEY_Contact_DataSuppliers.fmtid, Is.EqualTo(new Guid(0x9660C283, 0xFC3A, 0x4A08, 0xA0, 0x96, 0xEE, 0xD3, 0xAA, 0xC4, 0x6D, 0xA2)));
        Assert.That(PKEY_Contact_DataSuppliers.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_Department"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_DepartmentTest()
    {
        Assert.That(PKEY_Contact_Department.fmtid, Is.EqualTo(new Guid(0xFC9F7306, 0xFF8F, 0x4D49, 0x9F, 0xB6, 0x3F, 0xFE, 0x5C, 0x09, 0x51, 0xEC)));
        Assert.That(PKEY_Contact_Department.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_DisplayBusinessPhoneNumbers"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_DisplayBusinessPhoneNumbersTest()
    {
        Assert.That(PKEY_Contact_DisplayBusinessPhoneNumbers.fmtid, Is.EqualTo(new Guid(0x364028DA, 0xD895, 0x41FE, 0xA5, 0x84, 0x30, 0x2B, 0x1B, 0xB7, 0x0A, 0x76)));
        Assert.That(PKEY_Contact_DisplayBusinessPhoneNumbers.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_DisplayHomePhoneNumbers"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_DisplayHomePhoneNumbersTest()
    {
        Assert.That(PKEY_Contact_DisplayHomePhoneNumbers.fmtid, Is.EqualTo(new Guid(0x5068BCDF, 0xD697, 0x4D85, 0x8C, 0x53, 0x1F, 0x1C, 0xDA, 0xB0, 0x17, 0x63)));
        Assert.That(PKEY_Contact_DisplayHomePhoneNumbers.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_DisplayMobilePhoneNumbers"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_DisplayMobilePhoneNumbersTest()
    {
        Assert.That(PKEY_Contact_DisplayMobilePhoneNumbers.fmtid, Is.EqualTo(new Guid(0x9CB0C358, 0x9D7A, 0x46B1, 0xB4, 0x66, 0xDC, 0xC6, 0xF1, 0xA3, 0xD9, 0x3D)));
        Assert.That(PKEY_Contact_DisplayMobilePhoneNumbers.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_DisplayOtherPhoneNumbers"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_DisplayOtherPhoneNumbersTest()
    {
        Assert.That(PKEY_Contact_DisplayOtherPhoneNumbers.fmtid, Is.EqualTo(new Guid(0x03089873, 0x8EE8, 0x4191, 0xBD, 0x60, 0xD3, 0x1F, 0x72, 0xB7, 0x90, 0x0B)));
        Assert.That(PKEY_Contact_DisplayOtherPhoneNumbers.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_EmailAddress"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_EmailAddressTest()
    {
        Assert.That(PKEY_Contact_EmailAddress.fmtid, Is.EqualTo(new Guid(0xF8FA7FA3, 0xD12B, 0x4785, 0x8A, 0x4E, 0x69, 0x1A, 0x94, 0xF7, 0xA3, 0xE7)));
        Assert.That(PKEY_Contact_EmailAddress.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_EmailAddress2"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_EmailAddress2Test()
    {
        Assert.That(PKEY_Contact_EmailAddress2.fmtid, Is.EqualTo(new Guid(0x38965063, 0xEDC8, 0x4268, 0x84, 0x91, 0xB7, 0x72, 0x31, 0x72, 0xCF, 0x29)));
        Assert.That(PKEY_Contact_EmailAddress2.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_EmailAddress3"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_EmailAddress3Test()
    {
        Assert.That(PKEY_Contact_EmailAddress3.fmtid, Is.EqualTo(new Guid(0x644D37B4, 0xE1B3, 0x4BAD, 0xB0, 0x99, 0x7E, 0x7C, 0x04, 0x96, 0x6A, 0xCA)));
        Assert.That(PKEY_Contact_EmailAddress3.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_EmailAddresses"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_EmailAddressesTest()
    {
        Assert.That(PKEY_Contact_EmailAddresses.fmtid, Is.EqualTo(new Guid(0x84D8F337, 0x981D, 0x44B3, 0x96, 0x15, 0xC7, 0x59, 0x6D, 0xBA, 0x17, 0xE3)));
        Assert.That(PKEY_Contact_EmailAddresses.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_EmailName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_EmailNameTest()
    {
        Assert.That(PKEY_Contact_EmailName.fmtid, Is.EqualTo(new Guid(0xCC6F4F24, 0x6083, 0x4BD4, 0x87, 0x54, 0x67, 0x4D, 0x0D, 0xE8, 0x7A, 0xB8)));
        Assert.That(PKEY_Contact_EmailName.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_FileAsName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_FileAsNameTest()
    {
        Assert.That(PKEY_Contact_FileAsName.fmtid, Is.EqualTo(new Guid(0xF1A24AA7, 0x9CA7, 0x40F6, 0x89, 0xEC, 0x97, 0xDE, 0xF9, 0xFF, 0xE8, 0xDB)));
        Assert.That(PKEY_Contact_FileAsName.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_FirstName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_FirstNameTest()
    {
        Assert.That(PKEY_Contact_FirstName.fmtid, Is.EqualTo(new Guid(0x14977844, 0x6B49, 0x4AAD, 0xA7, 0x14, 0xA4, 0x51, 0x3B, 0xF6, 0x04, 0x60)));
        Assert.That(PKEY_Contact_FirstName.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_FullName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_FullNameTest()
    {
        Assert.That(PKEY_Contact_FullName.fmtid, Is.EqualTo(new Guid(0x635E9051, 0x50A5, 0x4BA2, 0xB9, 0xDB, 0x4E, 0xD0, 0x56, 0xC7, 0x72, 0x96)));
        Assert.That(PKEY_Contact_FullName.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_Gender"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_GenderTest()
    {
        Assert.That(PKEY_Contact_Gender.fmtid, Is.EqualTo(new Guid(0x3C8CEE58, 0xD4F0, 0x4CF9, 0xB7, 0x56, 0x4E, 0x5D, 0x24, 0x44, 0x7B, 0xCD)));
        Assert.That(PKEY_Contact_Gender.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_GenderValue"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_GenderValueTest()
    {
        Assert.That(PKEY_Contact_GenderValue.fmtid, Is.EqualTo(new Guid(0x3C8CEE58, 0xD4F0, 0x4CF9, 0xB7, 0x56, 0x4E, 0x5D, 0x24, 0x44, 0x7B, 0xCD)));
        Assert.That(PKEY_Contact_GenderValue.pid, Is.EqualTo(101));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_Hobbies"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_HobbiesTest()
    {
        Assert.That(PKEY_Contact_Hobbies.fmtid, Is.EqualTo(new Guid(0x5DC2253F, 0x5E11, 0x4ADF, 0x9C, 0xFE, 0x91, 0x0D, 0xD0, 0x1E, 0x3E, 0x70)));
        Assert.That(PKEY_Contact_Hobbies.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_HomeAddress"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_HomeAddressTest()
    {
        Assert.That(PKEY_Contact_HomeAddress.fmtid, Is.EqualTo(new Guid(0x98F98354, 0x617A, 0x46B8, 0x85, 0x60, 0x5B, 0x1B, 0x64, 0xBF, 0x1F, 0x89)));
        Assert.That(PKEY_Contact_HomeAddress.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_HomeAddress1Country"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_HomeAddress1CountryTest()
    {
        Assert.That(PKEY_Contact_HomeAddress1Country.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_HomeAddress1Country.pid, Is.EqualTo(104));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_HomeAddress1Locality"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_HomeAddress1LocalityTest()
    {
        Assert.That(PKEY_Contact_HomeAddress1Locality.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_HomeAddress1Locality.pid, Is.EqualTo(102));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_HomeAddress1PostalCode"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_HomeAddress1PostalCodeTest()
    {
        Assert.That(PKEY_Contact_HomeAddress1PostalCode.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_HomeAddress1PostalCode.pid, Is.EqualTo(105));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_HomeAddress1Region"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_HomeAddress1RegionTest()
    {
        Assert.That(PKEY_Contact_HomeAddress1Region.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_HomeAddress1Region.pid, Is.EqualTo(103));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_HomeAddress1Street"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_HomeAddress1StreetTest()
    {
        Assert.That(PKEY_Contact_HomeAddress1Street.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_HomeAddress1Street.pid, Is.EqualTo(101));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_HomeAddress2Country"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_HomeAddress2CountryTest()
    {
        Assert.That(PKEY_Contact_HomeAddress2Country.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_HomeAddress2Country.pid, Is.EqualTo(109));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_HomeAddress2Locality"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_HomeAddress2LocalityTest()
    {
        Assert.That(PKEY_Contact_HomeAddress2Locality.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_HomeAddress2Locality.pid, Is.EqualTo(107));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_HomeAddress2PostalCode"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_HomeAddress2PostalCodeTest()
    {
        Assert.That(PKEY_Contact_HomeAddress2PostalCode.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_HomeAddress2PostalCode.pid, Is.EqualTo(110));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_HomeAddress2Region"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_HomeAddress2RegionTest()
    {
        Assert.That(PKEY_Contact_HomeAddress2Region.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_HomeAddress2Region.pid, Is.EqualTo(108));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_HomeAddress2Street"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_HomeAddress2StreetTest()
    {
        Assert.That(PKEY_Contact_HomeAddress2Street.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_HomeAddress2Street.pid, Is.EqualTo(106));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_HomeAddress3Country"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_HomeAddress3CountryTest()
    {
        Assert.That(PKEY_Contact_HomeAddress3Country.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_HomeAddress3Country.pid, Is.EqualTo(114));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_HomeAddress3Locality"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_HomeAddress3LocalityTest()
    {
        Assert.That(PKEY_Contact_HomeAddress3Locality.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_HomeAddress3Locality.pid, Is.EqualTo(112));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_HomeAddress3PostalCode"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_HomeAddress3PostalCodeTest()
    {
        Assert.That(PKEY_Contact_HomeAddress3PostalCode.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_HomeAddress3PostalCode.pid, Is.EqualTo(115));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_HomeAddress3Region"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_HomeAddress3RegionTest()
    {
        Assert.That(PKEY_Contact_HomeAddress3Region.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_HomeAddress3Region.pid, Is.EqualTo(113));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_HomeAddress3Street"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_HomeAddress3StreetTest()
    {
        Assert.That(PKEY_Contact_HomeAddress3Street.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_HomeAddress3Street.pid, Is.EqualTo(111));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_HomeAddressCity"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_HomeAddressCityTest()
    {
        Assert.That(PKEY_Contact_HomeAddressCity.fmtid, Is.EqualTo(new Guid(0x176DC63C, 0x2688, 0x4E89, 0x81, 0x43, 0xA3, 0x47, 0x80, 0x0F, 0x25, 0xE9)));
        Assert.That(PKEY_Contact_HomeAddressCity.pid, Is.EqualTo(65));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_HomeAddressCountry"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_HomeAddressCountryTest()
    {
        Assert.That(PKEY_Contact_HomeAddressCountry.fmtid, Is.EqualTo(new Guid(0x08A65AA1, 0xF4C9, 0x43DD, 0x9D, 0xDF, 0xA3, 0x3D, 0x8E, 0x7E, 0xAD, 0x85)));
        Assert.That(PKEY_Contact_HomeAddressCountry.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_HomeAddressPostalCode"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_HomeAddressPostalCodeTest()
    {
        Assert.That(PKEY_Contact_HomeAddressPostalCode.fmtid, Is.EqualTo(new Guid(0x8AFCC170, 0x8A46, 0x4B53, 0x9E, 0xEE, 0x90, 0xBA, 0xE7, 0x15, 0x1E, 0x62)));
        Assert.That(PKEY_Contact_HomeAddressPostalCode.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_HomeAddressPostOfficeBox"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_HomeAddressPostOfficeBoxTest()
    {
        Assert.That(PKEY_Contact_HomeAddressPostOfficeBox.fmtid, Is.EqualTo(new Guid(0x7B9F6399, 0x0A3F, 0x4B12, 0x89, 0xBD, 0x4A, 0xDC, 0x51, 0xC9, 0x18, 0xAF)));
        Assert.That(PKEY_Contact_HomeAddressPostOfficeBox.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_HomeAddressState"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_HomeAddressStateTest()
    {
        Assert.That(PKEY_Contact_HomeAddressState.fmtid, Is.EqualTo(new Guid(0xC89A23D0, 0x7D6D, 0x4EB8, 0x87, 0xD4, 0x77, 0x6A, 0x82, 0xD4, 0x93, 0xE5)));
        Assert.That(PKEY_Contact_HomeAddressState.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_HomeAddressStreet"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_HomeAddressStreetTest()
    {
        Assert.That(PKEY_Contact_HomeAddressStreet.fmtid, Is.EqualTo(new Guid(0x0ADEF160, 0xDB3F, 0x4308, 0x9A, 0x21, 0x06, 0x23, 0x7B, 0x16, 0xFA, 0x2A)));
        Assert.That(PKEY_Contact_HomeAddressStreet.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_HomeEmailAddresses"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_HomeEmailAddressesTest()
    {
        Assert.That(PKEY_Contact_HomeEmailAddresses.fmtid, Is.EqualTo(new Guid(0x56C90E9D, 0x9D46, 0x4963, 0x88, 0x6F, 0x2E, 0x1C, 0xD9, 0xA6, 0x94, 0xEF)));
        Assert.That(PKEY_Contact_HomeEmailAddresses.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_HomeFaxNumber"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_HomeFaxNumberTest()
    {
        Assert.That(PKEY_Contact_HomeFaxNumber.fmtid, Is.EqualTo(new Guid(0x660E04D6, 0x81AB, 0x4977, 0xA0, 0x9F, 0x82, 0x31, 0x31, 0x13, 0xAB, 0x26)));
        Assert.That(PKEY_Contact_HomeFaxNumber.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_HomeTelephone"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_HomeTelephoneTest()
    {
        Assert.That(PKEY_Contact_HomeTelephone.fmtid, Is.EqualTo(new Guid(0x176DC63C, 0x2688, 0x4E89, 0x81, 0x43, 0xA3, 0x47, 0x80, 0x0F, 0x25, 0xE9)));
        Assert.That(PKEY_Contact_HomeTelephone.pid, Is.EqualTo(20));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_IMAddress"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_IMAddressTest()
    {
        Assert.That(PKEY_Contact_IMAddress.fmtid, Is.EqualTo(new Guid(0xD68DBD8A, 0x3374, 0x4B81, 0x99, 0x72, 0x3E, 0xC3, 0x06, 0x82, 0xDB, 0x3D)));
        Assert.That(PKEY_Contact_IMAddress.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_Initials"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_InitialsTest()
    {
        Assert.That(PKEY_Contact_Initials.fmtid, Is.EqualTo(new Guid(0xF3D8F40D, 0x50CB, 0x44A2, 0x97, 0x18, 0x40, 0xCB, 0x91, 0x19, 0x49, 0x5D)));
        Assert.That(PKEY_Contact_Initials.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_JA_CompanyNamePhonetic"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_JA_CompanyNamePhoneticTest()
    {
        Assert.That(PKEY_Contact_JA_CompanyNamePhonetic.fmtid, Is.EqualTo(new Guid(0x897B3694, 0xFE9E, 0x43E6, 0x80, 0x66, 0x26, 0x0F, 0x59, 0x0C, 0x01, 0x00)));
        Assert.That(PKEY_Contact_JA_CompanyNamePhonetic.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_JA_FirstNamePhonetic"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_JA_FirstNamePhoneticTest()
    {
        Assert.That(PKEY_Contact_JA_FirstNamePhonetic.fmtid, Is.EqualTo(new Guid(0x897B3694, 0xFE9E, 0x43E6, 0x80, 0x66, 0x26, 0x0F, 0x59, 0x0C, 0x01, 0x00)));
        Assert.That(PKEY_Contact_JA_FirstNamePhonetic.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_JA_LastNamePhonetic"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_JA_LastNamePhoneticTest()
    {
        Assert.That(PKEY_Contact_JA_LastNamePhonetic.fmtid, Is.EqualTo(new Guid(0x897B3694, 0xFE9E, 0x43E6, 0x80, 0x66, 0x26, 0x0F, 0x59, 0x0C, 0x01, 0x00)));
        Assert.That(PKEY_Contact_JA_LastNamePhonetic.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_JobInfo1CompanyAddress"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_JobInfo1CompanyAddressTest()
    {
        Assert.That(PKEY_Contact_JobInfo1CompanyAddress.fmtid, Is.EqualTo(new Guid(0x00F63DD8, 0x22BD, 0x4A5D, 0xBA, 0x34, 0x5C, 0xB0, 0xB9, 0xBD, 0xCB, 0x03)));
        Assert.That(PKEY_Contact_JobInfo1CompanyAddress.pid, Is.EqualTo(120));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_JobInfo1CompanyName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_JobInfo1CompanyNameTest()
    {
        Assert.That(PKEY_Contact_JobInfo1CompanyName.fmtid, Is.EqualTo(new Guid(0x00F63DD8, 0x22BD, 0x4A5D, 0xBA, 0x34, 0x5C, 0xB0, 0xB9, 0xBD, 0xCB, 0x03)));
        Assert.That(PKEY_Contact_JobInfo1CompanyName.pid, Is.EqualTo(102));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_JobInfo1Department"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_JobInfo1DepartmentTest()
    {
        Assert.That(PKEY_Contact_JobInfo1Department.fmtid, Is.EqualTo(new Guid(0x00F63DD8, 0x22BD, 0x4A5D, 0xBA, 0x34, 0x5C, 0xB0, 0xB9, 0xBD, 0xCB, 0x03)));
        Assert.That(PKEY_Contact_JobInfo1Department.pid, Is.EqualTo(106));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_JobInfo1Manager"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_JobInfo1ManagerTest()
    {
        Assert.That(PKEY_Contact_JobInfo1Manager.fmtid, Is.EqualTo(new Guid(0x00F63DD8, 0x22BD, 0x4A5D, 0xBA, 0x34, 0x5C, 0xB0, 0xB9, 0xBD, 0xCB, 0x03)));
        Assert.That(PKEY_Contact_JobInfo1Manager.pid, Is.EqualTo(105));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_JobInfo1OfficeLocation"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_JobInfo1OfficeLocationTest()
    {
        Assert.That(PKEY_Contact_JobInfo1OfficeLocation.fmtid, Is.EqualTo(new Guid(0x00F63DD8, 0x22BD, 0x4A5D, 0xBA, 0x34, 0x5C, 0xB0, 0xB9, 0xBD, 0xCB, 0x03)));
        Assert.That(PKEY_Contact_JobInfo1OfficeLocation.pid, Is.EqualTo(104));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_JobInfo1Title"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_JobInfo1TitleTest()
    {
        Assert.That(PKEY_Contact_JobInfo1Title.fmtid, Is.EqualTo(new Guid(0x00F63DD8, 0x22BD, 0x4A5D, 0xBA, 0x34, 0x5C, 0xB0, 0xB9, 0xBD, 0xCB, 0x03)));
        Assert.That(PKEY_Contact_JobInfo1Title.pid, Is.EqualTo(103));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_JobInfo1YomiCompanyName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_JobInfo1YomiCompanyNameTest()
    {
        Assert.That(PKEY_Contact_JobInfo1YomiCompanyName.fmtid, Is.EqualTo(new Guid(0x00F63DD8, 0x22BD, 0x4A5D, 0xBA, 0x34, 0x5C, 0xB0, 0xB9, 0xBD, 0xCB, 0x03)));
        Assert.That(PKEY_Contact_JobInfo1YomiCompanyName.pid, Is.EqualTo(101));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_JobInfo2CompanyAddress"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_JobInfo2CompanyAddressTest()
    {
        Assert.That(PKEY_Contact_JobInfo2CompanyAddress.fmtid, Is.EqualTo(new Guid(0x00F63DD8, 0x22BD, 0x4A5D, 0xBA, 0x34, 0x5C, 0xB0, 0xB9, 0xBD, 0xCB, 0x03)));
        Assert.That(PKEY_Contact_JobInfo2CompanyAddress.pid, Is.EqualTo(121));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_JobInfo2CompanyName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_JobInfo2CompanyNameTest()
    {
        Assert.That(PKEY_Contact_JobInfo2CompanyName.fmtid, Is.EqualTo(new Guid(0x00F63DD8, 0x22BD, 0x4A5D, 0xBA, 0x34, 0x5C, 0xB0, 0xB9, 0xBD, 0xCB, 0x03)));
        Assert.That(PKEY_Contact_JobInfo2CompanyName.pid, Is.EqualTo(108));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_JobInfo2Department"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_JobInfo2DepartmentTest()
    {
        Assert.That(PKEY_Contact_JobInfo2Department.fmtid, Is.EqualTo(new Guid(0x00F63DD8, 0x22BD, 0x4A5D, 0xBA, 0x34, 0x5C, 0xB0, 0xB9, 0xBD, 0xCB, 0x03)));
        Assert.That(PKEY_Contact_JobInfo2Department.pid, Is.EqualTo(113));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_JobInfo2Manager"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_JobInfo2ManagerTest()
    {
        Assert.That(PKEY_Contact_JobInfo2Manager.fmtid, Is.EqualTo(new Guid(0x00F63DD8, 0x22BD, 0x4A5D, 0xBA, 0x34, 0x5C, 0xB0, 0xB9, 0xBD, 0xCB, 0x03)));
        Assert.That(PKEY_Contact_JobInfo2Manager.pid, Is.EqualTo(112));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_JobInfo2OfficeLocation"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_JobInfo2OfficeLocationTest()
    {
        Assert.That(PKEY_Contact_JobInfo2OfficeLocation.fmtid, Is.EqualTo(new Guid(0x00F63DD8, 0x22BD, 0x4A5D, 0xBA, 0x34, 0x5C, 0xB0, 0xB9, 0xBD, 0xCB, 0x03)));
        Assert.That(PKEY_Contact_JobInfo2OfficeLocation.pid, Is.EqualTo(110));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_JobInfo2Title"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_JobInfo2TitleTest()
    {
        Assert.That(PKEY_Contact_JobInfo2Title.fmtid, Is.EqualTo(new Guid(0x00F63DD8, 0x22BD, 0x4A5D, 0xBA, 0x34, 0x5C, 0xB0, 0xB9, 0xBD, 0xCB, 0x03)));
        Assert.That(PKEY_Contact_JobInfo2Title.pid, Is.EqualTo(109));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_JobInfo2YomiCompanyName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_JobInfo2YomiCompanyNameTest()
    {
        Assert.That(PKEY_Contact_JobInfo2YomiCompanyName.fmtid, Is.EqualTo(new Guid(0x00F63DD8, 0x22BD, 0x4A5D, 0xBA, 0x34, 0x5C, 0xB0, 0xB9, 0xBD, 0xCB, 0x03)));
        Assert.That(PKEY_Contact_JobInfo2YomiCompanyName.pid, Is.EqualTo(107));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_JobInfo3CompanyAddress"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_JobInfo3CompanyAddressTest()
    {
        Assert.That(PKEY_Contact_JobInfo3CompanyAddress.fmtid, Is.EqualTo(new Guid(0x00F63DD8, 0x22BD, 0x4A5D, 0xBA, 0x34, 0x5C, 0xB0, 0xB9, 0xBD, 0xCB, 0x03)));
        Assert.That(PKEY_Contact_JobInfo3CompanyAddress.pid, Is.EqualTo(123));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_JobInfo3CompanyName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_JobInfo3CompanyNameTest()
    {
        Assert.That(PKEY_Contact_JobInfo3CompanyName.fmtid, Is.EqualTo(new Guid(0x00F63DD8, 0x22BD, 0x4A5D, 0xBA, 0x34, 0x5C, 0xB0, 0xB9, 0xBD, 0xCB, 0x03)));
        Assert.That(PKEY_Contact_JobInfo3CompanyName.pid, Is.EqualTo(115));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_JobInfo3Department"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_JobInfo3DepartmentTest()
    {
        Assert.That(PKEY_Contact_JobInfo3Department.fmtid, Is.EqualTo(new Guid(0x00F63DD8, 0x22BD, 0x4A5D, 0xBA, 0x34, 0x5C, 0xB0, 0xB9, 0xBD, 0xCB, 0x03)));
        Assert.That(PKEY_Contact_JobInfo3Department.pid, Is.EqualTo(119));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_JobInfo3Manager"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_JobInfo3ManagerTest()
    {
        Assert.That(PKEY_Contact_JobInfo3Manager.fmtid, Is.EqualTo(new Guid(0x00F63DD8, 0x22BD, 0x4A5D, 0xBA, 0x34, 0x5C, 0xB0, 0xB9, 0xBD, 0xCB, 0x03)));
        Assert.That(PKEY_Contact_JobInfo3Manager.pid, Is.EqualTo(118));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_JobInfo3OfficeLocation"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_JobInfo3OfficeLocationTest()
    {
        Assert.That(PKEY_Contact_JobInfo3OfficeLocation.fmtid, Is.EqualTo(new Guid(0x00F63DD8, 0x22BD, 0x4A5D, 0xBA, 0x34, 0x5C, 0xB0, 0xB9, 0xBD, 0xCB, 0x03)));
        Assert.That(PKEY_Contact_JobInfo3OfficeLocation.pid, Is.EqualTo(117));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_JobInfo3Title"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_JobInfo3TitleTest()
    {
        Assert.That(PKEY_Contact_JobInfo3Title.fmtid, Is.EqualTo(new Guid(0x00F63DD8, 0x22BD, 0x4A5D, 0xBA, 0x34, 0x5C, 0xB0, 0xB9, 0xBD, 0xCB, 0x03)));
        Assert.That(PKEY_Contact_JobInfo3Title.pid, Is.EqualTo(116));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_JobInfo3YomiCompanyName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_JobInfo3YomiCompanyNameTest()
    {
        Assert.That(PKEY_Contact_JobInfo3YomiCompanyName.fmtid, Is.EqualTo(new Guid(0x00F63DD8, 0x22BD, 0x4A5D, 0xBA, 0x34, 0x5C, 0xB0, 0xB9, 0xBD, 0xCB, 0x03)));
        Assert.That(PKEY_Contact_JobInfo3YomiCompanyName.pid, Is.EqualTo(114));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_JobTitle"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_JobTitleTest()
    {
        Assert.That(PKEY_Contact_JobTitle.fmtid, Is.EqualTo(new Guid(0x176DC63C, 0x2688, 0x4E89, 0x81, 0x43, 0xA3, 0x47, 0x80, 0x0F, 0x25, 0xE9)));
        Assert.That(PKEY_Contact_JobTitle.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_Label"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_LabelTest()
    {
        Assert.That(PKEY_Contact_Label.fmtid, Is.EqualTo(new Guid(0x97B0AD89, 0xDF49, 0x49CC, 0x83, 0x4E, 0x66, 0x09, 0x74, 0xFD, 0x75, 0x5B)));
        Assert.That(PKEY_Contact_Label.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_LastName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_LastNameTest()
    {
        Assert.That(PKEY_Contact_LastName.fmtid, Is.EqualTo(new Guid(0x8F367200, 0xC270, 0x457C, 0xB1, 0xD4, 0xE0, 0x7C, 0x5B, 0xCD, 0x90, 0xC7)));
        Assert.That(PKEY_Contact_LastName.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_MailingAddress"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_MailingAddressTest()
    {
        Assert.That(PKEY_Contact_MailingAddress.fmtid, Is.EqualTo(new Guid(0xC0AC206A, 0x827E, 0x4650, 0x95, 0xAE, 0x77, 0xE2, 0xBB, 0x74, 0xFC, 0xC9)));
        Assert.That(PKEY_Contact_MailingAddress.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_MiddleName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_MiddleNameTest()
    {
        Assert.That(PKEY_Contact_MiddleName.fmtid, Is.EqualTo(new Guid(0x176DC63C, 0x2688, 0x4E89, 0x81, 0x43, 0xA3, 0x47, 0x80, 0x0F, 0x25, 0xE9)));
        Assert.That(PKEY_Contact_MiddleName.pid, Is.EqualTo(71));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_MobileTelephone"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_MobileTelephoneTest()
    {
        Assert.That(PKEY_Contact_MobileTelephone.fmtid, Is.EqualTo(new Guid(0x176DC63C, 0x2688, 0x4E89, 0x81, 0x43, 0xA3, 0x47, 0x80, 0x0F, 0x25, 0xE9)));
        Assert.That(PKEY_Contact_MobileTelephone.pid, Is.EqualTo(35));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_NickName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_NickNameTest()
    {
        Assert.That(PKEY_Contact_NickName.fmtid, Is.EqualTo(new Guid(0x176DC63C, 0x2688, 0x4E89, 0x81, 0x43, 0xA3, 0x47, 0x80, 0x0F, 0x25, 0xE9)));
        Assert.That(PKEY_Contact_NickName.pid, Is.EqualTo(74));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_OfficeLocation"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_OfficeLocationTest()
    {
        Assert.That(PKEY_Contact_OfficeLocation.fmtid, Is.EqualTo(new Guid(0x176DC63C, 0x2688, 0x4E89, 0x81, 0x43, 0xA3, 0x47, 0x80, 0x0F, 0x25, 0xE9)));
        Assert.That(PKEY_Contact_OfficeLocation.pid, Is.EqualTo(7));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_OtherAddress"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_OtherAddressTest()
    {
        Assert.That(PKEY_Contact_OtherAddress.fmtid, Is.EqualTo(new Guid(0x508161FA, 0x313B, 0x43D5, 0x83, 0xA1, 0xC1, 0xAC, 0xCF, 0x68, 0x62, 0x2C)));
        Assert.That(PKEY_Contact_OtherAddress.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_OtherAddress1Country"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_OtherAddress1CountryTest()
    {
        Assert.That(PKEY_Contact_OtherAddress1Country.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_OtherAddress1Country.pid, Is.EqualTo(134));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_OtherAddress1Locality"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_OtherAddress1LocalityTest()
    {
        Assert.That(PKEY_Contact_OtherAddress1Locality.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_OtherAddress1Locality.pid, Is.EqualTo(132));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_OtherAddress1PostalCode"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_OtherAddress1PostalCodeTest()
    {
        Assert.That(PKEY_Contact_OtherAddress1PostalCode.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_OtherAddress1PostalCode.pid, Is.EqualTo(135));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_OtherAddress1Region"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_OtherAddress1RegionTest()
    {
        Assert.That(PKEY_Contact_OtherAddress1Region.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_OtherAddress1Region.pid, Is.EqualTo(133));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_OtherAddress1Street"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_OtherAddress1StreetTest()
    {
        Assert.That(PKEY_Contact_OtherAddress1Street.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_OtherAddress1Street.pid, Is.EqualTo(131));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_OtherAddress2Country"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_OtherAddress2CountryTest()
    {
        Assert.That(PKEY_Contact_OtherAddress2Country.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_OtherAddress2Country.pid, Is.EqualTo(139));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_OtherAddress2Locality"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_OtherAddress2LocalityTest()
    {
        Assert.That(PKEY_Contact_OtherAddress2Locality.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_OtherAddress2Locality.pid, Is.EqualTo(137));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_OtherAddress2PostalCode"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_OtherAddress2PostalCodeTest()
    {
        Assert.That(PKEY_Contact_OtherAddress2PostalCode.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_OtherAddress2PostalCode.pid, Is.EqualTo(140));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_OtherAddress2Region"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_OtherAddress2RegionTest()
    {
        Assert.That(PKEY_Contact_OtherAddress2Region.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_OtherAddress2Region.pid, Is.EqualTo(138));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_OtherAddress2Street"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_OtherAddress2StreetTest()
    {
        Assert.That(PKEY_Contact_OtherAddress2Street.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_OtherAddress2Street.pid, Is.EqualTo(136));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_OtherAddress3Country"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_OtherAddress3CountryTest()
    {
        Assert.That(PKEY_Contact_OtherAddress3Country.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_OtherAddress3Country.pid, Is.EqualTo(144));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_OtherAddress3Locality"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_OtherAddress3LocalityTest()
    {
        Assert.That(PKEY_Contact_OtherAddress3Locality.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_OtherAddress3Locality.pid, Is.EqualTo(142));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_OtherAddress3PostalCode"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_OtherAddress3PostalCodeTest()
    {
        Assert.That(PKEY_Contact_OtherAddress3PostalCode.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_OtherAddress3PostalCode.pid, Is.EqualTo(145));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_OtherAddress3Region"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_OtherAddress3RegionTest()
    {
        Assert.That(PKEY_Contact_OtherAddress3Region.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_OtherAddress3Region.pid, Is.EqualTo(143));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_OtherAddress3Street"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_OtherAddress3StreetTest()
    {
        Assert.That(PKEY_Contact_OtherAddress3Street.fmtid, Is.EqualTo(new Guid(0xA7B6F596, 0xD678, 0x4BC1, 0xB0, 0x5F, 0x02, 0x03, 0xD2, 0x7E, 0x8A, 0xA1)));
        Assert.That(PKEY_Contact_OtherAddress3Street.pid, Is.EqualTo(141));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_OtherAddressCity"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_OtherAddressCityTest()
    {
        Assert.That(PKEY_Contact_OtherAddressCity.fmtid, Is.EqualTo(new Guid(0x6E682923, 0x7F7B, 0x4F0C, 0xA3, 0x37, 0xCF, 0xCA, 0x29, 0x66, 0x87, 0xBF)));
        Assert.That(PKEY_Contact_OtherAddressCity.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_OtherAddressCountry"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_OtherAddressCountryTest()
    {
        Assert.That(PKEY_Contact_OtherAddressCountry.fmtid, Is.EqualTo(new Guid(0x8F167568, 0x0AAE, 0x4322, 0x8E, 0xD9, 0x60, 0x55, 0xB7, 0xB0, 0xE3, 0x98)));
        Assert.That(PKEY_Contact_OtherAddressCountry.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_OtherAddressPostalCode"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_OtherAddressPostalCodeTest()
    {
        Assert.That(PKEY_Contact_OtherAddressPostalCode.fmtid, Is.EqualTo(new Guid(0x95C656C1, 0x2ABF, 0x4148, 0x9E, 0xD3, 0x9E, 0xC6, 0x02, 0xE3, 0xB7, 0xCD)));
        Assert.That(PKEY_Contact_OtherAddressPostalCode.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_OtherAddressPostOfficeBox"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_OtherAddressPostOfficeBoxTest()
    {
        Assert.That(PKEY_Contact_OtherAddressPostOfficeBox.fmtid, Is.EqualTo(new Guid(0x8B26EA41, 0x058F, 0x43F6, 0xAE, 0xCC, 0x40, 0x35, 0x68, 0x1C, 0xE9, 0x77)));
        Assert.That(PKEY_Contact_OtherAddressPostOfficeBox.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_OtherAddressState"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_OtherAddressStateTest()
    {
        Assert.That(PKEY_Contact_OtherAddressState.fmtid, Is.EqualTo(new Guid(0x71B377D6, 0xE570, 0x425F, 0xA1, 0x70, 0x80, 0x9F, 0xAE, 0x73, 0xE5, 0x4E)));
        Assert.That(PKEY_Contact_OtherAddressState.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_OtherAddressStreet"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_OtherAddressStreetTest()
    {
        Assert.That(PKEY_Contact_OtherAddressStreet.fmtid, Is.EqualTo(new Guid(0xFF962609, 0xB7D6, 0x4999, 0x86, 0x2D, 0x95, 0x18, 0x0D, 0x52, 0x9A, 0xEA)));
        Assert.That(PKEY_Contact_OtherAddressStreet.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_OtherEmailAddresses"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_OtherEmailAddressesTest()
    {
        Assert.That(PKEY_Contact_OtherEmailAddresses.fmtid, Is.EqualTo(new Guid(0x11D6336B, 0x38C4, 0x4EC9, 0x84, 0xD6, 0xEB, 0x38, 0xD0, 0xB1, 0x50, 0xAF)));
        Assert.That(PKEY_Contact_OtherEmailAddresses.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_PagerTelephone"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_PagerTelephoneTest()
    {
        Assert.That(PKEY_Contact_PagerTelephone.fmtid, Is.EqualTo(new Guid(0xD6304E01, 0xF8F5, 0x4F45, 0x8B, 0x15, 0xD0, 0x24, 0xA6, 0x29, 0x67, 0x89)));
        Assert.That(PKEY_Contact_PagerTelephone.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_PersonalTitle"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_PersonalTitleTest()
    {
        Assert.That(PKEY_Contact_PersonalTitle.fmtid, Is.EqualTo(new Guid(0x176DC63C, 0x2688, 0x4E89, 0x81, 0x43, 0xA3, 0x47, 0x80, 0x0F, 0x25, 0xE9)));
        Assert.That(PKEY_Contact_PersonalTitle.pid, Is.EqualTo(69));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_PhoneNumbersCanonical"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_PhoneNumbersCanonicalTest()
    {
        Assert.That(PKEY_Contact_PhoneNumbersCanonical.fmtid, Is.EqualTo(new Guid(0xD042D2A1, 0x927E, 0x40B5, 0xA5, 0x03, 0x6E, 0xDB, 0xD4, 0x2A, 0x51, 0x7E)));
        Assert.That(PKEY_Contact_PhoneNumbersCanonical.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_Prefix"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_PrefixTest()
    {
        Assert.That(PKEY_Contact_Prefix.fmtid, Is.EqualTo(new Guid(0x176DC63C, 0x2688, 0x4E89, 0x81, 0x43, 0xA3, 0x47, 0x80, 0x0F, 0x25, 0xE9)));
        Assert.That(PKEY_Contact_Prefix.pid, Is.EqualTo(75));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_PrimaryAddressCity"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_PrimaryAddressCityTest()
    {
        Assert.That(PKEY_Contact_PrimaryAddressCity.fmtid, Is.EqualTo(new Guid(0xC8EA94F0, 0xA9E3, 0x4969, 0xA9, 0x4B, 0x9C, 0x62, 0xA9, 0x53, 0x24, 0xE0)));
        Assert.That(PKEY_Contact_PrimaryAddressCity.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_PrimaryAddressCountry"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_PrimaryAddressCountryTest()
    {
        Assert.That(PKEY_Contact_PrimaryAddressCountry.fmtid, Is.EqualTo(new Guid(0xE53D799D, 0x0F3F, 0x466E, 0xB2, 0xFF, 0x74, 0x63, 0x4A, 0x3C, 0xB7, 0xA4)));
        Assert.That(PKEY_Contact_PrimaryAddressCountry.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_PrimaryAddressPostalCode"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_PrimaryAddressPostalCodeTest()
    {
        Assert.That(PKEY_Contact_PrimaryAddressPostalCode.fmtid, Is.EqualTo(new Guid(0x18BBD425, 0xECFD, 0x46EF, 0xB6, 0x12, 0x7B, 0x4A, 0x60, 0x34, 0xED, 0xA0)));
        Assert.That(PKEY_Contact_PrimaryAddressPostalCode.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_PrimaryAddressPostOfficeBox"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_PrimaryAddressPostOfficeBoxTest()
    {
        Assert.That(PKEY_Contact_PrimaryAddressPostOfficeBox.fmtid, Is.EqualTo(new Guid(0xDE5EF3C7, 0x46E1, 0x484E, 0x99, 0x99, 0x62, 0xC5, 0x30, 0x83, 0x94, 0xC1)));
        Assert.That(PKEY_Contact_PrimaryAddressPostOfficeBox.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_PrimaryAddressState"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_PrimaryAddressStateTest()
    {
        Assert.That(PKEY_Contact_PrimaryAddressState.fmtid, Is.EqualTo(new Guid(0xF1176DFE, 0x7138, 0x4640, 0x8B, 0x4C, 0xAE, 0x37, 0x5D, 0xC7, 0x0A, 0x6D)));
        Assert.That(PKEY_Contact_PrimaryAddressState.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_PrimaryAddressStreet"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_PrimaryAddressStreetTest()
    {
        Assert.That(PKEY_Contact_PrimaryAddressStreet.fmtid, Is.EqualTo(new Guid(0x63C25B20, 0x96BE, 0x488F, 0x87, 0x88, 0xC0, 0x9C, 0x40, 0x7A, 0xD8, 0x12)));
        Assert.That(PKEY_Contact_PrimaryAddressStreet.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_PrimaryEmailAddress"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_PrimaryEmailAddressTest()
    {
        Assert.That(PKEY_Contact_PrimaryEmailAddress.fmtid, Is.EqualTo(new Guid(0x176DC63C, 0x2688, 0x4E89, 0x81, 0x43, 0xA3, 0x47, 0x80, 0x0F, 0x25, 0xE9)));
        Assert.That(PKEY_Contact_PrimaryEmailAddress.pid, Is.EqualTo(48));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_PrimaryTelephone"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_PrimaryTelephoneTest()
    {
        Assert.That(PKEY_Contact_PrimaryTelephone.fmtid, Is.EqualTo(new Guid(0x176DC63C, 0x2688, 0x4E89, 0x81, 0x43, 0xA3, 0x47, 0x80, 0x0F, 0x25, 0xE9)));
        Assert.That(PKEY_Contact_PrimaryTelephone.pid, Is.EqualTo(25));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_Profession"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_ProfessionTest()
    {
        Assert.That(PKEY_Contact_Profession.fmtid, Is.EqualTo(new Guid(0x7268AF55, 0x1CE4, 0x4F6E, 0xA4, 0x1F, 0xB6, 0xE4, 0xEF, 0x10, 0xE4, 0xA9)));
        Assert.That(PKEY_Contact_Profession.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_SpouseName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_SpouseNameTest()
    {
        Assert.That(PKEY_Contact_SpouseName.fmtid, Is.EqualTo(new Guid(0x9D2408B6, 0x3167, 0x422B, 0x82, 0xB0, 0xF5, 0x83, 0xB7, 0xA7, 0xCF, 0xE3)));
        Assert.That(PKEY_Contact_SpouseName.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_Suffix"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_SuffixTest()
    {
        Assert.That(PKEY_Contact_Suffix.fmtid, Is.EqualTo(new Guid(0x176DC63C, 0x2688, 0x4E89, 0x81, 0x43, 0xA3, 0x47, 0x80, 0x0F, 0x25, 0xE9)));
        Assert.That(PKEY_Contact_Suffix.pid, Is.EqualTo(73));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_TelexNumber"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_TelexNumberTest()
    {
        Assert.That(PKEY_Contact_TelexNumber.fmtid, Is.EqualTo(new Guid(0xC554493C, 0xC1F7, 0x40C1, 0xA7, 0x6C, 0xEF, 0x8C, 0x06, 0x14, 0x00, 0x3E)));
        Assert.That(PKEY_Contact_TelexNumber.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_TTYTDDTelephone"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_TTYTDDTelephoneTest()
    {
        Assert.That(PKEY_Contact_TTYTDDTelephone.fmtid, Is.EqualTo(new Guid(0xAAF16BAC, 0x2B55, 0x45E6, 0x9F, 0x6D, 0x41, 0x5E, 0xB9, 0x49, 0x10, 0xDF)));
        Assert.That(PKEY_Contact_TTYTDDTelephone.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_WebPage"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_WebPageTest()
    {
        Assert.That(PKEY_Contact_WebPage.fmtid, Is.EqualTo(new Guid(0xE3E0584C, 0xB788, 0x4A5A, 0xBB, 0x20, 0x7F, 0x5A, 0x44, 0xC9, 0xAC, 0xDD)));
        Assert.That(PKEY_Contact_WebPage.pid, Is.EqualTo(18));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_Webpage2"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_Webpage2Test()
    {
        Assert.That(PKEY_Contact_Webpage2.fmtid, Is.EqualTo(new Guid(0x00F63DD8, 0x22BD, 0x4A5D, 0xBA, 0x34, 0x5C, 0xB0, 0xB9, 0xBD, 0xCB, 0x03)));
        Assert.That(PKEY_Contact_Webpage2.pid, Is.EqualTo(124));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Contact_Webpage3"/> property is correct.</summary>
    [Test]
    public static void PKEY_Contact_Webpage3Test()
    {
        Assert.That(PKEY_Contact_Webpage3.fmtid, Is.EqualTo(new Guid(0x00F63DD8, 0x22BD, 0x4A5D, 0xBA, 0x34, 0x5C, 0xB0, 0xB9, 0xBD, 0xCB, 0x03)));
        Assert.That(PKEY_Contact_Webpage3.pid, Is.EqualTo(125));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_AcquisitionID"/> property is correct.</summary>
    [Test]
    public static void PKEY_AcquisitionIDTest()
    {
        Assert.That(PKEY_AcquisitionID.fmtid, Is.EqualTo(new Guid(0x65A98875, 0x3C80, 0x40AB, 0xAB, 0xBC, 0xEF, 0xDA, 0xF7, 0x7D, 0xBE, 0xE2)));
        Assert.That(PKEY_AcquisitionID.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ApplicationDefinedProperties"/> property is correct.</summary>
    [Test]
    public static void PKEY_ApplicationDefinedPropertiesTest()
    {
        Assert.That(PKEY_ApplicationDefinedProperties.fmtid, Is.EqualTo(new Guid(0xCDBFC167, 0x337E, 0x41D8, 0xAF, 0x7C, 0x8C, 0x09, 0x20, 0x54, 0x29, 0xC7)));
        Assert.That(PKEY_ApplicationDefinedProperties.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ApplicationName"/> property is correct.</summary>
    [Test]
    public static void PKEY_ApplicationNameTest()
    {
        Assert.That(PKEY_ApplicationName.fmtid, Is.EqualTo(new Guid(0xF29F85E0, 0x4FF9, 0x1068, 0xAB, 0x91, 0x08, 0x00, 0x2B, 0x27, 0xB3, 0xD9)));
        Assert.That(PKEY_ApplicationName.pid, Is.EqualTo(18));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_AppZoneIdentifier"/> property is correct.</summary>
    [Test]
    public static void PKEY_AppZoneIdentifierTest()
    {
        Assert.That(PKEY_AppZoneIdentifier.fmtid, Is.EqualTo(new Guid(0x502CFEAB, 0x47EB, 0x459C, 0xB9, 0x60, 0xE6, 0xD8, 0x72, 0x8F, 0x77, 0x01)));
        Assert.That(PKEY_AppZoneIdentifier.pid, Is.EqualTo(102));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Author"/> property is correct.</summary>
    [Test]
    public static void PKEY_AuthorTest()
    {
        Assert.That(PKEY_Author.fmtid, Is.EqualTo(new Guid(0xF29F85E0, 0x4FF9, 0x1068, 0xAB, 0x91, 0x08, 0x00, 0x2B, 0x27, 0xB3, 0xD9)));
        Assert.That(PKEY_Author.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_CachedFileUpdaterContentIdForConflictResolution"/> property is correct.</summary>
    [Test]
    public static void PKEY_CachedFileUpdaterContentIdForConflictResolutionTest()
    {
        Assert.That(PKEY_CachedFileUpdaterContentIdForConflictResolution.fmtid, Is.EqualTo(new Guid(0xFCEFF153, 0xE839, 0x4CF3, 0xA9, 0xE7, 0xEA, 0x22, 0x83, 0x20, 0x94, 0xB8)));
        Assert.That(PKEY_CachedFileUpdaterContentIdForConflictResolution.pid, Is.EqualTo(114));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_CachedFileUpdaterContentIdForStream"/> property is correct.</summary>
    [Test]
    public static void PKEY_CachedFileUpdaterContentIdForStreamTest()
    {
        Assert.That(PKEY_CachedFileUpdaterContentIdForStream.fmtid, Is.EqualTo(new Guid(0xFCEFF153, 0xE839, 0x4CF3, 0xA9, 0xE7, 0xEA, 0x22, 0x83, 0x20, 0x94, 0xB8)));
        Assert.That(PKEY_CachedFileUpdaterContentIdForStream.pid, Is.EqualTo(113));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Capacity"/> property is correct.</summary>
    [Test]
    public static void PKEY_CapacityTest()
    {
        Assert.That(PKEY_Capacity.fmtid, Is.EqualTo(new Guid(0x9B174B35, 0x40FF, 0x11D2, 0xA2, 0x7E, 0x00, 0xC0, 0x4F, 0xC3, 0x08, 0x71)));
        Assert.That(PKEY_Capacity.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Category"/> property is correct.</summary>
    [Test]
    public static void PKEY_CategoryTest()
    {
        Assert.That(PKEY_Category.fmtid, Is.EqualTo(new Guid(0xD5CDD502, 0x2E9C, 0x101B, 0x93, 0x97, 0x08, 0x00, 0x2B, 0x2C, 0xF9, 0xAE)));
        Assert.That(PKEY_Category.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Comment"/> property is correct.</summary>
    [Test]
    public static void PKEY_CommentTest()
    {
        Assert.That(PKEY_Comment.fmtid, Is.EqualTo(new Guid(0xF29F85E0, 0x4FF9, 0x1068, 0xAB, 0x91, 0x08, 0x00, 0x2B, 0x27, 0xB3, 0xD9)));
        Assert.That(PKEY_Comment.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Company"/> property is correct.</summary>
    [Test]
    public static void PKEY_CompanyTest()
    {
        Assert.That(PKEY_Company.fmtid, Is.EqualTo(new Guid(0xD5CDD502, 0x2E9C, 0x101B, 0x93, 0x97, 0x08, 0x00, 0x2B, 0x2C, 0xF9, 0xAE)));
        Assert.That(PKEY_Company.pid, Is.EqualTo(15));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ComputerName"/> property is correct.</summary>
    [Test]
    public static void PKEY_ComputerNameTest()
    {
        Assert.That(PKEY_ComputerName.fmtid, Is.EqualTo(new Guid(0x28636AA6, 0x953D, 0x11D2, 0xB5, 0xD6, 0x00, 0xC0, 0x4F, 0xD9, 0x18, 0xD0)));
        Assert.That(PKEY_ComputerName.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ContainedItems"/> property is correct.</summary>
    [Test]
    public static void PKEY_ContainedItemsTest()
    {
        Assert.That(PKEY_ContainedItems.fmtid, Is.EqualTo(new Guid(0x28636AA6, 0x953D, 0x11D2, 0xB5, 0xD6, 0x00, 0xC0, 0x4F, 0xD9, 0x18, 0xD0)));
        Assert.That(PKEY_ContainedItems.pid, Is.EqualTo(29));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ContentId"/> property is correct.</summary>
    [Test]
    public static void PKEY_ContentIdTest()
    {
        Assert.That(PKEY_ContentId.fmtid, Is.EqualTo(new Guid(0xFCEFF153, 0xE839, 0x4CF3, 0xA9, 0xE7, 0xEA, 0x22, 0x83, 0x20, 0x94, 0xB8)));
        Assert.That(PKEY_ContentId.pid, Is.EqualTo(132));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ContentStatus"/> property is correct.</summary>
    [Test]
    public static void PKEY_ContentStatusTest()
    {
        Assert.That(PKEY_ContentStatus.fmtid, Is.EqualTo(new Guid(0xD5CDD502, 0x2E9C, 0x101B, 0x93, 0x97, 0x08, 0x00, 0x2B, 0x2C, 0xF9, 0xAE)));
        Assert.That(PKEY_ContentStatus.pid, Is.EqualTo(27));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ContentType"/> property is correct.</summary>
    [Test]
    public static void PKEY_ContentTypeTest()
    {
        Assert.That(PKEY_ContentType.fmtid, Is.EqualTo(new Guid(0xD5CDD502, 0x2E9C, 0x101B, 0x93, 0x97, 0x08, 0x00, 0x2B, 0x2C, 0xF9, 0xAE)));
        Assert.That(PKEY_ContentType.pid, Is.EqualTo(26));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ContentUri"/> property is correct.</summary>
    [Test]
    public static void PKEY_ContentUriTest()
    {
        Assert.That(PKEY_ContentUri.fmtid, Is.EqualTo(new Guid(0xFCEFF153, 0xE839, 0x4CF3, 0xA9, 0xE7, 0xEA, 0x22, 0x83, 0x20, 0x94, 0xB8)));
        Assert.That(PKEY_ContentUri.pid, Is.EqualTo(131));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Copyright"/> property is correct.</summary>
    [Test]
    public static void PKEY_CopyrightTest()
    {
        Assert.That(PKEY_Copyright.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Copyright.pid, Is.EqualTo(11));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_CreatorAppId"/> property is correct.</summary>
    [Test]
    public static void PKEY_CreatorAppIdTest()
    {
        Assert.That(PKEY_CreatorAppId.fmtid, Is.EqualTo(new Guid(0xC2EA046E, 0x033C, 0x4E91, 0xBD, 0x5B, 0xD4, 0x94, 0x2F, 0x6B, 0xBE, 0x49)));
        Assert.That(PKEY_CreatorAppId.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_CreatorOpenWithUIOptions"/> property is correct.</summary>
    [Test]
    public static void PKEY_CreatorOpenWithUIOptionsTest()
    {
        Assert.That(PKEY_CreatorOpenWithUIOptions.fmtid, Is.EqualTo(new Guid(0xC2EA046E, 0x033C, 0x4E91, 0xBD, 0x5B, 0xD4, 0x94, 0x2F, 0x6B, 0xBE, 0x49)));
        Assert.That(PKEY_CreatorOpenWithUIOptions.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DataObjectFormat"/> property is correct.</summary>
    [Test]
    public static void PKEY_DataObjectFormatTest()
    {
        Assert.That(PKEY_DataObjectFormat.fmtid, Is.EqualTo(new Guid(0x1E81A3F8, 0xA30F, 0x4247, 0xB9, 0xEE, 0x1D, 0x03, 0x68, 0xA9, 0x42, 0x5C)));
        Assert.That(PKEY_DataObjectFormat.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DateAccessed"/> property is correct.</summary>
    [Test]
    public static void PKEY_DateAccessedTest()
    {
        Assert.That(PKEY_DateAccessed.fmtid, Is.EqualTo(new Guid(0xB725F130, 0x47EF, 0x101A, 0xA5, 0xF1, 0x02, 0x60, 0x8C, 0x9E, 0xEB, 0xAC)));
        Assert.That(PKEY_DateAccessed.pid, Is.EqualTo(16));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DateAcquired"/> property is correct.</summary>
    [Test]
    public static void PKEY_DateAcquiredTest()
    {
        Assert.That(PKEY_DateAcquired.fmtid, Is.EqualTo(new Guid(0x2CBAA8F5, 0xD81F, 0x47CA, 0xB1, 0x7A, 0xF8, 0xD8, 0x22, 0x30, 0x01, 0x31)));
        Assert.That(PKEY_DateAcquired.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DateArchived"/> property is correct.</summary>
    [Test]
    public static void PKEY_DateArchivedTest()
    {
        Assert.That(PKEY_DateArchived.fmtid, Is.EqualTo(new Guid(0x43F8D7B7, 0xA444, 0x4F87, 0x93, 0x83, 0x52, 0x27, 0x1C, 0x9B, 0x91, 0x5C)));
        Assert.That(PKEY_DateArchived.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DateCompleted"/> property is correct.</summary>
    [Test]
    public static void PKEY_DateCompletedTest()
    {
        Assert.That(PKEY_DateCompleted.fmtid, Is.EqualTo(new Guid(0x72FAB781, 0xACDA, 0x43E5, 0xB1, 0x55, 0xB2, 0x43, 0x4F, 0x85, 0xE6, 0x78)));
        Assert.That(PKEY_DateCompleted.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DateCreated"/> property is correct.</summary>
    [Test]
    public static void PKEY_DateCreatedTest()
    {
        Assert.That(PKEY_DateCreated.fmtid, Is.EqualTo(new Guid(0xB725F130, 0x47EF, 0x101A, 0xA5, 0xF1, 0x02, 0x60, 0x8C, 0x9E, 0xEB, 0xAC)));
        Assert.That(PKEY_DateCreated.pid, Is.EqualTo(15));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DateImported"/> property is correct.</summary>
    [Test]
    public static void PKEY_DateImportedTest()
    {
        Assert.That(PKEY_DateImported.fmtid, Is.EqualTo(new Guid(0x14B81DA1, 0x0135, 0x4D31, 0x96, 0xD9, 0x6C, 0xBF, 0xC9, 0x67, 0x1A, 0x99)));
        Assert.That(PKEY_DateImported.pid, Is.EqualTo(18258));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DateModified"/> property is correct.</summary>
    [Test]
    public static void PKEY_DateModifiedTest()
    {
        Assert.That(PKEY_DateModified.fmtid, Is.EqualTo(new Guid(0xB725F130, 0x47EF, 0x101A, 0xA5, 0xF1, 0x02, 0x60, 0x8C, 0x9E, 0xEB, 0xAC)));
        Assert.That(PKEY_DateModified.pid, Is.EqualTo(14));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DefaultSaveLocationDisplay"/> property is correct.</summary>
    [Test]
    public static void PKEY_DefaultSaveLocationDisplayTest()
    {
        Assert.That(PKEY_DefaultSaveLocationDisplay.fmtid, Is.EqualTo(new Guid(0x5D76B67F, 0x9B3D, 0x44BB, 0xB6, 0xAE, 0x25, 0xDA, 0x4F, 0x63, 0x8A, 0x67)));
        Assert.That(PKEY_DefaultSaveLocationDisplay.pid, Is.EqualTo(10));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DueDate"/> property is correct.</summary>
    [Test]
    public static void PKEY_DueDateTest()
    {
        Assert.That(PKEY_DueDate.fmtid, Is.EqualTo(new Guid(0x3F8472B5, 0xE0AF, 0x4DB2, 0x80, 0x71, 0xC5, 0x3F, 0xE7, 0x6A, 0xE7, 0xCE)));
        Assert.That(PKEY_DueDate.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_EndDate"/> property is correct.</summary>
    [Test]
    public static void PKEY_EndDateTest()
    {
        Assert.That(PKEY_EndDate.fmtid, Is.EqualTo(new Guid(0xC75FAA05, 0x96FD, 0x49E7, 0x9C, 0xB4, 0x9F, 0x60, 0x10, 0x82, 0xD5, 0x53)));
        Assert.That(PKEY_EndDate.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ExpandoProperties"/> property is correct.</summary>
    [Test]
    public static void PKEY_ExpandoPropertiesTest()
    {
        Assert.That(PKEY_ExpandoProperties.fmtid, Is.EqualTo(new Guid(0x6FA20DE6, 0xD11C, 0x4D9D, 0xA1, 0x54, 0x64, 0x31, 0x76, 0x28, 0xC1, 0x2D)));
        Assert.That(PKEY_ExpandoProperties.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_FileAllocationSize"/> property is correct.</summary>
    [Test]
    public static void PKEY_FileAllocationSizeTest()
    {
        Assert.That(PKEY_FileAllocationSize.fmtid, Is.EqualTo(new Guid(0xB725F130, 0x47EF, 0x101A, 0xA5, 0xF1, 0x02, 0x60, 0x8C, 0x9E, 0xEB, 0xAC)));
        Assert.That(PKEY_FileAllocationSize.pid, Is.EqualTo(18));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_FileAttributes"/> property is correct.</summary>
    [Test]
    public static void PKEY_FileAttributesTest()
    {
        Assert.That(PKEY_FileAttributes.fmtid, Is.EqualTo(new Guid(0xB725F130, 0x47EF, 0x101A, 0xA5, 0xF1, 0x02, 0x60, 0x8C, 0x9E, 0xEB, 0xAC)));
        Assert.That(PKEY_FileAttributes.pid, Is.EqualTo(13));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_FileCount"/> property is correct.</summary>
    [Test]
    public static void PKEY_FileCountTest()
    {
        Assert.That(PKEY_FileCount.fmtid, Is.EqualTo(new Guid(0x28636AA6, 0x953D, 0x11D2, 0xB5, 0xD6, 0x00, 0xC0, 0x4F, 0xD9, 0x18, 0xD0)));
        Assert.That(PKEY_FileCount.pid, Is.EqualTo(12));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_FileDescription"/> property is correct.</summary>
    [Test]
    public static void PKEY_FileDescriptionTest()
    {
        Assert.That(PKEY_FileDescription.fmtid, Is.EqualTo(new Guid(0x0CEF7D53, 0xFA64, 0x11D1, 0xA2, 0x03, 0x00, 0x00, 0xF8, 0x1F, 0xED, 0xEE)));
        Assert.That(PKEY_FileDescription.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_FileExtension"/> property is correct.</summary>
    [Test]
    public static void PKEY_FileExtensionTest()
    {
        Assert.That(PKEY_FileExtension.fmtid, Is.EqualTo(new Guid(0xE4F10A3C, 0x49E6, 0x405D, 0x82, 0x88, 0xA2, 0x3B, 0xD4, 0xEE, 0xAA, 0x6C)));
        Assert.That(PKEY_FileExtension.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_FileFRN"/> property is correct.</summary>
    [Test]
    public static void PKEY_FileFRNTest()
    {
        Assert.That(PKEY_FileFRN.fmtid, Is.EqualTo(new Guid(0xB725F130, 0x47EF, 0x101A, 0xA5, 0xF1, 0x02, 0x60, 0x8C, 0x9E, 0xEB, 0xAC)));
        Assert.That(PKEY_FileFRN.pid, Is.EqualTo(21));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_FileName"/> property is correct.</summary>
    [Test]
    public static void PKEY_FileNameTest()
    {
        Assert.That(PKEY_FileName.fmtid, Is.EqualTo(new Guid(0x41CF5AE0, 0xF75A, 0x4806, 0xBD, 0x87, 0x59, 0xC7, 0xD9, 0x24, 0x8E, 0xB9)));
        Assert.That(PKEY_FileName.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_FileOfflineAvailabilityStatus"/> property is correct.</summary>
    [Test]
    public static void PKEY_FileOfflineAvailabilityStatusTest()
    {
        Assert.That(PKEY_FileOfflineAvailabilityStatus.fmtid, Is.EqualTo(new Guid(0xFCEFF153, 0xE839, 0x4CF3, 0xA9, 0xE7, 0xEA, 0x22, 0x83, 0x20, 0x94, 0xB8)));
        Assert.That(PKEY_FileOfflineAvailabilityStatus.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_FileOwner"/> property is correct.</summary>
    [Test]
    public static void PKEY_FileOwnerTest()
    {
        Assert.That(PKEY_FileOwner.fmtid, Is.EqualTo(new Guid(0x9B174B34, 0x40FF, 0x11D2, 0xA2, 0x7E, 0x00, 0xC0, 0x4F, 0xC3, 0x08, 0x71)));
        Assert.That(PKEY_FileOwner.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_FilePlaceholderStatus"/> property is correct.</summary>
    [Test]
    public static void PKEY_FilePlaceholderStatusTest()
    {
        Assert.That(PKEY_FilePlaceholderStatus.fmtid, Is.EqualTo(new Guid(0xB2F9B9D6, 0xFEC4, 0x4DD5, 0x94, 0xD7, 0x89, 0x57, 0x48, 0x8C, 0x80, 0x7B)));
        Assert.That(PKEY_FilePlaceholderStatus.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_FileVersion"/> property is correct.</summary>
    [Test]
    public static void PKEY_FileVersionTest()
    {
        Assert.That(PKEY_FileVersion.fmtid, Is.EqualTo(new Guid(0x0CEF7D53, 0xFA64, 0x11D1, 0xA2, 0x03, 0x00, 0x00, 0xF8, 0x1F, 0xED, 0xEE)));
        Assert.That(PKEY_FileVersion.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_FindData"/> property is correct.</summary>
    [Test]
    public static void PKEY_FindDataTest()
    {
        Assert.That(PKEY_FindData.fmtid, Is.EqualTo(new Guid(0x28636AA6, 0x953D, 0x11D2, 0xB5, 0xD6, 0x00, 0xC0, 0x4F, 0xD9, 0x18, 0xD0)));
        Assert.That(PKEY_FindData.pid, Is.EqualTo(0));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_FlagColor"/> property is correct.</summary>
    [Test]
    public static void PKEY_FlagColorTest()
    {
        Assert.That(PKEY_FlagColor.fmtid, Is.EqualTo(new Guid(0x67DF94DE, 0x0CA7, 0x4D6F, 0xB7, 0x92, 0x05, 0x3A, 0x3E, 0x4F, 0x03, 0xCF)));
        Assert.That(PKEY_FlagColor.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_FlagColorText"/> property is correct.</summary>
    [Test]
    public static void PKEY_FlagColorTextTest()
    {
        Assert.That(PKEY_FlagColorText.fmtid, Is.EqualTo(new Guid(0x45EAE747, 0x8E2A, 0x40AE, 0x8C, 0xBF, 0xCA, 0x52, 0xAB, 0xA6, 0x15, 0x2A)));
        Assert.That(PKEY_FlagColorText.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_FlagStatus"/> property is correct.</summary>
    [Test]
    public static void PKEY_FlagStatusTest()
    {
        Assert.That(PKEY_FlagStatus.fmtid, Is.EqualTo(new Guid(0xE3E0584C, 0xB788, 0x4A5A, 0xBB, 0x20, 0x7F, 0x5A, 0x44, 0xC9, 0xAC, 0xDD)));
        Assert.That(PKEY_FlagStatus.pid, Is.EqualTo(12));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_FlagStatusText"/> property is correct.</summary>
    [Test]
    public static void PKEY_FlagStatusTextTest()
    {
        Assert.That(PKEY_FlagStatusText.fmtid, Is.EqualTo(new Guid(0xDC54FD2E, 0x189D, 0x4871, 0xAA, 0x01, 0x08, 0xC2, 0xF5, 0x7A, 0x4A, 0xBC)));
        Assert.That(PKEY_FlagStatusText.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_FolderKind"/> property is correct.</summary>
    [Test]
    public static void PKEY_FolderKindTest()
    {
        Assert.That(PKEY_FolderKind.fmtid, Is.EqualTo(new Guid(0xFCEFF153, 0xE839, 0x4CF3, 0xA9, 0xE7, 0xEA, 0x22, 0x83, 0x20, 0x94, 0xB8)));
        Assert.That(PKEY_FolderKind.pid, Is.EqualTo(101));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_FolderNameDisplay"/> property is correct.</summary>
    [Test]
    public static void PKEY_FolderNameDisplayTest()
    {
        Assert.That(PKEY_FolderNameDisplay.fmtid, Is.EqualTo(new Guid(0xB725F130, 0x47EF, 0x101A, 0xA5, 0xF1, 0x02, 0x60, 0x8C, 0x9E, 0xEB, 0xAC)));
        Assert.That(PKEY_FolderNameDisplay.pid, Is.EqualTo(25));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_FreeSpace"/> property is correct.</summary>
    [Test]
    public static void PKEY_FreeSpaceTest()
    {
        Assert.That(PKEY_FreeSpace.fmtid, Is.EqualTo(new Guid(0x9B174B35, 0x40FF, 0x11D2, 0xA2, 0x7E, 0x00, 0xC0, 0x4F, 0xC3, 0x08, 0x71)));
        Assert.That(PKEY_FreeSpace.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_FullText"/> property is correct.</summary>
    [Test]
    public static void PKEY_FullTextTest()
    {
        Assert.That(PKEY_FullText.fmtid, Is.EqualTo(new Guid(0x1E3EE840, 0xBC2B, 0x476C, 0x82, 0x37, 0x2A, 0xCD, 0x1A, 0x83, 0x9B, 0x22)));
        Assert.That(PKEY_FullText.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_HighKeywords"/> property is correct.</summary>
    [Test]
    public static void PKEY_HighKeywordsTest()
    {
        Assert.That(PKEY_HighKeywords.fmtid, Is.EqualTo(new Guid(0xF29F85E0, 0x4FF9, 0x1068, 0xAB, 0x91, 0x08, 0x00, 0x2B, 0x27, 0xB3, 0xD9)));
        Assert.That(PKEY_HighKeywords.pid, Is.EqualTo(24));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Identity"/> property is correct.</summary>
    [Test]
    public static void PKEY_IdentityTest()
    {
        Assert.That(PKEY_Identity.fmtid, Is.EqualTo(new Guid(0xA26F4AFC, 0x7346, 0x4299, 0xBE, 0x47, 0xEB, 0x1A, 0xE6, 0x13, 0x13, 0x9F)));
        Assert.That(PKEY_Identity.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Identity_Blob"/> property is correct.</summary>
    [Test]
    public static void PKEY_Identity_BlobTest()
    {
        Assert.That(PKEY_Identity_Blob.fmtid, Is.EqualTo(new Guid(0x8C3B93A4, 0xBAED, 0x1A83, 0x9A, 0x32, 0x10, 0x2E, 0xE3, 0x13, 0xF6, 0xEB)));
        Assert.That(PKEY_Identity_Blob.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Identity_DisplayName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Identity_DisplayNameTest()
    {
        Assert.That(PKEY_Identity_DisplayName.fmtid, Is.EqualTo(new Guid(0x7D683FC9, 0xD155, 0x45A8, 0xBB, 0x1F, 0x89, 0xD1, 0x9B, 0xCB, 0x79, 0x2F)));
        Assert.That(PKEY_Identity_DisplayName.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Identity_InternetSid"/> property is correct.</summary>
    [Test]
    public static void PKEY_Identity_InternetSidTest()
    {
        Assert.That(PKEY_Identity_InternetSid.fmtid, Is.EqualTo(new Guid(0x6D6D5D49, 0x265D, 0x4688, 0x9F, 0x4E, 0x1F, 0xDD, 0x33, 0xE7, 0xCC, 0x83)));
        Assert.That(PKEY_Identity_InternetSid.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Identity_IsMeIdentity"/> property is correct.</summary>
    [Test]
    public static void PKEY_Identity_IsMeIdentityTest()
    {
        Assert.That(PKEY_Identity_IsMeIdentity.fmtid, Is.EqualTo(new Guid(0xA4108708, 0x09DF, 0x4377, 0x9D, 0xFC, 0x6D, 0x99, 0x98, 0x6D, 0x5A, 0x67)));
        Assert.That(PKEY_Identity_IsMeIdentity.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Identity_KeyProviderContext"/> property is correct.</summary>
    [Test]
    public static void PKEY_Identity_KeyProviderContextTest()
    {
        Assert.That(PKEY_Identity_KeyProviderContext.fmtid, Is.EqualTo(new Guid(0xA26F4AFC, 0x7346, 0x4299, 0xBE, 0x47, 0xEB, 0x1A, 0xE6, 0x13, 0x13, 0x9F)));
        Assert.That(PKEY_Identity_KeyProviderContext.pid, Is.EqualTo(17));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Identity_KeyProviderName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Identity_KeyProviderNameTest()
    {
        Assert.That(PKEY_Identity_KeyProviderName.fmtid, Is.EqualTo(new Guid(0xA26F4AFC, 0x7346, 0x4299, 0xBE, 0x47, 0xEB, 0x1A, 0xE6, 0x13, 0x13, 0x9F)));
        Assert.That(PKEY_Identity_KeyProviderName.pid, Is.EqualTo(16));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Identity_LogonStatusString"/> property is correct.</summary>
    [Test]
    public static void PKEY_Identity_LogonStatusStringTest()
    {
        Assert.That(PKEY_Identity_LogonStatusString.fmtid, Is.EqualTo(new Guid(0xF18DEDF3, 0x337F, 0x42C0, 0x9E, 0x03, 0xCE, 0xE0, 0x87, 0x08, 0xA8, 0xC3)));
        Assert.That(PKEY_Identity_LogonStatusString.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Identity_PrimaryEmailAddress"/> property is correct.</summary>
    [Test]
    public static void PKEY_Identity_PrimaryEmailAddressTest()
    {
        Assert.That(PKEY_Identity_PrimaryEmailAddress.fmtid, Is.EqualTo(new Guid(0xFCC16823, 0xBAED, 0x4F24, 0x9B, 0x32, 0xA0, 0x98, 0x21, 0x17, 0xF7, 0xFA)));
        Assert.That(PKEY_Identity_PrimaryEmailAddress.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Identity_PrimarySid"/> property is correct.</summary>
    [Test]
    public static void PKEY_Identity_PrimarySidTest()
    {
        Assert.That(PKEY_Identity_PrimarySid.fmtid, Is.EqualTo(new Guid(0x2B1B801E, 0xC0C1, 0x4987, 0x9E, 0xC5, 0x72, 0xFA, 0x89, 0x81, 0x47, 0x87)));
        Assert.That(PKEY_Identity_PrimarySid.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Identity_ProviderData"/> property is correct.</summary>
    [Test]
    public static void PKEY_Identity_ProviderDataTest()
    {
        Assert.That(PKEY_Identity_ProviderData.fmtid, Is.EqualTo(new Guid(0xA8A74B92, 0x361B, 0x4E9A, 0xB7, 0x22, 0x7C, 0x4A, 0x73, 0x30, 0xA3, 0x12)));
        Assert.That(PKEY_Identity_ProviderData.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Identity_ProviderID"/> property is correct.</summary>
    [Test]
    public static void PKEY_Identity_ProviderIDTest()
    {
        Assert.That(PKEY_Identity_ProviderID.fmtid, Is.EqualTo(new Guid(0x74A7DE49, 0xFA11, 0x4D3D, 0xA0, 0x06, 0xDB, 0x7E, 0x08, 0x67, 0x59, 0x16)));
        Assert.That(PKEY_Identity_ProviderID.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Identity_QualifiedUserName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Identity_QualifiedUserNameTest()
    {
        Assert.That(PKEY_Identity_QualifiedUserName.fmtid, Is.EqualTo(new Guid(0xDA520E51, 0xF4E9, 0x4739, 0xAC, 0x82, 0x02, 0xE0, 0xA9, 0x5C, 0x90, 0x30)));
        Assert.That(PKEY_Identity_QualifiedUserName.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Identity_UniqueID"/> property is correct.</summary>
    [Test]
    public static void PKEY_Identity_UniqueIDTest()
    {
        Assert.That(PKEY_Identity_UniqueID.fmtid, Is.EqualTo(new Guid(0xE55FC3B0, 0x2B60, 0x4220, 0x91, 0x8E, 0xB2, 0x1E, 0x8B, 0xF1, 0x60, 0x16)));
        Assert.That(PKEY_Identity_UniqueID.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Identity_UserName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Identity_UserNameTest()
    {
        Assert.That(PKEY_Identity_UserName.fmtid, Is.EqualTo(new Guid(0xC4322503, 0x78CA, 0x49C6, 0x9A, 0xCC, 0xA6, 0x8E, 0x2A, 0xFD, 0x7B, 0x6B)));
        Assert.That(PKEY_Identity_UserName.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_IdentityProvider_Name"/> property is correct.</summary>
    [Test]
    public static void PKEY_IdentityProvider_NameTest()
    {
        Assert.That(PKEY_IdentityProvider_Name.fmtid, Is.EqualTo(new Guid(0xB96EFF7B, 0x35CA, 0x4A35, 0x86, 0x07, 0x29, 0xE3, 0xA5, 0x4C, 0x46, 0xEA)));
        Assert.That(PKEY_IdentityProvider_Name.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_IdentityProvider_Picture"/> property is correct.</summary>
    [Test]
    public static void PKEY_IdentityProvider_PictureTest()
    {
        Assert.That(PKEY_IdentityProvider_Picture.fmtid, Is.EqualTo(new Guid(0x2425166F, 0x5642, 0x4864, 0x99, 0x2F, 0x98, 0xFD, 0x98, 0xF2, 0x94, 0xC3)));
        Assert.That(PKEY_IdentityProvider_Picture.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ImageParsingName"/> property is correct.</summary>
    [Test]
    public static void PKEY_ImageParsingNameTest()
    {
        Assert.That(PKEY_ImageParsingName.fmtid, Is.EqualTo(new Guid(0xD7750EE0, 0xC6A4, 0x48EC, 0xB5, 0x3E, 0xB8, 0x7B, 0x52, 0xE6, 0xD0, 0x73)));
        Assert.That(PKEY_ImageParsingName.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Importance"/> property is correct.</summary>
    [Test]
    public static void PKEY_ImportanceTest()
    {
        Assert.That(PKEY_Importance.fmtid, Is.EqualTo(new Guid(0xE3E0584C, 0xB788, 0x4A5A, 0xBB, 0x20, 0x7F, 0x5A, 0x44, 0xC9, 0xAC, 0xDD)));
        Assert.That(PKEY_Importance.pid, Is.EqualTo(11));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ImportanceText"/> property is correct.</summary>
    [Test]
    public static void PKEY_ImportanceTextTest()
    {
        Assert.That(PKEY_ImportanceText.fmtid, Is.EqualTo(new Guid(0xA3B29791, 0x7713, 0x4E1D, 0xBB, 0x40, 0x17, 0xDB, 0x85, 0xF0, 0x18, 0x31)));
        Assert.That(PKEY_ImportanceText.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_IsAttachment"/> property is correct.</summary>
    [Test]
    public static void PKEY_IsAttachmentTest()
    {
        Assert.That(PKEY_IsAttachment.fmtid, Is.EqualTo(new Guid(0xF23F425C, 0x71A1, 0x4FA8, 0x92, 0x2F, 0x67, 0x8E, 0xA4, 0xA6, 0x04, 0x08)));
        Assert.That(PKEY_IsAttachment.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_IsDefaultNonOwnerSaveLocation"/> property is correct.</summary>
    [Test]
    public static void PKEY_IsDefaultNonOwnerSaveLocationTest()
    {
        Assert.That(PKEY_IsDefaultNonOwnerSaveLocation.fmtid, Is.EqualTo(new Guid(0x5D76B67F, 0x9B3D, 0x44BB, 0xB6, 0xAE, 0x25, 0xDA, 0x4F, 0x63, 0x8A, 0x67)));
        Assert.That(PKEY_IsDefaultNonOwnerSaveLocation.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_IsDefaultSaveLocation"/> property is correct.</summary>
    [Test]
    public static void PKEY_IsDefaultSaveLocationTest()
    {
        Assert.That(PKEY_IsDefaultSaveLocation.fmtid, Is.EqualTo(new Guid(0x5D76B67F, 0x9B3D, 0x44BB, 0xB6, 0xAE, 0x25, 0xDA, 0x4F, 0x63, 0x8A, 0x67)));
        Assert.That(PKEY_IsDefaultSaveLocation.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_IsDeleted"/> property is correct.</summary>
    [Test]
    public static void PKEY_IsDeletedTest()
    {
        Assert.That(PKEY_IsDeleted.fmtid, Is.EqualTo(new Guid(0x5CDA5FC8, 0x33EE, 0x4FF3, 0x90, 0x94, 0xAE, 0x7B, 0xD8, 0x86, 0x8C, 0x4D)));
        Assert.That(PKEY_IsDeleted.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_IsEncrypted"/> property is correct.</summary>
    [Test]
    public static void PKEY_IsEncryptedTest()
    {
        Assert.That(PKEY_IsEncrypted.fmtid, Is.EqualTo(new Guid(0x90E5E14E, 0x648B, 0x4826, 0xB2, 0xAA, 0xAC, 0xAF, 0x79, 0x0E, 0x35, 0x13)));
        Assert.That(PKEY_IsEncrypted.pid, Is.EqualTo(10));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_IsFlagged"/> property is correct.</summary>
    [Test]
    public static void PKEY_IsFlaggedTest()
    {
        Assert.That(PKEY_IsFlagged.fmtid, Is.EqualTo(new Guid(0x5DA84765, 0xE3FF, 0x4278, 0x86, 0xB0, 0xA2, 0x79, 0x67, 0xFB, 0xDD, 0x03)));
        Assert.That(PKEY_IsFlagged.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_IsFlaggedComplete"/> property is correct.</summary>
    [Test]
    public static void PKEY_IsFlaggedCompleteTest()
    {
        Assert.That(PKEY_IsFlaggedComplete.fmtid, Is.EqualTo(new Guid(0xA6F360D2, 0x55F9, 0x48DE, 0xB9, 0x09, 0x62, 0x0E, 0x09, 0x0A, 0x64, 0x7C)));
        Assert.That(PKEY_IsFlaggedComplete.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_IsIncomplete"/> property is correct.</summary>
    [Test]
    public static void PKEY_IsIncompleteTest()
    {
        Assert.That(PKEY_IsIncomplete.fmtid, Is.EqualTo(new Guid(0x346C8BD1, 0x2E6A, 0x4C45, 0x89, 0xA4, 0x61, 0xB7, 0x8E, 0x8E, 0x70, 0x0F)));
        Assert.That(PKEY_IsIncomplete.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_IsLocationSupported"/> property is correct.</summary>
    [Test]
    public static void PKEY_IsLocationSupportedTest()
    {
        Assert.That(PKEY_IsLocationSupported.fmtid, Is.EqualTo(new Guid(0x5D76B67F, 0x9B3D, 0x44BB, 0xB6, 0xAE, 0x25, 0xDA, 0x4F, 0x63, 0x8A, 0x67)));
        Assert.That(PKEY_IsLocationSupported.pid, Is.EqualTo(8));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_IsPinnedToNameSpaceTree"/> property is correct.</summary>
    [Test]
    public static void PKEY_IsPinnedToNameSpaceTreeTest()
    {
        Assert.That(PKEY_IsPinnedToNameSpaceTree.fmtid, Is.EqualTo(new Guid(0x5D76B67F, 0x9B3D, 0x44BB, 0xB6, 0xAE, 0x25, 0xDA, 0x4F, 0x63, 0x8A, 0x67)));
        Assert.That(PKEY_IsPinnedToNameSpaceTree.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_IsRead"/> property is correct.</summary>
    [Test]
    public static void PKEY_IsReadTest()
    {
        Assert.That(PKEY_IsRead.fmtid, Is.EqualTo(new Guid(0xE3E0584C, 0xB788, 0x4A5A, 0xBB, 0x20, 0x7F, 0x5A, 0x44, 0xC9, 0xAC, 0xDD)));
        Assert.That(PKEY_IsRead.pid, Is.EqualTo(10));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_IsSearchOnlyItem"/> property is correct.</summary>
    [Test]
    public static void PKEY_IsSearchOnlyItemTest()
    {
        Assert.That(PKEY_IsSearchOnlyItem.fmtid, Is.EqualTo(new Guid(0x5D76B67F, 0x9B3D, 0x44BB, 0xB6, 0xAE, 0x25, 0xDA, 0x4F, 0x63, 0x8A, 0x67)));
        Assert.That(PKEY_IsSearchOnlyItem.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_IsSendToTarget"/> property is correct.</summary>
    [Test]
    public static void PKEY_IsSendToTargetTest()
    {
        Assert.That(PKEY_IsSendToTarget.fmtid, Is.EqualTo(new Guid(0x28636AA6, 0x953D, 0x11D2, 0xB5, 0xD6, 0x00, 0xC0, 0x4F, 0xD9, 0x18, 0xD0)));
        Assert.That(PKEY_IsSendToTarget.pid, Is.EqualTo(33));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_IsShared"/> property is correct.</summary>
    [Test]
    public static void PKEY_IsSharedTest()
    {
        Assert.That(PKEY_IsShared.fmtid, Is.EqualTo(new Guid(0xEF884C5B, 0x2BFE, 0x41BB, 0xAA, 0xE5, 0x76, 0xEE, 0xDF, 0x4F, 0x99, 0x02)));
        Assert.That(PKEY_IsShared.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ItemAuthors"/> property is correct.</summary>
    [Test]
    public static void PKEY_ItemAuthorsTest()
    {
        Assert.That(PKEY_ItemAuthors.fmtid, Is.EqualTo(new Guid(0xD0A04F0A, 0x462A, 0x48A4, 0xBB, 0x2F, 0x37, 0x06, 0xE8, 0x8D, 0xBD, 0x7D)));
        Assert.That(PKEY_ItemAuthors.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ItemClassType"/> property is correct.</summary>
    [Test]
    public static void PKEY_ItemClassTypeTest()
    {
        Assert.That(PKEY_ItemClassType.fmtid, Is.EqualTo(new Guid(0x048658AD, 0x2DB8, 0x41A4, 0xBB, 0xB6, 0xAC, 0x1E, 0xF1, 0x20, 0x7E, 0xB1)));
        Assert.That(PKEY_ItemClassType.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ItemDate"/> property is correct.</summary>
    [Test]
    public static void PKEY_ItemDateTest()
    {
        Assert.That(PKEY_ItemDate.fmtid, Is.EqualTo(new Guid(0xF7DB74B4, 0x4287, 0x4103, 0xAF, 0xBA, 0xF1, 0xB1, 0x3D, 0xCD, 0x75, 0xCF)));
        Assert.That(PKEY_ItemDate.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ItemFolderNameDisplay"/> property is correct.</summary>
    [Test]
    public static void PKEY_ItemFolderNameDisplayTest()
    {
        Assert.That(PKEY_ItemFolderNameDisplay.fmtid, Is.EqualTo(new Guid(0xB725F130, 0x47EF, 0x101A, 0xA5, 0xF1, 0x02, 0x60, 0x8C, 0x9E, 0xEB, 0xAC)));
        Assert.That(PKEY_ItemFolderNameDisplay.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ItemFolderPathDisplay"/> property is correct.</summary>
    [Test]
    public static void PKEY_ItemFolderPathDisplayTest()
    {
        Assert.That(PKEY_ItemFolderPathDisplay.fmtid, Is.EqualTo(new Guid(0xE3E0584C, 0xB788, 0x4A5A, 0xBB, 0x20, 0x7F, 0x5A, 0x44, 0xC9, 0xAC, 0xDD)));
        Assert.That(PKEY_ItemFolderPathDisplay.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ItemFolderPathDisplayNarrow"/> property is correct.</summary>
    [Test]
    public static void PKEY_ItemFolderPathDisplayNarrowTest()
    {
        Assert.That(PKEY_ItemFolderPathDisplayNarrow.fmtid, Is.EqualTo(new Guid(0xDABD30ED, 0x0043, 0x4789, 0xA7, 0xF8, 0xD0, 0x13, 0xA4, 0x73, 0x66, 0x22)));
        Assert.That(PKEY_ItemFolderPathDisplayNarrow.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ItemName"/> property is correct.</summary>
    [Test]
    public static void PKEY_ItemNameTest()
    {
        Assert.That(PKEY_ItemName.fmtid, Is.EqualTo(new Guid(0x6B8DA074, 0x3B5C, 0x43BC, 0x88, 0x6F, 0x0A, 0x2C, 0xDC, 0xE0, 0x0B, 0x6F)));
        Assert.That(PKEY_ItemName.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ItemNameDisplay"/> property is correct.</summary>
    [Test]
    public static void PKEY_ItemNameDisplayTest()
    {
        Assert.That(PKEY_ItemNameDisplay.fmtid, Is.EqualTo(new Guid(0xB725F130, 0x47EF, 0x101A, 0xA5, 0xF1, 0x02, 0x60, 0x8C, 0x9E, 0xEB, 0xAC)));
        Assert.That(PKEY_ItemNameDisplay.pid, Is.EqualTo(10));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ItemNameDisplayWithoutExtension"/> property is correct.</summary>
    [Test]
    public static void PKEY_ItemNameDisplayWithoutExtensionTest()
    {
        Assert.That(PKEY_ItemNameDisplayWithoutExtension.fmtid, Is.EqualTo(new Guid(0xB725F130, 0x47EF, 0x101A, 0xA5, 0xF1, 0x02, 0x60, 0x8C, 0x9E, 0xEB, 0xAC)));
        Assert.That(PKEY_ItemNameDisplayWithoutExtension.pid, Is.EqualTo(24));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ItemNamePrefix"/> property is correct.</summary>
    [Test]
    public static void PKEY_ItemNamePrefixTest()
    {
        Assert.That(PKEY_ItemNamePrefix.fmtid, Is.EqualTo(new Guid(0xD7313FF1, 0xA77A, 0x401C, 0x8C, 0x99, 0x3D, 0xBD, 0xD6, 0x8A, 0xDD, 0x36)));
        Assert.That(PKEY_ItemNamePrefix.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ItemNameSortOverride"/> property is correct.</summary>
    [Test]
    public static void PKEY_ItemNameSortOverrideTest()
    {
        Assert.That(PKEY_ItemNameSortOverride.fmtid, Is.EqualTo(new Guid(0xB725F130, 0x47EF, 0x101A, 0xA5, 0xF1, 0x02, 0x60, 0x8C, 0x9E, 0xEB, 0xAC)));
        Assert.That(PKEY_ItemNameSortOverride.pid, Is.EqualTo(23));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ItemParticipants"/> property is correct.</summary>
    [Test]
    public static void PKEY_ItemParticipantsTest()
    {
        Assert.That(PKEY_ItemParticipants.fmtid, Is.EqualTo(new Guid(0xD4D0AA16, 0x9948, 0x41A4, 0xAA, 0x85, 0xD9, 0x7F, 0xF9, 0x64, 0x69, 0x93)));
        Assert.That(PKEY_ItemParticipants.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ItemPathDisplay"/> property is correct.</summary>
    [Test]
    public static void PKEY_ItemPathDisplayTest()
    {
        Assert.That(PKEY_ItemPathDisplay.fmtid, Is.EqualTo(new Guid(0xE3E0584C, 0xB788, 0x4A5A, 0xBB, 0x20, 0x7F, 0x5A, 0x44, 0xC9, 0xAC, 0xDD)));
        Assert.That(PKEY_ItemPathDisplay.pid, Is.EqualTo(7));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ItemPathDisplayNarrow"/> property is correct.</summary>
    [Test]
    public static void PKEY_ItemPathDisplayNarrowTest()
    {
        Assert.That(PKEY_ItemPathDisplayNarrow.fmtid, Is.EqualTo(new Guid(0x28636AA6, 0x953D, 0x11D2, 0xB5, 0xD6, 0x00, 0xC0, 0x4F, 0xD9, 0x18, 0xD0)));
        Assert.That(PKEY_ItemPathDisplayNarrow.pid, Is.EqualTo(8));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ItemSubType"/> property is correct.</summary>
    [Test]
    public static void PKEY_ItemSubTypeTest()
    {
        Assert.That(PKEY_ItemSubType.fmtid, Is.EqualTo(new Guid(0x28636AA6, 0x953D, 0x11D2, 0xB5, 0xD6, 0x00, 0xC0, 0x4F, 0xD9, 0x18, 0xD0)));
        Assert.That(PKEY_ItemSubType.pid, Is.EqualTo(37));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ItemType"/> property is correct.</summary>
    [Test]
    public static void PKEY_ItemTypeTest()
    {
        Assert.That(PKEY_ItemType.fmtid, Is.EqualTo(new Guid(0x28636AA6, 0x953D, 0x11D2, 0xB5, 0xD6, 0x00, 0xC0, 0x4F, 0xD9, 0x18, 0xD0)));
        Assert.That(PKEY_ItemType.pid, Is.EqualTo(11));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ItemTypeText"/> property is correct.</summary>
    [Test]
    public static void PKEY_ItemTypeTextTest()
    {
        Assert.That(PKEY_ItemTypeText.fmtid, Is.EqualTo(new Guid(0xB725F130, 0x47EF, 0x101A, 0xA5, 0xF1, 0x02, 0x60, 0x8C, 0x9E, 0xEB, 0xAC)));
        Assert.That(PKEY_ItemTypeText.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ItemUrl"/> property is correct.</summary>
    [Test]
    public static void PKEY_ItemUrlTest()
    {
        Assert.That(PKEY_ItemUrl.fmtid, Is.EqualTo(new Guid(0x49691C90, 0x7E17, 0x101A, 0xA9, 0x1C, 0x08, 0x00, 0x2B, 0x2E, 0xCD, 0xA9)));
        Assert.That(PKEY_ItemUrl.pid, Is.EqualTo(9));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Keywords"/> property is correct.</summary>
    [Test]
    public static void PKEY_KeywordsTest()
    {
        Assert.That(PKEY_Keywords.fmtid, Is.EqualTo(new Guid(0xF29F85E0, 0x4FF9, 0x1068, 0xAB, 0x91, 0x08, 0x00, 0x2B, 0x27, 0xB3, 0xD9)));
        Assert.That(PKEY_Keywords.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Kind"/> property is correct.</summary>
    [Test]
    public static void PKEY_KindTest()
    {
        Assert.That(PKEY_Kind.fmtid, Is.EqualTo(new Guid(0x1E3EE840, 0xBC2B, 0x476C, 0x82, 0x37, 0x2A, 0xCD, 0x1A, 0x83, 0x9B, 0x22)));
        Assert.That(PKEY_Kind.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_KindText"/> property is correct.</summary>
    [Test]
    public static void PKEY_KindTextTest()
    {
        Assert.That(PKEY_KindText.fmtid, Is.EqualTo(new Guid(0xF04BEF95, 0xC585, 0x4197, 0xA2, 0xB7, 0xDF, 0x46, 0xFD, 0xC9, 0xEE, 0x6D)));
        Assert.That(PKEY_KindText.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Language"/> property is correct.</summary>
    [Test]
    public static void PKEY_LanguageTest()
    {
        Assert.That(PKEY_Language.fmtid, Is.EqualTo(new Guid(0xD5CDD502, 0x2E9C, 0x101B, 0x93, 0x97, 0x08, 0x00, 0x2B, 0x2C, 0xF9, 0xAE)));
        Assert.That(PKEY_Language.pid, Is.EqualTo(28));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_LastSyncError"/> property is correct.</summary>
    [Test]
    public static void PKEY_LastSyncErrorTest()
    {
        Assert.That(PKEY_LastSyncError.fmtid, Is.EqualTo(new Guid(0xFCEFF153, 0xE839, 0x4CF3, 0xA9, 0xE7, 0xEA, 0x22, 0x83, 0x20, 0x94, 0xB8)));
        Assert.That(PKEY_LastSyncError.pid, Is.EqualTo(107));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_LastSyncWarning"/> property is correct.</summary>
    [Test]
    public static void PKEY_LastSyncWarningTest()
    {
        Assert.That(PKEY_LastSyncWarning.fmtid, Is.EqualTo(new Guid(0xFCEFF153, 0xE839, 0x4CF3, 0xA9, 0xE7, 0xEA, 0x22, 0x83, 0x20, 0x94, 0xB8)));
        Assert.That(PKEY_LastSyncWarning.pid, Is.EqualTo(128));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_LastWriterPackageFamilyName"/> property is correct.</summary>
    [Test]
    public static void PKEY_LastWriterPackageFamilyNameTest()
    {
        Assert.That(PKEY_LastWriterPackageFamilyName.fmtid, Is.EqualTo(new Guid(0x502CFEAB, 0x47EB, 0x459C, 0xB9, 0x60, 0xE6, 0xD8, 0x72, 0x8F, 0x77, 0x01)));
        Assert.That(PKEY_LastWriterPackageFamilyName.pid, Is.EqualTo(101));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_LowKeywords"/> property is correct.</summary>
    [Test]
    public static void PKEY_LowKeywordsTest()
    {
        Assert.That(PKEY_LowKeywords.fmtid, Is.EqualTo(new Guid(0xF29F85E0, 0x4FF9, 0x1068, 0xAB, 0x91, 0x08, 0x00, 0x2B, 0x27, 0xB3, 0xD9)));
        Assert.That(PKEY_LowKeywords.pid, Is.EqualTo(25));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_MediumKeywords"/> property is correct.</summary>
    [Test]
    public static void PKEY_MediumKeywordsTest()
    {
        Assert.That(PKEY_MediumKeywords.fmtid, Is.EqualTo(new Guid(0xF29F85E0, 0x4FF9, 0x1068, 0xAB, 0x91, 0x08, 0x00, 0x2B, 0x27, 0xB3, 0xD9)));
        Assert.That(PKEY_MediumKeywords.pid, Is.EqualTo(26));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_MileageInformation"/> property is correct.</summary>
    [Test]
    public static void PKEY_MileageInformationTest()
    {
        Assert.That(PKEY_MileageInformation.fmtid, Is.EqualTo(new Guid(0xFDF84370, 0x031A, 0x4ADD, 0x9E, 0x91, 0x0D, 0x77, 0x5F, 0x1C, 0x66, 0x05)));
        Assert.That(PKEY_MileageInformation.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_MIMEType"/> property is correct.</summary>
    [Test]
    public static void PKEY_MIMETypeTest()
    {
        Assert.That(PKEY_MIMEType.fmtid, Is.EqualTo(new Guid(0x0B63E350, 0x9CCC, 0x11D0, 0xBC, 0xDB, 0x00, 0x80, 0x5F, 0xCC, 0xCE, 0x04)));
        Assert.That(PKEY_MIMEType.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Null"/> property is correct.</summary>
    [Test]
    public static void PKEY_NullTest()
    {
        Assert.That(PKEY_Null.fmtid, Is.EqualTo(new Guid(0x00000000, 0x0000, 0x0000, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00)));
        Assert.That(PKEY_Null.pid, Is.EqualTo(0));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_OfflineAvailability"/> property is correct.</summary>
    [Test]
    public static void PKEY_OfflineAvailabilityTest()
    {
        Assert.That(PKEY_OfflineAvailability.fmtid, Is.EqualTo(new Guid(0xA94688B6, 0x7D9F, 0x4570, 0xA6, 0x48, 0xE3, 0xDF, 0xC0, 0xAB, 0x2B, 0x3F)));
        Assert.That(PKEY_OfflineAvailability.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_OfflineStatus"/> property is correct.</summary>
    [Test]
    public static void PKEY_OfflineStatusTest()
    {
        Assert.That(PKEY_OfflineStatus.fmtid, Is.EqualTo(new Guid(0x6D24888F, 0x4718, 0x4BDA, 0xAF, 0xED, 0xEA, 0x0F, 0xB4, 0x38, 0x6C, 0xD8)));
        Assert.That(PKEY_OfflineStatus.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_OriginalFileName"/> property is correct.</summary>
    [Test]
    public static void PKEY_OriginalFileNameTest()
    {
        Assert.That(PKEY_OriginalFileName.fmtid, Is.EqualTo(new Guid(0x0CEF7D53, 0xFA64, 0x11D1, 0xA2, 0x03, 0x00, 0x00, 0xF8, 0x1F, 0xED, 0xEE)));
        Assert.That(PKEY_OriginalFileName.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_OwnerSID"/> property is correct.</summary>
    [Test]
    public static void PKEY_OwnerSIDTest()
    {
        Assert.That(PKEY_OwnerSID.fmtid, Is.EqualTo(new Guid(0x5D76B67F, 0x9B3D, 0x44BB, 0xB6, 0xAE, 0x25, 0xDA, 0x4F, 0x63, 0x8A, 0x67)));
        Assert.That(PKEY_OwnerSID.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ParentalRating"/> property is correct.</summary>
    [Test]
    public static void PKEY_ParentalRatingTest()
    {
        Assert.That(PKEY_ParentalRating.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_ParentalRating.pid, Is.EqualTo(21));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ParentalRatingReason"/> property is correct.</summary>
    [Test]
    public static void PKEY_ParentalRatingReasonTest()
    {
        Assert.That(PKEY_ParentalRatingReason.fmtid, Is.EqualTo(new Guid(0x10984E0A, 0xF9F2, 0x4321, 0xB7, 0xEF, 0xBA, 0xF1, 0x95, 0xAF, 0x43, 0x19)));
        Assert.That(PKEY_ParentalRatingReason.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ParentalRatingsOrganization"/> property is correct.</summary>
    [Test]
    public static void PKEY_ParentalRatingsOrganizationTest()
    {
        Assert.That(PKEY_ParentalRatingsOrganization.fmtid, Is.EqualTo(new Guid(0xA7FE0840, 0x1344, 0x46F0, 0x8D, 0x37, 0x52, 0xED, 0x71, 0x2A, 0x4B, 0xF9)));
        Assert.That(PKEY_ParentalRatingsOrganization.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ParsingBindContext"/> property is correct.</summary>
    [Test]
    public static void PKEY_ParsingBindContextTest()
    {
        Assert.That(PKEY_ParsingBindContext.fmtid, Is.EqualTo(new Guid(0xDFB9A04D, 0x362F, 0x4CA3, 0xB3, 0x0B, 0x02, 0x54, 0xB1, 0x7B, 0x5B, 0x84)));
        Assert.That(PKEY_ParsingBindContext.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ParsingName"/> property is correct.</summary>
    [Test]
    public static void PKEY_ParsingNameTest()
    {
        Assert.That(PKEY_ParsingName.fmtid, Is.EqualTo(new Guid(0x28636AA6, 0x953D, 0x11D2, 0xB5, 0xD6, 0x00, 0xC0, 0x4F, 0xD9, 0x18, 0xD0)));
        Assert.That(PKEY_ParsingName.pid, Is.EqualTo(24));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ParsingPath"/> property is correct.</summary>
    [Test]
    public static void PKEY_ParsingPathTest()
    {
        Assert.That(PKEY_ParsingPath.fmtid, Is.EqualTo(new Guid(0x28636AA6, 0x953D, 0x11D2, 0xB5, 0xD6, 0x00, 0xC0, 0x4F, 0xD9, 0x18, 0xD0)));
        Assert.That(PKEY_ParsingPath.pid, Is.EqualTo(30));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PerceivedType"/> property is correct.</summary>
    [Test]
    public static void PKEY_PerceivedTypeTest()
    {
        Assert.That(PKEY_PerceivedType.fmtid, Is.EqualTo(new Guid(0x28636AA6, 0x953D, 0x11D2, 0xB5, 0xD6, 0x00, 0xC0, 0x4F, 0xD9, 0x18, 0xD0)));
        Assert.That(PKEY_PerceivedType.pid, Is.EqualTo(9));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PercentFull"/> property is correct.</summary>
    [Test]
    public static void PKEY_PercentFullTest()
    {
        Assert.That(PKEY_PercentFull.fmtid, Is.EqualTo(new Guid(0x9B174B35, 0x40FF, 0x11D2, 0xA2, 0x7E, 0x00, 0xC0, 0x4F, 0xC3, 0x08, 0x71)));
        Assert.That(PKEY_PercentFull.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Priority"/> property is correct.</summary>
    [Test]
    public static void PKEY_PriorityTest()
    {
        Assert.That(PKEY_Priority.fmtid, Is.EqualTo(new Guid(0x9C1FCF74, 0x2D97, 0x41BA, 0xB4, 0xAE, 0xCB, 0x2E, 0x36, 0x61, 0xA6, 0xE4)));
        Assert.That(PKEY_Priority.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PriorityText"/> property is correct.</summary>
    [Test]
    public static void PKEY_PriorityTextTest()
    {
        Assert.That(PKEY_PriorityText.fmtid, Is.EqualTo(new Guid(0xD98BE98B, 0xB86B, 0x4095, 0xBF, 0x52, 0x9D, 0x23, 0xB2, 0xE0, 0xA7, 0x52)));
        Assert.That(PKEY_PriorityText.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Project"/> property is correct.</summary>
    [Test]
    public static void PKEY_ProjectTest()
    {
        Assert.That(PKEY_Project.fmtid, Is.EqualTo(new Guid(0x39A7F922, 0x477C, 0x48DE, 0x8B, 0xC8, 0xB2, 0x84, 0x41, 0xE3, 0x42, 0xE3)));
        Assert.That(PKEY_Project.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ProviderItemID"/> property is correct.</summary>
    [Test]
    public static void PKEY_ProviderItemIDTest()
    {
        Assert.That(PKEY_ProviderItemID.fmtid, Is.EqualTo(new Guid(0xF21D9941, 0x81F0, 0x471A, 0xAD, 0xEE, 0x4E, 0x74, 0xB4, 0x92, 0x17, 0xED)));
        Assert.That(PKEY_ProviderItemID.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Rating"/> property is correct.</summary>
    [Test]
    public static void PKEY_RatingTest()
    {
        Assert.That(PKEY_Rating.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Rating.pid, Is.EqualTo(9));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_RatingText"/> property is correct.</summary>
    [Test]
    public static void PKEY_RatingTextTest()
    {
        Assert.That(PKEY_RatingText.fmtid, Is.EqualTo(new Guid(0x90197CA7, 0xFD8F, 0x4E8C, 0x9D, 0xA3, 0xB5, 0x7E, 0x1E, 0x60, 0x92, 0x95)));
        Assert.That(PKEY_RatingText.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_RemoteConflictingFile"/> property is correct.</summary>
    [Test]
    public static void PKEY_RemoteConflictingFileTest()
    {
        Assert.That(PKEY_RemoteConflictingFile.fmtid, Is.EqualTo(new Guid(0xFCEFF153, 0xE839, 0x4CF3, 0xA9, 0xE7, 0xEA, 0x22, 0x83, 0x20, 0x94, 0xB8)));
        Assert.That(PKEY_RemoteConflictingFile.pid, Is.EqualTo(115));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Security_AllowedEnterpriseDataProtectionIdentities"/> property is correct.</summary>
    [Test]
    public static void PKEY_Security_AllowedEnterpriseDataProtectionIdentitiesTest()
    {
        Assert.That(PKEY_Security_AllowedEnterpriseDataProtectionIdentities.fmtid, Is.EqualTo(new Guid(0x38D43380, 0xD418, 0x4830, 0x84, 0xD5, 0x46, 0x93, 0x5A, 0x81, 0xC5, 0xC6)));
        Assert.That(PKEY_Security_AllowedEnterpriseDataProtectionIdentities.pid, Is.EqualTo(32));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Security_EncryptionOwners"/> property is correct.</summary>
    [Test]
    public static void PKEY_Security_EncryptionOwnersTest()
    {
        Assert.That(PKEY_Security_EncryptionOwners.fmtid, Is.EqualTo(new Guid(0x5F5AFF6A, 0x37E5, 0x4780, 0x97, 0xEA, 0x80, 0xC7, 0x56, 0x5C, 0xF5, 0x35)));
        Assert.That(PKEY_Security_EncryptionOwners.pid, Is.EqualTo(34));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Security_EncryptionOwnersDisplay"/> property is correct.</summary>
    [Test]
    public static void PKEY_Security_EncryptionOwnersDisplayTest()
    {
        Assert.That(PKEY_Security_EncryptionOwnersDisplay.fmtid, Is.EqualTo(new Guid(0xDE621B8F, 0xE125, 0x43A3, 0xA3, 0x2D, 0x56, 0x65, 0x44, 0x6D, 0x63, 0x2A)));
        Assert.That(PKEY_Security_EncryptionOwnersDisplay.pid, Is.EqualTo(25));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Sensitivity"/> property is correct.</summary>
    [Test]
    public static void PKEY_SensitivityTest()
    {
        Assert.That(PKEY_Sensitivity.fmtid, Is.EqualTo(new Guid(0xF8D3F6AC, 0x4874, 0x42CB, 0xBE, 0x59, 0xAB, 0x45, 0x4B, 0x30, 0x71, 0x6A)));
        Assert.That(PKEY_Sensitivity.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_SensitivityText"/> property is correct.</summary>
    [Test]
    public static void PKEY_SensitivityTextTest()
    {
        Assert.That(PKEY_SensitivityText.fmtid, Is.EqualTo(new Guid(0xD0C7F054, 0x3F72, 0x4725, 0x85, 0x27, 0x12, 0x9A, 0x57, 0x7C, 0xB2, 0x69)));
        Assert.That(PKEY_SensitivityText.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_SFGAOFlags"/> property is correct.</summary>
    [Test]
    public static void PKEY_SFGAOFlagsTest()
    {
        Assert.That(PKEY_SFGAOFlags.fmtid, Is.EqualTo(new Guid(0x28636AA6, 0x953D, 0x11D2, 0xB5, 0xD6, 0x00, 0xC0, 0x4F, 0xD9, 0x18, 0xD0)));
        Assert.That(PKEY_SFGAOFlags.pid, Is.EqualTo(25));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_SharedWith"/> property is correct.</summary>
    [Test]
    public static void PKEY_SharedWithTest()
    {
        Assert.That(PKEY_SharedWith.fmtid, Is.EqualTo(new Guid(0xEF884C5B, 0x2BFE, 0x41BB, 0xAA, 0xE5, 0x76, 0xEE, 0xDF, 0x4F, 0x99, 0x02)));
        Assert.That(PKEY_SharedWith.pid, Is.EqualTo(200));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ShareUserRating"/> property is correct.</summary>
    [Test]
    public static void PKEY_ShareUserRatingTest()
    {
        Assert.That(PKEY_ShareUserRating.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_ShareUserRating.pid, Is.EqualTo(12));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_SharingStatus"/> property is correct.</summary>
    [Test]
    public static void PKEY_SharingStatusTest()
    {
        Assert.That(PKEY_SharingStatus.fmtid, Is.EqualTo(new Guid(0xEF884C5B, 0x2BFE, 0x41BB, 0xAA, 0xE5, 0x76, 0xEE, 0xDF, 0x4F, 0x99, 0x02)));
        Assert.That(PKEY_SharingStatus.pid, Is.EqualTo(300));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Shell_OmitFromView"/> property is correct.</summary>
    [Test]
    public static void PKEY_Shell_OmitFromViewTest()
    {
        Assert.That(PKEY_Shell_OmitFromView.fmtid, Is.EqualTo(new Guid(0xDE35258C, 0xC695, 0x4CBC, 0xB9, 0x82, 0x38, 0xB0, 0xAD, 0x24, 0xCE, 0xD0)));
        Assert.That(PKEY_Shell_OmitFromView.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_SimpleRating"/> property is correct.</summary>
    [Test]
    public static void PKEY_SimpleRatingTest()
    {
        Assert.That(PKEY_SimpleRating.fmtid, Is.EqualTo(new Guid(0xA09F084E, 0xAD41, 0x489F, 0x80, 0x76, 0xAA, 0x5B, 0xE3, 0x08, 0x2B, 0xCA)));
        Assert.That(PKEY_SimpleRating.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Size"/> property is correct.</summary>
    [Test]
    public static void PKEY_SizeTest()
    {
        Assert.That(PKEY_Size.fmtid, Is.EqualTo(new Guid(0xB725F130, 0x47EF, 0x101A, 0xA5, 0xF1, 0x02, 0x60, 0x8C, 0x9E, 0xEB, 0xAC)));
        Assert.That(PKEY_Size.pid, Is.EqualTo(12));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_SoftwareUsed"/> property is correct.</summary>
    [Test]
    public static void PKEY_SoftwareUsedTest()
    {
        Assert.That(PKEY_SoftwareUsed.fmtid, Is.EqualTo(new Guid(0x14B81DA1, 0x0135, 0x4D31, 0x96, 0xD9, 0x6C, 0xBF, 0xC9, 0x67, 0x1A, 0x99)));
        Assert.That(PKEY_SoftwareUsed.pid, Is.EqualTo(305));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_SourceItem"/> property is correct.</summary>
    [Test]
    public static void PKEY_SourceItemTest()
    {
        Assert.That(PKEY_SourceItem.fmtid, Is.EqualTo(new Guid(0x668CDFA5, 0x7A1B, 0x4323, 0xAE, 0x4B, 0xE5, 0x27, 0x39, 0x3A, 0x1D, 0x81)));
        Assert.That(PKEY_SourceItem.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_SourcePackageFamilyName"/> property is correct.</summary>
    [Test]
    public static void PKEY_SourcePackageFamilyNameTest()
    {
        Assert.That(PKEY_SourcePackageFamilyName.fmtid, Is.EqualTo(new Guid(0xFFAE9DB7, 0x1C8D, 0x43FF, 0x81, 0x8C, 0x84, 0x40, 0x3A, 0xA3, 0x73, 0x2D)));
        Assert.That(PKEY_SourcePackageFamilyName.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_StartDate"/> property is correct.</summary>
    [Test]
    public static void PKEY_StartDateTest()
    {
        Assert.That(PKEY_StartDate.fmtid, Is.EqualTo(new Guid(0x48FD6EC8, 0x8A12, 0x4CDF, 0xA0, 0x3E, 0x4E, 0xC5, 0xA5, 0x11, 0xED, 0xDE)));
        Assert.That(PKEY_StartDate.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Status"/> property is correct.</summary>
    [Test]
    public static void PKEY_StatusTest()
    {
        Assert.That(PKEY_Status.fmtid, Is.EqualTo(new Guid(0x000214A1, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46)));
        Assert.That(PKEY_Status.pid, Is.EqualTo(9));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_StorageProviderCallerVersionInformation"/> property is correct.</summary>
    [Test]
    public static void PKEY_StorageProviderCallerVersionInformationTest()
    {
        Assert.That(PKEY_StorageProviderCallerVersionInformation.fmtid, Is.EqualTo(new Guid(0xB2F9B9D6, 0xFEC4, 0x4DD5, 0x94, 0xD7, 0x89, 0x57, 0x48, 0x8C, 0x80, 0x7B)));
        Assert.That(PKEY_StorageProviderCallerVersionInformation.pid, Is.EqualTo(7));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_StorageProviderError"/> property is correct.</summary>
    [Test]
    public static void PKEY_StorageProviderErrorTest()
    {
        Assert.That(PKEY_StorageProviderError.fmtid, Is.EqualTo(new Guid(0xFCEFF153, 0xE839, 0x4CF3, 0xA9, 0xE7, 0xEA, 0x22, 0x83, 0x20, 0x94, 0xB8)));
        Assert.That(PKEY_StorageProviderError.pid, Is.EqualTo(109));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_StorageProviderFileChecksum"/> property is correct.</summary>
    [Test]
    public static void PKEY_StorageProviderFileChecksumTest()
    {
        Assert.That(PKEY_StorageProviderFileChecksum.fmtid, Is.EqualTo(new Guid(0xB2F9B9D6, 0xFEC4, 0x4DD5, 0x94, 0xD7, 0x89, 0x57, 0x48, 0x8C, 0x80, 0x7B)));
        Assert.That(PKEY_StorageProviderFileChecksum.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_StorageProviderFileFlags"/> property is correct.</summary>
    [Test]
    public static void PKEY_StorageProviderFileFlagsTest()
    {
        Assert.That(PKEY_StorageProviderFileFlags.fmtid, Is.EqualTo(new Guid(0xB2F9B9D6, 0xFEC4, 0x4DD5, 0x94, 0xD7, 0x89, 0x57, 0x48, 0x8C, 0x80, 0x7B)));
        Assert.That(PKEY_StorageProviderFileFlags.pid, Is.EqualTo(8));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_StorageProviderFileHasConflict"/> property is correct.</summary>
    [Test]
    public static void PKEY_StorageProviderFileHasConflictTest()
    {
        Assert.That(PKEY_StorageProviderFileHasConflict.fmtid, Is.EqualTo(new Guid(0xB2F9B9D6, 0xFEC4, 0x4DD5, 0x94, 0xD7, 0x89, 0x57, 0x48, 0x8C, 0x80, 0x7B)));
        Assert.That(PKEY_StorageProviderFileHasConflict.pid, Is.EqualTo(9));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_StorageProviderFileIdentifier"/> property is correct.</summary>
    [Test]
    public static void PKEY_StorageProviderFileIdentifierTest()
    {
        Assert.That(PKEY_StorageProviderFileIdentifier.fmtid, Is.EqualTo(new Guid(0xB2F9B9D6, 0xFEC4, 0x4DD5, 0x94, 0xD7, 0x89, 0x57, 0x48, 0x8C, 0x80, 0x7B)));
        Assert.That(PKEY_StorageProviderFileIdentifier.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_StorageProviderFileRemoteUri"/> property is correct.</summary>
    [Test]
    public static void PKEY_StorageProviderFileRemoteUriTest()
    {
        Assert.That(PKEY_StorageProviderFileRemoteUri.fmtid, Is.EqualTo(new Guid(0xFCEFF153, 0xE839, 0x4CF3, 0xA9, 0xE7, 0xEA, 0x22, 0x83, 0x20, 0x94, 0xB8)));
        Assert.That(PKEY_StorageProviderFileRemoteUri.pid, Is.EqualTo(112));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_StorageProviderFileVersion"/> property is correct.</summary>
    [Test]
    public static void PKEY_StorageProviderFileVersionTest()
    {
        Assert.That(PKEY_StorageProviderFileVersion.fmtid, Is.EqualTo(new Guid(0xB2F9B9D6, 0xFEC4, 0x4DD5, 0x94, 0xD7, 0x89, 0x57, 0x48, 0x8C, 0x80, 0x7B)));
        Assert.That(PKEY_StorageProviderFileVersion.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_StorageProviderFileVersionWaterline"/> property is correct.</summary>
    [Test]
    public static void PKEY_StorageProviderFileVersionWaterlineTest()
    {
        Assert.That(PKEY_StorageProviderFileVersionWaterline.fmtid, Is.EqualTo(new Guid(0xB2F9B9D6, 0xFEC4, 0x4DD5, 0x94, 0xD7, 0x89, 0x57, 0x48, 0x8C, 0x80, 0x7B)));
        Assert.That(PKEY_StorageProviderFileVersionWaterline.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_StorageProviderId"/> property is correct.</summary>
    [Test]
    public static void PKEY_StorageProviderIdTest()
    {
        Assert.That(PKEY_StorageProviderId.fmtid, Is.EqualTo(new Guid(0xFCEFF153, 0xE839, 0x4CF3, 0xA9, 0xE7, 0xEA, 0x22, 0x83, 0x20, 0x94, 0xB8)));
        Assert.That(PKEY_StorageProviderId.pid, Is.EqualTo(108));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_StorageProviderShareStatuses"/> property is correct.</summary>
    [Test]
    public static void PKEY_StorageProviderShareStatusesTest()
    {
        Assert.That(PKEY_StorageProviderShareStatuses.fmtid, Is.EqualTo(new Guid(0xFCEFF153, 0xE839, 0x4CF3, 0xA9, 0xE7, 0xEA, 0x22, 0x83, 0x20, 0x94, 0xB8)));
        Assert.That(PKEY_StorageProviderShareStatuses.pid, Is.EqualTo(111));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_StorageProviderSharingStatus"/> property is correct.</summary>
    [Test]
    public static void PKEY_StorageProviderSharingStatusTest()
    {
        Assert.That(PKEY_StorageProviderSharingStatus.fmtid, Is.EqualTo(new Guid(0xFCEFF153, 0xE839, 0x4CF3, 0xA9, 0xE7, 0xEA, 0x22, 0x83, 0x20, 0x94, 0xB8)));
        Assert.That(PKEY_StorageProviderSharingStatus.pid, Is.EqualTo(117));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_StorageProviderStatus"/> property is correct.</summary>
    [Test]
    public static void PKEY_StorageProviderStatusTest()
    {
        Assert.That(PKEY_StorageProviderStatus.fmtid, Is.EqualTo(new Guid(0xFCEFF153, 0xE839, 0x4CF3, 0xA9, 0xE7, 0xEA, 0x22, 0x83, 0x20, 0x94, 0xB8)));
        Assert.That(PKEY_StorageProviderStatus.pid, Is.EqualTo(110));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Subject"/> property is correct.</summary>
    [Test]
    public static void PKEY_SubjectTest()
    {
        Assert.That(PKEY_Subject.fmtid, Is.EqualTo(new Guid(0xF29F85E0, 0x4FF9, 0x1068, 0xAB, 0x91, 0x08, 0x00, 0x2B, 0x27, 0xB3, 0xD9)));
        Assert.That(PKEY_Subject.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_SyncTransferStatus"/> property is correct.</summary>
    [Test]
    public static void PKEY_SyncTransferStatusTest()
    {
        Assert.That(PKEY_SyncTransferStatus.fmtid, Is.EqualTo(new Guid(0xFCEFF153, 0xE839, 0x4CF3, 0xA9, 0xE7, 0xEA, 0x22, 0x83, 0x20, 0x94, 0xB8)));
        Assert.That(PKEY_SyncTransferStatus.pid, Is.EqualTo(103));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Thumbnail"/> property is correct.</summary>
    [Test]
    public static void PKEY_ThumbnailTest()
    {
        Assert.That(PKEY_Thumbnail.fmtid, Is.EqualTo(new Guid(0xF29F85E0, 0x4FF9, 0x1068, 0xAB, 0x91, 0x08, 0x00, 0x2B, 0x27, 0xB3, 0xD9)));
        Assert.That(PKEY_Thumbnail.pid, Is.EqualTo(17));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ThumbnailCacheId"/> property is correct.</summary>
    [Test]
    public static void PKEY_ThumbnailCacheIdTest()
    {
        Assert.That(PKEY_ThumbnailCacheId.fmtid, Is.EqualTo(new Guid(0x446D16B1, 0x8DAD, 0x4870, 0xA7, 0x48, 0x40, 0x2E, 0xA4, 0x3D, 0x78, 0x8C)));
        Assert.That(PKEY_ThumbnailCacheId.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ThumbnailStream"/> property is correct.</summary>
    [Test]
    public static void PKEY_ThumbnailStreamTest()
    {
        Assert.That(PKEY_ThumbnailStream.fmtid, Is.EqualTo(new Guid(0xF29F85E0, 0x4FF9, 0x1068, 0xAB, 0x91, 0x08, 0x00, 0x2B, 0x27, 0xB3, 0xD9)));
        Assert.That(PKEY_ThumbnailStream.pid, Is.EqualTo(27));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Title"/> property is correct.</summary>
    [Test]
    public static void PKEY_TitleTest()
    {
        Assert.That(PKEY_Title.fmtid, Is.EqualTo(new Guid(0xF29F85E0, 0x4FF9, 0x1068, 0xAB, 0x91, 0x08, 0x00, 0x2B, 0x27, 0xB3, 0xD9)));
        Assert.That(PKEY_Title.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_TitleSortOverride"/> property is correct.</summary>
    [Test]
    public static void PKEY_TitleSortOverrideTest()
    {
        Assert.That(PKEY_TitleSortOverride.fmtid, Is.EqualTo(new Guid(0xF0F7984D, 0x222E, 0x4AD2, 0x82, 0xAB, 0x1D, 0xD8, 0xEA, 0x40, 0xE5, 0x7E)));
        Assert.That(PKEY_TitleSortOverride.pid, Is.EqualTo(300));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_TotalFileSize"/> property is correct.</summary>
    [Test]
    public static void PKEY_TotalFileSizeTest()
    {
        Assert.That(PKEY_TotalFileSize.fmtid, Is.EqualTo(new Guid(0x28636AA6, 0x953D, 0x11D2, 0xB5, 0xD6, 0x00, 0xC0, 0x4F, 0xD9, 0x18, 0xD0)));
        Assert.That(PKEY_TotalFileSize.pid, Is.EqualTo(14));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Trademarks"/> property is correct.</summary>
    [Test]
    public static void PKEY_TrademarksTest()
    {
        Assert.That(PKEY_Trademarks.fmtid, Is.EqualTo(new Guid(0x0CEF7D53, 0xFA64, 0x11D1, 0xA2, 0x03, 0x00, 0x00, 0xF8, 0x1F, 0xED, 0xEE)));
        Assert.That(PKEY_Trademarks.pid, Is.EqualTo(9));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_TransferOrder"/> property is correct.</summary>
    [Test]
    public static void PKEY_TransferOrderTest()
    {
        Assert.That(PKEY_TransferOrder.fmtid, Is.EqualTo(new Guid(0xFCEFF153, 0xE839, 0x4CF3, 0xA9, 0xE7, 0xEA, 0x22, 0x83, 0x20, 0x94, 0xB8)));
        Assert.That(PKEY_TransferOrder.pid, Is.EqualTo(106));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_TransferPosition"/> property is correct.</summary>
    [Test]
    public static void PKEY_TransferPositionTest()
    {
        Assert.That(PKEY_TransferPosition.fmtid, Is.EqualTo(new Guid(0xFCEFF153, 0xE839, 0x4CF3, 0xA9, 0xE7, 0xEA, 0x22, 0x83, 0x20, 0x94, 0xB8)));
        Assert.That(PKEY_TransferPosition.pid, Is.EqualTo(104));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_TransferSize"/> property is correct.</summary>
    [Test]
    public static void PKEY_TransferSizeTest()
    {
        Assert.That(PKEY_TransferSize.fmtid, Is.EqualTo(new Guid(0xFCEFF153, 0xE839, 0x4CF3, 0xA9, 0xE7, 0xEA, 0x22, 0x83, 0x20, 0x94, 0xB8)));
        Assert.That(PKEY_TransferSize.pid, Is.EqualTo(105));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_VolumeId"/> property is correct.</summary>
    [Test]
    public static void PKEY_VolumeIdTest()
    {
        Assert.That(PKEY_VolumeId.fmtid, Is.EqualTo(new Guid(0x446D16B1, 0x8DAD, 0x4870, 0xA7, 0x48, 0x40, 0x2E, 0xA4, 0x3D, 0x78, 0x8C)));
        Assert.That(PKEY_VolumeId.pid, Is.EqualTo(104));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_ZoneIdentifier"/> property is correct.</summary>
    [Test]
    public static void PKEY_ZoneIdentifierTest()
    {
        Assert.That(PKEY_ZoneIdentifier.fmtid, Is.EqualTo(new Guid(0x502CFEAB, 0x47EB, 0x459C, 0xB9, 0x60, 0xE6, 0xD8, 0x72, 0x8F, 0x77, 0x01)));
        Assert.That(PKEY_ZoneIdentifier.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Device_PrinterURL"/> property is correct.</summary>
    [Test]
    public static void PKEY_Device_PrinterURLTest()
    {
        Assert.That(PKEY_Device_PrinterURL.fmtid, Is.EqualTo(new Guid(0x0B48F35A, 0xBE6E, 0x4F17, 0xB1, 0x08, 0x3C, 0x40, 0x73, 0xD1, 0x66, 0x9A)));
        Assert.That(PKEY_Device_PrinterURL.pid, Is.EqualTo(15));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_Bluetooth_DeviceAddress"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_Bluetooth_DeviceAddressTest()
    {
        Assert.That(PKEY_DeviceInterface_Bluetooth_DeviceAddress.fmtid, Is.EqualTo(new Guid(0x2BD67D8B, 0x8BEB, 0x48D5, 0x87, 0xE0, 0x6C, 0xDA, 0x34, 0x28, 0x04, 0x0A)));
        Assert.That(PKEY_DeviceInterface_Bluetooth_DeviceAddress.pid, Is.EqualTo(1));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_Bluetooth_Flags"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_Bluetooth_FlagsTest()
    {
        Assert.That(PKEY_DeviceInterface_Bluetooth_Flags.fmtid, Is.EqualTo(new Guid(0x2BD67D8B, 0x8BEB, 0x48D5, 0x87, 0xE0, 0x6C, 0xDA, 0x34, 0x28, 0x04, 0x0A)));
        Assert.That(PKEY_DeviceInterface_Bluetooth_Flags.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_Bluetooth_LastConnectedTime"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_Bluetooth_LastConnectedTimeTest()
    {
        Assert.That(PKEY_DeviceInterface_Bluetooth_LastConnectedTime.fmtid, Is.EqualTo(new Guid(0x2BD67D8B, 0x8BEB, 0x48D5, 0x87, 0xE0, 0x6C, 0xDA, 0x34, 0x28, 0x04, 0x0A)));
        Assert.That(PKEY_DeviceInterface_Bluetooth_LastConnectedTime.pid, Is.EqualTo(11));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_Bluetooth_Manufacturer"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_Bluetooth_ManufacturerTest()
    {
        Assert.That(PKEY_DeviceInterface_Bluetooth_Manufacturer.fmtid, Is.EqualTo(new Guid(0x2BD67D8B, 0x8BEB, 0x48D5, 0x87, 0xE0, 0x6C, 0xDA, 0x34, 0x28, 0x04, 0x0A)));
        Assert.That(PKEY_DeviceInterface_Bluetooth_Manufacturer.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_Bluetooth_ModelNumber"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_Bluetooth_ModelNumberTest()
    {
        Assert.That(PKEY_DeviceInterface_Bluetooth_ModelNumber.fmtid, Is.EqualTo(new Guid(0x2BD67D8B, 0x8BEB, 0x48D5, 0x87, 0xE0, 0x6C, 0xDA, 0x34, 0x28, 0x04, 0x0A)));
        Assert.That(PKEY_DeviceInterface_Bluetooth_ModelNumber.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_Bluetooth_ProductId"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_Bluetooth_ProductIdTest()
    {
        Assert.That(PKEY_DeviceInterface_Bluetooth_ProductId.fmtid, Is.EqualTo(new Guid(0x2BD67D8B, 0x8BEB, 0x48D5, 0x87, 0xE0, 0x6C, 0xDA, 0x34, 0x28, 0x04, 0x0A)));
        Assert.That(PKEY_DeviceInterface_Bluetooth_ProductId.pid, Is.EqualTo(8));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_Bluetooth_ProductVersion"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_Bluetooth_ProductVersionTest()
    {
        Assert.That(PKEY_DeviceInterface_Bluetooth_ProductVersion.fmtid, Is.EqualTo(new Guid(0x2BD67D8B, 0x8BEB, 0x48D5, 0x87, 0xE0, 0x6C, 0xDA, 0x34, 0x28, 0x04, 0x0A)));
        Assert.That(PKEY_DeviceInterface_Bluetooth_ProductVersion.pid, Is.EqualTo(9));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_Bluetooth_ServiceGuid"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_Bluetooth_ServiceGuidTest()
    {
        Assert.That(PKEY_DeviceInterface_Bluetooth_ServiceGuid.fmtid, Is.EqualTo(new Guid(0x2BD67D8B, 0x8BEB, 0x48D5, 0x87, 0xE0, 0x6C, 0xDA, 0x34, 0x28, 0x04, 0x0A)));
        Assert.That(PKEY_DeviceInterface_Bluetooth_ServiceGuid.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_Bluetooth_VendorId"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_Bluetooth_VendorIdTest()
    {
        Assert.That(PKEY_DeviceInterface_Bluetooth_VendorId.fmtid, Is.EqualTo(new Guid(0x2BD67D8B, 0x8BEB, 0x48D5, 0x87, 0xE0, 0x6C, 0xDA, 0x34, 0x28, 0x04, 0x0A)));
        Assert.That(PKEY_DeviceInterface_Bluetooth_VendorId.pid, Is.EqualTo(7));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_Bluetooth_VendorIdSource"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_Bluetooth_VendorIdSourceTest()
    {
        Assert.That(PKEY_DeviceInterface_Bluetooth_VendorIdSource.fmtid, Is.EqualTo(new Guid(0x2BD67D8B, 0x8BEB, 0x48D5, 0x87, 0xE0, 0x6C, 0xDA, 0x34, 0x28, 0x04, 0x0A)));
        Assert.That(PKEY_DeviceInterface_Bluetooth_VendorIdSource.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_Hid_IsReadOnly"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_Hid_IsReadOnlyTest()
    {
        Assert.That(PKEY_DeviceInterface_Hid_IsReadOnly.fmtid, Is.EqualTo(new Guid(0xCBF38310, 0x4A17, 0x4310, 0xA1, 0xEB, 0x24, 0x7F, 0x0B, 0x67, 0x59, 0x3B)));
        Assert.That(PKEY_DeviceInterface_Hid_IsReadOnly.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_Hid_ProductId"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_Hid_ProductIdTest()
    {
        Assert.That(PKEY_DeviceInterface_Hid_ProductId.fmtid, Is.EqualTo(new Guid(0xCBF38310, 0x4A17, 0x4310, 0xA1, 0xEB, 0x24, 0x7F, 0x0B, 0x67, 0x59, 0x3B)));
        Assert.That(PKEY_DeviceInterface_Hid_ProductId.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_Hid_UsageId"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_Hid_UsageIdTest()
    {
        Assert.That(PKEY_DeviceInterface_Hid_UsageId.fmtid, Is.EqualTo(new Guid(0xCBF38310, 0x4A17, 0x4310, 0xA1, 0xEB, 0x24, 0x7F, 0x0B, 0x67, 0x59, 0x3B)));
        Assert.That(PKEY_DeviceInterface_Hid_UsageId.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_Hid_UsagePage"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_Hid_UsagePageTest()
    {
        Assert.That(PKEY_DeviceInterface_Hid_UsagePage.fmtid, Is.EqualTo(new Guid(0xCBF38310, 0x4A17, 0x4310, 0xA1, 0xEB, 0x24, 0x7F, 0x0B, 0x67, 0x59, 0x3B)));
        Assert.That(PKEY_DeviceInterface_Hid_UsagePage.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_Hid_VendorId"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_Hid_VendorIdTest()
    {
        Assert.That(PKEY_DeviceInterface_Hid_VendorId.fmtid, Is.EqualTo(new Guid(0xCBF38310, 0x4A17, 0x4310, 0xA1, 0xEB, 0x24, 0x7F, 0x0B, 0x67, 0x59, 0x3B)));
        Assert.That(PKEY_DeviceInterface_Hid_VendorId.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_Hid_VersionNumber"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_Hid_VersionNumberTest()
    {
        Assert.That(PKEY_DeviceInterface_Hid_VersionNumber.fmtid, Is.EqualTo(new Guid(0xCBF38310, 0x4A17, 0x4310, 0xA1, 0xEB, 0x24, 0x7F, 0x0B, 0x67, 0x59, 0x3B)));
        Assert.That(PKEY_DeviceInterface_Hid_VersionNumber.pid, Is.EqualTo(7));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_PrinterDriverDirectory"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_PrinterDriverDirectoryTest()
    {
        Assert.That(PKEY_DeviceInterface_PrinterDriverDirectory.fmtid, Is.EqualTo(new Guid(0x847C66DE, 0xB8D6, 0x4AF9, 0xAB, 0xC3, 0x6F, 0x4F, 0x92, 0x6B, 0xC0, 0x39)));
        Assert.That(PKEY_DeviceInterface_PrinterDriverDirectory.pid, Is.EqualTo(14));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_PrinterDriverName"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_PrinterDriverNameTest()
    {
        Assert.That(PKEY_DeviceInterface_PrinterDriverName.fmtid, Is.EqualTo(new Guid(0xAFC47170, 0x14F5, 0x498C, 0x8F, 0x30, 0xB0, 0xD1, 0x9B, 0xE4, 0x49, 0xC6)));
        Assert.That(PKEY_DeviceInterface_PrinterDriverName.pid, Is.EqualTo(11));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_PrinterEnumerationFlag"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_PrinterEnumerationFlagTest()
    {
        Assert.That(PKEY_DeviceInterface_PrinterEnumerationFlag.fmtid, Is.EqualTo(new Guid(0xA00742A1, 0xCD8C, 0x4B37, 0x95, 0xAB, 0x70, 0x75, 0x55, 0x87, 0x76, 0x7A)));
        Assert.That(PKEY_DeviceInterface_PrinterEnumerationFlag.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_PrinterName"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_PrinterNameTest()
    {
        Assert.That(PKEY_DeviceInterface_PrinterName.fmtid, Is.EqualTo(new Guid(0x0A7B84EF, 0x0C27, 0x463F, 0x84, 0xEF, 0x06, 0xC5, 0x07, 0x00, 0x01, 0xBE)));
        Assert.That(PKEY_DeviceInterface_PrinterName.pid, Is.EqualTo(10));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_PrinterPortName"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_PrinterPortNameTest()
    {
        Assert.That(PKEY_DeviceInterface_PrinterPortName.fmtid, Is.EqualTo(new Guid(0xEEC7B761, 0x6F94, 0x41B1, 0x94, 0x9F, 0xC7, 0x29, 0x72, 0x0D, 0xD1, 0x3C)));
        Assert.That(PKEY_DeviceInterface_PrinterPortName.pid, Is.EqualTo(12));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_Proximity_SupportsNfc"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_Proximity_SupportsNfcTest()
    {
        Assert.That(PKEY_DeviceInterface_Proximity_SupportsNfc.fmtid, Is.EqualTo(new Guid(0xFB3842CD, 0x9E2A, 0x4F83, 0x8F, 0xCC, 0x4B, 0x07, 0x61, 0x13, 0x9A, 0xE9)));
        Assert.That(PKEY_DeviceInterface_Proximity_SupportsNfc.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_Serial_PortName"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_Serial_PortNameTest()
    {
        Assert.That(PKEY_DeviceInterface_Serial_PortName.fmtid, Is.EqualTo(new Guid(0x4C6BF15C, 0x4C03, 0x4AAC, 0x91, 0xF5, 0x64, 0xC0, 0xF8, 0x52, 0xBC, 0xF4)));
        Assert.That(PKEY_DeviceInterface_Serial_PortName.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_Serial_UsbProductId"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_Serial_UsbProductIdTest()
    {
        Assert.That(PKEY_DeviceInterface_Serial_UsbProductId.fmtid, Is.EqualTo(new Guid(0x4C6BF15C, 0x4C03, 0x4AAC, 0x91, 0xF5, 0x64, 0xC0, 0xF8, 0x52, 0xBC, 0xF4)));
        Assert.That(PKEY_DeviceInterface_Serial_UsbProductId.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_Serial_UsbVendorId"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_Serial_UsbVendorIdTest()
    {
        Assert.That(PKEY_DeviceInterface_Serial_UsbVendorId.fmtid, Is.EqualTo(new Guid(0x4C6BF15C, 0x4C03, 0x4AAC, 0x91, 0xF5, 0x64, 0xC0, 0xF8, 0x52, 0xBC, 0xF4)));
        Assert.That(PKEY_DeviceInterface_Serial_UsbVendorId.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_WinUsb_DeviceInterfaceClasses"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_WinUsb_DeviceInterfaceClassesTest()
    {
        Assert.That(PKEY_DeviceInterface_WinUsb_DeviceInterfaceClasses.fmtid, Is.EqualTo(new Guid(0x95E127B5, 0x79CC, 0x4E83, 0x9C, 0x9E, 0x84, 0x22, 0x18, 0x7B, 0x3E, 0x0E)));
        Assert.That(PKEY_DeviceInterface_WinUsb_DeviceInterfaceClasses.pid, Is.EqualTo(7));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_WinUsb_UsbClass"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_WinUsb_UsbClassTest()
    {
        Assert.That(PKEY_DeviceInterface_WinUsb_UsbClass.fmtid, Is.EqualTo(new Guid(0x95E127B5, 0x79CC, 0x4E83, 0x9C, 0x9E, 0x84, 0x22, 0x18, 0x7B, 0x3E, 0x0E)));
        Assert.That(PKEY_DeviceInterface_WinUsb_UsbClass.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_WinUsb_UsbProductId"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_WinUsb_UsbProductIdTest()
    {
        Assert.That(PKEY_DeviceInterface_WinUsb_UsbProductId.fmtid, Is.EqualTo(new Guid(0x95E127B5, 0x79CC, 0x4E83, 0x9C, 0x9E, 0x84, 0x22, 0x18, 0x7B, 0x3E, 0x0E)));
        Assert.That(PKEY_DeviceInterface_WinUsb_UsbProductId.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_WinUsb_UsbProtocol"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_WinUsb_UsbProtocolTest()
    {
        Assert.That(PKEY_DeviceInterface_WinUsb_UsbProtocol.fmtid, Is.EqualTo(new Guid(0x95E127B5, 0x79CC, 0x4E83, 0x9C, 0x9E, 0x84, 0x22, 0x18, 0x7B, 0x3E, 0x0E)));
        Assert.That(PKEY_DeviceInterface_WinUsb_UsbProtocol.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_WinUsb_UsbSubClass"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_WinUsb_UsbSubClassTest()
    {
        Assert.That(PKEY_DeviceInterface_WinUsb_UsbSubClass.fmtid, Is.EqualTo(new Guid(0x95E127B5, 0x79CC, 0x4E83, 0x9C, 0x9E, 0x84, 0x22, 0x18, 0x7B, 0x3E, 0x0E)));
        Assert.That(PKEY_DeviceInterface_WinUsb_UsbSubClass.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DeviceInterface_WinUsb_UsbVendorId"/> property is correct.</summary>
    [Test]
    public static void PKEY_DeviceInterface_WinUsb_UsbVendorIdTest()
    {
        Assert.That(PKEY_DeviceInterface_WinUsb_UsbVendorId.fmtid, Is.EqualTo(new Guid(0x95E127B5, 0x79CC, 0x4E83, 0x9C, 0x9E, 0x84, 0x22, 0x18, 0x7B, 0x3E, 0x0E)));
        Assert.That(PKEY_DeviceInterface_WinUsb_UsbVendorId.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_AepId"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_AepIdTest()
    {
        Assert.That(PKEY_Devices_Aep_AepId.fmtid, Is.EqualTo(new Guid(0x3B2CE006, 0x5E61, 0x4FDE, 0xBA, 0xB8, 0x9B, 0x8A, 0xAC, 0x9B, 0x26, 0xDF)));
        Assert.That(PKEY_Devices_Aep_AepId.pid, Is.EqualTo(8));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_Bluetooth_Cod_Major"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_Bluetooth_Cod_MajorTest()
    {
        Assert.That(PKEY_Devices_Aep_Bluetooth_Cod_Major.fmtid, Is.EqualTo(new Guid(0x5FBD34CD, 0x561A, 0x412E, 0xBA, 0x98, 0x47, 0x8A, 0x6B, 0x0F, 0xEF, 0x1D)));
        Assert.That(PKEY_Devices_Aep_Bluetooth_Cod_Major.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_Bluetooth_Cod_Minor"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_Bluetooth_Cod_MinorTest()
    {
        Assert.That(PKEY_Devices_Aep_Bluetooth_Cod_Minor.fmtid, Is.EqualTo(new Guid(0x5FBD34CD, 0x561A, 0x412E, 0xBA, 0x98, 0x47, 0x8A, 0x6B, 0x0F, 0xEF, 0x1D)));
        Assert.That(PKEY_Devices_Aep_Bluetooth_Cod_Minor.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_Bluetooth_Cod_Services_Audio"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_Bluetooth_Cod_Services_AudioTest()
    {
        Assert.That(PKEY_Devices_Aep_Bluetooth_Cod_Services_Audio.fmtid, Is.EqualTo(new Guid(0x5FBD34CD, 0x561A, 0x412E, 0xBA, 0x98, 0x47, 0x8A, 0x6B, 0x0F, 0xEF, 0x1D)));
        Assert.That(PKEY_Devices_Aep_Bluetooth_Cod_Services_Audio.pid, Is.EqualTo(10));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_Bluetooth_Cod_Services_Capturing"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_Bluetooth_Cod_Services_CapturingTest()
    {
        Assert.That(PKEY_Devices_Aep_Bluetooth_Cod_Services_Capturing.fmtid, Is.EqualTo(new Guid(0x5FBD34CD, 0x561A, 0x412E, 0xBA, 0x98, 0x47, 0x8A, 0x6B, 0x0F, 0xEF, 0x1D)));
        Assert.That(PKEY_Devices_Aep_Bluetooth_Cod_Services_Capturing.pid, Is.EqualTo(8));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_Bluetooth_Cod_Services_Information"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_Bluetooth_Cod_Services_InformationTest()
    {
        Assert.That(PKEY_Devices_Aep_Bluetooth_Cod_Services_Information.fmtid, Is.EqualTo(new Guid(0x5FBD34CD, 0x561A, 0x412E, 0xBA, 0x98, 0x47, 0x8A, 0x6B, 0x0F, 0xEF, 0x1D)));
        Assert.That(PKEY_Devices_Aep_Bluetooth_Cod_Services_Information.pid, Is.EqualTo(12));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_Bluetooth_Cod_Services_LimitedDiscovery"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_Bluetooth_Cod_Services_LimitedDiscoveryTest()
    {
        Assert.That(PKEY_Devices_Aep_Bluetooth_Cod_Services_LimitedDiscovery.fmtid, Is.EqualTo(new Guid(0x5FBD34CD, 0x561A, 0x412E, 0xBA, 0x98, 0x47, 0x8A, 0x6B, 0x0F, 0xEF, 0x1D)));
        Assert.That(PKEY_Devices_Aep_Bluetooth_Cod_Services_LimitedDiscovery.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_Bluetooth_Cod_Services_Networking"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_Bluetooth_Cod_Services_NetworkingTest()
    {
        Assert.That(PKEY_Devices_Aep_Bluetooth_Cod_Services_Networking.fmtid, Is.EqualTo(new Guid(0x5FBD34CD, 0x561A, 0x412E, 0xBA, 0x98, 0x47, 0x8A, 0x6B, 0x0F, 0xEF, 0x1D)));
        Assert.That(PKEY_Devices_Aep_Bluetooth_Cod_Services_Networking.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_Bluetooth_Cod_Services_ObjectXfer"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_Bluetooth_Cod_Services_ObjectXferTest()
    {
        Assert.That(PKEY_Devices_Aep_Bluetooth_Cod_Services_ObjectXfer.fmtid, Is.EqualTo(new Guid(0x5FBD34CD, 0x561A, 0x412E, 0xBA, 0x98, 0x47, 0x8A, 0x6B, 0x0F, 0xEF, 0x1D)));
        Assert.That(PKEY_Devices_Aep_Bluetooth_Cod_Services_ObjectXfer.pid, Is.EqualTo(9));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_Bluetooth_Cod_Services_Positioning"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_Bluetooth_Cod_Services_PositioningTest()
    {
        Assert.That(PKEY_Devices_Aep_Bluetooth_Cod_Services_Positioning.fmtid, Is.EqualTo(new Guid(0x5FBD34CD, 0x561A, 0x412E, 0xBA, 0x98, 0x47, 0x8A, 0x6B, 0x0F, 0xEF, 0x1D)));
        Assert.That(PKEY_Devices_Aep_Bluetooth_Cod_Services_Positioning.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_Bluetooth_Cod_Services_Rendering"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_Bluetooth_Cod_Services_RenderingTest()
    {
        Assert.That(PKEY_Devices_Aep_Bluetooth_Cod_Services_Rendering.fmtid, Is.EqualTo(new Guid(0x5FBD34CD, 0x561A, 0x412E, 0xBA, 0x98, 0x47, 0x8A, 0x6B, 0x0F, 0xEF, 0x1D)));
        Assert.That(PKEY_Devices_Aep_Bluetooth_Cod_Services_Rendering.pid, Is.EqualTo(7));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_Bluetooth_Cod_Services_Telephony"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_Bluetooth_Cod_Services_TelephonyTest()
    {
        Assert.That(PKEY_Devices_Aep_Bluetooth_Cod_Services_Telephony.fmtid, Is.EqualTo(new Guid(0x5FBD34CD, 0x561A, 0x412E, 0xBA, 0x98, 0x47, 0x8A, 0x6B, 0x0F, 0xEF, 0x1D)));
        Assert.That(PKEY_Devices_Aep_Bluetooth_Cod_Services_Telephony.pid, Is.EqualTo(11));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_Bluetooth_LastSeenTime"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_Bluetooth_LastSeenTimeTest()
    {
        Assert.That(PKEY_Devices_Aep_Bluetooth_LastSeenTime.fmtid, Is.EqualTo(new Guid(0x2BD67D8B, 0x8BEB, 0x48D5, 0x87, 0xE0, 0x6C, 0xDA, 0x34, 0x28, 0x04, 0x0A)));
        Assert.That(PKEY_Devices_Aep_Bluetooth_LastSeenTime.pid, Is.EqualTo(12));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_Bluetooth_Le_AddressType"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_Bluetooth_Le_AddressTypeTest()
    {
        Assert.That(PKEY_Devices_Aep_Bluetooth_Le_AddressType.fmtid, Is.EqualTo(new Guid(0x995EF0B0, 0x7EB3, 0x4A8B, 0xB9, 0xCE, 0x06, 0x8B, 0xB3, 0xF4, 0xAF, 0x69)));
        Assert.That(PKEY_Devices_Aep_Bluetooth_Le_AddressType.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_Bluetooth_Le_Appearance"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_Bluetooth_Le_AppearanceTest()
    {
        Assert.That(PKEY_Devices_Aep_Bluetooth_Le_Appearance.fmtid, Is.EqualTo(new Guid(0x995EF0B0, 0x7EB3, 0x4A8B, 0xB9, 0xCE, 0x06, 0x8B, 0xB3, 0xF4, 0xAF, 0x69)));
        Assert.That(PKEY_Devices_Aep_Bluetooth_Le_Appearance.pid, Is.EqualTo(1));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_Bluetooth_Le_Appearance_Category"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_Bluetooth_Le_Appearance_CategoryTest()
    {
        Assert.That(PKEY_Devices_Aep_Bluetooth_Le_Appearance_Category.fmtid, Is.EqualTo(new Guid(0x995EF0B0, 0x7EB3, 0x4A8B, 0xB9, 0xCE, 0x06, 0x8B, 0xB3, 0xF4, 0xAF, 0x69)));
        Assert.That(PKEY_Devices_Aep_Bluetooth_Le_Appearance_Category.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_Bluetooth_Le_Appearance_Subcategory"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_Bluetooth_Le_Appearance_SubcategoryTest()
    {
        Assert.That(PKEY_Devices_Aep_Bluetooth_Le_Appearance_Subcategory.fmtid, Is.EqualTo(new Guid(0x995EF0B0, 0x7EB3, 0x4A8B, 0xB9, 0xCE, 0x06, 0x8B, 0xB3, 0xF4, 0xAF, 0x69)));
        Assert.That(PKEY_Devices_Aep_Bluetooth_Le_Appearance_Subcategory.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_Bluetooth_Le_IsConnectable"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_Bluetooth_Le_IsConnectableTest()
    {
        Assert.That(PKEY_Devices_Aep_Bluetooth_Le_IsConnectable.fmtid, Is.EqualTo(new Guid(0x995EF0B0, 0x7EB3, 0x4A8B, 0xB9, 0xCE, 0x06, 0x8B, 0xB3, 0xF4, 0xAF, 0x69)));
        Assert.That(PKEY_Devices_Aep_Bluetooth_Le_IsConnectable.pid, Is.EqualTo(8));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_CanPair"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_CanPairTest()
    {
        Assert.That(PKEY_Devices_Aep_CanPair.fmtid, Is.EqualTo(new Guid(0xE7C3FB29, 0xCAA7, 0x4F47, 0x8C, 0x8B, 0xBE, 0x59, 0xB3, 0x30, 0xD4, 0xC5)));
        Assert.That(PKEY_Devices_Aep_CanPair.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_Category"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_CategoryTest()
    {
        Assert.That(PKEY_Devices_Aep_Category.fmtid, Is.EqualTo(new Guid(0xA35996AB, 0x11CF, 0x4935, 0x8B, 0x61, 0xA6, 0x76, 0x10, 0x81, 0xEC, 0xDF)));
        Assert.That(PKEY_Devices_Aep_Category.pid, Is.EqualTo(17));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_ContainerId"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_ContainerIdTest()
    {
        Assert.That(PKEY_Devices_Aep_ContainerId.fmtid, Is.EqualTo(new Guid(0xE7C3FB29, 0xCAA7, 0x4F47, 0x8C, 0x8B, 0xBE, 0x59, 0xB3, 0x30, 0xD4, 0xC5)));
        Assert.That(PKEY_Devices_Aep_ContainerId.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_DeviceAddress"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_DeviceAddressTest()
    {
        Assert.That(PKEY_Devices_Aep_DeviceAddress.fmtid, Is.EqualTo(new Guid(0xA35996AB, 0x11CF, 0x4935, 0x8B, 0x61, 0xA6, 0x76, 0x10, 0x81, 0xEC, 0xDF)));
        Assert.That(PKEY_Devices_Aep_DeviceAddress.pid, Is.EqualTo(12));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_IsConnected"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_IsConnectedTest()
    {
        Assert.That(PKEY_Devices_Aep_IsConnected.fmtid, Is.EqualTo(new Guid(0xA35996AB, 0x11CF, 0x4935, 0x8B, 0x61, 0xA6, 0x76, 0x10, 0x81, 0xEC, 0xDF)));
        Assert.That(PKEY_Devices_Aep_IsConnected.pid, Is.EqualTo(7));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_IsPaired"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_IsPairedTest()
    {
        Assert.That(PKEY_Devices_Aep_IsPaired.fmtid, Is.EqualTo(new Guid(0xA35996AB, 0x11CF, 0x4935, 0x8B, 0x61, 0xA6, 0x76, 0x10, 0x81, 0xEC, 0xDF)));
        Assert.That(PKEY_Devices_Aep_IsPaired.pid, Is.EqualTo(16));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_IsPresent"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_IsPresentTest()
    {
        Assert.That(PKEY_Devices_Aep_IsPresent.fmtid, Is.EqualTo(new Guid(0xA35996AB, 0x11CF, 0x4935, 0x8B, 0x61, 0xA6, 0x76, 0x10, 0x81, 0xEC, 0xDF)));
        Assert.That(PKEY_Devices_Aep_IsPresent.pid, Is.EqualTo(9));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_Manufacturer"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_ManufacturerTest()
    {
        Assert.That(PKEY_Devices_Aep_Manufacturer.fmtid, Is.EqualTo(new Guid(0xA35996AB, 0x11CF, 0x4935, 0x8B, 0x61, 0xA6, 0x76, 0x10, 0x81, 0xEC, 0xDF)));
        Assert.That(PKEY_Devices_Aep_Manufacturer.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_ModelId"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_ModelIdTest()
    {
        Assert.That(PKEY_Devices_Aep_ModelId.fmtid, Is.EqualTo(new Guid(0xA35996AB, 0x11CF, 0x4935, 0x8B, 0x61, 0xA6, 0x76, 0x10, 0x81, 0xEC, 0xDF)));
        Assert.That(PKEY_Devices_Aep_ModelId.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_ModelName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_ModelNameTest()
    {
        Assert.That(PKEY_Devices_Aep_ModelName.fmtid, Is.EqualTo(new Guid(0xA35996AB, 0x11CF, 0x4935, 0x8B, 0x61, 0xA6, 0x76, 0x10, 0x81, 0xEC, 0xDF)));
        Assert.That(PKEY_Devices_Aep_ModelName.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_PointOfService_ConnectionTypes"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_PointOfService_ConnectionTypesTest()
    {
        Assert.That(PKEY_Devices_Aep_PointOfService_ConnectionTypes.fmtid, Is.EqualTo(new Guid(0xD4BF61B3, 0x442E, 0x4ADA, 0x88, 0x2D, 0xFA, 0x7B, 0x70, 0xC8, 0x32, 0xD9)));
        Assert.That(PKEY_Devices_Aep_PointOfService_ConnectionTypes.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_ProtocolId"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_ProtocolIdTest()
    {
        Assert.That(PKEY_Devices_Aep_ProtocolId.fmtid, Is.EqualTo(new Guid(0x3B2CE006, 0x5E61, 0x4FDE, 0xBA, 0xB8, 0x9B, 0x8A, 0xAC, 0x9B, 0x26, 0xDF)));
        Assert.That(PKEY_Devices_Aep_ProtocolId.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Aep_SignalStrength"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Aep_SignalStrengthTest()
    {
        Assert.That(PKEY_Devices_Aep_SignalStrength.fmtid, Is.EqualTo(new Guid(0xA35996AB, 0x11CF, 0x4935, 0x8B, 0x61, 0xA6, 0x76, 0x10, 0x81, 0xEC, 0xDF)));
        Assert.That(PKEY_Devices_Aep_SignalStrength.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepContainer_CanPair"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepContainer_CanPairTest()
    {
        Assert.That(PKEY_Devices_AepContainer_CanPair.fmtid, Is.EqualTo(new Guid(0x0BBA1EDE, 0x7566, 0x4F47, 0x90, 0xEC, 0x25, 0xFC, 0x56, 0x7C, 0xED, 0x2A)));
        Assert.That(PKEY_Devices_AepContainer_CanPair.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepContainer_Categories"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepContainer_CategoriesTest()
    {
        Assert.That(PKEY_Devices_AepContainer_Categories.fmtid, Is.EqualTo(new Guid(0x0BBA1EDE, 0x7566, 0x4F47, 0x90, 0xEC, 0x25, 0xFC, 0x56, 0x7C, 0xED, 0x2A)));
        Assert.That(PKEY_Devices_AepContainer_Categories.pid, Is.EqualTo(9));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepContainer_Children"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepContainer_ChildrenTest()
    {
        Assert.That(PKEY_Devices_AepContainer_Children.fmtid, Is.EqualTo(new Guid(0x0BBA1EDE, 0x7566, 0x4F47, 0x90, 0xEC, 0x25, 0xFC, 0x56, 0x7C, 0xED, 0x2A)));
        Assert.That(PKEY_Devices_AepContainer_Children.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepContainer_ContainerId"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepContainer_ContainerIdTest()
    {
        Assert.That(PKEY_Devices_AepContainer_ContainerId.fmtid, Is.EqualTo(new Guid(0x0BBA1EDE, 0x7566, 0x4F47, 0x90, 0xEC, 0x25, 0xFC, 0x56, 0x7C, 0xED, 0x2A)));
        Assert.That(PKEY_Devices_AepContainer_ContainerId.pid, Is.EqualTo(12));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepContainer_DialProtocol_InstalledApplications"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepContainer_DialProtocol_InstalledApplicationsTest()
    {
        Assert.That(PKEY_Devices_AepContainer_DialProtocol_InstalledApplications.fmtid, Is.EqualTo(new Guid(0x6AF55D45, 0x38DB, 0x4495, 0xAC, 0xB0, 0xD4, 0x72, 0x8A, 0x3B, 0x83, 0x14)));
        Assert.That(PKEY_Devices_AepContainer_DialProtocol_InstalledApplications.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepContainer_IsPaired"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepContainer_IsPairedTest()
    {
        Assert.That(PKEY_Devices_AepContainer_IsPaired.fmtid, Is.EqualTo(new Guid(0x0BBA1EDE, 0x7566, 0x4F47, 0x90, 0xEC, 0x25, 0xFC, 0x56, 0x7C, 0xED, 0x2A)));
        Assert.That(PKEY_Devices_AepContainer_IsPaired.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepContainer_IsPresent"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepContainer_IsPresentTest()
    {
        Assert.That(PKEY_Devices_AepContainer_IsPresent.fmtid, Is.EqualTo(new Guid(0x0BBA1EDE, 0x7566, 0x4F47, 0x90, 0xEC, 0x25, 0xFC, 0x56, 0x7C, 0xED, 0x2A)));
        Assert.That(PKEY_Devices_AepContainer_IsPresent.pid, Is.EqualTo(11));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepContainer_Manufacturer"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepContainer_ManufacturerTest()
    {
        Assert.That(PKEY_Devices_AepContainer_Manufacturer.fmtid, Is.EqualTo(new Guid(0x0BBA1EDE, 0x7566, 0x4F47, 0x90, 0xEC, 0x25, 0xFC, 0x56, 0x7C, 0xED, 0x2A)));
        Assert.That(PKEY_Devices_AepContainer_Manufacturer.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepContainer_ModelIds"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepContainer_ModelIdsTest()
    {
        Assert.That(PKEY_Devices_AepContainer_ModelIds.fmtid, Is.EqualTo(new Guid(0x0BBA1EDE, 0x7566, 0x4F47, 0x90, 0xEC, 0x25, 0xFC, 0x56, 0x7C, 0xED, 0x2A)));
        Assert.That(PKEY_Devices_AepContainer_ModelIds.pid, Is.EqualTo(8));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepContainer_ModelName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepContainer_ModelNameTest()
    {
        Assert.That(PKEY_Devices_AepContainer_ModelName.fmtid, Is.EqualTo(new Guid(0x0BBA1EDE, 0x7566, 0x4F47, 0x90, 0xEC, 0x25, 0xFC, 0x56, 0x7C, 0xED, 0x2A)));
        Assert.That(PKEY_Devices_AepContainer_ModelName.pid, Is.EqualTo(7));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepContainer_ProtocolIds"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepContainer_ProtocolIdsTest()
    {
        Assert.That(PKEY_Devices_AepContainer_ProtocolIds.fmtid, Is.EqualTo(new Guid(0x0BBA1EDE, 0x7566, 0x4F47, 0x90, 0xEC, 0x25, 0xFC, 0x56, 0x7C, 0xED, 0x2A)));
        Assert.That(PKEY_Devices_AepContainer_ProtocolIds.pid, Is.EqualTo(13));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepContainer_SupportedUriSchemes"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepContainer_SupportedUriSchemesTest()
    {
        Assert.That(PKEY_Devices_AepContainer_SupportedUriSchemes.fmtid, Is.EqualTo(new Guid(0x6AF55D45, 0x38DB, 0x4495, 0xAC, 0xB0, 0xD4, 0x72, 0x8A, 0x3B, 0x83, 0x14)));
        Assert.That(PKEY_Devices_AepContainer_SupportedUriSchemes.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepContainer_SupportsAudio"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepContainer_SupportsAudioTest()
    {
        Assert.That(PKEY_Devices_AepContainer_SupportsAudio.fmtid, Is.EqualTo(new Guid(0x6AF55D45, 0x38DB, 0x4495, 0xAC, 0xB0, 0xD4, 0x72, 0x8A, 0x3B, 0x83, 0x14)));
        Assert.That(PKEY_Devices_AepContainer_SupportsAudio.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepContainer_SupportsCapturing"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepContainer_SupportsCapturingTest()
    {
        Assert.That(PKEY_Devices_AepContainer_SupportsCapturing.fmtid, Is.EqualTo(new Guid(0x6AF55D45, 0x38DB, 0x4495, 0xAC, 0xB0, 0xD4, 0x72, 0x8A, 0x3B, 0x83, 0x14)));
        Assert.That(PKEY_Devices_AepContainer_SupportsCapturing.pid, Is.EqualTo(11));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepContainer_SupportsImages"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepContainer_SupportsImagesTest()
    {
        Assert.That(PKEY_Devices_AepContainer_SupportsImages.fmtid, Is.EqualTo(new Guid(0x6AF55D45, 0x38DB, 0x4495, 0xAC, 0xB0, 0xD4, 0x72, 0x8A, 0x3B, 0x83, 0x14)));
        Assert.That(PKEY_Devices_AepContainer_SupportsImages.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepContainer_SupportsInformation"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepContainer_SupportsInformationTest()
    {
        Assert.That(PKEY_Devices_AepContainer_SupportsInformation.fmtid, Is.EqualTo(new Guid(0x6AF55D45, 0x38DB, 0x4495, 0xAC, 0xB0, 0xD4, 0x72, 0x8A, 0x3B, 0x83, 0x14)));
        Assert.That(PKEY_Devices_AepContainer_SupportsInformation.pid, Is.EqualTo(14));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepContainer_SupportsLimitedDiscovery"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepContainer_SupportsLimitedDiscoveryTest()
    {
        Assert.That(PKEY_Devices_AepContainer_SupportsLimitedDiscovery.fmtid, Is.EqualTo(new Guid(0x6AF55D45, 0x38DB, 0x4495, 0xAC, 0xB0, 0xD4, 0x72, 0x8A, 0x3B, 0x83, 0x14)));
        Assert.That(PKEY_Devices_AepContainer_SupportsLimitedDiscovery.pid, Is.EqualTo(7));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepContainer_SupportsNetworking"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepContainer_SupportsNetworkingTest()
    {
        Assert.That(PKEY_Devices_AepContainer_SupportsNetworking.fmtid, Is.EqualTo(new Guid(0x6AF55D45, 0x38DB, 0x4495, 0xAC, 0xB0, 0xD4, 0x72, 0x8A, 0x3B, 0x83, 0x14)));
        Assert.That(PKEY_Devices_AepContainer_SupportsNetworking.pid, Is.EqualTo(9));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepContainer_SupportsObjectTransfer"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepContainer_SupportsObjectTransferTest()
    {
        Assert.That(PKEY_Devices_AepContainer_SupportsObjectTransfer.fmtid, Is.EqualTo(new Guid(0x6AF55D45, 0x38DB, 0x4495, 0xAC, 0xB0, 0xD4, 0x72, 0x8A, 0x3B, 0x83, 0x14)));
        Assert.That(PKEY_Devices_AepContainer_SupportsObjectTransfer.pid, Is.EqualTo(12));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepContainer_SupportsPositioning"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepContainer_SupportsPositioningTest()
    {
        Assert.That(PKEY_Devices_AepContainer_SupportsPositioning.fmtid, Is.EqualTo(new Guid(0x6AF55D45, 0x38DB, 0x4495, 0xAC, 0xB0, 0xD4, 0x72, 0x8A, 0x3B, 0x83, 0x14)));
        Assert.That(PKEY_Devices_AepContainer_SupportsPositioning.pid, Is.EqualTo(8));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepContainer_SupportsRendering"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepContainer_SupportsRenderingTest()
    {
        Assert.That(PKEY_Devices_AepContainer_SupportsRendering.fmtid, Is.EqualTo(new Guid(0x6AF55D45, 0x38DB, 0x4495, 0xAC, 0xB0, 0xD4, 0x72, 0x8A, 0x3B, 0x83, 0x14)));
        Assert.That(PKEY_Devices_AepContainer_SupportsRendering.pid, Is.EqualTo(10));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepContainer_SupportsTelephony"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepContainer_SupportsTelephonyTest()
    {
        Assert.That(PKEY_Devices_AepContainer_SupportsTelephony.fmtid, Is.EqualTo(new Guid(0x6AF55D45, 0x38DB, 0x4495, 0xAC, 0xB0, 0xD4, 0x72, 0x8A, 0x3B, 0x83, 0x14)));
        Assert.That(PKEY_Devices_AepContainer_SupportsTelephony.pid, Is.EqualTo(13));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepContainer_SupportsVideo"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepContainer_SupportsVideoTest()
    {
        Assert.That(PKEY_Devices_AepContainer_SupportsVideo.fmtid, Is.EqualTo(new Guid(0x6AF55D45, 0x38DB, 0x4495, 0xAC, 0xB0, 0xD4, 0x72, 0x8A, 0x3B, 0x83, 0x14)));
        Assert.That(PKEY_Devices_AepContainer_SupportsVideo.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepService_AepId"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepService_AepIdTest()
    {
        Assert.That(PKEY_Devices_AepService_AepId.fmtid, Is.EqualTo(new Guid(0xC9C141A9, 0x1B4C, 0x4F17, 0xA9, 0xD1, 0xF2, 0x98, 0x53, 0x8C, 0xAD, 0xB8)));
        Assert.That(PKEY_Devices_AepService_AepId.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepService_Bluetooth_CacheMode"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepService_Bluetooth_CacheModeTest()
    {
        Assert.That(PKEY_Devices_AepService_Bluetooth_CacheMode.fmtid, Is.EqualTo(new Guid(0x9744311E, 0x7951, 0x4B2E, 0xB6, 0xF0, 0xEC, 0xB2, 0x93, 0xCA, 0xC1, 0x19)));
        Assert.That(PKEY_Devices_AepService_Bluetooth_CacheMode.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepService_Bluetooth_ServiceGuid"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepService_Bluetooth_ServiceGuidTest()
    {
        Assert.That(PKEY_Devices_AepService_Bluetooth_ServiceGuid.fmtid, Is.EqualTo(new Guid(0xA399AAC7, 0xC265, 0x474E, 0xB0, 0x73, 0xFF, 0xCE, 0x57, 0x72, 0x17, 0x16)));
        Assert.That(PKEY_Devices_AepService_Bluetooth_ServiceGuid.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepService_Bluetooth_TargetDevice"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepService_Bluetooth_TargetDeviceTest()
    {
        Assert.That(PKEY_Devices_AepService_Bluetooth_TargetDevice.fmtid, Is.EqualTo(new Guid(0x9744311E, 0x7951, 0x4B2E, 0xB6, 0xF0, 0xEC, 0xB2, 0x93, 0xCA, 0xC1, 0x19)));
        Assert.That(PKEY_Devices_AepService_Bluetooth_TargetDevice.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepService_ContainerId"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepService_ContainerIdTest()
    {
        Assert.That(PKEY_Devices_AepService_ContainerId.fmtid, Is.EqualTo(new Guid(0x71724756, 0x3E74, 0x4432, 0x9B, 0x59, 0xE7, 0xB2, 0xF6, 0x68, 0xA5, 0x93)));
        Assert.That(PKEY_Devices_AepService_ContainerId.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepService_FriendlyName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepService_FriendlyNameTest()
    {
        Assert.That(PKEY_Devices_AepService_FriendlyName.fmtid, Is.EqualTo(new Guid(0x71724756, 0x3E74, 0x4432, 0x9B, 0x59, 0xE7, 0xB2, 0xF6, 0x68, 0xA5, 0x93)));
        Assert.That(PKEY_Devices_AepService_FriendlyName.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepService_IoT_ServiceInterfaces"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepService_IoT_ServiceInterfacesTest()
    {
        Assert.That(PKEY_Devices_AepService_IoT_ServiceInterfaces.fmtid, Is.EqualTo(new Guid(0x79D94E82, 0x4D79, 0x45AA, 0x82, 0x1A, 0x74, 0x85, 0x8B, 0x4E, 0x4C, 0xA6)));
        Assert.That(PKEY_Devices_AepService_IoT_ServiceInterfaces.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepService_ParentAepIsPaired"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepService_ParentAepIsPairedTest()
    {
        Assert.That(PKEY_Devices_AepService_ParentAepIsPaired.fmtid, Is.EqualTo(new Guid(0xC9C141A9, 0x1B4C, 0x4F17, 0xA9, 0xD1, 0xF2, 0x98, 0x53, 0x8C, 0xAD, 0xB8)));
        Assert.That(PKEY_Devices_AepService_ParentAepIsPaired.pid, Is.EqualTo(7));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepService_ProtocolId"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepService_ProtocolIdTest()
    {
        Assert.That(PKEY_Devices_AepService_ProtocolId.fmtid, Is.EqualTo(new Guid(0xC9C141A9, 0x1B4C, 0x4F17, 0xA9, 0xD1, 0xF2, 0x98, 0x53, 0x8C, 0xAD, 0xB8)));
        Assert.That(PKEY_Devices_AepService_ProtocolId.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepService_ServiceClassId"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepService_ServiceClassIdTest()
    {
        Assert.That(PKEY_Devices_AepService_ServiceClassId.fmtid, Is.EqualTo(new Guid(0x71724756, 0x3E74, 0x4432, 0x9B, 0x59, 0xE7, 0xB2, 0xF6, 0x68, 0xA5, 0x93)));
        Assert.That(PKEY_Devices_AepService_ServiceClassId.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AepService_ServiceId"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AepService_ServiceIdTest()
    {
        Assert.That(PKEY_Devices_AepService_ServiceId.fmtid, Is.EqualTo(new Guid(0xC9C141A9, 0x1B4C, 0x4F17, 0xA9, 0xD1, 0xF2, 0x98, 0x53, 0x8C, 0xAD, 0xB8)));
        Assert.That(PKEY_Devices_AepService_ServiceId.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AppPackageFamilyName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AppPackageFamilyNameTest()
    {
        Assert.That(PKEY_Devices_AppPackageFamilyName.fmtid, Is.EqualTo(new Guid(0x51236583, 0x0C4A, 0x4FE8, 0xB8, 0x1F, 0x16, 0x6A, 0xEC, 0x13, 0xF5, 0x10)));
        Assert.That(PKEY_Devices_AppPackageFamilyName.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AudioDevice_Microphone_IsFarField"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AudioDevice_Microphone_IsFarFieldTest()
    {
        Assert.That(PKEY_Devices_AudioDevice_Microphone_IsFarField.fmtid, Is.EqualTo(new Guid(0x8943B373, 0x388C, 0x4395, 0xB5, 0x57, 0xBC, 0x6D, 0xBA, 0xFF, 0xAF, 0xDB)));
        Assert.That(PKEY_Devices_AudioDevice_Microphone_IsFarField.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AudioDevice_Microphone_SensitivityInDbfs"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AudioDevice_Microphone_SensitivityInDbfsTest()
    {
        Assert.That(PKEY_Devices_AudioDevice_Microphone_SensitivityInDbfs.fmtid, Is.EqualTo(new Guid(0x8943B373, 0x388C, 0x4395, 0xB5, 0x57, 0xBC, 0x6D, 0xBA, 0xFF, 0xAF, 0xDB)));
        Assert.That(PKEY_Devices_AudioDevice_Microphone_SensitivityInDbfs.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AudioDevice_Microphone_SensitivityInDbfs2"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AudioDevice_Microphone_SensitivityInDbfs2Test()
    {
        Assert.That(PKEY_Devices_AudioDevice_Microphone_SensitivityInDbfs2.fmtid, Is.EqualTo(new Guid(0x8943B373, 0x388C, 0x4395, 0xB5, 0x57, 0xBC, 0x6D, 0xBA, 0xFF, 0xAF, 0xDB)));
        Assert.That(PKEY_Devices_AudioDevice_Microphone_SensitivityInDbfs2.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AudioDevice_Microphone_SignalToNoiseRatioInDb"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AudioDevice_Microphone_SignalToNoiseRatioInDbTest()
    {
        Assert.That(PKEY_Devices_AudioDevice_Microphone_SignalToNoiseRatioInDb.fmtid, Is.EqualTo(new Guid(0x8943B373, 0x388C, 0x4395, 0xB5, 0x57, 0xBC, 0x6D, 0xBA, 0xFF, 0xAF, 0xDB)));
        Assert.That(PKEY_Devices_AudioDevice_Microphone_SignalToNoiseRatioInDb.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AudioDevice_RawProcessingSupported"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AudioDevice_RawProcessingSupportedTest()
    {
        Assert.That(PKEY_Devices_AudioDevice_RawProcessingSupported.fmtid, Is.EqualTo(new Guid(0x8943B373, 0x388C, 0x4395, 0xB5, 0x57, 0xBC, 0x6D, 0xBA, 0xFF, 0xAF, 0xDB)));
        Assert.That(PKEY_Devices_AudioDevice_RawProcessingSupported.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_AudioDevice_SpeechProcessingSupported"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_AudioDevice_SpeechProcessingSupportedTest()
    {
        Assert.That(PKEY_Devices_AudioDevice_SpeechProcessingSupported.fmtid, Is.EqualTo(new Guid(0xFB1DE864, 0xE06D, 0x47F4, 0x82, 0xA6, 0x8A, 0x0A, 0xEF, 0x44, 0x49, 0x3C)));
        Assert.That(PKEY_Devices_AudioDevice_SpeechProcessingSupported.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_BatteryLife"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_BatteryLifeTest()
    {
        Assert.That(PKEY_Devices_BatteryLife.fmtid, Is.EqualTo(new Guid(0x49CD1F76, 0x5626, 0x4B17, 0xA4, 0xE8, 0x18, 0xB4, 0xAA, 0x1A, 0x22, 0x13)));
        Assert.That(PKEY_Devices_BatteryLife.pid, Is.EqualTo(10));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_BatteryPlusCharging"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_BatteryPlusChargingTest()
    {
        Assert.That(PKEY_Devices_BatteryPlusCharging.fmtid, Is.EqualTo(new Guid(0x49CD1F76, 0x5626, 0x4B17, 0xA4, 0xE8, 0x18, 0xB4, 0xAA, 0x1A, 0x22, 0x13)));
        Assert.That(PKEY_Devices_BatteryPlusCharging.pid, Is.EqualTo(22));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_BatteryPlusChargingText"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_BatteryPlusChargingTextTest()
    {
        Assert.That(PKEY_Devices_BatteryPlusChargingText.fmtid, Is.EqualTo(new Guid(0x49CD1F76, 0x5626, 0x4B17, 0xA4, 0xE8, 0x18, 0xB4, 0xAA, 0x1A, 0x22, 0x13)));
        Assert.That(PKEY_Devices_BatteryPlusChargingText.pid, Is.EqualTo(23));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Category"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_CategoryTest()
    {
        Assert.That(PKEY_Devices_Category.fmtid, Is.EqualTo(new Guid(0x78C34FC8, 0x104A, 0x4ACA, 0x9E, 0xA4, 0x52, 0x4D, 0x52, 0x99, 0x6E, 0x57)));
        Assert.That(PKEY_Devices_Category.pid, Is.EqualTo(91));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_CategoryGroup"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_CategoryGroupTest()
    {
        Assert.That(PKEY_Devices_CategoryGroup.fmtid, Is.EqualTo(new Guid(0x78C34FC8, 0x104A, 0x4ACA, 0x9E, 0xA4, 0x52, 0x4D, 0x52, 0x99, 0x6E, 0x57)));
        Assert.That(PKEY_Devices_CategoryGroup.pid, Is.EqualTo(94));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_CategoryIds"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_CategoryIdsTest()
    {
        Assert.That(PKEY_Devices_CategoryIds.fmtid, Is.EqualTo(new Guid(0x78C34FC8, 0x104A, 0x4ACA, 0x9E, 0xA4, 0x52, 0x4D, 0x52, 0x99, 0x6E, 0x57)));
        Assert.That(PKEY_Devices_CategoryIds.pid, Is.EqualTo(90));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_CategoryPlural"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_CategoryPluralTest()
    {
        Assert.That(PKEY_Devices_CategoryPlural.fmtid, Is.EqualTo(new Guid(0x78C34FC8, 0x104A, 0x4ACA, 0x9E, 0xA4, 0x52, 0x4D, 0x52, 0x99, 0x6E, 0x57)));
        Assert.That(PKEY_Devices_CategoryPlural.pid, Is.EqualTo(92));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_ChallengeAep"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_ChallengeAepTest()
    {
        Assert.That(PKEY_Devices_ChallengeAep.fmtid, Is.EqualTo(new Guid(0x0774315E, 0xB714, 0x48EC, 0x8D, 0xE8, 0x81, 0x25, 0xC0, 0x77, 0xAC, 0x11)));
        Assert.That(PKEY_Devices_ChallengeAep.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_ChargingState"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_ChargingStateTest()
    {
        Assert.That(PKEY_Devices_ChargingState.fmtid, Is.EqualTo(new Guid(0x49CD1F76, 0x5626, 0x4B17, 0xA4, 0xE8, 0x18, 0xB4, 0xAA, 0x1A, 0x22, 0x13)));
        Assert.That(PKEY_Devices_ChargingState.pid, Is.EqualTo(11));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Children"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_ChildrenTest()
    {
        Assert.That(PKEY_Devices_Children.fmtid, Is.EqualTo(new Guid(0x4340A6C5, 0x93FA, 0x4706, 0x97, 0x2C, 0x7B, 0x64, 0x80, 0x08, 0xA5, 0xA7)));
        Assert.That(PKEY_Devices_Children.pid, Is.EqualTo(9));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_ClassGuid"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_ClassGuidTest()
    {
        Assert.That(PKEY_Devices_ClassGuid.fmtid, Is.EqualTo(new Guid(0xA45C254E, 0xDF1C, 0x4EFD, 0x80, 0x20, 0x67, 0xD1, 0x46, 0xA8, 0x50, 0xE0)));
        Assert.That(PKEY_Devices_ClassGuid.pid, Is.EqualTo(10));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_CompatibleIds"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_CompatibleIdsTest()
    {
        Assert.That(PKEY_Devices_CompatibleIds.fmtid, Is.EqualTo(new Guid(0xA45C254E, 0xDF1C, 0x4EFD, 0x80, 0x20, 0x67, 0xD1, 0x46, 0xA8, 0x50, 0xE0)));
        Assert.That(PKEY_Devices_CompatibleIds.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Connected"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_ConnectedTest()
    {
        Assert.That(PKEY_Devices_Connected.fmtid, Is.EqualTo(new Guid(0x78C34FC8, 0x104A, 0x4ACA, 0x9E, 0xA4, 0x52, 0x4D, 0x52, 0x99, 0x6E, 0x57)));
        Assert.That(PKEY_Devices_Connected.pid, Is.EqualTo(55));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_ContainerId"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_ContainerIdTest()
    {
        Assert.That(PKEY_Devices_ContainerId.fmtid, Is.EqualTo(new Guid(0x8C7ED206, 0x3F8A, 0x4827, 0xB3, 0xAB, 0xAE, 0x9E, 0x1F, 0xAE, 0xFC, 0x6C)));
        Assert.That(PKEY_Devices_ContainerId.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_DefaultTooltip"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_DefaultTooltipTest()
    {
        Assert.That(PKEY_Devices_DefaultTooltip.fmtid, Is.EqualTo(new Guid(0x880F70A2, 0x6082, 0x47AC, 0x8A, 0xAB, 0xA7, 0x39, 0xD1, 0xA3, 0x00, 0xC3)));
        Assert.That(PKEY_Devices_DefaultTooltip.pid, Is.EqualTo(153));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_DeviceCapabilities"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_DeviceCapabilitiesTest()
    {
        Assert.That(PKEY_Devices_DeviceCapabilities.fmtid, Is.EqualTo(new Guid(0xA45C254E, 0xDF1C, 0x4EFD, 0x80, 0x20, 0x67, 0xD1, 0x46, 0xA8, 0x50, 0xE0)));
        Assert.That(PKEY_Devices_DeviceCapabilities.pid, Is.EqualTo(17));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_DeviceCharacteristics"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_DeviceCharacteristicsTest()
    {
        Assert.That(PKEY_Devices_DeviceCharacteristics.fmtid, Is.EqualTo(new Guid(0xA45C254E, 0xDF1C, 0x4EFD, 0x80, 0x20, 0x67, 0xD1, 0x46, 0xA8, 0x50, 0xE0)));
        Assert.That(PKEY_Devices_DeviceCharacteristics.pid, Is.EqualTo(29));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_DeviceDescription1"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_DeviceDescription1Test()
    {
        Assert.That(PKEY_Devices_DeviceDescription1.fmtid, Is.EqualTo(new Guid(0x78C34FC8, 0x104A, 0x4ACA, 0x9E, 0xA4, 0x52, 0x4D, 0x52, 0x99, 0x6E, 0x57)));
        Assert.That(PKEY_Devices_DeviceDescription1.pid, Is.EqualTo(81));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_DeviceDescription2"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_DeviceDescription2Test()
    {
        Assert.That(PKEY_Devices_DeviceDescription2.fmtid, Is.EqualTo(new Guid(0x78C34FC8, 0x104A, 0x4ACA, 0x9E, 0xA4, 0x52, 0x4D, 0x52, 0x99, 0x6E, 0x57)));
        Assert.That(PKEY_Devices_DeviceDescription2.pid, Is.EqualTo(82));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_DeviceHasProblem"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_DeviceHasProblemTest()
    {
        Assert.That(PKEY_Devices_DeviceHasProblem.fmtid, Is.EqualTo(new Guid(0x540B947E, 0x8B40, 0x45BC, 0xA8, 0xA2, 0x6A, 0x0B, 0x89, 0x4C, 0xBD, 0xA2)));
        Assert.That(PKEY_Devices_DeviceHasProblem.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_DeviceInstanceId"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_DeviceInstanceIdTest()
    {
        Assert.That(PKEY_Devices_DeviceInstanceId.fmtid, Is.EqualTo(new Guid(0x78C34FC8, 0x104A, 0x4ACA, 0x9E, 0xA4, 0x52, 0x4D, 0x52, 0x99, 0x6E, 0x57)));
        Assert.That(PKEY_Devices_DeviceInstanceId.pid, Is.EqualTo(256));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_DeviceManufacturer"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_DeviceManufacturerTest()
    {
        Assert.That(PKEY_Devices_DeviceManufacturer.fmtid, Is.EqualTo(new Guid(0xA45C254E, 0xDF1C, 0x4EFD, 0x80, 0x20, 0x67, 0xD1, 0x46, 0xA8, 0x50, 0xE0)));
        Assert.That(PKEY_Devices_DeviceManufacturer.pid, Is.EqualTo(13));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_DevObjectType"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_DevObjectTypeTest()
    {
        Assert.That(PKEY_Devices_DevObjectType.fmtid, Is.EqualTo(new Guid(0x13673F42, 0xA3D6, 0x49F6, 0xB4, 0xDA, 0xAE, 0x46, 0xE0, 0xC5, 0x23, 0x7C)));
        Assert.That(PKEY_Devices_DevObjectType.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_DialProtocol_InstalledApplications"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_DialProtocol_InstalledApplicationsTest()
    {
        Assert.That(PKEY_Devices_DialProtocol_InstalledApplications.fmtid, Is.EqualTo(new Guid(0x6845CC72, 0x1B71, 0x48C3, 0xAF, 0x86, 0xB0, 0x91, 0x71, 0xA1, 0x9B, 0x14)));
        Assert.That(PKEY_Devices_DialProtocol_InstalledApplications.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_DiscoveryMethod"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_DiscoveryMethodTest()
    {
        Assert.That(PKEY_Devices_DiscoveryMethod.fmtid, Is.EqualTo(new Guid(0x78C34FC8, 0x104A, 0x4ACA, 0x9E, 0xA4, 0x52, 0x4D, 0x52, 0x99, 0x6E, 0x57)));
        Assert.That(PKEY_Devices_DiscoveryMethod.pid, Is.EqualTo(52));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Dnssd_Domain"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Dnssd_DomainTest()
    {
        Assert.That(PKEY_Devices_Dnssd_Domain.fmtid, Is.EqualTo(new Guid(0xBF79C0AB, 0xBB74, 0x4CEE, 0xB0, 0x70, 0x47, 0x0B, 0x5A, 0xE2, 0x02, 0xEA)));
        Assert.That(PKEY_Devices_Dnssd_Domain.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Dnssd_FullName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Dnssd_FullNameTest()
    {
        Assert.That(PKEY_Devices_Dnssd_FullName.fmtid, Is.EqualTo(new Guid(0xBF79C0AB, 0xBB74, 0x4CEE, 0xB0, 0x70, 0x47, 0x0B, 0x5A, 0xE2, 0x02, 0xEA)));
        Assert.That(PKEY_Devices_Dnssd_FullName.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Dnssd_HostName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Dnssd_HostNameTest()
    {
        Assert.That(PKEY_Devices_Dnssd_HostName.fmtid, Is.EqualTo(new Guid(0xBF79C0AB, 0xBB74, 0x4CEE, 0xB0, 0x70, 0x47, 0x0B, 0x5A, 0xE2, 0x02, 0xEA)));
        Assert.That(PKEY_Devices_Dnssd_HostName.pid, Is.EqualTo(7));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Dnssd_InstanceName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Dnssd_InstanceNameTest()
    {
        Assert.That(PKEY_Devices_Dnssd_InstanceName.fmtid, Is.EqualTo(new Guid(0xBF79C0AB, 0xBB74, 0x4CEE, 0xB0, 0x70, 0x47, 0x0B, 0x5A, 0xE2, 0x02, 0xEA)));
        Assert.That(PKEY_Devices_Dnssd_InstanceName.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Dnssd_NetworkAdapterId"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Dnssd_NetworkAdapterIdTest()
    {
        Assert.That(PKEY_Devices_Dnssd_NetworkAdapterId.fmtid, Is.EqualTo(new Guid(0xBF79C0AB, 0xBB74, 0x4CEE, 0xB0, 0x70, 0x47, 0x0B, 0x5A, 0xE2, 0x02, 0xEA)));
        Assert.That(PKEY_Devices_Dnssd_NetworkAdapterId.pid, Is.EqualTo(11));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Dnssd_PortNumber"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Dnssd_PortNumberTest()
    {
        Assert.That(PKEY_Devices_Dnssd_PortNumber.fmtid, Is.EqualTo(new Guid(0xBF79C0AB, 0xBB74, 0x4CEE, 0xB0, 0x70, 0x47, 0x0B, 0x5A, 0xE2, 0x02, 0xEA)));
        Assert.That(PKEY_Devices_Dnssd_PortNumber.pid, Is.EqualTo(12));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Dnssd_Priority"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Dnssd_PriorityTest()
    {
        Assert.That(PKEY_Devices_Dnssd_Priority.fmtid, Is.EqualTo(new Guid(0xBF79C0AB, 0xBB74, 0x4CEE, 0xB0, 0x70, 0x47, 0x0B, 0x5A, 0xE2, 0x02, 0xEA)));
        Assert.That(PKEY_Devices_Dnssd_Priority.pid, Is.EqualTo(9));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Dnssd_ServiceName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Dnssd_ServiceNameTest()
    {
        Assert.That(PKEY_Devices_Dnssd_ServiceName.fmtid, Is.EqualTo(new Guid(0xBF79C0AB, 0xBB74, 0x4CEE, 0xB0, 0x70, 0x47, 0x0B, 0x5A, 0xE2, 0x02, 0xEA)));
        Assert.That(PKEY_Devices_Dnssd_ServiceName.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Dnssd_TextAttributes"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Dnssd_TextAttributesTest()
    {
        Assert.That(PKEY_Devices_Dnssd_TextAttributes.fmtid, Is.EqualTo(new Guid(0xBF79C0AB, 0xBB74, 0x4CEE, 0xB0, 0x70, 0x47, 0x0B, 0x5A, 0xE2, 0x02, 0xEA)));
        Assert.That(PKEY_Devices_Dnssd_TextAttributes.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Dnssd_Ttl"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Dnssd_TtlTest()
    {
        Assert.That(PKEY_Devices_Dnssd_Ttl.fmtid, Is.EqualTo(new Guid(0xBF79C0AB, 0xBB74, 0x4CEE, 0xB0, 0x70, 0x47, 0x0B, 0x5A, 0xE2, 0x02, 0xEA)));
        Assert.That(PKEY_Devices_Dnssd_Ttl.pid, Is.EqualTo(10));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Dnssd_Weight"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Dnssd_WeightTest()
    {
        Assert.That(PKEY_Devices_Dnssd_Weight.fmtid, Is.EqualTo(new Guid(0xBF79C0AB, 0xBB74, 0x4CEE, 0xB0, 0x70, 0x47, 0x0B, 0x5A, 0xE2, 0x02, 0xEA)));
        Assert.That(PKEY_Devices_Dnssd_Weight.pid, Is.EqualTo(8));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_FriendlyName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_FriendlyNameTest()
    {
        Assert.That(PKEY_Devices_FriendlyName.fmtid, Is.EqualTo(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD)));
        Assert.That(PKEY_Devices_FriendlyName.pid, Is.EqualTo(12288));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_FunctionPaths"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_FunctionPathsTest()
    {
        Assert.That(PKEY_Devices_FunctionPaths.fmtid, Is.EqualTo(new Guid(0xD08DD4C0, 0x3A9E, 0x462E, 0x82, 0x90, 0x7B, 0x63, 0x6B, 0x25, 0x76, 0xB9)));
        Assert.That(PKEY_Devices_FunctionPaths.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_GlyphIcon"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_GlyphIconTest()
    {
        Assert.That(PKEY_Devices_GlyphIcon.fmtid, Is.EqualTo(new Guid(0x51236583, 0x0C4A, 0x4FE8, 0xB8, 0x1F, 0x16, 0x6A, 0xEC, 0x13, 0xF5, 0x10)));
        Assert.That(PKEY_Devices_GlyphIcon.pid, Is.EqualTo(123));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_HardwareIds"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_HardwareIdsTest()
    {
        Assert.That(PKEY_Devices_HardwareIds.fmtid, Is.EqualTo(new Guid(0xA45C254E, 0xDF1C, 0x4EFD, 0x80, 0x20, 0x67, 0xD1, 0x46, 0xA8, 0x50, 0xE0)));
        Assert.That(PKEY_Devices_HardwareIds.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Icon"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_IconTest()
    {
        Assert.That(PKEY_Devices_Icon.fmtid, Is.EqualTo(new Guid(0x78C34FC8, 0x104A, 0x4ACA, 0x9E, 0xA4, 0x52, 0x4D, 0x52, 0x99, 0x6E, 0x57)));
        Assert.That(PKEY_Devices_Icon.pid, Is.EqualTo(57));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_InLocalMachineContainer"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_InLocalMachineContainerTest()
    {
        Assert.That(PKEY_Devices_InLocalMachineContainer.fmtid, Is.EqualTo(new Guid(0x8C7ED206, 0x3F8A, 0x4827, 0xB3, 0xAB, 0xAE, 0x9E, 0x1F, 0xAE, 0xFC, 0x6C)));
        Assert.That(PKEY_Devices_InLocalMachineContainer.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_InterfaceClassGuid"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_InterfaceClassGuidTest()
    {
        Assert.That(PKEY_Devices_InterfaceClassGuid.fmtid, Is.EqualTo(new Guid(0x026E516E, 0xB814, 0x414B, 0x83, 0xCD, 0x85, 0x6D, 0x6F, 0xEF, 0x48, 0x22)));
        Assert.That(PKEY_Devices_InterfaceClassGuid.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_InterfaceEnabled"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_InterfaceEnabledTest()
    {
        Assert.That(PKEY_Devices_InterfaceEnabled.fmtid, Is.EqualTo(new Guid(0x026E516E, 0xB814, 0x414B, 0x83, 0xCD, 0x85, 0x6D, 0x6F, 0xEF, 0x48, 0x22)));
        Assert.That(PKEY_Devices_InterfaceEnabled.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_InterfacePaths"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_InterfacePathsTest()
    {
        Assert.That(PKEY_Devices_InterfacePaths.fmtid, Is.EqualTo(new Guid(0xD08DD4C0, 0x3A9E, 0x462E, 0x82, 0x90, 0x7B, 0x63, 0x6B, 0x25, 0x76, 0xB9)));
        Assert.That(PKEY_Devices_InterfacePaths.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_IpAddress"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_IpAddressTest()
    {
        Assert.That(PKEY_Devices_IpAddress.fmtid, Is.EqualTo(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD)));
        Assert.That(PKEY_Devices_IpAddress.pid, Is.EqualTo(12297));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_IsDefault"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_IsDefaultTest()
    {
        Assert.That(PKEY_Devices_IsDefault.fmtid, Is.EqualTo(new Guid(0x78C34FC8, 0x104A, 0x4ACA, 0x9E, 0xA4, 0x52, 0x4D, 0x52, 0x99, 0x6E, 0x57)));
        Assert.That(PKEY_Devices_IsDefault.pid, Is.EqualTo(86));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_IsNetworkConnected"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_IsNetworkConnectedTest()
    {
        Assert.That(PKEY_Devices_IsNetworkConnected.fmtid, Is.EqualTo(new Guid(0x78C34FC8, 0x104A, 0x4ACA, 0x9E, 0xA4, 0x52, 0x4D, 0x52, 0x99, 0x6E, 0x57)));
        Assert.That(PKEY_Devices_IsNetworkConnected.pid, Is.EqualTo(85));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_IsShared"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_IsSharedTest()
    {
        Assert.That(PKEY_Devices_IsShared.fmtid, Is.EqualTo(new Guid(0x78C34FC8, 0x104A, 0x4ACA, 0x9E, 0xA4, 0x52, 0x4D, 0x52, 0x99, 0x6E, 0x57)));
        Assert.That(PKEY_Devices_IsShared.pid, Is.EqualTo(84));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_IsSoftwareInstalling"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_IsSoftwareInstallingTest()
    {
        Assert.That(PKEY_Devices_IsSoftwareInstalling.fmtid, Is.EqualTo(new Guid(0x83DA6326, 0x97A6, 0x4088, 0x94, 0x53, 0xA1, 0x92, 0x3F, 0x57, 0x3B, 0x29)));
        Assert.That(PKEY_Devices_IsSoftwareInstalling.pid, Is.EqualTo(9));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_LaunchDeviceStageFromExplorer"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_LaunchDeviceStageFromExplorerTest()
    {
        Assert.That(PKEY_Devices_LaunchDeviceStageFromExplorer.fmtid, Is.EqualTo(new Guid(0x78C34FC8, 0x104A, 0x4ACA, 0x9E, 0xA4, 0x52, 0x4D, 0x52, 0x99, 0x6E, 0x57)));
        Assert.That(PKEY_Devices_LaunchDeviceStageFromExplorer.pid, Is.EqualTo(77));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_LocalMachine"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_LocalMachineTest()
    {
        Assert.That(PKEY_Devices_LocalMachine.fmtid, Is.EqualTo(new Guid(0x78C34FC8, 0x104A, 0x4ACA, 0x9E, 0xA4, 0x52, 0x4D, 0x52, 0x99, 0x6E, 0x57)));
        Assert.That(PKEY_Devices_LocalMachine.pid, Is.EqualTo(70));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_LocationPaths"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_LocationPathsTest()
    {
        Assert.That(PKEY_Devices_LocationPaths.fmtid, Is.EqualTo(new Guid(0xA45C254E, 0xDF1C, 0x4EFD, 0x80, 0x20, 0x67, 0xD1, 0x46, 0xA8, 0x50, 0xE0)));
        Assert.That(PKEY_Devices_LocationPaths.pid, Is.EqualTo(37));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Manufacturer"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_ManufacturerTest()
    {
        Assert.That(PKEY_Devices_Manufacturer.fmtid, Is.EqualTo(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD)));
        Assert.That(PKEY_Devices_Manufacturer.pid, Is.EqualTo(8192));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_MetadataPath"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_MetadataPathTest()
    {
        Assert.That(PKEY_Devices_MetadataPath.fmtid, Is.EqualTo(new Guid(0x78C34FC8, 0x104A, 0x4ACA, 0x9E, 0xA4, 0x52, 0x4D, 0x52, 0x99, 0x6E, 0x57)));
        Assert.That(PKEY_Devices_MetadataPath.pid, Is.EqualTo(71));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_MicrophoneArray_Geometry"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_MicrophoneArray_GeometryTest()
    {
        Assert.That(PKEY_Devices_MicrophoneArray_Geometry.fmtid, Is.EqualTo(new Guid(0xA1829EA2, 0x27EB, 0x459E, 0x93, 0x5D, 0xB2, 0xFA, 0xD7, 0xB0, 0x77, 0x62)));
        Assert.That(PKEY_Devices_MicrophoneArray_Geometry.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_MissedCalls"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_MissedCallsTest()
    {
        Assert.That(PKEY_Devices_MissedCalls.fmtid, Is.EqualTo(new Guid(0x49CD1F76, 0x5626, 0x4B17, 0xA4, 0xE8, 0x18, 0xB4, 0xAA, 0x1A, 0x22, 0x13)));
        Assert.That(PKEY_Devices_MissedCalls.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_ModelId"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_ModelIdTest()
    {
        Assert.That(PKEY_Devices_ModelId.fmtid, Is.EqualTo(new Guid(0x80D81EA6, 0x7473, 0x4B0C, 0x82, 0x16, 0xEF, 0xC1, 0x1A, 0x2C, 0x4C, 0x8B)));
        Assert.That(PKEY_Devices_ModelId.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_ModelName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_ModelNameTest()
    {
        Assert.That(PKEY_Devices_ModelName.fmtid, Is.EqualTo(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD)));
        Assert.That(PKEY_Devices_ModelName.pid, Is.EqualTo(8194));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_ModelNumber"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_ModelNumberTest()
    {
        Assert.That(PKEY_Devices_ModelNumber.fmtid, Is.EqualTo(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD)));
        Assert.That(PKEY_Devices_ModelNumber.pid, Is.EqualTo(8195));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_NetworkedTooltip"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_NetworkedTooltipTest()
    {
        Assert.That(PKEY_Devices_NetworkedTooltip.fmtid, Is.EqualTo(new Guid(0x880F70A2, 0x6082, 0x47AC, 0x8A, 0xAB, 0xA7, 0x39, 0xD1, 0xA3, 0x00, 0xC3)));
        Assert.That(PKEY_Devices_NetworkedTooltip.pid, Is.EqualTo(152));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_NetworkName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_NetworkNameTest()
    {
        Assert.That(PKEY_Devices_NetworkName.fmtid, Is.EqualTo(new Guid(0x49CD1F76, 0x5626, 0x4B17, 0xA4, 0xE8, 0x18, 0xB4, 0xAA, 0x1A, 0x22, 0x13)));
        Assert.That(PKEY_Devices_NetworkName.pid, Is.EqualTo(7));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_NetworkType"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_NetworkTypeTest()
    {
        Assert.That(PKEY_Devices_NetworkType.fmtid, Is.EqualTo(new Guid(0x49CD1F76, 0x5626, 0x4B17, 0xA4, 0xE8, 0x18, 0xB4, 0xAA, 0x1A, 0x22, 0x13)));
        Assert.That(PKEY_Devices_NetworkType.pid, Is.EqualTo(8));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_NewPictures"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_NewPicturesTest()
    {
        Assert.That(PKEY_Devices_NewPictures.fmtid, Is.EqualTo(new Guid(0x49CD1F76, 0x5626, 0x4B17, 0xA4, 0xE8, 0x18, 0xB4, 0xAA, 0x1A, 0x22, 0x13)));
        Assert.That(PKEY_Devices_NewPictures.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Notification"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_NotificationTest()
    {
        Assert.That(PKEY_Devices_Notification.fmtid, Is.EqualTo(new Guid(0x06704B0C, 0xE830, 0x4C81, 0x91, 0x78, 0x91, 0xE4, 0xE9, 0x5A, 0x80, 0xA0)));
        Assert.That(PKEY_Devices_Notification.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Notifications_LowBattery"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Notifications_LowBatteryTest()
    {
        Assert.That(PKEY_Devices_Notifications_LowBattery.fmtid, Is.EqualTo(new Guid(0xC4C07F2B, 0x8524, 0x4E66, 0xAE, 0x3A, 0xA6, 0x23, 0x5F, 0x10, 0x3B, 0xEB)));
        Assert.That(PKEY_Devices_Notifications_LowBattery.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Notifications_MissedCall"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Notifications_MissedCallTest()
    {
        Assert.That(PKEY_Devices_Notifications_MissedCall.fmtid, Is.EqualTo(new Guid(0x6614EF48, 0x4EFE, 0x4424, 0x9E, 0xDA, 0xC7, 0x9F, 0x40, 0x4E, 0xDF, 0x3E)));
        Assert.That(PKEY_Devices_Notifications_MissedCall.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Notifications_NewMessage"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Notifications_NewMessageTest()
    {
        Assert.That(PKEY_Devices_Notifications_NewMessage.fmtid, Is.EqualTo(new Guid(0x2BE9260A, 0x2012, 0x4742, 0xA5, 0x55, 0xF4, 0x1B, 0x63, 0x8B, 0x7D, 0xCB)));
        Assert.That(PKEY_Devices_Notifications_NewMessage.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Notifications_NewVoicemail"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Notifications_NewVoicemailTest()
    {
        Assert.That(PKEY_Devices_Notifications_NewVoicemail.fmtid, Is.EqualTo(new Guid(0x59569556, 0x0A08, 0x4212, 0x95, 0xB9, 0xFA, 0xE2, 0xAD, 0x64, 0x13, 0xDB)));
        Assert.That(PKEY_Devices_Notifications_NewVoicemail.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Notifications_StorageFull"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Notifications_StorageFullTest()
    {
        Assert.That(PKEY_Devices_Notifications_StorageFull.fmtid, Is.EqualTo(new Guid(0xA0E00EE1, 0xF0C7, 0x4D41, 0xB8, 0xE7, 0x26, 0xA7, 0xBD, 0x8D, 0x38, 0xB0)));
        Assert.That(PKEY_Devices_Notifications_StorageFull.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Notifications_StorageFullLinkText"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Notifications_StorageFullLinkTextTest()
    {
        Assert.That(PKEY_Devices_Notifications_StorageFullLinkText.fmtid, Is.EqualTo(new Guid(0xA0E00EE1, 0xF0C7, 0x4D41, 0xB8, 0xE7, 0x26, 0xA7, 0xBD, 0x8D, 0x38, 0xB0)));
        Assert.That(PKEY_Devices_Notifications_StorageFullLinkText.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_NotificationStore"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_NotificationStoreTest()
    {
        Assert.That(PKEY_Devices_NotificationStore.fmtid, Is.EqualTo(new Guid(0x06704B0C, 0xE830, 0x4C81, 0x91, 0x78, 0x91, 0xE4, 0xE9, 0x5A, 0x80, 0xA0)));
        Assert.That(PKEY_Devices_NotificationStore.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_NotWorkingProperly"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_NotWorkingProperlyTest()
    {
        Assert.That(PKEY_Devices_NotWorkingProperly.fmtid, Is.EqualTo(new Guid(0x78C34FC8, 0x104A, 0x4ACA, 0x9E, 0xA4, 0x52, 0x4D, 0x52, 0x99, 0x6E, 0x57)));
        Assert.That(PKEY_Devices_NotWorkingProperly.pid, Is.EqualTo(83));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Paired"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_PairedTest()
    {
        Assert.That(PKEY_Devices_Paired.fmtid, Is.EqualTo(new Guid(0x78C34FC8, 0x104A, 0x4ACA, 0x9E, 0xA4, 0x52, 0x4D, 0x52, 0x99, 0x6E, 0x57)));
        Assert.That(PKEY_Devices_Paired.pid, Is.EqualTo(56));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Panel_PanelGroup"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Panel_PanelGroupTest()
    {
        Assert.That(PKEY_Devices_Panel_PanelGroup.fmtid, Is.EqualTo(new Guid(0x8DBC9C86, 0x97A9, 0x4BFF, 0x9B, 0xC6, 0xBF, 0xE9, 0x5D, 0x3E, 0x6D, 0xAD)));
        Assert.That(PKEY_Devices_Panel_PanelGroup.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Panel_PanelId"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Panel_PanelIdTest()
    {
        Assert.That(PKEY_Devices_Panel_PanelId.fmtid, Is.EqualTo(new Guid(0x8DBC9C86, 0x97A9, 0x4BFF, 0x9B, 0xC6, 0xBF, 0xE9, 0x5D, 0x3E, 0x6D, 0xAD)));
        Assert.That(PKEY_Devices_Panel_PanelId.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Parent"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_ParentTest()
    {
        Assert.That(PKEY_Devices_Parent.fmtid, Is.EqualTo(new Guid(0x4340A6C5, 0x93FA, 0x4706, 0x97, 0x2C, 0x7B, 0x64, 0x80, 0x08, 0xA5, 0xA7)));
        Assert.That(PKEY_Devices_Parent.pid, Is.EqualTo(8));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_PhoneLineTransportDevice_Connected"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_PhoneLineTransportDevice_ConnectedTest()
    {
        Assert.That(PKEY_Devices_PhoneLineTransportDevice_Connected.fmtid, Is.EqualTo(new Guid(0xAECF2FE8, 0x1D00, 0x4FEE, 0x8A, 0x6D, 0xA7, 0x0D, 0x71, 0x9B, 0x77, 0x2B)));
        Assert.That(PKEY_Devices_PhoneLineTransportDevice_Connected.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_PhysicalDeviceLocation"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_PhysicalDeviceLocationTest()
    {
        Assert.That(PKEY_Devices_PhysicalDeviceLocation.fmtid, Is.EqualTo(new Guid(0x540B947E, 0x8B40, 0x45BC, 0xA8, 0xA2, 0x6A, 0x0B, 0x89, 0x4C, 0xBD, 0xA2)));
        Assert.That(PKEY_Devices_PhysicalDeviceLocation.pid, Is.EqualTo(9));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_PlaybackPositionPercent"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_PlaybackPositionPercentTest()
    {
        Assert.That(PKEY_Devices_PlaybackPositionPercent.fmtid, Is.EqualTo(new Guid(0x3633DE59, 0x6825, 0x4381, 0xA4, 0x9B, 0x9F, 0x6B, 0xA1, 0x3A, 0x14, 0x71)));
        Assert.That(PKEY_Devices_PlaybackPositionPercent.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_PlaybackState"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_PlaybackStateTest()
    {
        Assert.That(PKEY_Devices_PlaybackState.fmtid, Is.EqualTo(new Guid(0x3633DE59, 0x6825, 0x4381, 0xA4, 0x9B, 0x9F, 0x6B, 0xA1, 0x3A, 0x14, 0x71)));
        Assert.That(PKEY_Devices_PlaybackState.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_PlaybackTitle"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_PlaybackTitleTest()
    {
        Assert.That(PKEY_Devices_PlaybackTitle.fmtid, Is.EqualTo(new Guid(0x3633DE59, 0x6825, 0x4381, 0xA4, 0x9B, 0x9F, 0x6B, 0xA1, 0x3A, 0x14, 0x71)));
        Assert.That(PKEY_Devices_PlaybackTitle.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Present"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_PresentTest()
    {
        Assert.That(PKEY_Devices_Present.fmtid, Is.EqualTo(new Guid(0x540B947E, 0x8B40, 0x45BC, 0xA8, 0xA2, 0x6A, 0x0B, 0x89, 0x4C, 0xBD, 0xA2)));
        Assert.That(PKEY_Devices_Present.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_PresentationUrl"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_PresentationUrlTest()
    {
        Assert.That(PKEY_Devices_PresentationUrl.fmtid, Is.EqualTo(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD)));
        Assert.That(PKEY_Devices_PresentationUrl.pid, Is.EqualTo(8198));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_PrimaryCategory"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_PrimaryCategoryTest()
    {
        Assert.That(PKEY_Devices_PrimaryCategory.fmtid, Is.EqualTo(new Guid(0xD08DD4C0, 0x3A9E, 0x462E, 0x82, 0x90, 0x7B, 0x63, 0x6B, 0x25, 0x76, 0xB9)));
        Assert.That(PKEY_Devices_PrimaryCategory.pid, Is.EqualTo(10));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_RemainingDuration"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_RemainingDurationTest()
    {
        Assert.That(PKEY_Devices_RemainingDuration.fmtid, Is.EqualTo(new Guid(0x3633DE59, 0x6825, 0x4381, 0xA4, 0x9B, 0x9F, 0x6B, 0xA1, 0x3A, 0x14, 0x71)));
        Assert.That(PKEY_Devices_RemainingDuration.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_RestrictedInterface"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_RestrictedInterfaceTest()
    {
        Assert.That(PKEY_Devices_RestrictedInterface.fmtid, Is.EqualTo(new Guid(0x026E516E, 0xB814, 0x414B, 0x83, 0xCD, 0x85, 0x6D, 0x6F, 0xEF, 0x48, 0x22)));
        Assert.That(PKEY_Devices_RestrictedInterface.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Roaming"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_RoamingTest()
    {
        Assert.That(PKEY_Devices_Roaming.fmtid, Is.EqualTo(new Guid(0x49CD1F76, 0x5626, 0x4B17, 0xA4, 0xE8, 0x18, 0xB4, 0xAA, 0x1A, 0x22, 0x13)));
        Assert.That(PKEY_Devices_Roaming.pid, Is.EqualTo(9));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_SafeRemovalRequired"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_SafeRemovalRequiredTest()
    {
        Assert.That(PKEY_Devices_SafeRemovalRequired.fmtid, Is.EqualTo(new Guid(0xAFD97640, 0x86A3, 0x4210, 0xB6, 0x7C, 0x28, 0x9C, 0x41, 0xAA, 0xBE, 0x55)));
        Assert.That(PKEY_Devices_SafeRemovalRequired.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_SchematicName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_SchematicNameTest()
    {
        Assert.That(PKEY_Devices_SchematicName.fmtid, Is.EqualTo(new Guid(0x026E516E, 0xB814, 0x414B, 0x83, 0xCD, 0x85, 0x6D, 0x6F, 0xEF, 0x48, 0x22)));
        Assert.That(PKEY_Devices_SchematicName.pid, Is.EqualTo(9));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_ServiceAddress"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_ServiceAddressTest()
    {
        Assert.That(PKEY_Devices_ServiceAddress.fmtid, Is.EqualTo(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD)));
        Assert.That(PKEY_Devices_ServiceAddress.pid, Is.EqualTo(16384));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_ServiceId"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_ServiceIdTest()
    {
        Assert.That(PKEY_Devices_ServiceId.fmtid, Is.EqualTo(new Guid(0x656A3BB3, 0xECC0, 0x43FD, 0x84, 0x77, 0x4A, 0xE0, 0x40, 0x4A, 0x96, 0xCD)));
        Assert.That(PKEY_Devices_ServiceId.pid, Is.EqualTo(16385));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_SharedTooltip"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_SharedTooltipTest()
    {
        Assert.That(PKEY_Devices_SharedTooltip.fmtid, Is.EqualTo(new Guid(0x880F70A2, 0x6082, 0x47AC, 0x8A, 0xAB, 0xA7, 0x39, 0xD1, 0xA3, 0x00, 0xC3)));
        Assert.That(PKEY_Devices_SharedTooltip.pid, Is.EqualTo(151));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_SignalStrength"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_SignalStrengthTest()
    {
        Assert.That(PKEY_Devices_SignalStrength.fmtid, Is.EqualTo(new Guid(0x49CD1F76, 0x5626, 0x4B17, 0xA4, 0xE8, 0x18, 0xB4, 0xAA, 0x1A, 0x22, 0x13)));
        Assert.That(PKEY_Devices_SignalStrength.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_SmartCards_ReaderKind"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_SmartCards_ReaderKindTest()
    {
        Assert.That(PKEY_Devices_SmartCards_ReaderKind.fmtid, Is.EqualTo(new Guid(0xD6B5B883, 0x18BD, 0x4B4D, 0xB2, 0xEC, 0x9E, 0x38, 0xAF, 0xFE, 0xDA, 0x82)));
        Assert.That(PKEY_Devices_SmartCards_ReaderKind.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Status"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_StatusTest()
    {
        Assert.That(PKEY_Devices_Status.fmtid, Is.EqualTo(new Guid(0xD08DD4C0, 0x3A9E, 0x462E, 0x82, 0x90, 0x7B, 0x63, 0x6B, 0x25, 0x76, 0xB9)));
        Assert.That(PKEY_Devices_Status.pid, Is.EqualTo(259));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Status1"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Status1Test()
    {
        Assert.That(PKEY_Devices_Status1.fmtid, Is.EqualTo(new Guid(0xD08DD4C0, 0x3A9E, 0x462E, 0x82, 0x90, 0x7B, 0x63, 0x6B, 0x25, 0x76, 0xB9)));
        Assert.That(PKEY_Devices_Status1.pid, Is.EqualTo(257));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Status2"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Status2Test()
    {
        Assert.That(PKEY_Devices_Status2.fmtid, Is.EqualTo(new Guid(0xD08DD4C0, 0x3A9E, 0x462E, 0x82, 0x90, 0x7B, 0x63, 0x6B, 0x25, 0x76, 0xB9)));
        Assert.That(PKEY_Devices_Status2.pid, Is.EqualTo(258));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_StorageCapacity"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_StorageCapacityTest()
    {
        Assert.That(PKEY_Devices_StorageCapacity.fmtid, Is.EqualTo(new Guid(0x49CD1F76, 0x5626, 0x4B17, 0xA4, 0xE8, 0x18, 0xB4, 0xAA, 0x1A, 0x22, 0x13)));
        Assert.That(PKEY_Devices_StorageCapacity.pid, Is.EqualTo(12));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_StorageFreeSpace"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_StorageFreeSpaceTest()
    {
        Assert.That(PKEY_Devices_StorageFreeSpace.fmtid, Is.EqualTo(new Guid(0x49CD1F76, 0x5626, 0x4B17, 0xA4, 0xE8, 0x18, 0xB4, 0xAA, 0x1A, 0x22, 0x13)));
        Assert.That(PKEY_Devices_StorageFreeSpace.pid, Is.EqualTo(13));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_StorageFreeSpacePercent"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_StorageFreeSpacePercentTest()
    {
        Assert.That(PKEY_Devices_StorageFreeSpacePercent.fmtid, Is.EqualTo(new Guid(0x49CD1F76, 0x5626, 0x4B17, 0xA4, 0xE8, 0x18, 0xB4, 0xAA, 0x1A, 0x22, 0x13)));
        Assert.That(PKEY_Devices_StorageFreeSpacePercent.pid, Is.EqualTo(14));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_TextMessages"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_TextMessagesTest()
    {
        Assert.That(PKEY_Devices_TextMessages.fmtid, Is.EqualTo(new Guid(0x49CD1F76, 0x5626, 0x4B17, 0xA4, 0xE8, 0x18, 0xB4, 0xAA, 0x1A, 0x22, 0x13)));
        Assert.That(PKEY_Devices_TextMessages.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Voicemail"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_VoicemailTest()
    {
        Assert.That(PKEY_Devices_Voicemail.fmtid, Is.EqualTo(new Guid(0x49CD1F76, 0x5626, 0x4B17, 0xA4, 0xE8, 0x18, 0xB4, 0xAA, 0x1A, 0x22, 0x13)));
        Assert.That(PKEY_Devices_Voicemail.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_WiaDeviceType"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_WiaDeviceTypeTest()
    {
        Assert.That(PKEY_Devices_WiaDeviceType.fmtid, Is.EqualTo(new Guid(0x6BDD1FC6, 0x810F, 0x11D0, 0xBE, 0xC7, 0x08, 0x00, 0x2B, 0xE2, 0x09, 0x2F)));
        Assert.That(PKEY_Devices_WiaDeviceType.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_WiFi_InterfaceGuid"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_WiFi_InterfaceGuidTest()
    {
        Assert.That(PKEY_Devices_WiFi_InterfaceGuid.fmtid, Is.EqualTo(new Guid(0xEF1167EB, 0xCBFC, 0x4341, 0xA5, 0x68, 0xA7, 0xC9, 0x1A, 0x68, 0x98, 0x2C)));
        Assert.That(PKEY_Devices_WiFi_InterfaceGuid.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_WiFiDirect_DeviceAddress"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_WiFiDirect_DeviceAddressTest()
    {
        Assert.That(PKEY_Devices_WiFiDirect_DeviceAddress.fmtid, Is.EqualTo(new Guid(0x1506935D, 0xE3E7, 0x450F, 0x86, 0x37, 0x82, 0x23, 0x3E, 0xBE, 0x5F, 0x6E)));
        Assert.That(PKEY_Devices_WiFiDirect_DeviceAddress.pid, Is.EqualTo(13));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_WiFiDirect_GroupId"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_WiFiDirect_GroupIdTest()
    {
        Assert.That(PKEY_Devices_WiFiDirect_GroupId.fmtid, Is.EqualTo(new Guid(0x1506935D, 0xE3E7, 0x450F, 0x86, 0x37, 0x82, 0x23, 0x3E, 0xBE, 0x5F, 0x6E)));
        Assert.That(PKEY_Devices_WiFiDirect_GroupId.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_WiFiDirect_InformationElements"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_WiFiDirect_InformationElementsTest()
    {
        Assert.That(PKEY_Devices_WiFiDirect_InformationElements.fmtid, Is.EqualTo(new Guid(0x1506935D, 0xE3E7, 0x450F, 0x86, 0x37, 0x82, 0x23, 0x3E, 0xBE, 0x5F, 0x6E)));
        Assert.That(PKEY_Devices_WiFiDirect_InformationElements.pid, Is.EqualTo(12));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_WiFiDirect_InterfaceAddress"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_WiFiDirect_InterfaceAddressTest()
    {
        Assert.That(PKEY_Devices_WiFiDirect_InterfaceAddress.fmtid, Is.EqualTo(new Guid(0x1506935D, 0xE3E7, 0x450F, 0x86, 0x37, 0x82, 0x23, 0x3E, 0xBE, 0x5F, 0x6E)));
        Assert.That(PKEY_Devices_WiFiDirect_InterfaceAddress.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_WiFiDirect_InterfaceGuid"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_WiFiDirect_InterfaceGuidTest()
    {
        Assert.That(PKEY_Devices_WiFiDirect_InterfaceGuid.fmtid, Is.EqualTo(new Guid(0x1506935D, 0xE3E7, 0x450F, 0x86, 0x37, 0x82, 0x23, 0x3E, 0xBE, 0x5F, 0x6E)));
        Assert.That(PKEY_Devices_WiFiDirect_InterfaceGuid.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_WiFiDirect_IsConnected"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_WiFiDirect_IsConnectedTest()
    {
        Assert.That(PKEY_Devices_WiFiDirect_IsConnected.fmtid, Is.EqualTo(new Guid(0x1506935D, 0xE3E7, 0x450F, 0x86, 0x37, 0x82, 0x23, 0x3E, 0xBE, 0x5F, 0x6E)));
        Assert.That(PKEY_Devices_WiFiDirect_IsConnected.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_WiFiDirect_IsLegacyDevice"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_WiFiDirect_IsLegacyDeviceTest()
    {
        Assert.That(PKEY_Devices_WiFiDirect_IsLegacyDevice.fmtid, Is.EqualTo(new Guid(0x1506935D, 0xE3E7, 0x450F, 0x86, 0x37, 0x82, 0x23, 0x3E, 0xBE, 0x5F, 0x6E)));
        Assert.That(PKEY_Devices_WiFiDirect_IsLegacyDevice.pid, Is.EqualTo(7));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_WiFiDirect_IsMiracastLcpSupported"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_WiFiDirect_IsMiracastLcpSupportedTest()
    {
        Assert.That(PKEY_Devices_WiFiDirect_IsMiracastLcpSupported.fmtid, Is.EqualTo(new Guid(0x1506935D, 0xE3E7, 0x450F, 0x86, 0x37, 0x82, 0x23, 0x3E, 0xBE, 0x5F, 0x6E)));
        Assert.That(PKEY_Devices_WiFiDirect_IsMiracastLcpSupported.pid, Is.EqualTo(9));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_WiFiDirect_IsVisible"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_WiFiDirect_IsVisibleTest()
    {
        Assert.That(PKEY_Devices_WiFiDirect_IsVisible.fmtid, Is.EqualTo(new Guid(0x1506935D, 0xE3E7, 0x450F, 0x86, 0x37, 0x82, 0x23, 0x3E, 0xBE, 0x5F, 0x6E)));
        Assert.That(PKEY_Devices_WiFiDirect_IsVisible.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_WiFiDirect_MiracastVersion"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_WiFiDirect_MiracastVersionTest()
    {
        Assert.That(PKEY_Devices_WiFiDirect_MiracastVersion.fmtid, Is.EqualTo(new Guid(0x1506935D, 0xE3E7, 0x450F, 0x86, 0x37, 0x82, 0x23, 0x3E, 0xBE, 0x5F, 0x6E)));
        Assert.That(PKEY_Devices_WiFiDirect_MiracastVersion.pid, Is.EqualTo(8));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_WiFiDirect_Services"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_WiFiDirect_ServicesTest()
    {
        Assert.That(PKEY_Devices_WiFiDirect_Services.fmtid, Is.EqualTo(new Guid(0x1506935D, 0xE3E7, 0x450F, 0x86, 0x37, 0x82, 0x23, 0x3E, 0xBE, 0x5F, 0x6E)));
        Assert.That(PKEY_Devices_WiFiDirect_Services.pid, Is.EqualTo(10));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_WiFiDirect_SupportedChannelList"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_WiFiDirect_SupportedChannelListTest()
    {
        Assert.That(PKEY_Devices_WiFiDirect_SupportedChannelList.fmtid, Is.EqualTo(new Guid(0x1506935D, 0xE3E7, 0x450F, 0x86, 0x37, 0x82, 0x23, 0x3E, 0xBE, 0x5F, 0x6E)));
        Assert.That(PKEY_Devices_WiFiDirect_SupportedChannelList.pid, Is.EqualTo(11));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_WiFiDirectServices_AdvertisementId"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_WiFiDirectServices_AdvertisementIdTest()
    {
        Assert.That(PKEY_Devices_WiFiDirectServices_AdvertisementId.fmtid, Is.EqualTo(new Guid(0x31B37743, 0x7C5E, 0x4005, 0x93, 0xE6, 0xE9, 0x53, 0xF9, 0x2B, 0x82, 0xE9)));
        Assert.That(PKEY_Devices_WiFiDirectServices_AdvertisementId.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_WiFiDirectServices_RequestServiceInformation"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_WiFiDirectServices_RequestServiceInformationTest()
    {
        Assert.That(PKEY_Devices_WiFiDirectServices_RequestServiceInformation.fmtid, Is.EqualTo(new Guid(0x31B37743, 0x7C5E, 0x4005, 0x93, 0xE6, 0xE9, 0x53, 0xF9, 0x2B, 0x82, 0xE9)));
        Assert.That(PKEY_Devices_WiFiDirectServices_RequestServiceInformation.pid, Is.EqualTo(7));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_WiFiDirectServices_ServiceAddress"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_WiFiDirectServices_ServiceAddressTest()
    {
        Assert.That(PKEY_Devices_WiFiDirectServices_ServiceAddress.fmtid, Is.EqualTo(new Guid(0x31B37743, 0x7C5E, 0x4005, 0x93, 0xE6, 0xE9, 0x53, 0xF9, 0x2B, 0x82, 0xE9)));
        Assert.That(PKEY_Devices_WiFiDirectServices_ServiceAddress.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_WiFiDirectServices_ServiceConfigMethods"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_WiFiDirectServices_ServiceConfigMethodsTest()
    {
        Assert.That(PKEY_Devices_WiFiDirectServices_ServiceConfigMethods.fmtid, Is.EqualTo(new Guid(0x31B37743, 0x7C5E, 0x4005, 0x93, 0xE6, 0xE9, 0x53, 0xF9, 0x2B, 0x82, 0xE9)));
        Assert.That(PKEY_Devices_WiFiDirectServices_ServiceConfigMethods.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_WiFiDirectServices_ServiceInformation"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_WiFiDirectServices_ServiceInformationTest()
    {
        Assert.That(PKEY_Devices_WiFiDirectServices_ServiceInformation.fmtid, Is.EqualTo(new Guid(0x31B37743, 0x7C5E, 0x4005, 0x93, 0xE6, 0xE9, 0x53, 0xF9, 0x2B, 0x82, 0xE9)));
        Assert.That(PKEY_Devices_WiFiDirectServices_ServiceInformation.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_WiFiDirectServices_ServiceName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_WiFiDirectServices_ServiceNameTest()
    {
        Assert.That(PKEY_Devices_WiFiDirectServices_ServiceName.fmtid, Is.EqualTo(new Guid(0x31B37743, 0x7C5E, 0x4005, 0x93, 0xE6, 0xE9, 0x53, 0xF9, 0x2B, 0x82, 0xE9)));
        Assert.That(PKEY_Devices_WiFiDirectServices_ServiceName.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_WinPhone8CameraFlags"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_WinPhone8CameraFlagsTest()
    {
        Assert.That(PKEY_Devices_WinPhone8CameraFlags.fmtid, Is.EqualTo(new Guid(0xB7B4D61C, 0x5A64, 0x4187, 0xA5, 0x2E, 0xB1, 0x53, 0x9F, 0x35, 0x90, 0x99)));
        Assert.That(PKEY_Devices_WinPhone8CameraFlags.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Devices_Wwan_InterfaceGuid"/> property is correct.</summary>
    [Test]
    public static void PKEY_Devices_Wwan_InterfaceGuidTest()
    {
        Assert.That(PKEY_Devices_Wwan_InterfaceGuid.fmtid, Is.EqualTo(new Guid(0xFF1167EB, 0xCBFC, 0x4341, 0xA5, 0x68, 0xA7, 0xC9, 0x1A, 0x68, 0x98, 0x2C)));
        Assert.That(PKEY_Devices_Wwan_InterfaceGuid.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Storage_Portable"/> property is correct.</summary>
    [Test]
    public static void PKEY_Storage_PortableTest()
    {
        Assert.That(PKEY_Storage_Portable.fmtid, Is.EqualTo(new Guid(0x4D1EBEE8, 0x0803, 0x4774, 0x98, 0x42, 0xB7, 0x7D, 0xB5, 0x02, 0x65, 0xE9)));
        Assert.That(PKEY_Storage_Portable.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Storage_RemovableMedia"/> property is correct.</summary>
    [Test]
    public static void PKEY_Storage_RemovableMediaTest()
    {
        Assert.That(PKEY_Storage_RemovableMedia.fmtid, Is.EqualTo(new Guid(0x4D1EBEE8, 0x0803, 0x4774, 0x98, 0x42, 0xB7, 0x7D, 0xB5, 0x02, 0x65, 0xE9)));
        Assert.That(PKEY_Storage_RemovableMedia.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Storage_SystemCritical"/> property is correct.</summary>
    [Test]
    public static void PKEY_Storage_SystemCriticalTest()
    {
        Assert.That(PKEY_Storage_SystemCritical.fmtid, Is.EqualTo(new Guid(0x4D1EBEE8, 0x0803, 0x4774, 0x98, 0x42, 0xB7, 0x7D, 0xB5, 0x02, 0x65, 0xE9)));
        Assert.That(PKEY_Storage_SystemCritical.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Document_ByteCount"/> property is correct.</summary>
    [Test]
    public static void PKEY_Document_ByteCountTest()
    {
        Assert.That(PKEY_Document_ByteCount.fmtid, Is.EqualTo(new Guid(0xD5CDD502, 0x2E9C, 0x101B, 0x93, 0x97, 0x08, 0x00, 0x2B, 0x2C, 0xF9, 0xAE)));
        Assert.That(PKEY_Document_ByteCount.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Document_CharacterCount"/> property is correct.</summary>
    [Test]
    public static void PKEY_Document_CharacterCountTest()
    {
        Assert.That(PKEY_Document_CharacterCount.fmtid, Is.EqualTo(new Guid(0xF29F85E0, 0x4FF9, 0x1068, 0xAB, 0x91, 0x08, 0x00, 0x2B, 0x27, 0xB3, 0xD9)));
        Assert.That(PKEY_Document_CharacterCount.pid, Is.EqualTo(16));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Document_ClientID"/> property is correct.</summary>
    [Test]
    public static void PKEY_Document_ClientIDTest()
    {
        Assert.That(PKEY_Document_ClientID.fmtid, Is.EqualTo(new Guid(0x276D7BB0, 0x5B34, 0x4FB0, 0xAA, 0x4B, 0x15, 0x8E, 0xD1, 0x2A, 0x18, 0x09)));
        Assert.That(PKEY_Document_ClientID.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Document_Contributor"/> property is correct.</summary>
    [Test]
    public static void PKEY_Document_ContributorTest()
    {
        Assert.That(PKEY_Document_Contributor.fmtid, Is.EqualTo(new Guid(0xF334115E, 0xDA1B, 0x4509, 0x9B, 0x3D, 0x11, 0x95, 0x04, 0xDC, 0x7A, 0xBB)));
        Assert.That(PKEY_Document_Contributor.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Document_DateCreated"/> property is correct.</summary>
    [Test]
    public static void PKEY_Document_DateCreatedTest()
    {
        Assert.That(PKEY_Document_DateCreated.fmtid, Is.EqualTo(new Guid(0xF29F85E0, 0x4FF9, 0x1068, 0xAB, 0x91, 0x08, 0x00, 0x2B, 0x27, 0xB3, 0xD9)));
        Assert.That(PKEY_Document_DateCreated.pid, Is.EqualTo(12));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Document_DatePrinted"/> property is correct.</summary>
    [Test]
    public static void PKEY_Document_DatePrintedTest()
    {
        Assert.That(PKEY_Document_DatePrinted.fmtid, Is.EqualTo(new Guid(0xF29F85E0, 0x4FF9, 0x1068, 0xAB, 0x91, 0x08, 0x00, 0x2B, 0x27, 0xB3, 0xD9)));
        Assert.That(PKEY_Document_DatePrinted.pid, Is.EqualTo(11));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Document_DateSaved"/> property is correct.</summary>
    [Test]
    public static void PKEY_Document_DateSavedTest()
    {
        Assert.That(PKEY_Document_DateSaved.fmtid, Is.EqualTo(new Guid(0xF29F85E0, 0x4FF9, 0x1068, 0xAB, 0x91, 0x08, 0x00, 0x2B, 0x27, 0xB3, 0xD9)));
        Assert.That(PKEY_Document_DateSaved.pid, Is.EqualTo(13));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Document_Division"/> property is correct.</summary>
    [Test]
    public static void PKEY_Document_DivisionTest()
    {
        Assert.That(PKEY_Document_Division.fmtid, Is.EqualTo(new Guid(0x1E005EE6, 0xBF27, 0x428B, 0xB0, 0x1C, 0x79, 0x67, 0x6A, 0xCD, 0x28, 0x70)));
        Assert.That(PKEY_Document_Division.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Document_DocumentID"/> property is correct.</summary>
    [Test]
    public static void PKEY_Document_DocumentIDTest()
    {
        Assert.That(PKEY_Document_DocumentID.fmtid, Is.EqualTo(new Guid(0xE08805C8, 0xE395, 0x40DF, 0x80, 0xD2, 0x54, 0xF0, 0xD6, 0xC4, 0x31, 0x54)));
        Assert.That(PKEY_Document_DocumentID.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Document_HiddenSlideCount"/> property is correct.</summary>
    [Test]
    public static void PKEY_Document_HiddenSlideCountTest()
    {
        Assert.That(PKEY_Document_HiddenSlideCount.fmtid, Is.EqualTo(new Guid(0xD5CDD502, 0x2E9C, 0x101B, 0x93, 0x97, 0x08, 0x00, 0x2B, 0x2C, 0xF9, 0xAE)));
        Assert.That(PKEY_Document_HiddenSlideCount.pid, Is.EqualTo(9));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Document_LastAuthor"/> property is correct.</summary>
    [Test]
    public static void PKEY_Document_LastAuthorTest()
    {
        Assert.That(PKEY_Document_LastAuthor.fmtid, Is.EqualTo(new Guid(0xF29F85E0, 0x4FF9, 0x1068, 0xAB, 0x91, 0x08, 0x00, 0x2B, 0x27, 0xB3, 0xD9)));
        Assert.That(PKEY_Document_LastAuthor.pid, Is.EqualTo(8));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Document_LineCount"/> property is correct.</summary>
    [Test]
    public static void PKEY_Document_LineCountTest()
    {
        Assert.That(PKEY_Document_LineCount.fmtid, Is.EqualTo(new Guid(0xD5CDD502, 0x2E9C, 0x101B, 0x93, 0x97, 0x08, 0x00, 0x2B, 0x2C, 0xF9, 0xAE)));
        Assert.That(PKEY_Document_LineCount.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Document_Manager"/> property is correct.</summary>
    [Test]
    public static void PKEY_Document_ManagerTest()
    {
        Assert.That(PKEY_Document_Manager.fmtid, Is.EqualTo(new Guid(0xD5CDD502, 0x2E9C, 0x101B, 0x93, 0x97, 0x08, 0x00, 0x2B, 0x2C, 0xF9, 0xAE)));
        Assert.That(PKEY_Document_Manager.pid, Is.EqualTo(14));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Document_MultimediaClipCount"/> property is correct.</summary>
    [Test]
    public static void PKEY_Document_MultimediaClipCountTest()
    {
        Assert.That(PKEY_Document_MultimediaClipCount.fmtid, Is.EqualTo(new Guid(0xD5CDD502, 0x2E9C, 0x101B, 0x93, 0x97, 0x08, 0x00, 0x2B, 0x2C, 0xF9, 0xAE)));
        Assert.That(PKEY_Document_MultimediaClipCount.pid, Is.EqualTo(10));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Document_NoteCount"/> property is correct.</summary>
    [Test]
    public static void PKEY_Document_NoteCountTest()
    {
        Assert.That(PKEY_Document_NoteCount.fmtid, Is.EqualTo(new Guid(0xD5CDD502, 0x2E9C, 0x101B, 0x93, 0x97, 0x08, 0x00, 0x2B, 0x2C, 0xF9, 0xAE)));
        Assert.That(PKEY_Document_NoteCount.pid, Is.EqualTo(8));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Document_PageCount"/> property is correct.</summary>
    [Test]
    public static void PKEY_Document_PageCountTest()
    {
        Assert.That(PKEY_Document_PageCount.fmtid, Is.EqualTo(new Guid(0xF29F85E0, 0x4FF9, 0x1068, 0xAB, 0x91, 0x08, 0x00, 0x2B, 0x27, 0xB3, 0xD9)));
        Assert.That(PKEY_Document_PageCount.pid, Is.EqualTo(14));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Document_ParagraphCount"/> property is correct.</summary>
    [Test]
    public static void PKEY_Document_ParagraphCountTest()
    {
        Assert.That(PKEY_Document_ParagraphCount.fmtid, Is.EqualTo(new Guid(0xD5CDD502, 0x2E9C, 0x101B, 0x93, 0x97, 0x08, 0x00, 0x2B, 0x2C, 0xF9, 0xAE)));
        Assert.That(PKEY_Document_ParagraphCount.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Document_PresentationFormat"/> property is correct.</summary>
    [Test]
    public static void PKEY_Document_PresentationFormatTest()
    {
        Assert.That(PKEY_Document_PresentationFormat.fmtid, Is.EqualTo(new Guid(0xD5CDD502, 0x2E9C, 0x101B, 0x93, 0x97, 0x08, 0x00, 0x2B, 0x2C, 0xF9, 0xAE)));
        Assert.That(PKEY_Document_PresentationFormat.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Document_RevisionNumber"/> property is correct.</summary>
    [Test]
    public static void PKEY_Document_RevisionNumberTest()
    {
        Assert.That(PKEY_Document_RevisionNumber.fmtid, Is.EqualTo(new Guid(0xF29F85E0, 0x4FF9, 0x1068, 0xAB, 0x91, 0x08, 0x00, 0x2B, 0x27, 0xB3, 0xD9)));
        Assert.That(PKEY_Document_RevisionNumber.pid, Is.EqualTo(9));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Document_Security"/> property is correct.</summary>
    [Test]
    public static void PKEY_Document_SecurityTest()
    {
        Assert.That(PKEY_Document_Security.fmtid, Is.EqualTo(new Guid(0xF29F85E0, 0x4FF9, 0x1068, 0xAB, 0x91, 0x08, 0x00, 0x2B, 0x27, 0xB3, 0xD9)));
        Assert.That(PKEY_Document_Security.pid, Is.EqualTo(19));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Document_SlideCount"/> property is correct.</summary>
    [Test]
    public static void PKEY_Document_SlideCountTest()
    {
        Assert.That(PKEY_Document_SlideCount.fmtid, Is.EqualTo(new Guid(0xD5CDD502, 0x2E9C, 0x101B, 0x93, 0x97, 0x08, 0x00, 0x2B, 0x2C, 0xF9, 0xAE)));
        Assert.That(PKEY_Document_SlideCount.pid, Is.EqualTo(7));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Document_Template"/> property is correct.</summary>
    [Test]
    public static void PKEY_Document_TemplateTest()
    {
        Assert.That(PKEY_Document_Template.fmtid, Is.EqualTo(new Guid(0xF29F85E0, 0x4FF9, 0x1068, 0xAB, 0x91, 0x08, 0x00, 0x2B, 0x27, 0xB3, 0xD9)));
        Assert.That(PKEY_Document_Template.pid, Is.EqualTo(7));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Document_TotalEditingTime"/> property is correct.</summary>
    [Test]
    public static void PKEY_Document_TotalEditingTimeTest()
    {
        Assert.That(PKEY_Document_TotalEditingTime.fmtid, Is.EqualTo(new Guid(0xF29F85E0, 0x4FF9, 0x1068, 0xAB, 0x91, 0x08, 0x00, 0x2B, 0x27, 0xB3, 0xD9)));
        Assert.That(PKEY_Document_TotalEditingTime.pid, Is.EqualTo(10));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Document_Version"/> property is correct.</summary>
    [Test]
    public static void PKEY_Document_VersionTest()
    {
        Assert.That(PKEY_Document_Version.fmtid, Is.EqualTo(new Guid(0xD5CDD502, 0x2E9C, 0x101B, 0x93, 0x97, 0x08, 0x00, 0x2B, 0x2C, 0xF9, 0xAE)));
        Assert.That(PKEY_Document_Version.pid, Is.EqualTo(29));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Document_WordCount"/> property is correct.</summary>
    [Test]
    public static void PKEY_Document_WordCountTest()
    {
        Assert.That(PKEY_Document_WordCount.fmtid, Is.EqualTo(new Guid(0xF29F85E0, 0x4FF9, 0x1068, 0xAB, 0x91, 0x08, 0x00, 0x2B, 0x27, 0xB3, 0xD9)));
        Assert.That(PKEY_Document_WordCount.pid, Is.EqualTo(15));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DRM_DatePlayExpires"/> property is correct.</summary>
    [Test]
    public static void PKEY_DRM_DatePlayExpiresTest()
    {
        Assert.That(PKEY_DRM_DatePlayExpires.fmtid, Is.EqualTo(new Guid(0xAEAC19E4, 0x89AE, 0x4508, 0xB9, 0xB7, 0xBB, 0x86, 0x7A, 0xBE, 0xE2, 0xED)));
        Assert.That(PKEY_DRM_DatePlayExpires.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DRM_DatePlayStarts"/> property is correct.</summary>
    [Test]
    public static void PKEY_DRM_DatePlayStartsTest()
    {
        Assert.That(PKEY_DRM_DatePlayStarts.fmtid, Is.EqualTo(new Guid(0xAEAC19E4, 0x89AE, 0x4508, 0xB9, 0xB7, 0xBB, 0x86, 0x7A, 0xBE, 0xE2, 0xED)));
        Assert.That(PKEY_DRM_DatePlayStarts.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DRM_Description"/> property is correct.</summary>
    [Test]
    public static void PKEY_DRM_DescriptionTest()
    {
        Assert.That(PKEY_DRM_Description.fmtid, Is.EqualTo(new Guid(0xAEAC19E4, 0x89AE, 0x4508, 0xB9, 0xB7, 0xBB, 0x86, 0x7A, 0xBE, 0xE2, 0xED)));
        Assert.That(PKEY_DRM_Description.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DRM_IsDisabled"/> property is correct.</summary>
    [Test]
    public static void PKEY_DRM_IsDisabledTest()
    {
        Assert.That(PKEY_DRM_IsDisabled.fmtid, Is.EqualTo(new Guid(0xAEAC19E4, 0x89AE, 0x4508, 0xB9, 0xB7, 0xBB, 0x86, 0x7A, 0xBE, 0xE2, 0xED)));
        Assert.That(PKEY_DRM_IsDisabled.pid, Is.EqualTo(7));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DRM_IsProtected"/> property is correct.</summary>
    [Test]
    public static void PKEY_DRM_IsProtectedTest()
    {
        Assert.That(PKEY_DRM_IsProtected.fmtid, Is.EqualTo(new Guid(0xAEAC19E4, 0x89AE, 0x4508, 0xB9, 0xB7, 0xBB, 0x86, 0x7A, 0xBE, 0xE2, 0xED)));
        Assert.That(PKEY_DRM_IsProtected.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DRM_PlayCount"/> property is correct.</summary>
    [Test]
    public static void PKEY_DRM_PlayCountTest()
    {
        Assert.That(PKEY_DRM_PlayCount.fmtid, Is.EqualTo(new Guid(0xAEAC19E4, 0x89AE, 0x4508, 0xB9, 0xB7, 0xBB, 0x86, 0x7A, 0xBE, 0xE2, 0xED)));
        Assert.That(PKEY_DRM_PlayCount.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_Altitude"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_AltitudeTest()
    {
        Assert.That(PKEY_GPS_Altitude.fmtid, Is.EqualTo(new Guid(0x827EDB4F, 0x5B73, 0x44A7, 0x89, 0x1D, 0xFD, 0xFF, 0xAB, 0xEA, 0x35, 0xCA)));
        Assert.That(PKEY_GPS_Altitude.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_AltitudeDenominator"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_AltitudeDenominatorTest()
    {
        Assert.That(PKEY_GPS_AltitudeDenominator.fmtid, Is.EqualTo(new Guid(0x78342DCB, 0xE358, 0x4145, 0xAE, 0x9A, 0x6B, 0xFE, 0x4E, 0x0F, 0x9F, 0x51)));
        Assert.That(PKEY_GPS_AltitudeDenominator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_AltitudeNumerator"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_AltitudeNumeratorTest()
    {
        Assert.That(PKEY_GPS_AltitudeNumerator.fmtid, Is.EqualTo(new Guid(0x2DAD1EB7, 0x816D, 0x40D3, 0x9E, 0xC3, 0xC9, 0x77, 0x3B, 0xE2, 0xAA, 0xDE)));
        Assert.That(PKEY_GPS_AltitudeNumerator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_AltitudeRef"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_AltitudeRefTest()
    {
        Assert.That(PKEY_GPS_AltitudeRef.fmtid, Is.EqualTo(new Guid(0x46AC629D, 0x75EA, 0x4515, 0x86, 0x7F, 0x6D, 0xC4, 0x32, 0x1C, 0x58, 0x44)));
        Assert.That(PKEY_GPS_AltitudeRef.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_AreaInformation"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_AreaInformationTest()
    {
        Assert.That(PKEY_GPS_AreaInformation.fmtid, Is.EqualTo(new Guid(0x972E333E, 0xAC7E, 0x49F1, 0x8A, 0xDF, 0xA7, 0x0D, 0x07, 0xA9, 0xBC, 0xAB)));
        Assert.That(PKEY_GPS_AreaInformation.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_Date"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_DateTest()
    {
        Assert.That(PKEY_GPS_Date.fmtid, Is.EqualTo(new Guid(0x3602C812, 0x0F3B, 0x45F0, 0x85, 0xAD, 0x60, 0x34, 0x68, 0xD6, 0x94, 0x23)));
        Assert.That(PKEY_GPS_Date.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_DestBearing"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_DestBearingTest()
    {
        Assert.That(PKEY_GPS_DestBearing.fmtid, Is.EqualTo(new Guid(0xC66D4B3C, 0xE888, 0x47CC, 0xB9, 0x9F, 0x9D, 0xCA, 0x3E, 0xE3, 0x4D, 0xEA)));
        Assert.That(PKEY_GPS_DestBearing.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_DestBearingDenominator"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_DestBearingDenominatorTest()
    {
        Assert.That(PKEY_GPS_DestBearingDenominator.fmtid, Is.EqualTo(new Guid(0x7ABCF4F8, 0x7C3F, 0x4988, 0xAC, 0x91, 0x8D, 0x2C, 0x2E, 0x97, 0xEC, 0xA5)));
        Assert.That(PKEY_GPS_DestBearingDenominator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_DestBearingNumerator"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_DestBearingNumeratorTest()
    {
        Assert.That(PKEY_GPS_DestBearingNumerator.fmtid, Is.EqualTo(new Guid(0xBA3B1DA9, 0x86EE, 0x4B5D, 0xA2, 0xA4, 0xA2, 0x71, 0xA4, 0x29, 0xF0, 0xCF)));
        Assert.That(PKEY_GPS_DestBearingNumerator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_DestBearingRef"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_DestBearingRefTest()
    {
        Assert.That(PKEY_GPS_DestBearingRef.fmtid, Is.EqualTo(new Guid(0x9AB84393, 0x2A0F, 0x4B75, 0xBB, 0x22, 0x72, 0x79, 0x78, 0x69, 0x77, 0xCB)));
        Assert.That(PKEY_GPS_DestBearingRef.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_DestDistance"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_DestDistanceTest()
    {
        Assert.That(PKEY_GPS_DestDistance.fmtid, Is.EqualTo(new Guid(0xA93EAE04, 0x6804, 0x4F24, 0xAC, 0x81, 0x09, 0xB2, 0x66, 0x45, 0x21, 0x18)));
        Assert.That(PKEY_GPS_DestDistance.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_DestDistanceDenominator"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_DestDistanceDenominatorTest()
    {
        Assert.That(PKEY_GPS_DestDistanceDenominator.fmtid, Is.EqualTo(new Guid(0x9BC2C99B, 0xAC71, 0x4127, 0x9D, 0x1C, 0x25, 0x96, 0xD0, 0xD7, 0xDC, 0xB7)));
        Assert.That(PKEY_GPS_DestDistanceDenominator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_DestDistanceNumerator"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_DestDistanceNumeratorTest()
    {
        Assert.That(PKEY_GPS_DestDistanceNumerator.fmtid, Is.EqualTo(new Guid(0x2BDA47DA, 0x08C6, 0x4FE1, 0x80, 0xBC, 0xA7, 0x2F, 0xC5, 0x17, 0xC5, 0xD0)));
        Assert.That(PKEY_GPS_DestDistanceNumerator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_DestDistanceRef"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_DestDistanceRefTest()
    {
        Assert.That(PKEY_GPS_DestDistanceRef.fmtid, Is.EqualTo(new Guid(0xED4DF2D3, 0x8695, 0x450B, 0x85, 0x6F, 0xF5, 0xC1, 0xC5, 0x3A, 0xCB, 0x66)));
        Assert.That(PKEY_GPS_DestDistanceRef.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_DestLatitude"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_DestLatitudeTest()
    {
        Assert.That(PKEY_GPS_DestLatitude.fmtid, Is.EqualTo(new Guid(0x9D1D7CC5, 0x5C39, 0x451C, 0x86, 0xB3, 0x92, 0x8E, 0x2D, 0x18, 0xCC, 0x47)));
        Assert.That(PKEY_GPS_DestLatitude.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_DestLatitudeDenominator"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_DestLatitudeDenominatorTest()
    {
        Assert.That(PKEY_GPS_DestLatitudeDenominator.fmtid, Is.EqualTo(new Guid(0x3A372292, 0x7FCA, 0x49A7, 0x99, 0xD5, 0xE4, 0x7B, 0xB2, 0xD4, 0xE7, 0xAB)));
        Assert.That(PKEY_GPS_DestLatitudeDenominator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_DestLatitudeNumerator"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_DestLatitudeNumeratorTest()
    {
        Assert.That(PKEY_GPS_DestLatitudeNumerator.fmtid, Is.EqualTo(new Guid(0xECF4B6F6, 0xD5A6, 0x433C, 0xBB, 0x92, 0x40, 0x76, 0x65, 0x0F, 0xC8, 0x90)));
        Assert.That(PKEY_GPS_DestLatitudeNumerator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_DestLatitudeRef"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_DestLatitudeRefTest()
    {
        Assert.That(PKEY_GPS_DestLatitudeRef.fmtid, Is.EqualTo(new Guid(0xCEA820B9, 0xCE61, 0x4885, 0xA1, 0x28, 0x00, 0x5D, 0x90, 0x87, 0xC1, 0x92)));
        Assert.That(PKEY_GPS_DestLatitudeRef.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_DestLongitude"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_DestLongitudeTest()
    {
        Assert.That(PKEY_GPS_DestLongitude.fmtid, Is.EqualTo(new Guid(0x47A96261, 0xCB4C, 0x4807, 0x8A, 0xD3, 0x40, 0xB9, 0xD9, 0xDB, 0xC6, 0xBC)));
        Assert.That(PKEY_GPS_DestLongitude.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_DestLongitudeDenominator"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_DestLongitudeDenominatorTest()
    {
        Assert.That(PKEY_GPS_DestLongitudeDenominator.fmtid, Is.EqualTo(new Guid(0x425D69E5, 0x48AD, 0x4900, 0x8D, 0x80, 0x6E, 0xB6, 0xB8, 0xD0, 0xAC, 0x86)));
        Assert.That(PKEY_GPS_DestLongitudeDenominator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_DestLongitudeNumerator"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_DestLongitudeNumeratorTest()
    {
        Assert.That(PKEY_GPS_DestLongitudeNumerator.fmtid, Is.EqualTo(new Guid(0xA3250282, 0xFB6D, 0x48D5, 0x9A, 0x89, 0xDB, 0xCA, 0xCE, 0x75, 0xCC, 0xCF)));
        Assert.That(PKEY_GPS_DestLongitudeNumerator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_DestLongitudeRef"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_DestLongitudeRefTest()
    {
        Assert.That(PKEY_GPS_DestLongitudeRef.fmtid, Is.EqualTo(new Guid(0x182C1EA6, 0x7C1C, 0x4083, 0xAB, 0x4B, 0xAC, 0x6C, 0x9F, 0x4E, 0xD1, 0x28)));
        Assert.That(PKEY_GPS_DestLongitudeRef.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_Differential"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_DifferentialTest()
    {
        Assert.That(PKEY_GPS_Differential.fmtid, Is.EqualTo(new Guid(0xAAF4EE25, 0xBD3B, 0x4DD7, 0xBF, 0xC4, 0x47, 0xF7, 0x7B, 0xB0, 0x0F, 0x6D)));
        Assert.That(PKEY_GPS_Differential.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_DOP"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_DOPTest()
    {
        Assert.That(PKEY_GPS_DOP.fmtid, Is.EqualTo(new Guid(0x0CF8FB02, 0x1837, 0x42F1, 0xA6, 0x97, 0xA7, 0x01, 0x7A, 0xA2, 0x89, 0xB9)));
        Assert.That(PKEY_GPS_DOP.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_DOPDenominator"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_DOPDenominatorTest()
    {
        Assert.That(PKEY_GPS_DOPDenominator.fmtid, Is.EqualTo(new Guid(0xA0BE94C5, 0x50BA, 0x487B, 0xBD, 0x35, 0x06, 0x54, 0xBE, 0x88, 0x81, 0xED)));
        Assert.That(PKEY_GPS_DOPDenominator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_DOPNumerator"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_DOPNumeratorTest()
    {
        Assert.That(PKEY_GPS_DOPNumerator.fmtid, Is.EqualTo(new Guid(0x47166B16, 0x364F, 0x4AA0, 0x9F, 0x31, 0xE2, 0xAB, 0x3D, 0xF4, 0x49, 0xC3)));
        Assert.That(PKEY_GPS_DOPNumerator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_ImgDirection"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_ImgDirectionTest()
    {
        Assert.That(PKEY_GPS_ImgDirection.fmtid, Is.EqualTo(new Guid(0x16473C91, 0xD017, 0x4ED9, 0xBA, 0x4D, 0xB6, 0xBA, 0xA5, 0x5D, 0xBC, 0xF8)));
        Assert.That(PKEY_GPS_ImgDirection.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_ImgDirectionDenominator"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_ImgDirectionDenominatorTest()
    {
        Assert.That(PKEY_GPS_ImgDirectionDenominator.fmtid, Is.EqualTo(new Guid(0x10B24595, 0x41A2, 0x4E20, 0x93, 0xC2, 0x57, 0x61, 0xC1, 0x39, 0x5F, 0x32)));
        Assert.That(PKEY_GPS_ImgDirectionDenominator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_ImgDirectionNumerator"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_ImgDirectionNumeratorTest()
    {
        Assert.That(PKEY_GPS_ImgDirectionNumerator.fmtid, Is.EqualTo(new Guid(0xDC5877C7, 0x225F, 0x45F7, 0xBA, 0xC7, 0xE8, 0x13, 0x34, 0xB6, 0x13, 0x0A)));
        Assert.That(PKEY_GPS_ImgDirectionNumerator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_ImgDirectionRef"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_ImgDirectionRefTest()
    {
        Assert.That(PKEY_GPS_ImgDirectionRef.fmtid, Is.EqualTo(new Guid(0xA4AAA5B7, 0x1AD0, 0x445F, 0x81, 0x1A, 0x0F, 0x8F, 0x6E, 0x67, 0xF6, 0xB5)));
        Assert.That(PKEY_GPS_ImgDirectionRef.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_Latitude"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_LatitudeTest()
    {
        Assert.That(PKEY_GPS_Latitude.fmtid, Is.EqualTo(new Guid(0x8727CFFF, 0x4868, 0x4EC6, 0xAD, 0x5B, 0x81, 0xB9, 0x85, 0x21, 0xD1, 0xAB)));
        Assert.That(PKEY_GPS_Latitude.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_LatitudeDecimal"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_LatitudeDecimalTest()
    {
        Assert.That(PKEY_GPS_LatitudeDecimal.fmtid, Is.EqualTo(new Guid(0x0F55CDE2, 0x4F49, 0x450D, 0x92, 0xC1, 0xDC, 0xD1, 0x63, 0x01, 0xB1, 0xB7)));
        Assert.That(PKEY_GPS_LatitudeDecimal.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_LatitudeDenominator"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_LatitudeDenominatorTest()
    {
        Assert.That(PKEY_GPS_LatitudeDenominator.fmtid, Is.EqualTo(new Guid(0x16E634EE, 0x2BFF, 0x497B, 0xBD, 0x8A, 0x43, 0x41, 0xAD, 0x39, 0xEE, 0xB9)));
        Assert.That(PKEY_GPS_LatitudeDenominator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_LatitudeNumerator"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_LatitudeNumeratorTest()
    {
        Assert.That(PKEY_GPS_LatitudeNumerator.fmtid, Is.EqualTo(new Guid(0x7DDAAAD1, 0xCCC8, 0x41AE, 0xB7, 0x50, 0xB2, 0xCB, 0x80, 0x31, 0xAE, 0xA2)));
        Assert.That(PKEY_GPS_LatitudeNumerator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_LatitudeRef"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_LatitudeRefTest()
    {
        Assert.That(PKEY_GPS_LatitudeRef.fmtid, Is.EqualTo(new Guid(0x029C0252, 0x5B86, 0x46C7, 0xAC, 0xA0, 0x27, 0x69, 0xFF, 0xC8, 0xE3, 0xD4)));
        Assert.That(PKEY_GPS_LatitudeRef.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_Longitude"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_LongitudeTest()
    {
        Assert.That(PKEY_GPS_Longitude.fmtid, Is.EqualTo(new Guid(0xC4C4DBB2, 0xB593, 0x466B, 0xBB, 0xDA, 0xD0, 0x3D, 0x27, 0xD5, 0xE4, 0x3A)));
        Assert.That(PKEY_GPS_Longitude.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_LongitudeDecimal"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_LongitudeDecimalTest()
    {
        Assert.That(PKEY_GPS_LongitudeDecimal.fmtid, Is.EqualTo(new Guid(0x4679C1B5, 0x844D, 0x4590, 0xBA, 0xF5, 0xF3, 0x22, 0x23, 0x1F, 0x1B, 0x81)));
        Assert.That(PKEY_GPS_LongitudeDecimal.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_LongitudeDenominator"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_LongitudeDenominatorTest()
    {
        Assert.That(PKEY_GPS_LongitudeDenominator.fmtid, Is.EqualTo(new Guid(0xBE6E176C, 0x4534, 0x4D2C, 0xAC, 0xE5, 0x31, 0xDE, 0xDA, 0xC1, 0x60, 0x6B)));
        Assert.That(PKEY_GPS_LongitudeDenominator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_LongitudeNumerator"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_LongitudeNumeratorTest()
    {
        Assert.That(PKEY_GPS_LongitudeNumerator.fmtid, Is.EqualTo(new Guid(0x02B0F689, 0xA914, 0x4E45, 0x82, 0x1D, 0x1D, 0xDA, 0x45, 0x2E, 0xD2, 0xC4)));
        Assert.That(PKEY_GPS_LongitudeNumerator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_LongitudeRef"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_LongitudeRefTest()
    {
        Assert.That(PKEY_GPS_LongitudeRef.fmtid, Is.EqualTo(new Guid(0x33DCF22B, 0x28D5, 0x464C, 0x80, 0x35, 0x1E, 0xE9, 0xEF, 0xD2, 0x52, 0x78)));
        Assert.That(PKEY_GPS_LongitudeRef.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_MapDatum"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_MapDatumTest()
    {
        Assert.That(PKEY_GPS_MapDatum.fmtid, Is.EqualTo(new Guid(0x2CA2DAE6, 0xEDDC, 0x407D, 0xBE, 0xF1, 0x77, 0x39, 0x42, 0xAB, 0xFA, 0x95)));
        Assert.That(PKEY_GPS_MapDatum.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_MeasureMode"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_MeasureModeTest()
    {
        Assert.That(PKEY_GPS_MeasureMode.fmtid, Is.EqualTo(new Guid(0xA015ED5D, 0xAAEA, 0x4D58, 0x8A, 0x86, 0x3C, 0x58, 0x69, 0x20, 0xEA, 0x0B)));
        Assert.That(PKEY_GPS_MeasureMode.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_ProcessingMethod"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_ProcessingMethodTest()
    {
        Assert.That(PKEY_GPS_ProcessingMethod.fmtid, Is.EqualTo(new Guid(0x59D49E61, 0x840F, 0x4AA9, 0xA9, 0x39, 0xE2, 0x09, 0x9B, 0x7F, 0x63, 0x99)));
        Assert.That(PKEY_GPS_ProcessingMethod.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_Satellites"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_SatellitesTest()
    {
        Assert.That(PKEY_GPS_Satellites.fmtid, Is.EqualTo(new Guid(0x467EE575, 0x1F25, 0x4557, 0xAD, 0x4E, 0xB8, 0xB5, 0x8B, 0x0D, 0x9C, 0x15)));
        Assert.That(PKEY_GPS_Satellites.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_Speed"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_SpeedTest()
    {
        Assert.That(PKEY_GPS_Speed.fmtid, Is.EqualTo(new Guid(0xDA5D0862, 0x6E76, 0x4E1B, 0xBA, 0xBD, 0x70, 0x02, 0x1B, 0xD2, 0x54, 0x94)));
        Assert.That(PKEY_GPS_Speed.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_SpeedDenominator"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_SpeedDenominatorTest()
    {
        Assert.That(PKEY_GPS_SpeedDenominator.fmtid, Is.EqualTo(new Guid(0x7D122D5A, 0xAE5E, 0x4335, 0x88, 0x41, 0xD7, 0x1E, 0x7C, 0xE7, 0x2F, 0x53)));
        Assert.That(PKEY_GPS_SpeedDenominator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_SpeedNumerator"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_SpeedNumeratorTest()
    {
        Assert.That(PKEY_GPS_SpeedNumerator.fmtid, Is.EqualTo(new Guid(0xACC9CE3D, 0xC213, 0x4942, 0x8B, 0x48, 0x6D, 0x08, 0x20, 0xF2, 0x1C, 0x6D)));
        Assert.That(PKEY_GPS_SpeedNumerator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_SpeedRef"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_SpeedRefTest()
    {
        Assert.That(PKEY_GPS_SpeedRef.fmtid, Is.EqualTo(new Guid(0xECF7F4C9, 0x544F, 0x4D6D, 0x9D, 0x98, 0x8A, 0xD7, 0x9A, 0xDA, 0xF4, 0x53)));
        Assert.That(PKEY_GPS_SpeedRef.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_Status"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_StatusTest()
    {
        Assert.That(PKEY_GPS_Status.fmtid, Is.EqualTo(new Guid(0x125491F4, 0x818F, 0x46B2, 0x91, 0xB5, 0xD5, 0x37, 0x75, 0x36, 0x17, 0xB2)));
        Assert.That(PKEY_GPS_Status.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_Track"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_TrackTest()
    {
        Assert.That(PKEY_GPS_Track.fmtid, Is.EqualTo(new Guid(0x76C09943, 0x7C33, 0x49E3, 0x9E, 0x7E, 0xCD, 0xBA, 0x87, 0x2C, 0xFA, 0xDA)));
        Assert.That(PKEY_GPS_Track.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_TrackDenominator"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_TrackDenominatorTest()
    {
        Assert.That(PKEY_GPS_TrackDenominator.fmtid, Is.EqualTo(new Guid(0xC8D1920C, 0x01F6, 0x40C0, 0xAC, 0x86, 0x2F, 0x3A, 0x4A, 0xD0, 0x07, 0x70)));
        Assert.That(PKEY_GPS_TrackDenominator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_TrackNumerator"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_TrackNumeratorTest()
    {
        Assert.That(PKEY_GPS_TrackNumerator.fmtid, Is.EqualTo(new Guid(0x702926F4, 0x44A6, 0x43E1, 0xAE, 0x71, 0x45, 0x62, 0x71, 0x16, 0x89, 0x3B)));
        Assert.That(PKEY_GPS_TrackNumerator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_TrackRef"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_TrackRefTest()
    {
        Assert.That(PKEY_GPS_TrackRef.fmtid, Is.EqualTo(new Guid(0x35DBE6FE, 0x44C3, 0x4400, 0xAA, 0xAE, 0xD2, 0xC7, 0x99, 0xC4, 0x07, 0xE8)));
        Assert.That(PKEY_GPS_TrackRef.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_GPS_VersionID"/> property is correct.</summary>
    [Test]
    public static void PKEY_GPS_VersionIDTest()
    {
        Assert.That(PKEY_GPS_VersionID.fmtid, Is.EqualTo(new Guid(0x22704DA4, 0xC6B2, 0x4A99, 0x8E, 0x56, 0xF1, 0x6D, 0xF8, 0xC9, 0x25, 0x99)));
        Assert.That(PKEY_GPS_VersionID.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_History_VisitCount"/> property is correct.</summary>
    [Test]
    public static void PKEY_History_VisitCountTest()
    {
        Assert.That(PKEY_History_VisitCount.fmtid, Is.EqualTo(new Guid(0x5CBF2787, 0x48CF, 0x4208, 0xB9, 0x0E, 0xEE, 0x5E, 0x5D, 0x42, 0x02, 0x94)));
        Assert.That(PKEY_History_VisitCount.pid, Is.EqualTo(7));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Image_BitDepth"/> property is correct.</summary>
    [Test]
    public static void PKEY_Image_BitDepthTest()
    {
        Assert.That(PKEY_Image_BitDepth.fmtid, Is.EqualTo(new Guid(0x6444048F, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Image_BitDepth.pid, Is.EqualTo(7));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Image_ColorSpace"/> property is correct.</summary>
    [Test]
    public static void PKEY_Image_ColorSpaceTest()
    {
        Assert.That(PKEY_Image_ColorSpace.fmtid, Is.EqualTo(new Guid(0x14B81DA1, 0x0135, 0x4D31, 0x96, 0xD9, 0x6C, 0xBF, 0xC9, 0x67, 0x1A, 0x99)));
        Assert.That(PKEY_Image_ColorSpace.pid, Is.EqualTo(40961));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Image_CompressedBitsPerPixel"/> property is correct.</summary>
    [Test]
    public static void PKEY_Image_CompressedBitsPerPixelTest()
    {
        Assert.That(PKEY_Image_CompressedBitsPerPixel.fmtid, Is.EqualTo(new Guid(0x364B6FA9, 0x37AB, 0x482A, 0xBE, 0x2B, 0xAE, 0x02, 0xF6, 0x0D, 0x43, 0x18)));
        Assert.That(PKEY_Image_CompressedBitsPerPixel.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Image_CompressedBitsPerPixelDenominator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Image_CompressedBitsPerPixelDenominatorTest()
    {
        Assert.That(PKEY_Image_CompressedBitsPerPixelDenominator.fmtid, Is.EqualTo(new Guid(0x1F8844E1, 0x24AD, 0x4508, 0x9D, 0xFD, 0x53, 0x26, 0xA4, 0x15, 0xCE, 0x02)));
        Assert.That(PKEY_Image_CompressedBitsPerPixelDenominator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Image_CompressedBitsPerPixelNumerator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Image_CompressedBitsPerPixelNumeratorTest()
    {
        Assert.That(PKEY_Image_CompressedBitsPerPixelNumerator.fmtid, Is.EqualTo(new Guid(0xD21A7148, 0xD32C, 0x4624, 0x89, 0x00, 0x27, 0x72, 0x10, 0xF7, 0x9C, 0x0F)));
        Assert.That(PKEY_Image_CompressedBitsPerPixelNumerator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Image_Compression"/> property is correct.</summary>
    [Test]
    public static void PKEY_Image_CompressionTest()
    {
        Assert.That(PKEY_Image_Compression.fmtid, Is.EqualTo(new Guid(0x14B81DA1, 0x0135, 0x4D31, 0x96, 0xD9, 0x6C, 0xBF, 0xC9, 0x67, 0x1A, 0x99)));
        Assert.That(PKEY_Image_Compression.pid, Is.EqualTo(259));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Image_CompressionText"/> property is correct.</summary>
    [Test]
    public static void PKEY_Image_CompressionTextTest()
    {
        Assert.That(PKEY_Image_CompressionText.fmtid, Is.EqualTo(new Guid(0x3F08E66F, 0x2F44, 0x4BB9, 0xA6, 0x82, 0xAC, 0x35, 0xD2, 0x56, 0x23, 0x22)));
        Assert.That(PKEY_Image_CompressionText.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Image_Dimensions"/> property is correct.</summary>
    [Test]
    public static void PKEY_Image_DimensionsTest()
    {
        Assert.That(PKEY_Image_Dimensions.fmtid, Is.EqualTo(new Guid(0x6444048F, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Image_Dimensions.pid, Is.EqualTo(13));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Image_HorizontalResolution"/> property is correct.</summary>
    [Test]
    public static void PKEY_Image_HorizontalResolutionTest()
    {
        Assert.That(PKEY_Image_HorizontalResolution.fmtid, Is.EqualTo(new Guid(0x6444048F, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Image_HorizontalResolution.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Image_HorizontalSize"/> property is correct.</summary>
    [Test]
    public static void PKEY_Image_HorizontalSizeTest()
    {
        Assert.That(PKEY_Image_HorizontalSize.fmtid, Is.EqualTo(new Guid(0x6444048F, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Image_HorizontalSize.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Image_ImageID"/> property is correct.</summary>
    [Test]
    public static void PKEY_Image_ImageIDTest()
    {
        Assert.That(PKEY_Image_ImageID.fmtid, Is.EqualTo(new Guid(0x10DABE05, 0x32AA, 0x4C29, 0xBF, 0x1A, 0x63, 0xE2, 0xD2, 0x20, 0x58, 0x7F)));
        Assert.That(PKEY_Image_ImageID.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Image_ResolutionUnit"/> property is correct.</summary>
    [Test]
    public static void PKEY_Image_ResolutionUnitTest()
    {
        Assert.That(PKEY_Image_ResolutionUnit.fmtid, Is.EqualTo(new Guid(0x19B51FA6, 0x1F92, 0x4A5C, 0xAB, 0x48, 0x7D, 0xF0, 0xAB, 0xD6, 0x74, 0x44)));
        Assert.That(PKEY_Image_ResolutionUnit.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Image_VerticalResolution"/> property is correct.</summary>
    [Test]
    public static void PKEY_Image_VerticalResolutionTest()
    {
        Assert.That(PKEY_Image_VerticalResolution.fmtid, Is.EqualTo(new Guid(0x6444048F, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Image_VerticalResolution.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Image_VerticalSize"/> property is correct.</summary>
    [Test]
    public static void PKEY_Image_VerticalSizeTest()
    {
        Assert.That(PKEY_Image_VerticalSize.fmtid, Is.EqualTo(new Guid(0x6444048F, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Image_VerticalSize.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Journal_Contacts"/> property is correct.</summary>
    [Test]
    public static void PKEY_Journal_ContactsTest()
    {
        Assert.That(PKEY_Journal_Contacts.fmtid, Is.EqualTo(new Guid(0xDEA7C82C, 0x1D89, 0x4A66, 0x94, 0x27, 0xA4, 0xE3, 0xDE, 0xBA, 0xBC, 0xB1)));
        Assert.That(PKEY_Journal_Contacts.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Journal_EntryType"/> property is correct.</summary>
    [Test]
    public static void PKEY_Journal_EntryTypeTest()
    {
        Assert.That(PKEY_Journal_EntryType.fmtid, Is.EqualTo(new Guid(0x95BEB1FC, 0x326D, 0x4644, 0xB3, 0x96, 0xCD, 0x3E, 0xD9, 0x0E, 0x6D, 0xDF)));
        Assert.That(PKEY_Journal_EntryType.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_LayoutPattern_ContentViewModeForBrowse"/> property is correct.</summary>
    [Test]
    public static void PKEY_LayoutPattern_ContentViewModeForBrowseTest()
    {
        Assert.That(PKEY_LayoutPattern_ContentViewModeForBrowse.fmtid, Is.EqualTo(new Guid(0xC9944A21, 0xA406, 0x48FE, 0x82, 0x25, 0xAE, 0xC7, 0xE2, 0x4C, 0x21, 0x1B)));
        Assert.That(PKEY_LayoutPattern_ContentViewModeForBrowse.pid, Is.EqualTo(500));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_LayoutPattern_ContentViewModeForSearch"/> property is correct.</summary>
    [Test]
    public static void PKEY_LayoutPattern_ContentViewModeForSearchTest()
    {
        Assert.That(PKEY_LayoutPattern_ContentViewModeForSearch.fmtid, Is.EqualTo(new Guid(0xC9944A21, 0xA406, 0x48FE, 0x82, 0x25, 0xAE, 0xC7, 0xE2, 0x4C, 0x21, 0x1B)));
        Assert.That(PKEY_LayoutPattern_ContentViewModeForSearch.pid, Is.EqualTo(501));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_History_SelectionCount"/> property is correct.</summary>
    [Test]
    public static void PKEY_History_SelectionCountTest()
    {
        Assert.That(PKEY_History_SelectionCount.fmtid, Is.EqualTo(new Guid(0x1CE0D6BC, 0x536C, 0x4600, 0xB0, 0xDD, 0x7E, 0x0C, 0x66, 0xB3, 0x50, 0xD5)));
        Assert.That(PKEY_History_SelectionCount.pid, Is.EqualTo(8));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_History_TargetUrlHostName"/> property is correct.</summary>
    [Test]
    public static void PKEY_History_TargetUrlHostNameTest()
    {
        Assert.That(PKEY_History_TargetUrlHostName.fmtid, Is.EqualTo(new Guid(0x1CE0D6BC, 0x536C, 0x4600, 0xB0, 0xDD, 0x7E, 0x0C, 0x66, 0xB3, 0x50, 0xD5)));
        Assert.That(PKEY_History_TargetUrlHostName.pid, Is.EqualTo(9));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Link_Arguments"/> property is correct.</summary>
    [Test]
    public static void PKEY_Link_ArgumentsTest()
    {
        Assert.That(PKEY_Link_Arguments.fmtid, Is.EqualTo(new Guid(0x436F2667, 0x14E2, 0x4FEB, 0xB3, 0x0A, 0x14, 0x6C, 0x53, 0xB5, 0xB6, 0x74)));
        Assert.That(PKEY_Link_Arguments.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Link_Comment"/> property is correct.</summary>
    [Test]
    public static void PKEY_Link_CommentTest()
    {
        Assert.That(PKEY_Link_Comment.fmtid, Is.EqualTo(new Guid(0xB9B4B3FC, 0x2B51, 0x4A42, 0xB5, 0xD8, 0x32, 0x41, 0x46, 0xAF, 0xCF, 0x25)));
        Assert.That(PKEY_Link_Comment.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Link_DateVisited"/> property is correct.</summary>
    [Test]
    public static void PKEY_Link_DateVisitedTest()
    {
        Assert.That(PKEY_Link_DateVisited.fmtid, Is.EqualTo(new Guid(0x5CBF2787, 0x48CF, 0x4208, 0xB9, 0x0E, 0xEE, 0x5E, 0x5D, 0x42, 0x02, 0x94)));
        Assert.That(PKEY_Link_DateVisited.pid, Is.EqualTo(23));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Link_Description"/> property is correct.</summary>
    [Test]
    public static void PKEY_Link_DescriptionTest()
    {
        Assert.That(PKEY_Link_Description.fmtid, Is.EqualTo(new Guid(0x5CBF2787, 0x48CF, 0x4208, 0xB9, 0x0E, 0xEE, 0x5E, 0x5D, 0x42, 0x02, 0x94)));
        Assert.That(PKEY_Link_Description.pid, Is.EqualTo(21));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Link_FeedItemLocalId"/> property is correct.</summary>
    [Test]
    public static void PKEY_Link_FeedItemLocalIdTest()
    {
        Assert.That(PKEY_Link_FeedItemLocalId.fmtid, Is.EqualTo(new Guid(0x8A2F99F9, 0x3C37, 0x465D, 0xA8, 0xD7, 0x69, 0x77, 0x7A, 0x24, 0x6D, 0x0C)));
        Assert.That(PKEY_Link_FeedItemLocalId.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Link_Status"/> property is correct.</summary>
    [Test]
    public static void PKEY_Link_StatusTest()
    {
        Assert.That(PKEY_Link_Status.fmtid, Is.EqualTo(new Guid(0xB9B4B3FC, 0x2B51, 0x4A42, 0xB5, 0xD8, 0x32, 0x41, 0x46, 0xAF, 0xCF, 0x25)));
        Assert.That(PKEY_Link_Status.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Link_TargetExtension"/> property is correct.</summary>
    [Test]
    public static void PKEY_Link_TargetExtensionTest()
    {
        Assert.That(PKEY_Link_TargetExtension.fmtid, Is.EqualTo(new Guid(0x7A7D76F4, 0xB630, 0x4BD7, 0x95, 0xFF, 0x37, 0xCC, 0x51, 0xA9, 0x75, 0xC9)));
        Assert.That(PKEY_Link_TargetExtension.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Link_TargetParsingPath"/> property is correct.</summary>
    [Test]
    public static void PKEY_Link_TargetParsingPathTest()
    {
        Assert.That(PKEY_Link_TargetParsingPath.fmtid, Is.EqualTo(new Guid(0xB9B4B3FC, 0x2B51, 0x4A42, 0xB5, 0xD8, 0x32, 0x41, 0x46, 0xAF, 0xCF, 0x25)));
        Assert.That(PKEY_Link_TargetParsingPath.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Link_TargetSFGAOFlags"/> property is correct.</summary>
    [Test]
    public static void PKEY_Link_TargetSFGAOFlagsTest()
    {
        Assert.That(PKEY_Link_TargetSFGAOFlags.fmtid, Is.EqualTo(new Guid(0xB9B4B3FC, 0x2B51, 0x4A42, 0xB5, 0xD8, 0x32, 0x41, 0x46, 0xAF, 0xCF, 0x25)));
        Assert.That(PKEY_Link_TargetSFGAOFlags.pid, Is.EqualTo(8));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Link_TargetUrlHostName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Link_TargetUrlHostNameTest()
    {
        Assert.That(PKEY_Link_TargetUrlHostName.fmtid, Is.EqualTo(new Guid(0x8A2F99F9, 0x3C37, 0x465D, 0xA8, 0xD7, 0x69, 0x77, 0x7A, 0x24, 0x6D, 0x0C)));
        Assert.That(PKEY_Link_TargetUrlHostName.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Link_TargetUrlPath"/> property is correct.</summary>
    [Test]
    public static void PKEY_Link_TargetUrlPathTest()
    {
        Assert.That(PKEY_Link_TargetUrlPath.fmtid, Is.EqualTo(new Guid(0x8A2F99F9, 0x3C37, 0x465D, 0xA8, 0xD7, 0x69, 0x77, 0x7A, 0x24, 0x6D, 0x0C)));
        Assert.That(PKEY_Link_TargetUrlPath.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_AuthorUrl"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_AuthorUrlTest()
    {
        Assert.That(PKEY_Media_AuthorUrl.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_AuthorUrl.pid, Is.EqualTo(32));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_AverageLevel"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_AverageLevelTest()
    {
        Assert.That(PKEY_Media_AverageLevel.fmtid, Is.EqualTo(new Guid(0x09EDD5B6, 0xB301, 0x43C5, 0x99, 0x90, 0xD0, 0x03, 0x02, 0xEF, 0xFD, 0x46)));
        Assert.That(PKEY_Media_AverageLevel.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_ClassPrimaryID"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_ClassPrimaryIDTest()
    {
        Assert.That(PKEY_Media_ClassPrimaryID.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_ClassPrimaryID.pid, Is.EqualTo(13));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_ClassSecondaryID"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_ClassSecondaryIDTest()
    {
        Assert.That(PKEY_Media_ClassSecondaryID.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_ClassSecondaryID.pid, Is.EqualTo(14));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_CollectionGroupID"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_CollectionGroupIDTest()
    {
        Assert.That(PKEY_Media_CollectionGroupID.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_CollectionGroupID.pid, Is.EqualTo(24));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_CollectionID"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_CollectionIDTest()
    {
        Assert.That(PKEY_Media_CollectionID.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_CollectionID.pid, Is.EqualTo(25));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_ContentDistributor"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_ContentDistributorTest()
    {
        Assert.That(PKEY_Media_ContentDistributor.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_ContentDistributor.pid, Is.EqualTo(18));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_ContentID"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_ContentIDTest()
    {
        Assert.That(PKEY_Media_ContentID.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_ContentID.pid, Is.EqualTo(26));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_CreatorApplication"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_CreatorApplicationTest()
    {
        Assert.That(PKEY_Media_CreatorApplication.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_CreatorApplication.pid, Is.EqualTo(27));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_CreatorApplicationVersion"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_CreatorApplicationVersionTest()
    {
        Assert.That(PKEY_Media_CreatorApplicationVersion.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_CreatorApplicationVersion.pid, Is.EqualTo(28));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_DateEncoded"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_DateEncodedTest()
    {
        Assert.That(PKEY_Media_DateEncoded.fmtid, Is.EqualTo(new Guid(0x2E4B640D, 0x5019, 0x46D8, 0x88, 0x81, 0x55, 0x41, 0x4C, 0xC5, 0xCA, 0xA0)));
        Assert.That(PKEY_Media_DateEncoded.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_DateReleased"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_DateReleasedTest()
    {
        Assert.That(PKEY_Media_DateReleased.fmtid, Is.EqualTo(new Guid(0xDE41CC29, 0x6971, 0x4290, 0xB4, 0x72, 0xF5, 0x9F, 0x2E, 0x2F, 0x31, 0xE2)));
        Assert.That(PKEY_Media_DateReleased.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_DlnaProfileID"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_DlnaProfileIDTest()
    {
        Assert.That(PKEY_Media_DlnaProfileID.fmtid, Is.EqualTo(new Guid(0xCFA31B45, 0x525D, 0x4998, 0xBB, 0x44, 0x3F, 0x7D, 0x81, 0x54, 0x2F, 0xA4)));
        Assert.That(PKEY_Media_DlnaProfileID.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_Duration"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_DurationTest()
    {
        Assert.That(PKEY_Media_Duration.fmtid, Is.EqualTo(new Guid(0x64440490, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_Duration.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_DVDID"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_DVDIDTest()
    {
        Assert.That(PKEY_Media_DVDID.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_DVDID.pid, Is.EqualTo(15));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_EncodedBy"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_EncodedByTest()
    {
        Assert.That(PKEY_Media_EncodedBy.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_EncodedBy.pid, Is.EqualTo(36));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_EncodingSettings"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_EncodingSettingsTest()
    {
        Assert.That(PKEY_Media_EncodingSettings.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_EncodingSettings.pid, Is.EqualTo(37));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_EpisodeNumber"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_EpisodeNumberTest()
    {
        Assert.That(PKEY_Media_EpisodeNumber.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_EpisodeNumber.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_FrameCount"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_FrameCountTest()
    {
        Assert.That(PKEY_Media_FrameCount.fmtid, Is.EqualTo(new Guid(0x6444048F, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_FrameCount.pid, Is.EqualTo(12));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_MCDI"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_MCDITest()
    {
        Assert.That(PKEY_Media_MCDI.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_MCDI.pid, Is.EqualTo(16));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_MetadataContentProvider"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_MetadataContentProviderTest()
    {
        Assert.That(PKEY_Media_MetadataContentProvider.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_MetadataContentProvider.pid, Is.EqualTo(17));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_Producer"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_ProducerTest()
    {
        Assert.That(PKEY_Media_Producer.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_Producer.pid, Is.EqualTo(22));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_PromotionUrl"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_PromotionUrlTest()
    {
        Assert.That(PKEY_Media_PromotionUrl.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_PromotionUrl.pid, Is.EqualTo(33));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_ProtectionType"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_ProtectionTypeTest()
    {
        Assert.That(PKEY_Media_ProtectionType.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_ProtectionType.pid, Is.EqualTo(38));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_ProviderRating"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_ProviderRatingTest()
    {
        Assert.That(PKEY_Media_ProviderRating.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_ProviderRating.pid, Is.EqualTo(39));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_ProviderStyle"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_ProviderStyleTest()
    {
        Assert.That(PKEY_Media_ProviderStyle.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_ProviderStyle.pid, Is.EqualTo(40));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_Publisher"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_PublisherTest()
    {
        Assert.That(PKEY_Media_Publisher.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_Publisher.pid, Is.EqualTo(30));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_SeasonNumber"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_SeasonNumberTest()
    {
        Assert.That(PKEY_Media_SeasonNumber.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_SeasonNumber.pid, Is.EqualTo(101));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_SeriesName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_SeriesNameTest()
    {
        Assert.That(PKEY_Media_SeriesName.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_SeriesName.pid, Is.EqualTo(42));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_SubscriptionContentId"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_SubscriptionContentIdTest()
    {
        Assert.That(PKEY_Media_SubscriptionContentId.fmtid, Is.EqualTo(new Guid(0x9AEBAE7A, 0x9644, 0x487D, 0xA9, 0x2C, 0x65, 0x75, 0x85, 0xED, 0x75, 0x1A)));
        Assert.That(PKEY_Media_SubscriptionContentId.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_SubTitle"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_SubTitleTest()
    {
        Assert.That(PKEY_Media_SubTitle.fmtid, Is.EqualTo(new Guid(0x56A3372E, 0xCE9C, 0x11D2, 0x9F, 0x0E, 0x00, 0x60, 0x97, 0xC6, 0x86, 0xF6)));
        Assert.That(PKEY_Media_SubTitle.pid, Is.EqualTo(38));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_ThumbnailLargePath"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_ThumbnailLargePathTest()
    {
        Assert.That(PKEY_Media_ThumbnailLargePath.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_ThumbnailLargePath.pid, Is.EqualTo(47));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_ThumbnailLargeUri"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_ThumbnailLargeUriTest()
    {
        Assert.That(PKEY_Media_ThumbnailLargeUri.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_ThumbnailLargeUri.pid, Is.EqualTo(48));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_ThumbnailSmallPath"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_ThumbnailSmallPathTest()
    {
        Assert.That(PKEY_Media_ThumbnailSmallPath.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_ThumbnailSmallPath.pid, Is.EqualTo(49));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_ThumbnailSmallUri"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_ThumbnailSmallUriTest()
    {
        Assert.That(PKEY_Media_ThumbnailSmallUri.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_ThumbnailSmallUri.pid, Is.EqualTo(50));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_UniqueFileIdentifier"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_UniqueFileIdentifierTest()
    {
        Assert.That(PKEY_Media_UniqueFileIdentifier.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_UniqueFileIdentifier.pid, Is.EqualTo(35));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_UserNoAutoInfo"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_UserNoAutoInfoTest()
    {
        Assert.That(PKEY_Media_UserNoAutoInfo.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_UserNoAutoInfo.pid, Is.EqualTo(41));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_UserWebUrl"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_UserWebUrlTest()
    {
        Assert.That(PKEY_Media_UserWebUrl.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_UserWebUrl.pid, Is.EqualTo(34));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_Writer"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_WriterTest()
    {
        Assert.That(PKEY_Media_Writer.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Media_Writer.pid, Is.EqualTo(23));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Media_Year"/> property is correct.</summary>
    [Test]
    public static void PKEY_Media_YearTest()
    {
        Assert.That(PKEY_Media_Year.fmtid, Is.EqualTo(new Guid(0x56A3372E, 0xCE9C, 0x11D2, 0x9F, 0x0E, 0x00, 0x60, 0x97, 0xC6, 0x86, 0xF6)));
        Assert.That(PKEY_Media_Year.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Message_AttachmentContents"/> property is correct.</summary>
    [Test]
    public static void PKEY_Message_AttachmentContentsTest()
    {
        Assert.That(PKEY_Message_AttachmentContents.fmtid, Is.EqualTo(new Guid(0x3143BF7C, 0x80A8, 0x4854, 0x88, 0x80, 0xE2, 0xE4, 0x01, 0x89, 0xBD, 0xD0)));
        Assert.That(PKEY_Message_AttachmentContents.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Message_AttachmentNames"/> property is correct.</summary>
    [Test]
    public static void PKEY_Message_AttachmentNamesTest()
    {
        Assert.That(PKEY_Message_AttachmentNames.fmtid, Is.EqualTo(new Guid(0xE3E0584C, 0xB788, 0x4A5A, 0xBB, 0x20, 0x7F, 0x5A, 0x44, 0xC9, 0xAC, 0xDD)));
        Assert.That(PKEY_Message_AttachmentNames.pid, Is.EqualTo(21));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Message_BccAddress"/> property is correct.</summary>
    [Test]
    public static void PKEY_Message_BccAddressTest()
    {
        Assert.That(PKEY_Message_BccAddress.fmtid, Is.EqualTo(new Guid(0xE3E0584C, 0xB788, 0x4A5A, 0xBB, 0x20, 0x7F, 0x5A, 0x44, 0xC9, 0xAC, 0xDD)));
        Assert.That(PKEY_Message_BccAddress.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Message_BccName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Message_BccNameTest()
    {
        Assert.That(PKEY_Message_BccName.fmtid, Is.EqualTo(new Guid(0xE3E0584C, 0xB788, 0x4A5A, 0xBB, 0x20, 0x7F, 0x5A, 0x44, 0xC9, 0xAC, 0xDD)));
        Assert.That(PKEY_Message_BccName.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Message_CcAddress"/> property is correct.</summary>
    [Test]
    public static void PKEY_Message_CcAddressTest()
    {
        Assert.That(PKEY_Message_CcAddress.fmtid, Is.EqualTo(new Guid(0xE3E0584C, 0xB788, 0x4A5A, 0xBB, 0x20, 0x7F, 0x5A, 0x44, 0xC9, 0xAC, 0xDD)));
        Assert.That(PKEY_Message_CcAddress.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Message_CcName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Message_CcNameTest()
    {
        Assert.That(PKEY_Message_CcName.fmtid, Is.EqualTo(new Guid(0xE3E0584C, 0xB788, 0x4A5A, 0xBB, 0x20, 0x7F, 0x5A, 0x44, 0xC9, 0xAC, 0xDD)));
        Assert.That(PKEY_Message_CcName.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Message_ConversationID"/> property is correct.</summary>
    [Test]
    public static void PKEY_Message_ConversationIDTest()
    {
        Assert.That(PKEY_Message_ConversationID.fmtid, Is.EqualTo(new Guid(0xDC8F80BD, 0xAF1E, 0x4289, 0x85, 0xB6, 0x3D, 0xFC, 0x1B, 0x49, 0x39, 0x92)));
        Assert.That(PKEY_Message_ConversationID.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Message_ConversationIndex"/> property is correct.</summary>
    [Test]
    public static void PKEY_Message_ConversationIndexTest()
    {
        Assert.That(PKEY_Message_ConversationIndex.fmtid, Is.EqualTo(new Guid(0xDC8F80BD, 0xAF1E, 0x4289, 0x85, 0xB6, 0x3D, 0xFC, 0x1B, 0x49, 0x39, 0x92)));
        Assert.That(PKEY_Message_ConversationIndex.pid, Is.EqualTo(101));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Message_DateReceived"/> property is correct.</summary>
    [Test]
    public static void PKEY_Message_DateReceivedTest()
    {
        Assert.That(PKEY_Message_DateReceived.fmtid, Is.EqualTo(new Guid(0xE3E0584C, 0xB788, 0x4A5A, 0xBB, 0x20, 0x7F, 0x5A, 0x44, 0xC9, 0xAC, 0xDD)));
        Assert.That(PKEY_Message_DateReceived.pid, Is.EqualTo(20));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Message_DateSent"/> property is correct.</summary>
    [Test]
    public static void PKEY_Message_DateSentTest()
    {
        Assert.That(PKEY_Message_DateSent.fmtid, Is.EqualTo(new Guid(0xE3E0584C, 0xB788, 0x4A5A, 0xBB, 0x20, 0x7F, 0x5A, 0x44, 0xC9, 0xAC, 0xDD)));
        Assert.That(PKEY_Message_DateSent.pid, Is.EqualTo(19));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Message_Flags"/> property is correct.</summary>
    [Test]
    public static void PKEY_Message_FlagsTest()
    {
        Assert.That(PKEY_Message_Flags.fmtid, Is.EqualTo(new Guid(0xA82D9EE7, 0xCA67, 0x4312, 0x96, 0x5E, 0x22, 0x6B, 0xCE, 0xA8, 0x50, 0x23)));
        Assert.That(PKEY_Message_Flags.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Message_FromAddress"/> property is correct.</summary>
    [Test]
    public static void PKEY_Message_FromAddressTest()
    {
        Assert.That(PKEY_Message_FromAddress.fmtid, Is.EqualTo(new Guid(0xE3E0584C, 0xB788, 0x4A5A, 0xBB, 0x20, 0x7F, 0x5A, 0x44, 0xC9, 0xAC, 0xDD)));
        Assert.That(PKEY_Message_FromAddress.pid, Is.EqualTo(13));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Message_FromName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Message_FromNameTest()
    {
        Assert.That(PKEY_Message_FromName.fmtid, Is.EqualTo(new Guid(0xE3E0584C, 0xB788, 0x4A5A, 0xBB, 0x20, 0x7F, 0x5A, 0x44, 0xC9, 0xAC, 0xDD)));
        Assert.That(PKEY_Message_FromName.pid, Is.EqualTo(14));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Message_HasAttachments"/> property is correct.</summary>
    [Test]
    public static void PKEY_Message_HasAttachmentsTest()
    {
        Assert.That(PKEY_Message_HasAttachments.fmtid, Is.EqualTo(new Guid(0x9C1FCF74, 0x2D97, 0x41BA, 0xB4, 0xAE, 0xCB, 0x2E, 0x36, 0x61, 0xA6, 0xE4)));
        Assert.That(PKEY_Message_HasAttachments.pid, Is.EqualTo(8));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Message_IsFwdOrReply"/> property is correct.</summary>
    [Test]
    public static void PKEY_Message_IsFwdOrReplyTest()
    {
        Assert.That(PKEY_Message_IsFwdOrReply.fmtid, Is.EqualTo(new Guid(0x9A9BC088, 0x4F6D, 0x469E, 0x99, 0x19, 0xE7, 0x05, 0x41, 0x20, 0x40, 0xF9)));
        Assert.That(PKEY_Message_IsFwdOrReply.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Message_MessageClass"/> property is correct.</summary>
    [Test]
    public static void PKEY_Message_MessageClassTest()
    {
        Assert.That(PKEY_Message_MessageClass.fmtid, Is.EqualTo(new Guid(0xCD9ED458, 0x08CE, 0x418F, 0xA7, 0x0E, 0xF9, 0x12, 0xC7, 0xBB, 0x9C, 0x5C)));
        Assert.That(PKEY_Message_MessageClass.pid, Is.EqualTo(103));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Message_Participants"/> property is correct.</summary>
    [Test]
    public static void PKEY_Message_ParticipantsTest()
    {
        Assert.That(PKEY_Message_Participants.fmtid, Is.EqualTo(new Guid(0x1A9BA605, 0x8E7C, 0x4D11, 0xAD, 0x7D, 0xA5, 0x0A, 0xDA, 0x18, 0xBA, 0x1B)));
        Assert.That(PKEY_Message_Participants.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Message_ProofInProgress"/> property is correct.</summary>
    [Test]
    public static void PKEY_Message_ProofInProgressTest()
    {
        Assert.That(PKEY_Message_ProofInProgress.fmtid, Is.EqualTo(new Guid(0x9098F33C, 0x9A7D, 0x48A8, 0x8D, 0xE5, 0x2E, 0x12, 0x27, 0xA6, 0x4E, 0x91)));
        Assert.That(PKEY_Message_ProofInProgress.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Message_SenderAddress"/> property is correct.</summary>
    [Test]
    public static void PKEY_Message_SenderAddressTest()
    {
        Assert.That(PKEY_Message_SenderAddress.fmtid, Is.EqualTo(new Guid(0x0BE1C8E7, 0x1981, 0x4676, 0xAE, 0x14, 0xFD, 0xD7, 0x8F, 0x05, 0xA6, 0xE7)));
        Assert.That(PKEY_Message_SenderAddress.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Message_SenderName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Message_SenderNameTest()
    {
        Assert.That(PKEY_Message_SenderName.fmtid, Is.EqualTo(new Guid(0x0DA41CFA, 0xD224, 0x4A18, 0xAE, 0x2F, 0x59, 0x61, 0x58, 0xDB, 0x4B, 0x3A)));
        Assert.That(PKEY_Message_SenderName.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Message_Store"/> property is correct.</summary>
    [Test]
    public static void PKEY_Message_StoreTest()
    {
        Assert.That(PKEY_Message_Store.fmtid, Is.EqualTo(new Guid(0xE3E0584C, 0xB788, 0x4A5A, 0xBB, 0x20, 0x7F, 0x5A, 0x44, 0xC9, 0xAC, 0xDD)));
        Assert.That(PKEY_Message_Store.pid, Is.EqualTo(15));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Message_ToAddress"/> property is correct.</summary>
    [Test]
    public static void PKEY_Message_ToAddressTest()
    {
        Assert.That(PKEY_Message_ToAddress.fmtid, Is.EqualTo(new Guid(0xE3E0584C, 0xB788, 0x4A5A, 0xBB, 0x20, 0x7F, 0x5A, 0x44, 0xC9, 0xAC, 0xDD)));
        Assert.That(PKEY_Message_ToAddress.pid, Is.EqualTo(16));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Message_ToDoFlags"/> property is correct.</summary>
    [Test]
    public static void PKEY_Message_ToDoFlagsTest()
    {
        Assert.That(PKEY_Message_ToDoFlags.fmtid, Is.EqualTo(new Guid(0x1F856A9F, 0x6900, 0x4ABA, 0x95, 0x05, 0x2D, 0x5F, 0x1B, 0x4D, 0x66, 0xCB)));
        Assert.That(PKEY_Message_ToDoFlags.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Message_ToDoTitle"/> property is correct.</summary>
    [Test]
    public static void PKEY_Message_ToDoTitleTest()
    {
        Assert.That(PKEY_Message_ToDoTitle.fmtid, Is.EqualTo(new Guid(0xBCCC8A3C, 0x8CEF, 0x42E5, 0x9B, 0x1C, 0xC6, 0x90, 0x79, 0x39, 0x8B, 0xC7)));
        Assert.That(PKEY_Message_ToDoTitle.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Message_ToName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Message_ToNameTest()
    {
        Assert.That(PKEY_Message_ToName.fmtid, Is.EqualTo(new Guid(0xE3E0584C, 0xB788, 0x4A5A, 0xBB, 0x20, 0x7F, 0x5A, 0x44, 0xC9, 0xAC, 0xDD)));
        Assert.That(PKEY_Message_ToName.pid, Is.EqualTo(17));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Music_AlbumArtist"/> property is correct.</summary>
    [Test]
    public static void PKEY_Music_AlbumArtistTest()
    {
        Assert.That(PKEY_Music_AlbumArtist.fmtid, Is.EqualTo(new Guid(0x56A3372E, 0xCE9C, 0x11D2, 0x9F, 0x0E, 0x00, 0x60, 0x97, 0xC6, 0x86, 0xF6)));
        Assert.That(PKEY_Music_AlbumArtist.pid, Is.EqualTo(13));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Music_AlbumArtistSortOverride"/> property is correct.</summary>
    [Test]
    public static void PKEY_Music_AlbumArtistSortOverrideTest()
    {
        Assert.That(PKEY_Music_AlbumArtistSortOverride.fmtid, Is.EqualTo(new Guid(0xF1FDB4AF, 0xF78C, 0x466C, 0xBB, 0x05, 0x56, 0xE9, 0x2D, 0xB0, 0xB8, 0xEC)));
        Assert.That(PKEY_Music_AlbumArtistSortOverride.pid, Is.EqualTo(103));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Music_AlbumID"/> property is correct.</summary>
    [Test]
    public static void PKEY_Music_AlbumIDTest()
    {
        Assert.That(PKEY_Music_AlbumID.fmtid, Is.EqualTo(new Guid(0x56A3372E, 0xCE9C, 0x11D2, 0x9F, 0x0E, 0x00, 0x60, 0x97, 0xC6, 0x86, 0xF6)));
        Assert.That(PKEY_Music_AlbumID.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Music_AlbumTitle"/> property is correct.</summary>
    [Test]
    public static void PKEY_Music_AlbumTitleTest()
    {
        Assert.That(PKEY_Music_AlbumTitle.fmtid, Is.EqualTo(new Guid(0x56A3372E, 0xCE9C, 0x11D2, 0x9F, 0x0E, 0x00, 0x60, 0x97, 0xC6, 0x86, 0xF6)));
        Assert.That(PKEY_Music_AlbumTitle.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Music_AlbumTitleSortOverride"/> property is correct.</summary>
    [Test]
    public static void PKEY_Music_AlbumTitleSortOverrideTest()
    {
        Assert.That(PKEY_Music_AlbumTitleSortOverride.fmtid, Is.EqualTo(new Guid(0x13EB7FFC, 0xEC89, 0x4346, 0xB1, 0x9D, 0xCC, 0xC6, 0xF1, 0x78, 0x42, 0x23)));
        Assert.That(PKEY_Music_AlbumTitleSortOverride.pid, Is.EqualTo(101));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Music_Artist"/> property is correct.</summary>
    [Test]
    public static void PKEY_Music_ArtistTest()
    {
        Assert.That(PKEY_Music_Artist.fmtid, Is.EqualTo(new Guid(0x56A3372E, 0xCE9C, 0x11D2, 0x9F, 0x0E, 0x00, 0x60, 0x97, 0xC6, 0x86, 0xF6)));
        Assert.That(PKEY_Music_Artist.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Music_ArtistSortOverride"/> property is correct.</summary>
    [Test]
    public static void PKEY_Music_ArtistSortOverrideTest()
    {
        Assert.That(PKEY_Music_ArtistSortOverride.fmtid, Is.EqualTo(new Guid(0xDEEB2DB5, 0x0696, 0x4CE0, 0x94, 0xFE, 0xA0, 0x1F, 0x77, 0xA4, 0x5F, 0xB5)));
        Assert.That(PKEY_Music_ArtistSortOverride.pid, Is.EqualTo(102));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Music_BeatsPerMinute"/> property is correct.</summary>
    [Test]
    public static void PKEY_Music_BeatsPerMinuteTest()
    {
        Assert.That(PKEY_Music_BeatsPerMinute.fmtid, Is.EqualTo(new Guid(0x56A3372E, 0xCE9C, 0x11D2, 0x9F, 0x0E, 0x00, 0x60, 0x97, 0xC6, 0x86, 0xF6)));
        Assert.That(PKEY_Music_BeatsPerMinute.pid, Is.EqualTo(35));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Music_Composer"/> property is correct.</summary>
    [Test]
    public static void PKEY_Music_ComposerTest()
    {
        Assert.That(PKEY_Music_Composer.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Music_Composer.pid, Is.EqualTo(19));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Music_ComposerSortOverride"/> property is correct.</summary>
    [Test]
    public static void PKEY_Music_ComposerSortOverrideTest()
    {
        Assert.That(PKEY_Music_ComposerSortOverride.fmtid, Is.EqualTo(new Guid(0x00BC20A3, 0xBD48, 0x4085, 0x87, 0x2C, 0xA8, 0x8D, 0x77, 0xF5, 0x09, 0x7E)));
        Assert.That(PKEY_Music_ComposerSortOverride.pid, Is.EqualTo(105));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Music_Conductor"/> property is correct.</summary>
    [Test]
    public static void PKEY_Music_ConductorTest()
    {
        Assert.That(PKEY_Music_Conductor.fmtid, Is.EqualTo(new Guid(0x56A3372E, 0xCE9C, 0x11D2, 0x9F, 0x0E, 0x00, 0x60, 0x97, 0xC6, 0x86, 0xF6)));
        Assert.That(PKEY_Music_Conductor.pid, Is.EqualTo(36));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Music_ContentGroupDescription"/> property is correct.</summary>
    [Test]
    public static void PKEY_Music_ContentGroupDescriptionTest()
    {
        Assert.That(PKEY_Music_ContentGroupDescription.fmtid, Is.EqualTo(new Guid(0x56A3372E, 0xCE9C, 0x11D2, 0x9F, 0x0E, 0x00, 0x60, 0x97, 0xC6, 0x86, 0xF6)));
        Assert.That(PKEY_Music_ContentGroupDescription.pid, Is.EqualTo(33));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Music_DiscNumber"/> property is correct.</summary>
    [Test]
    public static void PKEY_Music_DiscNumberTest()
    {
        Assert.That(PKEY_Music_DiscNumber.fmtid, Is.EqualTo(new Guid(0x6AFE7437, 0x9BCD, 0x49C7, 0x80, 0xFE, 0x4A, 0x5C, 0x65, 0xFA, 0x58, 0x74)));
        Assert.That(PKEY_Music_DiscNumber.pid, Is.EqualTo(104));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Music_DisplayArtist"/> property is correct.</summary>
    [Test]
    public static void PKEY_Music_DisplayArtistTest()
    {
        Assert.That(PKEY_Music_DisplayArtist.fmtid, Is.EqualTo(new Guid(0xFD122953, 0xFA93, 0x4EF7, 0x92, 0xC3, 0x04, 0xC9, 0x46, 0xB2, 0xF7, 0xC8)));
        Assert.That(PKEY_Music_DisplayArtist.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Music_Genre"/> property is correct.</summary>
    [Test]
    public static void PKEY_Music_GenreTest()
    {
        Assert.That(PKEY_Music_Genre.fmtid, Is.EqualTo(new Guid(0x56A3372E, 0xCE9C, 0x11D2, 0x9F, 0x0E, 0x00, 0x60, 0x97, 0xC6, 0x86, 0xF6)));
        Assert.That(PKEY_Music_Genre.pid, Is.EqualTo(11));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Music_InitialKey"/> property is correct.</summary>
    [Test]
    public static void PKEY_Music_InitialKeyTest()
    {
        Assert.That(PKEY_Music_InitialKey.fmtid, Is.EqualTo(new Guid(0x56A3372E, 0xCE9C, 0x11D2, 0x9F, 0x0E, 0x00, 0x60, 0x97, 0xC6, 0x86, 0xF6)));
        Assert.That(PKEY_Music_InitialKey.pid, Is.EqualTo(34));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Music_IsCompilation"/> property is correct.</summary>
    [Test]
    public static void PKEY_Music_IsCompilationTest()
    {
        Assert.That(PKEY_Music_IsCompilation.fmtid, Is.EqualTo(new Guid(0xC449D5CB, 0x9EA4, 0x4809, 0x82, 0xE8, 0xAF, 0x9D, 0x59, 0xDE, 0xD6, 0xD1)));
        Assert.That(PKEY_Music_IsCompilation.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Music_Lyrics"/> property is correct.</summary>
    [Test]
    public static void PKEY_Music_LyricsTest()
    {
        Assert.That(PKEY_Music_Lyrics.fmtid, Is.EqualTo(new Guid(0x56A3372E, 0xCE9C, 0x11D2, 0x9F, 0x0E, 0x00, 0x60, 0x97, 0xC6, 0x86, 0xF6)));
        Assert.That(PKEY_Music_Lyrics.pid, Is.EqualTo(12));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Music_Mood"/> property is correct.</summary>
    [Test]
    public static void PKEY_Music_MoodTest()
    {
        Assert.That(PKEY_Music_Mood.fmtid, Is.EqualTo(new Guid(0x56A3372E, 0xCE9C, 0x11D2, 0x9F, 0x0E, 0x00, 0x60, 0x97, 0xC6, 0x86, 0xF6)));
        Assert.That(PKEY_Music_Mood.pid, Is.EqualTo(39));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Music_PartOfSet"/> property is correct.</summary>
    [Test]
    public static void PKEY_Music_PartOfSetTest()
    {
        Assert.That(PKEY_Music_PartOfSet.fmtid, Is.EqualTo(new Guid(0x56A3372E, 0xCE9C, 0x11D2, 0x9F, 0x0E, 0x00, 0x60, 0x97, 0xC6, 0x86, 0xF6)));
        Assert.That(PKEY_Music_PartOfSet.pid, Is.EqualTo(37));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Music_Period"/> property is correct.</summary>
    [Test]
    public static void PKEY_Music_PeriodTest()
    {
        Assert.That(PKEY_Music_Period.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Music_Period.pid, Is.EqualTo(31));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Music_SynchronizedLyrics"/> property is correct.</summary>
    [Test]
    public static void PKEY_Music_SynchronizedLyricsTest()
    {
        Assert.That(PKEY_Music_SynchronizedLyrics.fmtid, Is.EqualTo(new Guid(0x6B223B6A, 0x162E, 0x4AA9, 0xB3, 0x9F, 0x05, 0xD6, 0x78, 0xFC, 0x6D, 0x77)));
        Assert.That(PKEY_Music_SynchronizedLyrics.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Music_TrackNumber"/> property is correct.</summary>
    [Test]
    public static void PKEY_Music_TrackNumberTest()
    {
        Assert.That(PKEY_Music_TrackNumber.fmtid, Is.EqualTo(new Guid(0x56A3372E, 0xCE9C, 0x11D2, 0x9F, 0x0E, 0x00, 0x60, 0x97, 0xC6, 0x86, 0xF6)));
        Assert.That(PKEY_Music_TrackNumber.pid, Is.EqualTo(7));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Note_Color"/> property is correct.</summary>
    [Test]
    public static void PKEY_Note_ColorTest()
    {
        Assert.That(PKEY_Note_Color.fmtid, Is.EqualTo(new Guid(0x4776CAFA, 0xBCE4, 0x4CB1, 0xA2, 0x3E, 0x26, 0x5E, 0x76, 0xD8, 0xEB, 0x11)));
        Assert.That(PKEY_Note_Color.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Note_ColorText"/> property is correct.</summary>
    [Test]
    public static void PKEY_Note_ColorTextTest()
    {
        Assert.That(PKEY_Note_ColorText.fmtid, Is.EqualTo(new Guid(0x46B4E8DE, 0xCDB2, 0x440D, 0x88, 0x5C, 0x16, 0x58, 0xEB, 0x65, 0xB9, 0x14)));
        Assert.That(PKEY_Note_ColorText.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_Aperture"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_ApertureTest()
    {
        Assert.That(PKEY_Photo_Aperture.fmtid, Is.EqualTo(new Guid(0x14B81DA1, 0x0135, 0x4D31, 0x96, 0xD9, 0x6C, 0xBF, 0xC9, 0x67, 0x1A, 0x99)));
        Assert.That(PKEY_Photo_Aperture.pid, Is.EqualTo(37378));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_ApertureDenominator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_ApertureDenominatorTest()
    {
        Assert.That(PKEY_Photo_ApertureDenominator.fmtid, Is.EqualTo(new Guid(0xE1A9A38B, 0x6685, 0x46BD, 0x87, 0x5E, 0x57, 0x0D, 0xC7, 0xAD, 0x73, 0x20)));
        Assert.That(PKEY_Photo_ApertureDenominator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_ApertureNumerator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_ApertureNumeratorTest()
    {
        Assert.That(PKEY_Photo_ApertureNumerator.fmtid, Is.EqualTo(new Guid(0x0337ECEC, 0x39FB, 0x4581, 0xA0, 0xBD, 0x4C, 0x4C, 0xC5, 0x1E, 0x99, 0x14)));
        Assert.That(PKEY_Photo_ApertureNumerator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_Brightness"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_BrightnessTest()
    {
        Assert.That(PKEY_Photo_Brightness.fmtid, Is.EqualTo(new Guid(0x1A701BF6, 0x478C, 0x4361, 0x83, 0xAB, 0x37, 0x01, 0xBB, 0x05, 0x3C, 0x58)));
        Assert.That(PKEY_Photo_Brightness.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_BrightnessDenominator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_BrightnessDenominatorTest()
    {
        Assert.That(PKEY_Photo_BrightnessDenominator.fmtid, Is.EqualTo(new Guid(0x6EBE6946, 0x2321, 0x440A, 0x90, 0xF0, 0xC0, 0x43, 0xEF, 0xD3, 0x24, 0x76)));
        Assert.That(PKEY_Photo_BrightnessDenominator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_BrightnessNumerator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_BrightnessNumeratorTest()
    {
        Assert.That(PKEY_Photo_BrightnessNumerator.fmtid, Is.EqualTo(new Guid(0x9E7D118F, 0xB314, 0x45A0, 0x8C, 0xFB, 0xD6, 0x54, 0xB9, 0x17, 0xC9, 0xE9)));
        Assert.That(PKEY_Photo_BrightnessNumerator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_CameraManufacturer"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_CameraManufacturerTest()
    {
        Assert.That(PKEY_Photo_CameraManufacturer.fmtid, Is.EqualTo(new Guid(0x14B81DA1, 0x0135, 0x4D31, 0x96, 0xD9, 0x6C, 0xBF, 0xC9, 0x67, 0x1A, 0x99)));
        Assert.That(PKEY_Photo_CameraManufacturer.pid, Is.EqualTo(271));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_CameraModel"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_CameraModelTest()
    {
        Assert.That(PKEY_Photo_CameraModel.fmtid, Is.EqualTo(new Guid(0x14B81DA1, 0x0135, 0x4D31, 0x96, 0xD9, 0x6C, 0xBF, 0xC9, 0x67, 0x1A, 0x99)));
        Assert.That(PKEY_Photo_CameraModel.pid, Is.EqualTo(272));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_CameraSerialNumber"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_CameraSerialNumberTest()
    {
        Assert.That(PKEY_Photo_CameraSerialNumber.fmtid, Is.EqualTo(new Guid(0x14B81DA1, 0x0135, 0x4D31, 0x96, 0xD9, 0x6C, 0xBF, 0xC9, 0x67, 0x1A, 0x99)));
        Assert.That(PKEY_Photo_CameraSerialNumber.pid, Is.EqualTo(273));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_Contrast"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_ContrastTest()
    {
        Assert.That(PKEY_Photo_Contrast.fmtid, Is.EqualTo(new Guid(0x2A785BA9, 0x8D23, 0x4DED, 0x82, 0xE6, 0x60, 0xA3, 0x50, 0xC8, 0x6A, 0x10)));
        Assert.That(PKEY_Photo_Contrast.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_ContrastText"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_ContrastTextTest()
    {
        Assert.That(PKEY_Photo_ContrastText.fmtid, Is.EqualTo(new Guid(0x59DDE9F2, 0x5253, 0x40EA, 0x9A, 0x8B, 0x47, 0x9E, 0x96, 0xC6, 0x24, 0x9A)));
        Assert.That(PKEY_Photo_ContrastText.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_DateTaken"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_DateTakenTest()
    {
        Assert.That(PKEY_Photo_DateTaken.fmtid, Is.EqualTo(new Guid(0x14B81DA1, 0x0135, 0x4D31, 0x96, 0xD9, 0x6C, 0xBF, 0xC9, 0x67, 0x1A, 0x99)));
        Assert.That(PKEY_Photo_DateTaken.pid, Is.EqualTo(36867));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_DigitalZoom"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_DigitalZoomTest()
    {
        Assert.That(PKEY_Photo_DigitalZoom.fmtid, Is.EqualTo(new Guid(0xF85BF840, 0xA925, 0x4BC2, 0xB0, 0xC4, 0x8E, 0x36, 0xB5, 0x98, 0x67, 0x9E)));
        Assert.That(PKEY_Photo_DigitalZoom.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_DigitalZoomDenominator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_DigitalZoomDenominatorTest()
    {
        Assert.That(PKEY_Photo_DigitalZoomDenominator.fmtid, Is.EqualTo(new Guid(0x745BAF0E, 0xE5C1, 0x4CFB, 0x8A, 0x1B, 0xD0, 0x31, 0xA0, 0xA5, 0x23, 0x93)));
        Assert.That(PKEY_Photo_DigitalZoomDenominator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_DigitalZoomNumerator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_DigitalZoomNumeratorTest()
    {
        Assert.That(PKEY_Photo_DigitalZoomNumerator.fmtid, Is.EqualTo(new Guid(0x16CBB924, 0x6500, 0x473B, 0xA5, 0xBE, 0xF1, 0x59, 0x9B, 0xCB, 0xE4, 0x13)));
        Assert.That(PKEY_Photo_DigitalZoomNumerator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_Event"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_EventTest()
    {
        Assert.That(PKEY_Photo_Event.fmtid, Is.EqualTo(new Guid(0x14B81DA1, 0x0135, 0x4D31, 0x96, 0xD9, 0x6C, 0xBF, 0xC9, 0x67, 0x1A, 0x99)));
        Assert.That(PKEY_Photo_Event.pid, Is.EqualTo(18248));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_EXIFVersion"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_EXIFVersionTest()
    {
        Assert.That(PKEY_Photo_EXIFVersion.fmtid, Is.EqualTo(new Guid(0xD35F743A, 0xEB2E, 0x47F2, 0xA2, 0x86, 0x84, 0x41, 0x32, 0xCB, 0x14, 0x27)));
        Assert.That(PKEY_Photo_EXIFVersion.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_ExposureBias"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_ExposureBiasTest()
    {
        Assert.That(PKEY_Photo_ExposureBias.fmtid, Is.EqualTo(new Guid(0x14B81DA1, 0x0135, 0x4D31, 0x96, 0xD9, 0x6C, 0xBF, 0xC9, 0x67, 0x1A, 0x99)));
        Assert.That(PKEY_Photo_ExposureBias.pid, Is.EqualTo(37380));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_ExposureBiasDenominator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_ExposureBiasDenominatorTest()
    {
        Assert.That(PKEY_Photo_ExposureBiasDenominator.fmtid, Is.EqualTo(new Guid(0xAB205E50, 0x04B7, 0x461C, 0xA1, 0x8C, 0x2F, 0x23, 0x38, 0x36, 0xE6, 0x27)));
        Assert.That(PKEY_Photo_ExposureBiasDenominator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_ExposureBiasNumerator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_ExposureBiasNumeratorTest()
    {
        Assert.That(PKEY_Photo_ExposureBiasNumerator.fmtid, Is.EqualTo(new Guid(0x738BF284, 0x1D87, 0x420B, 0x92, 0xCF, 0x58, 0x34, 0xBF, 0x6E, 0xF9, 0xED)));
        Assert.That(PKEY_Photo_ExposureBiasNumerator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_ExposureIndex"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_ExposureIndexTest()
    {
        Assert.That(PKEY_Photo_ExposureIndex.fmtid, Is.EqualTo(new Guid(0x967B5AF8, 0x995A, 0x46ED, 0x9E, 0x11, 0x35, 0xB3, 0xC5, 0xB9, 0x78, 0x2D)));
        Assert.That(PKEY_Photo_ExposureIndex.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_ExposureIndexDenominator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_ExposureIndexDenominatorTest()
    {
        Assert.That(PKEY_Photo_ExposureIndexDenominator.fmtid, Is.EqualTo(new Guid(0x93112F89, 0xC28B, 0x492F, 0x8A, 0x9D, 0x4B, 0xE2, 0x06, 0x2C, 0xEE, 0x8A)));
        Assert.That(PKEY_Photo_ExposureIndexDenominator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_ExposureIndexNumerator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_ExposureIndexNumeratorTest()
    {
        Assert.That(PKEY_Photo_ExposureIndexNumerator.fmtid, Is.EqualTo(new Guid(0xCDEDCF30, 0x8919, 0x44DF, 0x8F, 0x4C, 0x4E, 0xB2, 0xFF, 0xDB, 0x8D, 0x89)));
        Assert.That(PKEY_Photo_ExposureIndexNumerator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_ExposureProgram"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_ExposureProgramTest()
    {
        Assert.That(PKEY_Photo_ExposureProgram.fmtid, Is.EqualTo(new Guid(0x14B81DA1, 0x0135, 0x4D31, 0x96, 0xD9, 0x6C, 0xBF, 0xC9, 0x67, 0x1A, 0x99)));
        Assert.That(PKEY_Photo_ExposureProgram.pid, Is.EqualTo(34850));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_ExposureProgramText"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_ExposureProgramTextTest()
    {
        Assert.That(PKEY_Photo_ExposureProgramText.fmtid, Is.EqualTo(new Guid(0xFEC690B7, 0x5F30, 0x4646, 0xAE, 0x47, 0x4C, 0xAA, 0xFB, 0xA8, 0x84, 0xA3)));
        Assert.That(PKEY_Photo_ExposureProgramText.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_ExposureTime"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_ExposureTimeTest()
    {
        Assert.That(PKEY_Photo_ExposureTime.fmtid, Is.EqualTo(new Guid(0x14B81DA1, 0x0135, 0x4D31, 0x96, 0xD9, 0x6C, 0xBF, 0xC9, 0x67, 0x1A, 0x99)));
        Assert.That(PKEY_Photo_ExposureTime.pid, Is.EqualTo(33434));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_ExposureTimeDenominator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_ExposureTimeDenominatorTest()
    {
        Assert.That(PKEY_Photo_ExposureTimeDenominator.fmtid, Is.EqualTo(new Guid(0x55E98597, 0xAD16, 0x42E0, 0xB6, 0x24, 0x21, 0x59, 0x9A, 0x19, 0x98, 0x38)));
        Assert.That(PKEY_Photo_ExposureTimeDenominator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_ExposureTimeNumerator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_ExposureTimeNumeratorTest()
    {
        Assert.That(PKEY_Photo_ExposureTimeNumerator.fmtid, Is.EqualTo(new Guid(0x257E44E2, 0x9031, 0x4323, 0xAC, 0x38, 0x85, 0xC5, 0x52, 0x87, 0x1B, 0x2E)));
        Assert.That(PKEY_Photo_ExposureTimeNumerator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_Flash"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_FlashTest()
    {
        Assert.That(PKEY_Photo_Flash.fmtid, Is.EqualTo(new Guid(0x14B81DA1, 0x0135, 0x4D31, 0x96, 0xD9, 0x6C, 0xBF, 0xC9, 0x67, 0x1A, 0x99)));
        Assert.That(PKEY_Photo_Flash.pid, Is.EqualTo(37385));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_FlashEnergy"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_FlashEnergyTest()
    {
        Assert.That(PKEY_Photo_FlashEnergy.fmtid, Is.EqualTo(new Guid(0x14B81DA1, 0x0135, 0x4D31, 0x96, 0xD9, 0x6C, 0xBF, 0xC9, 0x67, 0x1A, 0x99)));
        Assert.That(PKEY_Photo_FlashEnergy.pid, Is.EqualTo(41483));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_FlashEnergyDenominator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_FlashEnergyDenominatorTest()
    {
        Assert.That(PKEY_Photo_FlashEnergyDenominator.fmtid, Is.EqualTo(new Guid(0xD7B61C70, 0x6323, 0x49CD, 0xA5, 0xFC, 0xC8, 0x42, 0x77, 0x16, 0x2C, 0x97)));
        Assert.That(PKEY_Photo_FlashEnergyDenominator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_FlashEnergyNumerator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_FlashEnergyNumeratorTest()
    {
        Assert.That(PKEY_Photo_FlashEnergyNumerator.fmtid, Is.EqualTo(new Guid(0xFCAD3D3D, 0x0858, 0x400F, 0xAA, 0xA3, 0x2F, 0x66, 0xCC, 0xE2, 0xA6, 0xBC)));
        Assert.That(PKEY_Photo_FlashEnergyNumerator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_FlashManufacturer"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_FlashManufacturerTest()
    {
        Assert.That(PKEY_Photo_FlashManufacturer.fmtid, Is.EqualTo(new Guid(0xAABAF6C9, 0xE0C5, 0x4719, 0x85, 0x85, 0x57, 0xB1, 0x03, 0xE5, 0x84, 0xFE)));
        Assert.That(PKEY_Photo_FlashManufacturer.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_FlashModel"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_FlashModelTest()
    {
        Assert.That(PKEY_Photo_FlashModel.fmtid, Is.EqualTo(new Guid(0xFE83BB35, 0x4D1A, 0x42E2, 0x91, 0x6B, 0x06, 0xF3, 0xE1, 0xAF, 0x71, 0x9E)));
        Assert.That(PKEY_Photo_FlashModel.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_FlashText"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_FlashTextTest()
    {
        Assert.That(PKEY_Photo_FlashText.fmtid, Is.EqualTo(new Guid(0x6B8B68F6, 0x200B, 0x47EA, 0x8D, 0x25, 0xD8, 0x05, 0x0F, 0x57, 0x33, 0x9F)));
        Assert.That(PKEY_Photo_FlashText.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_FNumber"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_FNumberTest()
    {
        Assert.That(PKEY_Photo_FNumber.fmtid, Is.EqualTo(new Guid(0x14B81DA1, 0x0135, 0x4D31, 0x96, 0xD9, 0x6C, 0xBF, 0xC9, 0x67, 0x1A, 0x99)));
        Assert.That(PKEY_Photo_FNumber.pid, Is.EqualTo(33437));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_FNumberDenominator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_FNumberDenominatorTest()
    {
        Assert.That(PKEY_Photo_FNumberDenominator.fmtid, Is.EqualTo(new Guid(0xE92A2496, 0x223B, 0x4463, 0xA4, 0xE3, 0x30, 0xEA, 0xBB, 0xA7, 0x9D, 0x80)));
        Assert.That(PKEY_Photo_FNumberDenominator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_FNumberNumerator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_FNumberNumeratorTest()
    {
        Assert.That(PKEY_Photo_FNumberNumerator.fmtid, Is.EqualTo(new Guid(0x1B97738A, 0xFDFC, 0x462F, 0x9D, 0x93, 0x19, 0x57, 0xE0, 0x8B, 0xE9, 0x0C)));
        Assert.That(PKEY_Photo_FNumberNumerator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_FocalLength"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_FocalLengthTest()
    {
        Assert.That(PKEY_Photo_FocalLength.fmtid, Is.EqualTo(new Guid(0x14B81DA1, 0x0135, 0x4D31, 0x96, 0xD9, 0x6C, 0xBF, 0xC9, 0x67, 0x1A, 0x99)));
        Assert.That(PKEY_Photo_FocalLength.pid, Is.EqualTo(37386));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_FocalLengthDenominator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_FocalLengthDenominatorTest()
    {
        Assert.That(PKEY_Photo_FocalLengthDenominator.fmtid, Is.EqualTo(new Guid(0x305BC615, 0xDCA1, 0x44A5, 0x9F, 0xD4, 0x10, 0xC0, 0xBA, 0x79, 0x41, 0x2E)));
        Assert.That(PKEY_Photo_FocalLengthDenominator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_FocalLengthInFilm"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_FocalLengthInFilmTest()
    {
        Assert.That(PKEY_Photo_FocalLengthInFilm.fmtid, Is.EqualTo(new Guid(0xA0E74609, 0xB84D, 0x4F49, 0xB8, 0x60, 0x46, 0x2B, 0xD9, 0x97, 0x1F, 0x98)));
        Assert.That(PKEY_Photo_FocalLengthInFilm.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_FocalLengthNumerator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_FocalLengthNumeratorTest()
    {
        Assert.That(PKEY_Photo_FocalLengthNumerator.fmtid, Is.EqualTo(new Guid(0x776B6B3B, 0x1E3D, 0x4B0C, 0x9A, 0x0E, 0x8F, 0xBA, 0xF2, 0xA8, 0x49, 0x2A)));
        Assert.That(PKEY_Photo_FocalLengthNumerator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_FocalPlaneXResolution"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_FocalPlaneXResolutionTest()
    {
        Assert.That(PKEY_Photo_FocalPlaneXResolution.fmtid, Is.EqualTo(new Guid(0xCFC08D97, 0xC6F7, 0x4484, 0x89, 0xDD, 0xEB, 0xEF, 0x43, 0x56, 0xFE, 0x76)));
        Assert.That(PKEY_Photo_FocalPlaneXResolution.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_FocalPlaneXResolutionDenominator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_FocalPlaneXResolutionDenominatorTest()
    {
        Assert.That(PKEY_Photo_FocalPlaneXResolutionDenominator.fmtid, Is.EqualTo(new Guid(0x0933F3F5, 0x4786, 0x4F46, 0xA8, 0xE8, 0xD6, 0x4D, 0xD3, 0x7F, 0xA5, 0x21)));
        Assert.That(PKEY_Photo_FocalPlaneXResolutionDenominator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_FocalPlaneXResolutionNumerator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_FocalPlaneXResolutionNumeratorTest()
    {
        Assert.That(PKEY_Photo_FocalPlaneXResolutionNumerator.fmtid, Is.EqualTo(new Guid(0xDCCB10AF, 0xB4E2, 0x4B88, 0x95, 0xF9, 0x03, 0x1B, 0x4D, 0x5A, 0xB4, 0x90)));
        Assert.That(PKEY_Photo_FocalPlaneXResolutionNumerator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_FocalPlaneYResolution"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_FocalPlaneYResolutionTest()
    {
        Assert.That(PKEY_Photo_FocalPlaneYResolution.fmtid, Is.EqualTo(new Guid(0x4FFFE4D0, 0x914F, 0x4AC4, 0x8D, 0x6F, 0xC9, 0xC6, 0x1D, 0xE1, 0x69, 0xB1)));
        Assert.That(PKEY_Photo_FocalPlaneYResolution.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_FocalPlaneYResolutionDenominator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_FocalPlaneYResolutionDenominatorTest()
    {
        Assert.That(PKEY_Photo_FocalPlaneYResolutionDenominator.fmtid, Is.EqualTo(new Guid(0x1D6179A6, 0xA876, 0x4031, 0xB0, 0x13, 0x33, 0x47, 0xB2, 0xB6, 0x4D, 0xC8)));
        Assert.That(PKEY_Photo_FocalPlaneYResolutionDenominator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_FocalPlaneYResolutionNumerator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_FocalPlaneYResolutionNumeratorTest()
    {
        Assert.That(PKEY_Photo_FocalPlaneYResolutionNumerator.fmtid, Is.EqualTo(new Guid(0xA2E541C5, 0x4440, 0x4BA8, 0x86, 0x7E, 0x75, 0xCF, 0xC0, 0x68, 0x28, 0xCD)));
        Assert.That(PKEY_Photo_FocalPlaneYResolutionNumerator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_GainControl"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_GainControlTest()
    {
        Assert.That(PKEY_Photo_GainControl.fmtid, Is.EqualTo(new Guid(0xFA304789, 0x00C7, 0x4D80, 0x90, 0x4A, 0x1E, 0x4D, 0xCC, 0x72, 0x65, 0xAA)));
        Assert.That(PKEY_Photo_GainControl.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_GainControlDenominator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_GainControlDenominatorTest()
    {
        Assert.That(PKEY_Photo_GainControlDenominator.fmtid, Is.EqualTo(new Guid(0x42864DFD, 0x9DA4, 0x4F77, 0xBD, 0xED, 0x4A, 0xAD, 0x7B, 0x25, 0x67, 0x35)));
        Assert.That(PKEY_Photo_GainControlDenominator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_GainControlNumerator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_GainControlNumeratorTest()
    {
        Assert.That(PKEY_Photo_GainControlNumerator.fmtid, Is.EqualTo(new Guid(0x8E8ECF7C, 0xB7B8, 0x4EB8, 0xA6, 0x3F, 0x0E, 0xE7, 0x15, 0xC9, 0x6F, 0x9E)));
        Assert.That(PKEY_Photo_GainControlNumerator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_GainControlText"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_GainControlTextTest()
    {
        Assert.That(PKEY_Photo_GainControlText.fmtid, Is.EqualTo(new Guid(0xC06238B2, 0x0BF9, 0x4279, 0xA7, 0x23, 0x25, 0x85, 0x67, 0x15, 0xCB, 0x9D)));
        Assert.That(PKEY_Photo_GainControlText.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_ISOSpeed"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_ISOSpeedTest()
    {
        Assert.That(PKEY_Photo_ISOSpeed.fmtid, Is.EqualTo(new Guid(0x14B81DA1, 0x0135, 0x4D31, 0x96, 0xD9, 0x6C, 0xBF, 0xC9, 0x67, 0x1A, 0x99)));
        Assert.That(PKEY_Photo_ISOSpeed.pid, Is.EqualTo(34855));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_LensManufacturer"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_LensManufacturerTest()
    {
        Assert.That(PKEY_Photo_LensManufacturer.fmtid, Is.EqualTo(new Guid(0xE6DDCAF7, 0x29C5, 0x4F0A, 0x9A, 0x68, 0xD1, 0x94, 0x12, 0xEC, 0x70, 0x90)));
        Assert.That(PKEY_Photo_LensManufacturer.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_LensModel"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_LensModelTest()
    {
        Assert.That(PKEY_Photo_LensModel.fmtid, Is.EqualTo(new Guid(0xE1277516, 0x2B5F, 0x4869, 0x89, 0xB1, 0x2E, 0x58, 0x5B, 0xD3, 0x8B, 0x7A)));
        Assert.That(PKEY_Photo_LensModel.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_LightSource"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_LightSourceTest()
    {
        Assert.That(PKEY_Photo_LightSource.fmtid, Is.EqualTo(new Guid(0x14B81DA1, 0x0135, 0x4D31, 0x96, 0xD9, 0x6C, 0xBF, 0xC9, 0x67, 0x1A, 0x99)));
        Assert.That(PKEY_Photo_LightSource.pid, Is.EqualTo(37384));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_MakerNote"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_MakerNoteTest()
    {
        Assert.That(PKEY_Photo_MakerNote.fmtid, Is.EqualTo(new Guid(0xFA303353, 0xB659, 0x4052, 0x85, 0xE9, 0xBC, 0xAC, 0x79, 0x54, 0x9B, 0x84)));
        Assert.That(PKEY_Photo_MakerNote.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_MakerNoteOffset"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_MakerNoteOffsetTest()
    {
        Assert.That(PKEY_Photo_MakerNoteOffset.fmtid, Is.EqualTo(new Guid(0x813F4124, 0x34E6, 0x4D17, 0xAB, 0x3E, 0x6B, 0x1F, 0x3C, 0x22, 0x47, 0xA1)));
        Assert.That(PKEY_Photo_MakerNoteOffset.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_MaxAperture"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_MaxApertureTest()
    {
        Assert.That(PKEY_Photo_MaxAperture.fmtid, Is.EqualTo(new Guid(0x08F6D7C2, 0xE3F2, 0x44FC, 0xAF, 0x1E, 0x5A, 0xA5, 0xC8, 0x1A, 0x2D, 0x3E)));
        Assert.That(PKEY_Photo_MaxAperture.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_MaxApertureDenominator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_MaxApertureDenominatorTest()
    {
        Assert.That(PKEY_Photo_MaxApertureDenominator.fmtid, Is.EqualTo(new Guid(0xC77724D4, 0x601F, 0x46C5, 0x9B, 0x89, 0xC5, 0x3F, 0x93, 0xBC, 0xEB, 0x77)));
        Assert.That(PKEY_Photo_MaxApertureDenominator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_MaxApertureNumerator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_MaxApertureNumeratorTest()
    {
        Assert.That(PKEY_Photo_MaxApertureNumerator.fmtid, Is.EqualTo(new Guid(0xC107E191, 0xA459, 0x44C5, 0x9A, 0xE6, 0xB9, 0x52, 0xAD, 0x4B, 0x90, 0x6D)));
        Assert.That(PKEY_Photo_MaxApertureNumerator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_MeteringMode"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_MeteringModeTest()
    {
        Assert.That(PKEY_Photo_MeteringMode.fmtid, Is.EqualTo(new Guid(0x14B81DA1, 0x0135, 0x4D31, 0x96, 0xD9, 0x6C, 0xBF, 0xC9, 0x67, 0x1A, 0x99)));
        Assert.That(PKEY_Photo_MeteringMode.pid, Is.EqualTo(37383));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_MeteringModeText"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_MeteringModeTextTest()
    {
        Assert.That(PKEY_Photo_MeteringModeText.fmtid, Is.EqualTo(new Guid(0xF628FD8C, 0x7BA8, 0x465A, 0xA6, 0x5B, 0xC5, 0xAA, 0x79, 0x26, 0x3A, 0x9E)));
        Assert.That(PKEY_Photo_MeteringModeText.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_Orientation"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_OrientationTest()
    {
        Assert.That(PKEY_Photo_Orientation.fmtid, Is.EqualTo(new Guid(0x14B81DA1, 0x0135, 0x4D31, 0x96, 0xD9, 0x6C, 0xBF, 0xC9, 0x67, 0x1A, 0x99)));
        Assert.That(PKEY_Photo_Orientation.pid, Is.EqualTo(274));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_OrientationText"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_OrientationTextTest()
    {
        Assert.That(PKEY_Photo_OrientationText.fmtid, Is.EqualTo(new Guid(0xA9EA193C, 0xC511, 0x498A, 0xA0, 0x6B, 0x58, 0xE2, 0x77, 0x6D, 0xCC, 0x28)));
        Assert.That(PKEY_Photo_OrientationText.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_PeopleNames"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_PeopleNamesTest()
    {
        Assert.That(PKEY_Photo_PeopleNames.fmtid, Is.EqualTo(new Guid(0xE8309B6E, 0x084C, 0x49B4, 0xB1, 0xFC, 0x90, 0xA8, 0x03, 0x31, 0xB6, 0x38)));
        Assert.That(PKEY_Photo_PeopleNames.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_PhotometricInterpretation"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_PhotometricInterpretationTest()
    {
        Assert.That(PKEY_Photo_PhotometricInterpretation.fmtid, Is.EqualTo(new Guid(0x341796F1, 0x1DF9, 0x4B1C, 0xA5, 0x64, 0x91, 0xBD, 0xEF, 0xA4, 0x38, 0x77)));
        Assert.That(PKEY_Photo_PhotometricInterpretation.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_PhotometricInterpretationText"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_PhotometricInterpretationTextTest()
    {
        Assert.That(PKEY_Photo_PhotometricInterpretationText.fmtid, Is.EqualTo(new Guid(0x821437D6, 0x9EAB, 0x4765, 0xA5, 0x89, 0x3B, 0x1C, 0xBB, 0xD2, 0x2A, 0x61)));
        Assert.That(PKEY_Photo_PhotometricInterpretationText.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_ProgramMode"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_ProgramModeTest()
    {
        Assert.That(PKEY_Photo_ProgramMode.fmtid, Is.EqualTo(new Guid(0x6D217F6D, 0x3F6A, 0x4825, 0xB4, 0x70, 0x5F, 0x03, 0xCA, 0x2F, 0xBE, 0x9B)));
        Assert.That(PKEY_Photo_ProgramMode.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_ProgramModeText"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_ProgramModeTextTest()
    {
        Assert.That(PKEY_Photo_ProgramModeText.fmtid, Is.EqualTo(new Guid(0x7FE3AA27, 0x2648, 0x42F3, 0x89, 0xB0, 0x45, 0x4E, 0x5C, 0xB1, 0x50, 0xC3)));
        Assert.That(PKEY_Photo_ProgramModeText.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_RelatedSoundFile"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_RelatedSoundFileTest()
    {
        Assert.That(PKEY_Photo_RelatedSoundFile.fmtid, Is.EqualTo(new Guid(0x318A6B45, 0x087F, 0x4DC2, 0xB8, 0xCC, 0x05, 0x35, 0x95, 0x51, 0xFC, 0x9E)));
        Assert.That(PKEY_Photo_RelatedSoundFile.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_Saturation"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_SaturationTest()
    {
        Assert.That(PKEY_Photo_Saturation.fmtid, Is.EqualTo(new Guid(0x49237325, 0xA95A, 0x4F67, 0xB2, 0x11, 0x81, 0x6B, 0x2D, 0x45, 0xD2, 0xE0)));
        Assert.That(PKEY_Photo_Saturation.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_SaturationText"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_SaturationTextTest()
    {
        Assert.That(PKEY_Photo_SaturationText.fmtid, Is.EqualTo(new Guid(0x61478C08, 0xB600, 0x4A84, 0xBB, 0xE4, 0xE9, 0x9C, 0x45, 0xF0, 0xA0, 0x72)));
        Assert.That(PKEY_Photo_SaturationText.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_Sharpness"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_SharpnessTest()
    {
        Assert.That(PKEY_Photo_Sharpness.fmtid, Is.EqualTo(new Guid(0xFC6976DB, 0x8349, 0x4970, 0xAE, 0x97, 0xB3, 0xC5, 0x31, 0x6A, 0x08, 0xF0)));
        Assert.That(PKEY_Photo_Sharpness.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_SharpnessText"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_SharpnessTextTest()
    {
        Assert.That(PKEY_Photo_SharpnessText.fmtid, Is.EqualTo(new Guid(0x51EC3F47, 0xDD50, 0x421D, 0x87, 0x69, 0x33, 0x4F, 0x50, 0x42, 0x4B, 0x1E)));
        Assert.That(PKEY_Photo_SharpnessText.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_ShutterSpeed"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_ShutterSpeedTest()
    {
        Assert.That(PKEY_Photo_ShutterSpeed.fmtid, Is.EqualTo(new Guid(0x14B81DA1, 0x0135, 0x4D31, 0x96, 0xD9, 0x6C, 0xBF, 0xC9, 0x67, 0x1A, 0x99)));
        Assert.That(PKEY_Photo_ShutterSpeed.pid, Is.EqualTo(37377));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_ShutterSpeedDenominator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_ShutterSpeedDenominatorTest()
    {
        Assert.That(PKEY_Photo_ShutterSpeedDenominator.fmtid, Is.EqualTo(new Guid(0xE13D8975, 0x81C7, 0x4948, 0xAE, 0x3F, 0x37, 0xCA, 0xE1, 0x1E, 0x8F, 0xF7)));
        Assert.That(PKEY_Photo_ShutterSpeedDenominator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_ShutterSpeedNumerator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_ShutterSpeedNumeratorTest()
    {
        Assert.That(PKEY_Photo_ShutterSpeedNumerator.fmtid, Is.EqualTo(new Guid(0x16EA4042, 0xD6F4, 0x4BCA, 0x83, 0x49, 0x7C, 0x78, 0xD3, 0x0F, 0xB3, 0x33)));
        Assert.That(PKEY_Photo_ShutterSpeedNumerator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_SubjectDistance"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_SubjectDistanceTest()
    {
        Assert.That(PKEY_Photo_SubjectDistance.fmtid, Is.EqualTo(new Guid(0x14B81DA1, 0x0135, 0x4D31, 0x96, 0xD9, 0x6C, 0xBF, 0xC9, 0x67, 0x1A, 0x99)));
        Assert.That(PKEY_Photo_SubjectDistance.pid, Is.EqualTo(37382));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_SubjectDistanceDenominator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_SubjectDistanceDenominatorTest()
    {
        Assert.That(PKEY_Photo_SubjectDistanceDenominator.fmtid, Is.EqualTo(new Guid(0x0C840A88, 0xB043, 0x466D, 0x97, 0x66, 0xD4, 0xB2, 0x6D, 0xA3, 0xFA, 0x77)));
        Assert.That(PKEY_Photo_SubjectDistanceDenominator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_SubjectDistanceNumerator"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_SubjectDistanceNumeratorTest()
    {
        Assert.That(PKEY_Photo_SubjectDistanceNumerator.fmtid, Is.EqualTo(new Guid(0x8AF4961C, 0xF526, 0x43E5, 0xAA, 0x81, 0xDB, 0x76, 0x82, 0x19, 0x17, 0x8D)));
        Assert.That(PKEY_Photo_SubjectDistanceNumerator.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_TagViewAggregate"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_TagViewAggregateTest()
    {
        Assert.That(PKEY_Photo_TagViewAggregate.fmtid, Is.EqualTo(new Guid(0xB812F15D, 0xC2D8, 0x4BBF, 0xBA, 0xCD, 0x79, 0x74, 0x43, 0x46, 0x11, 0x3F)));
        Assert.That(PKEY_Photo_TagViewAggregate.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_TranscodedForSync"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_TranscodedForSyncTest()
    {
        Assert.That(PKEY_Photo_TranscodedForSync.fmtid, Is.EqualTo(new Guid(0x9A8EBB75, 0x6458, 0x4E82, 0xBA, 0xCB, 0x35, 0xC0, 0x09, 0x5B, 0x03, 0xBB)));
        Assert.That(PKEY_Photo_TranscodedForSync.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_WhiteBalance"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_WhiteBalanceTest()
    {
        Assert.That(PKEY_Photo_WhiteBalance.fmtid, Is.EqualTo(new Guid(0xEE3D3D8A, 0x5381, 0x4CFA, 0xB1, 0x3B, 0xAA, 0xF6, 0x6B, 0x5F, 0x4E, 0xC9)));
        Assert.That(PKEY_Photo_WhiteBalance.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Photo_WhiteBalanceText"/> property is correct.</summary>
    [Test]
    public static void PKEY_Photo_WhiteBalanceTextTest()
    {
        Assert.That(PKEY_Photo_WhiteBalanceText.fmtid, Is.EqualTo(new Guid(0x6336B95E, 0xC7A7, 0x426D, 0x86, 0xFD, 0x7A, 0xE3, 0xD3, 0x9C, 0x84, 0xB4)));
        Assert.That(PKEY_Photo_WhiteBalanceText.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropGroup_Advanced"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropGroup_AdvancedTest()
    {
        Assert.That(PKEY_PropGroup_Advanced.fmtid, Is.EqualTo(new Guid(0x900A403B, 0x097B, 0x4B95, 0x8A, 0xE2, 0x07, 0x1F, 0xDA, 0xEE, 0xB1, 0x18)));
        Assert.That(PKEY_PropGroup_Advanced.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropGroup_Audio"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropGroup_AudioTest()
    {
        Assert.That(PKEY_PropGroup_Audio.fmtid, Is.EqualTo(new Guid(0x2804D469, 0x788F, 0x48AA, 0x85, 0x70, 0x71, 0xB9, 0xC1, 0x87, 0xE1, 0x38)));
        Assert.That(PKEY_PropGroup_Audio.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropGroup_Calendar"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropGroup_CalendarTest()
    {
        Assert.That(PKEY_PropGroup_Calendar.fmtid, Is.EqualTo(new Guid(0x9973D2B5, 0xBFD8, 0x438A, 0xBA, 0x94, 0x53, 0x49, 0xB2, 0x93, 0x18, 0x1A)));
        Assert.That(PKEY_PropGroup_Calendar.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropGroup_Camera"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropGroup_CameraTest()
    {
        Assert.That(PKEY_PropGroup_Camera.fmtid, Is.EqualTo(new Guid(0xDE00DE32, 0x547E, 0x4981, 0xAD, 0x4B, 0x54, 0x2F, 0x2E, 0x90, 0x07, 0xD8)));
        Assert.That(PKEY_PropGroup_Camera.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropGroup_Contact"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropGroup_ContactTest()
    {
        Assert.That(PKEY_PropGroup_Contact.fmtid, Is.EqualTo(new Guid(0xDF975FD3, 0x250A, 0x4004, 0x85, 0x8F, 0x34, 0xE2, 0x9A, 0x3E, 0x37, 0xAA)));
        Assert.That(PKEY_PropGroup_Contact.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropGroup_Content"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropGroup_ContentTest()
    {
        Assert.That(PKEY_PropGroup_Content.fmtid, Is.EqualTo(new Guid(0xD0DAB0BA, 0x368A, 0x4050, 0xA8, 0x82, 0x6C, 0x01, 0x0F, 0xD1, 0x9A, 0x4F)));
        Assert.That(PKEY_PropGroup_Content.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropGroup_Description"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropGroup_DescriptionTest()
    {
        Assert.That(PKEY_PropGroup_Description.fmtid, Is.EqualTo(new Guid(0x8969B275, 0x9475, 0x4E00, 0xA8, 0x87, 0xFF, 0x93, 0xB8, 0xB4, 0x1E, 0x44)));
        Assert.That(PKEY_PropGroup_Description.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropGroup_FileSystem"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropGroup_FileSystemTest()
    {
        Assert.That(PKEY_PropGroup_FileSystem.fmtid, Is.EqualTo(new Guid(0xE3A7D2C1, 0x80FC, 0x4B40, 0x8F, 0x34, 0x30, 0xEA, 0x11, 0x1B, 0xDC, 0x2E)));
        Assert.That(PKEY_PropGroup_FileSystem.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropGroup_General"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropGroup_GeneralTest()
    {
        Assert.That(PKEY_PropGroup_General.fmtid, Is.EqualTo(new Guid(0xCC301630, 0xB192, 0x4C22, 0xB3, 0x72, 0x9F, 0x4C, 0x6D, 0x33, 0x8E, 0x07)));
        Assert.That(PKEY_PropGroup_General.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropGroup_GPS"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropGroup_GPSTest()
    {
        Assert.That(PKEY_PropGroup_GPS.fmtid, Is.EqualTo(new Guid(0xF3713ADA, 0x90E3, 0x4E11, 0xAA, 0xE5, 0xFD, 0xC1, 0x76, 0x85, 0xB9, 0xBE)));
        Assert.That(PKEY_PropGroup_GPS.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropGroup_Image"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropGroup_ImageTest()
    {
        Assert.That(PKEY_PropGroup_Image.fmtid, Is.EqualTo(new Guid(0xE3690A87, 0x0FA8, 0x4A2A, 0x9A, 0x9F, 0xFC, 0xE8, 0x82, 0x70, 0x55, 0xAC)));
        Assert.That(PKEY_PropGroup_Image.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropGroup_Media"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropGroup_MediaTest()
    {
        Assert.That(PKEY_PropGroup_Media.fmtid, Is.EqualTo(new Guid(0x61872CF7, 0x6B5E, 0x4B4B, 0xAC, 0x2D, 0x59, 0xDA, 0x84, 0x45, 0x92, 0x48)));
        Assert.That(PKEY_PropGroup_Media.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropGroup_MediaAdvanced"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropGroup_MediaAdvancedTest()
    {
        Assert.That(PKEY_PropGroup_MediaAdvanced.fmtid, Is.EqualTo(new Guid(0x8859A284, 0xDE7E, 0x4642, 0x99, 0xBA, 0xD4, 0x31, 0xD0, 0x44, 0xB1, 0xEC)));
        Assert.That(PKEY_PropGroup_MediaAdvanced.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropGroup_Message"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropGroup_MessageTest()
    {
        Assert.That(PKEY_PropGroup_Message.fmtid, Is.EqualTo(new Guid(0x7FD7259D, 0x16B4, 0x4135, 0x9F, 0x97, 0x7C, 0x96, 0xEC, 0xD2, 0xFA, 0x9E)));
        Assert.That(PKEY_PropGroup_Message.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropGroup_Music"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropGroup_MusicTest()
    {
        Assert.That(PKEY_PropGroup_Music.fmtid, Is.EqualTo(new Guid(0x68DD6094, 0x7216, 0x40F1, 0xA0, 0x29, 0x43, 0xFE, 0x71, 0x27, 0x04, 0x3F)));
        Assert.That(PKEY_PropGroup_Music.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropGroup_Origin"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropGroup_OriginTest()
    {
        Assert.That(PKEY_PropGroup_Origin.fmtid, Is.EqualTo(new Guid(0x2598D2FB, 0x5569, 0x4367, 0x95, 0xDF, 0x5C, 0xD3, 0xA1, 0x77, 0xE1, 0xA5)));
        Assert.That(PKEY_PropGroup_Origin.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropGroup_PhotoAdvanced"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropGroup_PhotoAdvancedTest()
    {
        Assert.That(PKEY_PropGroup_PhotoAdvanced.fmtid, Is.EqualTo(new Guid(0x0CB2BF5A, 0x9EE7, 0x4A86, 0x82, 0x22, 0xF0, 0x1E, 0x07, 0xFD, 0xAD, 0xAF)));
        Assert.That(PKEY_PropGroup_PhotoAdvanced.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropGroup_RecordedTV"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropGroup_RecordedTVTest()
    {
        Assert.That(PKEY_PropGroup_RecordedTV.fmtid, Is.EqualTo(new Guid(0xE7B33238, 0x6584, 0x4170, 0xA5, 0xC0, 0xAC, 0x25, 0xEF, 0xD9, 0xDA, 0x56)));
        Assert.That(PKEY_PropGroup_RecordedTV.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropGroup_Video"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropGroup_VideoTest()
    {
        Assert.That(PKEY_PropGroup_Video.fmtid, Is.EqualTo(new Guid(0xBEBE0920, 0x7671, 0x4C54, 0xA3, 0xEB, 0x49, 0xFD, 0xDF, 0xC1, 0x91, 0xEE)));
        Assert.That(PKEY_PropGroup_Video.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_InfoTipText"/> property is correct.</summary>
    [Test]
    public static void PKEY_InfoTipTextTest()
    {
        Assert.That(PKEY_InfoTipText.fmtid, Is.EqualTo(new Guid(0xC9944A21, 0xA406, 0x48FE, 0x82, 0x25, 0xAE, 0xC7, 0xE2, 0x4C, 0x21, 0x1B)));
        Assert.That(PKEY_InfoTipText.pid, Is.EqualTo(17));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropList_ConflictPrompt"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropList_ConflictPromptTest()
    {
        Assert.That(PKEY_PropList_ConflictPrompt.fmtid, Is.EqualTo(new Guid(0xC9944A21, 0xA406, 0x48FE, 0x82, 0x25, 0xAE, 0xC7, 0xE2, 0x4C, 0x21, 0x1B)));
        Assert.That(PKEY_PropList_ConflictPrompt.pid, Is.EqualTo(11));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropList_ContentViewModeForBrowse"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropList_ContentViewModeForBrowseTest()
    {
        Assert.That(PKEY_PropList_ContentViewModeForBrowse.fmtid, Is.EqualTo(new Guid(0xC9944A21, 0xA406, 0x48FE, 0x82, 0x25, 0xAE, 0xC7, 0xE2, 0x4C, 0x21, 0x1B)));
        Assert.That(PKEY_PropList_ContentViewModeForBrowse.pid, Is.EqualTo(13));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropList_ContentViewModeForSearch"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropList_ContentViewModeForSearchTest()
    {
        Assert.That(PKEY_PropList_ContentViewModeForSearch.fmtid, Is.EqualTo(new Guid(0xC9944A21, 0xA406, 0x48FE, 0x82, 0x25, 0xAE, 0xC7, 0xE2, 0x4C, 0x21, 0x1B)));
        Assert.That(PKEY_PropList_ContentViewModeForSearch.pid, Is.EqualTo(14));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropList_ExtendedTileInfo"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropList_ExtendedTileInfoTest()
    {
        Assert.That(PKEY_PropList_ExtendedTileInfo.fmtid, Is.EqualTo(new Guid(0xC9944A21, 0xA406, 0x48FE, 0x82, 0x25, 0xAE, 0xC7, 0xE2, 0x4C, 0x21, 0x1B)));
        Assert.That(PKEY_PropList_ExtendedTileInfo.pid, Is.EqualTo(9));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropList_FileOperationPrompt"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropList_FileOperationPromptTest()
    {
        Assert.That(PKEY_PropList_FileOperationPrompt.fmtid, Is.EqualTo(new Guid(0xC9944A21, 0xA406, 0x48FE, 0x82, 0x25, 0xAE, 0xC7, 0xE2, 0x4C, 0x21, 0x1B)));
        Assert.That(PKEY_PropList_FileOperationPrompt.pid, Is.EqualTo(10));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropList_FullDetails"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropList_FullDetailsTest()
    {
        Assert.That(PKEY_PropList_FullDetails.fmtid, Is.EqualTo(new Guid(0xC9944A21, 0xA406, 0x48FE, 0x82, 0x25, 0xAE, 0xC7, 0xE2, 0x4C, 0x21, 0x1B)));
        Assert.That(PKEY_PropList_FullDetails.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropList_InfoTip"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropList_InfoTipTest()
    {
        Assert.That(PKEY_PropList_InfoTip.fmtid, Is.EqualTo(new Guid(0xC9944A21, 0xA406, 0x48FE, 0x82, 0x25, 0xAE, 0xC7, 0xE2, 0x4C, 0x21, 0x1B)));
        Assert.That(PKEY_PropList_InfoTip.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropList_NonPersonal"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropList_NonPersonalTest()
    {
        Assert.That(PKEY_PropList_NonPersonal.fmtid, Is.EqualTo(new Guid(0x49D1091F, 0x082E, 0x493F, 0xB2, 0x3F, 0xD2, 0x30, 0x8A, 0xA9, 0x66, 0x8C)));
        Assert.That(PKEY_PropList_NonPersonal.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropList_PreviewDetails"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropList_PreviewDetailsTest()
    {
        Assert.That(PKEY_PropList_PreviewDetails.fmtid, Is.EqualTo(new Guid(0xC9944A21, 0xA406, 0x48FE, 0x82, 0x25, 0xAE, 0xC7, 0xE2, 0x4C, 0x21, 0x1B)));
        Assert.That(PKEY_PropList_PreviewDetails.pid, Is.EqualTo(8));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropList_PreviewTitle"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropList_PreviewTitleTest()
    {
        Assert.That(PKEY_PropList_PreviewTitle.fmtid, Is.EqualTo(new Guid(0xC9944A21, 0xA406, 0x48FE, 0x82, 0x25, 0xAE, 0xC7, 0xE2, 0x4C, 0x21, 0x1B)));
        Assert.That(PKEY_PropList_PreviewTitle.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropList_QuickTip"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropList_QuickTipTest()
    {
        Assert.That(PKEY_PropList_QuickTip.fmtid, Is.EqualTo(new Guid(0xC9944A21, 0xA406, 0x48FE, 0x82, 0x25, 0xAE, 0xC7, 0xE2, 0x4C, 0x21, 0x1B)));
        Assert.That(PKEY_PropList_QuickTip.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropList_TileInfo"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropList_TileInfoTest()
    {
        Assert.That(PKEY_PropList_TileInfo.fmtid, Is.EqualTo(new Guid(0xC9944A21, 0xA406, 0x48FE, 0x82, 0x25, 0xAE, 0xC7, 0xE2, 0x4C, 0x21, 0x1B)));
        Assert.That(PKEY_PropList_TileInfo.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_PropList_XPDetailsPanel"/> property is correct.</summary>
    [Test]
    public static void PKEY_PropList_XPDetailsPanelTest()
    {
        Assert.That(PKEY_PropList_XPDetailsPanel.fmtid, Is.EqualTo(new Guid(0xF2275480, 0xF782, 0x4291, 0xBD, 0x94, 0xF1, 0x36, 0x93, 0x51, 0x3A, 0xEC)));
        Assert.That(PKEY_PropList_XPDetailsPanel.pid, Is.EqualTo(0));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_RecordedTV_ChannelNumber"/> property is correct.</summary>
    [Test]
    public static void PKEY_RecordedTV_ChannelNumberTest()
    {
        Assert.That(PKEY_RecordedTV_ChannelNumber.fmtid, Is.EqualTo(new Guid(0x6D748DE2, 0x8D38, 0x4CC3, 0xAC, 0x60, 0xF0, 0x09, 0xB0, 0x57, 0xC5, 0x57)));
        Assert.That(PKEY_RecordedTV_ChannelNumber.pid, Is.EqualTo(7));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_RecordedTV_Credits"/> property is correct.</summary>
    [Test]
    public static void PKEY_RecordedTV_CreditsTest()
    {
        Assert.That(PKEY_RecordedTV_Credits.fmtid, Is.EqualTo(new Guid(0x6D748DE2, 0x8D38, 0x4CC3, 0xAC, 0x60, 0xF0, 0x09, 0xB0, 0x57, 0xC5, 0x57)));
        Assert.That(PKEY_RecordedTV_Credits.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_RecordedTV_DateContentExpires"/> property is correct.</summary>
    [Test]
    public static void PKEY_RecordedTV_DateContentExpiresTest()
    {
        Assert.That(PKEY_RecordedTV_DateContentExpires.fmtid, Is.EqualTo(new Guid(0x6D748DE2, 0x8D38, 0x4CC3, 0xAC, 0x60, 0xF0, 0x09, 0xB0, 0x57, 0xC5, 0x57)));
        Assert.That(PKEY_RecordedTV_DateContentExpires.pid, Is.EqualTo(15));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_RecordedTV_EpisodeName"/> property is correct.</summary>
    [Test]
    public static void PKEY_RecordedTV_EpisodeNameTest()
    {
        Assert.That(PKEY_RecordedTV_EpisodeName.fmtid, Is.EqualTo(new Guid(0x6D748DE2, 0x8D38, 0x4CC3, 0xAC, 0x60, 0xF0, 0x09, 0xB0, 0x57, 0xC5, 0x57)));
        Assert.That(PKEY_RecordedTV_EpisodeName.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_RecordedTV_IsATSCContent"/> property is correct.</summary>
    [Test]
    public static void PKEY_RecordedTV_IsATSCContentTest()
    {
        Assert.That(PKEY_RecordedTV_IsATSCContent.fmtid, Is.EqualTo(new Guid(0x6D748DE2, 0x8D38, 0x4CC3, 0xAC, 0x60, 0xF0, 0x09, 0xB0, 0x57, 0xC5, 0x57)));
        Assert.That(PKEY_RecordedTV_IsATSCContent.pid, Is.EqualTo(16));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_RecordedTV_IsClosedCaptioningAvailable"/> property is correct.</summary>
    [Test]
    public static void PKEY_RecordedTV_IsClosedCaptioningAvailableTest()
    {
        Assert.That(PKEY_RecordedTV_IsClosedCaptioningAvailable.fmtid, Is.EqualTo(new Guid(0x6D748DE2, 0x8D38, 0x4CC3, 0xAC, 0x60, 0xF0, 0x09, 0xB0, 0x57, 0xC5, 0x57)));
        Assert.That(PKEY_RecordedTV_IsClosedCaptioningAvailable.pid, Is.EqualTo(12));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_RecordedTV_IsDTVContent"/> property is correct.</summary>
    [Test]
    public static void PKEY_RecordedTV_IsDTVContentTest()
    {
        Assert.That(PKEY_RecordedTV_IsDTVContent.fmtid, Is.EqualTo(new Guid(0x6D748DE2, 0x8D38, 0x4CC3, 0xAC, 0x60, 0xF0, 0x09, 0xB0, 0x57, 0xC5, 0x57)));
        Assert.That(PKEY_RecordedTV_IsDTVContent.pid, Is.EqualTo(17));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_RecordedTV_IsHDContent"/> property is correct.</summary>
    [Test]
    public static void PKEY_RecordedTV_IsHDContentTest()
    {
        Assert.That(PKEY_RecordedTV_IsHDContent.fmtid, Is.EqualTo(new Guid(0x6D748DE2, 0x8D38, 0x4CC3, 0xAC, 0x60, 0xF0, 0x09, 0xB0, 0x57, 0xC5, 0x57)));
        Assert.That(PKEY_RecordedTV_IsHDContent.pid, Is.EqualTo(18));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_RecordedTV_IsRepeatBroadcast"/> property is correct.</summary>
    [Test]
    public static void PKEY_RecordedTV_IsRepeatBroadcastTest()
    {
        Assert.That(PKEY_RecordedTV_IsRepeatBroadcast.fmtid, Is.EqualTo(new Guid(0x6D748DE2, 0x8D38, 0x4CC3, 0xAC, 0x60, 0xF0, 0x09, 0xB0, 0x57, 0xC5, 0x57)));
        Assert.That(PKEY_RecordedTV_IsRepeatBroadcast.pid, Is.EqualTo(13));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_RecordedTV_IsSAP"/> property is correct.</summary>
    [Test]
    public static void PKEY_RecordedTV_IsSAPTest()
    {
        Assert.That(PKEY_RecordedTV_IsSAP.fmtid, Is.EqualTo(new Guid(0x6D748DE2, 0x8D38, 0x4CC3, 0xAC, 0x60, 0xF0, 0x09, 0xB0, 0x57, 0xC5, 0x57)));
        Assert.That(PKEY_RecordedTV_IsSAP.pid, Is.EqualTo(14));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_RecordedTV_NetworkAffiliation"/> property is correct.</summary>
    [Test]
    public static void PKEY_RecordedTV_NetworkAffiliationTest()
    {
        Assert.That(PKEY_RecordedTV_NetworkAffiliation.fmtid, Is.EqualTo(new Guid(0x2C53C813, 0xFB63, 0x4E22, 0xA1, 0xAB, 0x0B, 0x33, 0x1C, 0xA1, 0xE2, 0x73)));
        Assert.That(PKEY_RecordedTV_NetworkAffiliation.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_RecordedTV_OriginalBroadcastDate"/> property is correct.</summary>
    [Test]
    public static void PKEY_RecordedTV_OriginalBroadcastDateTest()
    {
        Assert.That(PKEY_RecordedTV_OriginalBroadcastDate.fmtid, Is.EqualTo(new Guid(0x4684FE97, 0x8765, 0x4842, 0x9C, 0x13, 0xF0, 0x06, 0x44, 0x7B, 0x17, 0x8C)));
        Assert.That(PKEY_RecordedTV_OriginalBroadcastDate.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_RecordedTV_ProgramDescription"/> property is correct.</summary>
    [Test]
    public static void PKEY_RecordedTV_ProgramDescriptionTest()
    {
        Assert.That(PKEY_RecordedTV_ProgramDescription.fmtid, Is.EqualTo(new Guid(0x6D748DE2, 0x8D38, 0x4CC3, 0xAC, 0x60, 0xF0, 0x09, 0xB0, 0x57, 0xC5, 0x57)));
        Assert.That(PKEY_RecordedTV_ProgramDescription.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_RecordedTV_RecordingTime"/> property is correct.</summary>
    [Test]
    public static void PKEY_RecordedTV_RecordingTimeTest()
    {
        Assert.That(PKEY_RecordedTV_RecordingTime.fmtid, Is.EqualTo(new Guid(0xA5477F61, 0x7A82, 0x4ECA, 0x9D, 0xDE, 0x98, 0xB6, 0x9B, 0x24, 0x79, 0xB3)));
        Assert.That(PKEY_RecordedTV_RecordingTime.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_RecordedTV_StationCallSign"/> property is correct.</summary>
    [Test]
    public static void PKEY_RecordedTV_StationCallSignTest()
    {
        Assert.That(PKEY_RecordedTV_StationCallSign.fmtid, Is.EqualTo(new Guid(0x6D748DE2, 0x8D38, 0x4CC3, 0xAC, 0x60, 0xF0, 0x09, 0xB0, 0x57, 0xC5, 0x57)));
        Assert.That(PKEY_RecordedTV_StationCallSign.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_RecordedTV_StationName"/> property is correct.</summary>
    [Test]
    public static void PKEY_RecordedTV_StationNameTest()
    {
        Assert.That(PKEY_RecordedTV_StationName.fmtid, Is.EqualTo(new Guid(0x1B5439E7, 0xEBA1, 0x4AF8, 0xBD, 0xD7, 0x7A, 0xF1, 0xD4, 0x54, 0x94, 0x93)));
        Assert.That(PKEY_RecordedTV_StationName.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Search_AutoSummary"/> property is correct.</summary>
    [Test]
    public static void PKEY_Search_AutoSummaryTest()
    {
        Assert.That(PKEY_Search_AutoSummary.fmtid, Is.EqualTo(new Guid(0x560C36C0, 0x503A, 0x11CF, 0xBA, 0xA1, 0x00, 0x00, 0x4C, 0x75, 0x2A, 0x9A)));
        Assert.That(PKEY_Search_AutoSummary.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Search_ContainerHash"/> property is correct.</summary>
    [Test]
    public static void PKEY_Search_ContainerHashTest()
    {
        Assert.That(PKEY_Search_ContainerHash.fmtid, Is.EqualTo(new Guid(0xBCEEE283, 0x35DF, 0x4D53, 0x82, 0x6A, 0xF3, 0x6A, 0x3E, 0xEF, 0xC6, 0xBE)));
        Assert.That(PKEY_Search_ContainerHash.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Search_Contents"/> property is correct.</summary>
    [Test]
    public static void PKEY_Search_ContentsTest()
    {
        Assert.That(PKEY_Search_Contents.fmtid, Is.EqualTo(new Guid(0xB725F130, 0x47EF, 0x101A, 0xA5, 0xF1, 0x02, 0x60, 0x8C, 0x9E, 0xEB, 0xAC)));
        Assert.That(PKEY_Search_Contents.pid, Is.EqualTo(19));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Search_EntryID"/> property is correct.</summary>
    [Test]
    public static void PKEY_Search_EntryIDTest()
    {
        Assert.That(PKEY_Search_EntryID.fmtid, Is.EqualTo(new Guid(0x49691C90, 0x7E17, 0x101A, 0xA9, 0x1C, 0x08, 0x00, 0x2B, 0x2E, 0xCD, 0xA9)));
        Assert.That(PKEY_Search_EntryID.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Search_ExtendedProperties"/> property is correct.</summary>
    [Test]
    public static void PKEY_Search_ExtendedPropertiesTest()
    {
        Assert.That(PKEY_Search_ExtendedProperties.fmtid, Is.EqualTo(new Guid(0x7B03B546, 0xFA4F, 0x4A52, 0xA2, 0xFE, 0x03, 0xD5, 0x31, 0x1E, 0x58, 0x65)));
        Assert.That(PKEY_Search_ExtendedProperties.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Search_GatherTime"/> property is correct.</summary>
    [Test]
    public static void PKEY_Search_GatherTimeTest()
    {
        Assert.That(PKEY_Search_GatherTime.fmtid, Is.EqualTo(new Guid(0x0B63E350, 0x9CCC, 0x11D0, 0xBC, 0xDB, 0x00, 0x80, 0x5F, 0xCC, 0xCE, 0x04)));
        Assert.That(PKEY_Search_GatherTime.pid, Is.EqualTo(8));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Search_HitCount"/> property is correct.</summary>
    [Test]
    public static void PKEY_Search_HitCountTest()
    {
        Assert.That(PKEY_Search_HitCount.fmtid, Is.EqualTo(new Guid(0x49691C90, 0x7E17, 0x101A, 0xA9, 0x1C, 0x08, 0x00, 0x2B, 0x2E, 0xCD, 0xA9)));
        Assert.That(PKEY_Search_HitCount.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Search_IsClosedDirectory"/> property is correct.</summary>
    [Test]
    public static void PKEY_Search_IsClosedDirectoryTest()
    {
        Assert.That(PKEY_Search_IsClosedDirectory.fmtid, Is.EqualTo(new Guid(0x0B63E343, 0x9CCC, 0x11D0, 0xBC, 0xDB, 0x00, 0x80, 0x5F, 0xCC, 0xCE, 0x04)));
        Assert.That(PKEY_Search_IsClosedDirectory.pid, Is.EqualTo(23));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Search_IsFullyContained"/> property is correct.</summary>
    [Test]
    public static void PKEY_Search_IsFullyContainedTest()
    {
        Assert.That(PKEY_Search_IsFullyContained.fmtid, Is.EqualTo(new Guid(0x0B63E343, 0x9CCC, 0x11D0, 0xBC, 0xDB, 0x00, 0x80, 0x5F, 0xCC, 0xCE, 0x04)));
        Assert.That(PKEY_Search_IsFullyContained.pid, Is.EqualTo(24));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Search_QueryFocusedSummary"/> property is correct.</summary>
    [Test]
    public static void PKEY_Search_QueryFocusedSummaryTest()
    {
        Assert.That(PKEY_Search_QueryFocusedSummary.fmtid, Is.EqualTo(new Guid(0x560C36C0, 0x503A, 0x11CF, 0xBA, 0xA1, 0x00, 0x00, 0x4C, 0x75, 0x2A, 0x9A)));
        Assert.That(PKEY_Search_QueryFocusedSummary.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Search_QueryFocusedSummaryWithFallback"/> property is correct.</summary>
    [Test]
    public static void PKEY_Search_QueryFocusedSummaryWithFallbackTest()
    {
        Assert.That(PKEY_Search_QueryFocusedSummaryWithFallback.fmtid, Is.EqualTo(new Guid(0x560C36C0, 0x503A, 0x11CF, 0xBA, 0xA1, 0x00, 0x00, 0x4C, 0x75, 0x2A, 0x9A)));
        Assert.That(PKEY_Search_QueryFocusedSummaryWithFallback.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Search_QueryPropertyHits"/> property is correct.</summary>
    [Test]
    public static void PKEY_Search_QueryPropertyHitsTest()
    {
        Assert.That(PKEY_Search_QueryPropertyHits.fmtid, Is.EqualTo(new Guid(0x49691C90, 0x7E17, 0x101A, 0xA9, 0x1C, 0x08, 0x00, 0x2B, 0x2E, 0xCD, 0xA9)));
        Assert.That(PKEY_Search_QueryPropertyHits.pid, Is.EqualTo(21));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Search_Rank"/> property is correct.</summary>
    [Test]
    public static void PKEY_Search_RankTest()
    {
        Assert.That(PKEY_Search_Rank.fmtid, Is.EqualTo(new Guid(0x49691C90, 0x7E17, 0x101A, 0xA9, 0x1C, 0x08, 0x00, 0x2B, 0x2E, 0xCD, 0xA9)));
        Assert.That(PKEY_Search_Rank.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Search_Store"/> property is correct.</summary>
    [Test]
    public static void PKEY_Search_StoreTest()
    {
        Assert.That(PKEY_Search_Store.fmtid, Is.EqualTo(new Guid(0xA06992B3, 0x8CAF, 0x4ED7, 0xA5, 0x47, 0xB2, 0x59, 0xE3, 0x2A, 0xC9, 0xFC)));
        Assert.That(PKEY_Search_Store.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Search_UrlToIndex"/> property is correct.</summary>
    [Test]
    public static void PKEY_Search_UrlToIndexTest()
    {
        Assert.That(PKEY_Search_UrlToIndex.fmtid, Is.EqualTo(new Guid(0x0B63E343, 0x9CCC, 0x11D0, 0xBC, 0xDB, 0x00, 0x80, 0x5F, 0xCC, 0xCE, 0x04)));
        Assert.That(PKEY_Search_UrlToIndex.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Search_UrlToIndexWithModificationTime"/> property is correct.</summary>
    [Test]
    public static void PKEY_Search_UrlToIndexWithModificationTimeTest()
    {
        Assert.That(PKEY_Search_UrlToIndexWithModificationTime.fmtid, Is.EqualTo(new Guid(0x0B63E343, 0x9CCC, 0x11D0, 0xBC, 0xDB, 0x00, 0x80, 0x5F, 0xCC, 0xCE, 0x04)));
        Assert.That(PKEY_Search_UrlToIndexWithModificationTime.pid, Is.EqualTo(12));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Supplemental_Album"/> property is correct.</summary>
    [Test]
    public static void PKEY_Supplemental_AlbumTest()
    {
        Assert.That(PKEY_Supplemental_Album.fmtid, Is.EqualTo(new Guid(0x0C73B141, 0x39D6, 0x4653, 0xA6, 0x83, 0xCA, 0xB2, 0x91, 0xEA, 0xF9, 0x5B)));
        Assert.That(PKEY_Supplemental_Album.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Supplemental_AlbumID"/> property is correct.</summary>
    [Test]
    public static void PKEY_Supplemental_AlbumIDTest()
    {
        Assert.That(PKEY_Supplemental_AlbumID.fmtid, Is.EqualTo(new Guid(0x0C73B141, 0x39D6, 0x4653, 0xA6, 0x83, 0xCA, 0xB2, 0x91, 0xEA, 0xF9, 0x5B)));
        Assert.That(PKEY_Supplemental_AlbumID.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Supplemental_Location"/> property is correct.</summary>
    [Test]
    public static void PKEY_Supplemental_LocationTest()
    {
        Assert.That(PKEY_Supplemental_Location.fmtid, Is.EqualTo(new Guid(0x0C73B141, 0x39D6, 0x4653, 0xA6, 0x83, 0xCA, 0xB2, 0x91, 0xEA, 0xF9, 0x5B)));
        Assert.That(PKEY_Supplemental_Location.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Supplemental_Person"/> property is correct.</summary>
    [Test]
    public static void PKEY_Supplemental_PersonTest()
    {
        Assert.That(PKEY_Supplemental_Person.fmtid, Is.EqualTo(new Guid(0x0C73B141, 0x39D6, 0x4653, 0xA6, 0x83, 0xCA, 0xB2, 0x91, 0xEA, 0xF9, 0x5B)));
        Assert.That(PKEY_Supplemental_Person.pid, Is.EqualTo(7));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Supplemental_ResourceId"/> property is correct.</summary>
    [Test]
    public static void PKEY_Supplemental_ResourceIdTest()
    {
        Assert.That(PKEY_Supplemental_ResourceId.fmtid, Is.EqualTo(new Guid(0x0C73B141, 0x39D6, 0x4653, 0xA6, 0x83, 0xCA, 0xB2, 0x91, 0xEA, 0xF9, 0x5B)));
        Assert.That(PKEY_Supplemental_ResourceId.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Supplemental_Tag"/> property is correct.</summary>
    [Test]
    public static void PKEY_Supplemental_TagTest()
    {
        Assert.That(PKEY_Supplemental_Tag.fmtid, Is.EqualTo(new Guid(0x0C73B141, 0x39D6, 0x4653, 0xA6, 0x83, 0xCA, 0xB2, 0x91, 0xEA, 0xF9, 0x5B)));
        Assert.That(PKEY_Supplemental_Tag.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_DescriptionID"/> property is correct.</summary>
    [Test]
    public static void PKEY_DescriptionIDTest()
    {
        Assert.That(PKEY_DescriptionID.fmtid, Is.EqualTo(new Guid(0x28636AA6, 0x953D, 0x11D2, 0xB5, 0xD6, 0x00, 0xC0, 0x4F, 0xD9, 0x18, 0xD0)));
        Assert.That(PKEY_DescriptionID.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_InternalName"/> property is correct.</summary>
    [Test]
    public static void PKEY_InternalNameTest()
    {
        Assert.That(PKEY_InternalName.fmtid, Is.EqualTo(new Guid(0x0CEF7D53, 0xFA64, 0x11D1, 0xA2, 0x03, 0x00, 0x00, 0xF8, 0x1F, 0xED, 0xEE)));
        Assert.That(PKEY_InternalName.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_LibraryLocationsCount"/> property is correct.</summary>
    [Test]
    public static void PKEY_LibraryLocationsCountTest()
    {
        Assert.That(PKEY_LibraryLocationsCount.fmtid, Is.EqualTo(new Guid(0x908696C7, 0x8F87, 0x44F2, 0x80, 0xED, 0xA8, 0xC1, 0xC6, 0x89, 0x45, 0x75)));
        Assert.That(PKEY_LibraryLocationsCount.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Link_TargetSFGAOFlagsStrings"/> property is correct.</summary>
    [Test]
    public static void PKEY_Link_TargetSFGAOFlagsStringsTest()
    {
        Assert.That(PKEY_Link_TargetSFGAOFlagsStrings.fmtid, Is.EqualTo(new Guid(0xD6942081, 0xD53B, 0x443D, 0xAD, 0x47, 0x5E, 0x05, 0x9D, 0x9C, 0xD2, 0x7A)));
        Assert.That(PKEY_Link_TargetSFGAOFlagsStrings.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Link_TargetUrl"/> property is correct.</summary>
    [Test]
    public static void PKEY_Link_TargetUrlTest()
    {
        Assert.That(PKEY_Link_TargetUrl.fmtid, Is.EqualTo(new Guid(0x5CBF2787, 0x48CF, 0x4208, 0xB9, 0x0E, 0xEE, 0x5E, 0x5D, 0x42, 0x02, 0x94)));
        Assert.That(PKEY_Link_TargetUrl.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_NamespaceCLSID"/> property is correct.</summary>
    [Test]
    public static void PKEY_NamespaceCLSIDTest()
    {
        Assert.That(PKEY_NamespaceCLSID.fmtid, Is.EqualTo(new Guid(0x28636AA6, 0x953D, 0x11D2, 0xB5, 0xD6, 0x00, 0xC0, 0x4F, 0xD9, 0x18, 0xD0)));
        Assert.That(PKEY_NamespaceCLSID.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Shell_SFGAOFlagsStrings"/> property is correct.</summary>
    [Test]
    public static void PKEY_Shell_SFGAOFlagsStringsTest()
    {
        Assert.That(PKEY_Shell_SFGAOFlagsStrings.fmtid, Is.EqualTo(new Guid(0xD6942081, 0xD53B, 0x443D, 0xAD, 0x47, 0x5E, 0x05, 0x9D, 0x9C, 0xD2, 0x7A)));
        Assert.That(PKEY_Shell_SFGAOFlagsStrings.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_StatusBarSelectedItemCount"/> property is correct.</summary>
    [Test]
    public static void PKEY_StatusBarSelectedItemCountTest()
    {
        Assert.That(PKEY_StatusBarSelectedItemCount.fmtid, Is.EqualTo(new Guid(0x26DC287C, 0x6E3D, 0x4BD3, 0xB2, 0xB0, 0x6A, 0x26, 0xBA, 0x2E, 0x34, 0x6D)));
        Assert.That(PKEY_StatusBarSelectedItemCount.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_StatusBarViewItemCount"/> property is correct.</summary>
    [Test]
    public static void PKEY_StatusBarViewItemCountTest()
    {
        Assert.That(PKEY_StatusBarViewItemCount.fmtid, Is.EqualTo(new Guid(0x26DC287C, 0x6E3D, 0x4BD3, 0xB2, 0xB0, 0x6A, 0x26, 0xBA, 0x2E, 0x34, 0x6D)));
        Assert.That(PKEY_StatusBarViewItemCount.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_AppUserModel_ExcludeFromShowInNewInstall"/> property is correct.</summary>
    [Test]
    public static void PKEY_AppUserModel_ExcludeFromShowInNewInstallTest()
    {
        Assert.That(PKEY_AppUserModel_ExcludeFromShowInNewInstall.fmtid, Is.EqualTo(new Guid(0x9F4C2855, 0x9F79, 0x4B39, 0xA8, 0xD0, 0xE1, 0xD4, 0x2D, 0xE1, 0xD5, 0xF3)));
        Assert.That(PKEY_AppUserModel_ExcludeFromShowInNewInstall.pid, Is.EqualTo(8));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_AppUserModel_ID"/> property is correct.</summary>
    [Test]
    public static void PKEY_AppUserModel_IDTest()
    {
        Assert.That(PKEY_AppUserModel_ID.fmtid, Is.EqualTo(new Guid(0x9F4C2855, 0x9F79, 0x4B39, 0xA8, 0xD0, 0xE1, 0xD4, 0x2D, 0xE1, 0xD5, 0xF3)));
        Assert.That(PKEY_AppUserModel_ID.pid, Is.EqualTo(5));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_AppUserModel_IsDestListSeparator"/> property is correct.</summary>
    [Test]
    public static void PKEY_AppUserModel_IsDestListSeparatorTest()
    {
        Assert.That(PKEY_AppUserModel_IsDestListSeparator.fmtid, Is.EqualTo(new Guid(0x9F4C2855, 0x9F79, 0x4B39, 0xA8, 0xD0, 0xE1, 0xD4, 0x2D, 0xE1, 0xD5, 0xF3)));
        Assert.That(PKEY_AppUserModel_IsDestListSeparator.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_AppUserModel_IsDualMode"/> property is correct.</summary>
    [Test]
    public static void PKEY_AppUserModel_IsDualModeTest()
    {
        Assert.That(PKEY_AppUserModel_IsDualMode.fmtid, Is.EqualTo(new Guid(0x9F4C2855, 0x9F79, 0x4B39, 0xA8, 0xD0, 0xE1, 0xD4, 0x2D, 0xE1, 0xD5, 0xF3)));
        Assert.That(PKEY_AppUserModel_IsDualMode.pid, Is.EqualTo(11));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_AppUserModel_PreventPinning"/> property is correct.</summary>
    [Test]
    public static void PKEY_AppUserModel_PreventPinningTest()
    {
        Assert.That(PKEY_AppUserModel_PreventPinning.fmtid, Is.EqualTo(new Guid(0x9F4C2855, 0x9F79, 0x4B39, 0xA8, 0xD0, 0xE1, 0xD4, 0x2D, 0xE1, 0xD5, 0xF3)));
        Assert.That(PKEY_AppUserModel_PreventPinning.pid, Is.EqualTo(9));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_AppUserModel_RelaunchCommand"/> property is correct.</summary>
    [Test]
    public static void PKEY_AppUserModel_RelaunchCommandTest()
    {
        Assert.That(PKEY_AppUserModel_RelaunchCommand.fmtid, Is.EqualTo(new Guid(0x9F4C2855, 0x9F79, 0x4B39, 0xA8, 0xD0, 0xE1, 0xD4, 0x2D, 0xE1, 0xD5, 0xF3)));
        Assert.That(PKEY_AppUserModel_RelaunchCommand.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_AppUserModel_RelaunchDisplayNameResource"/> property is correct.</summary>
    [Test]
    public static void PKEY_AppUserModel_RelaunchDisplayNameResourceTest()
    {
        Assert.That(PKEY_AppUserModel_RelaunchDisplayNameResource.fmtid, Is.EqualTo(new Guid(0x9F4C2855, 0x9F79, 0x4B39, 0xA8, 0xD0, 0xE1, 0xD4, 0x2D, 0xE1, 0xD5, 0xF3)));
        Assert.That(PKEY_AppUserModel_RelaunchDisplayNameResource.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_AppUserModel_RelaunchIconResource"/> property is correct.</summary>
    [Test]
    public static void PKEY_AppUserModel_RelaunchIconResourceTest()
    {
        Assert.That(PKEY_AppUserModel_RelaunchIconResource.fmtid, Is.EqualTo(new Guid(0x9F4C2855, 0x9F79, 0x4B39, 0xA8, 0xD0, 0xE1, 0xD4, 0x2D, 0xE1, 0xD5, 0xF3)));
        Assert.That(PKEY_AppUserModel_RelaunchIconResource.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_AppUserModel_SettingsCommand"/> property is correct.</summary>
    [Test]
    public static void PKEY_AppUserModel_SettingsCommandTest()
    {
        Assert.That(PKEY_AppUserModel_SettingsCommand.fmtid, Is.EqualTo(new Guid(0x9F4C2855, 0x9F79, 0x4B39, 0xA8, 0xD0, 0xE1, 0xD4, 0x2D, 0xE1, 0xD5, 0xF3)));
        Assert.That(PKEY_AppUserModel_SettingsCommand.pid, Is.EqualTo(38));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_AppUserModel_StartPinOption"/> property is correct.</summary>
    [Test]
    public static void PKEY_AppUserModel_StartPinOptionTest()
    {
        Assert.That(PKEY_AppUserModel_StartPinOption.fmtid, Is.EqualTo(new Guid(0x9F4C2855, 0x9F79, 0x4B39, 0xA8, 0xD0, 0xE1, 0xD4, 0x2D, 0xE1, 0xD5, 0xF3)));
        Assert.That(PKEY_AppUserModel_StartPinOption.pid, Is.EqualTo(12));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_AppUserModel_ToastActivatorCLSID"/> property is correct.</summary>
    [Test]
    public static void PKEY_AppUserModel_ToastActivatorCLSIDTest()
    {
        Assert.That(PKEY_AppUserModel_ToastActivatorCLSID.fmtid, Is.EqualTo(new Guid(0x9F4C2855, 0x9F79, 0x4B39, 0xA8, 0xD0, 0xE1, 0xD4, 0x2D, 0xE1, 0xD5, 0xF3)));
        Assert.That(PKEY_AppUserModel_ToastActivatorCLSID.pid, Is.EqualTo(26));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_AppUserModel_UninstallCommand"/> property is correct.</summary>
    [Test]
    public static void PKEY_AppUserModel_UninstallCommandTest()
    {
        Assert.That(PKEY_AppUserModel_UninstallCommand.fmtid, Is.EqualTo(new Guid(0x9F4C2855, 0x9F79, 0x4B39, 0xA8, 0xD0, 0xE1, 0xD4, 0x2D, 0xE1, 0xD5, 0xF3)));
        Assert.That(PKEY_AppUserModel_UninstallCommand.pid, Is.EqualTo(37));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_AppUserModel_VisualElementsManifestHintPath"/> property is correct.</summary>
    [Test]
    public static void PKEY_AppUserModel_VisualElementsManifestHintPathTest()
    {
        Assert.That(PKEY_AppUserModel_VisualElementsManifestHintPath.fmtid, Is.EqualTo(new Guid(0x9F4C2855, 0x9F79, 0x4B39, 0xA8, 0xD0, 0xE1, 0xD4, 0x2D, 0xE1, 0xD5, 0xF3)));
        Assert.That(PKEY_AppUserModel_VisualElementsManifestHintPath.pid, Is.EqualTo(31));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_EdgeGesture_DisableTouchWhenFullscreen"/> property is correct.</summary>
    [Test]
    public static void PKEY_EdgeGesture_DisableTouchWhenFullscreenTest()
    {
        Assert.That(PKEY_EdgeGesture_DisableTouchWhenFullscreen.fmtid, Is.EqualTo(new Guid(0x32CE38B2, 0x2C9A, 0x41B1, 0x9B, 0xC5, 0xB3, 0x78, 0x43, 0x94, 0xAA, 0x44)));
        Assert.That(PKEY_EdgeGesture_DisableTouchWhenFullscreen.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Software_DateLastUsed"/> property is correct.</summary>
    [Test]
    public static void PKEY_Software_DateLastUsedTest()
    {
        Assert.That(PKEY_Software_DateLastUsed.fmtid, Is.EqualTo(new Guid(0x841E4F90, 0xFF59, 0x4D16, 0x89, 0x47, 0xE8, 0x1B, 0xBF, 0xFA, 0xB3, 0x6D)));
        Assert.That(PKEY_Software_DateLastUsed.pid, Is.EqualTo(16));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Software_ProductName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Software_ProductNameTest()
    {
        Assert.That(PKEY_Software_ProductName.fmtid, Is.EqualTo(new Guid(0x0CEF7D53, 0xFA64, 0x11D1, 0xA2, 0x03, 0x00, 0x00, 0xF8, 0x1F, 0xED, 0xEE)));
        Assert.That(PKEY_Software_ProductName.pid, Is.EqualTo(7));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Sync_Comments"/> property is correct.</summary>
    [Test]
    public static void PKEY_Sync_CommentsTest()
    {
        Assert.That(PKEY_Sync_Comments.fmtid, Is.EqualTo(new Guid(0x7BD5533E, 0xAF15, 0x44DB, 0xB8, 0xC8, 0xBD, 0x66, 0x24, 0xE1, 0xD0, 0x32)));
        Assert.That(PKEY_Sync_Comments.pid, Is.EqualTo(13));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Sync_ConflictDescription"/> property is correct.</summary>
    [Test]
    public static void PKEY_Sync_ConflictDescriptionTest()
    {
        Assert.That(PKEY_Sync_ConflictDescription.fmtid, Is.EqualTo(new Guid(0xCE50C159, 0x2FB8, 0x41FD, 0xBE, 0x68, 0xD3, 0xE0, 0x42, 0xE2, 0x74, 0xBC)));
        Assert.That(PKEY_Sync_ConflictDescription.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Sync_ConflictFirstLocation"/> property is correct.</summary>
    [Test]
    public static void PKEY_Sync_ConflictFirstLocationTest()
    {
        Assert.That(PKEY_Sync_ConflictFirstLocation.fmtid, Is.EqualTo(new Guid(0xCE50C159, 0x2FB8, 0x41FD, 0xBE, 0x68, 0xD3, 0xE0, 0x42, 0xE2, 0x74, 0xBC)));
        Assert.That(PKEY_Sync_ConflictFirstLocation.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Sync_ConflictSecondLocation"/> property is correct.</summary>
    [Test]
    public static void PKEY_Sync_ConflictSecondLocationTest()
    {
        Assert.That(PKEY_Sync_ConflictSecondLocation.fmtid, Is.EqualTo(new Guid(0xCE50C159, 0x2FB8, 0x41FD, 0xBE, 0x68, 0xD3, 0xE0, 0x42, 0xE2, 0x74, 0xBC)));
        Assert.That(PKEY_Sync_ConflictSecondLocation.pid, Is.EqualTo(7));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Sync_HandlerCollectionID"/> property is correct.</summary>
    [Test]
    public static void PKEY_Sync_HandlerCollectionIDTest()
    {
        Assert.That(PKEY_Sync_HandlerCollectionID.fmtid, Is.EqualTo(new Guid(0x7BD5533E, 0xAF15, 0x44DB, 0xB8, 0xC8, 0xBD, 0x66, 0x24, 0xE1, 0xD0, 0x32)));
        Assert.That(PKEY_Sync_HandlerCollectionID.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Sync_HandlerID"/> property is correct.</summary>
    [Test]
    public static void PKEY_Sync_HandlerIDTest()
    {
        Assert.That(PKEY_Sync_HandlerID.fmtid, Is.EqualTo(new Guid(0x7BD5533E, 0xAF15, 0x44DB, 0xB8, 0xC8, 0xBD, 0x66, 0x24, 0xE1, 0xD0, 0x32)));
        Assert.That(PKEY_Sync_HandlerID.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Sync_HandlerName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Sync_HandlerNameTest()
    {
        Assert.That(PKEY_Sync_HandlerName.fmtid, Is.EqualTo(new Guid(0xCE50C159, 0x2FB8, 0x41FD, 0xBE, 0x68, 0xD3, 0xE0, 0x42, 0xE2, 0x74, 0xBC)));
        Assert.That(PKEY_Sync_HandlerName.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Sync_HandlerType"/> property is correct.</summary>
    [Test]
    public static void PKEY_Sync_HandlerTypeTest()
    {
        Assert.That(PKEY_Sync_HandlerType.fmtid, Is.EqualTo(new Guid(0x7BD5533E, 0xAF15, 0x44DB, 0xB8, 0xC8, 0xBD, 0x66, 0x24, 0xE1, 0xD0, 0x32)));
        Assert.That(PKEY_Sync_HandlerType.pid, Is.EqualTo(8));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Sync_HandlerTypeLabel"/> property is correct.</summary>
    [Test]
    public static void PKEY_Sync_HandlerTypeLabelTest()
    {
        Assert.That(PKEY_Sync_HandlerTypeLabel.fmtid, Is.EqualTo(new Guid(0x7BD5533E, 0xAF15, 0x44DB, 0xB8, 0xC8, 0xBD, 0x66, 0x24, 0xE1, 0xD0, 0x32)));
        Assert.That(PKEY_Sync_HandlerTypeLabel.pid, Is.EqualTo(9));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Sync_ItemID"/> property is correct.</summary>
    [Test]
    public static void PKEY_Sync_ItemIDTest()
    {
        Assert.That(PKEY_Sync_ItemID.fmtid, Is.EqualTo(new Guid(0x7BD5533E, 0xAF15, 0x44DB, 0xB8, 0xC8, 0xBD, 0x66, 0x24, 0xE1, 0xD0, 0x32)));
        Assert.That(PKEY_Sync_ItemID.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Sync_ItemName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Sync_ItemNameTest()
    {
        Assert.That(PKEY_Sync_ItemName.fmtid, Is.EqualTo(new Guid(0xCE50C159, 0x2FB8, 0x41FD, 0xBE, 0x68, 0xD3, 0xE0, 0x42, 0xE2, 0x74, 0xBC)));
        Assert.That(PKEY_Sync_ItemName.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Sync_ProgressPercentage"/> property is correct.</summary>
    [Test]
    public static void PKEY_Sync_ProgressPercentageTest()
    {
        Assert.That(PKEY_Sync_ProgressPercentage.fmtid, Is.EqualTo(new Guid(0x7BD5533E, 0xAF15, 0x44DB, 0xB8, 0xC8, 0xBD, 0x66, 0x24, 0xE1, 0xD0, 0x32)));
        Assert.That(PKEY_Sync_ProgressPercentage.pid, Is.EqualTo(23));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Sync_State"/> property is correct.</summary>
    [Test]
    public static void PKEY_Sync_StateTest()
    {
        Assert.That(PKEY_Sync_State.fmtid, Is.EqualTo(new Guid(0x7BD5533E, 0xAF15, 0x44DB, 0xB8, 0xC8, 0xBD, 0x66, 0x24, 0xE1, 0xD0, 0x32)));
        Assert.That(PKEY_Sync_State.pid, Is.EqualTo(24));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Sync_Status"/> property is correct.</summary>
    [Test]
    public static void PKEY_Sync_StatusTest()
    {
        Assert.That(PKEY_Sync_Status.fmtid, Is.EqualTo(new Guid(0x7BD5533E, 0xAF15, 0x44DB, 0xB8, 0xC8, 0xBD, 0x66, 0x24, 0xE1, 0xD0, 0x32)));
        Assert.That(PKEY_Sync_Status.pid, Is.EqualTo(10));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Task_BillingInformation"/> property is correct.</summary>
    [Test]
    public static void PKEY_Task_BillingInformationTest()
    {
        Assert.That(PKEY_Task_BillingInformation.fmtid, Is.EqualTo(new Guid(0xD37D52C6, 0x261C, 0x4303, 0x82, 0xB3, 0x08, 0xB9, 0x26, 0xAC, 0x6F, 0x12)));
        Assert.That(PKEY_Task_BillingInformation.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Task_CompletionStatus"/> property is correct.</summary>
    [Test]
    public static void PKEY_Task_CompletionStatusTest()
    {
        Assert.That(PKEY_Task_CompletionStatus.fmtid, Is.EqualTo(new Guid(0x084D8A0A, 0xE6D5, 0x40DE, 0xBF, 0x1F, 0xC8, 0x82, 0x0E, 0x7C, 0x87, 0x7C)));
        Assert.That(PKEY_Task_CompletionStatus.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Task_Owner"/> property is correct.</summary>
    [Test]
    public static void PKEY_Task_OwnerTest()
    {
        Assert.That(PKEY_Task_Owner.fmtid, Is.EqualTo(new Guid(0x08C7CC5F, 0x60F2, 0x4494, 0xAD, 0x75, 0x55, 0xE3, 0xE0, 0xB5, 0xAD, 0xD0)));
        Assert.That(PKEY_Task_Owner.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Video_Compression"/> property is correct.</summary>
    [Test]
    public static void PKEY_Video_CompressionTest()
    {
        Assert.That(PKEY_Video_Compression.fmtid, Is.EqualTo(new Guid(0x64440491, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Video_Compression.pid, Is.EqualTo(10));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Video_Director"/> property is correct.</summary>
    [Test]
    public static void PKEY_Video_DirectorTest()
    {
        Assert.That(PKEY_Video_Director.fmtid, Is.EqualTo(new Guid(0x64440492, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Video_Director.pid, Is.EqualTo(20));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Video_EncodingBitrate"/> property is correct.</summary>
    [Test]
    public static void PKEY_Video_EncodingBitrateTest()
    {
        Assert.That(PKEY_Video_EncodingBitrate.fmtid, Is.EqualTo(new Guid(0x64440491, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Video_EncodingBitrate.pid, Is.EqualTo(8));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Video_FourCC"/> property is correct.</summary>
    [Test]
    public static void PKEY_Video_FourCCTest()
    {
        Assert.That(PKEY_Video_FourCC.fmtid, Is.EqualTo(new Guid(0x64440491, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Video_FourCC.pid, Is.EqualTo(44));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Video_FrameHeight"/> property is correct.</summary>
    [Test]
    public static void PKEY_Video_FrameHeightTest()
    {
        Assert.That(PKEY_Video_FrameHeight.fmtid, Is.EqualTo(new Guid(0x64440491, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Video_FrameHeight.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Video_FrameRate"/> property is correct.</summary>
    [Test]
    public static void PKEY_Video_FrameRateTest()
    {
        Assert.That(PKEY_Video_FrameRate.fmtid, Is.EqualTo(new Guid(0x64440491, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Video_FrameRate.pid, Is.EqualTo(6));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Video_FrameWidth"/> property is correct.</summary>
    [Test]
    public static void PKEY_Video_FrameWidthTest()
    {
        Assert.That(PKEY_Video_FrameWidth.fmtid, Is.EqualTo(new Guid(0x64440491, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Video_FrameWidth.pid, Is.EqualTo(3));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Video_HorizontalAspectRatio"/> property is correct.</summary>
    [Test]
    public static void PKEY_Video_HorizontalAspectRatioTest()
    {
        Assert.That(PKEY_Video_HorizontalAspectRatio.fmtid, Is.EqualTo(new Guid(0x64440491, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Video_HorizontalAspectRatio.pid, Is.EqualTo(42));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Video_IsSpherical"/> property is correct.</summary>
    [Test]
    public static void PKEY_Video_IsSphericalTest()
    {
        Assert.That(PKEY_Video_IsSpherical.fmtid, Is.EqualTo(new Guid(0x64440491, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Video_IsSpherical.pid, Is.EqualTo(100));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Video_IsStereo"/> property is correct.</summary>
    [Test]
    public static void PKEY_Video_IsStereoTest()
    {
        Assert.That(PKEY_Video_IsStereo.fmtid, Is.EqualTo(new Guid(0x64440491, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Video_IsStereo.pid, Is.EqualTo(98));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Video_Orientation"/> property is correct.</summary>
    [Test]
    public static void PKEY_Video_OrientationTest()
    {
        Assert.That(PKEY_Video_Orientation.fmtid, Is.EqualTo(new Guid(0x64440491, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Video_Orientation.pid, Is.EqualTo(99));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Video_SampleSize"/> property is correct.</summary>
    [Test]
    public static void PKEY_Video_SampleSizeTest()
    {
        Assert.That(PKEY_Video_SampleSize.fmtid, Is.EqualTo(new Guid(0x64440491, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Video_SampleSize.pid, Is.EqualTo(9));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Video_StreamName"/> property is correct.</summary>
    [Test]
    public static void PKEY_Video_StreamNameTest()
    {
        Assert.That(PKEY_Video_StreamName.fmtid, Is.EqualTo(new Guid(0x64440491, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Video_StreamName.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Video_StreamNumber"/> property is correct.</summary>
    [Test]
    public static void PKEY_Video_StreamNumberTest()
    {
        Assert.That(PKEY_Video_StreamNumber.fmtid, Is.EqualTo(new Guid(0x64440491, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Video_StreamNumber.pid, Is.EqualTo(11));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Video_TotalBitrate"/> property is correct.</summary>
    [Test]
    public static void PKEY_Video_TotalBitrateTest()
    {
        Assert.That(PKEY_Video_TotalBitrate.fmtid, Is.EqualTo(new Guid(0x64440491, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Video_TotalBitrate.pid, Is.EqualTo(43));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Video_TranscodedForSync"/> property is correct.</summary>
    [Test]
    public static void PKEY_Video_TranscodedForSyncTest()
    {
        Assert.That(PKEY_Video_TranscodedForSync.fmtid, Is.EqualTo(new Guid(0x64440491, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Video_TranscodedForSync.pid, Is.EqualTo(46));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Video_VerticalAspectRatio"/> property is correct.</summary>
    [Test]
    public static void PKEY_Video_VerticalAspectRatioTest()
    {
        Assert.That(PKEY_Video_VerticalAspectRatio.fmtid, Is.EqualTo(new Guid(0x64440491, 0x4C8B, 0x11D1, 0x8B, 0x70, 0x08, 0x00, 0x36, 0xB1, 0x1A, 0x03)));
        Assert.That(PKEY_Video_VerticalAspectRatio.pid, Is.EqualTo(45));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Volume_FileSystem"/> property is correct.</summary>
    [Test]
    public static void PKEY_Volume_FileSystemTest()
    {
        Assert.That(PKEY_Volume_FileSystem.fmtid, Is.EqualTo(new Guid(0x9B174B35, 0x40FF, 0x11D2, 0xA2, 0x7E, 0x00, 0xC0, 0x4F, 0xC3, 0x08, 0x71)));
        Assert.That(PKEY_Volume_FileSystem.pid, Is.EqualTo(4));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Volume_IsMappedDrive"/> property is correct.</summary>
    [Test]
    public static void PKEY_Volume_IsMappedDriveTest()
    {
        Assert.That(PKEY_Volume_IsMappedDrive.fmtid, Is.EqualTo(new Guid(0x149C0B69, 0x2C2D, 0x48FC, 0x80, 0x8F, 0xD3, 0x18, 0xD7, 0x8C, 0x46, 0x36)));
        Assert.That(PKEY_Volume_IsMappedDrive.pid, Is.EqualTo(2));
    }

    /// <summary>Validates that the value of the <see cref = "PKEY_Volume_IsRoot"/> property is correct.</summary>
    [Test]
    public static void PKEY_Volume_IsRootTest()
    {
        Assert.That(PKEY_Volume_IsRoot.fmtid, Is.EqualTo(new Guid(0x9B174B35, 0x40FF, 0x11D2, 0xA2, 0x7E, 0x00, 0xC0, 0x4F, 0xC3, 0x08, 0x71)));
        Assert.That(PKEY_Volume_IsRoot.pid, Is.EqualTo(10));
    }
}