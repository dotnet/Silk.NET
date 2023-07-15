// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STREAM_ID_MAP.xml' path='doc/member[@name="STREAM_ID_MAP"]/*'/>
public partial struct STREAM_ID_MAP
{
    /// <include file='STREAM_ID_MAP.xml' path='doc/member[@name="STREAM_ID_MAP.stream_id"]/*'/>
    [NativeTypeName("ULONG")]
    public uint stream_id;
    /// <include file='STREAM_ID_MAP.xml' path='doc/member[@name="STREAM_ID_MAP.dwMediaSampleContent"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMediaSampleContent;
    /// <include file='STREAM_ID_MAP.xml' path='doc/member[@name="STREAM_ID_MAP.ulSubstreamFilterValue"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulSubstreamFilterValue;
    /// <include file='STREAM_ID_MAP.xml' path='doc/member[@name="STREAM_ID_MAP.iDataOffset"]/*'/>
    public int iDataOffset;
}