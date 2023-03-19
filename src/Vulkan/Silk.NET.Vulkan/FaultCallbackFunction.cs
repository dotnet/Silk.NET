// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core;

namespace Silk.NET.Vulkan;

public unsafe delegate void FaultCallbackFunction(Bool32 unrecordedFaults, uint faultCount, FaultData* faults);
