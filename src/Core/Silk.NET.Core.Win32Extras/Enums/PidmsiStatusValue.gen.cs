// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "PIDMSI_STATUS_VALUE")]
    public enum PidmsiStatusValue : int
    {
        [Obsolete("Deprecated in favour of \"Normal\"")]
        [NativeName("Name", "PIDMSI_STATUS_NORMAL")]
        PidmsiStatusNormal = 0x0,
        [Obsolete("Deprecated in favour of \"New\"")]
        [NativeName("Name", "PIDMSI_STATUS_NEW")]
        PidmsiStatusNew = 0x1,
        [Obsolete("Deprecated in favour of \"Prelim\"")]
        [NativeName("Name", "PIDMSI_STATUS_PRELIM")]
        PidmsiStatusPrelim = 0x2,
        [Obsolete("Deprecated in favour of \"Draft\"")]
        [NativeName("Name", "PIDMSI_STATUS_DRAFT")]
        PidmsiStatusDraft = 0x3,
        [Obsolete("Deprecated in favour of \"Inprogress\"")]
        [NativeName("Name", "PIDMSI_STATUS_INPROGRESS")]
        PidmsiStatusInprogress = 0x4,
        [Obsolete("Deprecated in favour of \"Edit\"")]
        [NativeName("Name", "PIDMSI_STATUS_EDIT")]
        PidmsiStatusEdit = 0x5,
        [Obsolete("Deprecated in favour of \"Review\"")]
        [NativeName("Name", "PIDMSI_STATUS_REVIEW")]
        PidmsiStatusReview = 0x6,
        [Obsolete("Deprecated in favour of \"Proof\"")]
        [NativeName("Name", "PIDMSI_STATUS_PROOF")]
        PidmsiStatusProof = 0x7,
        [Obsolete("Deprecated in favour of \"Final\"")]
        [NativeName("Name", "PIDMSI_STATUS_FINAL")]
        PidmsiStatusFinal = 0x8,
        [Obsolete("Deprecated in favour of \"Other\"")]
        [NativeName("Name", "PIDMSI_STATUS_OTHER")]
        PidmsiStatusOther = 0x7FFF,
        [NativeName("Name", "PIDMSI_STATUS_NORMAL")]
        Normal = 0x0,
        [NativeName("Name", "PIDMSI_STATUS_NEW")]
        New = 0x1,
        [NativeName("Name", "PIDMSI_STATUS_PRELIM")]
        Prelim = 0x2,
        [NativeName("Name", "PIDMSI_STATUS_DRAFT")]
        Draft = 0x3,
        [NativeName("Name", "PIDMSI_STATUS_INPROGRESS")]
        Inprogress = 0x4,
        [NativeName("Name", "PIDMSI_STATUS_EDIT")]
        Edit = 0x5,
        [NativeName("Name", "PIDMSI_STATUS_REVIEW")]
        Review = 0x6,
        [NativeName("Name", "PIDMSI_STATUS_PROOF")]
        Proof = 0x7,
        [NativeName("Name", "PIDMSI_STATUS_FINAL")]
        Final = 0x8,
        [NativeName("Name", "PIDMSI_STATUS_OTHER")]
        Other = 0x7FFF,
    }
}
