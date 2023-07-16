// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DIDATAFORMAT.xml' path='doc/member[@name="DIDATAFORMAT"]/*'/>
public unsafe partial struct DIDATAFORMAT
{
    /// <include file='DIDATAFORMAT.xml' path='doc/member[@name="DIDATAFORMAT.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='DIDATAFORMAT.xml' path='doc/member[@name="DIDATAFORMAT.dwObjSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwObjSize;
    /// <include file='DIDATAFORMAT.xml' path='doc/member[@name="DIDATAFORMAT.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='DIDATAFORMAT.xml' path='doc/member[@name="DIDATAFORMAT.dwDataSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDataSize;
    /// <include file='DIDATAFORMAT.xml' path='doc/member[@name="DIDATAFORMAT.dwNumObjs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNumObjs;
    /// <include file='DIDATAFORMAT.xml' path='doc/member[@name="DIDATAFORMAT.rgodf"]/*'/>
    [NativeTypeName("LPDIOBJECTDATAFORMAT")]
    public DIOBJECTDATAFORMAT* rgodf;
}