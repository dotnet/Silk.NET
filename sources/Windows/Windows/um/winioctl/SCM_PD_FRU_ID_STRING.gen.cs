// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SCM_PD_FRU_ID_STRING.xml' path='doc/member[@name="SCM_PD_FRU_ID_STRING"]/*'/>
public unsafe partial struct SCM_PD_FRU_ID_STRING
{
    /// <include file='SCM_PD_FRU_ID_STRING.xml' path='doc/member[@name="SCM_PD_FRU_ID_STRING.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='SCM_PD_FRU_ID_STRING.xml' path='doc/member[@name="SCM_PD_FRU_ID_STRING.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='SCM_PD_FRU_ID_STRING.xml' path='doc/member[@name="SCM_PD_FRU_ID_STRING.IdentifierSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint IdentifierSize;
    /// <include file='SCM_PD_FRU_ID_STRING.xml' path='doc/member[@name="SCM_PD_FRU_ID_STRING.Identifier"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte Identifier[1];
}