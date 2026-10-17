// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSenseDataProviderStateBD")]
public enum SenseDataProviderStateBD : uint
{
    [NativeName("XR_SENSE_DATA_PROVIDER_STATE_INITIALIZED_BD")]
    Initialized = 0,

    [NativeName("XR_SENSE_DATA_PROVIDER_STATE_RUNNING_BD")]
    Running = 1,

    [NativeName("XR_SENSE_DATA_PROVIDER_STATE_STOPPED_BD")]
    Stopped = 2,
}
