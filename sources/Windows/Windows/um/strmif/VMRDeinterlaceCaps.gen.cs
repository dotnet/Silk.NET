// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='VMRDeinterlaceCaps.xml' path='doc/member[@name="VMRDeinterlaceCaps"]/*'/>
public partial struct VMRDeinterlaceCaps
{
    /// <include file='VMRDeinterlaceCaps.xml' path='doc/member[@name="VMRDeinterlaceCaps.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='VMRDeinterlaceCaps.xml' path='doc/member[@name="VMRDeinterlaceCaps.dwNumPreviousOutputFrames"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNumPreviousOutputFrames;
    /// <include file='VMRDeinterlaceCaps.xml' path='doc/member[@name="VMRDeinterlaceCaps.dwNumForwardRefSamples"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNumForwardRefSamples;
    /// <include file='VMRDeinterlaceCaps.xml' path='doc/member[@name="VMRDeinterlaceCaps.dwNumBackwardRefSamples"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNumBackwardRefSamples;
    /// <include file='VMRDeinterlaceCaps.xml' path='doc/member[@name="VMRDeinterlaceCaps.DeinterlaceTechnology"]/*'/>
    public VMRDeinterlaceTech DeinterlaceTechnology;
}