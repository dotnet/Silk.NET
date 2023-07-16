// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IMAGEHLP_CBA_EVENT.xml' path='doc/member[@name="IMAGEHLP_CBA_EVENT"]/*'/>
public unsafe partial struct IMAGEHLP_CBA_EVENT
{
    /// <include file='IMAGEHLP_CBA_EVENT.xml' path='doc/member[@name="IMAGEHLP_CBA_EVENT.severity"]/*'/>
    [NativeTypeName("DWORD")]
    public uint severity;
    /// <include file='IMAGEHLP_CBA_EVENT.xml' path='doc/member[@name="IMAGEHLP_CBA_EVENT.code"]/*'/>
    [NativeTypeName("DWORD")]
    public uint code;
    /// <include file='IMAGEHLP_CBA_EVENT.xml' path='doc/member[@name="IMAGEHLP_CBA_EVENT.desc"]/*'/>
    [NativeTypeName("PCHAR")]
    public sbyte* desc;
    /// <include file='IMAGEHLP_CBA_EVENT.xml' path='doc/member[@name="IMAGEHLP_CBA_EVENT.@object"]/*'/>
    [NativeTypeName("PVOID")]
    public void* @object;
}