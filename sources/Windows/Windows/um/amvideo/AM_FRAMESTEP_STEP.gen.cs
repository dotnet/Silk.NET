// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='AM_FRAMESTEP_STEP.xml' path='doc/member[@name="AM_FRAMESTEP_STEP"]/*'/>
public partial struct AM_FRAMESTEP_STEP
{
    /// <include file='AM_FRAMESTEP_STEP.xml' path='doc/member[@name="AM_FRAMESTEP_STEP.dwFramesToStep"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFramesToStep;
}