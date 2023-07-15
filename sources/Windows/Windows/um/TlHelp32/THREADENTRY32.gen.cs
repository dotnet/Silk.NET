// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/TlHelp32.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='THREADENTRY32.xml' path='doc/member[@name="THREADENTRY32"]/*'/>
public partial struct THREADENTRY32
{
    /// <include file='THREADENTRY32.xml' path='doc/member[@name="THREADENTRY32.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='THREADENTRY32.xml' path='doc/member[@name="THREADENTRY32.cntUsage"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cntUsage;
    /// <include file='THREADENTRY32.xml' path='doc/member[@name="THREADENTRY32.th32ThreadID"]/*'/>
    [NativeTypeName("DWORD")]
    public uint th32ThreadID;
    /// <include file='THREADENTRY32.xml' path='doc/member[@name="THREADENTRY32.th32OwnerProcessID"]/*'/>
    [NativeTypeName("DWORD")]
    public uint th32OwnerProcessID;
    /// <include file='THREADENTRY32.xml' path='doc/member[@name="THREADENTRY32.tpBasePri"]/*'/>
    [NativeTypeName("LONG")]
    public int tpBasePri;
    /// <include file='THREADENTRY32.xml' path='doc/member[@name="THREADENTRY32.tpDeltaPri"]/*'/>
    [NativeTypeName("LONG")]
    public int tpDeltaPri;
    /// <include file='THREADENTRY32.xml' path='doc/member[@name="THREADENTRY32.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
}