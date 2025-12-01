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
    None = 0,

    [NativeName("AL_FALSE")]
    False = 0,

    [NativeName("AL_TRUE")]
    True = 1,

    [NativeName("AL_SOURCE_RELATIVE")]
    SourceRelative = 514,

    [NativeName("AL_CONE_INNER_ANGLE")]
    ConeInnerAngle = 4097,

    [NativeName("AL_CONE_OUTER_ANGLE")]
    ConeOuterAngle = 4098,

    [NativeName("AL_PITCH")]
    Pitch = 4099,

    [NativeName("AL_POSITION")]
    Position = 4100,

    [NativeName("AL_DIRECTION")]
    Direction = 4101,

    [NativeName("AL_VELOCITY")]
    Velocity = 4102,

    [NativeName("AL_LOOPING")]
    Looping = 4103,

    [NativeName("AL_BUFFER")]
    Buffer = 4105,

    [NativeName("AL_GAIN")]
    Gain = 4106,

    [NativeName("AL_MIN_GAIN")]
    MinGain = 4109,

    [NativeName("AL_MAX_GAIN")]
    MaxGain = 4110,

    [NativeName("AL_ORIENTATION")]
    Orientation = 4111,

    [NativeName("AL_SOURCE_STATE")]
    SourceState = 4112,

    [NativeName("AL_INITIAL")]
    Initial = 4113,

    [NativeName("AL_PLAYING")]
    Playing = 4114,

    [NativeName("AL_PAUSED")]
    Paused = 4115,

    [NativeName("AL_STOPPED")]
    Stopped = 4116,

    [NativeName("AL_BUFFERS_QUEUED")]
    BuffersQueued = 4117,

    [NativeName("AL_BUFFERS_PROCESSED")]
    BuffersProcessed = 4118,

    [NativeName("AL_REFERENCE_DISTANCE")]
    ReferenceDistance = 4128,

    [NativeName("AL_ROLLOFF_FACTOR")]
    RolloffFactor = 4129,

    [NativeName("AL_CONE_OUTER_GAIN")]
    ConeOuterGain = 4130,

    [NativeName("AL_MAX_DISTANCE")]
    MaxDistance = 4131,

    [NativeName("AL_FORMAT_MONO8")]
    FormatMono8 = 4352,

    [NativeName("AL_FORMAT_MONO16")]
    FormatMono16 = 4353,

    [NativeName("AL_FORMAT_STEREO8")]
    FormatStereo8 = 4354,

    [NativeName("AL_FORMAT_STEREO16")]
    FormatStereo16 = 4355,

    [NativeName("AL_FREQUENCY")]
    Frequency = 8193,

    [NativeName("AL_SIZE")]
    Size = 8196,

    [NativeName("AL_UNUSED")]
    Unused = 8208,

    [NativeName("AL_PENDING")]
    Pending = 8209,

    [NativeName("AL_PROCESSED")]
    Processed = 8210,

    [NativeName("AL_NO_ERROR")]
    NoError = 0,

    [NativeName("AL_INVALID_NAME")]
    InvalidName = 40961,

    [NativeName("AL_INVALID_ENUM")]
    InvalidEnum = 40962,

    [NativeName("AL_INVALID_VALUE")]
    InvalidValue = 40963,

    [NativeName("AL_INVALID_OPERATION")]
    InvalidOperation = 40964,

    [NativeName("AL_OUT_OF_MEMORY")]
    OutOfMemory = 40965,

    [NativeName("AL_VENDOR")]
    Vendor = 45057,

    [NativeName("AL_VERSION")]
    Version = 45058,

    [NativeName("AL_RENDERER")]
    Renderer = 45059,

    [NativeName("AL_EXTENSIONS")]
    Extensions = 45060,

    [NativeName("AL_DOPPLER_FACTOR")]
    DopplerFactor = 49152,

    [NativeName("AL_DOPPLER_VELOCITY")]
    DopplerVelocity = 49153,

    [NativeName("AL_DISTANCE_MODEL")]
    DistanceModel = 53248,

    [NativeName("AL_INVALID")]
    Invalid = 4294967295,

    [NativeName("AL_ILLEGAL_ENUM")]
    IllegalEnum = 40962,

    [NativeName("AL_ILLEGAL_COMMAND")]
    IllegalCommand = 40964,

    [NativeName("AL_INVERSE_DISTANCE")]
    InverseDistance = 53249,

    [NativeName("AL_INVERSE_DISTANCE_CLAMPED")]
    InverseDistanceClamped = 53250,

    [NativeName("AL_SEC_OFFSET")]
    SecOffset = 4132,

    [NativeName("AL_SAMPLE_OFFSET")]
    SampleOffset = 4133,

    [NativeName("AL_BYTE_OFFSET")]
    ByteOffset = 4134,

    [NativeName("AL_SOURCE_TYPE")]
    SourceType = 4135,

    [NativeName("AL_STATIC")]
    Static = 4136,

    [NativeName("AL_STREAMING")]
    Streaming = 4137,

    [NativeName("AL_UNDETERMINED")]
    Undetermined = 4144,

    [NativeName("AL_BITS")]
    Bits = 8194,

    [NativeName("AL_CHANNELS")]
    Channels = 8195,

    [NativeName("AL_SPEED_OF_SOUND")]
    SpeedOfSound = 49155,

    [NativeName("AL_LINEAR_DISTANCE")]
    LinearDistance = 53251,

    [NativeName("AL_LINEAR_DISTANCE_CLAMPED")]
    LinearDistanceClamped = 53252,

    [NativeName("AL_EXPONENT_DISTANCE")]
    ExponentDistance = 53253,

    [NativeName("AL_EXPONENT_DISTANCE_CLAMPED")]
    ExponentDistanceClamped = 53254,

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

    [NativeName("AL_METERS_PER_UNIT")]
    MetersPerUnit = 131076,

    [NativeName("AL_DIRECT_FILTER")]
    DirectFilter = 131077,

    [NativeName("AL_AUXILIARY_SEND_FILTER")]
    AuxiliarySendFilter = 131078,

    [NativeName("AL_AIR_ABSORPTION_FACTOR")]
    AirAbsorptionFactor = 131079,

    [NativeName("AL_ROOM_ROLLOFF_FACTOR")]
    RoomRolloffFactor = 131080,

    [NativeName("AL_CONE_OUTER_GAINHF")]
    ConeOuterGainhf = 131081,

    [NativeName("AL_DIRECT_FILTER_GAINHF_AUTO")]
    DirectFilterGainhfAuto = 131082,

    [NativeName("AL_AUXILIARY_SEND_FILTER_GAIN_AUTO")]
    AuxiliarySendFilterGainAuto = 131083,

    [NativeName("AL_AUXILIARY_SEND_FILTER_GAINHF_AUTO")]
    AuxiliarySendFilterGainhfAuto = 131084,

    [NativeName("AL_REVERB_DENSITY")]
    ReverbDensity = 1,

    [NativeName("AL_REVERB_DIFFUSION")]
    ReverbDiffusion = 2,

    [NativeName("AL_REVERB_GAIN")]
    ReverbGain = 3,

    [NativeName("AL_REVERB_GAINHF")]
    ReverbGainhf = 4,

    [NativeName("AL_REVERB_DECAY_TIME")]
    ReverbDecayTime = 5,

    [NativeName("AL_REVERB_DECAY_HFRATIO")]
    ReverbDecayHfratio = 6,

    [NativeName("AL_REVERB_REFLECTIONS_GAIN")]
    ReverbReflectionsGain = 7,

    [NativeName("AL_REVERB_REFLECTIONS_DELAY")]
    ReverbReflectionsDelay = 8,

    [NativeName("AL_REVERB_LATE_REVERB_GAIN")]
    ReverbLateReverbGain = 9,

    [NativeName("AL_REVERB_LATE_REVERB_DELAY")]
    ReverbLateReverbDelay = 10,

    [NativeName("AL_REVERB_AIR_ABSORPTION_GAINHF")]
    ReverbAirAbsorptionGainhf = 11,

    [NativeName("AL_REVERB_ROOM_ROLLOFF_FACTOR")]
    ReverbRoomRolloffFactor = 12,

    [NativeName("AL_REVERB_DECAY_HFLIMIT")]
    ReverbDecayHflimit = 13,

    [NativeName("AL_EAXREVERB_DENSITY")]
    EaxreverbDensity = 1,

    [NativeName("AL_EAXREVERB_DIFFUSION")]
    EaxreverbDiffusion = 2,

    [NativeName("AL_EAXREVERB_GAIN")]
    EaxreverbGain = 3,

    [NativeName("AL_EAXREVERB_GAINHF")]
    EaxreverbGainhf = 4,

    [NativeName("AL_EAXREVERB_GAINLF")]
    EaxreverbGainlf = 5,

    [NativeName("AL_EAXREVERB_DECAY_TIME")]
    EaxreverbDecayTime = 6,

    [NativeName("AL_EAXREVERB_DECAY_HFRATIO")]
    EaxreverbDecayHfratio = 7,

    [NativeName("AL_EAXREVERB_DECAY_LFRATIO")]
    EaxreverbDecayLfratio = 8,

    [NativeName("AL_EAXREVERB_REFLECTIONS_GAIN")]
    EaxreverbReflectionsGain = 9,

    [NativeName("AL_EAXREVERB_REFLECTIONS_DELAY")]
    EaxreverbReflectionsDelay = 10,

    [NativeName("AL_EAXREVERB_REFLECTIONS_PAN")]
    EaxreverbReflectionsPan = 11,

    [NativeName("AL_EAXREVERB_LATE_REVERB_GAIN")]
    EaxreverbLateReverbGain = 12,

    [NativeName("AL_EAXREVERB_LATE_REVERB_DELAY")]
    EaxreverbLateReverbDelay = 13,

    [NativeName("AL_EAXREVERB_LATE_REVERB_PAN")]
    EaxreverbLateReverbPan = 14,

    [NativeName("AL_EAXREVERB_ECHO_TIME")]
    EaxreverbEchoTime = 15,

    [NativeName("AL_EAXREVERB_ECHO_DEPTH")]
    EaxreverbEchoDepth = 16,

    [NativeName("AL_EAXREVERB_MODULATION_TIME")]
    EaxreverbModulationTime = 17,

    [NativeName("AL_EAXREVERB_MODULATION_DEPTH")]
    EaxreverbModulationDepth = 18,

    [NativeName("AL_EAXREVERB_AIR_ABSORPTION_GAINHF")]
    EaxreverbAirAbsorptionGainhf = 19,

    [NativeName("AL_EAXREVERB_HFREFERENCE")]
    EaxreverbHfreference = 20,

    [NativeName("AL_EAXREVERB_LFREFERENCE")]
    EaxreverbLfreference = 21,

    [NativeName("AL_EAXREVERB_ROOM_ROLLOFF_FACTOR")]
    EaxreverbRoomRolloffFactor = 22,

    [NativeName("AL_EAXREVERB_DECAY_HFLIMIT")]
    EaxreverbDecayHflimit = 23,

    [NativeName("AL_CHORUS_WAVEFORM")]
    ChorusWaveform = 1,

    [NativeName("AL_CHORUS_PHASE")]
    ChorusPhase = 2,

    [NativeName("AL_CHORUS_RATE")]
    ChorusRate = 3,

    [NativeName("AL_CHORUS_DEPTH")]
    ChorusDepth = 4,

    [NativeName("AL_CHORUS_FEEDBACK")]
    ChorusFeedback = 5,

    [NativeName("AL_CHORUS_DELAY")]
    ChorusDelay = 6,

    [NativeName("AL_DISTORTION_EDGE")]
    DistortionEdge = 1,

    [NativeName("AL_DISTORTION_GAIN")]
    DistortionGain = 2,

    [NativeName("AL_DISTORTION_LOWPASS_CUTOFF")]
    DistortionLowpassCutoff = 3,

    [NativeName("AL_DISTORTION_EQCENTER")]
    DistortionEqcenter = 4,

    [NativeName("AL_DISTORTION_EQBANDWIDTH")]
    DistortionEqbandwidth = 5,

    [NativeName("AL_ECHO_DELAY")]
    EchoDelay = 1,

    [NativeName("AL_ECHO_LRDELAY")]
    EchoLrdelay = 2,

    [NativeName("AL_ECHO_DAMPING")]
    EchoDamping = 3,

    [NativeName("AL_ECHO_FEEDBACK")]
    EchoFeedback = 4,

    [NativeName("AL_ECHO_SPREAD")]
    EchoSpread = 5,

    [NativeName("AL_FLANGER_WAVEFORM")]
    FlangerWaveform = 1,

    [NativeName("AL_FLANGER_PHASE")]
    FlangerPhase = 2,

    [NativeName("AL_FLANGER_RATE")]
    FlangerRate = 3,

    [NativeName("AL_FLANGER_DEPTH")]
    FlangerDepth = 4,

    [NativeName("AL_FLANGER_FEEDBACK")]
    FlangerFeedback = 5,

    [NativeName("AL_FLANGER_DELAY")]
    FlangerDelay = 6,

    [NativeName("AL_FREQUENCY_SHIFTER_FREQUENCY")]
    FrequencyShifterFrequency = 1,

    [NativeName("AL_FREQUENCY_SHIFTER_LEFT_DIRECTION")]
    FrequencyShifterLeftDirection = 2,

    [NativeName("AL_FREQUENCY_SHIFTER_RIGHT_DIRECTION")]
    FrequencyShifterRightDirection = 3,

    [NativeName("AL_VOCAL_MORPHER_PHONEMEA")]
    VocalMorpherPhonemea = 1,

    [NativeName("AL_VOCAL_MORPHER_PHONEMEA_COARSE_TUNING")]
    VocalMorpherPhonemeaCoarseTuning = 2,

    [NativeName("AL_VOCAL_MORPHER_PHONEMEB")]
    VocalMorpherPhonemeb = 3,

    [NativeName("AL_VOCAL_MORPHER_PHONEMEB_COARSE_TUNING")]
    VocalMorpherPhonemebCoarseTuning = 4,

    [NativeName("AL_VOCAL_MORPHER_WAVEFORM")]
    VocalMorpherWaveform = 5,

    [NativeName("AL_VOCAL_MORPHER_RATE")]
    VocalMorpherRate = 6,

    [NativeName("AL_PITCH_SHIFTER_COARSE_TUNE")]
    PitchShifterCoarseTune = 1,

    [NativeName("AL_PITCH_SHIFTER_FINE_TUNE")]
    PitchShifterFineTune = 2,

    [NativeName("AL_RING_MODULATOR_FREQUENCY")]
    RingModulatorFrequency = 1,

    [NativeName("AL_RING_MODULATOR_HIGHPASS_CUTOFF")]
    RingModulatorHighpassCutoff = 2,

    [NativeName("AL_RING_MODULATOR_WAVEFORM")]
    RingModulatorWaveform = 3,

    [NativeName("AL_AUTOWAH_ATTACK_TIME")]
    AutowahAttackTime = 1,

    [NativeName("AL_AUTOWAH_RELEASE_TIME")]
    AutowahReleaseTime = 2,

    [NativeName("AL_AUTOWAH_RESONANCE")]
    AutowahResonance = 3,

    [NativeName("AL_AUTOWAH_PEAK_GAIN")]
    AutowahPeakGain = 4,

    [NativeName("AL_COMPRESSOR_ONOFF")]
    CompressorOnoff = 1,

    [NativeName("AL_EQUALIZER_LOW_GAIN")]
    EqualizerLowGain = 1,

    [NativeName("AL_EQUALIZER_LOW_CUTOFF")]
    EqualizerLowCutoff = 2,

    [NativeName("AL_EQUALIZER_MID1_GAIN")]
    EqualizerMid1Gain = 3,

    [NativeName("AL_EQUALIZER_MID1_CENTER")]
    EqualizerMid1Center = 4,

    [NativeName("AL_EQUALIZER_MID1_WIDTH")]
    EqualizerMid1Width = 5,

    [NativeName("AL_EQUALIZER_MID2_GAIN")]
    EqualizerMid2Gain = 6,

    [NativeName("AL_EQUALIZER_MID2_CENTER")]
    EqualizerMid2Center = 7,

    [NativeName("AL_EQUALIZER_MID2_WIDTH")]
    EqualizerMid2Width = 8,

    [NativeName("AL_EQUALIZER_HIGH_GAIN")]
    EqualizerHighGain = 9,

    [NativeName("AL_EQUALIZER_HIGH_CUTOFF")]
    EqualizerHighCutoff = 10,

    [NativeName("AL_EFFECT_FIRST_PARAMETER")]
    EffectFirstParameter = 0,

    [NativeName("AL_EFFECT_LAST_PARAMETER")]
    EffectLastParameter = 32768,

    [NativeName("AL_EFFECT_TYPE")]
    EffectType = 32769,

    [NativeName("AL_EFFECT_NULL")]
    EffectNull = 0,

    [NativeName("AL_EFFECT_REVERB")]
    EffectReverb = 1,

    [NativeName("AL_EFFECT_CHORUS")]
    EffectChorus = 2,

    [NativeName("AL_EFFECT_DISTORTION")]
    EffectDistortion = 3,

    [NativeName("AL_EFFECT_ECHO")]
    EffectEcho = 4,

    [NativeName("AL_EFFECT_FLANGER")]
    EffectFlanger = 5,

    [NativeName("AL_EFFECT_FREQUENCY_SHIFTER")]
    EffectFrequencyShifter = 6,

    [NativeName("AL_EFFECT_VOCAL_MORPHER")]
    EffectVocalMorpher = 7,

    [NativeName("AL_EFFECT_PITCH_SHIFTER")]
    EffectPitchShifter = 8,

    [NativeName("AL_EFFECT_RING_MODULATOR")]
    EffectRingModulator = 9,

    [NativeName("AL_EFFECT_AUTOWAH")]
    EffectAutowah = 10,

    [NativeName("AL_EFFECT_COMPRESSOR")]
    EffectCompressor = 11,

    [NativeName("AL_EFFECT_EQUALIZER")]
    EffectEqualizer = 12,

    [NativeName("AL_EFFECT_EAXREVERB")]
    EffectEaxreverb = 32768,

    [NativeName("AL_EFFECTSLOT_EFFECT")]
    EffectslotEffect = 1,

    [NativeName("AL_EFFECTSLOT_GAIN")]
    EffectslotGain = 2,

    [NativeName("AL_EFFECTSLOT_AUXILIARY_SEND_AUTO")]
    EffectslotAuxiliarySendAuto = 3,

    [NativeName("AL_EFFECTSLOT_NULL")]
    EffectslotNull = 0,

    [NativeName("AL_LOWPASS_GAIN")]
    LowpassGain = 1,

    [NativeName("AL_LOWPASS_GAINHF")]
    LowpassGainhf = 2,

    [NativeName("AL_HIGHPASS_GAIN")]
    HighpassGain = 1,

    [NativeName("AL_HIGHPASS_GAINLF")]
    HighpassGainlf = 2,

    [NativeName("AL_BANDPASS_GAIN")]
    BandpassGain = 1,

    [NativeName("AL_BANDPASS_GAINLF")]
    BandpassGainlf = 2,

    [NativeName("AL_BANDPASS_GAINHF")]
    BandpassGainhf = 3,

    [NativeName("AL_FILTER_FIRST_PARAMETER")]
    FilterFirstParameter = 0,

    [NativeName("AL_FILTER_LAST_PARAMETER")]
    FilterLastParameter = 32768,

    [NativeName("AL_FILTER_TYPE")]
    FilterType = 32769,

    [NativeName("AL_FILTER_NULL")]
    FilterNull = 0,

    [NativeName("AL_FILTER_LOWPASS")]
    FilterLowpass = 1,

    [NativeName("AL_FILTER_HIGHPASS")]
    FilterHighpass = 2,

    [NativeName("AL_FILTER_BANDPASS")]
    FilterBandpass = 3,

    [NativeName("AL_LOWPASS_MIN_GAIN")]
    LowpassMinGain = 0,

    [NativeName("AL_LOWPASS_MAX_GAIN")]
    LowpassMaxGain = 1,

    [NativeName("AL_LOWPASS_DEFAULT_GAIN")]
    LowpassDefaultGain = 1,

    [NativeName("AL_LOWPASS_MIN_GAINHF")]
    LowpassMinGainhf = 0,

    [NativeName("AL_LOWPASS_MAX_GAINHF")]
    LowpassMaxGainhf = 1,

    [NativeName("AL_LOWPASS_DEFAULT_GAINHF")]
    LowpassDefaultGainhf = 1,

    [NativeName("AL_HIGHPASS_MIN_GAIN")]
    HighpassMinGain = 0,

    [NativeName("AL_HIGHPASS_MAX_GAIN")]
    HighpassMaxGain = 1,

    [NativeName("AL_HIGHPASS_DEFAULT_GAIN")]
    HighpassDefaultGain = 1,

    [NativeName("AL_HIGHPASS_MIN_GAINLF")]
    HighpassMinGainlf = 0,

    [NativeName("AL_HIGHPASS_MAX_GAINLF")]
    HighpassMaxGainlf = 1,

    [NativeName("AL_HIGHPASS_DEFAULT_GAINLF")]
    HighpassDefaultGainlf = 1,

    [NativeName("AL_BANDPASS_MIN_GAIN")]
    BandpassMinGain = 0,

    [NativeName("AL_BANDPASS_MAX_GAIN")]
    BandpassMaxGain = 1,

    [NativeName("AL_BANDPASS_DEFAULT_GAIN")]
    BandpassDefaultGain = 1,

    [NativeName("AL_BANDPASS_MIN_GAINHF")]
    BandpassMinGainhf = 0,

    [NativeName("AL_BANDPASS_MAX_GAINHF")]
    BandpassMaxGainhf = 1,

    [NativeName("AL_BANDPASS_DEFAULT_GAINHF")]
    BandpassDefaultGainhf = 1,

    [NativeName("AL_BANDPASS_MIN_GAINLF")]
    BandpassMinGainlf = 0,

    [NativeName("AL_BANDPASS_MAX_GAINLF")]
    BandpassMaxGainlf = 1,

    [NativeName("AL_BANDPASS_DEFAULT_GAINLF")]
    BandpassDefaultGainlf = 1,

    [NativeName("AL_REVERB_MIN_DENSITY")]
    ReverbMinDensity = 0,

    [NativeName("AL_REVERB_MAX_DENSITY")]
    ReverbMaxDensity = 1,

    [NativeName("AL_REVERB_DEFAULT_DENSITY")]
    ReverbDefaultDensity = 1,

    [NativeName("AL_REVERB_MIN_DIFFUSION")]
    ReverbMinDiffusion = 0,

    [NativeName("AL_REVERB_MAX_DIFFUSION")]
    ReverbMaxDiffusion = 1,

    [NativeName("AL_REVERB_DEFAULT_DIFFUSION")]
    ReverbDefaultDiffusion = 1,

    [NativeName("AL_REVERB_MIN_GAIN")]
    ReverbMinGain = 0,

    [NativeName("AL_REVERB_MAX_GAIN")]
    ReverbMaxGain = 1,

    [NativeName("AL_REVERB_DEFAULT_GAIN")]
    ReverbDefaultGain = 0,

    [NativeName("AL_REVERB_MIN_GAINHF")]
    ReverbMinGainhf = 0,

    [NativeName("AL_REVERB_MAX_GAINHF")]
    ReverbMaxGainhf = 1,

    [NativeName("AL_REVERB_DEFAULT_GAINHF")]
    ReverbDefaultGainhf = 0,

    [NativeName("AL_REVERB_MIN_DECAY_TIME")]
    ReverbMinDecayTime = 0,

    [NativeName("AL_REVERB_MAX_DECAY_TIME")]
    ReverbMaxDecayTime = 20,

    [NativeName("AL_REVERB_DEFAULT_DECAY_TIME")]
    ReverbDefaultDecayTime = 1,

    [NativeName("AL_REVERB_MIN_DECAY_HFRATIO")]
    ReverbMinDecayHfratio = 0,

    [NativeName("AL_REVERB_MAX_DECAY_HFRATIO")]
    ReverbMaxDecayHfratio = 2,

    [NativeName("AL_REVERB_DEFAULT_DECAY_HFRATIO")]
    ReverbDefaultDecayHfratio = 0,

    [NativeName("AL_REVERB_MIN_REFLECTIONS_GAIN")]
    ReverbMinReflectionsGain = 0,

    [NativeName("AL_REVERB_MAX_REFLECTIONS_GAIN")]
    ReverbMaxReflectionsGain = 3,

    [NativeName("AL_REVERB_DEFAULT_REFLECTIONS_GAIN")]
    ReverbDefaultReflectionsGain = 0,

    [NativeName("AL_REVERB_MIN_REFLECTIONS_DELAY")]
    ReverbMinReflectionsDelay = 0,

    [NativeName("AL_REVERB_MAX_REFLECTIONS_DELAY")]
    ReverbMaxReflectionsDelay = 0,

    [NativeName("AL_REVERB_DEFAULT_REFLECTIONS_DELAY")]
    ReverbDefaultReflectionsDelay = 0,

    [NativeName("AL_REVERB_MIN_LATE_REVERB_GAIN")]
    ReverbMinLateReverbGain = 0,

    [NativeName("AL_REVERB_MAX_LATE_REVERB_GAIN")]
    ReverbMaxLateReverbGain = 10,

    [NativeName("AL_REVERB_DEFAULT_LATE_REVERB_GAIN")]
    ReverbDefaultLateReverbGain = 1,

    [NativeName("AL_REVERB_MIN_LATE_REVERB_DELAY")]
    ReverbMinLateReverbDelay = 0,

    [NativeName("AL_REVERB_MAX_LATE_REVERB_DELAY")]
    ReverbMaxLateReverbDelay = 0,

    [NativeName("AL_REVERB_DEFAULT_LATE_REVERB_DELAY")]
    ReverbDefaultLateReverbDelay = 0,

    [NativeName("AL_REVERB_MIN_AIR_ABSORPTION_GAINHF")]
    ReverbMinAirAbsorptionGainhf = 0,

    [NativeName("AL_REVERB_MAX_AIR_ABSORPTION_GAINHF")]
    ReverbMaxAirAbsorptionGainhf = 1,

    [NativeName("AL_REVERB_DEFAULT_AIR_ABSORPTION_GAINHF")]
    ReverbDefaultAirAbsorptionGainhf = 0,

    [NativeName("AL_REVERB_MIN_ROOM_ROLLOFF_FACTOR")]
    ReverbMinRoomRolloffFactor = 0,

    [NativeName("AL_REVERB_MAX_ROOM_ROLLOFF_FACTOR")]
    ReverbMaxRoomRolloffFactor = 10,

    [NativeName("AL_REVERB_DEFAULT_ROOM_ROLLOFF_FACTOR")]
    ReverbDefaultRoomRolloffFactor = 0,

    [NativeName("AL_REVERB_MIN_DECAY_HFLIMIT")]
    ReverbMinDecayHflimit = 0,

    [NativeName("AL_REVERB_MAX_DECAY_HFLIMIT")]
    ReverbMaxDecayHflimit = 1,

    [NativeName("AL_REVERB_DEFAULT_DECAY_HFLIMIT")]
    ReverbDefaultDecayHflimit = 1,

    [NativeName("AL_EAXREVERB_MIN_DENSITY")]
    EaxreverbMinDensity = 0,

    [NativeName("AL_EAXREVERB_MAX_DENSITY")]
    EaxreverbMaxDensity = 1,

    [NativeName("AL_EAXREVERB_DEFAULT_DENSITY")]
    EaxreverbDefaultDensity = 1,

    [NativeName("AL_EAXREVERB_MIN_DIFFUSION")]
    EaxreverbMinDiffusion = 0,

    [NativeName("AL_EAXREVERB_MAX_DIFFUSION")]
    EaxreverbMaxDiffusion = 1,

    [NativeName("AL_EAXREVERB_DEFAULT_DIFFUSION")]
    EaxreverbDefaultDiffusion = 1,

    [NativeName("AL_EAXREVERB_MIN_GAIN")]
    EaxreverbMinGain = 0,

    [NativeName("AL_EAXREVERB_MAX_GAIN")]
    EaxreverbMaxGain = 1,

    [NativeName("AL_EAXREVERB_DEFAULT_GAIN")]
    EaxreverbDefaultGain = 0,

    [NativeName("AL_EAXREVERB_MIN_GAINHF")]
    EaxreverbMinGainhf = 0,

    [NativeName("AL_EAXREVERB_MAX_GAINHF")]
    EaxreverbMaxGainhf = 1,

    [NativeName("AL_EAXREVERB_DEFAULT_GAINHF")]
    EaxreverbDefaultGainhf = 0,

    [NativeName("AL_EAXREVERB_MIN_GAINLF")]
    EaxreverbMinGainlf = 0,

    [NativeName("AL_EAXREVERB_MAX_GAINLF")]
    EaxreverbMaxGainlf = 1,

    [NativeName("AL_EAXREVERB_DEFAULT_GAINLF")]
    EaxreverbDefaultGainlf = 1,

    [NativeName("AL_EAXREVERB_MIN_DECAY_TIME")]
    EaxreverbMinDecayTime = 0,

    [NativeName("AL_EAXREVERB_MAX_DECAY_TIME")]
    EaxreverbMaxDecayTime = 20,

    [NativeName("AL_EAXREVERB_DEFAULT_DECAY_TIME")]
    EaxreverbDefaultDecayTime = 1,

    [NativeName("AL_EAXREVERB_MIN_DECAY_HFRATIO")]
    EaxreverbMinDecayHfratio = 0,

    [NativeName("AL_EAXREVERB_MAX_DECAY_HFRATIO")]
    EaxreverbMaxDecayHfratio = 2,

    [NativeName("AL_EAXREVERB_DEFAULT_DECAY_HFRATIO")]
    EaxreverbDefaultDecayHfratio = 0,

    [NativeName("AL_EAXREVERB_MIN_DECAY_LFRATIO")]
    EaxreverbMinDecayLfratio = 0,

    [NativeName("AL_EAXREVERB_MAX_DECAY_LFRATIO")]
    EaxreverbMaxDecayLfratio = 2,

    [NativeName("AL_EAXREVERB_DEFAULT_DECAY_LFRATIO")]
    EaxreverbDefaultDecayLfratio = 1,

    [NativeName("AL_EAXREVERB_MIN_REFLECTIONS_GAIN")]
    EaxreverbMinReflectionsGain = 0,

    [NativeName("AL_EAXREVERB_MAX_REFLECTIONS_GAIN")]
    EaxreverbMaxReflectionsGain = 3,

    [NativeName("AL_EAXREVERB_DEFAULT_REFLECTIONS_GAIN")]
    EaxreverbDefaultReflectionsGain = 0,

    [NativeName("AL_EAXREVERB_MIN_REFLECTIONS_DELAY")]
    EaxreverbMinReflectionsDelay = 0,

    [NativeName("AL_EAXREVERB_MAX_REFLECTIONS_DELAY")]
    EaxreverbMaxReflectionsDelay = 0,

    [NativeName("AL_EAXREVERB_DEFAULT_REFLECTIONS_DELAY")]
    EaxreverbDefaultReflectionsDelay = 0,

    [NativeName("AL_EAXREVERB_DEFAULT_REFLECTIONS_PAN_XYZ")]
    EaxreverbDefaultReflectionsPanXyz = 0,

    [NativeName("AL_EAXREVERB_MIN_LATE_REVERB_GAIN")]
    EaxreverbMinLateReverbGain = 0,

    [NativeName("AL_EAXREVERB_MAX_LATE_REVERB_GAIN")]
    EaxreverbMaxLateReverbGain = 10,

    [NativeName("AL_EAXREVERB_DEFAULT_LATE_REVERB_GAIN")]
    EaxreverbDefaultLateReverbGain = 1,

    [NativeName("AL_EAXREVERB_MIN_LATE_REVERB_DELAY")]
    EaxreverbMinLateReverbDelay = 0,

    [NativeName("AL_EAXREVERB_MAX_LATE_REVERB_DELAY")]
    EaxreverbMaxLateReverbDelay = 0,

    [NativeName("AL_EAXREVERB_DEFAULT_LATE_REVERB_DELAY")]
    EaxreverbDefaultLateReverbDelay = 0,

    [NativeName("AL_EAXREVERB_DEFAULT_LATE_REVERB_PAN_XYZ")]
    EaxreverbDefaultLateReverbPanXyz = 0,

    [NativeName("AL_EAXREVERB_MIN_ECHO_TIME")]
    EaxreverbMinEchoTime = 0,

    [NativeName("AL_EAXREVERB_MAX_ECHO_TIME")]
    EaxreverbMaxEchoTime = 0,

    [NativeName("AL_EAXREVERB_DEFAULT_ECHO_TIME")]
    EaxreverbDefaultEchoTime = 0,

    [NativeName("AL_EAXREVERB_MIN_ECHO_DEPTH")]
    EaxreverbMinEchoDepth = 0,

    [NativeName("AL_EAXREVERB_MAX_ECHO_DEPTH")]
    EaxreverbMaxEchoDepth = 1,

    [NativeName("AL_EAXREVERB_DEFAULT_ECHO_DEPTH")]
    EaxreverbDefaultEchoDepth = 0,

    [NativeName("AL_EAXREVERB_MIN_MODULATION_TIME")]
    EaxreverbMinModulationTime = 0,

    [NativeName("AL_EAXREVERB_MAX_MODULATION_TIME")]
    EaxreverbMaxModulationTime = 4,

    [NativeName("AL_EAXREVERB_DEFAULT_MODULATION_TIME")]
    EaxreverbDefaultModulationTime = 0,

    [NativeName("AL_EAXREVERB_MIN_MODULATION_DEPTH")]
    EaxreverbMinModulationDepth = 0,

    [NativeName("AL_EAXREVERB_MAX_MODULATION_DEPTH")]
    EaxreverbMaxModulationDepth = 1,

    [NativeName("AL_EAXREVERB_DEFAULT_MODULATION_DEPTH")]
    EaxreverbDefaultModulationDepth = 0,

    [NativeName("AL_EAXREVERB_MIN_AIR_ABSORPTION_GAINHF")]
    EaxreverbMinAirAbsorptionGainhf = 0,

    [NativeName("AL_EAXREVERB_MAX_AIR_ABSORPTION_GAINHF")]
    EaxreverbMaxAirAbsorptionGainhf = 1,

    [NativeName("AL_EAXREVERB_DEFAULT_AIR_ABSORPTION_GAINHF")]
    EaxreverbDefaultAirAbsorptionGainhf = 0,

    [NativeName("AL_EAXREVERB_MIN_HFREFERENCE")]
    EaxreverbMinHfreference = 1000,

    [NativeName("AL_EAXREVERB_MAX_HFREFERENCE")]
    EaxreverbMaxHfreference = 20000,

    [NativeName("AL_EAXREVERB_DEFAULT_HFREFERENCE")]
    EaxreverbDefaultHfreference = 5000,

    [NativeName("AL_EAXREVERB_MIN_LFREFERENCE")]
    EaxreverbMinLfreference = 20,

    [NativeName("AL_EAXREVERB_MAX_LFREFERENCE")]
    EaxreverbMaxLfreference = 1000,

    [NativeName("AL_EAXREVERB_DEFAULT_LFREFERENCE")]
    EaxreverbDefaultLfreference = 250,

    [NativeName("AL_EAXREVERB_MIN_ROOM_ROLLOFF_FACTOR")]
    EaxreverbMinRoomRolloffFactor = 0,

    [NativeName("AL_EAXREVERB_MAX_ROOM_ROLLOFF_FACTOR")]
    EaxreverbMaxRoomRolloffFactor = 10,

    [NativeName("AL_EAXREVERB_DEFAULT_ROOM_ROLLOFF_FACTOR")]
    EaxreverbDefaultRoomRolloffFactor = 0,

    [NativeName("AL_EAXREVERB_MIN_DECAY_HFLIMIT")]
    EaxreverbMinDecayHflimit = 0,

    [NativeName("AL_EAXREVERB_MAX_DECAY_HFLIMIT")]
    EaxreverbMaxDecayHflimit = 1,

    [NativeName("AL_EAXREVERB_DEFAULT_DECAY_HFLIMIT")]
    EaxreverbDefaultDecayHflimit = 1,

    [NativeName("AL_CHORUS_WAVEFORM_SINUSOID")]
    ChorusWaveformSinusoid = 0,

    [NativeName("AL_CHORUS_WAVEFORM_TRIANGLE")]
    ChorusWaveformTriangle = 1,

    [NativeName("AL_CHORUS_MIN_WAVEFORM")]
    ChorusMinWaveform = 0,

    [NativeName("AL_CHORUS_MAX_WAVEFORM")]
    ChorusMaxWaveform = 1,

    [NativeName("AL_CHORUS_DEFAULT_WAVEFORM")]
    ChorusDefaultWaveform = 1,

    [NativeName("AL_CHORUS_MIN_PHASE")]
    ChorusMinPhase = 4294967116,

    [NativeName("AL_CHORUS_MAX_PHASE")]
    ChorusMaxPhase = 180,

    [NativeName("AL_CHORUS_DEFAULT_PHASE")]
    ChorusDefaultPhase = 90,

    [NativeName("AL_CHORUS_MIN_RATE")]
    ChorusMinRate = 0,

    [NativeName("AL_CHORUS_MAX_RATE")]
    ChorusMaxRate = 10,

    [NativeName("AL_CHORUS_DEFAULT_RATE")]
    ChorusDefaultRate = 1,

    [NativeName("AL_CHORUS_MIN_DEPTH")]
    ChorusMinDepth = 0,

    [NativeName("AL_CHORUS_MAX_DEPTH")]
    ChorusMaxDepth = 1,

    [NativeName("AL_CHORUS_DEFAULT_DEPTH")]
    ChorusDefaultDepth = 0,

    [NativeName("AL_CHORUS_MIN_FEEDBACK")]
    ChorusMinFeedback = 0,

    [NativeName("AL_CHORUS_MAX_FEEDBACK")]
    ChorusMaxFeedback = 1,

    [NativeName("AL_CHORUS_DEFAULT_FEEDBACK")]
    ChorusDefaultFeedback = 0,

    [NativeName("AL_CHORUS_MIN_DELAY")]
    ChorusMinDelay = 0,

    [NativeName("AL_CHORUS_MAX_DELAY")]
    ChorusMaxDelay = 0,

    [NativeName("AL_CHORUS_DEFAULT_DELAY")]
    ChorusDefaultDelay = 0,

    [NativeName("AL_DISTORTION_MIN_EDGE")]
    DistortionMinEdge = 0,

    [NativeName("AL_DISTORTION_MAX_EDGE")]
    DistortionMaxEdge = 1,

    [NativeName("AL_DISTORTION_DEFAULT_EDGE")]
    DistortionDefaultEdge = 0,

    [NativeName("AL_DISTORTION_MIN_GAIN")]
    DistortionMinGain = 0,

    [NativeName("AL_DISTORTION_MAX_GAIN")]
    DistortionMaxGain = 1,

    [NativeName("AL_DISTORTION_DEFAULT_GAIN")]
    DistortionDefaultGain = 0,

    [NativeName("AL_DISTORTION_MIN_LOWPASS_CUTOFF")]
    DistortionMinLowpassCutoff = 80,

    [NativeName("AL_DISTORTION_MAX_LOWPASS_CUTOFF")]
    DistortionMaxLowpassCutoff = 24000,

    [NativeName("AL_DISTORTION_DEFAULT_LOWPASS_CUTOFF")]
    DistortionDefaultLowpassCutoff = 8000,

    [NativeName("AL_DISTORTION_MIN_EQCENTER")]
    DistortionMinEqcenter = 80,

    [NativeName("AL_DISTORTION_MAX_EQCENTER")]
    DistortionMaxEqcenter = 24000,

    [NativeName("AL_DISTORTION_DEFAULT_EQCENTER")]
    DistortionDefaultEqcenter = 3600,

    [NativeName("AL_DISTORTION_MIN_EQBANDWIDTH")]
    DistortionMinEqbandwidth = 80,

    [NativeName("AL_DISTORTION_MAX_EQBANDWIDTH")]
    DistortionMaxEqbandwidth = 24000,

    [NativeName("AL_DISTORTION_DEFAULT_EQBANDWIDTH")]
    DistortionDefaultEqbandwidth = 3600,

    [NativeName("AL_ECHO_MIN_DELAY")]
    EchoMinDelay = 0,

    [NativeName("AL_ECHO_MAX_DELAY")]
    EchoMaxDelay = 0,

    [NativeName("AL_ECHO_DEFAULT_DELAY")]
    EchoDefaultDelay = 0,

    [NativeName("AL_ECHO_MIN_LRDELAY")]
    EchoMinLrdelay = 0,

    [NativeName("AL_ECHO_MAX_LRDELAY")]
    EchoMaxLrdelay = 0,

    [NativeName("AL_ECHO_DEFAULT_LRDELAY")]
    EchoDefaultLrdelay = 0,

    [NativeName("AL_ECHO_MIN_DAMPING")]
    EchoMinDamping = 0,

    [NativeName("AL_ECHO_MAX_DAMPING")]
    EchoMaxDamping = 0,

    [NativeName("AL_ECHO_DEFAULT_DAMPING")]
    EchoDefaultDamping = 0,

    [NativeName("AL_ECHO_MIN_FEEDBACK")]
    EchoMinFeedback = 0,

    [NativeName("AL_ECHO_MAX_FEEDBACK")]
    EchoMaxFeedback = 1,

    [NativeName("AL_ECHO_DEFAULT_FEEDBACK")]
    EchoDefaultFeedback = 0,

    [NativeName("AL_ECHO_MIN_SPREAD")]
    EchoMinSpread = 0,

    [NativeName("AL_ECHO_MAX_SPREAD")]
    EchoMaxSpread = 1,

    [NativeName("AL_ECHO_DEFAULT_SPREAD")]
    EchoDefaultSpread = 0,

    [NativeName("AL_FLANGER_WAVEFORM_SINUSOID")]
    FlangerWaveformSinusoid = 0,

    [NativeName("AL_FLANGER_WAVEFORM_TRIANGLE")]
    FlangerWaveformTriangle = 1,

    [NativeName("AL_FLANGER_MIN_WAVEFORM")]
    FlangerMinWaveform = 0,

    [NativeName("AL_FLANGER_MAX_WAVEFORM")]
    FlangerMaxWaveform = 1,

    [NativeName("AL_FLANGER_DEFAULT_WAVEFORM")]
    FlangerDefaultWaveform = 1,

    [NativeName("AL_FLANGER_MIN_PHASE")]
    FlangerMinPhase = 4294967116,

    [NativeName("AL_FLANGER_MAX_PHASE")]
    FlangerMaxPhase = 180,

    [NativeName("AL_FLANGER_DEFAULT_PHASE")]
    FlangerDefaultPhase = 0,

    [NativeName("AL_FLANGER_MIN_RATE")]
    FlangerMinRate = 0,

    [NativeName("AL_FLANGER_MAX_RATE")]
    FlangerMaxRate = 10,

    [NativeName("AL_FLANGER_DEFAULT_RATE")]
    FlangerDefaultRate = 0,

    [NativeName("AL_FLANGER_MIN_DEPTH")]
    FlangerMinDepth = 0,

    [NativeName("AL_FLANGER_MAX_DEPTH")]
    FlangerMaxDepth = 1,

    [NativeName("AL_FLANGER_DEFAULT_DEPTH")]
    FlangerDefaultDepth = 1,

    [NativeName("AL_FLANGER_MIN_FEEDBACK")]
    FlangerMinFeedback = 0,

    [NativeName("AL_FLANGER_MAX_FEEDBACK")]
    FlangerMaxFeedback = 1,

    [NativeName("AL_FLANGER_DEFAULT_FEEDBACK")]
    FlangerDefaultFeedback = 0,

    [NativeName("AL_FLANGER_MIN_DELAY")]
    FlangerMinDelay = 0,

    [NativeName("AL_FLANGER_MAX_DELAY")]
    FlangerMaxDelay = 0,

    [NativeName("AL_FLANGER_DEFAULT_DELAY")]
    FlangerDefaultDelay = 0,

    [NativeName("AL_FREQUENCY_SHIFTER_MIN_FREQUENCY")]
    FrequencyShifterMinFrequency = 0,

    [NativeName("AL_FREQUENCY_SHIFTER_MAX_FREQUENCY")]
    FrequencyShifterMaxFrequency = 24000,

    [NativeName("AL_FREQUENCY_SHIFTER_DEFAULT_FREQUENCY")]
    FrequencyShifterDefaultFrequency = 0,

    [NativeName("AL_FREQUENCY_SHIFTER_MIN_LEFT_DIRECTION")]
    FrequencyShifterMinLeftDirection = 0,

    [NativeName("AL_FREQUENCY_SHIFTER_MAX_LEFT_DIRECTION")]
    FrequencyShifterMaxLeftDirection = 2,

    [NativeName("AL_FREQUENCY_SHIFTER_DEFAULT_LEFT_DIRECTION")]
    FrequencyShifterDefaultLeftDirection = 0,

    [NativeName("AL_FREQUENCY_SHIFTER_DIRECTION_DOWN")]
    FrequencyShifterDirectionDown = 0,

    [NativeName("AL_FREQUENCY_SHIFTER_DIRECTION_UP")]
    FrequencyShifterDirectionUp = 1,

    [NativeName("AL_FREQUENCY_SHIFTER_DIRECTION_OFF")]
    FrequencyShifterDirectionOff = 2,

    [NativeName("AL_FREQUENCY_SHIFTER_MIN_RIGHT_DIRECTION")]
    FrequencyShifterMinRightDirection = 0,

    [NativeName("AL_FREQUENCY_SHIFTER_MAX_RIGHT_DIRECTION")]
    FrequencyShifterMaxRightDirection = 2,

    [NativeName("AL_FREQUENCY_SHIFTER_DEFAULT_RIGHT_DIRECTION")]
    FrequencyShifterDefaultRightDirection = 0,

    [NativeName("AL_VOCAL_MORPHER_MIN_PHONEMEA")]
    VocalMorpherMinPhonemea = 0,

    [NativeName("AL_VOCAL_MORPHER_MAX_PHONEMEA")]
    VocalMorpherMaxPhonemea = 29,

    [NativeName("AL_VOCAL_MORPHER_DEFAULT_PHONEMEA")]
    VocalMorpherDefaultPhonemea = 0,

    [NativeName("AL_VOCAL_MORPHER_MIN_PHONEMEA_COARSE_TUNING")]
    VocalMorpherMinPhonemeaCoarseTuning = 4294967272,

    [NativeName("AL_VOCAL_MORPHER_MAX_PHONEMEA_COARSE_TUNING")]
    VocalMorpherMaxPhonemeaCoarseTuning = 24,

    [NativeName("AL_VOCAL_MORPHER_DEFAULT_PHONEMEA_COARSE_TUNING")]
    VocalMorpherDefaultPhonemeaCoarseTuning = 0,

    [NativeName("AL_VOCAL_MORPHER_MIN_PHONEMEB")]
    VocalMorpherMinPhonemeb = 0,

    [NativeName("AL_VOCAL_MORPHER_MAX_PHONEMEB")]
    VocalMorpherMaxPhonemeb = 29,

    [NativeName("AL_VOCAL_MORPHER_DEFAULT_PHONEMEB")]
    VocalMorpherDefaultPhonemeb = 10,

    [NativeName("AL_VOCAL_MORPHER_MIN_PHONEMEB_COARSE_TUNING")]
    VocalMorpherMinPhonemebCoarseTuning = 4294967272,

    [NativeName("AL_VOCAL_MORPHER_MAX_PHONEMEB_COARSE_TUNING")]
    VocalMorpherMaxPhonemebCoarseTuning = 24,

    [NativeName("AL_VOCAL_MORPHER_DEFAULT_PHONEMEB_COARSE_TUNING")]
    VocalMorpherDefaultPhonemebCoarseTuning = 0,

    [NativeName("AL_VOCAL_MORPHER_PHONEME_A")]
    VocalMorpherPhonemeA = 0,

    [NativeName("AL_VOCAL_MORPHER_PHONEME_E")]
    VocalMorpherPhonemeE = 1,

    [NativeName("AL_VOCAL_MORPHER_PHONEME_I")]
    VocalMorpherPhonemeI = 2,

    [NativeName("AL_VOCAL_MORPHER_PHONEME_O")]
    VocalMorpherPhonemeO = 3,

    [NativeName("AL_VOCAL_MORPHER_PHONEME_U")]
    VocalMorpherPhonemeU = 4,

    [NativeName("AL_VOCAL_MORPHER_PHONEME_AA")]
    VocalMorpherPhonemeAa = 5,

    [NativeName("AL_VOCAL_MORPHER_PHONEME_AE")]
    VocalMorpherPhonemeAe = 6,

    [NativeName("AL_VOCAL_MORPHER_PHONEME_AH")]
    VocalMorpherPhonemeAh = 7,

    [NativeName("AL_VOCAL_MORPHER_PHONEME_AO")]
    VocalMorpherPhonemeAo = 8,

    [NativeName("AL_VOCAL_MORPHER_PHONEME_EH")]
    VocalMorpherPhonemeEh = 9,

    [NativeName("AL_VOCAL_MORPHER_PHONEME_ER")]
    VocalMorpherPhonemeEr = 10,

    [NativeName("AL_VOCAL_MORPHER_PHONEME_IH")]
    VocalMorpherPhonemeIh = 11,

    [NativeName("AL_VOCAL_MORPHER_PHONEME_IY")]
    VocalMorpherPhonemeIy = 12,

    [NativeName("AL_VOCAL_MORPHER_PHONEME_UH")]
    VocalMorpherPhonemeUh = 13,

    [NativeName("AL_VOCAL_MORPHER_PHONEME_UW")]
    VocalMorpherPhonemeUw = 14,

    [NativeName("AL_VOCAL_MORPHER_PHONEME_B")]
    VocalMorpherPhonemeB = 15,

    [NativeName("AL_VOCAL_MORPHER_PHONEME_D")]
    VocalMorpherPhonemeD = 16,

    [NativeName("AL_VOCAL_MORPHER_PHONEME_F")]
    VocalMorpherPhonemeF = 17,

    [NativeName("AL_VOCAL_MORPHER_PHONEME_G")]
    VocalMorpherPhonemeG = 18,

    [NativeName("AL_VOCAL_MORPHER_PHONEME_J")]
    VocalMorpherPhonemeJ = 19,

    [NativeName("AL_VOCAL_MORPHER_PHONEME_K")]
    VocalMorpherPhonemeK = 20,

    [NativeName("AL_VOCAL_MORPHER_PHONEME_L")]
    VocalMorpherPhonemeL = 21,

    [NativeName("AL_VOCAL_MORPHER_PHONEME_M")]
    VocalMorpherPhonemeM = 22,

    [NativeName("AL_VOCAL_MORPHER_PHONEME_N")]
    VocalMorpherPhonemeN = 23,

    [NativeName("AL_VOCAL_MORPHER_PHONEME_P")]
    VocalMorpherPhonemeP = 24,

    [NativeName("AL_VOCAL_MORPHER_PHONEME_R")]
    VocalMorpherPhonemeR = 25,

    [NativeName("AL_VOCAL_MORPHER_PHONEME_S")]
    VocalMorpherPhonemeS = 26,

    [NativeName("AL_VOCAL_MORPHER_PHONEME")]
    VocalMorpherPhoneme = 27,

    [NativeName("AL_VOCAL_MORPHER_PHONEME_V")]
    VocalMorpherPhonemeV = 28,

    [NativeName("AL_VOCAL_MORPHER_PHONEME_Z")]
    VocalMorpherPhonemeZ = 29,

    [NativeName("AL_VOCAL_MORPHER_WAVEFORM_SINUSOID")]
    VocalMorpherWaveformSinusoid = 0,

    [NativeName("AL_VOCAL_MORPHER_WAVEFORM_TRIANGLE")]
    VocalMorpherWaveformTriangle = 1,

    [NativeName("AL_VOCAL_MORPHER_WAVEFORM_SAWTOOTH")]
    VocalMorpherWaveformSawtooth = 2,

    [NativeName("AL_VOCAL_MORPHER_MIN_WAVEFORM")]
    VocalMorpherMinWaveform = 0,

    [NativeName("AL_VOCAL_MORPHER_MAX_WAVEFORM")]
    VocalMorpherMaxWaveform = 2,

    [NativeName("AL_VOCAL_MORPHER_DEFAULT_WAVEFORM")]
    VocalMorpherDefaultWaveform = 0,

    [NativeName("AL_VOCAL_MORPHER_MIN_RATE")]
    VocalMorpherMinRate = 0,

    [NativeName("AL_VOCAL_MORPHER_MAX_RATE")]
    VocalMorpherMaxRate = 10,

    [NativeName("AL_VOCAL_MORPHER_DEFAULT_RATE")]
    VocalMorpherDefaultRate = 1,

    [NativeName("AL_PITCH_SHIFTER_MIN_COARSE_TUNE")]
    PitchShifterMinCoarseTune = 4294967284,

    [NativeName("AL_PITCH_SHIFTER_MAX_COARSE_TUNE")]
    PitchShifterMaxCoarseTune = 12,

    [NativeName("AL_PITCH_SHIFTER_DEFAULT_COARSE_TUNE")]
    PitchShifterDefaultCoarseTune = 12,

    [NativeName("AL_PITCH_SHIFTER_MIN_FINE_TUNE")]
    PitchShifterMinFineTune = 4294967246,

    [NativeName("AL_PITCH_SHIFTER_MAX_FINE_TUNE")]
    PitchShifterMaxFineTune = 50,

    [NativeName("AL_PITCH_SHIFTER_DEFAULT_FINE_TUNE")]
    PitchShifterDefaultFineTune = 0,

    [NativeName("AL_RING_MODULATOR_MIN_FREQUENCY")]
    RingModulatorMinFrequency = 0,

    [NativeName("AL_RING_MODULATOR_MAX_FREQUENCY")]
    RingModulatorMaxFrequency = 8000,

    [NativeName("AL_RING_MODULATOR_DEFAULT_FREQUENCY")]
    RingModulatorDefaultFrequency = 440,

    [NativeName("AL_RING_MODULATOR_MIN_HIGHPASS_CUTOFF")]
    RingModulatorMinHighpassCutoff = 0,

    [NativeName("AL_RING_MODULATOR_MAX_HIGHPASS_CUTOFF")]
    RingModulatorMaxHighpassCutoff = 24000,

    [NativeName("AL_RING_MODULATOR_DEFAULT_HIGHPASS_CUTOFF")]
    RingModulatorDefaultHighpassCutoff = 800,

    [NativeName("AL_RING_MODULATOR_SINUSOID")]
    RingModulatorSinusoid = 0,

    [NativeName("AL_RING_MODULATOR_SAWTOOTH")]
    RingModulatorSawtooth = 1,

    [NativeName("AL_RING_MODULATOR_SQUARE")]
    RingModulatorSquare = 2,

    [NativeName("AL_RING_MODULATOR_MIN_WAVEFORM")]
    RingModulatorMinWaveform = 0,

    [NativeName("AL_RING_MODULATOR_MAX_WAVEFORM")]
    RingModulatorMaxWaveform = 2,

    [NativeName("AL_RING_MODULATOR_DEFAULT_WAVEFORM")]
    RingModulatorDefaultWaveform = 0,

    [NativeName("AL_AUTOWAH_MIN_ATTACK_TIME")]
    AutowahMinAttackTime = 0,

    [NativeName("AL_AUTOWAH_MAX_ATTACK_TIME")]
    AutowahMaxAttackTime = 1,

    [NativeName("AL_AUTOWAH_DEFAULT_ATTACK_TIME")]
    AutowahDefaultAttackTime = 0,

    [NativeName("AL_AUTOWAH_MIN_RELEASE_TIME")]
    AutowahMinReleaseTime = 0,

    [NativeName("AL_AUTOWAH_MAX_RELEASE_TIME")]
    AutowahMaxReleaseTime = 1,

    [NativeName("AL_AUTOWAH_DEFAULT_RELEASE_TIME")]
    AutowahDefaultReleaseTime = 0,

    [NativeName("AL_AUTOWAH_MIN_RESONANCE")]
    AutowahMinResonance = 2,

    [NativeName("AL_AUTOWAH_MAX_RESONANCE")]
    AutowahMaxResonance = 1000,

    [NativeName("AL_AUTOWAH_DEFAULT_RESONANCE")]
    AutowahDefaultResonance = 1000,

    [NativeName("AL_AUTOWAH_MIN_PEAK_GAIN")]
    AutowahMinPeakGain = 0,

    [NativeName("AL_AUTOWAH_MAX_PEAK_GAIN")]
    AutowahMaxPeakGain = 31621,

    [NativeName("AL_AUTOWAH_DEFAULT_PEAK_GAIN")]
    AutowahDefaultPeakGain = 11,

    [NativeName("AL_COMPRESSOR_MIN_ONOFF")]
    CompressorMinOnoff = 0,

    [NativeName("AL_COMPRESSOR_MAX_ONOFF")]
    CompressorMaxOnoff = 1,

    [NativeName("AL_COMPRESSOR_DEFAULT_ONOFF")]
    CompressorDefaultOnoff = 1,

    [NativeName("AL_EQUALIZER_MIN_LOW_GAIN")]
    EqualizerMinLowGain = 0,

    [NativeName("AL_EQUALIZER_MAX_LOW_GAIN")]
    EqualizerMaxLowGain = 7,

    [NativeName("AL_EQUALIZER_DEFAULT_LOW_GAIN")]
    EqualizerDefaultLowGain = 1,

    [NativeName("AL_EQUALIZER_MIN_LOW_CUTOFF")]
    EqualizerMinLowCutoff = 50,

    [NativeName("AL_EQUALIZER_MAX_LOW_CUTOFF")]
    EqualizerMaxLowCutoff = 800,

    [NativeName("AL_EQUALIZER_DEFAULT_LOW_CUTOFF")]
    EqualizerDefaultLowCutoff = 200,

    [NativeName("AL_EQUALIZER_MIN_MID1_GAIN")]
    EqualizerMinMid1Gain = 0,

    [NativeName("AL_EQUALIZER_MAX_MID1_GAIN")]
    EqualizerMaxMid1Gain = 7,

    [NativeName("AL_EQUALIZER_DEFAULT_MID1_GAIN")]
    EqualizerDefaultMid1Gain = 1,

    [NativeName("AL_EQUALIZER_MIN_MID1_CENTER")]
    EqualizerMinMid1Center = 200,

    [NativeName("AL_EQUALIZER_MAX_MID1_CENTER")]
    EqualizerMaxMid1Center = 3000,

    [NativeName("AL_EQUALIZER_DEFAULT_MID1_CENTER")]
    EqualizerDefaultMid1Center = 500,

    [NativeName("AL_EQUALIZER_MIN_MID1_WIDTH")]
    EqualizerMinMid1Width = 0,

    [NativeName("AL_EQUALIZER_MAX_MID1_WIDTH")]
    EqualizerMaxMid1Width = 1,

    [NativeName("AL_EQUALIZER_DEFAULT_MID1_WIDTH")]
    EqualizerDefaultMid1Width = 1,

    [NativeName("AL_EQUALIZER_MIN_MID2_GAIN")]
    EqualizerMinMid2Gain = 0,

    [NativeName("AL_EQUALIZER_MAX_MID2_GAIN")]
    EqualizerMaxMid2Gain = 7,

    [NativeName("AL_EQUALIZER_DEFAULT_MID2_GAIN")]
    EqualizerDefaultMid2Gain = 1,

    [NativeName("AL_EQUALIZER_MIN_MID2_CENTER")]
    EqualizerMinMid2Center = 1000,

    [NativeName("AL_EQUALIZER_MAX_MID2_CENTER")]
    EqualizerMaxMid2Center = 8000,

    [NativeName("AL_EQUALIZER_DEFAULT_MID2_CENTER")]
    EqualizerDefaultMid2Center = 3000,

    [NativeName("AL_EQUALIZER_MIN_MID2_WIDTH")]
    EqualizerMinMid2Width = 0,

    [NativeName("AL_EQUALIZER_MAX_MID2_WIDTH")]
    EqualizerMaxMid2Width = 1,

    [NativeName("AL_EQUALIZER_DEFAULT_MID2_WIDTH")]
    EqualizerDefaultMid2Width = 1,

    [NativeName("AL_EQUALIZER_MIN_HIGH_GAIN")]
    EqualizerMinHighGain = 0,

    [NativeName("AL_EQUALIZER_MAX_HIGH_GAIN")]
    EqualizerMaxHighGain = 7,

    [NativeName("AL_EQUALIZER_DEFAULT_HIGH_GAIN")]
    EqualizerDefaultHighGain = 1,

    [NativeName("AL_EQUALIZER_MIN_HIGH_CUTOFF")]
    EqualizerMinHighCutoff = 4000,

    [NativeName("AL_EQUALIZER_MAX_HIGH_CUTOFF")]
    EqualizerMaxHighCutoff = 16000,

    [NativeName("AL_EQUALIZER_DEFAULT_HIGH_CUTOFF")]
    EqualizerDefaultHighCutoff = 6000,

    [NativeName("AL_MIN_AIR_ABSORPTION_FACTOR")]
    MinAirAbsorptionFactor = 0,

    [NativeName("AL_MAX_AIR_ABSORPTION_FACTOR")]
    MaxAirAbsorptionFactor = 10,

    [NativeName("AL_DEFAULT_AIR_ABSORPTION_FACTOR")]
    DefaultAirAbsorptionFactor = 0,

    [NativeName("AL_MIN_ROOM_ROLLOFF_FACTOR")]
    MinRoomRolloffFactor = 0,

    [NativeName("AL_MAX_ROOM_ROLLOFF_FACTOR")]
    MaxRoomRolloffFactor = 10,

    [NativeName("AL_DEFAULT_ROOM_ROLLOFF_FACTOR")]
    DefaultRoomRolloffFactor = 0,

    [NativeName("AL_MIN_CONE_OUTER_GAINHF")]
    MinConeOuterGainhf = 0,

    [NativeName("AL_MAX_CONE_OUTER_GAINHF")]
    MaxConeOuterGainhf = 1,

    [NativeName("AL_DEFAULT_CONE_OUTER_GAINHF")]
    DefaultConeOuterGainhf = 1,

    [NativeName("AL_MIN_DIRECT_FILTER_GAINHF_AUTO")]
    MinDirectFilterGainhfAuto = 0,

    [NativeName("AL_MAX_DIRECT_FILTER_GAINHF_AUTO")]
    MaxDirectFilterGainhfAuto = 1,

    [NativeName("AL_DEFAULT_DIRECT_FILTER_GAINHF_AUTO")]
    DefaultDirectFilterGainhfAuto = 1,

    [NativeName("AL_MIN_AUXILIARY_SEND_FILTER_GAIN_AUTO")]
    MinAuxiliarySendFilterGainAuto = 0,

    [NativeName("AL_MAX_AUXILIARY_SEND_FILTER_GAIN_AUTO")]
    MaxAuxiliarySendFilterGainAuto = 1,

    [NativeName("AL_DEFAULT_AUXILIARY_SEND_FILTER_GAIN_AUTO")]
    DefaultAuxiliarySendFilterGainAuto = 1,

    [NativeName("AL_MIN_AUXILIARY_SEND_FILTER_GAINHF_AUTO")]
    MinAuxiliarySendFilterGainhfAuto = 0,

    [NativeName("AL_MAX_AUXILIARY_SEND_FILTER_GAINHF_AUTO")]
    MaxAuxiliarySendFilterGainhfAuto = 1,

    [NativeName("AL_DEFAULT_AUXILIARY_SEND_FILTER_GAINHF_AUTO")]
    DefaultAuxiliarySendFilterGainhfAuto = 1,

    [NativeName("AL_MIN_METERS_PER_UNIT")]
    MinMetersPerUnit = 0,

    [NativeName("AL_MAX_METERS_PER_UNIT")]
    MaxMetersPerUnit = 0,

    [NativeName("AL_DEFAULT_METERS_PER_UNIT")]
    DefaultMetersPerUnit = 1,

    [NativeName("AL_SOURCE_DISTANCE_MODEL")]
    SourceDistanceModel = 512,

    [NativeName("AL_BYTE_RW_OFFSETS_SOFT")]
    ByteRwOffsetsSOFT = 4145,

    [NativeName("AL_SAMPLE_RW_OFFSETS_SOFT")]
    SampleRwOffsetsSOFT = 4146,

    [NativeName("AL_LOOP_POINTS_SOFT")]
    LoopPointsSOFT = 8213,

    [NativeName("AL_FOLDBACK_EVENT_BLOCK")]
    FoldbackEventBlock = 16658,

    [NativeName("AL_FOLDBACK_EVENT_START")]
    FoldbackEventStart = 16657,

    [NativeName("AL_FOLDBACK_EVENT_STOP")]
    FoldbackEventStop = 16659,

    [NativeName("AL_FOLDBACK_MODE_MONO")]
    FoldbackModeMono = 16641,

    [NativeName("AL_FOLDBACK_MODE_STEREO")]
    FoldbackModeStereo = 16642,

    [NativeName("AL_DEDICATED_GAIN")]
    DedicatedGain = 1,

    [NativeName("AL_EFFECT_DEDICATED_DIALOGUE")]
    EffectDedicatedDialogue = 36865,

    [NativeName("AL_EFFECT_DEDICATED_LOW_FREQUENCY_EFFECT")]
    EffectDedicatedLowFrequencyEffect = 36864,

    [NativeName("AL_MONO_SOFT")]
    MonoSOFT = 5376,

    [NativeName("AL_STEREO_SOFT")]
    StereoSOFT = 5377,

    [NativeName("AL_REAR_SOFT")]
    RearSOFT = 5378,

    [NativeName("AL_QUAD_SOFT")]
    QuadSOFT = 5379,

    [NativeName("AL_5POINT1_SOFT")]
    X5Point1SOFT = 5380,

    [NativeName("AL_6POINT1_SOFT")]
    X6Point1SOFT = 5381,

    [NativeName("AL_7POINT1_SOFT")]
    X7Point1SOFT = 5382,

    [NativeName("AL_BYTE_SOFT")]
    ByteSOFT = 5120,

    [NativeName("AL_UNSIGNED_BYTE_SOFT")]
    UnsignedByteSOFT = 5121,

    [NativeName("AL_SHORT_SOFT")]
    ShortSOFT = 5122,

    [NativeName("AL_UNSIGNED_SHORT_SOFT")]
    UnsignedShortSOFT = 5123,

    [NativeName("AL_INT_SOFT")]
    IntSOFT = 5124,

    [NativeName("AL_UNSIGNED_INT_SOFT")]
    UnsignedIntSOFT = 5125,

    [NativeName("AL_FLOAT_SOFT")]
    FloatSOFT = 5126,

    [NativeName("AL_DOUBLE_SOFT")]
    DoubleSOFT = 5127,

    [NativeName("AL_BYTE3_SOFT")]
    Byte3SOFT = 5128,

    [NativeName("AL_UNSIGNED_BYTE3_SOFT")]
    UnsignedByte3SOFT = 5129,

    [NativeName("AL_MONO8_SOFT")]
    Mono8SOFT = 4352,

    [NativeName("AL_MONO16_SOFT")]
    Mono16SOFT = 4353,

    [NativeName("AL_MONO32F_SOFT")]
    Mono32FSOFT = 65552,

    [NativeName("AL_STEREO8_SOFT")]
    Stereo8SOFT = 4354,

    [NativeName("AL_STEREO16_SOFT")]
    Stereo16SOFT = 4355,

    [NativeName("AL_STEREO32F_SOFT")]
    Stereo32FSOFT = 65553,

    [NativeName("AL_QUAD8_SOFT")]
    Quad8SOFT = 4612,

    [NativeName("AL_QUAD16_SOFT")]
    Quad16SOFT = 4613,

    [NativeName("AL_QUAD32F_SOFT")]
    Quad32FSOFT = 4614,

    [NativeName("AL_REAR8_SOFT")]
    Rear8SOFT = 4615,

    [NativeName("AL_REAR16_SOFT")]
    Rear16SOFT = 4616,

    [NativeName("AL_REAR32F_SOFT")]
    Rear32FSOFT = 4617,

    [NativeName("AL_5POINT1_8_SOFT")]
    X5Point1X8SOFT = 4618,

    [NativeName("AL_5POINT1_16_SOFT")]
    X5Point1X16SOFT = 4619,

    [NativeName("AL_5POINT1_32F_SOFT")]
    X5Point1X32FSOFT = 4620,

    [NativeName("AL_6POINT1_8_SOFT")]
    X6Point1X8SOFT = 4621,

    [NativeName("AL_6POINT1_16_SOFT")]
    X6Point1X16SOFT = 4622,

    [NativeName("AL_6POINT1_32F_SOFT")]
    X6Point1X32FSOFT = 4623,

    [NativeName("AL_7POINT1_8_SOFT")]
    X7Point1X8SOFT = 4624,

    [NativeName("AL_7POINT1_16_SOFT")]
    X7Point1X16SOFT = 4625,

    [NativeName("AL_7POINT1_32F_SOFT")]
    X7Point1X32FSOFT = 4626,

    [NativeName("AL_INTERNAL_FORMAT_SOFT")]
    InternalFormatSOFT = 8200,

    [NativeName("AL_BYTE_LENGTH_SOFT")]
    ByteLengthSOFT = 8201,

    [NativeName("AL_SAMPLE_LENGTH_SOFT")]
    SampleLengthSOFT = 8202,

    [NativeName("AL_SEC_LENGTH_SOFT")]
    SecLengthSOFT = 8203,

    [NativeName("AL_DIRECT_CHANNELS_SOFT")]
    DirectChannelsSOFT = 4147,

    [NativeName("AL_STEREO_ANGLES")]
    StereoAngles = 4144,

    [NativeName("AL_SOURCE_RADIUS")]
    SourceRadius = 4145,

    [NativeName("AL_SAMPLE_OFFSET_LATENCY_SOFT")]
    SampleOffsetLatencySOFT = 4608,

    [NativeName("AL_SEC_OFFSET_LATENCY_SOFT")]
    SecOffsetLatencySOFT = 4609,

    [NativeName("AL_DEFERRED_UPDATES_SOFT")]
    DeferredUpdatesSOFT = 49154,

    [NativeName("AL_UNPACK_BLOCK_ALIGNMENT_SOFT")]
    UnpackBlockAlignmentSOFT = 8204,

    [NativeName("AL_PACK_BLOCK_ALIGNMENT_SOFT")]
    PackBlockAlignmentSOFT = 8205,

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

    [NativeName("AL_GAIN_LIMIT_SOFT")]
    GainLimitSOFT = 8206,

    [NativeName("AL_NUM_RESAMPLERS_SOFT")]
    NumResamplersSOFT = 4624,

    [NativeName("AL_DEFAULT_RESAMPLER_SOFT")]
    DefaultResamplerSOFT = 4625,

    [NativeName("AL_SOURCE_RESAMPLER_SOFT")]
    SourceResamplerSOFT = 4626,

    [NativeName("AL_RESAMPLER_NAME_SOFT")]
    ResamplerNameSOFT = 4627,

    [NativeName("AL_SOURCE_SPATIALIZE_SOFT")]
    SourceSpatializeSOFT = 4628,

    [NativeName("AL_AUTO_SOFT")]
    AutoSOFT = 2,

    [NativeName("AL_SAMPLE_OFFSET_CLOCK_SOFT")]
    SampleOffsetClockSOFT = 4610,

    [NativeName("AL_SEC_OFFSET_CLOCK_SOFT")]
    SecOffsetClockSOFT = 4611,

    [NativeName("AL_DROP_UNMATCHED_SOFT")]
    DropUnmatchedSOFT = 1,

    [NativeName("AL_REMIX_UNMATCHED_SOFT")]
    RemixUnmatchedSOFT = 2,

    [NativeName("AL_AMBISONIC_LAYOUT_SOFT")]
    AmbisonicLayoutSOFT = 6551,

    [NativeName("AL_AMBISONIC_SCALING_SOFT")]
    AmbisonicScalingSOFT = 6552,

    [NativeName("AL_FUMA_SOFT")]
    FumaSOFT = 0,

    [NativeName("AL_ACN_SOFT")]
    AcnSOFT = 1,

    [NativeName("AL_SN3D_SOFT")]
    Sn3DSOFT = 1,

    [NativeName("AL_N3D_SOFT")]
    N3DSOFT = 2,

    [NativeName("AL_EFFECTSLOT_TARGET_SOFT")]
    EffectslotTargetSOFT = 6556,

    [NativeName("AL_EVENT_CALLBACK_FUNCTION_SOFT")]
    EventCallbackFunctionSOFT = 6562,

    [NativeName("AL_EVENT_CALLBACK_USER_PARAM_SOFT")]
    EventCallbackUserParamSOFT = 6563,

    [NativeName("AL_EVENT_TYPE_BUFFER_COMPLETED_SOFT")]
    EventTypeBufferCompletedSOFT = 6564,

    [NativeName("AL_EVENT_TYPE_SOURCE_STATE_CHANGED_SOFT")]
    EventTypeSourceStateChangedSOFT = 6565,

    [NativeName("AL_EVENT_TYPE_DISCONNECTED_SOFT")]
    EventTypeDisconnectedSOFT = 6566,

    [NativeName("AL_BUFFER_CALLBACK_FUNCTION_SOFT")]
    BufferCallbackFunctionSOFT = 6560,

    [NativeName("AL_BUFFER_CALLBACK_USER_PARAM_SOFT")]
    BufferCallbackUserParamSOFT = 6561,

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

    [NativeName("AL_STEREO_MODE_SOFT")]
    StereoModeSOFT = 6576,

    [NativeName("AL_NORMAL_SOFT")]
    NormalSOFT = 0,

    [NativeName("AL_SUPER_STEREO_SOFT")]
    SuperStereoSOFT = 1,

    [NativeName("AL_SUPER_STEREO_WIDTH_SOFT")]
    SuperStereoWidthSOFT = 6577,

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

    [NativeName("AL_DONT_CARE_EXT")]
    DontCareEXT = 2,

    [NativeName("AL_DEBUG_OUTPUT_EXT")]
    DebugOutputEXT = 6578,

    [NativeName("AL_DEBUG_CALLBACK_FUNCTION_EXT")]
    DebugCallbackFunctionEXT = 6579,

    [NativeName("AL_DEBUG_CALLBACK_USER_PARAM_EXT")]
    DebugCallbackUserParamEXT = 6580,

    [NativeName("AL_DEBUG_SOURCE_API_EXT")]
    DebugSourceApiEXT = 6581,

    [NativeName("AL_DEBUG_SOURCE_AUDIO_SYSTEM_EXT")]
    DebugSourceAudioSystemEXT = 6582,

    [NativeName("AL_DEBUG_SOURCE_THIRD_PARTY_EXT")]
    DebugSourceThirdPartyEXT = 6583,

    [NativeName("AL_DEBUG_SOURCE_APPLICATION_EXT")]
    DebugSourceApplicationEXT = 6584,

    [NativeName("AL_DEBUG_SOURCE_OTHER_EXT")]
    DebugSourceOtherEXT = 6585,

    [NativeName("AL_DEBUG_TYPE_ERROR_EXT")]
    DebugTypeErrorEXT = 6586,

    [NativeName("AL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_EXT")]
    DebugTypeDeprecatedBehaviorEXT = 6587,

    [NativeName("AL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_EXT")]
    DebugTypeUndefinedBehaviorEXT = 6588,

    [NativeName("AL_DEBUG_TYPE_PORTABILITY_EXT")]
    DebugTypePortabilityEXT = 6589,

    [NativeName("AL_DEBUG_TYPE_PERFORMANCE_EXT")]
    DebugTypePerformanceEXT = 6590,

    [NativeName("AL_DEBUG_TYPE_MARKER_EXT")]
    DebugTypeMarkerEXT = 6591,

    [NativeName("AL_DEBUG_TYPE_PUSH_GROUP_EXT")]
    DebugTypePushGroupEXT = 6592,

    [NativeName("AL_DEBUG_TYPE_POP_GROUP_EXT")]
    DebugTypePopGroupEXT = 6593,

    [NativeName("AL_DEBUG_TYPE_OTHER_EXT")]
    DebugTypeOtherEXT = 6594,

    [NativeName("AL_DEBUG_SEVERITY_HIGH_EXT")]
    DebugSeverityHighEXT = 6595,

    [NativeName("AL_DEBUG_SEVERITY_MEDIUM_EXT")]
    DebugSeverityMediumEXT = 6596,

    [NativeName("AL_DEBUG_SEVERITY_LOW_EXT")]
    DebugSeverityLowEXT = 6597,

    [NativeName("AL_DEBUG_SEVERITY_NOTIFICATION_EXT")]
    DebugSeverityNotificationEXT = 6598,

    [NativeName("AL_DEBUG_LOGGED_MESSAGES_EXT")]
    DebugLoggedMessagesEXT = 6599,

    [NativeName("AL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_EXT")]
    DebugNextLoggedMessageLengthEXT = 6600,

    [NativeName("AL_MAX_DEBUG_MESSAGE_LENGTH_EXT")]
    MaxDebugMessageLengthEXT = 6601,

    [NativeName("AL_MAX_DEBUG_LOGGED_MESSAGES_EXT")]
    MaxDebugLoggedMessagesEXT = 6602,

    [NativeName("AL_MAX_DEBUG_GROUP_STACK_DEPTH_EXT")]
    MaxDebugGroupStackDepthEXT = 6603,

    [NativeName("AL_MAX_LABEL_LENGTH_EXT")]
    MaxLabelLengthEXT = 6604,

    [NativeName("AL_STACK_OVERFLOW_EXT")]
    StackOverflowEXT = 6605,

    [NativeName("AL_STACK_UNDERFLOW_EXT")]
    StackUnderflowEXT = 6606,

    [NativeName("AL_CONTEXT_FLAGS_EXT")]
    ContextFlagsEXT = 6607,

    [NativeName("AL_BUFFER_EXT")]
    BufferEXT = 4105,

    [NativeName("AL_SOURCE_EXT")]
    SourceEXT = 6608,

    [NativeName("AL_FILTER_EXT")]
    FilterEXT = 6609,

    [NativeName("AL_EFFECT_EXT")]
    EffectEXT = 6610,

    [NativeName("AL_AUXILIARY_EFFECT_SLOT_EXT")]
    AuxiliaryEffectSlotEXT = 6611,

    [NativeName("AL_UNPACK_AMBISONIC_ORDER_SOFT")]
    UnpackAmbisonicOrderSOFT = 6557,

    [NativeName("ALC_DEFAULT_FILTER_ORDER")]
    CDefaultFilterOrder = 4352,
}
