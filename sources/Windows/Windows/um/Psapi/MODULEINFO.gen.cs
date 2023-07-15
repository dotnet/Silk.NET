// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Psapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MODULEINFO.xml' path='doc/member[@name="MODULEINFO"]/*'/>
public unsafe partial struct MODULEINFO
{
    /// <include file='MODULEINFO.xml' path='doc/member[@name="MODULEINFO.lpBaseOfDll"]/*'/>
    [NativeTypeName("LPVOID")]
    public void* lpBaseOfDll;
    /// <include file='MODULEINFO.xml' path='doc/member[@name="MODULEINFO.SizeOfImage"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SizeOfImage;
    /// <include file='MODULEINFO.xml' path='doc/member[@name="MODULEINFO.EntryPoint"]/*'/>
    [NativeTypeName("LPVOID")]
    public void* EntryPoint;
}