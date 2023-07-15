// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;
/// <include file='XAUDIO2_FILTER_PARAMETERS.xml' path='doc/member[@name="XAUDIO2_FILTER_PARAMETERS"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct XAUDIO2_FILTER_PARAMETERS
{
    /// <include file='XAUDIO2_FILTER_PARAMETERS.xml' path='doc/member[@name="XAUDIO2_FILTER_PARAMETERS.Type"]/*'/>
    public XAUDIO2_FILTER_TYPE Type;
    /// <include file='XAUDIO2_FILTER_PARAMETERS.xml' path='doc/member[@name="XAUDIO2_FILTER_PARAMETERS.Frequency"]/*'/>
    public float Frequency;
    /// <include file='XAUDIO2_FILTER_PARAMETERS.xml' path='doc/member[@name="XAUDIO2_FILTER_PARAMETERS.OneOverQ"]/*'/>
    public float OneOverQ;
}