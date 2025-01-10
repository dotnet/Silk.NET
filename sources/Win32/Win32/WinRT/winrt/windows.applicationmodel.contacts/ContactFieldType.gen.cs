// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum ContactFieldType
{
    ContactFieldType_Email = 0,
    ContactFieldType_PhoneNumber = 1,

    [Obsolete(
        "Location  may be altered or unavailable for releases after Windows 8.1. Instead, use Address."
    )]
    ContactFieldType_Location = 2,

    [Obsolete(
        "InstantMessage  may be altered or unavailable for releases after Windows 8.1. Instead, use ConnectedServiceAccount."
    )]
    ContactFieldType_InstantMessage = 3,

    [Obsolete(
        "Custom may be altered or unavailable for releases after Windows 8.1. Instead, use one of the specific types."
    )]
    ContactFieldType_Custom = 4,
    ContactFieldType_ConnectedServiceAccount = 5,
    ContactFieldType_ImportantDate = 6,
    ContactFieldType_Address = 7,
    ContactFieldType_SignificantOther = 8,
    ContactFieldType_Notes = 9,
    ContactFieldType_Website = 10,
    ContactFieldType_JobInfo = 11,
}
