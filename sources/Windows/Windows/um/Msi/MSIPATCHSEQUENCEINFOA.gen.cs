// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Msi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MSIPATCHSEQUENCEINFOA.xml' path='doc/member[@name="MSIPATCHSEQUENCEINFOA"]/*'/>
public unsafe partial struct MSIPATCHSEQUENCEINFOA
{
    /// <include file='MSIPATCHSEQUENCEINFOA.xml' path='doc/member[@name="MSIPATCHSEQUENCEINFOA.szPatchData"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* szPatchData;
    /// <include file='MSIPATCHSEQUENCEINFOA.xml' path='doc/member[@name="MSIPATCHSEQUENCEINFOA.ePatchDataType"]/*'/>
    public MSIPATCHDATATYPE ePatchDataType;
    /// <include file='MSIPATCHSEQUENCEINFOA.xml' path='doc/member[@name="MSIPATCHSEQUENCEINFOA.dwOrder"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwOrder;
    /// <include file='MSIPATCHSEQUENCEINFOA.xml' path='doc/member[@name="MSIPATCHSEQUENCEINFOA.uStatus"]/*'/>
    public uint uStatus;
}