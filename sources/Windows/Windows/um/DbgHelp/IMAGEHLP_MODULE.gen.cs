// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IMAGEHLP_MODULE.xml' path='doc/member[@name="IMAGEHLP_MODULE"]/*'/>
public unsafe partial struct IMAGEHLP_MODULE
{
    /// <include file='IMAGEHLP_MODULE.xml' path='doc/member[@name="IMAGEHLP_MODULE.SizeOfStruct"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SizeOfStruct;
    /// <include file='IMAGEHLP_MODULE.xml' path='doc/member[@name="IMAGEHLP_MODULE.BaseOfImage"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BaseOfImage;
    /// <include file='IMAGEHLP_MODULE.xml' path='doc/member[@name="IMAGEHLP_MODULE.ImageSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ImageSize;
    /// <include file='IMAGEHLP_MODULE.xml' path='doc/member[@name="IMAGEHLP_MODULE.TimeDateStamp"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;
    /// <include file='IMAGEHLP_MODULE.xml' path='doc/member[@name="IMAGEHLP_MODULE.CheckSum"]/*'/>
    [NativeTypeName("DWORD")]
    public uint CheckSum;
    /// <include file='IMAGEHLP_MODULE.xml' path='doc/member[@name="IMAGEHLP_MODULE.NumSyms"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumSyms;
    /// <include file='IMAGEHLP_MODULE.xml' path='doc/member[@name="IMAGEHLP_MODULE.SymType"]/*'/>
    public SYM_TYPE SymType;
    /// <include file='IMAGEHLP_MODULE.xml' path='doc/member[@name="IMAGEHLP_MODULE.ModuleName"]/*'/>
    [NativeTypeName("CHAR[32]")]
    public fixed sbyte ModuleName[32];
    /// <include file='IMAGEHLP_MODULE.xml' path='doc/member[@name="IMAGEHLP_MODULE.ImageName"]/*'/>
    [NativeTypeName("CHAR[256]")]
    public fixed sbyte ImageName[256];
    /// <include file='IMAGEHLP_MODULE.xml' path='doc/member[@name="IMAGEHLP_MODULE.LoadedImageName"]/*'/>
    [NativeTypeName("CHAR[256]")]
    public fixed sbyte LoadedImageName[256];
}