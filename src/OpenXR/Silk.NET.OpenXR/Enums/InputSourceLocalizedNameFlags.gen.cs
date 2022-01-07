// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrInputSourceLocalizedNameFlags")]
    public enum InputSourceLocalizedNameFlags : long
    {
        [NativeName("Name", "XR_INPUT_SOURCE_LOCALIZED_NAME_USER_PATH_BIT")]
        InputSourceLocalizedNameUserPathBit = 1,
        [NativeName("Name", "XR_INPUT_SOURCE_LOCALIZED_NAME_INTERACTION_PROFILE_BIT")]
        InputSourceLocalizedNameInteractionProfileBit = 2,
        [NativeName("Name", "XR_INPUT_SOURCE_LOCALIZED_NAME_COMPONENT_BIT")]
        InputSourceLocalizedNameComponentBit = 4,
    }
}
