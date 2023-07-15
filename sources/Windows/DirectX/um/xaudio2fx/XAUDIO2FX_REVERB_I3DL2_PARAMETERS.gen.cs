// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2fx.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;
/// <include file='XAUDIO2FX_REVERB_I3DL2_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_I3DL2_PARAMETERS"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct XAUDIO2FX_REVERB_I3DL2_PARAMETERS
{
    /// <include file='XAUDIO2FX_REVERB_I3DL2_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_I3DL2_PARAMETERS.WetDryMix"]/*'/>
    public float WetDryMix;
    /// <include file='XAUDIO2FX_REVERB_I3DL2_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_I3DL2_PARAMETERS.Room"]/*'/>
    [NativeTypeName("INT32")]
    public int Room;
    /// <include file='XAUDIO2FX_REVERB_I3DL2_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_I3DL2_PARAMETERS.RoomHF"]/*'/>
    [NativeTypeName("INT32")]
    public int RoomHF;
    /// <include file='XAUDIO2FX_REVERB_I3DL2_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_I3DL2_PARAMETERS.RoomRolloffFactor"]/*'/>
    public float RoomRolloffFactor;
    /// <include file='XAUDIO2FX_REVERB_I3DL2_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_I3DL2_PARAMETERS.DecayTime"]/*'/>
    public float DecayTime;
    /// <include file='XAUDIO2FX_REVERB_I3DL2_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_I3DL2_PARAMETERS.DecayHFRatio"]/*'/>
    public float DecayHFRatio;
    /// <include file='XAUDIO2FX_REVERB_I3DL2_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_I3DL2_PARAMETERS.Reflections"]/*'/>
    [NativeTypeName("INT32")]
    public int Reflections;
    /// <include file='XAUDIO2FX_REVERB_I3DL2_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_I3DL2_PARAMETERS.ReflectionsDelay"]/*'/>
    public float ReflectionsDelay;
    /// <include file='XAUDIO2FX_REVERB_I3DL2_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_I3DL2_PARAMETERS.Reverb"]/*'/>
    [NativeTypeName("INT32")]
    public int Reverb;
    /// <include file='XAUDIO2FX_REVERB_I3DL2_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_I3DL2_PARAMETERS.ReverbDelay"]/*'/>
    public float ReverbDelay;
    /// <include file='XAUDIO2FX_REVERB_I3DL2_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_I3DL2_PARAMETERS.Diffusion"]/*'/>
    public float Diffusion;
    /// <include file='XAUDIO2FX_REVERB_I3DL2_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_I3DL2_PARAMETERS.Density"]/*'/>
    public float Density;
    /// <include file='XAUDIO2FX_REVERB_I3DL2_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_I3DL2_PARAMETERS.HFReference"]/*'/>
    public float HFReference;
}