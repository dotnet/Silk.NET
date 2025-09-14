// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrPersistenceLocationBD")]
    public enum PersistenceLocationBD : int
    {
        [Obsolete("Deprecated in favour of \"LocalBD\"")]
        [NativeName("Name", "XR_PERSISTENCE_LOCATION_LOCAL_BD")]
        PersistenceLocationLocalBD = 0,
        [NativeName("Name", "XR_PERSISTENCE_LOCATION_LOCAL_BD")]
        LocalBD = 0,
    }
}
