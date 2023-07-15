// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CLIPDATA.xml' path='doc/member[@name="CLIPDATA"]/*'/>
public unsafe partial struct CLIPDATA
{
    /// <include file='CLIPDATA.xml' path='doc/member[@name="CLIPDATA.cbSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cbSize;
    /// <include file='CLIPDATA.xml' path='doc/member[@name="CLIPDATA.ulClipFmt"]/*'/>
    [NativeTypeName("LONG")]
    public int ulClipFmt;
    /// <include file='CLIPDATA.xml' path='doc/member[@name="CLIPDATA.pClipData"]/*'/>
    public byte* pClipData;
}