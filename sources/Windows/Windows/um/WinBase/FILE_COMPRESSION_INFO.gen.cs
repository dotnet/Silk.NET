// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='FILE_COMPRESSION_INFO.xml' path='doc/member[@name="FILE_COMPRESSION_INFO"]/*'/>
public unsafe partial struct FILE_COMPRESSION_INFO
{
    /// <include file='FILE_COMPRESSION_INFO.xml' path='doc/member[@name="FILE_COMPRESSION_INFO.CompressedFileSize"]/*'/>
    public LARGE_INTEGER CompressedFileSize;
    /// <include file='FILE_COMPRESSION_INFO.xml' path='doc/member[@name="FILE_COMPRESSION_INFO.CompressionFormat"]/*'/>
    [NativeTypeName("WORD")]
    public ushort CompressionFormat;
    /// <include file='FILE_COMPRESSION_INFO.xml' path='doc/member[@name="FILE_COMPRESSION_INFO.CompressionUnitShift"]/*'/>
    [NativeTypeName("UCHAR")]
    public byte CompressionUnitShift;
    /// <include file='FILE_COMPRESSION_INFO.xml' path='doc/member[@name="FILE_COMPRESSION_INFO.ChunkShift"]/*'/>
    [NativeTypeName("UCHAR")]
    public byte ChunkShift;
    /// <include file='FILE_COMPRESSION_INFO.xml' path='doc/member[@name="FILE_COMPRESSION_INFO.ClusterShift"]/*'/>
    [NativeTypeName("UCHAR")]
    public byte ClusterShift;
    /// <include file='FILE_COMPRESSION_INFO.xml' path='doc/member[@name="FILE_COMPRESSION_INFO.Reserved"]/*'/>
    [NativeTypeName("UCHAR[3]")]
    public fixed byte Reserved[3];
}