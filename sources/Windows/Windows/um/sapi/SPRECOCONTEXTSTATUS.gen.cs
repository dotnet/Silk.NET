// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SPRECOCONTEXTSTATUS.xml' path='doc/member[@name="SPRECOCONTEXTSTATUS"]/*'/>
public unsafe partial struct SPRECOCONTEXTSTATUS
{
    /// <include file='SPRECOCONTEXTSTATUS.xml' path='doc/member[@name="SPRECOCONTEXTSTATUS.eInterference"]/*'/>
    public SPINTERFERENCE eInterference;
    /// <include file='SPRECOCONTEXTSTATUS.xml' path='doc/member[@name="SPRECOCONTEXTSTATUS.szRequestTypeOfUI"]/*'/>
    [NativeTypeName("WCHAR[255]")]
    public fixed ushort szRequestTypeOfUI[255];
    /// <include file='SPRECOCONTEXTSTATUS.xml' path='doc/member[@name="SPRECOCONTEXTSTATUS.dwReserved1"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved1;
    /// <include file='SPRECOCONTEXTSTATUS.xml' path='doc/member[@name="SPRECOCONTEXTSTATUS.dwReserved2"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved2;
}