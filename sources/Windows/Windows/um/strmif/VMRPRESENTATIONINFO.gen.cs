// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.DirectX;

namespace Silk.NET.Windows;
/// <include file='VMRPRESENTATIONINFO.xml' path='doc/member[@name="VMRPRESENTATIONINFO"]/*'/>
public unsafe partial struct VMRPRESENTATIONINFO
{
    /// <include file='VMRPRESENTATIONINFO.xml' path='doc/member[@name="VMRPRESENTATIONINFO.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='VMRPRESENTATIONINFO.xml' path='doc/member[@name="VMRPRESENTATIONINFO.lpSurf"]/*'/>
    [NativeTypeName("LPDIRECTDRAWSURFACE7")]
    public IDirectDrawSurface7* lpSurf;
    /// <include file='VMRPRESENTATIONINFO.xml' path='doc/member[@name="VMRPRESENTATIONINFO.rtStart"]/*'/>
    [NativeTypeName("REFERENCE_TIME")]
    public long rtStart;
    /// <include file='VMRPRESENTATIONINFO.xml' path='doc/member[@name="VMRPRESENTATIONINFO.rtEnd"]/*'/>
    [NativeTypeName("REFERENCE_TIME")]
    public long rtEnd;
    /// <include file='VMRPRESENTATIONINFO.xml' path='doc/member[@name="VMRPRESENTATIONINFO.szAspectRatio"]/*'/>
    public SIZE szAspectRatio;
    /// <include file='VMRPRESENTATIONINFO.xml' path='doc/member[@name="VMRPRESENTATIONINFO.rcSrc"]/*'/>
    public RECT rcSrc;
    /// <include file='VMRPRESENTATIONINFO.xml' path='doc/member[@name="VMRPRESENTATIONINFO.rcDst"]/*'/>
    public RECT rcDst;
    /// <include file='VMRPRESENTATIONINFO.xml' path='doc/member[@name="VMRPRESENTATIONINFO.dwTypeSpecificFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwTypeSpecificFlags;
    /// <include file='VMRPRESENTATIONINFO.xml' path='doc/member[@name="VMRPRESENTATIONINFO.dwInterlaceFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwInterlaceFlags;
}