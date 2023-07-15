// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DBGHELP_DATA_REPORT_STRUCT.xml' path='doc/member[@name="DBGHELP_DATA_REPORT_STRUCT"]/*'/>
public unsafe partial struct DBGHELP_DATA_REPORT_STRUCT
{
    /// <include file='DBGHELP_DATA_REPORT_STRUCT.xml' path='doc/member[@name="DBGHELP_DATA_REPORT_STRUCT.pBinPathNonExist"]/*'/>
    [NativeTypeName("PCWSTR")]
    public ushort* pBinPathNonExist;
    /// <include file='DBGHELP_DATA_REPORT_STRUCT.xml' path='doc/member[@name="DBGHELP_DATA_REPORT_STRUCT.pSymbolPathNonExist"]/*'/>
    [NativeTypeName("PCWSTR")]
    public ushort* pSymbolPathNonExist;
}