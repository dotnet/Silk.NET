// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_VIDEO_ENCODER_LEVEL_SETTING.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_LEVEL_SETTING"]/*'/>
public unsafe partial struct D3D12_VIDEO_ENCODER_LEVEL_SETTING
{
    /// <include file='D3D12_VIDEO_ENCODER_LEVEL_SETTING.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_LEVEL_SETTING.DataSize"]/*'/>
    public uint DataSize;
    /// <include file='D3D12_VIDEO_ENCODER_LEVEL_SETTING.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_LEVEL_SETTING.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_d3d12video_L6504_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pH264LevelSetting"]/*'/>
    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_LEVELS_H264* pH264LevelSetting
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pH264LevelSetting;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pHEVCLevelSetting"]/*'/>
    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_LEVEL_TIER_CONSTRAINTS_HEVC* pHEVCLevelSetting
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pHEVCLevelSetting;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pH264LevelSetting"]/*'/>
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_LEVELS_H264* pH264LevelSetting;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pHEVCLevelSetting"]/*'/>
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_LEVEL_TIER_CONSTRAINTS_HEVC* pHEVCLevelSetting;
    }
}