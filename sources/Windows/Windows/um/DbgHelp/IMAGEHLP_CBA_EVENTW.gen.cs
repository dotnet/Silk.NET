// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IMAGEHLP_CBA_EVENTW.xml' path='doc/member[@name="IMAGEHLP_CBA_EVENTW"]/*'/>
public unsafe partial struct IMAGEHLP_CBA_EVENTW
{
    /// <include file='IMAGEHLP_CBA_EVENTW.xml' path='doc/member[@name="IMAGEHLP_CBA_EVENTW.severity"]/*'/>
    [NativeTypeName("DWORD")]
    public uint severity;
    /// <include file='IMAGEHLP_CBA_EVENTW.xml' path='doc/member[@name="IMAGEHLP_CBA_EVENTW.code"]/*'/>
    [NativeTypeName("DWORD")]
    public uint code;
    /// <include file='IMAGEHLP_CBA_EVENTW.xml' path='doc/member[@name="IMAGEHLP_CBA_EVENTW.desc"]/*'/>
    [NativeTypeName("PCWSTR")]
    public ushort* desc;
    /// <include file='IMAGEHLP_CBA_EVENTW.xml' path='doc/member[@name="IMAGEHLP_CBA_EVENTW.@object"]/*'/>
    [NativeTypeName("PVOID")]
    public void* @object;
}