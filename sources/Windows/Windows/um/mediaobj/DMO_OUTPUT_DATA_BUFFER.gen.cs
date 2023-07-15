// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mediaobj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DMO_OUTPUT_DATA_BUFFER.xml' path='doc/member[@name="DMO_OUTPUT_DATA_BUFFER"]/*'/>
public unsafe partial struct DMO_OUTPUT_DATA_BUFFER
{
    /// <include file='DMO_OUTPUT_DATA_BUFFER.xml' path='doc/member[@name="DMO_OUTPUT_DATA_BUFFER.pBuffer"]/*'/>
    public IMediaBuffer* pBuffer;
    /// <include file='DMO_OUTPUT_DATA_BUFFER.xml' path='doc/member[@name="DMO_OUTPUT_DATA_BUFFER.dwStatus"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwStatus;
    /// <include file='DMO_OUTPUT_DATA_BUFFER.xml' path='doc/member[@name="DMO_OUTPUT_DATA_BUFFER.rtTimestamp"]/*'/>
    [NativeTypeName("REFERENCE_TIME")]
    public long rtTimestamp;
    /// <include file='DMO_OUTPUT_DATA_BUFFER.xml' path='doc/member[@name="DMO_OUTPUT_DATA_BUFFER.rtTimelength"]/*'/>
    [NativeTypeName("REFERENCE_TIME")]
    public long rtTimelength;
}