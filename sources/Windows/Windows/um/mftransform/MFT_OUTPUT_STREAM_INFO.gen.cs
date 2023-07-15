// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MFT_OUTPUT_STREAM_INFO.xml' path='doc/member[@name="MFT_OUTPUT_STREAM_INFO"]/*'/>
public partial struct MFT_OUTPUT_STREAM_INFO
{
    /// <include file='MFT_OUTPUT_STREAM_INFO.xml' path='doc/member[@name="MFT_OUTPUT_STREAM_INFO.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='MFT_OUTPUT_STREAM_INFO.xml' path='doc/member[@name="MFT_OUTPUT_STREAM_INFO.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='MFT_OUTPUT_STREAM_INFO.xml' path='doc/member[@name="MFT_OUTPUT_STREAM_INFO.cbAlignment"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbAlignment;
}