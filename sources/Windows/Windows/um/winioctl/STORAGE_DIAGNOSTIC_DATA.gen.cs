// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_DIAGNOSTIC_DATA.xml' path='doc/member[@name="STORAGE_DIAGNOSTIC_DATA"]/*'/>
public unsafe partial struct STORAGE_DIAGNOSTIC_DATA
{
    /// <include file='STORAGE_DIAGNOSTIC_DATA.xml' path='doc/member[@name="STORAGE_DIAGNOSTIC_DATA.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_DIAGNOSTIC_DATA.xml' path='doc/member[@name="STORAGE_DIAGNOSTIC_DATA.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_DIAGNOSTIC_DATA.xml' path='doc/member[@name="STORAGE_DIAGNOSTIC_DATA.ProviderId"]/*'/>
    public Guid ProviderId;
    /// <include file='STORAGE_DIAGNOSTIC_DATA.xml' path='doc/member[@name="STORAGE_DIAGNOSTIC_DATA.BufferSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BufferSize;
    /// <include file='STORAGE_DIAGNOSTIC_DATA.xml' path='doc/member[@name="STORAGE_DIAGNOSTIC_DATA.Reserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Reserved;
    /// <include file='STORAGE_DIAGNOSTIC_DATA.xml' path='doc/member[@name="STORAGE_DIAGNOSTIC_DATA.DiagnosticDataBuffer"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte DiagnosticDataBuffer[1];
}