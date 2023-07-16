// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='FILE_STREAM_INFO.xml' path='doc/member[@name="FILE_STREAM_INFO"]/*'/>
public unsafe partial struct FILE_STREAM_INFO
{
    /// <include file='FILE_STREAM_INFO.xml' path='doc/member[@name="FILE_STREAM_INFO.NextEntryOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NextEntryOffset;
    /// <include file='FILE_STREAM_INFO.xml' path='doc/member[@name="FILE_STREAM_INFO.StreamNameLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint StreamNameLength;
    /// <include file='FILE_STREAM_INFO.xml' path='doc/member[@name="FILE_STREAM_INFO.StreamSize"]/*'/>
    public LARGE_INTEGER StreamSize;
    /// <include file='FILE_STREAM_INFO.xml' path='doc/member[@name="FILE_STREAM_INFO.StreamAllocationSize"]/*'/>
    public LARGE_INTEGER StreamAllocationSize;
    /// <include file='FILE_STREAM_INFO.xml' path='doc/member[@name="FILE_STREAM_INFO.StreamName"]/*'/>
    [NativeTypeName("WCHAR[1]")]
    public fixed ushort StreamName[1];
}