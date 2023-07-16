// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DISPLAYCONFIG_SOURCE_MODE.xml' path='doc/member[@name="DISPLAYCONFIG_SOURCE_MODE"]/*'/>
public partial struct DISPLAYCONFIG_SOURCE_MODE
{
    /// <include file='DISPLAYCONFIG_SOURCE_MODE.xml' path='doc/member[@name="DISPLAYCONFIG_SOURCE_MODE.width"]/*'/>
    [NativeTypeName("UINT32")]
    public uint width;
    /// <include file='DISPLAYCONFIG_SOURCE_MODE.xml' path='doc/member[@name="DISPLAYCONFIG_SOURCE_MODE.height"]/*'/>
    [NativeTypeName("UINT32")]
    public uint height;
    /// <include file='DISPLAYCONFIG_SOURCE_MODE.xml' path='doc/member[@name="DISPLAYCONFIG_SOURCE_MODE.pixelFormat"]/*'/>
    public DISPLAYCONFIG_PIXELFORMAT pixelFormat;
    /// <include file='DISPLAYCONFIG_SOURCE_MODE.xml' path='doc/member[@name="DISPLAYCONFIG_SOURCE_MODE.position"]/*'/>
    public POINTL position;
}