// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SPAUDIOSTATUS.xml' path='doc/member[@name="SPAUDIOSTATUS"]/*'/>
public partial struct SPAUDIOSTATUS
{
    /// <include file='SPAUDIOSTATUS.xml' path='doc/member[@name="SPAUDIOSTATUS.cbFreeBuffSpace"]/*'/>
    [NativeTypeName("long")]
    public int cbFreeBuffSpace;
    /// <include file='SPAUDIOSTATUS.xml' path='doc/member[@name="SPAUDIOSTATUS.cbNonBlockingIO"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cbNonBlockingIO;
    /// <include file='SPAUDIOSTATUS.xml' path='doc/member[@name="SPAUDIOSTATUS.State"]/*'/>
    public SPAUDIOSTATE State;
    /// <include file='SPAUDIOSTATUS.xml' path='doc/member[@name="SPAUDIOSTATUS.CurSeekPos"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong CurSeekPos;
    /// <include file='SPAUDIOSTATUS.xml' path='doc/member[@name="SPAUDIOSTATUS.CurDevicePos"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong CurDevicePos;
    /// <include file='SPAUDIOSTATUS.xml' path='doc/member[@name="SPAUDIOSTATUS.dwAudioLevel"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAudioLevel;
    /// <include file='SPAUDIOSTATUS.xml' path='doc/member[@name="SPAUDIOSTATUS.dwReserved2"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved2;
}