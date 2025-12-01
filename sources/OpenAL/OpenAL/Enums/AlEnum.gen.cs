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

[NativeName("ALEnum")]
public enum AlEnum : uint
{
    [NativeName("AL_NONE")]
    None = unchecked((uint)0),

    [NativeName("AL_FALSE")]
    False = unchecked((uint)0),

    [NativeName("AL_TRUE")]
    True = unchecked((uint)1),

    [NativeName("AL_SOURCE_RELATIVE")]
    SourceRelative = unchecked((uint)0x202),

    [NativeName("AL_CONE_INNER_ANGLE")]
    ConeInnerAngle = unchecked((uint)0x1001),

    [NativeName("AL_CONE_OUTER_ANGLE")]
    ConeOuterAngle = unchecked((uint)0x1002),

    [NativeName("AL_PITCH")]
    Pitch = unchecked((uint)0x1003),

    [NativeName("AL_POSITION")]
    Position = unchecked((uint)0x1004),

    [NativeName("AL_DIRECTION")]
    Direction = unchecked((uint)0x1005),

    [NativeName("AL_VELOCITY")]
    Velocity = unchecked((uint)0x1006),

    [NativeName("AL_LOOPING")]
    Looping = unchecked((uint)0x1007),

    [NativeName("AL_BUFFER")]
    Buffer = unchecked((uint)0x1009),

    [NativeName("AL_GAIN")]
    Gain = unchecked((uint)0x100A),

    [NativeName("AL_MIN_GAIN")]
    MinGain = unchecked((uint)0x100D),

    [NativeName("AL_MAX_GAIN")]
    MaxGain = unchecked((uint)0x100E),

    [NativeName("AL_ORIENTATION")]
    Orientation = unchecked((uint)0x100F),

    [NativeName("AL_SOURCE_STATE")]
    SourceState = unchecked((uint)0x1010),

    [NativeName("AL_INITIAL")]
    Initial = unchecked((uint)0x1011),

    [NativeName("AL_PLAYING")]
    Playing = unchecked((uint)0x1012),

    [NativeName("AL_PAUSED")]
    Paused = unchecked((uint)0x1013),

    [NativeName("AL_STOPPED")]
    Stopped = unchecked((uint)0x1014),

    [NativeName("AL_BUFFERS_QUEUED")]
    BuffersQueued = unchecked((uint)0x1015),

    [NativeName("AL_BUFFERS_PROCESSED")]
    BuffersProcessed = unchecked((uint)0x1016),

    [NativeName("AL_REFERENCE_DISTANCE")]
    ReferenceDistance = unchecked((uint)0x1020),

    [NativeName("AL_ROLLOFF_FACTOR")]
    RolloffFactor = unchecked((uint)0x1021),

    [NativeName("AL_CONE_OUTER_GAIN")]
    ConeOuterGain = unchecked((uint)0x1022),

    [NativeName("AL_MAX_DISTANCE")]
    MaxDistance = unchecked((uint)0x1023),

    [NativeName("AL_FORMAT_MONO8")]
    FormatMono8 = unchecked((uint)0x1100),

    [NativeName("AL_FORMAT_MONO16")]
    FormatMono16 = unchecked((uint)0x1101),

    [NativeName("AL_FORMAT_STEREO8")]
    FormatStereo8 = unchecked((uint)0x1102),

    [NativeName("AL_FORMAT_STEREO16")]
    FormatStereo16 = unchecked((uint)0x1103),

    [NativeName("AL_FREQUENCY")]
    Frequency = unchecked((uint)0x2001),

    [NativeName("AL_SIZE")]
    Size = unchecked((uint)0x2004),

    [NativeName("AL_UNUSED")]
    Unused = unchecked((uint)0x2010),

    [NativeName("AL_PENDING")]
    Pending = unchecked((uint)0x2011),

    [NativeName("AL_PROCESSED")]
    Processed = unchecked((uint)0x2012),

    [NativeName("AL_NO_ERROR")]
    NoError = unchecked((uint)0),

    [NativeName("AL_INVALID_NAME")]
    InvalidName = unchecked((uint)0xA001),

    [NativeName("AL_INVALID_ENUM")]
    InvalidEnum = unchecked((uint)0xA002),

    [NativeName("AL_INVALID_VALUE")]
    InvalidValue = unchecked((uint)0xA003),

    [NativeName("AL_INVALID_OPERATION")]
    InvalidOperation = unchecked((uint)0xA004),

    [NativeName("AL_OUT_OF_MEMORY")]
    OutOfMemory = unchecked((uint)0xA005),

    [NativeName("AL_VENDOR")]
    Vendor = unchecked((uint)0xB001),

    [NativeName("AL_VERSION")]
    Version = unchecked((uint)0xB002),

    [NativeName("AL_RENDERER")]
    Renderer = unchecked((uint)0xB003),

    [NativeName("AL_EXTENSIONS")]
    Extensions = unchecked((uint)0xB004),

    [NativeName("AL_DOPPLER_FACTOR")]
    DopplerFactor = unchecked((uint)0xC000),

    [NativeName("AL_DOPPLER_VELOCITY")]
    DopplerVelocity = unchecked((uint)0xC001),

    [NativeName("AL_DISTANCE_MODEL")]
    DistanceModel = unchecked((uint)0xD000),

    [NativeName("AL_INVALID")]
    Invalid = unchecked((uint)(-1)),

    [NativeName("AL_ILLEGAL_ENUM")]
    IllegalEnum = unchecked((uint)0xA002),

    [NativeName("AL_ILLEGAL_COMMAND")]
    IllegalCommand = unchecked((uint)0xA004),

    [NativeName("AL_INVERSE_DISTANCE")]
    InverseDistance = unchecked((uint)0xD001),

    [NativeName("AL_INVERSE_DISTANCE_CLAMPED")]
    InverseDistanceClamped = unchecked((uint)0xD002),

    [NativeName("AL_SEC_OFFSET")]
    SecOffset = unchecked((uint)0x1024),

    [NativeName("AL_SAMPLE_OFFSET")]
    SampleOffset = unchecked((uint)0x1025),

    [NativeName("AL_BYTE_OFFSET")]
    ByteOffset = unchecked((uint)0x1026),

    [NativeName("AL_SOURCE_TYPE")]
    SourceType = unchecked((uint)0x1027),

    [NativeName("AL_STATIC")]
    Static = unchecked((uint)0x1028),

    [NativeName("AL_STREAMING")]
    Streaming = unchecked((uint)0x1029),

    [NativeName("AL_UNDETERMINED")]
    Undetermined = unchecked((uint)0x1030),

    [NativeName("AL_BITS")]
    Bits = unchecked((uint)0x2002),

    [NativeName("AL_CHANNELS")]
    Channels = unchecked((uint)0x2003),

    [NativeName("AL_SPEED_OF_SOUND")]
    SpeedOfSound = unchecked((uint)0xC003),

    [NativeName("AL_LINEAR_DISTANCE")]
    LinearDistance = unchecked((uint)0xD003),

    [NativeName("AL_LINEAR_DISTANCE_CLAMPED")]
    LinearDistanceClamped = unchecked((uint)0xD004),

    [NativeName("AL_EXPONENT_DISTANCE")]
    ExponentDistance = unchecked((uint)0xD005),

    [NativeName("AL_EXPONENT_DISTANCE_CLAMPED")]
    ExponentDistanceClamped = unchecked((uint)0xD006),

    [NativeName("AL_FORMAT_IMA_ADPCM_MONO16_EXT")]
    FormatImaAdpcmMono16EXT = unchecked((uint)0x10000),

    [NativeName("AL_FORMAT_IMA_ADPCM_STEREO16_EXT")]
    FormatImaAdpcmStereo16EXT = unchecked((uint)0x10001),

    [NativeName("AL_FORMAT_WAVE_EXT")]
    FormatWaveEXT = unchecked((uint)0x10002),

    [NativeName("AL_FORMAT_VORBIS_EXT")]
    FormatVorbisEXT = unchecked((uint)0x10003),

    [NativeName("AL_FORMAT_QUAD8_LOKI")]
    FormatQuad8LOKI = unchecked((uint)0x10004),

    [NativeName("AL_FORMAT_QUAD16_LOKI")]
    FormatQuad16LOKI = unchecked((uint)0x10005),

    [NativeName("AL_FORMAT_MONO_FLOAT32")]
    FormatMonoFloat32 = unchecked((uint)0x10010),

    [NativeName("AL_FORMAT_STEREO_FLOAT32")]
    FormatStereoFloat32 = unchecked((uint)0x10011),

    [NativeName("AL_FORMAT_MONO_DOUBLE_EXT")]
    FormatMonoDoubleEXT = unchecked((uint)0x10012),

    [NativeName("AL_FORMAT_STEREO_DOUBLE_EXT")]
    FormatStereoDoubleEXT = unchecked((uint)0x10013),

    [NativeName("AL_FORMAT_MONO_MULAW_EXT")]
    FormatMonoMulawEXT = unchecked((uint)0x10014),

    [NativeName("AL_FORMAT_STEREO_MULAW_EXT")]
    FormatStereoMulawEXT = unchecked((uint)0x10015),

    [NativeName("AL_FORMAT_MONO_ALAW_EXT")]
    FormatMonoAlawEXT = unchecked((uint)0x10016),

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

    [NativeName("AL_METERS_PER_UNIT")]
    MetersPerUnit = unchecked((uint)0x20004),

    [NativeName("AL_DIRECT_FILTER")]
    DirectFilter = unchecked((uint)0x20005),

    [NativeName("AL_AUXILIARY_SEND_FILTER")]
    AuxiliarySendFilter = unchecked((uint)0x20006),

    [NativeName("AL_AIR_ABSORPTION_FACTOR")]
    AirAbsorptionFactor = unchecked((uint)0x20007),

    [NativeName("AL_ROOM_ROLLOFF_FACTOR")]
    RoomRolloffFactor = unchecked((uint)0x20008),

    [NativeName("AL_CONE_OUTER_GAINHF")]
    ConeOuterGainhf = unchecked((uint)0x20009),

    [NativeName("AL_DIRECT_FILTER_GAINHF_AUTO")]
    DirectFilterGainhfAuto = unchecked((uint)0x2000A),

    [NativeName("AL_AUXILIARY_SEND_FILTER_GAIN_AUTO")]
    AuxiliarySendFilterGainAuto = unchecked((uint)0x2000B),

    [NativeName("AL_AUXILIARY_SEND_FILTER_GAINHF_AUTO")]
    AuxiliarySendFilterGainhfAuto = unchecked((uint)0x2000C),

    [NativeName("AL_REVERB_DENSITY")]
    ReverbDensity = unchecked((uint)0x0001),

    [NativeName("AL_REVERB_DIFFUSION")]
    ReverbDiffusion = unchecked((uint)0x0002),

    [NativeName("AL_REVERB_GAIN")]
    ReverbGain = unchecked((uint)0x0003),

    [NativeName("AL_REVERB_GAINHF")]
    ReverbGainhf = unchecked((uint)0x0004),

    [NativeName("AL_REVERB_DECAY_TIME")]
    ReverbDecayTime = unchecked((uint)0x0005),

    [NativeName("AL_REVERB_DECAY_HFRATIO")]
    ReverbDecayHfratio = unchecked((uint)0x0006),

    [NativeName("AL_REVERB_REFLECTIONS_GAIN")]
    ReverbReflectionsGain = unchecked((uint)0x0007),

    [NativeName("AL_REVERB_REFLECTIONS_DELAY")]
    ReverbReflectionsDelay = unchecked((uint)0x0008),

    [NativeName("AL_REVERB_LATE_REVERB_GAIN")]
    ReverbLateReverbGain = unchecked((uint)0x0009),

    [NativeName("AL_REVERB_LATE_REVERB_DELAY")]
    ReverbLateReverbDelay = unchecked((uint)0x000A),

    [NativeName("AL_REVERB_AIR_ABSORPTION_GAINHF")]
    ReverbAirAbsorptionGainhf = unchecked((uint)0x000B),

    [NativeName("AL_REVERB_ROOM_ROLLOFF_FACTOR")]
    ReverbRoomRolloffFactor = unchecked((uint)0x000C),

    [NativeName("AL_REVERB_DECAY_HFLIMIT")]
    ReverbDecayHflimit = unchecked((uint)0x000D),

    [NativeName("AL_EAXREVERB_DENSITY")]
    EaxreverbDensity = unchecked((uint)0x0001),

    [NativeName("AL_EAXREVERB_DIFFUSION")]
    EaxreverbDiffusion = unchecked((uint)0x0002),

    [NativeName("AL_EAXREVERB_GAIN")]
    EaxreverbGain = unchecked((uint)0x0003),

    [NativeName("AL_EAXREVERB_GAINHF")]
    EaxreverbGainhf = unchecked((uint)0x0004),

    [NativeName("AL_EAXREVERB_GAINLF")]
    EaxreverbGainlf = unchecked((uint)0x0005),

    [NativeName("AL_EAXREVERB_DECAY_TIME")]
    EaxreverbDecayTime = unchecked((uint)0x0006),

    [NativeName("AL_EAXREVERB_DECAY_HFRATIO")]
    EaxreverbDecayHfratio = unchecked((uint)0x0007),

    [NativeName("AL_EAXREVERB_DECAY_LFRATIO")]
    EaxreverbDecayLfratio = unchecked((uint)0x0008),

    [NativeName("AL_EAXREVERB_REFLECTIONS_GAIN")]
    EaxreverbReflectionsGain = unchecked((uint)0x0009),

    [NativeName("AL_EAXREVERB_REFLECTIONS_DELAY")]
    EaxreverbReflectionsDelay = unchecked((uint)0x000A),

    [NativeName("AL_EAXREVERB_REFLECTIONS_PAN")]
    EaxreverbReflectionsPan = unchecked((uint)0x000B),

    [NativeName("AL_EAXREVERB_LATE_REVERB_GAIN")]
    EaxreverbLateReverbGain = unchecked((uint)0x000C),

    [NativeName("AL_EAXREVERB_LATE_REVERB_DELAY")]
    EaxreverbLateReverbDelay = unchecked((uint)0x000D),

    [NativeName("AL_EAXREVERB_LATE_REVERB_PAN")]
    EaxreverbLateReverbPan = unchecked((uint)0x000E),

    [NativeName("AL_EAXREVERB_ECHO_TIME")]
    EaxreverbEchoTime = unchecked((uint)0x000F),

    [NativeName("AL_EAXREVERB_ECHO_DEPTH")]
    EaxreverbEchoDepth = unchecked((uint)0x0010),

    [NativeName("AL_EAXREVERB_MODULATION_TIME")]
    EaxreverbModulationTime = unchecked((uint)0x0011),

    [NativeName("AL_EAXREVERB_MODULATION_DEPTH")]
    EaxreverbModulationDepth = unchecked((uint)0x0012),

    [NativeName("AL_EAXREVERB_AIR_ABSORPTION_GAINHF")]
    EaxreverbAirAbsorptionGainhf = unchecked((uint)0x0013),

    [NativeName("AL_EAXREVERB_HFREFERENCE")]
    EaxreverbHfreference = unchecked((uint)0x0014),

    [NativeName("AL_EAXREVERB_LFREFERENCE")]
    EaxreverbLfreference = unchecked((uint)0x0015),

    [NativeName("AL_EAXREVERB_ROOM_ROLLOFF_FACTOR")]
    EaxreverbRoomRolloffFactor = unchecked((uint)0x0016),

    [NativeName("AL_EAXREVERB_DECAY_HFLIMIT")]
    EaxreverbDecayHflimit = unchecked((uint)0x0017),

    [NativeName("AL_CHORUS_WAVEFORM")]
    ChorusWaveform = unchecked((uint)0x0001),

    [NativeName("AL_CHORUS_PHASE")]
    ChorusPhase = unchecked((uint)0x0002),

    [NativeName("AL_CHORUS_RATE")]
    ChorusRate = unchecked((uint)0x0003),

    [NativeName("AL_CHORUS_DEPTH")]
    ChorusDepth = unchecked((uint)0x0004),

    [NativeName("AL_CHORUS_FEEDBACK")]
    ChorusFeedback = unchecked((uint)0x0005),

    [NativeName("AL_CHORUS_DELAY")]
    ChorusDelay = unchecked((uint)0x0006),

    [NativeName("AL_DISTORTION_EDGE")]
    DistortionEdge = unchecked((uint)0x0001),

    [NativeName("AL_DISTORTION_GAIN")]
    DistortionGain = unchecked((uint)0x0002),

    [NativeName("AL_DISTORTION_LOWPASS_CUTOFF")]
    DistortionLowpassCutoff = unchecked((uint)0x0003),

    [NativeName("AL_DISTORTION_EQCENTER")]
    DistortionEqcenter = unchecked((uint)0x0004),

    [NativeName("AL_DISTORTION_EQBANDWIDTH")]
    DistortionEqbandwidth = unchecked((uint)0x0005),

    [NativeName("AL_ECHO_DELAY")]
    EchoDelay = unchecked((uint)0x0001),

    [NativeName("AL_ECHO_LRDELAY")]
    EchoLrdelay = unchecked((uint)0x0002),

    [NativeName("AL_ECHO_DAMPING")]
    EchoDamping = unchecked((uint)0x0003),

    [NativeName("AL_ECHO_FEEDBACK")]
    EchoFeedback = unchecked((uint)0x0004),

    [NativeName("AL_ECHO_SPREAD")]
    EchoSpread = unchecked((uint)0x0005),

    [NativeName("AL_FLANGER_WAVEFORM")]
    FlangerWaveform = unchecked((uint)0x0001),

    [NativeName("AL_FLANGER_PHASE")]
    FlangerPhase = unchecked((uint)0x0002),

    [NativeName("AL_FLANGER_RATE")]
    FlangerRate = unchecked((uint)0x0003),

    [NativeName("AL_FLANGER_DEPTH")]
    FlangerDepth = unchecked((uint)0x0004),

    [NativeName("AL_FLANGER_FEEDBACK")]
    FlangerFeedback = unchecked((uint)0x0005),

    [NativeName("AL_FLANGER_DELAY")]
    FlangerDelay = unchecked((uint)0x0006),

    [NativeName("AL_FREQUENCY_SHIFTER_FREQUENCY")]
    FrequencyShifterFrequency = unchecked((uint)0x0001),

    [NativeName("AL_FREQUENCY_SHIFTER_LEFT_DIRECTION")]
    FrequencyShifterLeftDirection = unchecked((uint)0x0002),

    [NativeName("AL_FREQUENCY_SHIFTER_RIGHT_DIRECTION")]
    FrequencyShifterRightDirection = unchecked((uint)0x0003),

    [NativeName("AL_VOCAL_MORPHER_PHONEMEA")]
    VocalMorpherPhonemea = unchecked((uint)0x0001),

    [NativeName("AL_VOCAL_MORPHER_PHONEMEA_COARSE_TUNING")]
    VocalMorpherPhonemeaCoarseTuning = unchecked((uint)0x0002),

    [NativeName("AL_VOCAL_MORPHER_PHONEMEB")]
    VocalMorpherPhonemeb = unchecked((uint)0x0003),

    [NativeName("AL_VOCAL_MORPHER_PHONEMEB_COARSE_TUNING")]
    VocalMorpherPhonemebCoarseTuning = unchecked((uint)0x0004),

    [NativeName("AL_VOCAL_MORPHER_WAVEFORM")]
    VocalMorpherWaveform = unchecked((uint)0x0005),

    [NativeName("AL_VOCAL_MORPHER_RATE")]
    VocalMorpherRate = unchecked((uint)0x0006),

    [NativeName("AL_PITCH_SHIFTER_COARSE_TUNE")]
    PitchShifterCoarseTune = unchecked((uint)0x0001),

    [NativeName("AL_PITCH_SHIFTER_FINE_TUNE")]
    PitchShifterFineTune = unchecked((uint)0x0002),

    [NativeName("AL_RING_MODULATOR_FREQUENCY")]
    RingModulatorFrequency = unchecked((uint)0x0001),

    [NativeName("AL_RING_MODULATOR_HIGHPASS_CUTOFF")]
    RingModulatorHighpassCutoff = unchecked((uint)0x0002),

    [NativeName("AL_RING_MODULATOR_WAVEFORM")]
    RingModulatorWaveform = unchecked((uint)0x0003),

    [NativeName("AL_AUTOWAH_ATTACK_TIME")]
    AutowahAttackTime = unchecked((uint)0x0001),

    [NativeName("AL_AUTOWAH_RELEASE_TIME")]
    AutowahReleaseTime = unchecked((uint)0x0002),

    [NativeName("AL_AUTOWAH_RESONANCE")]
    AutowahResonance = unchecked((uint)0x0003),

    [NativeName("AL_AUTOWAH_PEAK_GAIN")]
    AutowahPeakGain = unchecked((uint)0x0004),

    [NativeName("AL_COMPRESSOR_ONOFF")]
    CompressorOnoff = unchecked((uint)0x0001),

    [NativeName("AL_EQUALIZER_LOW_GAIN")]
    EqualizerLowGain = unchecked((uint)0x0001),

    [NativeName("AL_EQUALIZER_LOW_CUTOFF")]
    EqualizerLowCutoff = unchecked((uint)0x0002),

    [NativeName("AL_EQUALIZER_MID1_GAIN")]
    EqualizerMid1Gain = unchecked((uint)0x0003),

    [NativeName("AL_EQUALIZER_MID1_CENTER")]
    EqualizerMid1Center = unchecked((uint)0x0004),

    [NativeName("AL_EQUALIZER_MID1_WIDTH")]
    EqualizerMid1Width = unchecked((uint)0x0005),

    [NativeName("AL_EQUALIZER_MID2_GAIN")]
    EqualizerMid2Gain = unchecked((uint)0x0006),

    [NativeName("AL_EQUALIZER_MID2_CENTER")]
    EqualizerMid2Center = unchecked((uint)0x0007),

    [NativeName("AL_EQUALIZER_MID2_WIDTH")]
    EqualizerMid2Width = unchecked((uint)0x0008),

    [NativeName("AL_EQUALIZER_HIGH_GAIN")]
    EqualizerHighGain = unchecked((uint)0x0009),

    [NativeName("AL_EQUALIZER_HIGH_CUTOFF")]
    EqualizerHighCutoff = unchecked((uint)0x000A),

    [NativeName("AL_EFFECT_FIRST_PARAMETER")]
    EffectFirstParameter = unchecked((uint)0x0000),

    [NativeName("AL_EFFECT_LAST_PARAMETER")]
    EffectLastParameter = unchecked((uint)0x8000),

    [NativeName("AL_EFFECT_TYPE")]
    EffectType = unchecked((uint)0x8001),

    [NativeName("AL_EFFECT_NULL")]
    EffectNull = unchecked((uint)0x0000),

    [NativeName("AL_EFFECT_REVERB")]
    EffectReverb = unchecked((uint)0x0001),

    [NativeName("AL_EFFECT_CHORUS")]
    EffectChorus = unchecked((uint)0x0002),

    [NativeName("AL_EFFECT_DISTORTION")]
    EffectDistortion = unchecked((uint)0x0003),

    [NativeName("AL_EFFECT_ECHO")]
    EffectEcho = unchecked((uint)0x0004),

    [NativeName("AL_EFFECT_FLANGER")]
    EffectFlanger = unchecked((uint)0x0005),

    [NativeName("AL_EFFECT_FREQUENCY_SHIFTER")]
    EffectFrequencyShifter = unchecked((uint)0x0006),

    [NativeName("AL_EFFECT_VOCAL_MORPHER")]
    EffectVocalMorpher = unchecked((uint)0x0007),

    [NativeName("AL_EFFECT_PITCH_SHIFTER")]
    EffectPitchShifter = unchecked((uint)0x0008),

    [NativeName("AL_EFFECT_RING_MODULATOR")]
    EffectRingModulator = unchecked((uint)0x0009),

    [NativeName("AL_EFFECT_AUTOWAH")]
    EffectAutowah = unchecked((uint)0x000A),

    [NativeName("AL_EFFECT_COMPRESSOR")]
    EffectCompressor = unchecked((uint)0x000B),

    [NativeName("AL_EFFECT_EQUALIZER")]
    EffectEqualizer = unchecked((uint)0x000C),

    [NativeName("AL_EFFECT_EAXREVERB")]
    EffectEaxreverb = unchecked((uint)0x8000),

    [NativeName("AL_EFFECTSLOT_EFFECT")]
    EffectslotEffect = unchecked((uint)0x0001),

    [NativeName("AL_EFFECTSLOT_GAIN")]
    EffectslotGain = unchecked((uint)0x0002),

    [NativeName("AL_EFFECTSLOT_AUXILIARY_SEND_AUTO")]
    EffectslotAuxiliarySendAuto = unchecked((uint)0x0003),

    [NativeName("AL_EFFECTSLOT_NULL")]
    EffectslotNull = unchecked((uint)0x0000),

    [NativeName("AL_LOWPASS_GAIN")]
    LowpassGain = unchecked((uint)0x0001),

    [NativeName("AL_LOWPASS_GAINHF")]
    LowpassGainhf = unchecked((uint)0x0002),

    [NativeName("AL_HIGHPASS_GAIN")]
    HighpassGain = unchecked((uint)0x0001),

    [NativeName("AL_HIGHPASS_GAINLF")]
    HighpassGainlf = unchecked((uint)0x0002),

    [NativeName("AL_BANDPASS_GAIN")]
    BandpassGain = unchecked((uint)0x0001),

    [NativeName("AL_BANDPASS_GAINLF")]
    BandpassGainlf = unchecked((uint)0x0002),

    [NativeName("AL_BANDPASS_GAINHF")]
    BandpassGainhf = unchecked((uint)0x0003),

    [NativeName("AL_FILTER_FIRST_PARAMETER")]
    FilterFirstParameter = unchecked((uint)0x0000),

    [NativeName("AL_FILTER_LAST_PARAMETER")]
    FilterLastParameter = unchecked((uint)0x8000),

    [NativeName("AL_FILTER_TYPE")]
    FilterType = unchecked((uint)0x8001),

    [NativeName("AL_FILTER_NULL")]
    FilterNull = unchecked((uint)0x0000),

    [NativeName("AL_FILTER_LOWPASS")]
    FilterLowpass = unchecked((uint)0x0001),

    [NativeName("AL_FILTER_HIGHPASS")]
    FilterHighpass = unchecked((uint)0x0002),

    [NativeName("AL_FILTER_BANDPASS")]
    FilterBandpass = unchecked((uint)0x0003),

    [NativeName("AL_LOWPASS_MIN_GAIN")]
    LowpassMinGain = unchecked((uint)0.0f),

    [NativeName("AL_LOWPASS_MAX_GAIN")]
    LowpassMaxGain = unchecked((uint)1.0f),

    [NativeName("AL_LOWPASS_DEFAULT_GAIN")]
    LowpassDefaultGain = unchecked((uint)1.0f),

    [NativeName("AL_LOWPASS_MIN_GAINHF")]
    LowpassMinGainhf = unchecked((uint)0.0f),

    [NativeName("AL_LOWPASS_MAX_GAINHF")]
    LowpassMaxGainhf = unchecked((uint)1.0f),

    [NativeName("AL_LOWPASS_DEFAULT_GAINHF")]
    LowpassDefaultGainhf = unchecked((uint)1.0f),

    [NativeName("AL_HIGHPASS_MIN_GAIN")]
    HighpassMinGain = unchecked((uint)0.0f),

    [NativeName("AL_HIGHPASS_MAX_GAIN")]
    HighpassMaxGain = unchecked((uint)1.0f),

    [NativeName("AL_HIGHPASS_DEFAULT_GAIN")]
    HighpassDefaultGain = unchecked((uint)1.0f),

    [NativeName("AL_HIGHPASS_MIN_GAINLF")]
    HighpassMinGainlf = unchecked((uint)0.0f),

    [NativeName("AL_HIGHPASS_MAX_GAINLF")]
    HighpassMaxGainlf = unchecked((uint)1.0f),

    [NativeName("AL_HIGHPASS_DEFAULT_GAINLF")]
    HighpassDefaultGainlf = unchecked((uint)1.0f),

    [NativeName("AL_BANDPASS_MIN_GAIN")]
    BandpassMinGain = unchecked((uint)0.0f),

    [NativeName("AL_BANDPASS_MAX_GAIN")]
    BandpassMaxGain = unchecked((uint)1.0f),

    [NativeName("AL_BANDPASS_DEFAULT_GAIN")]
    BandpassDefaultGain = unchecked((uint)1.0f),

    [NativeName("AL_BANDPASS_MIN_GAINHF")]
    BandpassMinGainhf = unchecked((uint)0.0f),

    [NativeName("AL_BANDPASS_MAX_GAINHF")]
    BandpassMaxGainhf = unchecked((uint)1.0f),

    [NativeName("AL_BANDPASS_DEFAULT_GAINHF")]
    BandpassDefaultGainhf = unchecked((uint)1.0f),

    [NativeName("AL_BANDPASS_MIN_GAINLF")]
    BandpassMinGainlf = unchecked((uint)0.0f),

    [NativeName("AL_BANDPASS_MAX_GAINLF")]
    BandpassMaxGainlf = unchecked((uint)1.0f),

    [NativeName("AL_BANDPASS_DEFAULT_GAINLF")]
    BandpassDefaultGainlf = unchecked((uint)1.0f),

    [NativeName("AL_REVERB_MIN_DENSITY")]
    ReverbMinDensity = unchecked((uint)0.0f),

    [NativeName("AL_REVERB_MAX_DENSITY")]
    ReverbMaxDensity = unchecked((uint)1.0f),

    [NativeName("AL_REVERB_DEFAULT_DENSITY")]
    ReverbDefaultDensity = unchecked((uint)1.0f),

    [NativeName("AL_REVERB_MIN_DIFFUSION")]
    ReverbMinDiffusion = unchecked((uint)0.0f),

    [NativeName("AL_REVERB_MAX_DIFFUSION")]
    ReverbMaxDiffusion = unchecked((uint)1.0f),

    [NativeName("AL_REVERB_DEFAULT_DIFFUSION")]
    ReverbDefaultDiffusion = unchecked((uint)1.0f),

    [NativeName("AL_REVERB_MIN_GAIN")]
    ReverbMinGain = unchecked((uint)0.0f),

    [NativeName("AL_REVERB_MAX_GAIN")]
    ReverbMaxGain = unchecked((uint)1.0f),

    [NativeName("AL_REVERB_DEFAULT_GAIN")]
    ReverbDefaultGain = unchecked((uint)0.32f),

    [NativeName("AL_REVERB_MIN_GAINHF")]
    ReverbMinGainhf = unchecked((uint)0.0f),

    [NativeName("AL_REVERB_MAX_GAINHF")]
    ReverbMaxGainhf = unchecked((uint)1.0f),

    [NativeName("AL_REVERB_DEFAULT_GAINHF")]
    ReverbDefaultGainhf = unchecked((uint)0.89f),

    [NativeName("AL_REVERB_MIN_DECAY_TIME")]
    ReverbMinDecayTime = unchecked((uint)0.1f),

    [NativeName("AL_REVERB_MAX_DECAY_TIME")]
    ReverbMaxDecayTime = unchecked((uint)20.0f),

    [NativeName("AL_REVERB_DEFAULT_DECAY_TIME")]
    ReverbDefaultDecayTime = unchecked((uint)1.49f),

    [NativeName("AL_REVERB_MIN_DECAY_HFRATIO")]
    ReverbMinDecayHfratio = unchecked((uint)0.1f),

    [NativeName("AL_REVERB_MAX_DECAY_HFRATIO")]
    ReverbMaxDecayHfratio = unchecked((uint)2.0f),

    [NativeName("AL_REVERB_DEFAULT_DECAY_HFRATIO")]
    ReverbDefaultDecayHfratio = unchecked((uint)0.83f),

    [NativeName("AL_REVERB_MIN_REFLECTIONS_GAIN")]
    ReverbMinReflectionsGain = unchecked((uint)0.0f),

    [NativeName("AL_REVERB_MAX_REFLECTIONS_GAIN")]
    ReverbMaxReflectionsGain = unchecked((uint)3.16f),

    [NativeName("AL_REVERB_DEFAULT_REFLECTIONS_GAIN")]
    ReverbDefaultReflectionsGain = unchecked((uint)0.05f),

    [NativeName("AL_REVERB_MIN_REFLECTIONS_DELAY")]
    ReverbMinReflectionsDelay = unchecked((uint)0.0f),

    [NativeName("AL_REVERB_MAX_REFLECTIONS_DELAY")]
    ReverbMaxReflectionsDelay = unchecked((uint)0.3f),

    [NativeName("AL_REVERB_DEFAULT_REFLECTIONS_DELAY")]
    ReverbDefaultReflectionsDelay = unchecked((uint)0.007f),

    [NativeName("AL_REVERB_MIN_LATE_REVERB_GAIN")]
    ReverbMinLateReverbGain = unchecked((uint)0.0f),

    [NativeName("AL_REVERB_MAX_LATE_REVERB_GAIN")]
    ReverbMaxLateReverbGain = unchecked((uint)10.0f),

    [NativeName("AL_REVERB_DEFAULT_LATE_REVERB_GAIN")]
    ReverbDefaultLateReverbGain = unchecked((uint)1.26f),

    [NativeName("AL_REVERB_MIN_LATE_REVERB_DELAY")]
    ReverbMinLateReverbDelay = unchecked((uint)0.0f),

    [NativeName("AL_REVERB_MAX_LATE_REVERB_DELAY")]
    ReverbMaxLateReverbDelay = unchecked((uint)0.1f),

    [NativeName("AL_REVERB_DEFAULT_LATE_REVERB_DELAY")]
    ReverbDefaultLateReverbDelay = unchecked((uint)0.011f),

    [NativeName("AL_REVERB_MIN_AIR_ABSORPTION_GAINHF")]
    ReverbMinAirAbsorptionGainhf = unchecked((uint)0.892f),

    [NativeName("AL_REVERB_MAX_AIR_ABSORPTION_GAINHF")]
    ReverbMaxAirAbsorptionGainhf = unchecked((uint)1.0f),

    [NativeName("AL_REVERB_DEFAULT_AIR_ABSORPTION_GAINHF")]
    ReverbDefaultAirAbsorptionGainhf = unchecked((uint)0.994f),

    [NativeName("AL_REVERB_MIN_ROOM_ROLLOFF_FACTOR")]
    ReverbMinRoomRolloffFactor = unchecked((uint)0.0f),

    [NativeName("AL_REVERB_MAX_ROOM_ROLLOFF_FACTOR")]
    ReverbMaxRoomRolloffFactor = unchecked((uint)10.0f),

    [NativeName("AL_REVERB_DEFAULT_ROOM_ROLLOFF_FACTOR")]
    ReverbDefaultRoomRolloffFactor = unchecked((uint)0.0f),

    [NativeName("AL_REVERB_MIN_DECAY_HFLIMIT")]
    ReverbMinDecayHflimit = unchecked((uint)0),

    [NativeName("AL_REVERB_MAX_DECAY_HFLIMIT")]
    ReverbMaxDecayHflimit = unchecked((uint)1),

    [NativeName("AL_REVERB_DEFAULT_DECAY_HFLIMIT")]
    ReverbDefaultDecayHflimit = unchecked((uint)1),

    [NativeName("AL_EAXREVERB_MIN_DENSITY")]
    EaxreverbMinDensity = unchecked((uint)0.0f),

    [NativeName("AL_EAXREVERB_MAX_DENSITY")]
    EaxreverbMaxDensity = unchecked((uint)1.0f),

    [NativeName("AL_EAXREVERB_DEFAULT_DENSITY")]
    EaxreverbDefaultDensity = unchecked((uint)1.0f),

    [NativeName("AL_EAXREVERB_MIN_DIFFUSION")]
    EaxreverbMinDiffusion = unchecked((uint)0.0f),

    [NativeName("AL_EAXREVERB_MAX_DIFFUSION")]
    EaxreverbMaxDiffusion = unchecked((uint)1.0f),

    [NativeName("AL_EAXREVERB_DEFAULT_DIFFUSION")]
    EaxreverbDefaultDiffusion = unchecked((uint)1.0f),

    [NativeName("AL_EAXREVERB_MIN_GAIN")]
    EaxreverbMinGain = unchecked((uint)0.0f),

    [NativeName("AL_EAXREVERB_MAX_GAIN")]
    EaxreverbMaxGain = unchecked((uint)1.0f),

    [NativeName("AL_EAXREVERB_DEFAULT_GAIN")]
    EaxreverbDefaultGain = unchecked((uint)0.32f),

    [NativeName("AL_EAXREVERB_MIN_GAINHF")]
    EaxreverbMinGainhf = unchecked((uint)0.0f),

    [NativeName("AL_EAXREVERB_MAX_GAINHF")]
    EaxreverbMaxGainhf = unchecked((uint)1.0f),

    [NativeName("AL_EAXREVERB_DEFAULT_GAINHF")]
    EaxreverbDefaultGainhf = unchecked((uint)0.89f),

    [NativeName("AL_EAXREVERB_MIN_GAINLF")]
    EaxreverbMinGainlf = unchecked((uint)0.0f),

    [NativeName("AL_EAXREVERB_MAX_GAINLF")]
    EaxreverbMaxGainlf = unchecked((uint)1.0f),

    [NativeName("AL_EAXREVERB_DEFAULT_GAINLF")]
    EaxreverbDefaultGainlf = unchecked((uint)1.0f),

    [NativeName("AL_EAXREVERB_MIN_DECAY_TIME")]
    EaxreverbMinDecayTime = unchecked((uint)0.1f),

    [NativeName("AL_EAXREVERB_MAX_DECAY_TIME")]
    EaxreverbMaxDecayTime = unchecked((uint)20.0f),

    [NativeName("AL_EAXREVERB_DEFAULT_DECAY_TIME")]
    EaxreverbDefaultDecayTime = unchecked((uint)1.49f),

    [NativeName("AL_EAXREVERB_MIN_DECAY_HFRATIO")]
    EaxreverbMinDecayHfratio = unchecked((uint)0.1f),

    [NativeName("AL_EAXREVERB_MAX_DECAY_HFRATIO")]
    EaxreverbMaxDecayHfratio = unchecked((uint)2.0f),

    [NativeName("AL_EAXREVERB_DEFAULT_DECAY_HFRATIO")]
    EaxreverbDefaultDecayHfratio = unchecked((uint)0.83f),

    [NativeName("AL_EAXREVERB_MIN_DECAY_LFRATIO")]
    EaxreverbMinDecayLfratio = unchecked((uint)0.1f),

    [NativeName("AL_EAXREVERB_MAX_DECAY_LFRATIO")]
    EaxreverbMaxDecayLfratio = unchecked((uint)2.0f),

    [NativeName("AL_EAXREVERB_DEFAULT_DECAY_LFRATIO")]
    EaxreverbDefaultDecayLfratio = unchecked((uint)1.0f),

    [NativeName("AL_EAXREVERB_MIN_REFLECTIONS_GAIN")]
    EaxreverbMinReflectionsGain = unchecked((uint)0.0f),

    [NativeName("AL_EAXREVERB_MAX_REFLECTIONS_GAIN")]
    EaxreverbMaxReflectionsGain = unchecked((uint)3.16f),

    [NativeName("AL_EAXREVERB_DEFAULT_REFLECTIONS_GAIN")]
    EaxreverbDefaultReflectionsGain = unchecked((uint)0.05f),

    [NativeName("AL_EAXREVERB_MIN_REFLECTIONS_DELAY")]
    EaxreverbMinReflectionsDelay = unchecked((uint)0.0f),

    [NativeName("AL_EAXREVERB_MAX_REFLECTIONS_DELAY")]
    EaxreverbMaxReflectionsDelay = unchecked((uint)0.3f),

    [NativeName("AL_EAXREVERB_DEFAULT_REFLECTIONS_DELAY")]
    EaxreverbDefaultReflectionsDelay = unchecked((uint)0.007f),

    [NativeName("AL_EAXREVERB_DEFAULT_REFLECTIONS_PAN_XYZ")]
    EaxreverbDefaultReflectionsPanXyz = unchecked((uint)0.0f),

    [NativeName("AL_EAXREVERB_MIN_LATE_REVERB_GAIN")]
    EaxreverbMinLateReverbGain = unchecked((uint)0.0f),

    [NativeName("AL_EAXREVERB_MAX_LATE_REVERB_GAIN")]
    EaxreverbMaxLateReverbGain = unchecked((uint)10.0f),

    [NativeName("AL_EAXREVERB_DEFAULT_LATE_REVERB_GAIN")]
    EaxreverbDefaultLateReverbGain = unchecked((uint)1.26f),

    [NativeName("AL_EAXREVERB_MIN_LATE_REVERB_DELAY")]
    EaxreverbMinLateReverbDelay = unchecked((uint)0.0f),

    [NativeName("AL_EAXREVERB_MAX_LATE_REVERB_DELAY")]
    EaxreverbMaxLateReverbDelay = unchecked((uint)0.1f),

    [NativeName("AL_EAXREVERB_DEFAULT_LATE_REVERB_DELAY")]
    EaxreverbDefaultLateReverbDelay = unchecked((uint)0.011f),

    [NativeName("AL_EAXREVERB_DEFAULT_LATE_REVERB_PAN_XYZ")]
    EaxreverbDefaultLateReverbPanXyz = unchecked((uint)0.0f),

    [NativeName("AL_EAXREVERB_MIN_ECHO_TIME")]
    EaxreverbMinEchoTime = unchecked((uint)0.075f),

    [NativeName("AL_EAXREVERB_MAX_ECHO_TIME")]
    EaxreverbMaxEchoTime = unchecked((uint)0.25f),

    [NativeName("AL_EAXREVERB_DEFAULT_ECHO_TIME")]
    EaxreverbDefaultEchoTime = unchecked((uint)0.25f),

    [NativeName("AL_EAXREVERB_MIN_ECHO_DEPTH")]
    EaxreverbMinEchoDepth = unchecked((uint)0.0f),

    [NativeName("AL_EAXREVERB_MAX_ECHO_DEPTH")]
    EaxreverbMaxEchoDepth = unchecked((uint)1.0f),

    [NativeName("AL_EAXREVERB_DEFAULT_ECHO_DEPTH")]
    EaxreverbDefaultEchoDepth = unchecked((uint)0.0f),

    [NativeName("AL_EAXREVERB_MIN_MODULATION_TIME")]
    EaxreverbMinModulationTime = unchecked((uint)0.04f),

    [NativeName("AL_EAXREVERB_MAX_MODULATION_TIME")]
    EaxreverbMaxModulationTime = unchecked((uint)4.0f),

    [NativeName("AL_EAXREVERB_DEFAULT_MODULATION_TIME")]
    EaxreverbDefaultModulationTime = unchecked((uint)0.25f),

    [NativeName("AL_EAXREVERB_MIN_MODULATION_DEPTH")]
    EaxreverbMinModulationDepth = unchecked((uint)0.0f),

    [NativeName("AL_EAXREVERB_MAX_MODULATION_DEPTH")]
    EaxreverbMaxModulationDepth = unchecked((uint)1.0f),

    [NativeName("AL_EAXREVERB_DEFAULT_MODULATION_DEPTH")]
    EaxreverbDefaultModulationDepth = unchecked((uint)0.0f),

    [NativeName("AL_EAXREVERB_MIN_AIR_ABSORPTION_GAINHF")]
    EaxreverbMinAirAbsorptionGainhf = unchecked((uint)0.892f),

    [NativeName("AL_EAXREVERB_MAX_AIR_ABSORPTION_GAINHF")]
    EaxreverbMaxAirAbsorptionGainhf = unchecked((uint)1.0f),

    [NativeName("AL_EAXREVERB_DEFAULT_AIR_ABSORPTION_GAINHF")]
    EaxreverbDefaultAirAbsorptionGainhf = unchecked((uint)0.994f),

    [NativeName("AL_EAXREVERB_MIN_HFREFERENCE")]
    EaxreverbMinHfreference = unchecked((uint)1000.0f),

    [NativeName("AL_EAXREVERB_MAX_HFREFERENCE")]
    EaxreverbMaxHfreference = unchecked((uint)20000.0f),

    [NativeName("AL_EAXREVERB_DEFAULT_HFREFERENCE")]
    EaxreverbDefaultHfreference = unchecked((uint)5000.0f),

    [NativeName("AL_EAXREVERB_MIN_LFREFERENCE")]
    EaxreverbMinLfreference = unchecked((uint)20.0f),

    [NativeName("AL_EAXREVERB_MAX_LFREFERENCE")]
    EaxreverbMaxLfreference = unchecked((uint)1000.0f),

    [NativeName("AL_EAXREVERB_DEFAULT_LFREFERENCE")]
    EaxreverbDefaultLfreference = unchecked((uint)250.0f),

    [NativeName("AL_EAXREVERB_MIN_ROOM_ROLLOFF_FACTOR")]
    EaxreverbMinRoomRolloffFactor = unchecked((uint)0.0f),

    [NativeName("AL_EAXREVERB_MAX_ROOM_ROLLOFF_FACTOR")]
    EaxreverbMaxRoomRolloffFactor = unchecked((uint)10.0f),

    [NativeName("AL_EAXREVERB_DEFAULT_ROOM_ROLLOFF_FACTOR")]
    EaxreverbDefaultRoomRolloffFactor = unchecked((uint)0.0f),

    [NativeName("AL_EAXREVERB_MIN_DECAY_HFLIMIT")]
    EaxreverbMinDecayHflimit = unchecked((uint)0),

    [NativeName("AL_EAXREVERB_MAX_DECAY_HFLIMIT")]
    EaxreverbMaxDecayHflimit = unchecked((uint)1),

    [NativeName("AL_EAXREVERB_DEFAULT_DECAY_HFLIMIT")]
    EaxreverbDefaultDecayHflimit = unchecked((uint)1),

    [NativeName("AL_CHORUS_WAVEFORM_SINUSOID")]
    ChorusWaveformSinusoid = unchecked((uint)0),

    [NativeName("AL_CHORUS_WAVEFORM_TRIANGLE")]
    ChorusWaveformTriangle = unchecked((uint)1),

    [NativeName("AL_CHORUS_MIN_WAVEFORM")]
    ChorusMinWaveform = unchecked((uint)0),

    [NativeName("AL_CHORUS_MAX_WAVEFORM")]
    ChorusMaxWaveform = unchecked((uint)1),

    [NativeName("AL_CHORUS_DEFAULT_WAVEFORM")]
    ChorusDefaultWaveform = unchecked((uint)1),

    [NativeName("AL_CHORUS_MIN_PHASE")]
    ChorusMinPhase = unchecked((uint)-180),

    [NativeName("AL_CHORUS_MAX_PHASE")]
    ChorusMaxPhase = unchecked((uint)180),

    [NativeName("AL_CHORUS_DEFAULT_PHASE")]
    ChorusDefaultPhase = unchecked((uint)90),

    [NativeName("AL_CHORUS_MIN_RATE")]
    ChorusMinRate = unchecked((uint)0.0f),

    [NativeName("AL_CHORUS_MAX_RATE")]
    ChorusMaxRate = unchecked((uint)10.0f),

    [NativeName("AL_CHORUS_DEFAULT_RATE")]
    ChorusDefaultRate = unchecked((uint)1.1f),

    [NativeName("AL_CHORUS_MIN_DEPTH")]
    ChorusMinDepth = unchecked((uint)0.0f),

    [NativeName("AL_CHORUS_MAX_DEPTH")]
    ChorusMaxDepth = unchecked((uint)1.0f),

    [NativeName("AL_CHORUS_DEFAULT_DEPTH")]
    ChorusDefaultDepth = unchecked((uint)0.1f),

    [NativeName("AL_CHORUS_MIN_FEEDBACK")]
    ChorusMinFeedback = unchecked((uint)-1.0f),

    [NativeName("AL_CHORUS_MAX_FEEDBACK")]
    ChorusMaxFeedback = unchecked((uint)1.0f),

    [NativeName("AL_CHORUS_DEFAULT_FEEDBACK")]
    ChorusDefaultFeedback = unchecked((uint)0.25f),

    [NativeName("AL_CHORUS_MIN_DELAY")]
    ChorusMinDelay = unchecked((uint)0.0f),

    [NativeName("AL_CHORUS_MAX_DELAY")]
    ChorusMaxDelay = unchecked((uint)0.016f),

    [NativeName("AL_CHORUS_DEFAULT_DELAY")]
    ChorusDefaultDelay = unchecked((uint)0.016f),

    [NativeName("AL_DISTORTION_MIN_EDGE")]
    DistortionMinEdge = unchecked((uint)0.0f),

    [NativeName("AL_DISTORTION_MAX_EDGE")]
    DistortionMaxEdge = unchecked((uint)1.0f),

    [NativeName("AL_DISTORTION_DEFAULT_EDGE")]
    DistortionDefaultEdge = unchecked((uint)0.2f),

    [NativeName("AL_DISTORTION_MIN_GAIN")]
    DistortionMinGain = unchecked((uint)0.01f),

    [NativeName("AL_DISTORTION_MAX_GAIN")]
    DistortionMaxGain = unchecked((uint)1.0f),

    [NativeName("AL_DISTORTION_DEFAULT_GAIN")]
    DistortionDefaultGain = unchecked((uint)0.05f),

    [NativeName("AL_DISTORTION_MIN_LOWPASS_CUTOFF")]
    DistortionMinLowpassCutoff = unchecked((uint)80.0f),

    [NativeName("AL_DISTORTION_MAX_LOWPASS_CUTOFF")]
    DistortionMaxLowpassCutoff = unchecked((uint)24000.0f),

    [NativeName("AL_DISTORTION_DEFAULT_LOWPASS_CUTOFF")]
    DistortionDefaultLowpassCutoff = unchecked((uint)8000.0f),

    [NativeName("AL_DISTORTION_MIN_EQCENTER")]
    DistortionMinEqcenter = unchecked((uint)80.0f),

    [NativeName("AL_DISTORTION_MAX_EQCENTER")]
    DistortionMaxEqcenter = unchecked((uint)24000.0f),

    [NativeName("AL_DISTORTION_DEFAULT_EQCENTER")]
    DistortionDefaultEqcenter = unchecked((uint)3600.0f),

    [NativeName("AL_DISTORTION_MIN_EQBANDWIDTH")]
    DistortionMinEqbandwidth = unchecked((uint)80.0f),

    [NativeName("AL_DISTORTION_MAX_EQBANDWIDTH")]
    DistortionMaxEqbandwidth = unchecked((uint)24000.0f),

    [NativeName("AL_DISTORTION_DEFAULT_EQBANDWIDTH")]
    DistortionDefaultEqbandwidth = unchecked((uint)3600.0f),

    [NativeName("AL_ECHO_MIN_DELAY")]
    EchoMinDelay = unchecked((uint)0.0f),

    [NativeName("AL_ECHO_MAX_DELAY")]
    EchoMaxDelay = unchecked((uint)0.207f),

    [NativeName("AL_ECHO_DEFAULT_DELAY")]
    EchoDefaultDelay = unchecked((uint)0.1f),

    [NativeName("AL_ECHO_MIN_LRDELAY")]
    EchoMinLrdelay = unchecked((uint)0.0f),

    [NativeName("AL_ECHO_MAX_LRDELAY")]
    EchoMaxLrdelay = unchecked((uint)0.404f),

    [NativeName("AL_ECHO_DEFAULT_LRDELAY")]
    EchoDefaultLrdelay = unchecked((uint)0.1f),

    [NativeName("AL_ECHO_MIN_DAMPING")]
    EchoMinDamping = unchecked((uint)0.0f),

    [NativeName("AL_ECHO_MAX_DAMPING")]
    EchoMaxDamping = unchecked((uint)0.99f),

    [NativeName("AL_ECHO_DEFAULT_DAMPING")]
    EchoDefaultDamping = unchecked((uint)0.5f),

    [NativeName("AL_ECHO_MIN_FEEDBACK")]
    EchoMinFeedback = unchecked((uint)0.0f),

    [NativeName("AL_ECHO_MAX_FEEDBACK")]
    EchoMaxFeedback = unchecked((uint)1.0f),

    [NativeName("AL_ECHO_DEFAULT_FEEDBACK")]
    EchoDefaultFeedback = unchecked((uint)0.5f),

    [NativeName("AL_ECHO_MIN_SPREAD")]
    EchoMinSpread = unchecked((uint)-1.0f),

    [NativeName("AL_ECHO_MAX_SPREAD")]
    EchoMaxSpread = unchecked((uint)1.0f),

    [NativeName("AL_ECHO_DEFAULT_SPREAD")]
    EchoDefaultSpread = unchecked((uint)-1.0f),

    [NativeName("AL_FLANGER_WAVEFORM_SINUSOID")]
    FlangerWaveformSinusoid = unchecked((uint)0),

    [NativeName("AL_FLANGER_WAVEFORM_TRIANGLE")]
    FlangerWaveformTriangle = unchecked((uint)1),

    [NativeName("AL_FLANGER_MIN_WAVEFORM")]
    FlangerMinWaveform = unchecked((uint)0),

    [NativeName("AL_FLANGER_MAX_WAVEFORM")]
    FlangerMaxWaveform = unchecked((uint)1),

    [NativeName("AL_FLANGER_DEFAULT_WAVEFORM")]
    FlangerDefaultWaveform = unchecked((uint)1),

    [NativeName("AL_FLANGER_MIN_PHASE")]
    FlangerMinPhase = unchecked((uint)-180),

    [NativeName("AL_FLANGER_MAX_PHASE")]
    FlangerMaxPhase = unchecked((uint)180),

    [NativeName("AL_FLANGER_DEFAULT_PHASE")]
    FlangerDefaultPhase = unchecked((uint)0),

    [NativeName("AL_FLANGER_MIN_RATE")]
    FlangerMinRate = unchecked((uint)0.0f),

    [NativeName("AL_FLANGER_MAX_RATE")]
    FlangerMaxRate = unchecked((uint)10.0f),

    [NativeName("AL_FLANGER_DEFAULT_RATE")]
    FlangerDefaultRate = unchecked((uint)0.27f),

    [NativeName("AL_FLANGER_MIN_DEPTH")]
    FlangerMinDepth = unchecked((uint)0.0f),

    [NativeName("AL_FLANGER_MAX_DEPTH")]
    FlangerMaxDepth = unchecked((uint)1.0f),

    [NativeName("AL_FLANGER_DEFAULT_DEPTH")]
    FlangerDefaultDepth = unchecked((uint)1.0f),

    [NativeName("AL_FLANGER_MIN_FEEDBACK")]
    FlangerMinFeedback = unchecked((uint)-1.0f),

    [NativeName("AL_FLANGER_MAX_FEEDBACK")]
    FlangerMaxFeedback = unchecked((uint)1.0f),

    [NativeName("AL_FLANGER_DEFAULT_FEEDBACK")]
    FlangerDefaultFeedback = unchecked((uint)-0.5f),

    [NativeName("AL_FLANGER_MIN_DELAY")]
    FlangerMinDelay = unchecked((uint)0.0f),

    [NativeName("AL_FLANGER_MAX_DELAY")]
    FlangerMaxDelay = unchecked((uint)0.004f),

    [NativeName("AL_FLANGER_DEFAULT_DELAY")]
    FlangerDefaultDelay = unchecked((uint)0.002f),

    [NativeName("AL_FREQUENCY_SHIFTER_MIN_FREQUENCY")]
    FrequencyShifterMinFrequency = unchecked((uint)0.0f),

    [NativeName("AL_FREQUENCY_SHIFTER_MAX_FREQUENCY")]
    FrequencyShifterMaxFrequency = unchecked((uint)24000.0f),

    [NativeName("AL_FREQUENCY_SHIFTER_DEFAULT_FREQUENCY")]
    FrequencyShifterDefaultFrequency = unchecked((uint)0.0f),

    [NativeName("AL_FREQUENCY_SHIFTER_MIN_LEFT_DIRECTION")]
    FrequencyShifterMinLeftDirection = unchecked((uint)0),

    [NativeName("AL_FREQUENCY_SHIFTER_MAX_LEFT_DIRECTION")]
    FrequencyShifterMaxLeftDirection = unchecked((uint)2),

    [NativeName("AL_FREQUENCY_SHIFTER_DEFAULT_LEFT_DIRECTION")]
    FrequencyShifterDefaultLeftDirection = unchecked((uint)0),

    [NativeName("AL_FREQUENCY_SHIFTER_DIRECTION_DOWN")]
    FrequencyShifterDirectionDown = unchecked((uint)0),

    [NativeName("AL_FREQUENCY_SHIFTER_DIRECTION_UP")]
    FrequencyShifterDirectionUp = unchecked((uint)1),

    [NativeName("AL_FREQUENCY_SHIFTER_DIRECTION_OFF")]
    FrequencyShifterDirectionOff = unchecked((uint)2),

    [NativeName("AL_FREQUENCY_SHIFTER_MIN_RIGHT_DIRECTION")]
    FrequencyShifterMinRightDirection = unchecked((uint)0),

    [NativeName("AL_FREQUENCY_SHIFTER_MAX_RIGHT_DIRECTION")]
    FrequencyShifterMaxRightDirection = unchecked((uint)2),

    [NativeName("AL_FREQUENCY_SHIFTER_DEFAULT_RIGHT_DIRECTION")]
    FrequencyShifterDefaultRightDirection = unchecked((uint)0),

    [NativeName("AL_VOCAL_MORPHER_MIN_PHONEMEA")]
    VocalMorpherMinPhonemea = unchecked((uint)0),

    [NativeName("AL_VOCAL_MORPHER_MAX_PHONEMEA")]
    VocalMorpherMaxPhonemea = unchecked((uint)29),

    [NativeName("AL_VOCAL_MORPHER_DEFAULT_PHONEMEA")]
    VocalMorpherDefaultPhonemea = unchecked((uint)0),

    [NativeName("AL_VOCAL_MORPHER_MIN_PHONEMEA_COARSE_TUNING")]
    VocalMorpherMinPhonemeaCoarseTuning = unchecked((uint)-24),

    [NativeName("AL_VOCAL_MORPHER_MAX_PHONEMEA_COARSE_TUNING")]
    VocalMorpherMaxPhonemeaCoarseTuning = unchecked((uint)24),

    [NativeName("AL_VOCAL_MORPHER_DEFAULT_PHONEMEA_COARSE_TUNING")]
    VocalMorpherDefaultPhonemeaCoarseTuning = unchecked((uint)0),

    [NativeName("AL_VOCAL_MORPHER_MIN_PHONEMEB")]
    VocalMorpherMinPhonemeb = unchecked((uint)0),

    [NativeName("AL_VOCAL_MORPHER_MAX_PHONEMEB")]
    VocalMorpherMaxPhonemeb = unchecked((uint)29),

    [NativeName("AL_VOCAL_MORPHER_DEFAULT_PHONEMEB")]
    VocalMorpherDefaultPhonemeb = unchecked((uint)10),

    [NativeName("AL_VOCAL_MORPHER_MIN_PHONEMEB_COARSE_TUNING")]
    VocalMorpherMinPhonemebCoarseTuning = unchecked((uint)-24),

    [NativeName("AL_VOCAL_MORPHER_MAX_PHONEMEB_COARSE_TUNING")]
    VocalMorpherMaxPhonemebCoarseTuning = unchecked((uint)24),

    [NativeName("AL_VOCAL_MORPHER_DEFAULT_PHONEMEB_COARSE_TUNING")]
    VocalMorpherDefaultPhonemebCoarseTuning = unchecked((uint)0),

    [NativeName("AL_VOCAL_MORPHER_PHONEME_A")]
    VocalMorpherPhonemeA = unchecked((uint)0),

    [NativeName("AL_VOCAL_MORPHER_PHONEME_E")]
    VocalMorpherPhonemeE = unchecked((uint)1),

    [NativeName("AL_VOCAL_MORPHER_PHONEME_I")]
    VocalMorpherPhonemeI = unchecked((uint)2),

    [NativeName("AL_VOCAL_MORPHER_PHONEME_O")]
    VocalMorpherPhonemeO = unchecked((uint)3),

    [NativeName("AL_VOCAL_MORPHER_PHONEME_U")]
    VocalMorpherPhonemeU = unchecked((uint)4),

    [NativeName("AL_VOCAL_MORPHER_PHONEME_AA")]
    VocalMorpherPhonemeAa = unchecked((uint)5),

    [NativeName("AL_VOCAL_MORPHER_PHONEME_AE")]
    VocalMorpherPhonemeAe = unchecked((uint)6),

    [NativeName("AL_VOCAL_MORPHER_PHONEME_AH")]
    VocalMorpherPhonemeAh = unchecked((uint)7),

    [NativeName("AL_VOCAL_MORPHER_PHONEME_AO")]
    VocalMorpherPhonemeAo = unchecked((uint)8),

    [NativeName("AL_VOCAL_MORPHER_PHONEME_EH")]
    VocalMorpherPhonemeEh = unchecked((uint)9),

    [NativeName("AL_VOCAL_MORPHER_PHONEME_ER")]
    VocalMorpherPhonemeEr = unchecked((uint)10),

    [NativeName("AL_VOCAL_MORPHER_PHONEME_IH")]
    VocalMorpherPhonemeIh = unchecked((uint)11),

    [NativeName("AL_VOCAL_MORPHER_PHONEME_IY")]
    VocalMorpherPhonemeIy = unchecked((uint)12),

    [NativeName("AL_VOCAL_MORPHER_PHONEME_UH")]
    VocalMorpherPhonemeUh = unchecked((uint)13),

    [NativeName("AL_VOCAL_MORPHER_PHONEME_UW")]
    VocalMorpherPhonemeUw = unchecked((uint)14),

    [NativeName("AL_VOCAL_MORPHER_PHONEME_B")]
    VocalMorpherPhonemeB = unchecked((uint)15),

    [NativeName("AL_VOCAL_MORPHER_PHONEME_D")]
    VocalMorpherPhonemeD = unchecked((uint)16),

    [NativeName("AL_VOCAL_MORPHER_PHONEME_F")]
    VocalMorpherPhonemeF = unchecked((uint)17),

    [NativeName("AL_VOCAL_MORPHER_PHONEME_G")]
    VocalMorpherPhonemeG = unchecked((uint)18),

    [NativeName("AL_VOCAL_MORPHER_PHONEME_J")]
    VocalMorpherPhonemeJ = unchecked((uint)19),

    [NativeName("AL_VOCAL_MORPHER_PHONEME_K")]
    VocalMorpherPhonemeK = unchecked((uint)20),

    [NativeName("AL_VOCAL_MORPHER_PHONEME_L")]
    VocalMorpherPhonemeL = unchecked((uint)21),

    [NativeName("AL_VOCAL_MORPHER_PHONEME_M")]
    VocalMorpherPhonemeM = unchecked((uint)22),

    [NativeName("AL_VOCAL_MORPHER_PHONEME_N")]
    VocalMorpherPhonemeN = unchecked((uint)23),

    [NativeName("AL_VOCAL_MORPHER_PHONEME_P")]
    VocalMorpherPhonemeP = unchecked((uint)24),

    [NativeName("AL_VOCAL_MORPHER_PHONEME_R")]
    VocalMorpherPhonemeR = unchecked((uint)25),

    [NativeName("AL_VOCAL_MORPHER_PHONEME_S")]
    VocalMorpherPhonemeS = unchecked((uint)26),

    [NativeName("AL_VOCAL_MORPHER_PHONEME")]
    VocalMorpherPhoneme = unchecked((uint)27),

    [NativeName("AL_VOCAL_MORPHER_PHONEME_V")]
    VocalMorpherPhonemeV = unchecked((uint)28),

    [NativeName("AL_VOCAL_MORPHER_PHONEME_Z")]
    VocalMorpherPhonemeZ = unchecked((uint)29),

    [NativeName("AL_VOCAL_MORPHER_WAVEFORM_SINUSOID")]
    VocalMorpherWaveformSinusoid = unchecked((uint)0),

    [NativeName("AL_VOCAL_MORPHER_WAVEFORM_TRIANGLE")]
    VocalMorpherWaveformTriangle = unchecked((uint)1),

    [NativeName("AL_VOCAL_MORPHER_WAVEFORM_SAWTOOTH")]
    VocalMorpherWaveformSawtooth = unchecked((uint)2),

    [NativeName("AL_VOCAL_MORPHER_MIN_WAVEFORM")]
    VocalMorpherMinWaveform = unchecked((uint)0),

    [NativeName("AL_VOCAL_MORPHER_MAX_WAVEFORM")]
    VocalMorpherMaxWaveform = unchecked((uint)2),

    [NativeName("AL_VOCAL_MORPHER_DEFAULT_WAVEFORM")]
    VocalMorpherDefaultWaveform = unchecked((uint)0),

    [NativeName("AL_VOCAL_MORPHER_MIN_RATE")]
    VocalMorpherMinRate = unchecked((uint)0.0f),

    [NativeName("AL_VOCAL_MORPHER_MAX_RATE")]
    VocalMorpherMaxRate = unchecked((uint)10.0f),

    [NativeName("AL_VOCAL_MORPHER_DEFAULT_RATE")]
    VocalMorpherDefaultRate = unchecked((uint)1.41f),

    [NativeName("AL_PITCH_SHIFTER_MIN_COARSE_TUNE")]
    PitchShifterMinCoarseTune = unchecked((uint)-12),

    [NativeName("AL_PITCH_SHIFTER_MAX_COARSE_TUNE")]
    PitchShifterMaxCoarseTune = unchecked((uint)12),

    [NativeName("AL_PITCH_SHIFTER_DEFAULT_COARSE_TUNE")]
    PitchShifterDefaultCoarseTune = unchecked((uint)12),

    [NativeName("AL_PITCH_SHIFTER_MIN_FINE_TUNE")]
    PitchShifterMinFineTune = unchecked((uint)-50),

    [NativeName("AL_PITCH_SHIFTER_MAX_FINE_TUNE")]
    PitchShifterMaxFineTune = unchecked((uint)50),

    [NativeName("AL_PITCH_SHIFTER_DEFAULT_FINE_TUNE")]
    PitchShifterDefaultFineTune = unchecked((uint)0),

    [NativeName("AL_RING_MODULATOR_MIN_FREQUENCY")]
    RingModulatorMinFrequency = unchecked((uint)0.0f),

    [NativeName("AL_RING_MODULATOR_MAX_FREQUENCY")]
    RingModulatorMaxFrequency = unchecked((uint)8000.0f),

    [NativeName("AL_RING_MODULATOR_DEFAULT_FREQUENCY")]
    RingModulatorDefaultFrequency = unchecked((uint)440.0f),

    [NativeName("AL_RING_MODULATOR_MIN_HIGHPASS_CUTOFF")]
    RingModulatorMinHighpassCutoff = unchecked((uint)0.0f),

    [NativeName("AL_RING_MODULATOR_MAX_HIGHPASS_CUTOFF")]
    RingModulatorMaxHighpassCutoff = unchecked((uint)24000.0f),

    [NativeName("AL_RING_MODULATOR_DEFAULT_HIGHPASS_CUTOFF")]
    RingModulatorDefaultHighpassCutoff = unchecked((uint)800.0f),

    [NativeName("AL_RING_MODULATOR_SINUSOID")]
    RingModulatorSinusoid = unchecked((uint)0),

    [NativeName("AL_RING_MODULATOR_SAWTOOTH")]
    RingModulatorSawtooth = unchecked((uint)1),

    [NativeName("AL_RING_MODULATOR_SQUARE")]
    RingModulatorSquare = unchecked((uint)2),

    [NativeName("AL_RING_MODULATOR_MIN_WAVEFORM")]
    RingModulatorMinWaveform = unchecked((uint)0),

    [NativeName("AL_RING_MODULATOR_MAX_WAVEFORM")]
    RingModulatorMaxWaveform = unchecked((uint)2),

    [NativeName("AL_RING_MODULATOR_DEFAULT_WAVEFORM")]
    RingModulatorDefaultWaveform = unchecked((uint)0),

    [NativeName("AL_AUTOWAH_MIN_ATTACK_TIME")]
    AutowahMinAttackTime = unchecked((uint)0.0001f),

    [NativeName("AL_AUTOWAH_MAX_ATTACK_TIME")]
    AutowahMaxAttackTime = unchecked((uint)1.0f),

    [NativeName("AL_AUTOWAH_DEFAULT_ATTACK_TIME")]
    AutowahDefaultAttackTime = unchecked((uint)0.06f),

    [NativeName("AL_AUTOWAH_MIN_RELEASE_TIME")]
    AutowahMinReleaseTime = unchecked((uint)0.0001f),

    [NativeName("AL_AUTOWAH_MAX_RELEASE_TIME")]
    AutowahMaxReleaseTime = unchecked((uint)1.0f),

    [NativeName("AL_AUTOWAH_DEFAULT_RELEASE_TIME")]
    AutowahDefaultReleaseTime = unchecked((uint)0.06f),

    [NativeName("AL_AUTOWAH_MIN_RESONANCE")]
    AutowahMinResonance = unchecked((uint)2.0f),

    [NativeName("AL_AUTOWAH_MAX_RESONANCE")]
    AutowahMaxResonance = unchecked((uint)1000.0f),

    [NativeName("AL_AUTOWAH_DEFAULT_RESONANCE")]
    AutowahDefaultResonance = unchecked((uint)1000.0f),

    [NativeName("AL_AUTOWAH_MIN_PEAK_GAIN")]
    AutowahMinPeakGain = unchecked((uint)0.00003f),

    [NativeName("AL_AUTOWAH_MAX_PEAK_GAIN")]
    AutowahMaxPeakGain = unchecked((uint)31621.0f),

    [NativeName("AL_AUTOWAH_DEFAULT_PEAK_GAIN")]
    AutowahDefaultPeakGain = unchecked((uint)11.22f),

    [NativeName("AL_COMPRESSOR_MIN_ONOFF")]
    CompressorMinOnoff = unchecked((uint)0),

    [NativeName("AL_COMPRESSOR_MAX_ONOFF")]
    CompressorMaxOnoff = unchecked((uint)1),

    [NativeName("AL_COMPRESSOR_DEFAULT_ONOFF")]
    CompressorDefaultOnoff = unchecked((uint)1),

    [NativeName("AL_EQUALIZER_MIN_LOW_GAIN")]
    EqualizerMinLowGain = unchecked((uint)0.126f),

    [NativeName("AL_EQUALIZER_MAX_LOW_GAIN")]
    EqualizerMaxLowGain = unchecked((uint)7.943f),

    [NativeName("AL_EQUALIZER_DEFAULT_LOW_GAIN")]
    EqualizerDefaultLowGain = unchecked((uint)1.0f),

    [NativeName("AL_EQUALIZER_MIN_LOW_CUTOFF")]
    EqualizerMinLowCutoff = unchecked((uint)50.0f),

    [NativeName("AL_EQUALIZER_MAX_LOW_CUTOFF")]
    EqualizerMaxLowCutoff = unchecked((uint)800.0f),

    [NativeName("AL_EQUALIZER_DEFAULT_LOW_CUTOFF")]
    EqualizerDefaultLowCutoff = unchecked((uint)200.0f),

    [NativeName("AL_EQUALIZER_MIN_MID1_GAIN")]
    EqualizerMinMid1Gain = unchecked((uint)0.126f),

    [NativeName("AL_EQUALIZER_MAX_MID1_GAIN")]
    EqualizerMaxMid1Gain = unchecked((uint)7.943f),

    [NativeName("AL_EQUALIZER_DEFAULT_MID1_GAIN")]
    EqualizerDefaultMid1Gain = unchecked((uint)1.0f),

    [NativeName("AL_EQUALIZER_MIN_MID1_CENTER")]
    EqualizerMinMid1Center = unchecked((uint)200.0f),

    [NativeName("AL_EQUALIZER_MAX_MID1_CENTER")]
    EqualizerMaxMid1Center = unchecked((uint)3000.0f),

    [NativeName("AL_EQUALIZER_DEFAULT_MID1_CENTER")]
    EqualizerDefaultMid1Center = unchecked((uint)500.0f),

    [NativeName("AL_EQUALIZER_MIN_MID1_WIDTH")]
    EqualizerMinMid1Width = unchecked((uint)0.01f),

    [NativeName("AL_EQUALIZER_MAX_MID1_WIDTH")]
    EqualizerMaxMid1Width = unchecked((uint)1.0f),

    [NativeName("AL_EQUALIZER_DEFAULT_MID1_WIDTH")]
    EqualizerDefaultMid1Width = unchecked((uint)1.0f),

    [NativeName("AL_EQUALIZER_MIN_MID2_GAIN")]
    EqualizerMinMid2Gain = unchecked((uint)0.126f),

    [NativeName("AL_EQUALIZER_MAX_MID2_GAIN")]
    EqualizerMaxMid2Gain = unchecked((uint)7.943f),

    [NativeName("AL_EQUALIZER_DEFAULT_MID2_GAIN")]
    EqualizerDefaultMid2Gain = unchecked((uint)1.0f),

    [NativeName("AL_EQUALIZER_MIN_MID2_CENTER")]
    EqualizerMinMid2Center = unchecked((uint)1000.0f),

    [NativeName("AL_EQUALIZER_MAX_MID2_CENTER")]
    EqualizerMaxMid2Center = unchecked((uint)8000.0f),

    [NativeName("AL_EQUALIZER_DEFAULT_MID2_CENTER")]
    EqualizerDefaultMid2Center = unchecked((uint)3000.0f),

    [NativeName("AL_EQUALIZER_MIN_MID2_WIDTH")]
    EqualizerMinMid2Width = unchecked((uint)0.01f),

    [NativeName("AL_EQUALIZER_MAX_MID2_WIDTH")]
    EqualizerMaxMid2Width = unchecked((uint)1.0f),

    [NativeName("AL_EQUALIZER_DEFAULT_MID2_WIDTH")]
    EqualizerDefaultMid2Width = unchecked((uint)1.0f),

    [NativeName("AL_EQUALIZER_MIN_HIGH_GAIN")]
    EqualizerMinHighGain = unchecked((uint)0.126f),

    [NativeName("AL_EQUALIZER_MAX_HIGH_GAIN")]
    EqualizerMaxHighGain = unchecked((uint)7.943f),

    [NativeName("AL_EQUALIZER_DEFAULT_HIGH_GAIN")]
    EqualizerDefaultHighGain = unchecked((uint)1.0f),

    [NativeName("AL_EQUALIZER_MIN_HIGH_CUTOFF")]
    EqualizerMinHighCutoff = unchecked((uint)4000.0f),

    [NativeName("AL_EQUALIZER_MAX_HIGH_CUTOFF")]
    EqualizerMaxHighCutoff = unchecked((uint)16000.0f),

    [NativeName("AL_EQUALIZER_DEFAULT_HIGH_CUTOFF")]
    EqualizerDefaultHighCutoff = unchecked((uint)6000.0f),

    [NativeName("AL_MIN_AIR_ABSORPTION_FACTOR")]
    MinAirAbsorptionFactor = unchecked((uint)0.0f),

    [NativeName("AL_MAX_AIR_ABSORPTION_FACTOR")]
    MaxAirAbsorptionFactor = unchecked((uint)10.0f),

    [NativeName("AL_DEFAULT_AIR_ABSORPTION_FACTOR")]
    DefaultAirAbsorptionFactor = unchecked((uint)0.0f),

    [NativeName("AL_MIN_ROOM_ROLLOFF_FACTOR")]
    MinRoomRolloffFactor = unchecked((uint)0.0f),

    [NativeName("AL_MAX_ROOM_ROLLOFF_FACTOR")]
    MaxRoomRolloffFactor = unchecked((uint)10.0f),

    [NativeName("AL_DEFAULT_ROOM_ROLLOFF_FACTOR")]
    DefaultRoomRolloffFactor = unchecked((uint)0.0f),

    [NativeName("AL_MIN_CONE_OUTER_GAINHF")]
    MinConeOuterGainhf = unchecked((uint)0.0f),

    [NativeName("AL_MAX_CONE_OUTER_GAINHF")]
    MaxConeOuterGainhf = unchecked((uint)1.0f),

    [NativeName("AL_DEFAULT_CONE_OUTER_GAINHF")]
    DefaultConeOuterGainhf = unchecked((uint)1.0f),

    [NativeName("AL_MIN_DIRECT_FILTER_GAINHF_AUTO")]
    MinDirectFilterGainhfAuto = unchecked((uint)0),

    [NativeName("AL_MAX_DIRECT_FILTER_GAINHF_AUTO")]
    MaxDirectFilterGainhfAuto = unchecked((uint)1),

    [NativeName("AL_DEFAULT_DIRECT_FILTER_GAINHF_AUTO")]
    DefaultDirectFilterGainhfAuto = unchecked((uint)1),

    [NativeName("AL_MIN_AUXILIARY_SEND_FILTER_GAIN_AUTO")]
    MinAuxiliarySendFilterGainAuto = unchecked((uint)0),

    [NativeName("AL_MAX_AUXILIARY_SEND_FILTER_GAIN_AUTO")]
    MaxAuxiliarySendFilterGainAuto = unchecked((uint)1),

    [NativeName("AL_DEFAULT_AUXILIARY_SEND_FILTER_GAIN_AUTO")]
    DefaultAuxiliarySendFilterGainAuto = unchecked((uint)1),

    [NativeName("AL_MIN_AUXILIARY_SEND_FILTER_GAINHF_AUTO")]
    MinAuxiliarySendFilterGainhfAuto = unchecked((uint)0),

    [NativeName("AL_MAX_AUXILIARY_SEND_FILTER_GAINHF_AUTO")]
    MaxAuxiliarySendFilterGainhfAuto = unchecked((uint)1),

    [NativeName("AL_DEFAULT_AUXILIARY_SEND_FILTER_GAINHF_AUTO")]
    DefaultAuxiliarySendFilterGainhfAuto = unchecked((uint)1),

    [NativeName("AL_MIN_METERS_PER_UNIT")]
    MinMetersPerUnit = unchecked((uint)1.17549435e-38F),

    [NativeName("AL_MAX_METERS_PER_UNIT")]
    MaxMetersPerUnit = unchecked((uint)3.40282347e+38F),

    [NativeName("AL_DEFAULT_METERS_PER_UNIT")]
    DefaultMetersPerUnit = unchecked((uint)1.0f),

    [NativeName("AL_SOURCE_DISTANCE_MODEL")]
    SourceDistanceModel = unchecked((uint)0x200),

    [NativeName("AL_BYTE_RW_OFFSETS_SOFT")]
    ByteRwOffsetsSOFT = unchecked((uint)0x1031),

    [NativeName("AL_SAMPLE_RW_OFFSETS_SOFT")]
    SampleRwOffsetsSOFT = unchecked((uint)0x1032),

    [NativeName("AL_LOOP_POINTS_SOFT")]
    LoopPointsSOFT = unchecked((uint)0x2015),

    [NativeName("AL_FOLDBACK_EVENT_BLOCK")]
    FoldbackEventBlock = unchecked((uint)0x4112),

    [NativeName("AL_FOLDBACK_EVENT_START")]
    FoldbackEventStart = unchecked((uint)0x4111),

    [NativeName("AL_FOLDBACK_EVENT_STOP")]
    FoldbackEventStop = unchecked((uint)0x4113),

    [NativeName("AL_FOLDBACK_MODE_MONO")]
    FoldbackModeMono = unchecked((uint)0x4101),

    [NativeName("AL_FOLDBACK_MODE_STEREO")]
    FoldbackModeStereo = unchecked((uint)0x4102),

    [NativeName("AL_DEDICATED_GAIN")]
    DedicatedGain = unchecked((uint)0x0001),

    [NativeName("AL_EFFECT_DEDICATED_DIALOGUE")]
    EffectDedicatedDialogue = unchecked((uint)0x9001),

    [NativeName("AL_EFFECT_DEDICATED_LOW_FREQUENCY_EFFECT")]
    EffectDedicatedLowFrequencyEffect = unchecked((uint)0x9000),

    [NativeName("AL_MONO_SOFT")]
    MonoSOFT = unchecked((uint)0x1500),

    [NativeName("AL_STEREO_SOFT")]
    StereoSOFT = unchecked((uint)0x1501),

    [NativeName("AL_REAR_SOFT")]
    RearSOFT = unchecked((uint)0x1502),

    [NativeName("AL_QUAD_SOFT")]
    QuadSOFT = unchecked((uint)0x1503),

    [NativeName("AL_5POINT1_SOFT")]
    X5Point1SOFT = unchecked((uint)0x1504),

    [NativeName("AL_6POINT1_SOFT")]
    X6Point1SOFT = unchecked((uint)0x1505),

    [NativeName("AL_7POINT1_SOFT")]
    X7Point1SOFT = unchecked((uint)0x1506),

    [NativeName("AL_BYTE_SOFT")]
    ByteSOFT = unchecked((uint)0x1400),

    [NativeName("AL_UNSIGNED_BYTE_SOFT")]
    UnsignedByteSOFT = unchecked((uint)0x1401),

    [NativeName("AL_SHORT_SOFT")]
    ShortSOFT = unchecked((uint)0x1402),

    [NativeName("AL_UNSIGNED_SHORT_SOFT")]
    UnsignedShortSOFT = unchecked((uint)0x1403),

    [NativeName("AL_INT_SOFT")]
    IntSOFT = unchecked((uint)0x1404),

    [NativeName("AL_UNSIGNED_INT_SOFT")]
    UnsignedIntSOFT = unchecked((uint)0x1405),

    [NativeName("AL_FLOAT_SOFT")]
    FloatSOFT = unchecked((uint)0x1406),

    [NativeName("AL_DOUBLE_SOFT")]
    DoubleSOFT = unchecked((uint)0x1407),

    [NativeName("AL_BYTE3_SOFT")]
    Byte3SOFT = unchecked((uint)0x1408),

    [NativeName("AL_UNSIGNED_BYTE3_SOFT")]
    UnsignedByte3SOFT = unchecked((uint)0x1409),

    [NativeName("AL_MONO8_SOFT")]
    Mono8SOFT = unchecked((uint)0x1100),

    [NativeName("AL_MONO16_SOFT")]
    Mono16SOFT = unchecked((uint)0x1101),

    [NativeName("AL_MONO32F_SOFT")]
    Mono32FSOFT = unchecked((uint)0x10010),

    [NativeName("AL_STEREO8_SOFT")]
    Stereo8SOFT = unchecked((uint)0x1102),

    [NativeName("AL_STEREO16_SOFT")]
    Stereo16SOFT = unchecked((uint)0x1103),

    [NativeName("AL_STEREO32F_SOFT")]
    Stereo32FSOFT = unchecked((uint)0x10011),

    [NativeName("AL_QUAD8_SOFT")]
    Quad8SOFT = unchecked((uint)0x1204),

    [NativeName("AL_QUAD16_SOFT")]
    Quad16SOFT = unchecked((uint)0x1205),

    [NativeName("AL_QUAD32F_SOFT")]
    Quad32FSOFT = unchecked((uint)0x1206),

    [NativeName("AL_REAR8_SOFT")]
    Rear8SOFT = unchecked((uint)0x1207),

    [NativeName("AL_REAR16_SOFT")]
    Rear16SOFT = unchecked((uint)0x1208),

    [NativeName("AL_REAR32F_SOFT")]
    Rear32FSOFT = unchecked((uint)0x1209),

    [NativeName("AL_5POINT1_8_SOFT")]
    X5Point1X8SOFT = unchecked((uint)0x120A),

    [NativeName("AL_5POINT1_16_SOFT")]
    X5Point1X16SOFT = unchecked((uint)0x120B),

    [NativeName("AL_5POINT1_32F_SOFT")]
    X5Point1X32FSOFT = unchecked((uint)0x120C),

    [NativeName("AL_6POINT1_8_SOFT")]
    X6Point1X8SOFT = unchecked((uint)0x120D),

    [NativeName("AL_6POINT1_16_SOFT")]
    X6Point1X16SOFT = unchecked((uint)0x120E),

    [NativeName("AL_6POINT1_32F_SOFT")]
    X6Point1X32FSOFT = unchecked((uint)0x120F),

    [NativeName("AL_7POINT1_8_SOFT")]
    X7Point1X8SOFT = unchecked((uint)0x1210),

    [NativeName("AL_7POINT1_16_SOFT")]
    X7Point1X16SOFT = unchecked((uint)0x1211),

    [NativeName("AL_7POINT1_32F_SOFT")]
    X7Point1X32FSOFT = unchecked((uint)0x1212),

    [NativeName("AL_INTERNAL_FORMAT_SOFT")]
    InternalFormatSOFT = unchecked((uint)0x2008),

    [NativeName("AL_BYTE_LENGTH_SOFT")]
    ByteLengthSOFT = unchecked((uint)0x2009),

    [NativeName("AL_SAMPLE_LENGTH_SOFT")]
    SampleLengthSOFT = unchecked((uint)0x200A),

    [NativeName("AL_SEC_LENGTH_SOFT")]
    SecLengthSOFT = unchecked((uint)0x200B),

    [NativeName("AL_DIRECT_CHANNELS_SOFT")]
    DirectChannelsSOFT = unchecked((uint)0x1033),

    [NativeName("AL_STEREO_ANGLES")]
    StereoAngles = unchecked((uint)0x1030),

    [NativeName("AL_SOURCE_RADIUS")]
    SourceRadius = unchecked((uint)0x1031),

    [NativeName("AL_SAMPLE_OFFSET_LATENCY_SOFT")]
    SampleOffsetLatencySOFT = unchecked((uint)0x1200),

    [NativeName("AL_SEC_OFFSET_LATENCY_SOFT")]
    SecOffsetLatencySOFT = unchecked((uint)0x1201),

    [NativeName("AL_DEFERRED_UPDATES_SOFT")]
    DeferredUpdatesSOFT = unchecked((uint)0xC002),

    [NativeName("AL_UNPACK_BLOCK_ALIGNMENT_SOFT")]
    UnpackBlockAlignmentSOFT = unchecked((uint)0x200C),

    [NativeName("AL_PACK_BLOCK_ALIGNMENT_SOFT")]
    PackBlockAlignmentSOFT = unchecked((uint)0x200D),

    [NativeName("AL_FORMAT_MONO_MSADPCM_SOFT")]
    FormatMonoMsadpcmSOFT = unchecked((uint)0x1302),

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

    [NativeName("AL_GAIN_LIMIT_SOFT")]
    GainLimitSOFT = unchecked((uint)0x200E),

    [NativeName("AL_NUM_RESAMPLERS_SOFT")]
    NumResamplersSOFT = unchecked((uint)0x1210),

    [NativeName("AL_DEFAULT_RESAMPLER_SOFT")]
    DefaultResamplerSOFT = unchecked((uint)0x1211),

    [NativeName("AL_SOURCE_RESAMPLER_SOFT")]
    SourceResamplerSOFT = unchecked((uint)0x1212),

    [NativeName("AL_RESAMPLER_NAME_SOFT")]
    ResamplerNameSOFT = unchecked((uint)0x1213),

    [NativeName("AL_SOURCE_SPATIALIZE_SOFT")]
    SourceSpatializeSOFT = unchecked((uint)0x1214),

    [NativeName("AL_AUTO_SOFT")]
    AutoSOFT = unchecked((uint)0x0002),

    [NativeName("AL_SAMPLE_OFFSET_CLOCK_SOFT")]
    SampleOffsetClockSOFT = unchecked((uint)0x1202),

    [NativeName("AL_SEC_OFFSET_CLOCK_SOFT")]
    SecOffsetClockSOFT = unchecked((uint)0x1203),

    [NativeName("AL_DROP_UNMATCHED_SOFT")]
    DropUnmatchedSOFT = unchecked((uint)0x0001),

    [NativeName("AL_REMIX_UNMATCHED_SOFT")]
    RemixUnmatchedSOFT = unchecked((uint)0x0002),

    [NativeName("AL_AMBISONIC_LAYOUT_SOFT")]
    AmbisonicLayoutSOFT = unchecked((uint)0x1997),

    [NativeName("AL_AMBISONIC_SCALING_SOFT")]
    AmbisonicScalingSOFT = unchecked((uint)0x1998),

    [NativeName("AL_FUMA_SOFT")]
    FumaSOFT = unchecked((uint)0x0000),

    [NativeName("AL_ACN_SOFT")]
    AcnSOFT = unchecked((uint)0x0001),

    [NativeName("AL_SN3D_SOFT")]
    Sn3DSOFT = unchecked((uint)0x0001),

    [NativeName("AL_N3D_SOFT")]
    N3DSOFT = unchecked((uint)0x0002),

    [NativeName("AL_EFFECTSLOT_TARGET_SOFT")]
    EffectslotTargetSOFT = unchecked((uint)0x199C),

    [NativeName("AL_EVENT_CALLBACK_FUNCTION_SOFT")]
    EventCallbackFunctionSOFT = unchecked((uint)0x19A2),

    [NativeName("AL_EVENT_CALLBACK_USER_PARAM_SOFT")]
    EventCallbackUserParamSOFT = unchecked((uint)0x19A3),

    [NativeName("AL_EVENT_TYPE_BUFFER_COMPLETED_SOFT")]
    EventTypeBufferCompletedSOFT = unchecked((uint)0x19A4),

    [NativeName("AL_EVENT_TYPE_SOURCE_STATE_CHANGED_SOFT")]
    EventTypeSourceStateChangedSOFT = unchecked((uint)0x19A5),

    [NativeName("AL_EVENT_TYPE_DISCONNECTED_SOFT")]
    EventTypeDisconnectedSOFT = unchecked((uint)0x19A6),

    [NativeName("AL_BUFFER_CALLBACK_FUNCTION_SOFT")]
    BufferCallbackFunctionSOFT = unchecked((uint)0x19A0),

    [NativeName("AL_BUFFER_CALLBACK_USER_PARAM_SOFT")]
    BufferCallbackUserParamSOFT = unchecked((uint)0x19A1),

    [NativeName("AL_FORMAT_UHJ2CHN8_SOFT")]
    FormatUhj2Chn8SOFT = unchecked((uint)0x19A2),

    [NativeName("AL_FORMAT_UHJ2CHN16_SOFT")]
    FormatUhj2Chn16SOFT = unchecked((uint)0x19A3),

    [NativeName("AL_FORMAT_UHJ2CHN_FLOAT32_SOFT")]
    FormatUhj2ChnFloat32SOFT = unchecked((uint)0x19A4),

    [NativeName("AL_FORMAT_UHJ3CHN8_SOFT")]
    FormatUhj3Chn8SOFT = unchecked((uint)0x19A5),

    [NativeName("AL_FORMAT_UHJ3CHN16_SOFT")]
    FormatUhj3Chn16SOFT = unchecked((uint)0x19A6),

    [NativeName("AL_FORMAT_UHJ3CHN_FLOAT32_SOFT")]
    FormatUhj3ChnFloat32SOFT = unchecked((uint)0x19A7),

    [NativeName("AL_FORMAT_UHJ4CHN8_SOFT")]
    FormatUhj4Chn8SOFT = unchecked((uint)0x19A8),

    [NativeName("AL_FORMAT_UHJ4CHN16_SOFT")]
    FormatUhj4Chn16SOFT = unchecked((uint)0x19A9),

    [NativeName("AL_FORMAT_UHJ4CHN_FLOAT32_SOFT")]
    FormatUhj4ChnFloat32SOFT = unchecked((uint)0x19AA),

    [NativeName("AL_STEREO_MODE_SOFT")]
    StereoModeSOFT = unchecked((uint)0x19B0),

    [NativeName("AL_NORMAL_SOFT")]
    NormalSOFT = unchecked((uint)0x0000),

    [NativeName("AL_SUPER_STEREO_SOFT")]
    SuperStereoSOFT = unchecked((uint)0x0001),

    [NativeName("AL_SUPER_STEREO_WIDTH_SOFT")]
    SuperStereoWidthSOFT = unchecked((uint)0x19B1),

    [NativeName("AL_FORMAT_UHJ2CHN_MULAW_SOFT")]
    FormatUhj2ChnMulawSOFT = unchecked((uint)0x19B3),

    [NativeName("AL_FORMAT_UHJ2CHN_ALAW_SOFT")]
    FormatUhj2ChnAlawSOFT = unchecked((uint)0x19B4),

    [NativeName("AL_FORMAT_UHJ2CHN_IMA4_SOFT")]
    FormatUhj2ChnIma4SOFT = unchecked((uint)0x19B5),

    [NativeName("AL_FORMAT_UHJ2CHN_MSADPCM_SOFT")]
    FormatUhj2ChnMsadpcmSOFT = unchecked((uint)0x19B6),

    [NativeName("AL_FORMAT_UHJ3CHN_MULAW_SOFT")]
    FormatUhj3ChnMulawSOFT = unchecked((uint)0x19B7),

    [NativeName("AL_FORMAT_UHJ3CHN_ALAW_SOFT")]
    FormatUhj3ChnAlawSOFT = unchecked((uint)0x19B8),

    [NativeName("AL_FORMAT_UHJ4CHN_MULAW_SOFT")]
    FormatUhj4ChnMulawSOFT = unchecked((uint)0x19B9),

    [NativeName("AL_FORMAT_UHJ4CHN_ALAW_SOFT")]
    FormatUhj4ChnAlawSOFT = unchecked((uint)0x19BA),

    [NativeName("AL_DONT_CARE_EXT")]
    DontCareEXT = unchecked((uint)0x0002),

    [NativeName("AL_DEBUG_OUTPUT_EXT")]
    DebugOutputEXT = unchecked((uint)0x19B2),

    [NativeName("AL_DEBUG_CALLBACK_FUNCTION_EXT")]
    DebugCallbackFunctionEXT = unchecked((uint)0x19B3),

    [NativeName("AL_DEBUG_CALLBACK_USER_PARAM_EXT")]
    DebugCallbackUserParamEXT = unchecked((uint)0x19B4),

    [NativeName("AL_DEBUG_SOURCE_API_EXT")]
    DebugSourceApiEXT = unchecked((uint)0x19B5),

    [NativeName("AL_DEBUG_SOURCE_AUDIO_SYSTEM_EXT")]
    DebugSourceAudioSystemEXT = unchecked((uint)0x19B6),

    [NativeName("AL_DEBUG_SOURCE_THIRD_PARTY_EXT")]
    DebugSourceThirdPartyEXT = unchecked((uint)0x19B7),

    [NativeName("AL_DEBUG_SOURCE_APPLICATION_EXT")]
    DebugSourceApplicationEXT = unchecked((uint)0x19B8),

    [NativeName("AL_DEBUG_SOURCE_OTHER_EXT")]
    DebugSourceOtherEXT = unchecked((uint)0x19B9),

    [NativeName("AL_DEBUG_TYPE_ERROR_EXT")]
    DebugTypeErrorEXT = unchecked((uint)0x19BA),

    [NativeName("AL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_EXT")]
    DebugTypeDeprecatedBehaviorEXT = unchecked((uint)0x19BB),

    [NativeName("AL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_EXT")]
    DebugTypeUndefinedBehaviorEXT = unchecked((uint)0x19BC),

    [NativeName("AL_DEBUG_TYPE_PORTABILITY_EXT")]
    DebugTypePortabilityEXT = unchecked((uint)0x19BD),

    [NativeName("AL_DEBUG_TYPE_PERFORMANCE_EXT")]
    DebugTypePerformanceEXT = unchecked((uint)0x19BE),

    [NativeName("AL_DEBUG_TYPE_MARKER_EXT")]
    DebugTypeMarkerEXT = unchecked((uint)0x19BF),

    [NativeName("AL_DEBUG_TYPE_PUSH_GROUP_EXT")]
    DebugTypePushGroupEXT = unchecked((uint)0x19C0),

    [NativeName("AL_DEBUG_TYPE_POP_GROUP_EXT")]
    DebugTypePopGroupEXT = unchecked((uint)0x19C1),

    [NativeName("AL_DEBUG_TYPE_OTHER_EXT")]
    DebugTypeOtherEXT = unchecked((uint)0x19C2),

    [NativeName("AL_DEBUG_SEVERITY_HIGH_EXT")]
    DebugSeverityHighEXT = unchecked((uint)0x19C3),

    [NativeName("AL_DEBUG_SEVERITY_MEDIUM_EXT")]
    DebugSeverityMediumEXT = unchecked((uint)0x19C4),

    [NativeName("AL_DEBUG_SEVERITY_LOW_EXT")]
    DebugSeverityLowEXT = unchecked((uint)0x19C5),

    [NativeName("AL_DEBUG_SEVERITY_NOTIFICATION_EXT")]
    DebugSeverityNotificationEXT = unchecked((uint)0x19C6),

    [NativeName("AL_DEBUG_LOGGED_MESSAGES_EXT")]
    DebugLoggedMessagesEXT = unchecked((uint)0x19C7),

    [NativeName("AL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_EXT")]
    DebugNextLoggedMessageLengthEXT = unchecked((uint)0x19C8),

    [NativeName("AL_MAX_DEBUG_MESSAGE_LENGTH_EXT")]
    MaxDebugMessageLengthEXT = unchecked((uint)0x19C9),

    [NativeName("AL_MAX_DEBUG_LOGGED_MESSAGES_EXT")]
    MaxDebugLoggedMessagesEXT = unchecked((uint)0x19CA),

    [NativeName("AL_MAX_DEBUG_GROUP_STACK_DEPTH_EXT")]
    MaxDebugGroupStackDepthEXT = unchecked((uint)0x19CB),

    [NativeName("AL_MAX_LABEL_LENGTH_EXT")]
    MaxLabelLengthEXT = unchecked((uint)0x19CC),

    [NativeName("AL_STACK_OVERFLOW_EXT")]
    StackOverflowEXT = unchecked((uint)0x19CD),

    [NativeName("AL_STACK_UNDERFLOW_EXT")]
    StackUnderflowEXT = unchecked((uint)0x19CE),

    [NativeName("AL_CONTEXT_FLAGS_EXT")]
    ContextFlagsEXT = unchecked((uint)0x19CF),

    [NativeName("AL_BUFFER_EXT")]
    BufferEXT = unchecked((uint)0x1009),

    [NativeName("AL_SOURCE_EXT")]
    SourceEXT = unchecked((uint)0x19D0),

    [NativeName("AL_FILTER_EXT")]
    FilterEXT = unchecked((uint)0x19D1),

    [NativeName("AL_EFFECT_EXT")]
    EffectEXT = unchecked((uint)0x19D2),

    [NativeName("AL_AUXILIARY_EFFECT_SLOT_EXT")]
    AuxiliaryEffectSlotEXT = unchecked((uint)0x19D3),

    [NativeName("AL_UNPACK_AMBISONIC_ORDER_SOFT")]
    UnpackAmbisonicOrderSOFT = unchecked((uint)0x199D),

    [NativeName("ALC_DEFAULT_FILTER_ORDER")]
    CDefaultFilterOrder = unchecked((uint)0x1100),
}
