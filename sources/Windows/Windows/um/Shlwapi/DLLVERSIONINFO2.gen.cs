// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DLLVERSIONINFO2.xml' path='doc/member[@name="DLLVERSIONINFO2"]/*'/>
public partial struct DLLVERSIONINFO2
{
    /// <include file='DLLVERSIONINFO2.xml' path='doc/member[@name="DLLVERSIONINFO2.info1"]/*'/>
    public DLLVERSIONINFO info1;
    /// <include file='DLLVERSIONINFO2.xml' path='doc/member[@name="DLLVERSIONINFO2.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='DLLVERSIONINFO2.xml' path='doc/member[@name="DLLVERSIONINFO2.ullVersion"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong ullVersion;
}