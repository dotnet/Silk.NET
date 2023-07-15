// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2fx.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='XAUDIO2FX_REVERB_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_PARAMETERS"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct XAUDIO2FX_REVERB_PARAMETERS
{
    /// <include file='XAUDIO2FX_REVERB_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_PARAMETERS.WetDryMix"]/*'/>
    public float WetDryMix;
    /// <include file='XAUDIO2FX_REVERB_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_PARAMETERS.ReflectionsDelay"]/*'/>
    [NativeTypeName("UINT32")]
    public uint ReflectionsDelay;
    /// <include file='XAUDIO2FX_REVERB_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_PARAMETERS.ReverbDelay"]/*'/>
    public byte ReverbDelay;
    /// <include file='XAUDIO2FX_REVERB_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_PARAMETERS.RearDelay"]/*'/>
    public byte RearDelay;
    /// <include file='XAUDIO2FX_REVERB_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_PARAMETERS.SideDelay"]/*'/>
    public byte SideDelay;
    /// <include file='XAUDIO2FX_REVERB_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_PARAMETERS.PositionLeft"]/*'/>
    public byte PositionLeft;
    /// <include file='XAUDIO2FX_REVERB_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_PARAMETERS.PositionRight"]/*'/>
    public byte PositionRight;
    /// <include file='XAUDIO2FX_REVERB_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_PARAMETERS.PositionMatrixLeft"]/*'/>
    public byte PositionMatrixLeft;
    /// <include file='XAUDIO2FX_REVERB_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_PARAMETERS.PositionMatrixRight"]/*'/>
    public byte PositionMatrixRight;
    /// <include file='XAUDIO2FX_REVERB_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_PARAMETERS.EarlyDiffusion"]/*'/>
    public byte EarlyDiffusion;
    /// <include file='XAUDIO2FX_REVERB_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_PARAMETERS.LateDiffusion"]/*'/>
    public byte LateDiffusion;
    /// <include file='XAUDIO2FX_REVERB_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_PARAMETERS.LowEQGain"]/*'/>
    public byte LowEQGain;
    /// <include file='XAUDIO2FX_REVERB_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_PARAMETERS.LowEQCutoff"]/*'/>
    public byte LowEQCutoff;
    /// <include file='XAUDIO2FX_REVERB_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_PARAMETERS.HighEQGain"]/*'/>
    public byte HighEQGain;
    /// <include file='XAUDIO2FX_REVERB_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_PARAMETERS.HighEQCutoff"]/*'/>
    public byte HighEQCutoff;
    /// <include file='XAUDIO2FX_REVERB_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_PARAMETERS.RoomFilterFreq"]/*'/>
    public float RoomFilterFreq;
    /// <include file='XAUDIO2FX_REVERB_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_PARAMETERS.RoomFilterMain"]/*'/>
    public float RoomFilterMain;
    /// <include file='XAUDIO2FX_REVERB_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_PARAMETERS.RoomFilterHF"]/*'/>
    public float RoomFilterHF;
    /// <include file='XAUDIO2FX_REVERB_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_PARAMETERS.ReflectionsGain"]/*'/>
    public float ReflectionsGain;
    /// <include file='XAUDIO2FX_REVERB_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_PARAMETERS.ReverbGain"]/*'/>
    public float ReverbGain;
    /// <include file='XAUDIO2FX_REVERB_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_PARAMETERS.DecayTime"]/*'/>
    public float DecayTime;
    /// <include file='XAUDIO2FX_REVERB_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_PARAMETERS.Density"]/*'/>
    public float Density;
    /// <include file='XAUDIO2FX_REVERB_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_PARAMETERS.RoomSize"]/*'/>
    public float RoomSize;
    /// <include file='XAUDIO2FX_REVERB_PARAMETERS.xml' path='doc/member[@name="XAUDIO2FX_REVERB_PARAMETERS.DisableLateField"]/*'/>
    public BOOL DisableLateField;
}