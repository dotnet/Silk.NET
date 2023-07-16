// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DIDEVICEIMAGEINFOHEADERA.xml' path='doc/member[@name="DIDEVICEIMAGEINFOHEADERA"]/*'/>
public unsafe partial struct DIDEVICEIMAGEINFOHEADERA
{
    /// <include file='DIDEVICEIMAGEINFOHEADERA.xml' path='doc/member[@name="DIDEVICEIMAGEINFOHEADERA.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='DIDEVICEIMAGEINFOHEADERA.xml' path='doc/member[@name="DIDEVICEIMAGEINFOHEADERA.dwSizeImageInfo"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSizeImageInfo;
    /// <include file='DIDEVICEIMAGEINFOHEADERA.xml' path='doc/member[@name="DIDEVICEIMAGEINFOHEADERA.dwcViews"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwcViews;
    /// <include file='DIDEVICEIMAGEINFOHEADERA.xml' path='doc/member[@name="DIDEVICEIMAGEINFOHEADERA.dwcButtons"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwcButtons;
    /// <include file='DIDEVICEIMAGEINFOHEADERA.xml' path='doc/member[@name="DIDEVICEIMAGEINFOHEADERA.dwcAxes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwcAxes;
    /// <include file='DIDEVICEIMAGEINFOHEADERA.xml' path='doc/member[@name="DIDEVICEIMAGEINFOHEADERA.dwcPOVs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwcPOVs;
    /// <include file='DIDEVICEIMAGEINFOHEADERA.xml' path='doc/member[@name="DIDEVICEIMAGEINFOHEADERA.dwBufferSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwBufferSize;
    /// <include file='DIDEVICEIMAGEINFOHEADERA.xml' path='doc/member[@name="DIDEVICEIMAGEINFOHEADERA.dwBufferUsed"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwBufferUsed;
    /// <include file='DIDEVICEIMAGEINFOHEADERA.xml' path='doc/member[@name="DIDEVICEIMAGEINFOHEADERA.lprgImageInfoArray"]/*'/>
    [NativeTypeName("LPDIDEVICEIMAGEINFOA")]
    public DIDEVICEIMAGEINFOA* lprgImageInfoArray;
}