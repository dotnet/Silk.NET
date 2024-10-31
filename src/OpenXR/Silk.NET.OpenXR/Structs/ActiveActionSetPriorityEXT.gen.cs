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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrActiveActionSetPriorityEXT")]
    public unsafe partial struct ActiveActionSetPriorityEXT
    {
        public ActiveActionSetPriorityEXT
        (
            ActionSet? actionSet = null,
            uint? priorityOverride = null
        ) : this()
        {
            if (actionSet is not null)
            {
                ActionSet = actionSet.Value;
            }

            if (priorityOverride is not null)
            {
                PriorityOverride = priorityOverride.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrActionSet")]
        [NativeName("Type.Name", "XrActionSet")]
        [NativeName("Name", "actionSet")]
        public ActionSet ActionSet;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "priorityOverride")]
        public uint PriorityOverride;
    }
}
