// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='REPARSE_GUID_DATA_BUFFER.xml' path='doc/member[@name="REPARSE_GUID_DATA_BUFFER"]/*'/>
public partial struct REPARSE_GUID_DATA_BUFFER
{
    /// <include file='REPARSE_GUID_DATA_BUFFER.xml' path='doc/member[@name="REPARSE_GUID_DATA_BUFFER.ReparseTag"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ReparseTag;
    /// <include file='REPARSE_GUID_DATA_BUFFER.xml' path='doc/member[@name="REPARSE_GUID_DATA_BUFFER.ReparseDataLength"]/*'/>
    [NativeTypeName("WORD")]
    public ushort ReparseDataLength;
    /// <include file='REPARSE_GUID_DATA_BUFFER.xml' path='doc/member[@name="REPARSE_GUID_DATA_BUFFER.Reserved"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Reserved;
    /// <include file='REPARSE_GUID_DATA_BUFFER.xml' path='doc/member[@name="REPARSE_GUID_DATA_BUFFER.ReparseGuid"]/*'/>
    public Guid ReparseGuid;
    /// <include file='REPARSE_GUID_DATA_BUFFER.xml' path='doc/member[@name="REPARSE_GUID_DATA_BUFFER.GenericReparseBuffer"]/*'/>
    [NativeTypeName("__AnonymousRecord_winnt_L14588_C5")]
    public _GenericReparseBuffer_e__Struct GenericReparseBuffer;
    /// <include file='_GenericReparseBuffer_e__Struct.xml' path='doc/member[@name="_GenericReparseBuffer_e__Struct"]/*'/>
    public unsafe partial struct _GenericReparseBuffer_e__Struct
    {
        /// <include file='_GenericReparseBuffer_e__Struct.xml' path='doc/member[@name="_GenericReparseBuffer_e__Struct.DataBuffer"]/*'/>
        [NativeTypeName("BYTE[1]")]
        public fixed byte DataBuffer[1];
    }
}