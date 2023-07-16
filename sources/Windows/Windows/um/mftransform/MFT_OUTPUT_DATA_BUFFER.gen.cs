// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MFT_OUTPUT_DATA_BUFFER.xml' path='doc/member[@name="MFT_OUTPUT_DATA_BUFFER"]/*'/>
public unsafe partial struct MFT_OUTPUT_DATA_BUFFER
{
    /// <include file='MFT_OUTPUT_DATA_BUFFER.xml' path='doc/member[@name="MFT_OUTPUT_DATA_BUFFER.dwStreamID"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwStreamID;
    /// <include file='MFT_OUTPUT_DATA_BUFFER.xml' path='doc/member[@name="MFT_OUTPUT_DATA_BUFFER.pSample"]/*'/>
    public IMFSample* pSample;
    /// <include file='MFT_OUTPUT_DATA_BUFFER.xml' path='doc/member[@name="MFT_OUTPUT_DATA_BUFFER.dwStatus"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwStatus;
    /// <include file='MFT_OUTPUT_DATA_BUFFER.xml' path='doc/member[@name="MFT_OUTPUT_DATA_BUFFER.pEvents"]/*'/>
    public IMFCollection* pEvents;
}