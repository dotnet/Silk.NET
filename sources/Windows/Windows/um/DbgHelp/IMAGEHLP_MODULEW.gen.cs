// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IMAGEHLP_MODULEW.xml' path='doc/member[@name="IMAGEHLP_MODULEW"]/*'/>
public unsafe partial struct IMAGEHLP_MODULEW
{
    /// <include file='IMAGEHLP_MODULEW.xml' path='doc/member[@name="IMAGEHLP_MODULEW.SizeOfStruct"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SizeOfStruct;
    /// <include file='IMAGEHLP_MODULEW.xml' path='doc/member[@name="IMAGEHLP_MODULEW.BaseOfImage"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BaseOfImage;
    /// <include file='IMAGEHLP_MODULEW.xml' path='doc/member[@name="IMAGEHLP_MODULEW.ImageSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ImageSize;
    /// <include file='IMAGEHLP_MODULEW.xml' path='doc/member[@name="IMAGEHLP_MODULEW.TimeDateStamp"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;
    /// <include file='IMAGEHLP_MODULEW.xml' path='doc/member[@name="IMAGEHLP_MODULEW.CheckSum"]/*'/>
    [NativeTypeName("DWORD")]
    public uint CheckSum;
    /// <include file='IMAGEHLP_MODULEW.xml' path='doc/member[@name="IMAGEHLP_MODULEW.NumSyms"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumSyms;
    /// <include file='IMAGEHLP_MODULEW.xml' path='doc/member[@name="IMAGEHLP_MODULEW.SymType"]/*'/>
    public SYM_TYPE SymType;
    /// <include file='IMAGEHLP_MODULEW.xml' path='doc/member[@name="IMAGEHLP_MODULEW.ModuleName"]/*'/>
    [NativeTypeName("WCHAR[32]")]
    public fixed ushort ModuleName[32];
    /// <include file='IMAGEHLP_MODULEW.xml' path='doc/member[@name="IMAGEHLP_MODULEW.ImageName"]/*'/>
    [NativeTypeName("WCHAR[256]")]
    public fixed ushort ImageName[256];
    /// <include file='IMAGEHLP_MODULEW.xml' path='doc/member[@name="IMAGEHLP_MODULEW.LoadedImageName"]/*'/>
    [NativeTypeName("WCHAR[256]")]
    public fixed ushort LoadedImageName[256];
}