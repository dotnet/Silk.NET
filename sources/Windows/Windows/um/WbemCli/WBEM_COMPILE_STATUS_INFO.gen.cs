// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WBEM_COMPILE_STATUS_INFO.xml' path='doc/member[@name="WBEM_COMPILE_STATUS_INFO"]/*'/>
public partial struct WBEM_COMPILE_STATUS_INFO
{
    /// <include file='WBEM_COMPILE_STATUS_INFO.xml' path='doc/member[@name="WBEM_COMPILE_STATUS_INFO.lPhaseError"]/*'/>
    [NativeTypeName("long")]
    public int lPhaseError;
    /// <include file='WBEM_COMPILE_STATUS_INFO.xml' path='doc/member[@name="WBEM_COMPILE_STATUS_INFO.hRes"]/*'/>
    public HRESULT hRes;
    /// <include file='WBEM_COMPILE_STATUS_INFO.xml' path='doc/member[@name="WBEM_COMPILE_STATUS_INFO.ObjectNum"]/*'/>
    [NativeTypeName("long")]
    public int ObjectNum;
    /// <include file='WBEM_COMPILE_STATUS_INFO.xml' path='doc/member[@name="WBEM_COMPILE_STATUS_INFO.FirstLine"]/*'/>
    [NativeTypeName("long")]
    public int FirstLine;
    /// <include file='WBEM_COMPILE_STATUS_INFO.xml' path='doc/member[@name="WBEM_COMPILE_STATUS_INFO.LastLine"]/*'/>
    [NativeTypeName("long")]
    public int LastLine;
    /// <include file='WBEM_COMPILE_STATUS_INFO.xml' path='doc/member[@name="WBEM_COMPILE_STATUS_INFO.dwOutFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwOutFlags;
}