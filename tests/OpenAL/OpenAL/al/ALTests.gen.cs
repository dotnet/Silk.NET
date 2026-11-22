// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Generated using the OpenAL Soft headers and corresponding dependencies.
// Original source is licensed under the LGPL 2.0 license. Please note that while bindings are able to be MIT due to
// being header-derived only, implementations of the headers may have a less permissive license.
using System;
using NUnit.Framework;
using static Silk.NET.OpenAL.AL;

namespace Silk.NET.OpenAL.UnitTests;

/// <summary>Provides validation of the <see cref = "AL"/> class.</summary>
public static unsafe partial class ALTests
{
    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_GENERIC_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_GENERIC_Test()
    {
        Assert.That(EFX_REVERB_PRESET_GENERIC_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_GENERIC_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_GENERIC_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_GENERIC_.flGainHF, Is.EqualTo(0.8913f));
        Assert.That(EFX_REVERB_PRESET_GENERIC_.flGainLF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_GENERIC_.flDecayTime, Is.EqualTo(1.4900f));
        Assert.That(EFX_REVERB_PRESET_GENERIC_.flDecayHFRatio, Is.EqualTo(0.8300f));
        Assert.That(EFX_REVERB_PRESET_GENERIC_.flDecayLFRatio, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_GENERIC_.flReflectionsGain, Is.EqualTo(0.0500f));
        Assert.That(EFX_REVERB_PRESET_GENERIC_.flReflectionsDelay, Is.EqualTo(0.0070f));
        Assert.That(
            EFX_REVERB_PRESET_GENERIC_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_GENERIC_.flLateReverbGain, Is.EqualTo(1.2589f));
        Assert.That(EFX_REVERB_PRESET_GENERIC_.flLateReverbDelay, Is.EqualTo(0.0110f));
        Assert.That(
            EFX_REVERB_PRESET_GENERIC_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_GENERIC_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_GENERIC_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_GENERIC_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_GENERIC_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_GENERIC_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_GENERIC_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_GENERIC_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_GENERIC_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_GENERIC_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_PADDED_CELL_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_PADDED_CELL_Test()
    {
        Assert.That(EFX_REVERB_PRESET_PADDED_CELL_.flDensity, Is.EqualTo(0.1715f));
        Assert.That(EFX_REVERB_PRESET_PADDED_CELL_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_PADDED_CELL_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_PADDED_CELL_.flGainHF, Is.EqualTo(0.0010f));
        Assert.That(EFX_REVERB_PRESET_PADDED_CELL_.flGainLF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_PADDED_CELL_.flDecayTime, Is.EqualTo(0.1700f));
        Assert.That(EFX_REVERB_PRESET_PADDED_CELL_.flDecayHFRatio, Is.EqualTo(0.1000f));
        Assert.That(EFX_REVERB_PRESET_PADDED_CELL_.flDecayLFRatio, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_PADDED_CELL_.flReflectionsGain, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_PADDED_CELL_.flReflectionsDelay, Is.EqualTo(0.0010f));
        Assert.That(
            EFX_REVERB_PRESET_PADDED_CELL_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_PADDED_CELL_.flLateReverbGain, Is.EqualTo(1.2691f));
        Assert.That(EFX_REVERB_PRESET_PADDED_CELL_.flLateReverbDelay, Is.EqualTo(0.0020f));
        Assert.That(
            EFX_REVERB_PRESET_PADDED_CELL_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_PADDED_CELL_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_PADDED_CELL_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PADDED_CELL_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_PADDED_CELL_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PADDED_CELL_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_PADDED_CELL_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_PADDED_CELL_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_PADDED_CELL_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PADDED_CELL_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_ROOM_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_ROOM_Test()
    {
        Assert.That(EFX_REVERB_PRESET_ROOM_.flDensity, Is.EqualTo(0.4287f));
        Assert.That(EFX_REVERB_PRESET_ROOM_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_ROOM_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_ROOM_.flGainHF, Is.EqualTo(0.5929f));
        Assert.That(EFX_REVERB_PRESET_ROOM_.flGainLF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_ROOM_.flDecayTime, Is.EqualTo(0.4000f));
        Assert.That(EFX_REVERB_PRESET_ROOM_.flDecayHFRatio, Is.EqualTo(0.8300f));
        Assert.That(EFX_REVERB_PRESET_ROOM_.flDecayLFRatio, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_ROOM_.flReflectionsGain, Is.EqualTo(0.1503f));
        Assert.That(EFX_REVERB_PRESET_ROOM_.flReflectionsDelay, Is.EqualTo(0.0020f));
        Assert.That(
            EFX_REVERB_PRESET_ROOM_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_ROOM_.flLateReverbGain, Is.EqualTo(1.0629f));
        Assert.That(EFX_REVERB_PRESET_ROOM_.flLateReverbDelay, Is.EqualTo(0.0030f));
        Assert.That(
            EFX_REVERB_PRESET_ROOM_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_ROOM_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_ROOM_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_ROOM_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_ROOM_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_ROOM_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_ROOM_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_ROOM_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_ROOM_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_ROOM_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_BATHROOM_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_BATHROOM_Test()
    {
        Assert.That(EFX_REVERB_PRESET_BATHROOM_.flDensity, Is.EqualTo(0.1715f));
        Assert.That(EFX_REVERB_PRESET_BATHROOM_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_BATHROOM_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_BATHROOM_.flGainHF, Is.EqualTo(0.2512f));
        Assert.That(EFX_REVERB_PRESET_BATHROOM_.flGainLF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_BATHROOM_.flDecayTime, Is.EqualTo(1.4900f));
        Assert.That(EFX_REVERB_PRESET_BATHROOM_.flDecayHFRatio, Is.EqualTo(0.5400f));
        Assert.That(EFX_REVERB_PRESET_BATHROOM_.flDecayLFRatio, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_BATHROOM_.flReflectionsGain, Is.EqualTo(0.6531f));
        Assert.That(EFX_REVERB_PRESET_BATHROOM_.flReflectionsDelay, Is.EqualTo(0.0070f));
        Assert.That(
            EFX_REVERB_PRESET_BATHROOM_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_BATHROOM_.flLateReverbGain, Is.EqualTo(3.2734f));
        Assert.That(EFX_REVERB_PRESET_BATHROOM_.flLateReverbDelay, Is.EqualTo(0.0110f));
        Assert.That(
            EFX_REVERB_PRESET_BATHROOM_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_BATHROOM_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_BATHROOM_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_BATHROOM_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_BATHROOM_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_BATHROOM_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_BATHROOM_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_BATHROOM_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_BATHROOM_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_BATHROOM_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_LIVING_ROOM_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_LIVING_ROOM_Test()
    {
        Assert.That(EFX_REVERB_PRESET_LIVING_ROOM_.flDensity, Is.EqualTo(0.9766f));
        Assert.That(EFX_REVERB_PRESET_LIVING_ROOM_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_LIVING_ROOM_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_LIVING_ROOM_.flGainHF, Is.EqualTo(0.0010f));
        Assert.That(EFX_REVERB_PRESET_LIVING_ROOM_.flGainLF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_LIVING_ROOM_.flDecayTime, Is.EqualTo(0.5000f));
        Assert.That(EFX_REVERB_PRESET_LIVING_ROOM_.flDecayHFRatio, Is.EqualTo(0.1000f));
        Assert.That(EFX_REVERB_PRESET_LIVING_ROOM_.flDecayLFRatio, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_LIVING_ROOM_.flReflectionsGain, Is.EqualTo(0.2051f));
        Assert.That(EFX_REVERB_PRESET_LIVING_ROOM_.flReflectionsDelay, Is.EqualTo(0.0030f));
        Assert.That(
            EFX_REVERB_PRESET_LIVING_ROOM_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_LIVING_ROOM_.flLateReverbGain, Is.EqualTo(0.2805f));
        Assert.That(EFX_REVERB_PRESET_LIVING_ROOM_.flLateReverbDelay, Is.EqualTo(0.0040f));
        Assert.That(
            EFX_REVERB_PRESET_LIVING_ROOM_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_LIVING_ROOM_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_LIVING_ROOM_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_LIVING_ROOM_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_LIVING_ROOM_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_LIVING_ROOM_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_LIVING_ROOM_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_LIVING_ROOM_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_LIVING_ROOM_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_LIVING_ROOM_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_STONE_ROOM_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_STONE_ROOM_Test()
    {
        Assert.That(EFX_REVERB_PRESET_STONE_ROOM_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_STONE_ROOM_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_STONE_ROOM_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_STONE_ROOM_.flGainHF, Is.EqualTo(0.7079f));
        Assert.That(EFX_REVERB_PRESET_STONE_ROOM_.flGainLF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_STONE_ROOM_.flDecayTime, Is.EqualTo(2.3100f));
        Assert.That(EFX_REVERB_PRESET_STONE_ROOM_.flDecayHFRatio, Is.EqualTo(0.6400f));
        Assert.That(EFX_REVERB_PRESET_STONE_ROOM_.flDecayLFRatio, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_STONE_ROOM_.flReflectionsGain, Is.EqualTo(0.4411f));
        Assert.That(EFX_REVERB_PRESET_STONE_ROOM_.flReflectionsDelay, Is.EqualTo(0.0120f));
        Assert.That(
            EFX_REVERB_PRESET_STONE_ROOM_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_STONE_ROOM_.flLateReverbGain, Is.EqualTo(1.1003f));
        Assert.That(EFX_REVERB_PRESET_STONE_ROOM_.flLateReverbDelay, Is.EqualTo(0.0170f));
        Assert.That(
            EFX_REVERB_PRESET_STONE_ROOM_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_STONE_ROOM_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_STONE_ROOM_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_STONE_ROOM_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_STONE_ROOM_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_STONE_ROOM_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_STONE_ROOM_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_STONE_ROOM_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_STONE_ROOM_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_STONE_ROOM_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_AUDITORIUM_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_AUDITORIUM_Test()
    {
        Assert.That(EFX_REVERB_PRESET_AUDITORIUM_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_AUDITORIUM_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_AUDITORIUM_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_AUDITORIUM_.flGainHF, Is.EqualTo(0.5781f));
        Assert.That(EFX_REVERB_PRESET_AUDITORIUM_.flGainLF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_AUDITORIUM_.flDecayTime, Is.EqualTo(4.3200f));
        Assert.That(EFX_REVERB_PRESET_AUDITORIUM_.flDecayHFRatio, Is.EqualTo(0.5900f));
        Assert.That(EFX_REVERB_PRESET_AUDITORIUM_.flDecayLFRatio, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_AUDITORIUM_.flReflectionsGain, Is.EqualTo(0.4032f));
        Assert.That(EFX_REVERB_PRESET_AUDITORIUM_.flReflectionsDelay, Is.EqualTo(0.0200f));
        Assert.That(
            EFX_REVERB_PRESET_AUDITORIUM_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_AUDITORIUM_.flLateReverbGain, Is.EqualTo(0.7170f));
        Assert.That(EFX_REVERB_PRESET_AUDITORIUM_.flLateReverbDelay, Is.EqualTo(0.0300f));
        Assert.That(
            EFX_REVERB_PRESET_AUDITORIUM_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_AUDITORIUM_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_AUDITORIUM_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_AUDITORIUM_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_AUDITORIUM_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_AUDITORIUM_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_AUDITORIUM_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_AUDITORIUM_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_AUDITORIUM_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_AUDITORIUM_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_CONCERT_HALL_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_CONCERT_HALL_Test()
    {
        Assert.That(EFX_REVERB_PRESET_CONCERT_HALL_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CONCERT_HALL_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CONCERT_HALL_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_CONCERT_HALL_.flGainHF, Is.EqualTo(0.5623f));
        Assert.That(EFX_REVERB_PRESET_CONCERT_HALL_.flGainLF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CONCERT_HALL_.flDecayTime, Is.EqualTo(3.9200f));
        Assert.That(EFX_REVERB_PRESET_CONCERT_HALL_.flDecayHFRatio, Is.EqualTo(0.7000f));
        Assert.That(EFX_REVERB_PRESET_CONCERT_HALL_.flDecayLFRatio, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CONCERT_HALL_.flReflectionsGain, Is.EqualTo(0.2427f));
        Assert.That(EFX_REVERB_PRESET_CONCERT_HALL_.flReflectionsDelay, Is.EqualTo(0.0200f));
        Assert.That(
            EFX_REVERB_PRESET_CONCERT_HALL_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CONCERT_HALL_.flLateReverbGain, Is.EqualTo(0.9977f));
        Assert.That(EFX_REVERB_PRESET_CONCERT_HALL_.flLateReverbDelay, Is.EqualTo(0.0290f));
        Assert.That(
            EFX_REVERB_PRESET_CONCERT_HALL_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CONCERT_HALL_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_CONCERT_HALL_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CONCERT_HALL_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_CONCERT_HALL_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CONCERT_HALL_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_CONCERT_HALL_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_CONCERT_HALL_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_CONCERT_HALL_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CONCERT_HALL_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_CAVE_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_CAVE_Test()
    {
        Assert.That(EFX_REVERB_PRESET_CAVE_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CAVE_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CAVE_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_CAVE_.flGainHF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CAVE_.flGainLF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CAVE_.flDecayTime, Is.EqualTo(2.9100f));
        Assert.That(EFX_REVERB_PRESET_CAVE_.flDecayHFRatio, Is.EqualTo(1.3000f));
        Assert.That(EFX_REVERB_PRESET_CAVE_.flDecayLFRatio, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CAVE_.flReflectionsGain, Is.EqualTo(0.5000f));
        Assert.That(EFX_REVERB_PRESET_CAVE_.flReflectionsDelay, Is.EqualTo(0.0150f));
        Assert.That(
            EFX_REVERB_PRESET_CAVE_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CAVE_.flLateReverbGain, Is.EqualTo(0.7063f));
        Assert.That(EFX_REVERB_PRESET_CAVE_.flLateReverbDelay, Is.EqualTo(0.0220f));
        Assert.That(
            EFX_REVERB_PRESET_CAVE_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CAVE_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_CAVE_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CAVE_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_CAVE_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CAVE_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_CAVE_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_CAVE_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_CAVE_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CAVE_.iDecayHFLimit, Is.EqualTo(0x0));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_ARENA_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_ARENA_Test()
    {
        Assert.That(EFX_REVERB_PRESET_ARENA_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_ARENA_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_ARENA_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_ARENA_.flGainHF, Is.EqualTo(0.4477f));
        Assert.That(EFX_REVERB_PRESET_ARENA_.flGainLF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_ARENA_.flDecayTime, Is.EqualTo(7.2400f));
        Assert.That(EFX_REVERB_PRESET_ARENA_.flDecayHFRatio, Is.EqualTo(0.3300f));
        Assert.That(EFX_REVERB_PRESET_ARENA_.flDecayLFRatio, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_ARENA_.flReflectionsGain, Is.EqualTo(0.2612f));
        Assert.That(EFX_REVERB_PRESET_ARENA_.flReflectionsDelay, Is.EqualTo(0.0200f));
        Assert.That(
            EFX_REVERB_PRESET_ARENA_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_ARENA_.flLateReverbGain, Is.EqualTo(1.0186f));
        Assert.That(EFX_REVERB_PRESET_ARENA_.flLateReverbDelay, Is.EqualTo(0.0300f));
        Assert.That(
            EFX_REVERB_PRESET_ARENA_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_ARENA_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_ARENA_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_ARENA_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_ARENA_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_ARENA_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_ARENA_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_ARENA_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_ARENA_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_ARENA_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_HANGAR_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_HANGAR_Test()
    {
        Assert.That(EFX_REVERB_PRESET_HANGAR_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_HANGAR_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_HANGAR_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_HANGAR_.flGainHF, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_HANGAR_.flGainLF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_HANGAR_.flDecayTime, Is.EqualTo(10.0500f));
        Assert.That(EFX_REVERB_PRESET_HANGAR_.flDecayHFRatio, Is.EqualTo(0.2300f));
        Assert.That(EFX_REVERB_PRESET_HANGAR_.flDecayLFRatio, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_HANGAR_.flReflectionsGain, Is.EqualTo(0.5000f));
        Assert.That(EFX_REVERB_PRESET_HANGAR_.flReflectionsDelay, Is.EqualTo(0.0200f));
        Assert.That(
            EFX_REVERB_PRESET_HANGAR_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_HANGAR_.flLateReverbGain, Is.EqualTo(1.2560f));
        Assert.That(EFX_REVERB_PRESET_HANGAR_.flLateReverbDelay, Is.EqualTo(0.0300f));
        Assert.That(
            EFX_REVERB_PRESET_HANGAR_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_HANGAR_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_HANGAR_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_HANGAR_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_HANGAR_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_HANGAR_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_HANGAR_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_HANGAR_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_HANGAR_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_HANGAR_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_CARPETED_HALLWAY_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_CARPETED_HALLWAY_Test()
    {
        Assert.That(EFX_REVERB_PRESET_CARPETED_HALLWAY_.flDensity, Is.EqualTo(0.4287f));
        Assert.That(EFX_REVERB_PRESET_CARPETED_HALLWAY_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CARPETED_HALLWAY_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_CARPETED_HALLWAY_.flGainHF, Is.EqualTo(0.0100f));
        Assert.That(EFX_REVERB_PRESET_CARPETED_HALLWAY_.flGainLF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CARPETED_HALLWAY_.flDecayTime, Is.EqualTo(0.3000f));
        Assert.That(EFX_REVERB_PRESET_CARPETED_HALLWAY_.flDecayHFRatio, Is.EqualTo(0.1000f));
        Assert.That(EFX_REVERB_PRESET_CARPETED_HALLWAY_.flDecayLFRatio, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CARPETED_HALLWAY_.flReflectionsGain, Is.EqualTo(0.1215f));
        Assert.That(EFX_REVERB_PRESET_CARPETED_HALLWAY_.flReflectionsDelay, Is.EqualTo(0.0020f));
        Assert.That(
            EFX_REVERB_PRESET_CARPETED_HALLWAY_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CARPETED_HALLWAY_.flLateReverbGain, Is.EqualTo(0.1531f));
        Assert.That(EFX_REVERB_PRESET_CARPETED_HALLWAY_.flLateReverbDelay, Is.EqualTo(0.0300f));
        Assert.That(
            EFX_REVERB_PRESET_CARPETED_HALLWAY_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CARPETED_HALLWAY_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_CARPETED_HALLWAY_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CARPETED_HALLWAY_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_CARPETED_HALLWAY_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CARPETED_HALLWAY_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_CARPETED_HALLWAY_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_CARPETED_HALLWAY_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_CARPETED_HALLWAY_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CARPETED_HALLWAY_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_HALLWAY_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_HALLWAY_Test()
    {
        Assert.That(EFX_REVERB_PRESET_HALLWAY_.flDensity, Is.EqualTo(0.3645f));
        Assert.That(EFX_REVERB_PRESET_HALLWAY_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_HALLWAY_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_HALLWAY_.flGainHF, Is.EqualTo(0.7079f));
        Assert.That(EFX_REVERB_PRESET_HALLWAY_.flGainLF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_HALLWAY_.flDecayTime, Is.EqualTo(1.4900f));
        Assert.That(EFX_REVERB_PRESET_HALLWAY_.flDecayHFRatio, Is.EqualTo(0.5900f));
        Assert.That(EFX_REVERB_PRESET_HALLWAY_.flDecayLFRatio, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_HALLWAY_.flReflectionsGain, Is.EqualTo(0.2458f));
        Assert.That(EFX_REVERB_PRESET_HALLWAY_.flReflectionsDelay, Is.EqualTo(0.0070f));
        Assert.That(
            EFX_REVERB_PRESET_HALLWAY_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_HALLWAY_.flLateReverbGain, Is.EqualTo(1.6615f));
        Assert.That(EFX_REVERB_PRESET_HALLWAY_.flLateReverbDelay, Is.EqualTo(0.0110f));
        Assert.That(
            EFX_REVERB_PRESET_HALLWAY_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_HALLWAY_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_HALLWAY_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_HALLWAY_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_HALLWAY_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_HALLWAY_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_HALLWAY_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_HALLWAY_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_HALLWAY_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_HALLWAY_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_STONE_CORRIDOR_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_STONE_CORRIDOR_Test()
    {
        Assert.That(EFX_REVERB_PRESET_STONE_CORRIDOR_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_STONE_CORRIDOR_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_STONE_CORRIDOR_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_STONE_CORRIDOR_.flGainHF, Is.EqualTo(0.7612f));
        Assert.That(EFX_REVERB_PRESET_STONE_CORRIDOR_.flGainLF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_STONE_CORRIDOR_.flDecayTime, Is.EqualTo(2.7000f));
        Assert.That(EFX_REVERB_PRESET_STONE_CORRIDOR_.flDecayHFRatio, Is.EqualTo(0.7900f));
        Assert.That(EFX_REVERB_PRESET_STONE_CORRIDOR_.flDecayLFRatio, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_STONE_CORRIDOR_.flReflectionsGain, Is.EqualTo(0.2472f));
        Assert.That(EFX_REVERB_PRESET_STONE_CORRIDOR_.flReflectionsDelay, Is.EqualTo(0.0130f));
        Assert.That(
            EFX_REVERB_PRESET_STONE_CORRIDOR_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_STONE_CORRIDOR_.flLateReverbGain, Is.EqualTo(1.5758f));
        Assert.That(EFX_REVERB_PRESET_STONE_CORRIDOR_.flLateReverbDelay, Is.EqualTo(0.0200f));
        Assert.That(
            EFX_REVERB_PRESET_STONE_CORRIDOR_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_STONE_CORRIDOR_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_STONE_CORRIDOR_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_STONE_CORRIDOR_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_STONE_CORRIDOR_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_STONE_CORRIDOR_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_STONE_CORRIDOR_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_STONE_CORRIDOR_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_STONE_CORRIDOR_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_STONE_CORRIDOR_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_ALLEY_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_ALLEY_Test()
    {
        Assert.That(EFX_REVERB_PRESET_ALLEY_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_ALLEY_.flDiffusion, Is.EqualTo(0.3000f));
        Assert.That(EFX_REVERB_PRESET_ALLEY_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_ALLEY_.flGainHF, Is.EqualTo(0.7328f));
        Assert.That(EFX_REVERB_PRESET_ALLEY_.flGainLF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_ALLEY_.flDecayTime, Is.EqualTo(1.4900f));
        Assert.That(EFX_REVERB_PRESET_ALLEY_.flDecayHFRatio, Is.EqualTo(0.8600f));
        Assert.That(EFX_REVERB_PRESET_ALLEY_.flDecayLFRatio, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_ALLEY_.flReflectionsGain, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_ALLEY_.flReflectionsDelay, Is.EqualTo(0.0070f));
        Assert.That(
            EFX_REVERB_PRESET_ALLEY_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_ALLEY_.flLateReverbGain, Is.EqualTo(0.9954f));
        Assert.That(EFX_REVERB_PRESET_ALLEY_.flLateReverbDelay, Is.EqualTo(0.0110f));
        Assert.That(
            EFX_REVERB_PRESET_ALLEY_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_ALLEY_.flEchoTime, Is.EqualTo(0.1250f));
        Assert.That(EFX_REVERB_PRESET_ALLEY_.flEchoDepth, Is.EqualTo(0.9500f));
        Assert.That(EFX_REVERB_PRESET_ALLEY_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_ALLEY_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_ALLEY_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_ALLEY_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_ALLEY_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_ALLEY_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_ALLEY_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_FOREST_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_FOREST_Test()
    {
        Assert.That(EFX_REVERB_PRESET_FOREST_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_FOREST_.flDiffusion, Is.EqualTo(0.3000f));
        Assert.That(EFX_REVERB_PRESET_FOREST_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_FOREST_.flGainHF, Is.EqualTo(0.0224f));
        Assert.That(EFX_REVERB_PRESET_FOREST_.flGainLF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_FOREST_.flDecayTime, Is.EqualTo(1.4900f));
        Assert.That(EFX_REVERB_PRESET_FOREST_.flDecayHFRatio, Is.EqualTo(0.5400f));
        Assert.That(EFX_REVERB_PRESET_FOREST_.flDecayLFRatio, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_FOREST_.flReflectionsGain, Is.EqualTo(0.0525f));
        Assert.That(EFX_REVERB_PRESET_FOREST_.flReflectionsDelay, Is.EqualTo(0.1620f));
        Assert.That(
            EFX_REVERB_PRESET_FOREST_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_FOREST_.flLateReverbGain, Is.EqualTo(0.7682f));
        Assert.That(EFX_REVERB_PRESET_FOREST_.flLateReverbDelay, Is.EqualTo(0.0880f));
        Assert.That(
            EFX_REVERB_PRESET_FOREST_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_FOREST_.flEchoTime, Is.EqualTo(0.1250f));
        Assert.That(EFX_REVERB_PRESET_FOREST_.flEchoDepth, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_FOREST_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_FOREST_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_FOREST_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_FOREST_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_FOREST_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_FOREST_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_FOREST_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_CITY_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_CITY_Test()
    {
        Assert.That(EFX_REVERB_PRESET_CITY_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_.flDiffusion, Is.EqualTo(0.5000f));
        Assert.That(EFX_REVERB_PRESET_CITY_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_CITY_.flGainHF, Is.EqualTo(0.3981f));
        Assert.That(EFX_REVERB_PRESET_CITY_.flGainLF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_.flDecayTime, Is.EqualTo(1.4900f));
        Assert.That(EFX_REVERB_PRESET_CITY_.flDecayHFRatio, Is.EqualTo(0.6700f));
        Assert.That(EFX_REVERB_PRESET_CITY_.flDecayLFRatio, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_.flReflectionsGain, Is.EqualTo(0.0730f));
        Assert.That(EFX_REVERB_PRESET_CITY_.flReflectionsDelay, Is.EqualTo(0.0070f));
        Assert.That(
            EFX_REVERB_PRESET_CITY_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CITY_.flLateReverbGain, Is.EqualTo(0.1427f));
        Assert.That(EFX_REVERB_PRESET_CITY_.flLateReverbDelay, Is.EqualTo(0.0110f));
        Assert.That(
            EFX_REVERB_PRESET_CITY_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CITY_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_CITY_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_CITY_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_CITY_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_MOUNTAINS_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_MOUNTAINS_Test()
    {
        Assert.That(EFX_REVERB_PRESET_MOUNTAINS_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_MOUNTAINS_.flDiffusion, Is.EqualTo(0.2700f));
        Assert.That(EFX_REVERB_PRESET_MOUNTAINS_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_MOUNTAINS_.flGainHF, Is.EqualTo(0.0562f));
        Assert.That(EFX_REVERB_PRESET_MOUNTAINS_.flGainLF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_MOUNTAINS_.flDecayTime, Is.EqualTo(1.4900f));
        Assert.That(EFX_REVERB_PRESET_MOUNTAINS_.flDecayHFRatio, Is.EqualTo(0.2100f));
        Assert.That(EFX_REVERB_PRESET_MOUNTAINS_.flDecayLFRatio, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_MOUNTAINS_.flReflectionsGain, Is.EqualTo(0.0407f));
        Assert.That(EFX_REVERB_PRESET_MOUNTAINS_.flReflectionsDelay, Is.EqualTo(0.3000f));
        Assert.That(
            EFX_REVERB_PRESET_MOUNTAINS_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_MOUNTAINS_.flLateReverbGain, Is.EqualTo(0.1919f));
        Assert.That(EFX_REVERB_PRESET_MOUNTAINS_.flLateReverbDelay, Is.EqualTo(0.1000f));
        Assert.That(
            EFX_REVERB_PRESET_MOUNTAINS_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_MOUNTAINS_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_MOUNTAINS_.flEchoDepth, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_MOUNTAINS_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_MOUNTAINS_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_MOUNTAINS_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_MOUNTAINS_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_MOUNTAINS_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_MOUNTAINS_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_MOUNTAINS_.iDecayHFLimit, Is.EqualTo(0x0));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_QUARRY_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_QUARRY_Test()
    {
        Assert.That(EFX_REVERB_PRESET_QUARRY_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_QUARRY_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_QUARRY_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_QUARRY_.flGainHF, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_QUARRY_.flGainLF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_QUARRY_.flDecayTime, Is.EqualTo(1.4900f));
        Assert.That(EFX_REVERB_PRESET_QUARRY_.flDecayHFRatio, Is.EqualTo(0.8300f));
        Assert.That(EFX_REVERB_PRESET_QUARRY_.flDecayLFRatio, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_QUARRY_.flReflectionsGain, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_QUARRY_.flReflectionsDelay, Is.EqualTo(0.0610f));
        Assert.That(
            EFX_REVERB_PRESET_QUARRY_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_QUARRY_.flLateReverbGain, Is.EqualTo(1.7783f));
        Assert.That(EFX_REVERB_PRESET_QUARRY_.flLateReverbDelay, Is.EqualTo(0.0250f));
        Assert.That(
            EFX_REVERB_PRESET_QUARRY_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_QUARRY_.flEchoTime, Is.EqualTo(0.1250f));
        Assert.That(EFX_REVERB_PRESET_QUARRY_.flEchoDepth, Is.EqualTo(0.7000f));
        Assert.That(EFX_REVERB_PRESET_QUARRY_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_QUARRY_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_QUARRY_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_QUARRY_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_QUARRY_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_QUARRY_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_QUARRY_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_PLAIN_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_PLAIN_Test()
    {
        Assert.That(EFX_REVERB_PRESET_PLAIN_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_PLAIN_.flDiffusion, Is.EqualTo(0.2100f));
        Assert.That(EFX_REVERB_PRESET_PLAIN_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_PLAIN_.flGainHF, Is.EqualTo(0.1000f));
        Assert.That(EFX_REVERB_PRESET_PLAIN_.flGainLF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_PLAIN_.flDecayTime, Is.EqualTo(1.4900f));
        Assert.That(EFX_REVERB_PRESET_PLAIN_.flDecayHFRatio, Is.EqualTo(0.5000f));
        Assert.That(EFX_REVERB_PRESET_PLAIN_.flDecayLFRatio, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_PLAIN_.flReflectionsGain, Is.EqualTo(0.0585f));
        Assert.That(EFX_REVERB_PRESET_PLAIN_.flReflectionsDelay, Is.EqualTo(0.1790f));
        Assert.That(
            EFX_REVERB_PRESET_PLAIN_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_PLAIN_.flLateReverbGain, Is.EqualTo(0.1089f));
        Assert.That(EFX_REVERB_PRESET_PLAIN_.flLateReverbDelay, Is.EqualTo(0.1000f));
        Assert.That(
            EFX_REVERB_PRESET_PLAIN_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_PLAIN_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_PLAIN_.flEchoDepth, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_PLAIN_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_PLAIN_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PLAIN_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_PLAIN_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_PLAIN_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_PLAIN_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PLAIN_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_PARKINGLOT_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_PARKINGLOT_Test()
    {
        Assert.That(EFX_REVERB_PRESET_PARKINGLOT_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_PARKINGLOT_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_PARKINGLOT_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_PARKINGLOT_.flGainHF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_PARKINGLOT_.flGainLF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_PARKINGLOT_.flDecayTime, Is.EqualTo(1.6500f));
        Assert.That(EFX_REVERB_PRESET_PARKINGLOT_.flDecayHFRatio, Is.EqualTo(1.5000f));
        Assert.That(EFX_REVERB_PRESET_PARKINGLOT_.flDecayLFRatio, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_PARKINGLOT_.flReflectionsGain, Is.EqualTo(0.2082f));
        Assert.That(EFX_REVERB_PRESET_PARKINGLOT_.flReflectionsDelay, Is.EqualTo(0.0080f));
        Assert.That(
            EFX_REVERB_PRESET_PARKINGLOT_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_PARKINGLOT_.flLateReverbGain, Is.EqualTo(0.2652f));
        Assert.That(EFX_REVERB_PRESET_PARKINGLOT_.flLateReverbDelay, Is.EqualTo(0.0120f));
        Assert.That(
            EFX_REVERB_PRESET_PARKINGLOT_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_PARKINGLOT_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_PARKINGLOT_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PARKINGLOT_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_PARKINGLOT_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PARKINGLOT_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_PARKINGLOT_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_PARKINGLOT_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_PARKINGLOT_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PARKINGLOT_.iDecayHFLimit, Is.EqualTo(0x0));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_SEWERPIPE_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_SEWERPIPE_Test()
    {
        Assert.That(EFX_REVERB_PRESET_SEWERPIPE_.flDensity, Is.EqualTo(0.3071f));
        Assert.That(EFX_REVERB_PRESET_SEWERPIPE_.flDiffusion, Is.EqualTo(0.8000f));
        Assert.That(EFX_REVERB_PRESET_SEWERPIPE_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_SEWERPIPE_.flGainHF, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_SEWERPIPE_.flGainLF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_SEWERPIPE_.flDecayTime, Is.EqualTo(2.8100f));
        Assert.That(EFX_REVERB_PRESET_SEWERPIPE_.flDecayHFRatio, Is.EqualTo(0.1400f));
        Assert.That(EFX_REVERB_PRESET_SEWERPIPE_.flDecayLFRatio, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_SEWERPIPE_.flReflectionsGain, Is.EqualTo(1.6387f));
        Assert.That(EFX_REVERB_PRESET_SEWERPIPE_.flReflectionsDelay, Is.EqualTo(0.0140f));
        Assert.That(
            EFX_REVERB_PRESET_SEWERPIPE_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_SEWERPIPE_.flLateReverbGain, Is.EqualTo(3.2471f));
        Assert.That(EFX_REVERB_PRESET_SEWERPIPE_.flLateReverbDelay, Is.EqualTo(0.0210f));
        Assert.That(
            EFX_REVERB_PRESET_SEWERPIPE_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_SEWERPIPE_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_SEWERPIPE_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_SEWERPIPE_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_SEWERPIPE_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_SEWERPIPE_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_SEWERPIPE_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_SEWERPIPE_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_SEWERPIPE_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_SEWERPIPE_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_UNDERWATER_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_UNDERWATER_Test()
    {
        Assert.That(EFX_REVERB_PRESET_UNDERWATER_.flDensity, Is.EqualTo(0.3645f));
        Assert.That(EFX_REVERB_PRESET_UNDERWATER_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_UNDERWATER_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_UNDERWATER_.flGainHF, Is.EqualTo(0.0100f));
        Assert.That(EFX_REVERB_PRESET_UNDERWATER_.flGainLF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_UNDERWATER_.flDecayTime, Is.EqualTo(1.4900f));
        Assert.That(EFX_REVERB_PRESET_UNDERWATER_.flDecayHFRatio, Is.EqualTo(0.1000f));
        Assert.That(EFX_REVERB_PRESET_UNDERWATER_.flDecayLFRatio, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_UNDERWATER_.flReflectionsGain, Is.EqualTo(0.5963f));
        Assert.That(EFX_REVERB_PRESET_UNDERWATER_.flReflectionsDelay, Is.EqualTo(0.0070f));
        Assert.That(
            EFX_REVERB_PRESET_UNDERWATER_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_UNDERWATER_.flLateReverbGain, Is.EqualTo(7.0795f));
        Assert.That(EFX_REVERB_PRESET_UNDERWATER_.flLateReverbDelay, Is.EqualTo(0.0110f));
        Assert.That(
            EFX_REVERB_PRESET_UNDERWATER_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_UNDERWATER_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_UNDERWATER_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_UNDERWATER_.flModulationTime, Is.EqualTo(1.1800f));
        Assert.That(EFX_REVERB_PRESET_UNDERWATER_.flModulationDepth, Is.EqualTo(0.3480f));
        Assert.That(EFX_REVERB_PRESET_UNDERWATER_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_UNDERWATER_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_UNDERWATER_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_UNDERWATER_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_UNDERWATER_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_DRUGGED_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_DRUGGED_Test()
    {
        Assert.That(EFX_REVERB_PRESET_DRUGGED_.flDensity, Is.EqualTo(0.4287f));
        Assert.That(EFX_REVERB_PRESET_DRUGGED_.flDiffusion, Is.EqualTo(0.5000f));
        Assert.That(EFX_REVERB_PRESET_DRUGGED_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_DRUGGED_.flGainHF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_DRUGGED_.flGainLF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_DRUGGED_.flDecayTime, Is.EqualTo(8.3900f));
        Assert.That(EFX_REVERB_PRESET_DRUGGED_.flDecayHFRatio, Is.EqualTo(1.3900f));
        Assert.That(EFX_REVERB_PRESET_DRUGGED_.flDecayLFRatio, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_DRUGGED_.flReflectionsGain, Is.EqualTo(0.8760f));
        Assert.That(EFX_REVERB_PRESET_DRUGGED_.flReflectionsDelay, Is.EqualTo(0.0020f));
        Assert.That(
            EFX_REVERB_PRESET_DRUGGED_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_DRUGGED_.flLateReverbGain, Is.EqualTo(3.1081f));
        Assert.That(EFX_REVERB_PRESET_DRUGGED_.flLateReverbDelay, Is.EqualTo(0.0300f));
        Assert.That(
            EFX_REVERB_PRESET_DRUGGED_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_DRUGGED_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_DRUGGED_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_DRUGGED_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_DRUGGED_.flModulationDepth, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_DRUGGED_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_DRUGGED_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_DRUGGED_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_DRUGGED_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_DRUGGED_.iDecayHFLimit, Is.EqualTo(0x0));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_DIZZY_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_DIZZY_Test()
    {
        Assert.That(EFX_REVERB_PRESET_DIZZY_.flDensity, Is.EqualTo(0.3645f));
        Assert.That(EFX_REVERB_PRESET_DIZZY_.flDiffusion, Is.EqualTo(0.6000f));
        Assert.That(EFX_REVERB_PRESET_DIZZY_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_DIZZY_.flGainHF, Is.EqualTo(0.6310f));
        Assert.That(EFX_REVERB_PRESET_DIZZY_.flGainLF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_DIZZY_.flDecayTime, Is.EqualTo(17.2300f));
        Assert.That(EFX_REVERB_PRESET_DIZZY_.flDecayHFRatio, Is.EqualTo(0.5600f));
        Assert.That(EFX_REVERB_PRESET_DIZZY_.flDecayLFRatio, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_DIZZY_.flReflectionsGain, Is.EqualTo(0.1392f));
        Assert.That(EFX_REVERB_PRESET_DIZZY_.flReflectionsDelay, Is.EqualTo(0.0200f));
        Assert.That(
            EFX_REVERB_PRESET_DIZZY_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_DIZZY_.flLateReverbGain, Is.EqualTo(0.4937f));
        Assert.That(EFX_REVERB_PRESET_DIZZY_.flLateReverbDelay, Is.EqualTo(0.0300f));
        Assert.That(
            EFX_REVERB_PRESET_DIZZY_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_DIZZY_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_DIZZY_.flEchoDepth, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_DIZZY_.flModulationTime, Is.EqualTo(0.8100f));
        Assert.That(EFX_REVERB_PRESET_DIZZY_.flModulationDepth, Is.EqualTo(0.3100f));
        Assert.That(EFX_REVERB_PRESET_DIZZY_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_DIZZY_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_DIZZY_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_DIZZY_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_DIZZY_.iDecayHFLimit, Is.EqualTo(0x0));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_PSYCHOTIC_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_PSYCHOTIC_Test()
    {
        Assert.That(EFX_REVERB_PRESET_PSYCHOTIC_.flDensity, Is.EqualTo(0.0625f));
        Assert.That(EFX_REVERB_PRESET_PSYCHOTIC_.flDiffusion, Is.EqualTo(0.5000f));
        Assert.That(EFX_REVERB_PRESET_PSYCHOTIC_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_PSYCHOTIC_.flGainHF, Is.EqualTo(0.8404f));
        Assert.That(EFX_REVERB_PRESET_PSYCHOTIC_.flGainLF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_PSYCHOTIC_.flDecayTime, Is.EqualTo(7.5600f));
        Assert.That(EFX_REVERB_PRESET_PSYCHOTIC_.flDecayHFRatio, Is.EqualTo(0.9100f));
        Assert.That(EFX_REVERB_PRESET_PSYCHOTIC_.flDecayLFRatio, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_PSYCHOTIC_.flReflectionsGain, Is.EqualTo(0.4864f));
        Assert.That(EFX_REVERB_PRESET_PSYCHOTIC_.flReflectionsDelay, Is.EqualTo(0.0200f));
        Assert.That(
            EFX_REVERB_PRESET_PSYCHOTIC_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_PSYCHOTIC_.flLateReverbGain, Is.EqualTo(2.4378f));
        Assert.That(EFX_REVERB_PRESET_PSYCHOTIC_.flLateReverbDelay, Is.EqualTo(0.0300f));
        Assert.That(
            EFX_REVERB_PRESET_PSYCHOTIC_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_PSYCHOTIC_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_PSYCHOTIC_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PSYCHOTIC_.flModulationTime, Is.EqualTo(4.0000f));
        Assert.That(EFX_REVERB_PRESET_PSYCHOTIC_.flModulationDepth, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_PSYCHOTIC_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_PSYCHOTIC_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_PSYCHOTIC_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_PSYCHOTIC_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PSYCHOTIC_.iDecayHFLimit, Is.EqualTo(0x0));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_CASTLE_SMALLROOM_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_CASTLE_SMALLROOM_Test()
    {
        Assert.That(EFX_REVERB_PRESET_CASTLE_SMALLROOM_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SMALLROOM_.flDiffusion, Is.EqualTo(0.8900f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SMALLROOM_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SMALLROOM_.flGainHF, Is.EqualTo(0.3981f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SMALLROOM_.flGainLF, Is.EqualTo(0.1000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SMALLROOM_.flDecayTime, Is.EqualTo(1.2200f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SMALLROOM_.flDecayHFRatio, Is.EqualTo(0.8300f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SMALLROOM_.flDecayLFRatio, Is.EqualTo(0.3100f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SMALLROOM_.flReflectionsGain, Is.EqualTo(0.8913f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SMALLROOM_.flReflectionsDelay, Is.EqualTo(0.0220f));
        Assert.That(
            EFX_REVERB_PRESET_CASTLE_SMALLROOM_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CASTLE_SMALLROOM_.flLateReverbGain, Is.EqualTo(1.9953f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SMALLROOM_.flLateReverbDelay, Is.EqualTo(0.0110f));
        Assert.That(
            EFX_REVERB_PRESET_CASTLE_SMALLROOM_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CASTLE_SMALLROOM_.flEchoTime, Is.EqualTo(0.1380f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SMALLROOM_.flEchoDepth, Is.EqualTo(0.0800f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SMALLROOM_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SMALLROOM_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SMALLROOM_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SMALLROOM_.flHFReference, Is.EqualTo(5168.6001f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SMALLROOM_.flLFReference, Is.EqualTo(139.5000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SMALLROOM_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SMALLROOM_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_CASTLE_SHORTPASSAGE_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_CASTLE_SHORTPASSAGE_Test()
    {
        Assert.That(EFX_REVERB_PRESET_CASTLE_SHORTPASSAGE_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SHORTPASSAGE_.flDiffusion, Is.EqualTo(0.8900f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SHORTPASSAGE_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SHORTPASSAGE_.flGainHF, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SHORTPASSAGE_.flGainLF, Is.EqualTo(0.1000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SHORTPASSAGE_.flDecayTime, Is.EqualTo(2.3200f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SHORTPASSAGE_.flDecayHFRatio, Is.EqualTo(0.8300f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SHORTPASSAGE_.flDecayLFRatio, Is.EqualTo(0.3100f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SHORTPASSAGE_.flReflectionsGain, Is.EqualTo(0.8913f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SHORTPASSAGE_.flReflectionsDelay, Is.EqualTo(0.0070f));
        Assert.That(
            EFX_REVERB_PRESET_CASTLE_SHORTPASSAGE_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CASTLE_SHORTPASSAGE_.flLateReverbGain, Is.EqualTo(1.2589f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SHORTPASSAGE_.flLateReverbDelay, Is.EqualTo(0.0230f));
        Assert.That(
            EFX_REVERB_PRESET_CASTLE_SHORTPASSAGE_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CASTLE_SHORTPASSAGE_.flEchoTime, Is.EqualTo(0.1380f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SHORTPASSAGE_.flEchoDepth, Is.EqualTo(0.0800f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SHORTPASSAGE_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SHORTPASSAGE_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_CASTLE_SHORTPASSAGE_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(EFX_REVERB_PRESET_CASTLE_SHORTPASSAGE_.flHFReference, Is.EqualTo(5168.6001f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_SHORTPASSAGE_.flLFReference, Is.EqualTo(139.5000f));
        Assert.That(
            EFX_REVERB_PRESET_CASTLE_SHORTPASSAGE_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_CASTLE_SHORTPASSAGE_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_CASTLE_MEDIUMROOM_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_CASTLE_MEDIUMROOM_Test()
    {
        Assert.That(EFX_REVERB_PRESET_CASTLE_MEDIUMROOM_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_MEDIUMROOM_.flDiffusion, Is.EqualTo(0.9300f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_MEDIUMROOM_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_MEDIUMROOM_.flGainHF, Is.EqualTo(0.2818f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_MEDIUMROOM_.flGainLF, Is.EqualTo(0.1000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_MEDIUMROOM_.flDecayTime, Is.EqualTo(2.0400f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_MEDIUMROOM_.flDecayHFRatio, Is.EqualTo(0.8300f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_MEDIUMROOM_.flDecayLFRatio, Is.EqualTo(0.4600f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_MEDIUMROOM_.flReflectionsGain, Is.EqualTo(0.6310f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_MEDIUMROOM_.flReflectionsDelay, Is.EqualTo(0.0220f));
        Assert.That(
            EFX_REVERB_PRESET_CASTLE_MEDIUMROOM_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CASTLE_MEDIUMROOM_.flLateReverbGain, Is.EqualTo(1.5849f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_MEDIUMROOM_.flLateReverbDelay, Is.EqualTo(0.0110f));
        Assert.That(
            EFX_REVERB_PRESET_CASTLE_MEDIUMROOM_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CASTLE_MEDIUMROOM_.flEchoTime, Is.EqualTo(0.1550f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_MEDIUMROOM_.flEchoDepth, Is.EqualTo(0.0300f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_MEDIUMROOM_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_MEDIUMROOM_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_CASTLE_MEDIUMROOM_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(EFX_REVERB_PRESET_CASTLE_MEDIUMROOM_.flHFReference, Is.EqualTo(5168.6001f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_MEDIUMROOM_.flLFReference, Is.EqualTo(139.5000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_MEDIUMROOM_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_MEDIUMROOM_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_CASTLE_LARGEROOM_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_CASTLE_LARGEROOM_Test()
    {
        Assert.That(EFX_REVERB_PRESET_CASTLE_LARGEROOM_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LARGEROOM_.flDiffusion, Is.EqualTo(0.8200f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LARGEROOM_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LARGEROOM_.flGainHF, Is.EqualTo(0.2818f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LARGEROOM_.flGainLF, Is.EqualTo(0.1259f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LARGEROOM_.flDecayTime, Is.EqualTo(2.5300f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LARGEROOM_.flDecayHFRatio, Is.EqualTo(0.8300f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LARGEROOM_.flDecayLFRatio, Is.EqualTo(0.5000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LARGEROOM_.flReflectionsGain, Is.EqualTo(0.4467f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LARGEROOM_.flReflectionsDelay, Is.EqualTo(0.0340f));
        Assert.That(
            EFX_REVERB_PRESET_CASTLE_LARGEROOM_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CASTLE_LARGEROOM_.flLateReverbGain, Is.EqualTo(1.2589f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LARGEROOM_.flLateReverbDelay, Is.EqualTo(0.0160f));
        Assert.That(
            EFX_REVERB_PRESET_CASTLE_LARGEROOM_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CASTLE_LARGEROOM_.flEchoTime, Is.EqualTo(0.1850f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LARGEROOM_.flEchoDepth, Is.EqualTo(0.0700f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LARGEROOM_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LARGEROOM_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LARGEROOM_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LARGEROOM_.flHFReference, Is.EqualTo(5168.6001f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LARGEROOM_.flLFReference, Is.EqualTo(139.5000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LARGEROOM_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LARGEROOM_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_CASTLE_LONGPASSAGE_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_CASTLE_LONGPASSAGE_Test()
    {
        Assert.That(EFX_REVERB_PRESET_CASTLE_LONGPASSAGE_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LONGPASSAGE_.flDiffusion, Is.EqualTo(0.8900f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LONGPASSAGE_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LONGPASSAGE_.flGainHF, Is.EqualTo(0.3981f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LONGPASSAGE_.flGainLF, Is.EqualTo(0.1000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LONGPASSAGE_.flDecayTime, Is.EqualTo(3.4200f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LONGPASSAGE_.flDecayHFRatio, Is.EqualTo(0.8300f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LONGPASSAGE_.flDecayLFRatio, Is.EqualTo(0.3100f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LONGPASSAGE_.flReflectionsGain, Is.EqualTo(0.8913f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LONGPASSAGE_.flReflectionsDelay, Is.EqualTo(0.0070f));
        Assert.That(
            EFX_REVERB_PRESET_CASTLE_LONGPASSAGE_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CASTLE_LONGPASSAGE_.flLateReverbGain, Is.EqualTo(1.4125f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LONGPASSAGE_.flLateReverbDelay, Is.EqualTo(0.0230f));
        Assert.That(
            EFX_REVERB_PRESET_CASTLE_LONGPASSAGE_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CASTLE_LONGPASSAGE_.flEchoTime, Is.EqualTo(0.1380f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LONGPASSAGE_.flEchoDepth, Is.EqualTo(0.0800f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LONGPASSAGE_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LONGPASSAGE_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_CASTLE_LONGPASSAGE_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(EFX_REVERB_PRESET_CASTLE_LONGPASSAGE_.flHFReference, Is.EqualTo(5168.6001f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LONGPASSAGE_.flLFReference, Is.EqualTo(139.5000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LONGPASSAGE_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_LONGPASSAGE_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_CASTLE_HALL_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_CASTLE_HALL_Test()
    {
        Assert.That(EFX_REVERB_PRESET_CASTLE_HALL_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_HALL_.flDiffusion, Is.EqualTo(0.8100f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_HALL_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_HALL_.flGainHF, Is.EqualTo(0.2818f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_HALL_.flGainLF, Is.EqualTo(0.1778f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_HALL_.flDecayTime, Is.EqualTo(3.1400f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_HALL_.flDecayHFRatio, Is.EqualTo(0.7900f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_HALL_.flDecayLFRatio, Is.EqualTo(0.6200f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_HALL_.flReflectionsGain, Is.EqualTo(0.1778f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_HALL_.flReflectionsDelay, Is.EqualTo(0.0560f));
        Assert.That(
            EFX_REVERB_PRESET_CASTLE_HALL_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CASTLE_HALL_.flLateReverbGain, Is.EqualTo(1.1220f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_HALL_.flLateReverbDelay, Is.EqualTo(0.0240f));
        Assert.That(
            EFX_REVERB_PRESET_CASTLE_HALL_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CASTLE_HALL_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_HALL_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_HALL_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_HALL_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_HALL_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_HALL_.flHFReference, Is.EqualTo(5168.6001f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_HALL_.flLFReference, Is.EqualTo(139.5000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_HALL_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_HALL_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_CASTLE_CUPBOARD_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_CASTLE_CUPBOARD_Test()
    {
        Assert.That(EFX_REVERB_PRESET_CASTLE_CUPBOARD_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_CUPBOARD_.flDiffusion, Is.EqualTo(0.8900f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_CUPBOARD_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_CUPBOARD_.flGainHF, Is.EqualTo(0.2818f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_CUPBOARD_.flGainLF, Is.EqualTo(0.1000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_CUPBOARD_.flDecayTime, Is.EqualTo(0.6700f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_CUPBOARD_.flDecayHFRatio, Is.EqualTo(0.8700f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_CUPBOARD_.flDecayLFRatio, Is.EqualTo(0.3100f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_CUPBOARD_.flReflectionsGain, Is.EqualTo(1.4125f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_CUPBOARD_.flReflectionsDelay, Is.EqualTo(0.0100f));
        Assert.That(
            EFX_REVERB_PRESET_CASTLE_CUPBOARD_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CASTLE_CUPBOARD_.flLateReverbGain, Is.EqualTo(3.5481f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_CUPBOARD_.flLateReverbDelay, Is.EqualTo(0.0070f));
        Assert.That(
            EFX_REVERB_PRESET_CASTLE_CUPBOARD_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CASTLE_CUPBOARD_.flEchoTime, Is.EqualTo(0.1380f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_CUPBOARD_.flEchoDepth, Is.EqualTo(0.0800f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_CUPBOARD_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_CUPBOARD_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_CUPBOARD_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_CUPBOARD_.flHFReference, Is.EqualTo(5168.6001f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_CUPBOARD_.flLFReference, Is.EqualTo(139.5000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_CUPBOARD_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_CUPBOARD_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_CASTLE_COURTYARD_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_CASTLE_COURTYARD_Test()
    {
        Assert.That(EFX_REVERB_PRESET_CASTLE_COURTYARD_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_COURTYARD_.flDiffusion, Is.EqualTo(0.4200f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_COURTYARD_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_COURTYARD_.flGainHF, Is.EqualTo(0.4467f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_COURTYARD_.flGainLF, Is.EqualTo(0.1995f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_COURTYARD_.flDecayTime, Is.EqualTo(2.1300f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_COURTYARD_.flDecayHFRatio, Is.EqualTo(0.6100f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_COURTYARD_.flDecayLFRatio, Is.EqualTo(0.2300f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_COURTYARD_.flReflectionsGain, Is.EqualTo(0.2239f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_COURTYARD_.flReflectionsDelay, Is.EqualTo(0.1600f));
        Assert.That(
            EFX_REVERB_PRESET_CASTLE_COURTYARD_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CASTLE_COURTYARD_.flLateReverbGain, Is.EqualTo(0.7079f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_COURTYARD_.flLateReverbDelay, Is.EqualTo(0.0360f));
        Assert.That(
            EFX_REVERB_PRESET_CASTLE_COURTYARD_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CASTLE_COURTYARD_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_COURTYARD_.flEchoDepth, Is.EqualTo(0.3700f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_COURTYARD_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_COURTYARD_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_COURTYARD_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_COURTYARD_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_COURTYARD_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_COURTYARD_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_COURTYARD_.iDecayHFLimit, Is.EqualTo(0x0));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_CASTLE_ALCOVE_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_CASTLE_ALCOVE_Test()
    {
        Assert.That(EFX_REVERB_PRESET_CASTLE_ALCOVE_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_ALCOVE_.flDiffusion, Is.EqualTo(0.8900f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_ALCOVE_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_ALCOVE_.flGainHF, Is.EqualTo(0.5012f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_ALCOVE_.flGainLF, Is.EqualTo(0.1000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_ALCOVE_.flDecayTime, Is.EqualTo(1.6400f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_ALCOVE_.flDecayHFRatio, Is.EqualTo(0.8700f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_ALCOVE_.flDecayLFRatio, Is.EqualTo(0.3100f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_ALCOVE_.flReflectionsGain, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_ALCOVE_.flReflectionsDelay, Is.EqualTo(0.0070f));
        Assert.That(
            EFX_REVERB_PRESET_CASTLE_ALCOVE_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CASTLE_ALCOVE_.flLateReverbGain, Is.EqualTo(1.4125f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_ALCOVE_.flLateReverbDelay, Is.EqualTo(0.0340f));
        Assert.That(
            EFX_REVERB_PRESET_CASTLE_ALCOVE_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CASTLE_ALCOVE_.flEchoTime, Is.EqualTo(0.1380f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_ALCOVE_.flEchoDepth, Is.EqualTo(0.0800f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_ALCOVE_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_ALCOVE_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_ALCOVE_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_ALCOVE_.flHFReference, Is.EqualTo(5168.6001f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_ALCOVE_.flLFReference, Is.EqualTo(139.5000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_ALCOVE_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CASTLE_ALCOVE_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_FACTORY_SMALL_ROOM_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_FACTORY_SMALL_ROOM_Test()
    {
        Assert.That(EFX_REVERB_PRESET_FACTORY_SMALL_ROOM_.flDensity, Is.EqualTo(0.3645f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_SMALL_ROOM_.flDiffusion, Is.EqualTo(0.8200f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_SMALL_ROOM_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_SMALL_ROOM_.flGainHF, Is.EqualTo(0.7943f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_SMALL_ROOM_.flGainLF, Is.EqualTo(0.5012f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_SMALL_ROOM_.flDecayTime, Is.EqualTo(1.7200f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_SMALL_ROOM_.flDecayHFRatio, Is.EqualTo(0.6500f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_SMALL_ROOM_.flDecayLFRatio, Is.EqualTo(1.3100f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_SMALL_ROOM_.flReflectionsGain, Is.EqualTo(0.7079f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_SMALL_ROOM_.flReflectionsDelay, Is.EqualTo(0.0100f));
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_SMALL_ROOM_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_FACTORY_SMALL_ROOM_.flLateReverbGain, Is.EqualTo(1.7783f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_SMALL_ROOM_.flLateReverbDelay, Is.EqualTo(0.0240f));
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_SMALL_ROOM_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_FACTORY_SMALL_ROOM_.flEchoTime, Is.EqualTo(0.1190f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_SMALL_ROOM_.flEchoDepth, Is.EqualTo(0.0700f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_SMALL_ROOM_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_SMALL_ROOM_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_SMALL_ROOM_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(EFX_REVERB_PRESET_FACTORY_SMALL_ROOM_.flHFReference, Is.EqualTo(3762.6001f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_SMALL_ROOM_.flLFReference, Is.EqualTo(362.5000f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_SMALL_ROOM_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_SMALL_ROOM_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_FACTORY_SHORT_PASSAGE_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_FACTORY_SHORT_PASSAGE_Test()
    {
        Assert.That(EFX_REVERB_PRESET_FACTORY_SHORT_PASSAGE_.flDensity, Is.EqualTo(0.3645f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_SHORT_PASSAGE_.flDiffusion, Is.EqualTo(0.6400f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_SHORT_PASSAGE_.flGain, Is.EqualTo(0.2512f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_SHORT_PASSAGE_.flGainHF, Is.EqualTo(0.7943f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_SHORT_PASSAGE_.flGainLF, Is.EqualTo(0.5012f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_SHORT_PASSAGE_.flDecayTime, Is.EqualTo(2.5300f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_SHORT_PASSAGE_.flDecayHFRatio, Is.EqualTo(0.6500f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_SHORT_PASSAGE_.flDecayLFRatio, Is.EqualTo(1.3100f));
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_SHORT_PASSAGE_.flReflectionsGain,
            Is.EqualTo(1.0000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_SHORT_PASSAGE_.flReflectionsDelay,
            Is.EqualTo(0.0100f)
        );
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_SHORT_PASSAGE_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_FACTORY_SHORT_PASSAGE_.flLateReverbGain, Is.EqualTo(1.2589f));
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_SHORT_PASSAGE_.flLateReverbDelay,
            Is.EqualTo(0.0380f)
        );
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_SHORT_PASSAGE_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_FACTORY_SHORT_PASSAGE_.flEchoTime, Is.EqualTo(0.1350f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_SHORT_PASSAGE_.flEchoDepth, Is.EqualTo(0.2300f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_SHORT_PASSAGE_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_SHORT_PASSAGE_.flModulationDepth,
            Is.EqualTo(0.0000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_SHORT_PASSAGE_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(EFX_REVERB_PRESET_FACTORY_SHORT_PASSAGE_.flHFReference, Is.EqualTo(3762.6001f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_SHORT_PASSAGE_.flLFReference, Is.EqualTo(362.5000f));
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_SHORT_PASSAGE_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_FACTORY_SHORT_PASSAGE_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_FACTORY_MEDIUM_ROOM_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_FACTORY_MEDIUM_ROOM_Test()
    {
        Assert.That(EFX_REVERB_PRESET_FACTORY_MEDIUM_ROOM_.flDensity, Is.EqualTo(0.4287f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_MEDIUM_ROOM_.flDiffusion, Is.EqualTo(0.8200f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_MEDIUM_ROOM_.flGain, Is.EqualTo(0.2512f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_MEDIUM_ROOM_.flGainHF, Is.EqualTo(0.7943f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_MEDIUM_ROOM_.flGainLF, Is.EqualTo(0.5012f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_MEDIUM_ROOM_.flDecayTime, Is.EqualTo(2.7600f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_MEDIUM_ROOM_.flDecayHFRatio, Is.EqualTo(0.6500f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_MEDIUM_ROOM_.flDecayLFRatio, Is.EqualTo(1.3100f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_MEDIUM_ROOM_.flReflectionsGain, Is.EqualTo(0.2818f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_MEDIUM_ROOM_.flReflectionsDelay, Is.EqualTo(0.0220f));
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_MEDIUM_ROOM_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_FACTORY_MEDIUM_ROOM_.flLateReverbGain, Is.EqualTo(1.4125f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_MEDIUM_ROOM_.flLateReverbDelay, Is.EqualTo(0.0230f));
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_MEDIUM_ROOM_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_FACTORY_MEDIUM_ROOM_.flEchoTime, Is.EqualTo(0.1740f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_MEDIUM_ROOM_.flEchoDepth, Is.EqualTo(0.0700f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_MEDIUM_ROOM_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_MEDIUM_ROOM_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_MEDIUM_ROOM_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(EFX_REVERB_PRESET_FACTORY_MEDIUM_ROOM_.flHFReference, Is.EqualTo(3762.6001f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_MEDIUM_ROOM_.flLFReference, Is.EqualTo(362.5000f));
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_MEDIUM_ROOM_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_FACTORY_MEDIUM_ROOM_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_FACTORY_LARGE_ROOM_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_FACTORY_LARGE_ROOM_Test()
    {
        Assert.That(EFX_REVERB_PRESET_FACTORY_LARGE_ROOM_.flDensity, Is.EqualTo(0.4287f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_LARGE_ROOM_.flDiffusion, Is.EqualTo(0.7500f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_LARGE_ROOM_.flGain, Is.EqualTo(0.2512f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_LARGE_ROOM_.flGainHF, Is.EqualTo(0.7079f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_LARGE_ROOM_.flGainLF, Is.EqualTo(0.6310f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_LARGE_ROOM_.flDecayTime, Is.EqualTo(4.2400f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_LARGE_ROOM_.flDecayHFRatio, Is.EqualTo(0.5100f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_LARGE_ROOM_.flDecayLFRatio, Is.EqualTo(1.3100f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_LARGE_ROOM_.flReflectionsGain, Is.EqualTo(0.1778f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_LARGE_ROOM_.flReflectionsDelay, Is.EqualTo(0.0390f));
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_LARGE_ROOM_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_FACTORY_LARGE_ROOM_.flLateReverbGain, Is.EqualTo(1.1220f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_LARGE_ROOM_.flLateReverbDelay, Is.EqualTo(0.0230f));
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_LARGE_ROOM_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_FACTORY_LARGE_ROOM_.flEchoTime, Is.EqualTo(0.2310f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_LARGE_ROOM_.flEchoDepth, Is.EqualTo(0.0700f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_LARGE_ROOM_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_LARGE_ROOM_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_LARGE_ROOM_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(EFX_REVERB_PRESET_FACTORY_LARGE_ROOM_.flHFReference, Is.EqualTo(3762.6001f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_LARGE_ROOM_.flLFReference, Is.EqualTo(362.5000f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_LARGE_ROOM_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_LARGE_ROOM_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_FACTORY_LONG_PASSAGE_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_FACTORY_LONG_PASSAGE_Test()
    {
        Assert.That(EFX_REVERB_PRESET_FACTORY_LONG_PASSAGE_.flDensity, Is.EqualTo(0.3645f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_LONG_PASSAGE_.flDiffusion, Is.EqualTo(0.6400f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_LONG_PASSAGE_.flGain, Is.EqualTo(0.2512f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_LONG_PASSAGE_.flGainHF, Is.EqualTo(0.7943f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_LONG_PASSAGE_.flGainLF, Is.EqualTo(0.5012f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_LONG_PASSAGE_.flDecayTime, Is.EqualTo(4.0600f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_LONG_PASSAGE_.flDecayHFRatio, Is.EqualTo(0.6500f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_LONG_PASSAGE_.flDecayLFRatio, Is.EqualTo(1.3100f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_LONG_PASSAGE_.flReflectionsGain, Is.EqualTo(1.0000f));
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_LONG_PASSAGE_.flReflectionsDelay,
            Is.EqualTo(0.0200f)
        );
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_LONG_PASSAGE_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_FACTORY_LONG_PASSAGE_.flLateReverbGain, Is.EqualTo(1.2589f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_LONG_PASSAGE_.flLateReverbDelay, Is.EqualTo(0.0370f));
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_LONG_PASSAGE_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_FACTORY_LONG_PASSAGE_.flEchoTime, Is.EqualTo(0.1350f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_LONG_PASSAGE_.flEchoDepth, Is.EqualTo(0.2300f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_LONG_PASSAGE_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_LONG_PASSAGE_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_LONG_PASSAGE_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(EFX_REVERB_PRESET_FACTORY_LONG_PASSAGE_.flHFReference, Is.EqualTo(3762.6001f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_LONG_PASSAGE_.flLFReference, Is.EqualTo(362.5000f));
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_LONG_PASSAGE_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_FACTORY_LONG_PASSAGE_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_FACTORY_HALL_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_FACTORY_HALL_Test()
    {
        Assert.That(EFX_REVERB_PRESET_FACTORY_HALL_.flDensity, Is.EqualTo(0.4287f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_HALL_.flDiffusion, Is.EqualTo(0.7500f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_HALL_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_HALL_.flGainHF, Is.EqualTo(0.7079f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_HALL_.flGainLF, Is.EqualTo(0.6310f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_HALL_.flDecayTime, Is.EqualTo(7.4300f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_HALL_.flDecayHFRatio, Is.EqualTo(0.5100f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_HALL_.flDecayLFRatio, Is.EqualTo(1.3100f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_HALL_.flReflectionsGain, Is.EqualTo(0.0631f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_HALL_.flReflectionsDelay, Is.EqualTo(0.0730f));
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_HALL_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_FACTORY_HALL_.flLateReverbGain, Is.EqualTo(0.8913f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_HALL_.flLateReverbDelay, Is.EqualTo(0.0270f));
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_HALL_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_FACTORY_HALL_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_HALL_.flEchoDepth, Is.EqualTo(0.0700f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_HALL_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_HALL_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_HALL_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_HALL_.flHFReference, Is.EqualTo(3762.6001f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_HALL_.flLFReference, Is.EqualTo(362.5000f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_HALL_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_HALL_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_FACTORY_CUPBOARD_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_FACTORY_CUPBOARD_Test()
    {
        Assert.That(EFX_REVERB_PRESET_FACTORY_CUPBOARD_.flDensity, Is.EqualTo(0.3071f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_CUPBOARD_.flDiffusion, Is.EqualTo(0.6300f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_CUPBOARD_.flGain, Is.EqualTo(0.2512f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_CUPBOARD_.flGainHF, Is.EqualTo(0.7943f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_CUPBOARD_.flGainLF, Is.EqualTo(0.5012f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_CUPBOARD_.flDecayTime, Is.EqualTo(0.4900f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_CUPBOARD_.flDecayHFRatio, Is.EqualTo(0.6500f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_CUPBOARD_.flDecayLFRatio, Is.EqualTo(1.3100f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_CUPBOARD_.flReflectionsGain, Is.EqualTo(1.2589f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_CUPBOARD_.flReflectionsDelay, Is.EqualTo(0.0100f));
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_CUPBOARD_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_FACTORY_CUPBOARD_.flLateReverbGain, Is.EqualTo(1.9953f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_CUPBOARD_.flLateReverbDelay, Is.EqualTo(0.0320f));
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_CUPBOARD_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_FACTORY_CUPBOARD_.flEchoTime, Is.EqualTo(0.1070f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_CUPBOARD_.flEchoDepth, Is.EqualTo(0.0700f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_CUPBOARD_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_CUPBOARD_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_CUPBOARD_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_CUPBOARD_.flHFReference, Is.EqualTo(3762.6001f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_CUPBOARD_.flLFReference, Is.EqualTo(362.5000f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_CUPBOARD_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_CUPBOARD_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_FACTORY_COURTYARD_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_FACTORY_COURTYARD_Test()
    {
        Assert.That(EFX_REVERB_PRESET_FACTORY_COURTYARD_.flDensity, Is.EqualTo(0.3071f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_COURTYARD_.flDiffusion, Is.EqualTo(0.5700f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_COURTYARD_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_COURTYARD_.flGainHF, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_COURTYARD_.flGainLF, Is.EqualTo(0.6310f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_COURTYARD_.flDecayTime, Is.EqualTo(2.3200f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_COURTYARD_.flDecayHFRatio, Is.EqualTo(0.2900f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_COURTYARD_.flDecayLFRatio, Is.EqualTo(0.5600f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_COURTYARD_.flReflectionsGain, Is.EqualTo(0.2239f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_COURTYARD_.flReflectionsDelay, Is.EqualTo(0.1400f));
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_COURTYARD_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_FACTORY_COURTYARD_.flLateReverbGain, Is.EqualTo(0.3981f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_COURTYARD_.flLateReverbDelay, Is.EqualTo(0.0390f));
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_COURTYARD_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_FACTORY_COURTYARD_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_COURTYARD_.flEchoDepth, Is.EqualTo(0.2900f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_COURTYARD_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_COURTYARD_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_COURTYARD_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(EFX_REVERB_PRESET_FACTORY_COURTYARD_.flHFReference, Is.EqualTo(3762.6001f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_COURTYARD_.flLFReference, Is.EqualTo(362.5000f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_COURTYARD_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_COURTYARD_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_FACTORY_ALCOVE_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_FACTORY_ALCOVE_Test()
    {
        Assert.That(EFX_REVERB_PRESET_FACTORY_ALCOVE_.flDensity, Is.EqualTo(0.3645f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_ALCOVE_.flDiffusion, Is.EqualTo(0.5900f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_ALCOVE_.flGain, Is.EqualTo(0.2512f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_ALCOVE_.flGainHF, Is.EqualTo(0.7943f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_ALCOVE_.flGainLF, Is.EqualTo(0.5012f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_ALCOVE_.flDecayTime, Is.EqualTo(3.1400f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_ALCOVE_.flDecayHFRatio, Is.EqualTo(0.6500f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_ALCOVE_.flDecayLFRatio, Is.EqualTo(1.3100f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_ALCOVE_.flReflectionsGain, Is.EqualTo(1.4125f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_ALCOVE_.flReflectionsDelay, Is.EqualTo(0.0100f));
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_ALCOVE_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_FACTORY_ALCOVE_.flLateReverbGain, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_ALCOVE_.flLateReverbDelay, Is.EqualTo(0.0380f));
        Assert.That(
            EFX_REVERB_PRESET_FACTORY_ALCOVE_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_FACTORY_ALCOVE_.flEchoTime, Is.EqualTo(0.1140f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_ALCOVE_.flEchoDepth, Is.EqualTo(0.1000f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_ALCOVE_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_ALCOVE_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_ALCOVE_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_ALCOVE_.flHFReference, Is.EqualTo(3762.6001f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_ALCOVE_.flLFReference, Is.EqualTo(362.5000f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_ALCOVE_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_FACTORY_ALCOVE_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_ICE_PALACE_SMALL_ROOM_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_ICE_PALACE_SMALL_ROOM_Test()
    {
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_SMALL_ROOM_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_SMALL_ROOM_.flDiffusion, Is.EqualTo(0.8400f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_SMALL_ROOM_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_SMALL_ROOM_.flGainHF, Is.EqualTo(0.5623f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_SMALL_ROOM_.flGainLF, Is.EqualTo(0.2818f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_SMALL_ROOM_.flDecayTime, Is.EqualTo(1.5100f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_SMALL_ROOM_.flDecayHFRatio, Is.EqualTo(1.5300f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_SMALL_ROOM_.flDecayLFRatio, Is.EqualTo(0.2700f));
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_SMALL_ROOM_.flReflectionsGain,
            Is.EqualTo(0.8913f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_SMALL_ROOM_.flReflectionsDelay,
            Is.EqualTo(0.0100f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_SMALL_ROOM_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_SMALL_ROOM_.flLateReverbGain, Is.EqualTo(1.4125f));
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_SMALL_ROOM_.flLateReverbDelay,
            Is.EqualTo(0.0110f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_SMALL_ROOM_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_SMALL_ROOM_.flEchoTime, Is.EqualTo(0.1640f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_SMALL_ROOM_.flEchoDepth, Is.EqualTo(0.1400f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_SMALL_ROOM_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_SMALL_ROOM_.flModulationDepth,
            Is.EqualTo(0.0000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_SMALL_ROOM_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_SMALL_ROOM_.flHFReference,
            Is.EqualTo(12428.5000f)
        );
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_SMALL_ROOM_.flLFReference, Is.EqualTo(99.6000f));
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_SMALL_ROOM_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_SMALL_ROOM_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_ICE_PALACE_SHORT_PASSAGE_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_ICE_PALACE_SHORT_PASSAGE_Test()
    {
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_SHORT_PASSAGE_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_SHORT_PASSAGE_.flDiffusion, Is.EqualTo(0.7500f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_SHORT_PASSAGE_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_SHORT_PASSAGE_.flGainHF, Is.EqualTo(0.5623f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_SHORT_PASSAGE_.flGainLF, Is.EqualTo(0.2818f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_SHORT_PASSAGE_.flDecayTime, Is.EqualTo(1.7900f));
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_SHORT_PASSAGE_.flDecayHFRatio,
            Is.EqualTo(1.4600f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_SHORT_PASSAGE_.flDecayLFRatio,
            Is.EqualTo(0.2800f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_SHORT_PASSAGE_.flReflectionsGain,
            Is.EqualTo(0.5012f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_SHORT_PASSAGE_.flReflectionsDelay,
            Is.EqualTo(0.0100f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_SHORT_PASSAGE_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_SHORT_PASSAGE_.flLateReverbGain,
            Is.EqualTo(1.1220f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_SHORT_PASSAGE_.flLateReverbDelay,
            Is.EqualTo(0.0190f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_SHORT_PASSAGE_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_SHORT_PASSAGE_.flEchoTime, Is.EqualTo(0.1770f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_SHORT_PASSAGE_.flEchoDepth, Is.EqualTo(0.0900f));
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_SHORT_PASSAGE_.flModulationTime,
            Is.EqualTo(0.2500f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_SHORT_PASSAGE_.flModulationDepth,
            Is.EqualTo(0.0000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_SHORT_PASSAGE_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_SHORT_PASSAGE_.flHFReference,
            Is.EqualTo(12428.5000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_SHORT_PASSAGE_.flLFReference,
            Is.EqualTo(99.6000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_SHORT_PASSAGE_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_SHORT_PASSAGE_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_ICE_PALACE_MEDIUM_ROOM_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_ICE_PALACE_MEDIUM_ROOM_Test()
    {
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_MEDIUM_ROOM_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_MEDIUM_ROOM_.flDiffusion, Is.EqualTo(0.8700f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_MEDIUM_ROOM_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_MEDIUM_ROOM_.flGainHF, Is.EqualTo(0.5623f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_MEDIUM_ROOM_.flGainLF, Is.EqualTo(0.4467f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_MEDIUM_ROOM_.flDecayTime, Is.EqualTo(2.2200f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_MEDIUM_ROOM_.flDecayHFRatio, Is.EqualTo(1.5300f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_MEDIUM_ROOM_.flDecayLFRatio, Is.EqualTo(0.3200f));
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_MEDIUM_ROOM_.flReflectionsGain,
            Is.EqualTo(0.3981f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_MEDIUM_ROOM_.flReflectionsDelay,
            Is.EqualTo(0.0390f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_MEDIUM_ROOM_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_MEDIUM_ROOM_.flLateReverbGain,
            Is.EqualTo(1.1220f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_MEDIUM_ROOM_.flLateReverbDelay,
            Is.EqualTo(0.0270f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_MEDIUM_ROOM_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_MEDIUM_ROOM_.flEchoTime, Is.EqualTo(0.1860f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_MEDIUM_ROOM_.flEchoDepth, Is.EqualTo(0.1200f));
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_MEDIUM_ROOM_.flModulationTime,
            Is.EqualTo(0.2500f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_MEDIUM_ROOM_.flModulationDepth,
            Is.EqualTo(0.0000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_MEDIUM_ROOM_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_MEDIUM_ROOM_.flHFReference,
            Is.EqualTo(12428.5000f)
        );
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_MEDIUM_ROOM_.flLFReference, Is.EqualTo(99.6000f));
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_MEDIUM_ROOM_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_MEDIUM_ROOM_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_ICE_PALACE_LARGE_ROOM_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_ICE_PALACE_LARGE_ROOM_Test()
    {
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_LARGE_ROOM_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_LARGE_ROOM_.flDiffusion, Is.EqualTo(0.8100f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_LARGE_ROOM_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_LARGE_ROOM_.flGainHF, Is.EqualTo(0.5623f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_LARGE_ROOM_.flGainLF, Is.EqualTo(0.4467f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_LARGE_ROOM_.flDecayTime, Is.EqualTo(3.1400f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_LARGE_ROOM_.flDecayHFRatio, Is.EqualTo(1.5300f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_LARGE_ROOM_.flDecayLFRatio, Is.EqualTo(0.3200f));
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_LARGE_ROOM_.flReflectionsGain,
            Is.EqualTo(0.2512f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_LARGE_ROOM_.flReflectionsDelay,
            Is.EqualTo(0.0390f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_LARGE_ROOM_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_LARGE_ROOM_.flLateReverbGain, Is.EqualTo(1.0000f));
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_LARGE_ROOM_.flLateReverbDelay,
            Is.EqualTo(0.0270f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_LARGE_ROOM_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_LARGE_ROOM_.flEchoTime, Is.EqualTo(0.2140f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_LARGE_ROOM_.flEchoDepth, Is.EqualTo(0.1100f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_LARGE_ROOM_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_LARGE_ROOM_.flModulationDepth,
            Is.EqualTo(0.0000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_LARGE_ROOM_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_LARGE_ROOM_.flHFReference,
            Is.EqualTo(12428.5000f)
        );
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_LARGE_ROOM_.flLFReference, Is.EqualTo(99.6000f));
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_LARGE_ROOM_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_LARGE_ROOM_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_ICE_PALACE_LONG_PASSAGE_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_ICE_PALACE_LONG_PASSAGE_Test()
    {
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_LONG_PASSAGE_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_LONG_PASSAGE_.flDiffusion, Is.EqualTo(0.7700f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_LONG_PASSAGE_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_LONG_PASSAGE_.flGainHF, Is.EqualTo(0.5623f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_LONG_PASSAGE_.flGainLF, Is.EqualTo(0.3981f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_LONG_PASSAGE_.flDecayTime, Is.EqualTo(3.0100f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_LONG_PASSAGE_.flDecayHFRatio, Is.EqualTo(1.4600f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_LONG_PASSAGE_.flDecayLFRatio, Is.EqualTo(0.2800f));
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_LONG_PASSAGE_.flReflectionsGain,
            Is.EqualTo(0.7943f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_LONG_PASSAGE_.flReflectionsDelay,
            Is.EqualTo(0.0120f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_LONG_PASSAGE_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_LONG_PASSAGE_.flLateReverbGain,
            Is.EqualTo(1.2589f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_LONG_PASSAGE_.flLateReverbDelay,
            Is.EqualTo(0.0250f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_LONG_PASSAGE_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_LONG_PASSAGE_.flEchoTime, Is.EqualTo(0.1860f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_LONG_PASSAGE_.flEchoDepth, Is.EqualTo(0.0400f));
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_LONG_PASSAGE_.flModulationTime,
            Is.EqualTo(0.2500f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_LONG_PASSAGE_.flModulationDepth,
            Is.EqualTo(0.0000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_LONG_PASSAGE_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_LONG_PASSAGE_.flHFReference,
            Is.EqualTo(12428.5000f)
        );
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_LONG_PASSAGE_.flLFReference, Is.EqualTo(99.6000f));
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_LONG_PASSAGE_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_LONG_PASSAGE_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_ICE_PALACE_HALL_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_ICE_PALACE_HALL_Test()
    {
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_HALL_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_HALL_.flDiffusion, Is.EqualTo(0.7600f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_HALL_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_HALL_.flGainHF, Is.EqualTo(0.4467f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_HALL_.flGainLF, Is.EqualTo(0.5623f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_HALL_.flDecayTime, Is.EqualTo(5.4900f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_HALL_.flDecayHFRatio, Is.EqualTo(1.5300f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_HALL_.flDecayLFRatio, Is.EqualTo(0.3800f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_HALL_.flReflectionsGain, Is.EqualTo(0.1122f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_HALL_.flReflectionsDelay, Is.EqualTo(0.0540f));
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_HALL_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_HALL_.flLateReverbGain, Is.EqualTo(0.6310f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_HALL_.flLateReverbDelay, Is.EqualTo(0.0520f));
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_HALL_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_HALL_.flEchoTime, Is.EqualTo(0.2260f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_HALL_.flEchoDepth, Is.EqualTo(0.1100f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_HALL_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_HALL_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_HALL_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_HALL_.flHFReference, Is.EqualTo(12428.5000f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_HALL_.flLFReference, Is.EqualTo(99.6000f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_HALL_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_HALL_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_ICE_PALACE_CUPBOARD_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_ICE_PALACE_CUPBOARD_Test()
    {
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_CUPBOARD_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_CUPBOARD_.flDiffusion, Is.EqualTo(0.8300f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_CUPBOARD_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_CUPBOARD_.flGainHF, Is.EqualTo(0.5012f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_CUPBOARD_.flGainLF, Is.EqualTo(0.2239f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_CUPBOARD_.flDecayTime, Is.EqualTo(0.7600f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_CUPBOARD_.flDecayHFRatio, Is.EqualTo(1.5300f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_CUPBOARD_.flDecayLFRatio, Is.EqualTo(0.2600f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_CUPBOARD_.flReflectionsGain, Is.EqualTo(1.1220f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_CUPBOARD_.flReflectionsDelay, Is.EqualTo(0.0120f));
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_CUPBOARD_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_CUPBOARD_.flLateReverbGain, Is.EqualTo(1.9953f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_CUPBOARD_.flLateReverbDelay, Is.EqualTo(0.0160f));
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_CUPBOARD_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_CUPBOARD_.flEchoTime, Is.EqualTo(0.1430f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_CUPBOARD_.flEchoDepth, Is.EqualTo(0.0800f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_CUPBOARD_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_CUPBOARD_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_CUPBOARD_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_CUPBOARD_.flHFReference, Is.EqualTo(12428.5000f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_CUPBOARD_.flLFReference, Is.EqualTo(99.6000f));
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_CUPBOARD_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_CUPBOARD_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_ICE_PALACE_COURTYARD_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_ICE_PALACE_COURTYARD_Test()
    {
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_COURTYARD_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_COURTYARD_.flDiffusion, Is.EqualTo(0.5900f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_COURTYARD_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_COURTYARD_.flGainHF, Is.EqualTo(0.2818f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_COURTYARD_.flGainLF, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_COURTYARD_.flDecayTime, Is.EqualTo(2.0400f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_COURTYARD_.flDecayHFRatio, Is.EqualTo(1.2000f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_COURTYARD_.flDecayLFRatio, Is.EqualTo(0.3800f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_COURTYARD_.flReflectionsGain, Is.EqualTo(0.3162f));
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_COURTYARD_.flReflectionsDelay,
            Is.EqualTo(0.1730f)
        );
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_COURTYARD_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_COURTYARD_.flLateReverbGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_COURTYARD_.flLateReverbDelay, Is.EqualTo(0.0430f));
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_COURTYARD_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_COURTYARD_.flEchoTime, Is.EqualTo(0.2350f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_COURTYARD_.flEchoDepth, Is.EqualTo(0.4800f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_COURTYARD_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_COURTYARD_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_COURTYARD_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_COURTYARD_.flHFReference, Is.EqualTo(12428.5000f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_COURTYARD_.flLFReference, Is.EqualTo(99.6000f));
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_COURTYARD_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_COURTYARD_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_ICE_PALACE_ALCOVE_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_ICE_PALACE_ALCOVE_Test()
    {
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_ALCOVE_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_ALCOVE_.flDiffusion, Is.EqualTo(0.8400f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_ALCOVE_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_ALCOVE_.flGainHF, Is.EqualTo(0.5623f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_ALCOVE_.flGainLF, Is.EqualTo(0.2818f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_ALCOVE_.flDecayTime, Is.EqualTo(2.7600f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_ALCOVE_.flDecayHFRatio, Is.EqualTo(1.4600f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_ALCOVE_.flDecayLFRatio, Is.EqualTo(0.2800f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_ALCOVE_.flReflectionsGain, Is.EqualTo(1.1220f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_ALCOVE_.flReflectionsDelay, Is.EqualTo(0.0100f));
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_ALCOVE_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_ALCOVE_.flLateReverbGain, Is.EqualTo(0.8913f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_ALCOVE_.flLateReverbDelay, Is.EqualTo(0.0300f));
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_ALCOVE_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_ALCOVE_.flEchoTime, Is.EqualTo(0.1610f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_ALCOVE_.flEchoDepth, Is.EqualTo(0.0900f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_ALCOVE_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_ALCOVE_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_ICE_PALACE_ALCOVE_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_ALCOVE_.flHFReference, Is.EqualTo(12428.5000f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_ALCOVE_.flLFReference, Is.EqualTo(99.6000f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_ALCOVE_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_ICE_PALACE_ALCOVE_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_SPACE_STATION_SMALL_ROOM_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_SPACE_STATION_SMALL_ROOM_Test()
    {
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_SMALL_ROOM_.flDensity, Is.EqualTo(0.2109f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_SMALL_ROOM_.flDiffusion, Is.EqualTo(0.7000f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_SMALL_ROOM_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_SMALL_ROOM_.flGainHF, Is.EqualTo(0.7079f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_SMALL_ROOM_.flGainLF, Is.EqualTo(0.8913f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_SMALL_ROOM_.flDecayTime, Is.EqualTo(1.7200f));
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SMALL_ROOM_.flDecayHFRatio,
            Is.EqualTo(0.8200f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SMALL_ROOM_.flDecayLFRatio,
            Is.EqualTo(0.5500f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SMALL_ROOM_.flReflectionsGain,
            Is.EqualTo(0.7943f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SMALL_ROOM_.flReflectionsDelay,
            Is.EqualTo(0.0070f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SMALL_ROOM_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SMALL_ROOM_.flLateReverbGain,
            Is.EqualTo(1.4125f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SMALL_ROOM_.flLateReverbDelay,
            Is.EqualTo(0.0130f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SMALL_ROOM_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_SMALL_ROOM_.flEchoTime, Is.EqualTo(0.1880f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_SMALL_ROOM_.flEchoDepth, Is.EqualTo(0.2600f));
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SMALL_ROOM_.flModulationTime,
            Is.EqualTo(0.2500f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SMALL_ROOM_.flModulationDepth,
            Is.EqualTo(0.0000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SMALL_ROOM_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SMALL_ROOM_.flHFReference,
            Is.EqualTo(3316.1001f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SMALL_ROOM_.flLFReference,
            Is.EqualTo(458.2000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SMALL_ROOM_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_SMALL_ROOM_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_SPACE_STATION_SHORT_PASSAGE_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_SPACE_STATION_SHORT_PASSAGE_Test()
    {
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_SHORT_PASSAGE_.flDensity, Is.EqualTo(0.2109f));
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SHORT_PASSAGE_.flDiffusion,
            Is.EqualTo(0.8700f)
        );
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_SHORT_PASSAGE_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_SHORT_PASSAGE_.flGainHF, Is.EqualTo(0.6310f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_SHORT_PASSAGE_.flGainLF, Is.EqualTo(0.8913f));
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SHORT_PASSAGE_.flDecayTime,
            Is.EqualTo(3.5700f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SHORT_PASSAGE_.flDecayHFRatio,
            Is.EqualTo(0.5000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SHORT_PASSAGE_.flDecayLFRatio,
            Is.EqualTo(0.5500f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SHORT_PASSAGE_.flReflectionsGain,
            Is.EqualTo(1.0000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SHORT_PASSAGE_.flReflectionsDelay,
            Is.EqualTo(0.0120f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SHORT_PASSAGE_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SHORT_PASSAGE_.flLateReverbGain,
            Is.EqualTo(1.1220f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SHORT_PASSAGE_.flLateReverbDelay,
            Is.EqualTo(0.0160f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SHORT_PASSAGE_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_SHORT_PASSAGE_.flEchoTime, Is.EqualTo(0.1720f));
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SHORT_PASSAGE_.flEchoDepth,
            Is.EqualTo(0.2000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SHORT_PASSAGE_.flModulationTime,
            Is.EqualTo(0.2500f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SHORT_PASSAGE_.flModulationDepth,
            Is.EqualTo(0.0000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SHORT_PASSAGE_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SHORT_PASSAGE_.flHFReference,
            Is.EqualTo(3316.1001f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SHORT_PASSAGE_.flLFReference,
            Is.EqualTo(458.2000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_SHORT_PASSAGE_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_SHORT_PASSAGE_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_SPACE_STATION_MEDIUM_ROOM_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_SPACE_STATION_MEDIUM_ROOM_Test()
    {
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_MEDIUM_ROOM_.flDensity, Is.EqualTo(0.2109f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_MEDIUM_ROOM_.flDiffusion, Is.EqualTo(0.7500f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_MEDIUM_ROOM_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_MEDIUM_ROOM_.flGainHF, Is.EqualTo(0.6310f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_MEDIUM_ROOM_.flGainLF, Is.EqualTo(0.8913f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_MEDIUM_ROOM_.flDecayTime, Is.EqualTo(3.0100f));
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_MEDIUM_ROOM_.flDecayHFRatio,
            Is.EqualTo(0.5000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_MEDIUM_ROOM_.flDecayLFRatio,
            Is.EqualTo(0.5500f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_MEDIUM_ROOM_.flReflectionsGain,
            Is.EqualTo(0.3981f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_MEDIUM_ROOM_.flReflectionsDelay,
            Is.EqualTo(0.0340f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_MEDIUM_ROOM_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_MEDIUM_ROOM_.flLateReverbGain,
            Is.EqualTo(1.1220f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_MEDIUM_ROOM_.flLateReverbDelay,
            Is.EqualTo(0.0350f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_MEDIUM_ROOM_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_MEDIUM_ROOM_.flEchoTime, Is.EqualTo(0.2090f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_MEDIUM_ROOM_.flEchoDepth, Is.EqualTo(0.3100f));
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_MEDIUM_ROOM_.flModulationTime,
            Is.EqualTo(0.2500f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_MEDIUM_ROOM_.flModulationDepth,
            Is.EqualTo(0.0000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_MEDIUM_ROOM_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_MEDIUM_ROOM_.flHFReference,
            Is.EqualTo(3316.1001f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_MEDIUM_ROOM_.flLFReference,
            Is.EqualTo(458.2000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_MEDIUM_ROOM_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_MEDIUM_ROOM_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_SPACE_STATION_LARGE_ROOM_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_SPACE_STATION_LARGE_ROOM_Test()
    {
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_LARGE_ROOM_.flDensity, Is.EqualTo(0.3645f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_LARGE_ROOM_.flDiffusion, Is.EqualTo(0.8100f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_LARGE_ROOM_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_LARGE_ROOM_.flGainHF, Is.EqualTo(0.6310f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_LARGE_ROOM_.flGainLF, Is.EqualTo(0.8913f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_LARGE_ROOM_.flDecayTime, Is.EqualTo(3.8900f));
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_LARGE_ROOM_.flDecayHFRatio,
            Is.EqualTo(0.3800f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_LARGE_ROOM_.flDecayLFRatio,
            Is.EqualTo(0.6100f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_LARGE_ROOM_.flReflectionsGain,
            Is.EqualTo(0.3162f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_LARGE_ROOM_.flReflectionsDelay,
            Is.EqualTo(0.0560f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_LARGE_ROOM_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_LARGE_ROOM_.flLateReverbGain,
            Is.EqualTo(0.8913f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_LARGE_ROOM_.flLateReverbDelay,
            Is.EqualTo(0.0350f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_LARGE_ROOM_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_LARGE_ROOM_.flEchoTime, Is.EqualTo(0.2330f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_LARGE_ROOM_.flEchoDepth, Is.EqualTo(0.2800f));
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_LARGE_ROOM_.flModulationTime,
            Is.EqualTo(0.2500f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_LARGE_ROOM_.flModulationDepth,
            Is.EqualTo(0.0000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_LARGE_ROOM_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_LARGE_ROOM_.flHFReference,
            Is.EqualTo(3316.1001f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_LARGE_ROOM_.flLFReference,
            Is.EqualTo(458.2000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_LARGE_ROOM_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_LARGE_ROOM_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_SPACE_STATION_LONG_PASSAGE_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_SPACE_STATION_LONG_PASSAGE_Test()
    {
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_LONG_PASSAGE_.flDensity, Is.EqualTo(0.4287f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_LONG_PASSAGE_.flDiffusion, Is.EqualTo(0.8200f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_LONG_PASSAGE_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_LONG_PASSAGE_.flGainHF, Is.EqualTo(0.6310f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_LONG_PASSAGE_.flGainLF, Is.EqualTo(0.8913f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_LONG_PASSAGE_.flDecayTime, Is.EqualTo(4.6200f));
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_LONG_PASSAGE_.flDecayHFRatio,
            Is.EqualTo(0.6200f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_LONG_PASSAGE_.flDecayLFRatio,
            Is.EqualTo(0.5500f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_LONG_PASSAGE_.flReflectionsGain,
            Is.EqualTo(1.0000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_LONG_PASSAGE_.flReflectionsDelay,
            Is.EqualTo(0.0120f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_LONG_PASSAGE_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_LONG_PASSAGE_.flLateReverbGain,
            Is.EqualTo(1.2589f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_LONG_PASSAGE_.flLateReverbDelay,
            Is.EqualTo(0.0310f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_LONG_PASSAGE_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_LONG_PASSAGE_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_LONG_PASSAGE_.flEchoDepth, Is.EqualTo(0.2300f));
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_LONG_PASSAGE_.flModulationTime,
            Is.EqualTo(0.2500f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_LONG_PASSAGE_.flModulationDepth,
            Is.EqualTo(0.0000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_LONG_PASSAGE_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_LONG_PASSAGE_.flHFReference,
            Is.EqualTo(3316.1001f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_LONG_PASSAGE_.flLFReference,
            Is.EqualTo(458.2000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_LONG_PASSAGE_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_LONG_PASSAGE_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_SPACE_STATION_HALL_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_SPACE_STATION_HALL_Test()
    {
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_HALL_.flDensity, Is.EqualTo(0.4287f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_HALL_.flDiffusion, Is.EqualTo(0.8700f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_HALL_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_HALL_.flGainHF, Is.EqualTo(0.6310f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_HALL_.flGainLF, Is.EqualTo(0.8913f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_HALL_.flDecayTime, Is.EqualTo(7.1100f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_HALL_.flDecayHFRatio, Is.EqualTo(0.3800f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_HALL_.flDecayLFRatio, Is.EqualTo(0.6100f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_HALL_.flReflectionsGain, Is.EqualTo(0.1778f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_HALL_.flReflectionsDelay, Is.EqualTo(0.1000f));
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_HALL_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_HALL_.flLateReverbGain, Is.EqualTo(0.6310f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_HALL_.flLateReverbDelay, Is.EqualTo(0.0470f));
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_HALL_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_HALL_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_HALL_.flEchoDepth, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_HALL_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_HALL_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_HALL_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_HALL_.flHFReference, Is.EqualTo(3316.1001f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_HALL_.flLFReference, Is.EqualTo(458.2000f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_HALL_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_HALL_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_SPACE_STATION_CUPBOARD_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_SPACE_STATION_CUPBOARD_Test()
    {
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_CUPBOARD_.flDensity, Is.EqualTo(0.1715f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_CUPBOARD_.flDiffusion, Is.EqualTo(0.5600f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_CUPBOARD_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_CUPBOARD_.flGainHF, Is.EqualTo(0.7079f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_CUPBOARD_.flGainLF, Is.EqualTo(0.8913f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_CUPBOARD_.flDecayTime, Is.EqualTo(0.7900f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_CUPBOARD_.flDecayHFRatio, Is.EqualTo(0.8100f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_CUPBOARD_.flDecayLFRatio, Is.EqualTo(0.5500f));
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_CUPBOARD_.flReflectionsGain,
            Is.EqualTo(1.4125f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_CUPBOARD_.flReflectionsDelay,
            Is.EqualTo(0.0070f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_CUPBOARD_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_CUPBOARD_.flLateReverbGain,
            Is.EqualTo(1.7783f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_CUPBOARD_.flLateReverbDelay,
            Is.EqualTo(0.0180f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_CUPBOARD_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_CUPBOARD_.flEchoTime, Is.EqualTo(0.1810f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_CUPBOARD_.flEchoDepth, Is.EqualTo(0.3100f));
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_CUPBOARD_.flModulationTime,
            Is.EqualTo(0.2500f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_CUPBOARD_.flModulationDepth,
            Is.EqualTo(0.0000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_CUPBOARD_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_CUPBOARD_.flHFReference,
            Is.EqualTo(3316.1001f)
        );
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_CUPBOARD_.flLFReference, Is.EqualTo(458.2000f));
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_CUPBOARD_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_CUPBOARD_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_SPACE_STATION_ALCOVE_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_SPACE_STATION_ALCOVE_Test()
    {
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_ALCOVE_.flDensity, Is.EqualTo(0.2109f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_ALCOVE_.flDiffusion, Is.EqualTo(0.7800f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_ALCOVE_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_ALCOVE_.flGainHF, Is.EqualTo(0.7079f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_ALCOVE_.flGainLF, Is.EqualTo(0.8913f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_ALCOVE_.flDecayTime, Is.EqualTo(1.1600f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_ALCOVE_.flDecayHFRatio, Is.EqualTo(0.8100f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_ALCOVE_.flDecayLFRatio, Is.EqualTo(0.5500f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_ALCOVE_.flReflectionsGain, Is.EqualTo(1.4125f));
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_ALCOVE_.flReflectionsDelay,
            Is.EqualTo(0.0070f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_ALCOVE_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_ALCOVE_.flLateReverbGain, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_ALCOVE_.flLateReverbDelay, Is.EqualTo(0.0180f));
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_ALCOVE_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_ALCOVE_.flEchoTime, Is.EqualTo(0.1920f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_ALCOVE_.flEchoDepth, Is.EqualTo(0.2100f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_ALCOVE_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_ALCOVE_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_ALCOVE_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_ALCOVE_.flHFReference, Is.EqualTo(3316.1001f));
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_ALCOVE_.flLFReference, Is.EqualTo(458.2000f));
        Assert.That(
            EFX_REVERB_PRESET_SPACE_STATION_ALCOVE_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_SPACE_STATION_ALCOVE_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_WOODEN_SMALL_ROOM_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_WOODEN_SMALL_ROOM_Test()
    {
        Assert.That(EFX_REVERB_PRESET_WOODEN_SMALL_ROOM_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_SMALL_ROOM_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_SMALL_ROOM_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_SMALL_ROOM_.flGainHF, Is.EqualTo(0.1122f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_SMALL_ROOM_.flGainLF, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_SMALL_ROOM_.flDecayTime, Is.EqualTo(0.7900f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_SMALL_ROOM_.flDecayHFRatio, Is.EqualTo(0.3200f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_SMALL_ROOM_.flDecayLFRatio, Is.EqualTo(0.8700f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_SMALL_ROOM_.flReflectionsGain, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_SMALL_ROOM_.flReflectionsDelay, Is.EqualTo(0.0320f));
        Assert.That(
            EFX_REVERB_PRESET_WOODEN_SMALL_ROOM_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_WOODEN_SMALL_ROOM_.flLateReverbGain, Is.EqualTo(0.8913f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_SMALL_ROOM_.flLateReverbDelay, Is.EqualTo(0.0290f));
        Assert.That(
            EFX_REVERB_PRESET_WOODEN_SMALL_ROOM_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_WOODEN_SMALL_ROOM_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_SMALL_ROOM_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_SMALL_ROOM_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_SMALL_ROOM_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_WOODEN_SMALL_ROOM_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(EFX_REVERB_PRESET_WOODEN_SMALL_ROOM_.flHFReference, Is.EqualTo(4705.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_SMALL_ROOM_.flLFReference, Is.EqualTo(99.6000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_SMALL_ROOM_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_SMALL_ROOM_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_WOODEN_SHORT_PASSAGE_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_WOODEN_SHORT_PASSAGE_Test()
    {
        Assert.That(EFX_REVERB_PRESET_WOODEN_SHORT_PASSAGE_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_SHORT_PASSAGE_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_SHORT_PASSAGE_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_SHORT_PASSAGE_.flGainHF, Is.EqualTo(0.1259f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_SHORT_PASSAGE_.flGainLF, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_SHORT_PASSAGE_.flDecayTime, Is.EqualTo(1.7500f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_SHORT_PASSAGE_.flDecayHFRatio, Is.EqualTo(0.5000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_SHORT_PASSAGE_.flDecayLFRatio, Is.EqualTo(0.8700f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_SHORT_PASSAGE_.flReflectionsGain, Is.EqualTo(0.8913f));
        Assert.That(
            EFX_REVERB_PRESET_WOODEN_SHORT_PASSAGE_.flReflectionsDelay,
            Is.EqualTo(0.0120f)
        );
        Assert.That(
            EFX_REVERB_PRESET_WOODEN_SHORT_PASSAGE_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_WOODEN_SHORT_PASSAGE_.flLateReverbGain, Is.EqualTo(0.6310f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_SHORT_PASSAGE_.flLateReverbDelay, Is.EqualTo(0.0240f));
        Assert.That(
            EFX_REVERB_PRESET_WOODEN_SHORT_PASSAGE_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_WOODEN_SHORT_PASSAGE_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_SHORT_PASSAGE_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_SHORT_PASSAGE_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_SHORT_PASSAGE_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_WOODEN_SHORT_PASSAGE_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(EFX_REVERB_PRESET_WOODEN_SHORT_PASSAGE_.flHFReference, Is.EqualTo(4705.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_SHORT_PASSAGE_.flLFReference, Is.EqualTo(99.6000f));
        Assert.That(
            EFX_REVERB_PRESET_WOODEN_SHORT_PASSAGE_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_WOODEN_SHORT_PASSAGE_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_WOODEN_MEDIUM_ROOM_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_WOODEN_MEDIUM_ROOM_Test()
    {
        Assert.That(EFX_REVERB_PRESET_WOODEN_MEDIUM_ROOM_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_MEDIUM_ROOM_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_MEDIUM_ROOM_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_MEDIUM_ROOM_.flGainHF, Is.EqualTo(0.1000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_MEDIUM_ROOM_.flGainLF, Is.EqualTo(0.2818f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_MEDIUM_ROOM_.flDecayTime, Is.EqualTo(1.4700f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_MEDIUM_ROOM_.flDecayHFRatio, Is.EqualTo(0.4200f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_MEDIUM_ROOM_.flDecayLFRatio, Is.EqualTo(0.8200f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_MEDIUM_ROOM_.flReflectionsGain, Is.EqualTo(0.8913f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_MEDIUM_ROOM_.flReflectionsDelay, Is.EqualTo(0.0490f));
        Assert.That(
            EFX_REVERB_PRESET_WOODEN_MEDIUM_ROOM_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_WOODEN_MEDIUM_ROOM_.flLateReverbGain, Is.EqualTo(0.8913f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_MEDIUM_ROOM_.flLateReverbDelay, Is.EqualTo(0.0290f));
        Assert.That(
            EFX_REVERB_PRESET_WOODEN_MEDIUM_ROOM_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_WOODEN_MEDIUM_ROOM_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_MEDIUM_ROOM_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_MEDIUM_ROOM_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_MEDIUM_ROOM_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_WOODEN_MEDIUM_ROOM_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(EFX_REVERB_PRESET_WOODEN_MEDIUM_ROOM_.flHFReference, Is.EqualTo(4705.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_MEDIUM_ROOM_.flLFReference, Is.EqualTo(99.6000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_MEDIUM_ROOM_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_MEDIUM_ROOM_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_WOODEN_LARGE_ROOM_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_WOODEN_LARGE_ROOM_Test()
    {
        Assert.That(EFX_REVERB_PRESET_WOODEN_LARGE_ROOM_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_LARGE_ROOM_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_LARGE_ROOM_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_LARGE_ROOM_.flGainHF, Is.EqualTo(0.0891f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_LARGE_ROOM_.flGainLF, Is.EqualTo(0.2818f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_LARGE_ROOM_.flDecayTime, Is.EqualTo(2.6500f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_LARGE_ROOM_.flDecayHFRatio, Is.EqualTo(0.3300f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_LARGE_ROOM_.flDecayLFRatio, Is.EqualTo(0.8200f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_LARGE_ROOM_.flReflectionsGain, Is.EqualTo(0.8913f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_LARGE_ROOM_.flReflectionsDelay, Is.EqualTo(0.0660f));
        Assert.That(
            EFX_REVERB_PRESET_WOODEN_LARGE_ROOM_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_WOODEN_LARGE_ROOM_.flLateReverbGain, Is.EqualTo(0.7943f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_LARGE_ROOM_.flLateReverbDelay, Is.EqualTo(0.0490f));
        Assert.That(
            EFX_REVERB_PRESET_WOODEN_LARGE_ROOM_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_WOODEN_LARGE_ROOM_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_LARGE_ROOM_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_LARGE_ROOM_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_LARGE_ROOM_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_WOODEN_LARGE_ROOM_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(EFX_REVERB_PRESET_WOODEN_LARGE_ROOM_.flHFReference, Is.EqualTo(4705.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_LARGE_ROOM_.flLFReference, Is.EqualTo(99.6000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_LARGE_ROOM_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_LARGE_ROOM_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_WOODEN_LONG_PASSAGE_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_WOODEN_LONG_PASSAGE_Test()
    {
        Assert.That(EFX_REVERB_PRESET_WOODEN_LONG_PASSAGE_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_LONG_PASSAGE_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_LONG_PASSAGE_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_LONG_PASSAGE_.flGainHF, Is.EqualTo(0.1000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_LONG_PASSAGE_.flGainLF, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_LONG_PASSAGE_.flDecayTime, Is.EqualTo(1.9900f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_LONG_PASSAGE_.flDecayHFRatio, Is.EqualTo(0.4000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_LONG_PASSAGE_.flDecayLFRatio, Is.EqualTo(0.7900f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_LONG_PASSAGE_.flReflectionsGain, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_LONG_PASSAGE_.flReflectionsDelay, Is.EqualTo(0.0200f));
        Assert.That(
            EFX_REVERB_PRESET_WOODEN_LONG_PASSAGE_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_WOODEN_LONG_PASSAGE_.flLateReverbGain, Is.EqualTo(0.4467f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_LONG_PASSAGE_.flLateReverbDelay, Is.EqualTo(0.0360f));
        Assert.That(
            EFX_REVERB_PRESET_WOODEN_LONG_PASSAGE_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_WOODEN_LONG_PASSAGE_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_LONG_PASSAGE_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_LONG_PASSAGE_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_LONG_PASSAGE_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_WOODEN_LONG_PASSAGE_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(EFX_REVERB_PRESET_WOODEN_LONG_PASSAGE_.flHFReference, Is.EqualTo(4705.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_LONG_PASSAGE_.flLFReference, Is.EqualTo(99.6000f));
        Assert.That(
            EFX_REVERB_PRESET_WOODEN_LONG_PASSAGE_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_WOODEN_LONG_PASSAGE_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_WOODEN_HALL_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_WOODEN_HALL_Test()
    {
        Assert.That(EFX_REVERB_PRESET_WOODEN_HALL_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_HALL_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_HALL_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_HALL_.flGainHF, Is.EqualTo(0.0794f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_HALL_.flGainLF, Is.EqualTo(0.2818f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_HALL_.flDecayTime, Is.EqualTo(3.4500f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_HALL_.flDecayHFRatio, Is.EqualTo(0.3000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_HALL_.flDecayLFRatio, Is.EqualTo(0.8200f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_HALL_.flReflectionsGain, Is.EqualTo(0.8913f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_HALL_.flReflectionsDelay, Is.EqualTo(0.0880f));
        Assert.That(
            EFX_REVERB_PRESET_WOODEN_HALL_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_WOODEN_HALL_.flLateReverbGain, Is.EqualTo(0.7943f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_HALL_.flLateReverbDelay, Is.EqualTo(0.0630f));
        Assert.That(
            EFX_REVERB_PRESET_WOODEN_HALL_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_WOODEN_HALL_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_HALL_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_HALL_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_HALL_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_HALL_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_HALL_.flHFReference, Is.EqualTo(4705.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_HALL_.flLFReference, Is.EqualTo(99.6000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_HALL_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_HALL_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_WOODEN_CUPBOARD_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_WOODEN_CUPBOARD_Test()
    {
        Assert.That(EFX_REVERB_PRESET_WOODEN_CUPBOARD_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_CUPBOARD_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_CUPBOARD_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_CUPBOARD_.flGainHF, Is.EqualTo(0.1413f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_CUPBOARD_.flGainLF, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_CUPBOARD_.flDecayTime, Is.EqualTo(0.5600f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_CUPBOARD_.flDecayHFRatio, Is.EqualTo(0.4600f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_CUPBOARD_.flDecayLFRatio, Is.EqualTo(0.9100f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_CUPBOARD_.flReflectionsGain, Is.EqualTo(1.1220f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_CUPBOARD_.flReflectionsDelay, Is.EqualTo(0.0120f));
        Assert.That(
            EFX_REVERB_PRESET_WOODEN_CUPBOARD_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_WOODEN_CUPBOARD_.flLateReverbGain, Is.EqualTo(1.1220f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_CUPBOARD_.flLateReverbDelay, Is.EqualTo(0.0280f));
        Assert.That(
            EFX_REVERB_PRESET_WOODEN_CUPBOARD_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_WOODEN_CUPBOARD_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_CUPBOARD_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_CUPBOARD_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_CUPBOARD_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_CUPBOARD_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_CUPBOARD_.flHFReference, Is.EqualTo(4705.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_CUPBOARD_.flLFReference, Is.EqualTo(99.6000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_CUPBOARD_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_CUPBOARD_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_WOODEN_COURTYARD_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_WOODEN_COURTYARD_Test()
    {
        Assert.That(EFX_REVERB_PRESET_WOODEN_COURTYARD_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_COURTYARD_.flDiffusion, Is.EqualTo(0.6500f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_COURTYARD_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_COURTYARD_.flGainHF, Is.EqualTo(0.0794f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_COURTYARD_.flGainLF, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_COURTYARD_.flDecayTime, Is.EqualTo(1.7900f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_COURTYARD_.flDecayHFRatio, Is.EqualTo(0.3500f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_COURTYARD_.flDecayLFRatio, Is.EqualTo(0.7900f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_COURTYARD_.flReflectionsGain, Is.EqualTo(0.5623f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_COURTYARD_.flReflectionsDelay, Is.EqualTo(0.1230f));
        Assert.That(
            EFX_REVERB_PRESET_WOODEN_COURTYARD_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_WOODEN_COURTYARD_.flLateReverbGain, Is.EqualTo(0.1000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_COURTYARD_.flLateReverbDelay, Is.EqualTo(0.0320f));
        Assert.That(
            EFX_REVERB_PRESET_WOODEN_COURTYARD_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_WOODEN_COURTYARD_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_COURTYARD_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_COURTYARD_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_COURTYARD_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_COURTYARD_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_COURTYARD_.flHFReference, Is.EqualTo(4705.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_COURTYARD_.flLFReference, Is.EqualTo(99.6000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_COURTYARD_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_COURTYARD_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_WOODEN_ALCOVE_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_WOODEN_ALCOVE_Test()
    {
        Assert.That(EFX_REVERB_PRESET_WOODEN_ALCOVE_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_ALCOVE_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_ALCOVE_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_ALCOVE_.flGainHF, Is.EqualTo(0.1259f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_ALCOVE_.flGainLF, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_ALCOVE_.flDecayTime, Is.EqualTo(1.2200f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_ALCOVE_.flDecayHFRatio, Is.EqualTo(0.6200f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_ALCOVE_.flDecayLFRatio, Is.EqualTo(0.9100f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_ALCOVE_.flReflectionsGain, Is.EqualTo(1.1220f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_ALCOVE_.flReflectionsDelay, Is.EqualTo(0.0120f));
        Assert.That(
            EFX_REVERB_PRESET_WOODEN_ALCOVE_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_WOODEN_ALCOVE_.flLateReverbGain, Is.EqualTo(0.7079f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_ALCOVE_.flLateReverbDelay, Is.EqualTo(0.0240f));
        Assert.That(
            EFX_REVERB_PRESET_WOODEN_ALCOVE_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_WOODEN_ALCOVE_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_ALCOVE_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_ALCOVE_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_ALCOVE_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_ALCOVE_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_ALCOVE_.flHFReference, Is.EqualTo(4705.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_ALCOVE_.flLFReference, Is.EqualTo(99.6000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_ALCOVE_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_WOODEN_ALCOVE_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_SPORT_EMPTY_STADIUM_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_SPORT_EMPTY_STADIUM_Test()
    {
        Assert.That(EFX_REVERB_PRESET_SPORT_EMPTY_STADIUM_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_SPORT_EMPTY_STADIUM_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_SPORT_EMPTY_STADIUM_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_SPORT_EMPTY_STADIUM_.flGainHF, Is.EqualTo(0.4467f));
        Assert.That(EFX_REVERB_PRESET_SPORT_EMPTY_STADIUM_.flGainLF, Is.EqualTo(0.7943f));
        Assert.That(EFX_REVERB_PRESET_SPORT_EMPTY_STADIUM_.flDecayTime, Is.EqualTo(6.2600f));
        Assert.That(EFX_REVERB_PRESET_SPORT_EMPTY_STADIUM_.flDecayHFRatio, Is.EqualTo(0.5100f));
        Assert.That(EFX_REVERB_PRESET_SPORT_EMPTY_STADIUM_.flDecayLFRatio, Is.EqualTo(1.1000f));
        Assert.That(EFX_REVERB_PRESET_SPORT_EMPTY_STADIUM_.flReflectionsGain, Is.EqualTo(0.0631f));
        Assert.That(EFX_REVERB_PRESET_SPORT_EMPTY_STADIUM_.flReflectionsDelay, Is.EqualTo(0.1830f));
        Assert.That(
            EFX_REVERB_PRESET_SPORT_EMPTY_STADIUM_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_SPORT_EMPTY_STADIUM_.flLateReverbGain, Is.EqualTo(0.3981f));
        Assert.That(EFX_REVERB_PRESET_SPORT_EMPTY_STADIUM_.flLateReverbDelay, Is.EqualTo(0.0380f));
        Assert.That(
            EFX_REVERB_PRESET_SPORT_EMPTY_STADIUM_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_SPORT_EMPTY_STADIUM_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_SPORT_EMPTY_STADIUM_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_SPORT_EMPTY_STADIUM_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_SPORT_EMPTY_STADIUM_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_SPORT_EMPTY_STADIUM_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(EFX_REVERB_PRESET_SPORT_EMPTY_STADIUM_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_SPORT_EMPTY_STADIUM_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(
            EFX_REVERB_PRESET_SPORT_EMPTY_STADIUM_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_SPORT_EMPTY_STADIUM_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_SPORT_SQUASH_COURT_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_SPORT_SQUASH_COURT_Test()
    {
        Assert.That(EFX_REVERB_PRESET_SPORT_SQUASH_COURT_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_SPORT_SQUASH_COURT_.flDiffusion, Is.EqualTo(0.7500f));
        Assert.That(EFX_REVERB_PRESET_SPORT_SQUASH_COURT_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_SPORT_SQUASH_COURT_.flGainHF, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_SPORT_SQUASH_COURT_.flGainLF, Is.EqualTo(0.7943f));
        Assert.That(EFX_REVERB_PRESET_SPORT_SQUASH_COURT_.flDecayTime, Is.EqualTo(2.2200f));
        Assert.That(EFX_REVERB_PRESET_SPORT_SQUASH_COURT_.flDecayHFRatio, Is.EqualTo(0.9100f));
        Assert.That(EFX_REVERB_PRESET_SPORT_SQUASH_COURT_.flDecayLFRatio, Is.EqualTo(1.1600f));
        Assert.That(EFX_REVERB_PRESET_SPORT_SQUASH_COURT_.flReflectionsGain, Is.EqualTo(0.4467f));
        Assert.That(EFX_REVERB_PRESET_SPORT_SQUASH_COURT_.flReflectionsDelay, Is.EqualTo(0.0070f));
        Assert.That(
            EFX_REVERB_PRESET_SPORT_SQUASH_COURT_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_SPORT_SQUASH_COURT_.flLateReverbGain, Is.EqualTo(0.7943f));
        Assert.That(EFX_REVERB_PRESET_SPORT_SQUASH_COURT_.flLateReverbDelay, Is.EqualTo(0.0110f));
        Assert.That(
            EFX_REVERB_PRESET_SPORT_SQUASH_COURT_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_SPORT_SQUASH_COURT_.flEchoTime, Is.EqualTo(0.1260f));
        Assert.That(EFX_REVERB_PRESET_SPORT_SQUASH_COURT_.flEchoDepth, Is.EqualTo(0.1900f));
        Assert.That(EFX_REVERB_PRESET_SPORT_SQUASH_COURT_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_SPORT_SQUASH_COURT_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_SPORT_SQUASH_COURT_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(EFX_REVERB_PRESET_SPORT_SQUASH_COURT_.flHFReference, Is.EqualTo(7176.8999f));
        Assert.That(EFX_REVERB_PRESET_SPORT_SQUASH_COURT_.flLFReference, Is.EqualTo(211.2000f));
        Assert.That(EFX_REVERB_PRESET_SPORT_SQUASH_COURT_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_SPORT_SQUASH_COURT_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_SPORT_SMALL_SWIMMING_POOL_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_SPORT_SMALL_SWIMMING_POOL_Test()
    {
        Assert.That(EFX_REVERB_PRESET_SPORT_SMALL_SWIMMING_POOL_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_SPORT_SMALL_SWIMMING_POOL_.flDiffusion, Is.EqualTo(0.7000f));
        Assert.That(EFX_REVERB_PRESET_SPORT_SMALL_SWIMMING_POOL_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_SPORT_SMALL_SWIMMING_POOL_.flGainHF, Is.EqualTo(0.7943f));
        Assert.That(EFX_REVERB_PRESET_SPORT_SMALL_SWIMMING_POOL_.flGainLF, Is.EqualTo(0.8913f));
        Assert.That(EFX_REVERB_PRESET_SPORT_SMALL_SWIMMING_POOL_.flDecayTime, Is.EqualTo(2.7600f));
        Assert.That(
            EFX_REVERB_PRESET_SPORT_SMALL_SWIMMING_POOL_.flDecayHFRatio,
            Is.EqualTo(1.2500f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPORT_SMALL_SWIMMING_POOL_.flDecayLFRatio,
            Is.EqualTo(1.1400f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPORT_SMALL_SWIMMING_POOL_.flReflectionsGain,
            Is.EqualTo(0.6310f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPORT_SMALL_SWIMMING_POOL_.flReflectionsDelay,
            Is.EqualTo(0.0200f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPORT_SMALL_SWIMMING_POOL_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(
            EFX_REVERB_PRESET_SPORT_SMALL_SWIMMING_POOL_.flLateReverbGain,
            Is.EqualTo(0.7943f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPORT_SMALL_SWIMMING_POOL_.flLateReverbDelay,
            Is.EqualTo(0.0300f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPORT_SMALL_SWIMMING_POOL_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_SPORT_SMALL_SWIMMING_POOL_.flEchoTime, Is.EqualTo(0.1790f));
        Assert.That(EFX_REVERB_PRESET_SPORT_SMALL_SWIMMING_POOL_.flEchoDepth, Is.EqualTo(0.1500f));
        Assert.That(
            EFX_REVERB_PRESET_SPORT_SMALL_SWIMMING_POOL_.flModulationTime,
            Is.EqualTo(0.8950f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPORT_SMALL_SWIMMING_POOL_.flModulationDepth,
            Is.EqualTo(0.1900f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPORT_SMALL_SWIMMING_POOL_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPORT_SMALL_SWIMMING_POOL_.flHFReference,
            Is.EqualTo(5000.0000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPORT_SMALL_SWIMMING_POOL_.flLFReference,
            Is.EqualTo(250.0000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPORT_SMALL_SWIMMING_POOL_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_SPORT_SMALL_SWIMMING_POOL_.iDecayHFLimit, Is.EqualTo(0x0));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_SPORT_LARGE_SWIMMING_POOL_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_SPORT_LARGE_SWIMMING_POOL_Test()
    {
        Assert.That(EFX_REVERB_PRESET_SPORT_LARGE_SWIMMING_POOL_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_SPORT_LARGE_SWIMMING_POOL_.flDiffusion, Is.EqualTo(0.8200f));
        Assert.That(EFX_REVERB_PRESET_SPORT_LARGE_SWIMMING_POOL_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_SPORT_LARGE_SWIMMING_POOL_.flGainHF, Is.EqualTo(0.7943f));
        Assert.That(EFX_REVERB_PRESET_SPORT_LARGE_SWIMMING_POOL_.flGainLF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_SPORT_LARGE_SWIMMING_POOL_.flDecayTime, Is.EqualTo(5.4900f));
        Assert.That(
            EFX_REVERB_PRESET_SPORT_LARGE_SWIMMING_POOL_.flDecayHFRatio,
            Is.EqualTo(1.3100f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPORT_LARGE_SWIMMING_POOL_.flDecayLFRatio,
            Is.EqualTo(1.1400f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPORT_LARGE_SWIMMING_POOL_.flReflectionsGain,
            Is.EqualTo(0.4467f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPORT_LARGE_SWIMMING_POOL_.flReflectionsDelay,
            Is.EqualTo(0.0390f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPORT_LARGE_SWIMMING_POOL_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(
            EFX_REVERB_PRESET_SPORT_LARGE_SWIMMING_POOL_.flLateReverbGain,
            Is.EqualTo(0.5012f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPORT_LARGE_SWIMMING_POOL_.flLateReverbDelay,
            Is.EqualTo(0.0490f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPORT_LARGE_SWIMMING_POOL_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_SPORT_LARGE_SWIMMING_POOL_.flEchoTime, Is.EqualTo(0.2220f));
        Assert.That(EFX_REVERB_PRESET_SPORT_LARGE_SWIMMING_POOL_.flEchoDepth, Is.EqualTo(0.5500f));
        Assert.That(
            EFX_REVERB_PRESET_SPORT_LARGE_SWIMMING_POOL_.flModulationTime,
            Is.EqualTo(1.1590f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPORT_LARGE_SWIMMING_POOL_.flModulationDepth,
            Is.EqualTo(0.2100f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPORT_LARGE_SWIMMING_POOL_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPORT_LARGE_SWIMMING_POOL_.flHFReference,
            Is.EqualTo(5000.0000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPORT_LARGE_SWIMMING_POOL_.flLFReference,
            Is.EqualTo(250.0000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPORT_LARGE_SWIMMING_POOL_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_SPORT_LARGE_SWIMMING_POOL_.iDecayHFLimit, Is.EqualTo(0x0));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_SPORT_GYMNASIUM_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_SPORT_GYMNASIUM_Test()
    {
        Assert.That(EFX_REVERB_PRESET_SPORT_GYMNASIUM_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_SPORT_GYMNASIUM_.flDiffusion, Is.EqualTo(0.8100f));
        Assert.That(EFX_REVERB_PRESET_SPORT_GYMNASIUM_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_SPORT_GYMNASIUM_.flGainHF, Is.EqualTo(0.4467f));
        Assert.That(EFX_REVERB_PRESET_SPORT_GYMNASIUM_.flGainLF, Is.EqualTo(0.8913f));
        Assert.That(EFX_REVERB_PRESET_SPORT_GYMNASIUM_.flDecayTime, Is.EqualTo(3.1400f));
        Assert.That(EFX_REVERB_PRESET_SPORT_GYMNASIUM_.flDecayHFRatio, Is.EqualTo(1.0600f));
        Assert.That(EFX_REVERB_PRESET_SPORT_GYMNASIUM_.flDecayLFRatio, Is.EqualTo(1.3500f));
        Assert.That(EFX_REVERB_PRESET_SPORT_GYMNASIUM_.flReflectionsGain, Is.EqualTo(0.3981f));
        Assert.That(EFX_REVERB_PRESET_SPORT_GYMNASIUM_.flReflectionsDelay, Is.EqualTo(0.0290f));
        Assert.That(
            EFX_REVERB_PRESET_SPORT_GYMNASIUM_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_SPORT_GYMNASIUM_.flLateReverbGain, Is.EqualTo(0.5623f));
        Assert.That(EFX_REVERB_PRESET_SPORT_GYMNASIUM_.flLateReverbDelay, Is.EqualTo(0.0450f));
        Assert.That(
            EFX_REVERB_PRESET_SPORT_GYMNASIUM_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_SPORT_GYMNASIUM_.flEchoTime, Is.EqualTo(0.1460f));
        Assert.That(EFX_REVERB_PRESET_SPORT_GYMNASIUM_.flEchoDepth, Is.EqualTo(0.1400f));
        Assert.That(EFX_REVERB_PRESET_SPORT_GYMNASIUM_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_SPORT_GYMNASIUM_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_SPORT_GYMNASIUM_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_SPORT_GYMNASIUM_.flHFReference, Is.EqualTo(7176.8999f));
        Assert.That(EFX_REVERB_PRESET_SPORT_GYMNASIUM_.flLFReference, Is.EqualTo(211.2000f));
        Assert.That(EFX_REVERB_PRESET_SPORT_GYMNASIUM_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_SPORT_GYMNASIUM_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_SPORT_FULL_STADIUM_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_SPORT_FULL_STADIUM_Test()
    {
        Assert.That(EFX_REVERB_PRESET_SPORT_FULL_STADIUM_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_SPORT_FULL_STADIUM_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_SPORT_FULL_STADIUM_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_SPORT_FULL_STADIUM_.flGainHF, Is.EqualTo(0.0708f));
        Assert.That(EFX_REVERB_PRESET_SPORT_FULL_STADIUM_.flGainLF, Is.EqualTo(0.7943f));
        Assert.That(EFX_REVERB_PRESET_SPORT_FULL_STADIUM_.flDecayTime, Is.EqualTo(5.2500f));
        Assert.That(EFX_REVERB_PRESET_SPORT_FULL_STADIUM_.flDecayHFRatio, Is.EqualTo(0.1700f));
        Assert.That(EFX_REVERB_PRESET_SPORT_FULL_STADIUM_.flDecayLFRatio, Is.EqualTo(0.8000f));
        Assert.That(EFX_REVERB_PRESET_SPORT_FULL_STADIUM_.flReflectionsGain, Is.EqualTo(0.1000f));
        Assert.That(EFX_REVERB_PRESET_SPORT_FULL_STADIUM_.flReflectionsDelay, Is.EqualTo(0.1880f));
        Assert.That(
            EFX_REVERB_PRESET_SPORT_FULL_STADIUM_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_SPORT_FULL_STADIUM_.flLateReverbGain, Is.EqualTo(0.2818f));
        Assert.That(EFX_REVERB_PRESET_SPORT_FULL_STADIUM_.flLateReverbDelay, Is.EqualTo(0.0380f));
        Assert.That(
            EFX_REVERB_PRESET_SPORT_FULL_STADIUM_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_SPORT_FULL_STADIUM_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_SPORT_FULL_STADIUM_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_SPORT_FULL_STADIUM_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_SPORT_FULL_STADIUM_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_SPORT_FULL_STADIUM_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(EFX_REVERB_PRESET_SPORT_FULL_STADIUM_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_SPORT_FULL_STADIUM_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_SPORT_FULL_STADIUM_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_SPORT_FULL_STADIUM_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_SPORT_STADIUM_TANNOY_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_SPORT_STADIUM_TANNOY_Test()
    {
        Assert.That(EFX_REVERB_PRESET_SPORT_STADIUM_TANNOY_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_SPORT_STADIUM_TANNOY_.flDiffusion, Is.EqualTo(0.7800f));
        Assert.That(EFX_REVERB_PRESET_SPORT_STADIUM_TANNOY_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_SPORT_STADIUM_TANNOY_.flGainHF, Is.EqualTo(0.5623f));
        Assert.That(EFX_REVERB_PRESET_SPORT_STADIUM_TANNOY_.flGainLF, Is.EqualTo(0.5012f));
        Assert.That(EFX_REVERB_PRESET_SPORT_STADIUM_TANNOY_.flDecayTime, Is.EqualTo(2.5300f));
        Assert.That(EFX_REVERB_PRESET_SPORT_STADIUM_TANNOY_.flDecayHFRatio, Is.EqualTo(0.8800f));
        Assert.That(EFX_REVERB_PRESET_SPORT_STADIUM_TANNOY_.flDecayLFRatio, Is.EqualTo(0.6800f));
        Assert.That(EFX_REVERB_PRESET_SPORT_STADIUM_TANNOY_.flReflectionsGain, Is.EqualTo(0.2818f));
        Assert.That(
            EFX_REVERB_PRESET_SPORT_STADIUM_TANNOY_.flReflectionsDelay,
            Is.EqualTo(0.2300f)
        );
        Assert.That(
            EFX_REVERB_PRESET_SPORT_STADIUM_TANNOY_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_SPORT_STADIUM_TANNOY_.flLateReverbGain, Is.EqualTo(0.5012f));
        Assert.That(EFX_REVERB_PRESET_SPORT_STADIUM_TANNOY_.flLateReverbDelay, Is.EqualTo(0.0630f));
        Assert.That(
            EFX_REVERB_PRESET_SPORT_STADIUM_TANNOY_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_SPORT_STADIUM_TANNOY_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_SPORT_STADIUM_TANNOY_.flEchoDepth, Is.EqualTo(0.2000f));
        Assert.That(EFX_REVERB_PRESET_SPORT_STADIUM_TANNOY_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_SPORT_STADIUM_TANNOY_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_SPORT_STADIUM_TANNOY_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(EFX_REVERB_PRESET_SPORT_STADIUM_TANNOY_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_SPORT_STADIUM_TANNOY_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(
            EFX_REVERB_PRESET_SPORT_STADIUM_TANNOY_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_SPORT_STADIUM_TANNOY_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_PREFAB_WORKSHOP_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_PREFAB_WORKSHOP_Test()
    {
        Assert.That(EFX_REVERB_PRESET_PREFAB_WORKSHOP_.flDensity, Is.EqualTo(0.4287f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_WORKSHOP_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_WORKSHOP_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_WORKSHOP_.flGainHF, Is.EqualTo(0.1413f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_WORKSHOP_.flGainLF, Is.EqualTo(0.3981f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_WORKSHOP_.flDecayTime, Is.EqualTo(0.7600f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_WORKSHOP_.flDecayHFRatio, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_WORKSHOP_.flDecayLFRatio, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_WORKSHOP_.flReflectionsGain, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_WORKSHOP_.flReflectionsDelay, Is.EqualTo(0.0120f));
        Assert.That(
            EFX_REVERB_PRESET_PREFAB_WORKSHOP_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_PREFAB_WORKSHOP_.flLateReverbGain, Is.EqualTo(1.1220f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_WORKSHOP_.flLateReverbDelay, Is.EqualTo(0.0120f));
        Assert.That(
            EFX_REVERB_PRESET_PREFAB_WORKSHOP_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_PREFAB_WORKSHOP_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_WORKSHOP_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_WORKSHOP_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_WORKSHOP_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_WORKSHOP_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_WORKSHOP_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_WORKSHOP_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_WORKSHOP_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_WORKSHOP_.iDecayHFLimit, Is.EqualTo(0x0));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_PREFAB_SCHOOL_ROOM_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_PREFAB_SCHOOL_ROOM_Test()
    {
        Assert.That(EFX_REVERB_PRESET_PREFAB_SCHOOL_ROOM_.flDensity, Is.EqualTo(0.4022f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_SCHOOL_ROOM_.flDiffusion, Is.EqualTo(0.6900f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_SCHOOL_ROOM_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_SCHOOL_ROOM_.flGainHF, Is.EqualTo(0.6310f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_SCHOOL_ROOM_.flGainLF, Is.EqualTo(0.5012f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_SCHOOL_ROOM_.flDecayTime, Is.EqualTo(0.9800f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_SCHOOL_ROOM_.flDecayHFRatio, Is.EqualTo(0.4500f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_SCHOOL_ROOM_.flDecayLFRatio, Is.EqualTo(0.1800f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_SCHOOL_ROOM_.flReflectionsGain, Is.EqualTo(1.4125f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_SCHOOL_ROOM_.flReflectionsDelay, Is.EqualTo(0.0170f));
        Assert.That(
            EFX_REVERB_PRESET_PREFAB_SCHOOL_ROOM_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_PREFAB_SCHOOL_ROOM_.flLateReverbGain, Is.EqualTo(1.4125f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_SCHOOL_ROOM_.flLateReverbDelay, Is.EqualTo(0.0150f));
        Assert.That(
            EFX_REVERB_PRESET_PREFAB_SCHOOL_ROOM_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_PREFAB_SCHOOL_ROOM_.flEchoTime, Is.EqualTo(0.0950f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_SCHOOL_ROOM_.flEchoDepth, Is.EqualTo(0.1400f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_SCHOOL_ROOM_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_SCHOOL_ROOM_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_PREFAB_SCHOOL_ROOM_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(EFX_REVERB_PRESET_PREFAB_SCHOOL_ROOM_.flHFReference, Is.EqualTo(7176.8999f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_SCHOOL_ROOM_.flLFReference, Is.EqualTo(211.2000f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_SCHOOL_ROOM_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_SCHOOL_ROOM_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_PREFAB_PRACTISE_ROOM_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_PREFAB_PRACTISE_ROOM_Test()
    {
        Assert.That(EFX_REVERB_PRESET_PREFAB_PRACTISE_ROOM_.flDensity, Is.EqualTo(0.4022f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_PRACTISE_ROOM_.flDiffusion, Is.EqualTo(0.8700f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_PRACTISE_ROOM_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_PRACTISE_ROOM_.flGainHF, Is.EqualTo(0.3981f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_PRACTISE_ROOM_.flGainLF, Is.EqualTo(0.5012f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_PRACTISE_ROOM_.flDecayTime, Is.EqualTo(1.1200f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_PRACTISE_ROOM_.flDecayHFRatio, Is.EqualTo(0.5600f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_PRACTISE_ROOM_.flDecayLFRatio, Is.EqualTo(0.1800f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_PRACTISE_ROOM_.flReflectionsGain, Is.EqualTo(1.2589f));
        Assert.That(
            EFX_REVERB_PRESET_PREFAB_PRACTISE_ROOM_.flReflectionsDelay,
            Is.EqualTo(0.0100f)
        );
        Assert.That(
            EFX_REVERB_PRESET_PREFAB_PRACTISE_ROOM_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_PREFAB_PRACTISE_ROOM_.flLateReverbGain, Is.EqualTo(1.4125f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_PRACTISE_ROOM_.flLateReverbDelay, Is.EqualTo(0.0110f));
        Assert.That(
            EFX_REVERB_PRESET_PREFAB_PRACTISE_ROOM_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_PREFAB_PRACTISE_ROOM_.flEchoTime, Is.EqualTo(0.0950f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_PRACTISE_ROOM_.flEchoDepth, Is.EqualTo(0.1400f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_PRACTISE_ROOM_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_PRACTISE_ROOM_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_PREFAB_PRACTISE_ROOM_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(EFX_REVERB_PRESET_PREFAB_PRACTISE_ROOM_.flHFReference, Is.EqualTo(7176.8999f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_PRACTISE_ROOM_.flLFReference, Is.EqualTo(211.2000f));
        Assert.That(
            EFX_REVERB_PRESET_PREFAB_PRACTISE_ROOM_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_PREFAB_PRACTISE_ROOM_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_PREFAB_OUTHOUSE_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_PREFAB_OUTHOUSE_Test()
    {
        Assert.That(EFX_REVERB_PRESET_PREFAB_OUTHOUSE_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_OUTHOUSE_.flDiffusion, Is.EqualTo(0.8200f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_OUTHOUSE_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_OUTHOUSE_.flGainHF, Is.EqualTo(0.1122f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_OUTHOUSE_.flGainLF, Is.EqualTo(0.1585f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_OUTHOUSE_.flDecayTime, Is.EqualTo(1.3800f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_OUTHOUSE_.flDecayHFRatio, Is.EqualTo(0.3800f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_OUTHOUSE_.flDecayLFRatio, Is.EqualTo(0.3500f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_OUTHOUSE_.flReflectionsGain, Is.EqualTo(0.8913f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_OUTHOUSE_.flReflectionsDelay, Is.EqualTo(0.0240f));
        Assert.That(
            EFX_REVERB_PRESET_PREFAB_OUTHOUSE_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, -0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_PREFAB_OUTHOUSE_.flLateReverbGain, Is.EqualTo(0.6310f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_OUTHOUSE_.flLateReverbDelay, Is.EqualTo(0.0440f));
        Assert.That(
            EFX_REVERB_PRESET_PREFAB_OUTHOUSE_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_PREFAB_OUTHOUSE_.flEchoTime, Is.EqualTo(0.1210f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_OUTHOUSE_.flEchoDepth, Is.EqualTo(0.1700f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_OUTHOUSE_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_OUTHOUSE_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_OUTHOUSE_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_OUTHOUSE_.flHFReference, Is.EqualTo(2854.3999f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_OUTHOUSE_.flLFReference, Is.EqualTo(107.5000f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_OUTHOUSE_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_OUTHOUSE_.iDecayHFLimit, Is.EqualTo(0x0));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_PREFAB_CARAVAN_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_PREFAB_CARAVAN_Test()
    {
        Assert.That(EFX_REVERB_PRESET_PREFAB_CARAVAN_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_CARAVAN_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_CARAVAN_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_CARAVAN_.flGainHF, Is.EqualTo(0.0891f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_CARAVAN_.flGainLF, Is.EqualTo(0.1259f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_CARAVAN_.flDecayTime, Is.EqualTo(0.4300f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_CARAVAN_.flDecayHFRatio, Is.EqualTo(1.5000f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_CARAVAN_.flDecayLFRatio, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_CARAVAN_.flReflectionsGain, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_CARAVAN_.flReflectionsDelay, Is.EqualTo(0.0120f));
        Assert.That(
            EFX_REVERB_PRESET_PREFAB_CARAVAN_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_PREFAB_CARAVAN_.flLateReverbGain, Is.EqualTo(1.9953f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_CARAVAN_.flLateReverbDelay, Is.EqualTo(0.0120f));
        Assert.That(
            EFX_REVERB_PRESET_PREFAB_CARAVAN_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_PREFAB_CARAVAN_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_CARAVAN_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_CARAVAN_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_CARAVAN_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_CARAVAN_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_CARAVAN_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_CARAVAN_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_CARAVAN_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PREFAB_CARAVAN_.iDecayHFLimit, Is.EqualTo(0x0));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_DOME_TOMB_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_DOME_TOMB_Test()
    {
        Assert.That(EFX_REVERB_PRESET_DOME_TOMB_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_DOME_TOMB_.flDiffusion, Is.EqualTo(0.7900f));
        Assert.That(EFX_REVERB_PRESET_DOME_TOMB_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_DOME_TOMB_.flGainHF, Is.EqualTo(0.3548f));
        Assert.That(EFX_REVERB_PRESET_DOME_TOMB_.flGainLF, Is.EqualTo(0.2239f));
        Assert.That(EFX_REVERB_PRESET_DOME_TOMB_.flDecayTime, Is.EqualTo(4.1800f));
        Assert.That(EFX_REVERB_PRESET_DOME_TOMB_.flDecayHFRatio, Is.EqualTo(0.2100f));
        Assert.That(EFX_REVERB_PRESET_DOME_TOMB_.flDecayLFRatio, Is.EqualTo(0.1000f));
        Assert.That(EFX_REVERB_PRESET_DOME_TOMB_.flReflectionsGain, Is.EqualTo(0.3868f));
        Assert.That(EFX_REVERB_PRESET_DOME_TOMB_.flReflectionsDelay, Is.EqualTo(0.0300f));
        Assert.That(
            EFX_REVERB_PRESET_DOME_TOMB_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_DOME_TOMB_.flLateReverbGain, Is.EqualTo(1.6788f));
        Assert.That(EFX_REVERB_PRESET_DOME_TOMB_.flLateReverbDelay, Is.EqualTo(0.0220f));
        Assert.That(
            EFX_REVERB_PRESET_DOME_TOMB_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_DOME_TOMB_.flEchoTime, Is.EqualTo(0.1770f));
        Assert.That(EFX_REVERB_PRESET_DOME_TOMB_.flEchoDepth, Is.EqualTo(0.1900f));
        Assert.That(EFX_REVERB_PRESET_DOME_TOMB_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_DOME_TOMB_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_DOME_TOMB_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_DOME_TOMB_.flHFReference, Is.EqualTo(2854.3999f));
        Assert.That(EFX_REVERB_PRESET_DOME_TOMB_.flLFReference, Is.EqualTo(20.0000f));
        Assert.That(EFX_REVERB_PRESET_DOME_TOMB_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_DOME_TOMB_.iDecayHFLimit, Is.EqualTo(0x0));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_PIPE_SMALL_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_PIPE_SMALL_Test()
    {
        Assert.That(EFX_REVERB_PRESET_PIPE_SMALL_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_PIPE_SMALL_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_PIPE_SMALL_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_PIPE_SMALL_.flGainHF, Is.EqualTo(0.3548f));
        Assert.That(EFX_REVERB_PRESET_PIPE_SMALL_.flGainLF, Is.EqualTo(0.2239f));
        Assert.That(EFX_REVERB_PRESET_PIPE_SMALL_.flDecayTime, Is.EqualTo(5.0400f));
        Assert.That(EFX_REVERB_PRESET_PIPE_SMALL_.flDecayHFRatio, Is.EqualTo(0.1000f));
        Assert.That(EFX_REVERB_PRESET_PIPE_SMALL_.flDecayLFRatio, Is.EqualTo(0.1000f));
        Assert.That(EFX_REVERB_PRESET_PIPE_SMALL_.flReflectionsGain, Is.EqualTo(0.5012f));
        Assert.That(EFX_REVERB_PRESET_PIPE_SMALL_.flReflectionsDelay, Is.EqualTo(0.0320f));
        Assert.That(
            EFX_REVERB_PRESET_PIPE_SMALL_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_PIPE_SMALL_.flLateReverbGain, Is.EqualTo(2.5119f));
        Assert.That(EFX_REVERB_PRESET_PIPE_SMALL_.flLateReverbDelay, Is.EqualTo(0.0150f));
        Assert.That(
            EFX_REVERB_PRESET_PIPE_SMALL_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_PIPE_SMALL_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_PIPE_SMALL_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PIPE_SMALL_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_PIPE_SMALL_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PIPE_SMALL_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_PIPE_SMALL_.flHFReference, Is.EqualTo(2854.3999f));
        Assert.That(EFX_REVERB_PRESET_PIPE_SMALL_.flLFReference, Is.EqualTo(20.0000f));
        Assert.That(EFX_REVERB_PRESET_PIPE_SMALL_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PIPE_SMALL_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_DOME_SAINT_PAULS_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_DOME_SAINT_PAULS_Test()
    {
        Assert.That(EFX_REVERB_PRESET_DOME_SAINT_PAULS_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_DOME_SAINT_PAULS_.flDiffusion, Is.EqualTo(0.8700f));
        Assert.That(EFX_REVERB_PRESET_DOME_SAINT_PAULS_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_DOME_SAINT_PAULS_.flGainHF, Is.EqualTo(0.3548f));
        Assert.That(EFX_REVERB_PRESET_DOME_SAINT_PAULS_.flGainLF, Is.EqualTo(0.2239f));
        Assert.That(EFX_REVERB_PRESET_DOME_SAINT_PAULS_.flDecayTime, Is.EqualTo(10.4800f));
        Assert.That(EFX_REVERB_PRESET_DOME_SAINT_PAULS_.flDecayHFRatio, Is.EqualTo(0.1900f));
        Assert.That(EFX_REVERB_PRESET_DOME_SAINT_PAULS_.flDecayLFRatio, Is.EqualTo(0.1000f));
        Assert.That(EFX_REVERB_PRESET_DOME_SAINT_PAULS_.flReflectionsGain, Is.EqualTo(0.1778f));
        Assert.That(EFX_REVERB_PRESET_DOME_SAINT_PAULS_.flReflectionsDelay, Is.EqualTo(0.0900f));
        Assert.That(
            EFX_REVERB_PRESET_DOME_SAINT_PAULS_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_DOME_SAINT_PAULS_.flLateReverbGain, Is.EqualTo(1.2589f));
        Assert.That(EFX_REVERB_PRESET_DOME_SAINT_PAULS_.flLateReverbDelay, Is.EqualTo(0.0420f));
        Assert.That(
            EFX_REVERB_PRESET_DOME_SAINT_PAULS_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_DOME_SAINT_PAULS_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_DOME_SAINT_PAULS_.flEchoDepth, Is.EqualTo(0.1200f));
        Assert.That(EFX_REVERB_PRESET_DOME_SAINT_PAULS_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_DOME_SAINT_PAULS_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_DOME_SAINT_PAULS_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_DOME_SAINT_PAULS_.flHFReference, Is.EqualTo(2854.3999f));
        Assert.That(EFX_REVERB_PRESET_DOME_SAINT_PAULS_.flLFReference, Is.EqualTo(20.0000f));
        Assert.That(EFX_REVERB_PRESET_DOME_SAINT_PAULS_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_DOME_SAINT_PAULS_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_PIPE_LONG_THIN_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_PIPE_LONG_THIN_Test()
    {
        Assert.That(EFX_REVERB_PRESET_PIPE_LONG_THIN_.flDensity, Is.EqualTo(0.2560f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LONG_THIN_.flDiffusion, Is.EqualTo(0.9100f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LONG_THIN_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LONG_THIN_.flGainHF, Is.EqualTo(0.4467f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LONG_THIN_.flGainLF, Is.EqualTo(0.2818f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LONG_THIN_.flDecayTime, Is.EqualTo(9.2100f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LONG_THIN_.flDecayHFRatio, Is.EqualTo(0.1800f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LONG_THIN_.flDecayLFRatio, Is.EqualTo(0.1000f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LONG_THIN_.flReflectionsGain, Is.EqualTo(0.7079f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LONG_THIN_.flReflectionsDelay, Is.EqualTo(0.0100f));
        Assert.That(
            EFX_REVERB_PRESET_PIPE_LONG_THIN_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_PIPE_LONG_THIN_.flLateReverbGain, Is.EqualTo(0.7079f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LONG_THIN_.flLateReverbDelay, Is.EqualTo(0.0220f));
        Assert.That(
            EFX_REVERB_PRESET_PIPE_LONG_THIN_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_PIPE_LONG_THIN_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LONG_THIN_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LONG_THIN_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LONG_THIN_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LONG_THIN_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LONG_THIN_.flHFReference, Is.EqualTo(2854.3999f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LONG_THIN_.flLFReference, Is.EqualTo(20.0000f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LONG_THIN_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LONG_THIN_.iDecayHFLimit, Is.EqualTo(0x0));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_PIPE_LARGE_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_PIPE_LARGE_Test()
    {
        Assert.That(EFX_REVERB_PRESET_PIPE_LARGE_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LARGE_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LARGE_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LARGE_.flGainHF, Is.EqualTo(0.3548f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LARGE_.flGainLF, Is.EqualTo(0.2239f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LARGE_.flDecayTime, Is.EqualTo(8.4500f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LARGE_.flDecayHFRatio, Is.EqualTo(0.1000f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LARGE_.flDecayLFRatio, Is.EqualTo(0.1000f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LARGE_.flReflectionsGain, Is.EqualTo(0.3981f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LARGE_.flReflectionsDelay, Is.EqualTo(0.0460f));
        Assert.That(
            EFX_REVERB_PRESET_PIPE_LARGE_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_PIPE_LARGE_.flLateReverbGain, Is.EqualTo(1.5849f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LARGE_.flLateReverbDelay, Is.EqualTo(0.0320f));
        Assert.That(
            EFX_REVERB_PRESET_PIPE_LARGE_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_PIPE_LARGE_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LARGE_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LARGE_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LARGE_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LARGE_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LARGE_.flHFReference, Is.EqualTo(2854.3999f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LARGE_.flLFReference, Is.EqualTo(20.0000f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LARGE_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PIPE_LARGE_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_PIPE_RESONANT_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_PIPE_RESONANT_Test()
    {
        Assert.That(EFX_REVERB_PRESET_PIPE_RESONANT_.flDensity, Is.EqualTo(0.1373f));
        Assert.That(EFX_REVERB_PRESET_PIPE_RESONANT_.flDiffusion, Is.EqualTo(0.9100f));
        Assert.That(EFX_REVERB_PRESET_PIPE_RESONANT_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_PIPE_RESONANT_.flGainHF, Is.EqualTo(0.4467f));
        Assert.That(EFX_REVERB_PRESET_PIPE_RESONANT_.flGainLF, Is.EqualTo(0.2818f));
        Assert.That(EFX_REVERB_PRESET_PIPE_RESONANT_.flDecayTime, Is.EqualTo(6.8100f));
        Assert.That(EFX_REVERB_PRESET_PIPE_RESONANT_.flDecayHFRatio, Is.EqualTo(0.1800f));
        Assert.That(EFX_REVERB_PRESET_PIPE_RESONANT_.flDecayLFRatio, Is.EqualTo(0.1000f));
        Assert.That(EFX_REVERB_PRESET_PIPE_RESONANT_.flReflectionsGain, Is.EqualTo(0.7079f));
        Assert.That(EFX_REVERB_PRESET_PIPE_RESONANT_.flReflectionsDelay, Is.EqualTo(0.0100f));
        Assert.That(
            EFX_REVERB_PRESET_PIPE_RESONANT_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_PIPE_RESONANT_.flLateReverbGain, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_PIPE_RESONANT_.flLateReverbDelay, Is.EqualTo(0.0220f));
        Assert.That(
            EFX_REVERB_PRESET_PIPE_RESONANT_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_PIPE_RESONANT_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_PIPE_RESONANT_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PIPE_RESONANT_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_PIPE_RESONANT_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PIPE_RESONANT_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_PIPE_RESONANT_.flHFReference, Is.EqualTo(2854.3999f));
        Assert.That(EFX_REVERB_PRESET_PIPE_RESONANT_.flLFReference, Is.EqualTo(20.0000f));
        Assert.That(EFX_REVERB_PRESET_PIPE_RESONANT_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_PIPE_RESONANT_.iDecayHFLimit, Is.EqualTo(0x0));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_OUTDOORS_BACKYARD_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_OUTDOORS_BACKYARD_Test()
    {
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_BACKYARD_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_BACKYARD_.flDiffusion, Is.EqualTo(0.4500f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_BACKYARD_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_BACKYARD_.flGainHF, Is.EqualTo(0.2512f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_BACKYARD_.flGainLF, Is.EqualTo(0.5012f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_BACKYARD_.flDecayTime, Is.EqualTo(1.1200f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_BACKYARD_.flDecayHFRatio, Is.EqualTo(0.3400f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_BACKYARD_.flDecayLFRatio, Is.EqualTo(0.4600f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_BACKYARD_.flReflectionsGain, Is.EqualTo(0.4467f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_BACKYARD_.flReflectionsDelay, Is.EqualTo(0.0690f));
        Assert.That(
            EFX_REVERB_PRESET_OUTDOORS_BACKYARD_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, -0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_BACKYARD_.flLateReverbGain, Is.EqualTo(0.7079f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_BACKYARD_.flLateReverbDelay, Is.EqualTo(0.0230f));
        Assert.That(
            EFX_REVERB_PRESET_OUTDOORS_BACKYARD_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_BACKYARD_.flEchoTime, Is.EqualTo(0.2180f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_BACKYARD_.flEchoDepth, Is.EqualTo(0.3400f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_BACKYARD_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_BACKYARD_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_OUTDOORS_BACKYARD_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_BACKYARD_.flHFReference, Is.EqualTo(4399.1001f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_BACKYARD_.flLFReference, Is.EqualTo(242.9000f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_BACKYARD_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_BACKYARD_.iDecayHFLimit, Is.EqualTo(0x0));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_OUTDOORS_ROLLING_PLAINS_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_OUTDOORS_ROLLING_PLAINS_Test()
    {
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_ROLLING_PLAINS_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_ROLLING_PLAINS_.flDiffusion, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_ROLLING_PLAINS_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_ROLLING_PLAINS_.flGainHF, Is.EqualTo(0.0112f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_ROLLING_PLAINS_.flGainLF, Is.EqualTo(0.6310f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_ROLLING_PLAINS_.flDecayTime, Is.EqualTo(2.1300f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_ROLLING_PLAINS_.flDecayHFRatio, Is.EqualTo(0.2100f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_ROLLING_PLAINS_.flDecayLFRatio, Is.EqualTo(0.4600f));
        Assert.That(
            EFX_REVERB_PRESET_OUTDOORS_ROLLING_PLAINS_.flReflectionsGain,
            Is.EqualTo(0.1778f)
        );
        Assert.That(
            EFX_REVERB_PRESET_OUTDOORS_ROLLING_PLAINS_.flReflectionsDelay,
            Is.EqualTo(0.3000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_OUTDOORS_ROLLING_PLAINS_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, -0.0000f })
        );
        Assert.That(
            EFX_REVERB_PRESET_OUTDOORS_ROLLING_PLAINS_.flLateReverbGain,
            Is.EqualTo(0.4467f)
        );
        Assert.That(
            EFX_REVERB_PRESET_OUTDOORS_ROLLING_PLAINS_.flLateReverbDelay,
            Is.EqualTo(0.0190f)
        );
        Assert.That(
            EFX_REVERB_PRESET_OUTDOORS_ROLLING_PLAINS_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_ROLLING_PLAINS_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_ROLLING_PLAINS_.flEchoDepth, Is.EqualTo(1.0000f));
        Assert.That(
            EFX_REVERB_PRESET_OUTDOORS_ROLLING_PLAINS_.flModulationTime,
            Is.EqualTo(0.2500f)
        );
        Assert.That(
            EFX_REVERB_PRESET_OUTDOORS_ROLLING_PLAINS_.flModulationDepth,
            Is.EqualTo(0.0000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_OUTDOORS_ROLLING_PLAINS_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(
            EFX_REVERB_PRESET_OUTDOORS_ROLLING_PLAINS_.flHFReference,
            Is.EqualTo(4399.1001f)
        );
        Assert.That(
            EFX_REVERB_PRESET_OUTDOORS_ROLLING_PLAINS_.flLFReference,
            Is.EqualTo(242.9000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_OUTDOORS_ROLLING_PLAINS_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_ROLLING_PLAINS_.iDecayHFLimit, Is.EqualTo(0x0));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_OUTDOORS_DEEP_CANYON_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_OUTDOORS_DEEP_CANYON_Test()
    {
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_DEEP_CANYON_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_DEEP_CANYON_.flDiffusion, Is.EqualTo(0.7400f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_DEEP_CANYON_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_DEEP_CANYON_.flGainHF, Is.EqualTo(0.1778f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_DEEP_CANYON_.flGainLF, Is.EqualTo(0.6310f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_DEEP_CANYON_.flDecayTime, Is.EqualTo(3.8900f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_DEEP_CANYON_.flDecayHFRatio, Is.EqualTo(0.2100f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_DEEP_CANYON_.flDecayLFRatio, Is.EqualTo(0.4600f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_DEEP_CANYON_.flReflectionsGain, Is.EqualTo(0.3162f));
        Assert.That(
            EFX_REVERB_PRESET_OUTDOORS_DEEP_CANYON_.flReflectionsDelay,
            Is.EqualTo(0.2230f)
        );
        Assert.That(
            EFX_REVERB_PRESET_OUTDOORS_DEEP_CANYON_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, -0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_DEEP_CANYON_.flLateReverbGain, Is.EqualTo(0.3548f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_DEEP_CANYON_.flLateReverbDelay, Is.EqualTo(0.0190f));
        Assert.That(
            EFX_REVERB_PRESET_OUTDOORS_DEEP_CANYON_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_DEEP_CANYON_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_DEEP_CANYON_.flEchoDepth, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_DEEP_CANYON_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_DEEP_CANYON_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_OUTDOORS_DEEP_CANYON_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_DEEP_CANYON_.flHFReference, Is.EqualTo(4399.1001f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_DEEP_CANYON_.flLFReference, Is.EqualTo(242.9000f));
        Assert.That(
            EFX_REVERB_PRESET_OUTDOORS_DEEP_CANYON_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_DEEP_CANYON_.iDecayHFLimit, Is.EqualTo(0x0));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_OUTDOORS_CREEK_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_OUTDOORS_CREEK_Test()
    {
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_CREEK_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_CREEK_.flDiffusion, Is.EqualTo(0.3500f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_CREEK_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_CREEK_.flGainHF, Is.EqualTo(0.1778f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_CREEK_.flGainLF, Is.EqualTo(0.5012f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_CREEK_.flDecayTime, Is.EqualTo(2.1300f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_CREEK_.flDecayHFRatio, Is.EqualTo(0.2100f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_CREEK_.flDecayLFRatio, Is.EqualTo(0.4600f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_CREEK_.flReflectionsGain, Is.EqualTo(0.3981f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_CREEK_.flReflectionsDelay, Is.EqualTo(0.1150f));
        Assert.That(
            EFX_REVERB_PRESET_OUTDOORS_CREEK_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, -0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_CREEK_.flLateReverbGain, Is.EqualTo(0.1995f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_CREEK_.flLateReverbDelay, Is.EqualTo(0.0310f));
        Assert.That(
            EFX_REVERB_PRESET_OUTDOORS_CREEK_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_CREEK_.flEchoTime, Is.EqualTo(0.2180f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_CREEK_.flEchoDepth, Is.EqualTo(0.3400f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_CREEK_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_CREEK_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_CREEK_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_CREEK_.flHFReference, Is.EqualTo(4399.1001f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_CREEK_.flLFReference, Is.EqualTo(242.9000f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_CREEK_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_CREEK_.iDecayHFLimit, Is.EqualTo(0x0));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_OUTDOORS_VALLEY_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_OUTDOORS_VALLEY_Test()
    {
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_VALLEY_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_VALLEY_.flDiffusion, Is.EqualTo(0.2800f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_VALLEY_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_VALLEY_.flGainHF, Is.EqualTo(0.0282f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_VALLEY_.flGainLF, Is.EqualTo(0.1585f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_VALLEY_.flDecayTime, Is.EqualTo(2.8800f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_VALLEY_.flDecayHFRatio, Is.EqualTo(0.2600f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_VALLEY_.flDecayLFRatio, Is.EqualTo(0.3500f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_VALLEY_.flReflectionsGain, Is.EqualTo(0.1413f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_VALLEY_.flReflectionsDelay, Is.EqualTo(0.2630f));
        Assert.That(
            EFX_REVERB_PRESET_OUTDOORS_VALLEY_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, -0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_VALLEY_.flLateReverbGain, Is.EqualTo(0.3981f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_VALLEY_.flLateReverbDelay, Is.EqualTo(0.1000f));
        Assert.That(
            EFX_REVERB_PRESET_OUTDOORS_VALLEY_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_VALLEY_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_VALLEY_.flEchoDepth, Is.EqualTo(0.3400f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_VALLEY_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_VALLEY_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_VALLEY_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_VALLEY_.flHFReference, Is.EqualTo(2854.3999f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_VALLEY_.flLFReference, Is.EqualTo(107.5000f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_VALLEY_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_OUTDOORS_VALLEY_.iDecayHFLimit, Is.EqualTo(0x0));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_MOOD_HEAVEN_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_MOOD_HEAVEN_Test()
    {
        Assert.That(EFX_REVERB_PRESET_MOOD_HEAVEN_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HEAVEN_.flDiffusion, Is.EqualTo(0.9400f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HEAVEN_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HEAVEN_.flGainHF, Is.EqualTo(0.7943f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HEAVEN_.flGainLF, Is.EqualTo(0.4467f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HEAVEN_.flDecayTime, Is.EqualTo(5.0400f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HEAVEN_.flDecayHFRatio, Is.EqualTo(1.1200f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HEAVEN_.flDecayLFRatio, Is.EqualTo(0.5600f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HEAVEN_.flReflectionsGain, Is.EqualTo(0.2427f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HEAVEN_.flReflectionsDelay, Is.EqualTo(0.0200f));
        Assert.That(
            EFX_REVERB_PRESET_MOOD_HEAVEN_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_MOOD_HEAVEN_.flLateReverbGain, Is.EqualTo(1.2589f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HEAVEN_.flLateReverbDelay, Is.EqualTo(0.0290f));
        Assert.That(
            EFX_REVERB_PRESET_MOOD_HEAVEN_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_MOOD_HEAVEN_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HEAVEN_.flEchoDepth, Is.EqualTo(0.0800f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HEAVEN_.flModulationTime, Is.EqualTo(2.7420f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HEAVEN_.flModulationDepth, Is.EqualTo(0.0500f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HEAVEN_.flAirAbsorptionGainHF, Is.EqualTo(0.9977f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HEAVEN_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HEAVEN_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HEAVEN_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HEAVEN_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_MOOD_HELL_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_MOOD_HELL_Test()
    {
        Assert.That(EFX_REVERB_PRESET_MOOD_HELL_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HELL_.flDiffusion, Is.EqualTo(0.5700f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HELL_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HELL_.flGainHF, Is.EqualTo(0.3548f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HELL_.flGainLF, Is.EqualTo(0.4467f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HELL_.flDecayTime, Is.EqualTo(3.5700f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HELL_.flDecayHFRatio, Is.EqualTo(0.4900f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HELL_.flDecayLFRatio, Is.EqualTo(2.0000f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HELL_.flReflectionsGain, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HELL_.flReflectionsDelay, Is.EqualTo(0.0200f));
        Assert.That(
            EFX_REVERB_PRESET_MOOD_HELL_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_MOOD_HELL_.flLateReverbGain, Is.EqualTo(1.4125f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HELL_.flLateReverbDelay, Is.EqualTo(0.0300f));
        Assert.That(
            EFX_REVERB_PRESET_MOOD_HELL_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_MOOD_HELL_.flEchoTime, Is.EqualTo(0.1100f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HELL_.flEchoDepth, Is.EqualTo(0.0400f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HELL_.flModulationTime, Is.EqualTo(2.1090f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HELL_.flModulationDepth, Is.EqualTo(0.5200f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HELL_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HELL_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HELL_.flLFReference, Is.EqualTo(139.5000f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HELL_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_MOOD_HELL_.iDecayHFLimit, Is.EqualTo(0x0));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_MOOD_MEMORY_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_MOOD_MEMORY_Test()
    {
        Assert.That(EFX_REVERB_PRESET_MOOD_MEMORY_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_MOOD_MEMORY_.flDiffusion, Is.EqualTo(0.8500f));
        Assert.That(EFX_REVERB_PRESET_MOOD_MEMORY_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_MOOD_MEMORY_.flGainHF, Is.EqualTo(0.6310f));
        Assert.That(EFX_REVERB_PRESET_MOOD_MEMORY_.flGainLF, Is.EqualTo(0.3548f));
        Assert.That(EFX_REVERB_PRESET_MOOD_MEMORY_.flDecayTime, Is.EqualTo(4.0600f));
        Assert.That(EFX_REVERB_PRESET_MOOD_MEMORY_.flDecayHFRatio, Is.EqualTo(0.8200f));
        Assert.That(EFX_REVERB_PRESET_MOOD_MEMORY_.flDecayLFRatio, Is.EqualTo(0.5600f));
        Assert.That(EFX_REVERB_PRESET_MOOD_MEMORY_.flReflectionsGain, Is.EqualTo(0.0398f));
        Assert.That(EFX_REVERB_PRESET_MOOD_MEMORY_.flReflectionsDelay, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_MOOD_MEMORY_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_MOOD_MEMORY_.flLateReverbGain, Is.EqualTo(1.1220f));
        Assert.That(EFX_REVERB_PRESET_MOOD_MEMORY_.flLateReverbDelay, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_MOOD_MEMORY_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_MOOD_MEMORY_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_MOOD_MEMORY_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_MOOD_MEMORY_.flModulationTime, Is.EqualTo(0.4740f));
        Assert.That(EFX_REVERB_PRESET_MOOD_MEMORY_.flModulationDepth, Is.EqualTo(0.4500f));
        Assert.That(EFX_REVERB_PRESET_MOOD_MEMORY_.flAirAbsorptionGainHF, Is.EqualTo(0.9886f));
        Assert.That(EFX_REVERB_PRESET_MOOD_MEMORY_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_MOOD_MEMORY_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_MOOD_MEMORY_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_MOOD_MEMORY_.iDecayHFLimit, Is.EqualTo(0x0));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_DRIVING_COMMENTATOR_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_DRIVING_COMMENTATOR_Test()
    {
        Assert.That(EFX_REVERB_PRESET_DRIVING_COMMENTATOR_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_COMMENTATOR_.flDiffusion, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_COMMENTATOR_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_COMMENTATOR_.flGainHF, Is.EqualTo(0.5623f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_COMMENTATOR_.flGainLF, Is.EqualTo(0.5012f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_COMMENTATOR_.flDecayTime, Is.EqualTo(2.4200f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_COMMENTATOR_.flDecayHFRatio, Is.EqualTo(0.8800f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_COMMENTATOR_.flDecayLFRatio, Is.EqualTo(0.6800f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_COMMENTATOR_.flReflectionsGain, Is.EqualTo(0.1995f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_COMMENTATOR_.flReflectionsDelay, Is.EqualTo(0.0930f));
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_COMMENTATOR_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_DRIVING_COMMENTATOR_.flLateReverbGain, Is.EqualTo(0.2512f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_COMMENTATOR_.flLateReverbDelay, Is.EqualTo(0.0170f));
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_COMMENTATOR_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_DRIVING_COMMENTATOR_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_COMMENTATOR_.flEchoDepth, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_COMMENTATOR_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_COMMENTATOR_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_COMMENTATOR_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9886f)
        );
        Assert.That(EFX_REVERB_PRESET_DRIVING_COMMENTATOR_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_COMMENTATOR_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_COMMENTATOR_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_DRIVING_COMMENTATOR_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_DRIVING_PIT_GARAGE_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_DRIVING_PIT_GARAGE_Test()
    {
        Assert.That(EFX_REVERB_PRESET_DRIVING_PIT_GARAGE_.flDensity, Is.EqualTo(0.4287f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_PIT_GARAGE_.flDiffusion, Is.EqualTo(0.5900f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_PIT_GARAGE_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_PIT_GARAGE_.flGainHF, Is.EqualTo(0.7079f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_PIT_GARAGE_.flGainLF, Is.EqualTo(0.5623f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_PIT_GARAGE_.flDecayTime, Is.EqualTo(1.7200f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_PIT_GARAGE_.flDecayHFRatio, Is.EqualTo(0.9300f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_PIT_GARAGE_.flDecayLFRatio, Is.EqualTo(0.8700f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_PIT_GARAGE_.flReflectionsGain, Is.EqualTo(0.5623f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_PIT_GARAGE_.flReflectionsDelay, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_PIT_GARAGE_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_DRIVING_PIT_GARAGE_.flLateReverbGain, Is.EqualTo(1.2589f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_PIT_GARAGE_.flLateReverbDelay, Is.EqualTo(0.0160f));
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_PIT_GARAGE_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_DRIVING_PIT_GARAGE_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_PIT_GARAGE_.flEchoDepth, Is.EqualTo(0.1100f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_PIT_GARAGE_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_PIT_GARAGE_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_PIT_GARAGE_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(EFX_REVERB_PRESET_DRIVING_PIT_GARAGE_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_PIT_GARAGE_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_PIT_GARAGE_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_PIT_GARAGE_.iDecayHFLimit, Is.EqualTo(0x0));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_DRIVING_IN_CAR_RACER_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_DRIVING_IN_CAR_RACER_Test()
    {
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_RACER_.flDensity, Is.EqualTo(0.0832f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_RACER_.flDiffusion, Is.EqualTo(0.8000f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_RACER_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_RACER_.flGainHF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_RACER_.flGainLF, Is.EqualTo(0.7943f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_RACER_.flDecayTime, Is.EqualTo(0.1700f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_RACER_.flDecayHFRatio, Is.EqualTo(2.0000f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_RACER_.flDecayLFRatio, Is.EqualTo(0.4100f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_RACER_.flReflectionsGain, Is.EqualTo(1.7783f));
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_IN_CAR_RACER_.flReflectionsDelay,
            Is.EqualTo(0.0070f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_IN_CAR_RACER_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_RACER_.flLateReverbGain, Is.EqualTo(0.7079f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_RACER_.flLateReverbDelay, Is.EqualTo(0.0150f));
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_IN_CAR_RACER_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_RACER_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_RACER_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_RACER_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_RACER_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_IN_CAR_RACER_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_RACER_.flHFReference, Is.EqualTo(10268.2002f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_RACER_.flLFReference, Is.EqualTo(251.0000f));
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_IN_CAR_RACER_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_RACER_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_DRIVING_IN_CAR_SPORTS_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_DRIVING_IN_CAR_SPORTS_Test()
    {
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_SPORTS_.flDensity, Is.EqualTo(0.0832f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_SPORTS_.flDiffusion, Is.EqualTo(0.8000f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_SPORTS_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_SPORTS_.flGainHF, Is.EqualTo(0.6310f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_SPORTS_.flGainLF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_SPORTS_.flDecayTime, Is.EqualTo(0.1700f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_SPORTS_.flDecayHFRatio, Is.EqualTo(0.7500f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_SPORTS_.flDecayLFRatio, Is.EqualTo(0.4100f));
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_IN_CAR_SPORTS_.flReflectionsGain,
            Is.EqualTo(1.0000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_IN_CAR_SPORTS_.flReflectionsDelay,
            Is.EqualTo(0.0100f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_IN_CAR_SPORTS_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_SPORTS_.flLateReverbGain, Is.EqualTo(0.5623f));
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_IN_CAR_SPORTS_.flLateReverbDelay,
            Is.EqualTo(0.0000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_IN_CAR_SPORTS_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_SPORTS_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_SPORTS_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_SPORTS_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_IN_CAR_SPORTS_.flModulationDepth,
            Is.EqualTo(0.0000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_IN_CAR_SPORTS_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_IN_CAR_SPORTS_.flHFReference,
            Is.EqualTo(10268.2002f)
        );
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_SPORTS_.flLFReference, Is.EqualTo(251.0000f));
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_IN_CAR_SPORTS_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_SPORTS_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_DRIVING_IN_CAR_LUXURY_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_DRIVING_IN_CAR_LUXURY_Test()
    {
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_LUXURY_.flDensity, Is.EqualTo(0.2560f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_LUXURY_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_LUXURY_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_LUXURY_.flGainHF, Is.EqualTo(0.1000f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_LUXURY_.flGainLF, Is.EqualTo(0.5012f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_LUXURY_.flDecayTime, Is.EqualTo(0.1300f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_LUXURY_.flDecayHFRatio, Is.EqualTo(0.4100f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_LUXURY_.flDecayLFRatio, Is.EqualTo(0.4600f));
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_IN_CAR_LUXURY_.flReflectionsGain,
            Is.EqualTo(0.7943f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_IN_CAR_LUXURY_.flReflectionsDelay,
            Is.EqualTo(0.0100f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_IN_CAR_LUXURY_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_LUXURY_.flLateReverbGain, Is.EqualTo(1.5849f));
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_IN_CAR_LUXURY_.flLateReverbDelay,
            Is.EqualTo(0.0100f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_IN_CAR_LUXURY_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_LUXURY_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_LUXURY_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_LUXURY_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_IN_CAR_LUXURY_.flModulationDepth,
            Is.EqualTo(0.0000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_IN_CAR_LUXURY_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_IN_CAR_LUXURY_.flHFReference,
            Is.EqualTo(10268.2002f)
        );
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_LUXURY_.flLFReference, Is.EqualTo(251.0000f));
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_IN_CAR_LUXURY_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_DRIVING_IN_CAR_LUXURY_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_DRIVING_FULL_GRAND_STAND_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_DRIVING_FULL_GRAND_STAND_Test()
    {
        Assert.That(EFX_REVERB_PRESET_DRIVING_FULL_GRAND_STAND_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_FULL_GRAND_STAND_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_FULL_GRAND_STAND_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_FULL_GRAND_STAND_.flGainHF, Is.EqualTo(0.2818f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_FULL_GRAND_STAND_.flGainLF, Is.EqualTo(0.6310f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_FULL_GRAND_STAND_.flDecayTime, Is.EqualTo(3.0100f));
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_FULL_GRAND_STAND_.flDecayHFRatio,
            Is.EqualTo(1.3700f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_FULL_GRAND_STAND_.flDecayLFRatio,
            Is.EqualTo(1.2800f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_FULL_GRAND_STAND_.flReflectionsGain,
            Is.EqualTo(0.3548f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_FULL_GRAND_STAND_.flReflectionsDelay,
            Is.EqualTo(0.0900f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_FULL_GRAND_STAND_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_FULL_GRAND_STAND_.flLateReverbGain,
            Is.EqualTo(0.1778f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_FULL_GRAND_STAND_.flLateReverbDelay,
            Is.EqualTo(0.0490f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_FULL_GRAND_STAND_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_DRIVING_FULL_GRAND_STAND_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_FULL_GRAND_STAND_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_FULL_GRAND_STAND_.flModulationTime,
            Is.EqualTo(0.2500f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_FULL_GRAND_STAND_.flModulationDepth,
            Is.EqualTo(0.0000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_FULL_GRAND_STAND_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_FULL_GRAND_STAND_.flHFReference,
            Is.EqualTo(10420.2002f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_FULL_GRAND_STAND_.flLFReference,
            Is.EqualTo(250.0000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_FULL_GRAND_STAND_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_DRIVING_FULL_GRAND_STAND_.iDecayHFLimit, Is.EqualTo(0x0));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_DRIVING_EMPTY_GRAND_STAND_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_DRIVING_EMPTY_GRAND_STAND_Test()
    {
        Assert.That(EFX_REVERB_PRESET_DRIVING_EMPTY_GRAND_STAND_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_EMPTY_GRAND_STAND_.flDiffusion, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_EMPTY_GRAND_STAND_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_EMPTY_GRAND_STAND_.flGainHF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_EMPTY_GRAND_STAND_.flGainLF, Is.EqualTo(0.7943f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_EMPTY_GRAND_STAND_.flDecayTime, Is.EqualTo(4.6200f));
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_EMPTY_GRAND_STAND_.flDecayHFRatio,
            Is.EqualTo(1.7500f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_EMPTY_GRAND_STAND_.flDecayLFRatio,
            Is.EqualTo(1.4000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_EMPTY_GRAND_STAND_.flReflectionsGain,
            Is.EqualTo(0.2082f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_EMPTY_GRAND_STAND_.flReflectionsDelay,
            Is.EqualTo(0.0900f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_EMPTY_GRAND_STAND_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_EMPTY_GRAND_STAND_.flLateReverbGain,
            Is.EqualTo(0.2512f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_EMPTY_GRAND_STAND_.flLateReverbDelay,
            Is.EqualTo(0.0490f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_EMPTY_GRAND_STAND_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_DRIVING_EMPTY_GRAND_STAND_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_EMPTY_GRAND_STAND_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_EMPTY_GRAND_STAND_.flModulationTime,
            Is.EqualTo(0.2500f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_EMPTY_GRAND_STAND_.flModulationDepth,
            Is.EqualTo(0.0000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_EMPTY_GRAND_STAND_.flAirAbsorptionGainHF,
            Is.EqualTo(0.9943f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_EMPTY_GRAND_STAND_.flHFReference,
            Is.EqualTo(10420.2002f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_EMPTY_GRAND_STAND_.flLFReference,
            Is.EqualTo(250.0000f)
        );
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_EMPTY_GRAND_STAND_.flRoomRolloffFactor,
            Is.EqualTo(0.0000f)
        );
        Assert.That(EFX_REVERB_PRESET_DRIVING_EMPTY_GRAND_STAND_.iDecayHFLimit, Is.EqualTo(0x0));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_DRIVING_TUNNEL_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_DRIVING_TUNNEL_Test()
    {
        Assert.That(EFX_REVERB_PRESET_DRIVING_TUNNEL_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_TUNNEL_.flDiffusion, Is.EqualTo(0.8100f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_TUNNEL_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_TUNNEL_.flGainHF, Is.EqualTo(0.3981f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_TUNNEL_.flGainLF, Is.EqualTo(0.8913f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_TUNNEL_.flDecayTime, Is.EqualTo(3.4200f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_TUNNEL_.flDecayHFRatio, Is.EqualTo(0.9400f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_TUNNEL_.flDecayLFRatio, Is.EqualTo(1.3100f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_TUNNEL_.flReflectionsGain, Is.EqualTo(0.7079f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_TUNNEL_.flReflectionsDelay, Is.EqualTo(0.0510f));
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_TUNNEL_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_DRIVING_TUNNEL_.flLateReverbGain, Is.EqualTo(0.7079f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_TUNNEL_.flLateReverbDelay, Is.EqualTo(0.0470f));
        Assert.That(
            EFX_REVERB_PRESET_DRIVING_TUNNEL_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_DRIVING_TUNNEL_.flEchoTime, Is.EqualTo(0.2140f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_TUNNEL_.flEchoDepth, Is.EqualTo(0.0500f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_TUNNEL_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_TUNNEL_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_TUNNEL_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_TUNNEL_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_TUNNEL_.flLFReference, Is.EqualTo(155.3000f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_TUNNEL_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_DRIVING_TUNNEL_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_CITY_STREETS_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_CITY_STREETS_Test()
    {
        Assert.That(EFX_REVERB_PRESET_CITY_STREETS_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_STREETS_.flDiffusion, Is.EqualTo(0.7800f));
        Assert.That(EFX_REVERB_PRESET_CITY_STREETS_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_CITY_STREETS_.flGainHF, Is.EqualTo(0.7079f));
        Assert.That(EFX_REVERB_PRESET_CITY_STREETS_.flGainLF, Is.EqualTo(0.8913f));
        Assert.That(EFX_REVERB_PRESET_CITY_STREETS_.flDecayTime, Is.EqualTo(1.7900f));
        Assert.That(EFX_REVERB_PRESET_CITY_STREETS_.flDecayHFRatio, Is.EqualTo(1.1200f));
        Assert.That(EFX_REVERB_PRESET_CITY_STREETS_.flDecayLFRatio, Is.EqualTo(0.9100f));
        Assert.That(EFX_REVERB_PRESET_CITY_STREETS_.flReflectionsGain, Is.EqualTo(0.2818f));
        Assert.That(EFX_REVERB_PRESET_CITY_STREETS_.flReflectionsDelay, Is.EqualTo(0.0460f));
        Assert.That(
            EFX_REVERB_PRESET_CITY_STREETS_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CITY_STREETS_.flLateReverbGain, Is.EqualTo(0.1995f));
        Assert.That(EFX_REVERB_PRESET_CITY_STREETS_.flLateReverbDelay, Is.EqualTo(0.0280f));
        Assert.That(
            EFX_REVERB_PRESET_CITY_STREETS_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CITY_STREETS_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_CITY_STREETS_.flEchoDepth, Is.EqualTo(0.2000f));
        Assert.That(EFX_REVERB_PRESET_CITY_STREETS_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_CITY_STREETS_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_STREETS_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_CITY_STREETS_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_STREETS_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_STREETS_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_STREETS_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_CITY_SUBWAY_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_CITY_SUBWAY_Test()
    {
        Assert.That(EFX_REVERB_PRESET_CITY_SUBWAY_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_SUBWAY_.flDiffusion, Is.EqualTo(0.7400f));
        Assert.That(EFX_REVERB_PRESET_CITY_SUBWAY_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_CITY_SUBWAY_.flGainHF, Is.EqualTo(0.7079f));
        Assert.That(EFX_REVERB_PRESET_CITY_SUBWAY_.flGainLF, Is.EqualTo(0.8913f));
        Assert.That(EFX_REVERB_PRESET_CITY_SUBWAY_.flDecayTime, Is.EqualTo(3.0100f));
        Assert.That(EFX_REVERB_PRESET_CITY_SUBWAY_.flDecayHFRatio, Is.EqualTo(1.2300f));
        Assert.That(EFX_REVERB_PRESET_CITY_SUBWAY_.flDecayLFRatio, Is.EqualTo(0.9100f));
        Assert.That(EFX_REVERB_PRESET_CITY_SUBWAY_.flReflectionsGain, Is.EqualTo(0.7079f));
        Assert.That(EFX_REVERB_PRESET_CITY_SUBWAY_.flReflectionsDelay, Is.EqualTo(0.0460f));
        Assert.That(
            EFX_REVERB_PRESET_CITY_SUBWAY_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CITY_SUBWAY_.flLateReverbGain, Is.EqualTo(1.2589f));
        Assert.That(EFX_REVERB_PRESET_CITY_SUBWAY_.flLateReverbDelay, Is.EqualTo(0.0280f));
        Assert.That(
            EFX_REVERB_PRESET_CITY_SUBWAY_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CITY_SUBWAY_.flEchoTime, Is.EqualTo(0.1250f));
        Assert.That(EFX_REVERB_PRESET_CITY_SUBWAY_.flEchoDepth, Is.EqualTo(0.2100f));
        Assert.That(EFX_REVERB_PRESET_CITY_SUBWAY_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_CITY_SUBWAY_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_SUBWAY_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_CITY_SUBWAY_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_SUBWAY_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_SUBWAY_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_SUBWAY_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_CITY_MUSEUM_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_CITY_MUSEUM_Test()
    {
        Assert.That(EFX_REVERB_PRESET_CITY_MUSEUM_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_MUSEUM_.flDiffusion, Is.EqualTo(0.8200f));
        Assert.That(EFX_REVERB_PRESET_CITY_MUSEUM_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_CITY_MUSEUM_.flGainHF, Is.EqualTo(0.1778f));
        Assert.That(EFX_REVERB_PRESET_CITY_MUSEUM_.flGainLF, Is.EqualTo(0.1778f));
        Assert.That(EFX_REVERB_PRESET_CITY_MUSEUM_.flDecayTime, Is.EqualTo(3.2800f));
        Assert.That(EFX_REVERB_PRESET_CITY_MUSEUM_.flDecayHFRatio, Is.EqualTo(1.4000f));
        Assert.That(EFX_REVERB_PRESET_CITY_MUSEUM_.flDecayLFRatio, Is.EqualTo(0.5700f));
        Assert.That(EFX_REVERB_PRESET_CITY_MUSEUM_.flReflectionsGain, Is.EqualTo(0.2512f));
        Assert.That(EFX_REVERB_PRESET_CITY_MUSEUM_.flReflectionsDelay, Is.EqualTo(0.0390f));
        Assert.That(
            EFX_REVERB_PRESET_CITY_MUSEUM_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, -0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CITY_MUSEUM_.flLateReverbGain, Is.EqualTo(0.8913f));
        Assert.That(EFX_REVERB_PRESET_CITY_MUSEUM_.flLateReverbDelay, Is.EqualTo(0.0340f));
        Assert.That(
            EFX_REVERB_PRESET_CITY_MUSEUM_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CITY_MUSEUM_.flEchoTime, Is.EqualTo(0.1300f));
        Assert.That(EFX_REVERB_PRESET_CITY_MUSEUM_.flEchoDepth, Is.EqualTo(0.1700f));
        Assert.That(EFX_REVERB_PRESET_CITY_MUSEUM_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_CITY_MUSEUM_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_MUSEUM_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_CITY_MUSEUM_.flHFReference, Is.EqualTo(2854.3999f));
        Assert.That(EFX_REVERB_PRESET_CITY_MUSEUM_.flLFReference, Is.EqualTo(107.5000f));
        Assert.That(EFX_REVERB_PRESET_CITY_MUSEUM_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_MUSEUM_.iDecayHFLimit, Is.EqualTo(0x0));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_CITY_LIBRARY_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_CITY_LIBRARY_Test()
    {
        Assert.That(EFX_REVERB_PRESET_CITY_LIBRARY_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_LIBRARY_.flDiffusion, Is.EqualTo(0.8200f));
        Assert.That(EFX_REVERB_PRESET_CITY_LIBRARY_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_CITY_LIBRARY_.flGainHF, Is.EqualTo(0.2818f));
        Assert.That(EFX_REVERB_PRESET_CITY_LIBRARY_.flGainLF, Is.EqualTo(0.0891f));
        Assert.That(EFX_REVERB_PRESET_CITY_LIBRARY_.flDecayTime, Is.EqualTo(2.7600f));
        Assert.That(EFX_REVERB_PRESET_CITY_LIBRARY_.flDecayHFRatio, Is.EqualTo(0.8900f));
        Assert.That(EFX_REVERB_PRESET_CITY_LIBRARY_.flDecayLFRatio, Is.EqualTo(0.4100f));
        Assert.That(EFX_REVERB_PRESET_CITY_LIBRARY_.flReflectionsGain, Is.EqualTo(0.3548f));
        Assert.That(EFX_REVERB_PRESET_CITY_LIBRARY_.flReflectionsDelay, Is.EqualTo(0.0290f));
        Assert.That(
            EFX_REVERB_PRESET_CITY_LIBRARY_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, -0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CITY_LIBRARY_.flLateReverbGain, Is.EqualTo(0.8913f));
        Assert.That(EFX_REVERB_PRESET_CITY_LIBRARY_.flLateReverbDelay, Is.EqualTo(0.0200f));
        Assert.That(
            EFX_REVERB_PRESET_CITY_LIBRARY_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CITY_LIBRARY_.flEchoTime, Is.EqualTo(0.1300f));
        Assert.That(EFX_REVERB_PRESET_CITY_LIBRARY_.flEchoDepth, Is.EqualTo(0.1700f));
        Assert.That(EFX_REVERB_PRESET_CITY_LIBRARY_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_CITY_LIBRARY_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_LIBRARY_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_CITY_LIBRARY_.flHFReference, Is.EqualTo(2854.3999f));
        Assert.That(EFX_REVERB_PRESET_CITY_LIBRARY_.flLFReference, Is.EqualTo(107.5000f));
        Assert.That(EFX_REVERB_PRESET_CITY_LIBRARY_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_LIBRARY_.iDecayHFLimit, Is.EqualTo(0x0));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_CITY_UNDERPASS_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_CITY_UNDERPASS_Test()
    {
        Assert.That(EFX_REVERB_PRESET_CITY_UNDERPASS_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_UNDERPASS_.flDiffusion, Is.EqualTo(0.8200f));
        Assert.That(EFX_REVERB_PRESET_CITY_UNDERPASS_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_CITY_UNDERPASS_.flGainHF, Is.EqualTo(0.4467f));
        Assert.That(EFX_REVERB_PRESET_CITY_UNDERPASS_.flGainLF, Is.EqualTo(0.8913f));
        Assert.That(EFX_REVERB_PRESET_CITY_UNDERPASS_.flDecayTime, Is.EqualTo(3.5700f));
        Assert.That(EFX_REVERB_PRESET_CITY_UNDERPASS_.flDecayHFRatio, Is.EqualTo(1.1200f));
        Assert.That(EFX_REVERB_PRESET_CITY_UNDERPASS_.flDecayLFRatio, Is.EqualTo(0.9100f));
        Assert.That(EFX_REVERB_PRESET_CITY_UNDERPASS_.flReflectionsGain, Is.EqualTo(0.3981f));
        Assert.That(EFX_REVERB_PRESET_CITY_UNDERPASS_.flReflectionsDelay, Is.EqualTo(0.0590f));
        Assert.That(
            EFX_REVERB_PRESET_CITY_UNDERPASS_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CITY_UNDERPASS_.flLateReverbGain, Is.EqualTo(0.8913f));
        Assert.That(EFX_REVERB_PRESET_CITY_UNDERPASS_.flLateReverbDelay, Is.EqualTo(0.0370f));
        Assert.That(
            EFX_REVERB_PRESET_CITY_UNDERPASS_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CITY_UNDERPASS_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_CITY_UNDERPASS_.flEchoDepth, Is.EqualTo(0.1400f));
        Assert.That(EFX_REVERB_PRESET_CITY_UNDERPASS_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_CITY_UNDERPASS_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_UNDERPASS_.flAirAbsorptionGainHF, Is.EqualTo(0.9920f));
        Assert.That(EFX_REVERB_PRESET_CITY_UNDERPASS_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_UNDERPASS_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_UNDERPASS_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_UNDERPASS_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_CITY_ABANDONED_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_CITY_ABANDONED_Test()
    {
        Assert.That(EFX_REVERB_PRESET_CITY_ABANDONED_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_ABANDONED_.flDiffusion, Is.EqualTo(0.6900f));
        Assert.That(EFX_REVERB_PRESET_CITY_ABANDONED_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_CITY_ABANDONED_.flGainHF, Is.EqualTo(0.7943f));
        Assert.That(EFX_REVERB_PRESET_CITY_ABANDONED_.flGainLF, Is.EqualTo(0.8913f));
        Assert.That(EFX_REVERB_PRESET_CITY_ABANDONED_.flDecayTime, Is.EqualTo(3.2800f));
        Assert.That(EFX_REVERB_PRESET_CITY_ABANDONED_.flDecayHFRatio, Is.EqualTo(1.1700f));
        Assert.That(EFX_REVERB_PRESET_CITY_ABANDONED_.flDecayLFRatio, Is.EqualTo(0.9100f));
        Assert.That(EFX_REVERB_PRESET_CITY_ABANDONED_.flReflectionsGain, Is.EqualTo(0.4467f));
        Assert.That(EFX_REVERB_PRESET_CITY_ABANDONED_.flReflectionsDelay, Is.EqualTo(0.0440f));
        Assert.That(
            EFX_REVERB_PRESET_CITY_ABANDONED_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CITY_ABANDONED_.flLateReverbGain, Is.EqualTo(0.2818f));
        Assert.That(EFX_REVERB_PRESET_CITY_ABANDONED_.flLateReverbDelay, Is.EqualTo(0.0240f));
        Assert.That(
            EFX_REVERB_PRESET_CITY_ABANDONED_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CITY_ABANDONED_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_CITY_ABANDONED_.flEchoDepth, Is.EqualTo(0.2000f));
        Assert.That(EFX_REVERB_PRESET_CITY_ABANDONED_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_CITY_ABANDONED_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_ABANDONED_.flAirAbsorptionGainHF, Is.EqualTo(0.9966f));
        Assert.That(EFX_REVERB_PRESET_CITY_ABANDONED_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_ABANDONED_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_ABANDONED_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CITY_ABANDONED_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_DUSTY_ROOM_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_DUSTY_ROOM_Test()
    {
        Assert.That(EFX_REVERB_PRESET_DUSTY_ROOM_.flDensity, Is.EqualTo(0.3645f));
        Assert.That(EFX_REVERB_PRESET_DUSTY_ROOM_.flDiffusion, Is.EqualTo(0.5600f));
        Assert.That(EFX_REVERB_PRESET_DUSTY_ROOM_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_DUSTY_ROOM_.flGainHF, Is.EqualTo(0.7943f));
        Assert.That(EFX_REVERB_PRESET_DUSTY_ROOM_.flGainLF, Is.EqualTo(0.7079f));
        Assert.That(EFX_REVERB_PRESET_DUSTY_ROOM_.flDecayTime, Is.EqualTo(1.7900f));
        Assert.That(EFX_REVERB_PRESET_DUSTY_ROOM_.flDecayHFRatio, Is.EqualTo(0.3800f));
        Assert.That(EFX_REVERB_PRESET_DUSTY_ROOM_.flDecayLFRatio, Is.EqualTo(0.2100f));
        Assert.That(EFX_REVERB_PRESET_DUSTY_ROOM_.flReflectionsGain, Is.EqualTo(0.5012f));
        Assert.That(EFX_REVERB_PRESET_DUSTY_ROOM_.flReflectionsDelay, Is.EqualTo(0.0020f));
        Assert.That(
            EFX_REVERB_PRESET_DUSTY_ROOM_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_DUSTY_ROOM_.flLateReverbGain, Is.EqualTo(1.2589f));
        Assert.That(EFX_REVERB_PRESET_DUSTY_ROOM_.flLateReverbDelay, Is.EqualTo(0.0060f));
        Assert.That(
            EFX_REVERB_PRESET_DUSTY_ROOM_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_DUSTY_ROOM_.flEchoTime, Is.EqualTo(0.2020f));
        Assert.That(EFX_REVERB_PRESET_DUSTY_ROOM_.flEchoDepth, Is.EqualTo(0.0500f));
        Assert.That(EFX_REVERB_PRESET_DUSTY_ROOM_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_DUSTY_ROOM_.flModulationDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_DUSTY_ROOM_.flAirAbsorptionGainHF, Is.EqualTo(0.9886f));
        Assert.That(EFX_REVERB_PRESET_DUSTY_ROOM_.flHFReference, Is.EqualTo(13046.0000f));
        Assert.That(EFX_REVERB_PRESET_DUSTY_ROOM_.flLFReference, Is.EqualTo(163.3000f));
        Assert.That(EFX_REVERB_PRESET_DUSTY_ROOM_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_DUSTY_ROOM_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_CHAPEL_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_CHAPEL_Test()
    {
        Assert.That(EFX_REVERB_PRESET_CHAPEL_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CHAPEL_.flDiffusion, Is.EqualTo(0.8400f));
        Assert.That(EFX_REVERB_PRESET_CHAPEL_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_CHAPEL_.flGainHF, Is.EqualTo(0.5623f));
        Assert.That(EFX_REVERB_PRESET_CHAPEL_.flGainLF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_CHAPEL_.flDecayTime, Is.EqualTo(4.6200f));
        Assert.That(EFX_REVERB_PRESET_CHAPEL_.flDecayHFRatio, Is.EqualTo(0.6400f));
        Assert.That(EFX_REVERB_PRESET_CHAPEL_.flDecayLFRatio, Is.EqualTo(1.2300f));
        Assert.That(EFX_REVERB_PRESET_CHAPEL_.flReflectionsGain, Is.EqualTo(0.4467f));
        Assert.That(EFX_REVERB_PRESET_CHAPEL_.flReflectionsDelay, Is.EqualTo(0.0320f));
        Assert.That(
            EFX_REVERB_PRESET_CHAPEL_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CHAPEL_.flLateReverbGain, Is.EqualTo(0.7943f));
        Assert.That(EFX_REVERB_PRESET_CHAPEL_.flLateReverbDelay, Is.EqualTo(0.0490f));
        Assert.That(
            EFX_REVERB_PRESET_CHAPEL_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_CHAPEL_.flEchoTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_CHAPEL_.flEchoDepth, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CHAPEL_.flModulationTime, Is.EqualTo(0.2500f));
        Assert.That(EFX_REVERB_PRESET_CHAPEL_.flModulationDepth, Is.EqualTo(0.1100f));
        Assert.That(EFX_REVERB_PRESET_CHAPEL_.flAirAbsorptionGainHF, Is.EqualTo(0.9943f));
        Assert.That(EFX_REVERB_PRESET_CHAPEL_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_CHAPEL_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_CHAPEL_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_CHAPEL_.iDecayHFLimit, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "EFX_REVERB_PRESET_SMALL_WATERROOM_"/> property is correct.</summary>

    [Test]
    public static void EFX_REVERB_PRESET_SMALL_WATERROOM_Test()
    {
        Assert.That(EFX_REVERB_PRESET_SMALL_WATERROOM_.flDensity, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_SMALL_WATERROOM_.flDiffusion, Is.EqualTo(0.7000f));
        Assert.That(EFX_REVERB_PRESET_SMALL_WATERROOM_.flGain, Is.EqualTo(0.3162f));
        Assert.That(EFX_REVERB_PRESET_SMALL_WATERROOM_.flGainHF, Is.EqualTo(0.4477f));
        Assert.That(EFX_REVERB_PRESET_SMALL_WATERROOM_.flGainLF, Is.EqualTo(1.0000f));
        Assert.That(EFX_REVERB_PRESET_SMALL_WATERROOM_.flDecayTime, Is.EqualTo(1.5100f));
        Assert.That(EFX_REVERB_PRESET_SMALL_WATERROOM_.flDecayHFRatio, Is.EqualTo(1.2500f));
        Assert.That(EFX_REVERB_PRESET_SMALL_WATERROOM_.flDecayLFRatio, Is.EqualTo(1.1400f));
        Assert.That(EFX_REVERB_PRESET_SMALL_WATERROOM_.flReflectionsGain, Is.EqualTo(0.8913f));
        Assert.That(EFX_REVERB_PRESET_SMALL_WATERROOM_.flReflectionsDelay, Is.EqualTo(0.0200f));
        Assert.That(
            EFX_REVERB_PRESET_SMALL_WATERROOM_.flReflectionsPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_SMALL_WATERROOM_.flLateReverbGain, Is.EqualTo(1.4125f));
        Assert.That(EFX_REVERB_PRESET_SMALL_WATERROOM_.flLateReverbDelay, Is.EqualTo(0.0300f));
        Assert.That(
            EFX_REVERB_PRESET_SMALL_WATERROOM_.flLateReverbPan,
            Is.EqualTo(new float[3] { 0.0000f, 0.0000f, 0.0000f })
        );
        Assert.That(EFX_REVERB_PRESET_SMALL_WATERROOM_.flEchoTime, Is.EqualTo(0.1790f));
        Assert.That(EFX_REVERB_PRESET_SMALL_WATERROOM_.flEchoDepth, Is.EqualTo(0.1500f));
        Assert.That(EFX_REVERB_PRESET_SMALL_WATERROOM_.flModulationTime, Is.EqualTo(0.8950f));
        Assert.That(EFX_REVERB_PRESET_SMALL_WATERROOM_.flModulationDepth, Is.EqualTo(0.1900f));
        Assert.That(EFX_REVERB_PRESET_SMALL_WATERROOM_.flAirAbsorptionGainHF, Is.EqualTo(0.9920f));
        Assert.That(EFX_REVERB_PRESET_SMALL_WATERROOM_.flHFReference, Is.EqualTo(5000.0000f));
        Assert.That(EFX_REVERB_PRESET_SMALL_WATERROOM_.flLFReference, Is.EqualTo(250.0000f));
        Assert.That(EFX_REVERB_PRESET_SMALL_WATERROOM_.flRoomRolloffFactor, Is.EqualTo(0.0000f));
        Assert.That(EFX_REVERB_PRESET_SMALL_WATERROOM_.iDecayHFLimit, Is.EqualTo(0x0));
    }
}
