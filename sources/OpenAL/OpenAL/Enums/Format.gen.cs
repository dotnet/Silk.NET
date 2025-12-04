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
    FormatMono8 = unchecked((uint)0x1100),

    [NativeName("AL_FORMAT_MONO16")]
    FormatMono16 = unchecked((uint)0x1101),

    [NativeName("AL_FORMAT_STEREO8")]
    FormatStereo8 = unchecked((uint)0x1102),

    [NativeName("AL_FORMAT_STEREO16")]
    FormatStereo16 = unchecked((uint)0x1103),

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("AL_FORMAT_IMA_ADPCM_MONO16_EXT")]
    FormatImaAdpcmMono16EXT = unchecked((uint)0x10000),

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("AL_FORMAT_IMA_ADPCM_STEREO16_EXT")]
    FormatImaAdpcmStereo16EXT = unchecked((uint)0x10001),

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("AL_FORMAT_WAVE_EXT")]
    FormatWaveEXT = unchecked((uint)0x10002),

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("AL_FORMAT_VORBIS_EXT")]
    FormatVorbisEXT = unchecked((uint)0x10003),

    [NameAffix("Suffix", "LOKI", 0, -1)]
    [NativeName("AL_FORMAT_QUAD8_LOKI")]
    FormatQuad8LOKI = unchecked((uint)0x10004),

    [NameAffix("Suffix", "LOKI", 0, -1)]
    [NativeName("AL_FORMAT_QUAD16_LOKI")]
    FormatQuad16LOKI = unchecked((uint)0x10005),

    [NativeName("AL_FORMAT_MONO_FLOAT32")]
    FormatMonoFloat32 = unchecked((uint)0x10010),

    [NativeName("AL_FORMAT_STEREO_FLOAT32")]
    FormatStereoFloat32 = unchecked((uint)0x10011),

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("AL_FORMAT_MONO_DOUBLE_EXT")]
    FormatMonoDoubleEXT = unchecked((uint)0x10012),

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("AL_FORMAT_STEREO_DOUBLE_EXT")]
    FormatStereoDoubleEXT = unchecked((uint)0x10013),

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("AL_FORMAT_MONO_MULAW_EXT")]
    FormatMonoMulawEXT = unchecked((uint)0x10014),

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("AL_FORMAT_STEREO_MULAW_EXT")]
    FormatStereoMulawEXT = unchecked((uint)0x10015),

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("AL_FORMAT_MONO_ALAW_EXT")]
    FormatMonoAlawEXT = unchecked((uint)0x10016),

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("AL_FORMAT_STEREO_ALAW_EXT")]
    FormatStereoAlawEXT = unchecked((uint)0x10017),

    [NativeName("AL_FORMAT_QUAD8")]
    FormatQuad8 = unchecked((uint)0x1204),

    [NativeName("AL_FORMAT_QUAD16")]
    FormatQuad16 = unchecked((uint)0x1205),

    [NativeName("AL_FORMAT_QUAD32")]
    FormatQuad32 = unchecked((uint)0x1206),

    [NativeName("AL_FORMAT_REAR8")]
    FormatRear8 = unchecked((uint)0x1207),

    [NativeName("AL_FORMAT_REAR16")]
    FormatRear16 = unchecked((uint)0x1208),

    [NativeName("AL_FORMAT_REAR32")]
    FormatRear32 = unchecked((uint)0x1209),

    [NativeName("AL_FORMAT_51CHN8")]
    Format51Chn8 = unchecked((uint)0x120A),

    [NativeName("AL_FORMAT_51CHN16")]
    Format51Chn16 = unchecked((uint)0x120B),

    [NativeName("AL_FORMAT_51CHN32")]
    Format51Chn32 = unchecked((uint)0x120C),

    [NativeName("AL_FORMAT_61CHN8")]
    Format61Chn8 = unchecked((uint)0x120D),

    [NativeName("AL_FORMAT_61CHN16")]
    Format61Chn16 = unchecked((uint)0x120E),

    [NativeName("AL_FORMAT_61CHN32")]
    Format61Chn32 = unchecked((uint)0x120F),

    [NativeName("AL_FORMAT_71CHN8")]
    Format71Chn8 = unchecked((uint)0x1210),

    [NativeName("AL_FORMAT_71CHN16")]
    Format71Chn16 = unchecked((uint)0x1211),

    [NativeName("AL_FORMAT_71CHN32")]
    Format71Chn32 = unchecked((uint)0x1212),

    [NativeName("AL_FORMAT_MONO_MULAW")]
    FormatMonoMulaw = unchecked((uint)0x10014),

    [NativeName("AL_FORMAT_STEREO_MULAW")]
    FormatStereoMulaw = unchecked((uint)0x10015),

    [NativeName("AL_FORMAT_QUAD_MULAW")]
    FormatQuadMulaw = unchecked((uint)0x10021),

    [NativeName("AL_FORMAT_REAR_MULAW")]
    FormatRearMulaw = unchecked((uint)0x10022),

    [NativeName("AL_FORMAT_51CHN_MULAW")]
    Format51ChnMulaw = unchecked((uint)0x10023),

    [NativeName("AL_FORMAT_61CHN_MULAW")]
    Format61ChnMulaw = unchecked((uint)0x10024),

    [NativeName("AL_FORMAT_71CHN_MULAW")]
    Format71ChnMulaw = unchecked((uint)0x10025),

    [NativeName("AL_FORMAT_MONO_IMA4")]
    FormatMonoIma4 = unchecked((uint)0x1300),

    [NativeName("AL_FORMAT_STEREO_IMA4")]
    FormatStereoIma4 = unchecked((uint)0x1301),

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("AL_FORMAT_MONO_MSADPCM_SOFT")]
    FormatMonoMsadpcmSOFT = unchecked((uint)0x1302),

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("AL_FORMAT_STEREO_MSADPCM_SOFT")]
    FormatStereoMsadpcmSOFT = unchecked((uint)0x1303),

    [NativeName("AL_FORMAT_BFORMAT2D_8")]
    FormatBformat2D8 = unchecked((uint)0x20021),

    [NativeName("AL_FORMAT_BFORMAT2D_16")]
    FormatBformat2D16 = unchecked((uint)0x20022),

    [NativeName("AL_FORMAT_BFORMAT2D_FLOAT32")]
    FormatBformat2DFloat32 = unchecked((uint)0x20023),

    [NativeName("AL_FORMAT_BFORMAT3D_8")]
    FormatBformat3D8 = unchecked((uint)0x20031),

    [NativeName("AL_FORMAT_BFORMAT3D_16")]
    FormatBformat3D16 = unchecked((uint)0x20032),

    [NativeName("AL_FORMAT_BFORMAT3D_FLOAT32")]
    FormatBformat3DFloat32 = unchecked((uint)0x20033),

    [NativeName("AL_FORMAT_BFORMAT2D_MULAW")]
    FormatBformat2DMulaw = unchecked((uint)0x10031),

    [NativeName("AL_FORMAT_BFORMAT3D_MULAW")]
    FormatBformat3DMulaw = unchecked((uint)0x10032),

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("AL_FORMAT_UHJ2CHN8_SOFT")]
    FormatUhj2Chn8SOFT = unchecked((uint)0x19A2),

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("AL_FORMAT_UHJ2CHN16_SOFT")]
    FormatUhj2Chn16SOFT = unchecked((uint)0x19A3),

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("AL_FORMAT_UHJ2CHN_FLOAT32_SOFT")]
    FormatUhj2ChnFloat32SOFT = unchecked((uint)0x19A4),

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("AL_FORMAT_UHJ3CHN8_SOFT")]
    FormatUhj3Chn8SOFT = unchecked((uint)0x19A5),

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("AL_FORMAT_UHJ3CHN16_SOFT")]
    FormatUhj3Chn16SOFT = unchecked((uint)0x19A6),

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("AL_FORMAT_UHJ3CHN_FLOAT32_SOFT")]
    FormatUhj3ChnFloat32SOFT = unchecked((uint)0x19A7),

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("AL_FORMAT_UHJ4CHN8_SOFT")]
    FormatUhj4Chn8SOFT = unchecked((uint)0x19A8),

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("AL_FORMAT_UHJ4CHN16_SOFT")]
    FormatUhj4Chn16SOFT = unchecked((uint)0x19A9),

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("AL_FORMAT_UHJ4CHN_FLOAT32_SOFT")]
    FormatUhj4ChnFloat32SOFT = unchecked((uint)0x19AA),

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("AL_FORMAT_UHJ2CHN_MULAW_SOFT")]
    FormatUhj2ChnMulawSOFT = unchecked((uint)0x19B3),

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("AL_FORMAT_UHJ2CHN_ALAW_SOFT")]
    FormatUhj2ChnAlawSOFT = unchecked((uint)0x19B4),

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("AL_FORMAT_UHJ2CHN_IMA4_SOFT")]
    FormatUhj2ChnIma4SOFT = unchecked((uint)0x19B5),

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("AL_FORMAT_UHJ2CHN_MSADPCM_SOFT")]
    FormatUhj2ChnMsadpcmSOFT = unchecked((uint)0x19B6),

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("AL_FORMAT_UHJ3CHN_MULAW_SOFT")]
    FormatUhj3ChnMulawSOFT = unchecked((uint)0x19B7),

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("AL_FORMAT_UHJ3CHN_ALAW_SOFT")]
    FormatUhj3ChnAlawSOFT = unchecked((uint)0x19B8),

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("AL_FORMAT_UHJ4CHN_MULAW_SOFT")]
    FormatUhj4ChnMulawSOFT = unchecked((uint)0x19B9),

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("AL_FORMAT_UHJ4CHN_ALAW_SOFT")]
    FormatUhj4ChnAlawSOFT = unchecked((uint)0x19BA),
}
