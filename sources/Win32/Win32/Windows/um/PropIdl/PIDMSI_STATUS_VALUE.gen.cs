// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/PropIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum PIDMSI_STATUS_VALUE
{
    PIDMSI_STATUS_NORMAL = 0,
    PIDMSI_STATUS_NEW = (PIDMSI_STATUS_NORMAL + 1),
    PIDMSI_STATUS_PRELIM = (PIDMSI_STATUS_NEW + 1),
    PIDMSI_STATUS_DRAFT = (PIDMSI_STATUS_PRELIM + 1),
    PIDMSI_STATUS_INPROGRESS = (PIDMSI_STATUS_DRAFT + 1),
    PIDMSI_STATUS_EDIT = (PIDMSI_STATUS_INPROGRESS + 1),
    PIDMSI_STATUS_REVIEW = (PIDMSI_STATUS_EDIT + 1),
    PIDMSI_STATUS_PROOF = (PIDMSI_STATUS_REVIEW + 1),
    PIDMSI_STATUS_FINAL = (PIDMSI_STATUS_PROOF + 1),
    PIDMSI_STATUS_OTHER = 0x7fff,
}
