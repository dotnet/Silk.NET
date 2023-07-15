// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='PROPPRG.xml' path='doc/member[@name="PROPPRG"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct PROPPRG
{
    /// <include file='PROPPRG.xml' path='doc/member[@name="PROPPRG.flPrg"]/*'/>
    [NativeTypeName("WORD")]
    public ushort flPrg;
    /// <include file='PROPPRG.xml' path='doc/member[@name="PROPPRG.flPrgInit"]/*'/>
    [NativeTypeName("WORD")]
    public ushort flPrgInit;
    /// <include file='PROPPRG.xml' path='doc/member[@name="PROPPRG.achTitle"]/*'/>
    [NativeTypeName("CHAR[30]")]
    public fixed sbyte achTitle[30];
    /// <include file='PROPPRG.xml' path='doc/member[@name="PROPPRG.achCmdLine"]/*'/>
    [NativeTypeName("CHAR[128]")]
    public fixed sbyte achCmdLine[128];
    /// <include file='PROPPRG.xml' path='doc/member[@name="PROPPRG.achWorkDir"]/*'/>
    [NativeTypeName("CHAR[64]")]
    public fixed sbyte achWorkDir[64];
    /// <include file='PROPPRG.xml' path='doc/member[@name="PROPPRG.wHotKey"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wHotKey;
    /// <include file='PROPPRG.xml' path='doc/member[@name="PROPPRG.achIconFile"]/*'/>
    [NativeTypeName("CHAR[80]")]
    public fixed sbyte achIconFile[80];
    /// <include file='PROPPRG.xml' path='doc/member[@name="PROPPRG.wIconIndex"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wIconIndex;
    /// <include file='PROPPRG.xml' path='doc/member[@name="PROPPRG.dwEnhModeFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwEnhModeFlags;
    /// <include file='PROPPRG.xml' path='doc/member[@name="PROPPRG.dwRealModeFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRealModeFlags;
    /// <include file='PROPPRG.xml' path='doc/member[@name="PROPPRG.achOtherFile"]/*'/>
    [NativeTypeName("CHAR[80]")]
    public fixed sbyte achOtherFile[80];
    /// <include file='PROPPRG.xml' path='doc/member[@name="PROPPRG.achPIFFile"]/*'/>
    [NativeTypeName("CHAR[260]")]
    public fixed sbyte achPIFFile[260];
}