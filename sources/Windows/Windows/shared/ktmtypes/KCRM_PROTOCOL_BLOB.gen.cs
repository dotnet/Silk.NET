// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ktmtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='KCRM_PROTOCOL_BLOB.xml' path='doc/member[@name="KCRM_PROTOCOL_BLOB"]/*'/>
public partial struct KCRM_PROTOCOL_BLOB
{
    /// <include file='KCRM_PROTOCOL_BLOB.xml' path='doc/member[@name="KCRM_PROTOCOL_BLOB.ProtocolId"]/*'/>
    [NativeTypeName("CRM_PROTOCOL_ID")]
    public Guid ProtocolId;
    /// <include file='KCRM_PROTOCOL_BLOB.xml' path='doc/member[@name="KCRM_PROTOCOL_BLOB.StaticInfoLength"]/*'/>
    [NativeTypeName("ULONG")]
    public uint StaticInfoLength;
    /// <include file='KCRM_PROTOCOL_BLOB.xml' path='doc/member[@name="KCRM_PROTOCOL_BLOB.TransactionIdInfoLength"]/*'/>
    [NativeTypeName("ULONG")]
    public uint TransactionIdInfoLength;
    /// <include file='KCRM_PROTOCOL_BLOB.xml' path='doc/member[@name="KCRM_PROTOCOL_BLOB.Unused1"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Unused1;
    /// <include file='KCRM_PROTOCOL_BLOB.xml' path='doc/member[@name="KCRM_PROTOCOL_BLOB.Unused2"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Unused2;
}