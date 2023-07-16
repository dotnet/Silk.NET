// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA"]/*'/>
public unsafe partial struct EXTLOGFONTA
{
    /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA.elfLogFont"]/*'/>
    public LOGFONTA elfLogFont;
    /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA.elfFullName"]/*'/>
    [NativeTypeName("BYTE[64]")]
    public fixed byte elfFullName[64];
    /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA.elfStyle"]/*'/>
    [NativeTypeName("BYTE[32]")]
    public fixed byte elfStyle[32];
    /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA.elfVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint elfVersion;
    /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA.elfStyleSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint elfStyleSize;
    /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA.elfMatch"]/*'/>
    [NativeTypeName("DWORD")]
    public uint elfMatch;
    /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA.elfReserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint elfReserved;
    /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA.elfVendorId"]/*'/>
    [NativeTypeName("BYTE[4]")]
    public fixed byte elfVendorId[4];
    /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA.elfCulture"]/*'/>
    [NativeTypeName("DWORD")]
    public uint elfCulture;
    /// <include file='EXTLOGFONTA.xml' path='doc/member[@name="EXTLOGFONTA.elfPanose"]/*'/>
    public PANOSE elfPanose;
}