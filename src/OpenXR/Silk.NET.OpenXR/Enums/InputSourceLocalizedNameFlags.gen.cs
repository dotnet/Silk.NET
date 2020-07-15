// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags()]
    [NativeName("Name", "XrInputSourceLocalizedNameFlags")]
    public enum InputSourceLocalizedNameFlags
    {
        [NativeName("Name", "XR_INPUT_SOURCE_LOCALIZED_NAME_USER_PATH_BIT")]
        InputSourceLocalizedNameUserPathBit = 1,
        [NativeName("Name", "XR_INPUT_SOURCE_LOCALIZED_NAME_INTERACTION_PROFILE_BIT")]
        InputSourceLocalizedNameInteractionProfileBit = 2,
        [NativeName("Name", "XR_INPUT_SOURCE_LOCALIZED_NAME_COMPONENT_BIT")]
        InputSourceLocalizedNameComponentBit = 4,
    }
}
