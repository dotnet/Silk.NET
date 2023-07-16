// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xapofx.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
/// <include file='FXREVERB_PARAMETERS.xml' path='doc/member[@name="FXREVERB_PARAMETERS"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct FXREVERB_PARAMETERS
{
    /// <include file='FXREVERB_PARAMETERS.xml' path='doc/member[@name="FXREVERB_PARAMETERS.Diffusion"]/*'/>
    public float Diffusion;
    /// <include file='FXREVERB_PARAMETERS.xml' path='doc/member[@name="FXREVERB_PARAMETERS.RoomSize"]/*'/>
    public float RoomSize;
}