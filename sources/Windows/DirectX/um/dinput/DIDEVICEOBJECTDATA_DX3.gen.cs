// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DIDEVICEOBJECTDATA_DX3.xml' path='doc/member[@name="DIDEVICEOBJECTDATA_DX3"]/*'/>
public partial struct DIDEVICEOBJECTDATA_DX3
{
    /// <include file='DIDEVICEOBJECTDATA_DX3.xml' path='doc/member[@name="DIDEVICEOBJECTDATA_DX3.dwOfs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwOfs;
    /// <include file='DIDEVICEOBJECTDATA_DX3.xml' path='doc/member[@name="DIDEVICEOBJECTDATA_DX3.dwData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwData;
    /// <include file='DIDEVICEOBJECTDATA_DX3.xml' path='doc/member[@name="DIDEVICEOBJECTDATA_DX3.dwTimeStamp"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwTimeStamp;
    /// <include file='DIDEVICEOBJECTDATA_DX3.xml' path='doc/member[@name="DIDEVICEOBJECTDATA_DX3.dwSequence"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSequence;
}