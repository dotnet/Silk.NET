// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDisplayModePropertiesKHR")]
    public unsafe partial struct DisplayModePropertiesKHR
    {
        public DisplayModePropertiesKHR
        (
            DisplayModeKHR? displayMode = null,
            DisplayModeParametersKHR? parameters = null
        ) : this()
        {
            if (displayMode is not null)
            {
                DisplayMode = displayMode.Value;
            }

            if (parameters is not null)
            {
                Parameters = parameters.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkDisplayModeKHR")]
        [NativeName("Type.Name", "VkDisplayModeKHR")]
        [NativeName("Name", "displayMode")]
        public DisplayModeKHR DisplayMode;
/// <summary></summary>
        [NativeName("Type", "VkDisplayModeParametersKHR")]
        [NativeName("Type.Name", "VkDisplayModeParametersKHR")]
        [NativeName("Name", "parameters")]
        public DisplayModeParametersKHR Parameters;
    }
}
