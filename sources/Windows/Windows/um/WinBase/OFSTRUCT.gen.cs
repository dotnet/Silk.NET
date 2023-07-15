// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='OFSTRUCT.xml' path='doc/member[@name="OFSTRUCT"]/*'/>
public unsafe partial struct OFSTRUCT
{
    /// <include file='OFSTRUCT.xml' path='doc/member[@name="OFSTRUCT.cBytes"]/*'/>
    public byte cBytes;
    /// <include file='OFSTRUCT.xml' path='doc/member[@name="OFSTRUCT.fFixedDisk"]/*'/>
    public byte fFixedDisk;
    /// <include file='OFSTRUCT.xml' path='doc/member[@name="OFSTRUCT.nErrCode"]/*'/>
    [NativeTypeName("WORD")]
    public ushort nErrCode;
    /// <include file='OFSTRUCT.xml' path='doc/member[@name="OFSTRUCT.Reserved1"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Reserved1;
    /// <include file='OFSTRUCT.xml' path='doc/member[@name="OFSTRUCT.Reserved2"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Reserved2;
    /// <include file='OFSTRUCT.xml' path='doc/member[@name="OFSTRUCT.szPathName"]/*'/>
    [NativeTypeName("CHAR[128]")]
    public fixed sbyte szPathName[128];
}