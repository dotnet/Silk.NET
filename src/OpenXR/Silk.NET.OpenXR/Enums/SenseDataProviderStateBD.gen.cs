// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSenseDataProviderStateBD")]
    public enum SenseDataProviderStateBD : int
    {
        [Obsolete("Deprecated in favour of \"InitializedBD\"")]
        [NativeName("Name", "XR_SENSE_DATA_PROVIDER_STATE_INITIALIZED_BD")]
        SenseDataProviderStateInitializedBD = 0,
        [Obsolete("Deprecated in favour of \"RunningBD\"")]
        [NativeName("Name", "XR_SENSE_DATA_PROVIDER_STATE_RUNNING_BD")]
        SenseDataProviderStateRunningBD = 1,
        [Obsolete("Deprecated in favour of \"StoppedBD\"")]
        [NativeName("Name", "XR_SENSE_DATA_PROVIDER_STATE_STOPPED_BD")]
        SenseDataProviderStateStoppedBD = 2,
        [NativeName("Name", "XR_SENSE_DATA_PROVIDER_STATE_INITIALIZED_BD")]
        InitializedBD = 0,
        [NativeName("Name", "XR_SENSE_DATA_PROVIDER_STATE_RUNNING_BD")]
        RunningBD = 1,
        [NativeName("Name", "XR_SENSE_DATA_PROVIDER_STATE_STOPPED_BD")]
        StoppedBD = 2,
    }
}
