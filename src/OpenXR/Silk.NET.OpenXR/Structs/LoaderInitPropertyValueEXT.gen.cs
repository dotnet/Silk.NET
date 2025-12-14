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
    [NativeName("Name", "XrLoaderInitPropertyValueEXT")]
    public unsafe partial struct LoaderInitPropertyValueEXT
    {
        public LoaderInitPropertyValueEXT
        (
            byte* name = null,
            byte* value = null
        ) : this()
        {
            if (name is not null)
            {
                Name = name;
            }

            if (value is not null)
            {
                Value = value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "char*")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "name")]
        public byte* Name;
/// <summary></summary>
        [NativeName("Type", "char*")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "value")]
        public byte* Value;
    }
}
