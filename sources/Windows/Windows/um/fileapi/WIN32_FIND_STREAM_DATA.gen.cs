// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/fileapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WIN32_FIND_STREAM_DATA.xml' path='doc/member[@name="WIN32_FIND_STREAM_DATA"]/*'/>
public unsafe partial struct WIN32_FIND_STREAM_DATA
{
    /// <include file='WIN32_FIND_STREAM_DATA.xml' path='doc/member[@name="WIN32_FIND_STREAM_DATA.StreamSize"]/*'/>
    public LARGE_INTEGER StreamSize;
    /// <include file='WIN32_FIND_STREAM_DATA.xml' path='doc/member[@name="WIN32_FIND_STREAM_DATA.cStreamName"]/*'/>
    [NativeTypeName("WCHAR[296]")]
    public fixed ushort cStreamName[296];
}