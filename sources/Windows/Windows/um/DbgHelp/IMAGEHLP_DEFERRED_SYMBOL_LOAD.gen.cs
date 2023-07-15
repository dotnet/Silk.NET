// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOAD.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOAD"]/*'/>
public unsafe partial struct IMAGEHLP_DEFERRED_SYMBOL_LOAD
{
    /// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOAD.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOAD.SizeOfStruct"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SizeOfStruct;
    /// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOAD.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOAD.BaseOfImage"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BaseOfImage;
    /// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOAD.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOAD.CheckSum"]/*'/>
    [NativeTypeName("DWORD")]
    public uint CheckSum;
    /// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOAD.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOAD.TimeDateStamp"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;
    /// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOAD.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOAD.FileName"]/*'/>
    [NativeTypeName("CHAR[260]")]
    public fixed sbyte FileName[260];
    /// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOAD.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOAD.Reparse"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte Reparse;
    /// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOAD.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOAD.hFile"]/*'/>
    public HANDLE hFile;
}