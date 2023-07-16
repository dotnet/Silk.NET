// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DIDEVICEOBJECTDATA.xml' path='doc/member[@name="DIDEVICEOBJECTDATA"]/*'/>
public partial struct DIDEVICEOBJECTDATA
{
    /// <include file='DIDEVICEOBJECTDATA.xml' path='doc/member[@name="DIDEVICEOBJECTDATA.dwOfs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwOfs;
    /// <include file='DIDEVICEOBJECTDATA.xml' path='doc/member[@name="DIDEVICEOBJECTDATA.dwData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwData;
    /// <include file='DIDEVICEOBJECTDATA.xml' path='doc/member[@name="DIDEVICEOBJECTDATA.dwTimeStamp"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwTimeStamp;
    /// <include file='DIDEVICEOBJECTDATA.xml' path='doc/member[@name="DIDEVICEOBJECTDATA.dwSequence"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSequence;
    /// <include file='DIDEVICEOBJECTDATA.xml' path='doc/member[@name="DIDEVICEOBJECTDATA.uAppData"]/*'/>
    [NativeTypeName("UINT_PTR")]
    public nuint uAppData;
}