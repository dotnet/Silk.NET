// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='MFVIDEOFORMAT.xml' path='doc/member[@name="MFVIDEOFORMAT"]/*'/>
public partial struct MFVIDEOFORMAT
{
    /// <include file='MFVIDEOFORMAT.xml' path='doc/member[@name="MFVIDEOFORMAT.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='MFVIDEOFORMAT.xml' path='doc/member[@name="MFVIDEOFORMAT.videoInfo"]/*'/>
    public MFVideoInfo videoInfo;
    /// <include file='MFVIDEOFORMAT.xml' path='doc/member[@name="MFVIDEOFORMAT.guidFormat"]/*'/>
    public Guid guidFormat;
    /// <include file='MFVIDEOFORMAT.xml' path='doc/member[@name="MFVIDEOFORMAT.compressedInfo"]/*'/>
    public MFVideoCompressedInfo compressedInfo;
    /// <include file='MFVIDEOFORMAT.xml' path='doc/member[@name="MFVIDEOFORMAT.surfaceInfo"]/*'/>
    public MFVideoSurfaceInfo surfaceInfo;
}