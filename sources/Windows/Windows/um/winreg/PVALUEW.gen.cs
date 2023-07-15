// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='PVALUEW.xml' path='doc/member[@name="PVALUEW"]/*'/>
public unsafe partial struct PVALUEW
{
    /// <include file='PVALUEW.xml' path='doc/member[@name="PVALUEW.pv_valuename"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pv_valuename;
    /// <include file='PVALUEW.xml' path='doc/member[@name="PVALUEW.pv_valuelen"]/*'/>
    public int pv_valuelen;
    /// <include file='PVALUEW.xml' path='doc/member[@name="PVALUEW.pv_value_context"]/*'/>
    [NativeTypeName("LPVOID")]
    public void* pv_value_context;
    /// <include file='PVALUEW.xml' path='doc/member[@name="PVALUEW.pv_type"]/*'/>
    [NativeTypeName("DWORD")]
    public uint pv_type;
}