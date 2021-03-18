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
    [NativeName("Name", "XrActionSuggestedBinding")]
    public unsafe partial struct ActionSuggestedBinding
    {
        public ActionSuggestedBinding
        (
            Action? action = null,
            ulong? binding = null
        ) : this()
        {
            if (action is not null)
            {
                Action = action.Value;
            }

            if (binding is not null)
            {
                Binding = binding.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrAction")]
        [NativeName("Type.Name", "XrAction")]
        [NativeName("Name", "action")]
        public Action Action;
/// <summary></summary>
        [NativeName("Type", "XrPath")]
        [NativeName("Type.Name", "XrPath")]
        [NativeName("Name", "binding")]
        public ulong Binding;
    }
}
