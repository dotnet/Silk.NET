// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DIDEVICEIMAGEINFOHEADERW.xml' path='doc/member[@name="DIDEVICEIMAGEINFOHEADERW"]/*' />
public unsafe partial struct DIDEVICEIMAGEINFOHEADERW
{
    /// <include file='DIDEVICEIMAGEINFOHEADERW.xml' path='doc/member[@name="DIDEVICEIMAGEINFOHEADERW.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='DIDEVICEIMAGEINFOHEADERW.xml' path='doc/member[@name="DIDEVICEIMAGEINFOHEADERW.dwSizeImageInfo"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSizeImageInfo;

    /// <include file='DIDEVICEIMAGEINFOHEADERW.xml' path='doc/member[@name="DIDEVICEIMAGEINFOHEADERW.dwcViews"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwcViews;

    /// <include file='DIDEVICEIMAGEINFOHEADERW.xml' path='doc/member[@name="DIDEVICEIMAGEINFOHEADERW.dwcButtons"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwcButtons;

    /// <include file='DIDEVICEIMAGEINFOHEADERW.xml' path='doc/member[@name="DIDEVICEIMAGEINFOHEADERW.dwcAxes"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwcAxes;

    /// <include file='DIDEVICEIMAGEINFOHEADERW.xml' path='doc/member[@name="DIDEVICEIMAGEINFOHEADERW.dwcPOVs"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwcPOVs;

    /// <include file='DIDEVICEIMAGEINFOHEADERW.xml' path='doc/member[@name="DIDEVICEIMAGEINFOHEADERW.dwBufferSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwBufferSize;

    /// <include file='DIDEVICEIMAGEINFOHEADERW.xml' path='doc/member[@name="DIDEVICEIMAGEINFOHEADERW.dwBufferUsed"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwBufferUsed;

    /// <include file='DIDEVICEIMAGEINFOHEADERW.xml' path='doc/member[@name="DIDEVICEIMAGEINFOHEADERW.lprgImageInfoArray"]/*' />
    [NativeTypeName("LPDIDEVICEIMAGEINFOW")]
    public DIDEVICEIMAGEINFOW* lprgImageInfoArray;
}
