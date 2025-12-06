// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Generated using the OpenAL Soft headers and corresponding dependencies.
// Original source is licensed under the LGPL 2.0 license. Please note that while bindings are able to be MIT due to
// being header-derived only, implementations of the headers may have a less permissive license.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenAL;

[NativeName("Format")]
public enum Format : uint
{
    [NativeName("AL_FORMAT_MONO8")]
    FormatMono8 = 4352,

    [NativeName("AL_FORMAT_MONO16")]
    FormatMono16 = 4353,

    [NativeName("AL_FORMAT_STEREO8")]
    FormatStereo8 = 4354,

    [NativeName("AL_FORMAT_STEREO16")]
    FormatStereo16 = 4355,

    [NativeName("AL_FORMAT_IMA_ADPCM_MONO16_EXT")]
    FormatImaAdpcmMono16EXT = 65536,

    [NativeName("AL_FORMAT_IMA_ADPCM_STEREO16_EXT")]
    FormatImaAdpcmStereo16EXT = 65537,

    [NativeName("AL_FORMAT_WAVE_EXT")]
    FormatWaveEXT = 65538,

    [NativeName("AL_FORMAT_VORBIS_EXT")]
    FormatVorbisEXT = 65539,

    [NativeName("AL_FORMAT_QUAD8_LOKI")]
    FormatQuad8LOKI = 65540,

    [NativeName("AL_FORMAT_QUAD16_LOKI")]
    FormatQuad16LOKI = 65541,

    [NativeName("AL_FORMAT_MONO_FLOAT32")]
    FormatMonoFloat32 = 65552,

    [NativeName("AL_FORMAT_STEREO_FLOAT32")]
    FormatStereoFloat32 = 65553,

    [NativeName("AL_FORMAT_MONO_DOUBLE_EXT")]
    FormatMonoDoubleEXT = 65554,

    [NativeName("AL_FORMAT_STEREO_DOUBLE_EXT")]
    FormatStereoDoubleEXT = 65555,

    [NativeName("AL_FORMAT_MONO_MULAW_EXT")]
    FormatMonoMulawEXT = 65556,

    [NativeName("AL_FORMAT_STEREO_MULAW_EXT")]
    FormatStereoMulawEXT = 65557,

    [NativeName("AL_FORMAT_MONO_ALAW_EXT")]
    FormatMonoAlawEXT = 65558,

    [NativeName("AL_FORMAT_STEREO_ALAW_EXT")]
    FormatStereoAlawEXT = 65559,

    [NativeName("AL_FORMAT_QUAD8")]
    FormatQuad8 = 4612,

    [NativeName("AL_FORMAT_QUAD16")]
    FormatQuad16 = 4613,

    [NativeName("AL_FORMAT_QUAD32")]
    FormatQuad32 = 4614,

    [NativeName("AL_FORMAT_REAR8")]
    FormatRear8 = 4615,

    [NativeName("AL_FORMAT_REAR16")]
    FormatRear16 = 4616,

    [NativeName("AL_FORMAT_REAR32")]
    FormatRear32 = 4617,

    [NativeName("AL_FORMAT_51CHN8")]
    Format51Chn8 = 4618,

    [NativeName("AL_FORMAT_51CHN16")]
    Format51Chn16 = 4619,

    [NativeName("AL_FORMAT_51CHN32")]
    Format51Chn32 = 4620,

    [NativeName("AL_FORMAT_61CHN8")]
    Format61Chn8 = 4621,

    [NativeName("AL_FORMAT_61CHN16")]
    Format61Chn16 = 4622,

    [NativeName("AL_FORMAT_61CHN32")]
    Format61Chn32 = 4623,

    [NativeName("AL_FORMAT_71CHN8")]
    Format71Chn8 = 4624,

    [NativeName("AL_FORMAT_71CHN16")]
    Format71Chn16 = 4625,

    [NativeName("AL_FORMAT_71CHN32")]
    Format71Chn32 = 4626,

    [NativeName("AL_FORMAT_MONO_MULAW")]
    FormatMonoMulaw = 65556,

    [NativeName("AL_FORMAT_STEREO_MULAW")]
    FormatStereoMulaw = 65557,

    [NativeName("AL_FORMAT_QUAD_MULAW")]
    FormatQuadMulaw = 65569,

    [NativeName("AL_FORMAT_REAR_MULAW")]
    FormatRearMulaw = 65570,

    [NativeName("AL_FORMAT_51CHN_MULAW")]
    Format51ChnMulaw = 65571,

    [NativeName("AL_FORMAT_61CHN_MULAW")]
    Format61ChnMulaw = 65572,

    [NativeName("AL_FORMAT_71CHN_MULAW")]
    Format71ChnMulaw = 65573,

    [NativeName("AL_FORMAT_MONO_IMA4")]
    FormatMonoIma4 = 4864,

    [NativeName("AL_FORMAT_STEREO_IMA4")]
    FormatStereoIma4 = 4865,

    [NativeName("AL_FORMAT_MONO_MSADPCM_SOFT")]
    FormatMonoMsadpcmSOFT = 4866,

    [NativeName("AL_FORMAT_STEREO_MSADPCM_SOFT")]
    FormatStereoMsadpcmSOFT = 4867,

    [NativeName("AL_FORMAT_BFORMAT2D_8")]
    FormatBformat2D8 = 131105,

    [NativeName("AL_FORMAT_BFORMAT2D_16")]
    FormatBformat2D16 = 131106,

    [NativeName("AL_FORMAT_BFORMAT2D_FLOAT32")]
    FormatBformat2DFloat32 = 131107,

    [NativeName("AL_FORMAT_BFORMAT3D_8")]
    FormatBformat3D8 = 131121,

    [NativeName("AL_FORMAT_BFORMAT3D_16")]
    FormatBformat3D16 = 131122,

    [NativeName("AL_FORMAT_BFORMAT3D_FLOAT32")]
    FormatBformat3DFloat32 = 131123,

    [NativeName("AL_FORMAT_BFORMAT2D_MULAW")]
    FormatBformat2DMulaw = 65585,

    [NativeName("AL_FORMAT_BFORMAT3D_MULAW")]
    FormatBformat3DMulaw = 65586,

    [NativeName("AL_FORMAT_UHJ2CHN8_SOFT")]
    FormatUhj2Chn8SOFT = 6562,

    [NativeName("AL_FORMAT_UHJ2CHN16_SOFT")]
    FormatUhj2Chn16SOFT = 6563,

    [NativeName("AL_FORMAT_UHJ2CHN_FLOAT32_SOFT")]
    FormatUhj2ChnFloat32SOFT = 6564,

    [NativeName("AL_FORMAT_UHJ3CHN8_SOFT")]
    FormatUhj3Chn8SOFT = 6565,

    [NativeName("AL_FORMAT_UHJ3CHN16_SOFT")]
    FormatUhj3Chn16SOFT = 6566,

    [NativeName("AL_FORMAT_UHJ3CHN_FLOAT32_SOFT")]
    FormatUhj3ChnFloat32SOFT = 6567,

    [NativeName("AL_FORMAT_UHJ4CHN8_SOFT")]
    FormatUhj4Chn8SOFT = 6568,

    [NativeName("AL_FORMAT_UHJ4CHN16_SOFT")]
    FormatUhj4Chn16SOFT = 6569,

    [NativeName("AL_FORMAT_UHJ4CHN_FLOAT32_SOFT")]
    FormatUhj4ChnFloat32SOFT = 6570,

    [NativeName("AL_FORMAT_UHJ2CHN_MULAW_SOFT")]
    FormatUhj2ChnMulawSOFT = 6579,

    [NativeName("AL_FORMAT_UHJ2CHN_ALAW_SOFT")]
    FormatUhj2ChnAlawSOFT = 6580,

    [NativeName("AL_FORMAT_UHJ2CHN_IMA4_SOFT")]
    FormatUhj2ChnIma4SOFT = 6581,

    [NativeName("AL_FORMAT_UHJ2CHN_MSADPCM_SOFT")]
    FormatUhj2ChnMsadpcmSOFT = 6582,

    [NativeName("AL_FORMAT_UHJ3CHN_MULAW_SOFT")]
    FormatUhj3ChnMulawSOFT = 6583,

    [NativeName("AL_FORMAT_UHJ3CHN_ALAW_SOFT")]
    FormatUhj3ChnAlawSOFT = 6584,

    [NativeName("AL_FORMAT_UHJ4CHN_MULAW_SOFT")]
    FormatUhj4ChnMulawSOFT = 6585,

    [NativeName("AL_FORMAT_UHJ4CHN_ALAW_SOFT")]
    FormatUhj4ChnAlawSOFT = 6586,
}
