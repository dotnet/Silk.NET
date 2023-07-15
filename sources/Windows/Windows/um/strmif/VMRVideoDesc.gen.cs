// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='VMRVideoDesc.xml' path='doc/member[@name="VMRVideoDesc"]/*'/>
public partial struct VMRVideoDesc
{
    /// <include file='VMRVideoDesc.xml' path='doc/member[@name="VMRVideoDesc.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='VMRVideoDesc.xml' path='doc/member[@name="VMRVideoDesc.dwSampleWidth"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSampleWidth;
    /// <include file='VMRVideoDesc.xml' path='doc/member[@name="VMRVideoDesc.dwSampleHeight"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSampleHeight;
    /// <include file='VMRVideoDesc.xml' path='doc/member[@name="VMRVideoDesc.SingleFieldPerSample"]/*'/>
    public BOOL SingleFieldPerSample;
    /// <include file='VMRVideoDesc.xml' path='doc/member[@name="VMRVideoDesc.dwFourCC"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFourCC;
    /// <include file='VMRVideoDesc.xml' path='doc/member[@name="VMRVideoDesc.InputSampleFreq"]/*'/>
    public VMRFrequency InputSampleFreq;
    /// <include file='VMRVideoDesc.xml' path='doc/member[@name="VMRVideoDesc.OutputFrameFreq"]/*'/>
    public VMRFrequency OutputFrameFreq;
}