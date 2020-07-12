// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    public unsafe struct ActiveActionSet
    {
        public ActiveActionSet
        (
            ActionSet actionSet = default,
            ulong subactionPath = default
        )
        {
           ActionSet = actionSet;
           SubactionPath = subactionPath;
        }

/// <summary></summary>
        public ActionSet ActionSet;
/// <summary></summary>
        public ulong SubactionPath;
    }
}
