// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_RPMB_DATA_FRAME.xml' path='doc/member[@name="STORAGE_RPMB_DATA_FRAME"]/*'/>
public unsafe partial struct STORAGE_RPMB_DATA_FRAME
{
    /// <include file='STORAGE_RPMB_DATA_FRAME.xml' path='doc/member[@name="STORAGE_RPMB_DATA_FRAME.Stuff"]/*'/>
    [NativeTypeName("BYTE[196]")]
    public fixed byte Stuff[196];
    /// <include file='STORAGE_RPMB_DATA_FRAME.xml' path='doc/member[@name="STORAGE_RPMB_DATA_FRAME.KeyOrMAC"]/*'/>
    [NativeTypeName("BYTE[32]")]
    public fixed byte KeyOrMAC[32];
    /// <include file='STORAGE_RPMB_DATA_FRAME.xml' path='doc/member[@name="STORAGE_RPMB_DATA_FRAME.Data"]/*'/>
    [NativeTypeName("BYTE[256]")]
    public fixed byte Data[256];
    /// <include file='STORAGE_RPMB_DATA_FRAME.xml' path='doc/member[@name="STORAGE_RPMB_DATA_FRAME.Nonce"]/*'/>
    [NativeTypeName("BYTE[16]")]
    public fixed byte Nonce[16];
    /// <include file='STORAGE_RPMB_DATA_FRAME.xml' path='doc/member[@name="STORAGE_RPMB_DATA_FRAME.WriteCounter"]/*'/>
    [NativeTypeName("BYTE[4]")]
    public fixed byte WriteCounter[4];
    /// <include file='STORAGE_RPMB_DATA_FRAME.xml' path='doc/member[@name="STORAGE_RPMB_DATA_FRAME.Address"]/*'/>
    [NativeTypeName("BYTE[2]")]
    public fixed byte Address[2];
    /// <include file='STORAGE_RPMB_DATA_FRAME.xml' path='doc/member[@name="STORAGE_RPMB_DATA_FRAME.BlockCount"]/*'/>
    [NativeTypeName("BYTE[2]")]
    public fixed byte BlockCount[2];
    /// <include file='STORAGE_RPMB_DATA_FRAME.xml' path='doc/member[@name="STORAGE_RPMB_DATA_FRAME.OperationResult"]/*'/>
    [NativeTypeName("BYTE[2]")]
    public fixed byte OperationResult[2];
    /// <include file='STORAGE_RPMB_DATA_FRAME.xml' path='doc/member[@name="STORAGE_RPMB_DATA_FRAME.RequestOrResponseType"]/*'/>
    [NativeTypeName("BYTE[2]")]
    public fixed byte RequestOrResponseType[2];
}