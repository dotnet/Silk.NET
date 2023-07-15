// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='WINTRUST_BLOB_INFO.xml' path='doc/member[@name="WINTRUST_BLOB_INFO"]/*'/>
public unsafe partial struct WINTRUST_BLOB_INFO
{
    /// <include file='WINTRUST_BLOB_INFO.xml' path='doc/member[@name="WINTRUST_BLOB_INFO.cbStruct"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbStruct;
    /// <include file='WINTRUST_BLOB_INFO.xml' path='doc/member[@name="WINTRUST_BLOB_INFO.gSubject"]/*'/>
    public Guid gSubject;
    /// <include file='WINTRUST_BLOB_INFO.xml' path='doc/member[@name="WINTRUST_BLOB_INFO.pcwszDisplayName"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* pcwszDisplayName;
    /// <include file='WINTRUST_BLOB_INFO.xml' path='doc/member[@name="WINTRUST_BLOB_INFO.cbMemObject"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbMemObject;
    /// <include file='WINTRUST_BLOB_INFO.xml' path='doc/member[@name="WINTRUST_BLOB_INFO.pbMemObject"]/*'/>
    public byte* pbMemObject;
    /// <include file='WINTRUST_BLOB_INFO.xml' path='doc/member[@name="WINTRUST_BLOB_INFO.cbMemSignedMsg"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbMemSignedMsg;
    /// <include file='WINTRUST_BLOB_INFO.xml' path='doc/member[@name="WINTRUST_BLOB_INFO.pbMemSignedMsg"]/*'/>
    public byte* pbMemSignedMsg;
}