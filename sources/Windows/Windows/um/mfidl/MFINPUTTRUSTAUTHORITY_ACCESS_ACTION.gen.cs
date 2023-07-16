// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MFINPUTTRUSTAUTHORITY_ACCESS_ACTION.xml' path='doc/member[@name="MFINPUTTRUSTAUTHORITY_ACCESS_ACTION"]/*'/>
public unsafe partial struct MFINPUTTRUSTAUTHORITY_ACCESS_ACTION
{
    /// <include file='MFINPUTTRUSTAUTHORITY_ACCESS_ACTION.xml' path='doc/member[@name="MFINPUTTRUSTAUTHORITY_ACCESS_ACTION.Action"]/*'/>
    public MFPOLICYMANAGER_ACTION Action;
    /// <include file='MFINPUTTRUSTAUTHORITY_ACCESS_ACTION.xml' path='doc/member[@name="MFINPUTTRUSTAUTHORITY_ACCESS_ACTION.pbTicket"]/*'/>
    public byte* pbTicket;
    /// <include file='MFINPUTTRUSTAUTHORITY_ACCESS_ACTION.xml' path='doc/member[@name="MFINPUTTRUSTAUTHORITY_ACCESS_ACTION.cbTicket"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbTicket;
}