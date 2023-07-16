// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DICUSTOMFORCE.xml' path='doc/member[@name="DICUSTOMFORCE"]/*'/>
public unsafe partial struct DICUSTOMFORCE
{
    /// <include file='DICUSTOMFORCE.xml' path='doc/member[@name="DICUSTOMFORCE.cChannels"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cChannels;
    /// <include file='DICUSTOMFORCE.xml' path='doc/member[@name="DICUSTOMFORCE.dwSamplePeriod"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSamplePeriod;
    /// <include file='DICUSTOMFORCE.xml' path='doc/member[@name="DICUSTOMFORCE.cSamples"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cSamples;
    /// <include file='DICUSTOMFORCE.xml' path='doc/member[@name="DICUSTOMFORCE.rglForceData"]/*'/>
    [NativeTypeName("LPLONG")]
    public int* rglForceData;
}