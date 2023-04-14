// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRVReflect
{
    [NativeName("Name", "SpvLoopControlShift_")]
    public enum LoopControlShift : int
    {
        [NativeName("Name", "SpvLoopControlUnrollShift")]
        UnrollShift = 0x0,
        [NativeName("Name", "SpvLoopControlDontUnrollShift")]
        DontUnrollShift = 0x1,
        [NativeName("Name", "SpvLoopControlDependencyInfiniteShift")]
        DependencyInfiniteShift = 0x2,
        [NativeName("Name", "SpvLoopControlDependencyLengthShift")]
        DependencyLengthShift = 0x3,
        [NativeName("Name", "SpvLoopControlMinIterationsShift")]
        MinIterationsShift = 0x4,
        [NativeName("Name", "SpvLoopControlMaxIterationsShift")]
        MaxIterationsShift = 0x5,
        [NativeName("Name", "SpvLoopControlIterationMultipleShift")]
        IterationMultipleShift = 0x6,
        [NativeName("Name", "SpvLoopControlPeelCountShift")]
        PeelCountShift = 0x7,
        [NativeName("Name", "SpvLoopControlPartialCountShift")]
        PartialCountShift = 0x8,
        [NativeName("Name", "SpvLoopControlInitiationIntervalINTELShift")]
        InitiationIntervalIntelshift = 0x10,
        [NativeName("Name", "SpvLoopControlMaxConcurrencyINTELShift")]
        MaxConcurrencyIntelshift = 0x11,
        [NativeName("Name", "SpvLoopControlDependencyArrayINTELShift")]
        DependencyArrayIntelshift = 0x12,
        [NativeName("Name", "SpvLoopControlPipelineEnableINTELShift")]
        PipelineEnableIntelshift = 0x13,
        [NativeName("Name", "SpvLoopControlLoopCoalesceINTELShift")]
        LoopCoalesceIntelshift = 0x14,
        [NativeName("Name", "SpvLoopControlMaxInterleavingINTELShift")]
        MaxInterleavingIntelshift = 0x15,
        [NativeName("Name", "SpvLoopControlSpeculatedIterationsINTELShift")]
        SpeculatedIterationsIntelshift = 0x16,
        [NativeName("Name", "SpvLoopControlNoFusionINTELShift")]
        NoFusionIntelshift = 0x17,
        [NativeName("Name", "SpvLoopControlMax")]
        Max = 0x7FFFFFFF,
    }
}
