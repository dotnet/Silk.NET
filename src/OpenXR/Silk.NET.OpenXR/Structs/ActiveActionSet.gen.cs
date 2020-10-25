// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrActiveActionSet")]
    public unsafe partial struct ActiveActionSet
    {
        public ActiveActionSet
        (
            ActionSet? actionSet = null,
            ulong? subactionPath = null
        ) : this()
        {
            if (actionSet is not null)
            {
                ActionSet = actionSet.Value;
            }

            if (subactionPath is not null)
            {
                SubactionPath = subactionPath.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrActionSet")]
        [NativeName("Type.Name", "XrActionSet")]
        [NativeName("Name", "actionSet")]
        public ActionSet ActionSet;
/// <summary></summary>
        [NativeName("Type", "XrPath")]
        [NativeName("Type.Name", "XrPath")]
        [NativeName("Name", "subactionPath")]
        public ulong SubactionPath;
    }
}
