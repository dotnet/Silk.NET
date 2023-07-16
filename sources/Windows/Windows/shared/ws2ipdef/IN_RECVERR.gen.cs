// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IN_RECVERR.xml' path='doc/member[@name="IN_RECVERR"]/*'/>
public partial struct IN_RECVERR
{
    /// <include file='IN_RECVERR.xml' path='doc/member[@name="IN_RECVERR.protocol"]/*'/>
    public IPPROTO protocol;
    /// <include file='IN_RECVERR.xml' path='doc/member[@name="IN_RECVERR.info"]/*'/>
    [NativeTypeName("ULONG")]
    public uint info;
    /// <include file='IN_RECVERR.xml' path='doc/member[@name="IN_RECVERR.type"]/*'/>
    [NativeTypeName("UINT8")]
    public byte type;
    /// <include file='IN_RECVERR.xml' path='doc/member[@name="IN_RECVERR.code"]/*'/>
    [NativeTypeName("UINT8")]
    public byte code;
}