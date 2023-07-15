// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='IMAGEHLP_MODULEW64.xml' path='doc/member[@name="IMAGEHLP_MODULEW64"]/*'/>
public unsafe partial struct IMAGEHLP_MODULEW64
{
    /// <include file='IMAGEHLP_MODULEW64.xml' path='doc/member[@name="IMAGEHLP_MODULEW64.SizeOfStruct"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SizeOfStruct;
    /// <include file='IMAGEHLP_MODULEW64.xml' path='doc/member[@name="IMAGEHLP_MODULEW64.BaseOfImage"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong BaseOfImage;
    /// <include file='IMAGEHLP_MODULEW64.xml' path='doc/member[@name="IMAGEHLP_MODULEW64.ImageSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ImageSize;
    /// <include file='IMAGEHLP_MODULEW64.xml' path='doc/member[@name="IMAGEHLP_MODULEW64.TimeDateStamp"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;
    /// <include file='IMAGEHLP_MODULEW64.xml' path='doc/member[@name="IMAGEHLP_MODULEW64.CheckSum"]/*'/>
    [NativeTypeName("DWORD")]
    public uint CheckSum;
    /// <include file='IMAGEHLP_MODULEW64.xml' path='doc/member[@name="IMAGEHLP_MODULEW64.NumSyms"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumSyms;
    /// <include file='IMAGEHLP_MODULEW64.xml' path='doc/member[@name="IMAGEHLP_MODULEW64.SymType"]/*'/>
    public SYM_TYPE SymType;
    /// <include file='IMAGEHLP_MODULEW64.xml' path='doc/member[@name="IMAGEHLP_MODULEW64.ModuleName"]/*'/>
    [NativeTypeName("WCHAR[32]")]
    public fixed ushort ModuleName[32];
    /// <include file='IMAGEHLP_MODULEW64.xml' path='doc/member[@name="IMAGEHLP_MODULEW64.ImageName"]/*'/>
    [NativeTypeName("WCHAR[256]")]
    public fixed ushort ImageName[256];
    /// <include file='IMAGEHLP_MODULEW64.xml' path='doc/member[@name="IMAGEHLP_MODULEW64.LoadedImageName"]/*'/>
    [NativeTypeName("WCHAR[256]")]
    public fixed ushort LoadedImageName[256];
    /// <include file='IMAGEHLP_MODULEW64.xml' path='doc/member[@name="IMAGEHLP_MODULEW64.LoadedPdbName"]/*'/>
    [NativeTypeName("WCHAR[256]")]
    public fixed ushort LoadedPdbName[256];
    /// <include file='IMAGEHLP_MODULEW64.xml' path='doc/member[@name="IMAGEHLP_MODULEW64.CVSig"]/*'/>
    [NativeTypeName("DWORD")]
    public uint CVSig;
    /// <include file='IMAGEHLP_MODULEW64.xml' path='doc/member[@name="IMAGEHLP_MODULEW64.CVData"]/*'/>
    [NativeTypeName("WCHAR[780]")]
    public fixed ushort CVData[780];
    /// <include file='IMAGEHLP_MODULEW64.xml' path='doc/member[@name="IMAGEHLP_MODULEW64.PdbSig"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PdbSig;
    /// <include file='IMAGEHLP_MODULEW64.xml' path='doc/member[@name="IMAGEHLP_MODULEW64.PdbSig70"]/*'/>
    public Guid PdbSig70;
    /// <include file='IMAGEHLP_MODULEW64.xml' path='doc/member[@name="IMAGEHLP_MODULEW64.PdbAge"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PdbAge;
    /// <include file='IMAGEHLP_MODULEW64.xml' path='doc/member[@name="IMAGEHLP_MODULEW64.PdbUnmatched"]/*'/>
    public BOOL PdbUnmatched;
    /// <include file='IMAGEHLP_MODULEW64.xml' path='doc/member[@name="IMAGEHLP_MODULEW64.DbgUnmatched"]/*'/>
    public BOOL DbgUnmatched;
    /// <include file='IMAGEHLP_MODULEW64.xml' path='doc/member[@name="IMAGEHLP_MODULEW64.LineNumbers"]/*'/>
    public BOOL LineNumbers;
    /// <include file='IMAGEHLP_MODULEW64.xml' path='doc/member[@name="IMAGEHLP_MODULEW64.GlobalSymbols"]/*'/>
    public BOOL GlobalSymbols;
    /// <include file='IMAGEHLP_MODULEW64.xml' path='doc/member[@name="IMAGEHLP_MODULEW64.TypeInfo"]/*'/>
    public BOOL TypeInfo;
    /// <include file='IMAGEHLP_MODULEW64.xml' path='doc/member[@name="IMAGEHLP_MODULEW64.SourceIndexed"]/*'/>
    public BOOL SourceIndexed;
    /// <include file='IMAGEHLP_MODULEW64.xml' path='doc/member[@name="IMAGEHLP_MODULEW64.Publics"]/*'/>
    public BOOL Publics;
    /// <include file='IMAGEHLP_MODULEW64.xml' path='doc/member[@name="IMAGEHLP_MODULEW64.MachineType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MachineType;
    /// <include file='IMAGEHLP_MODULEW64.xml' path='doc/member[@name="IMAGEHLP_MODULEW64.Reserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Reserved;
}