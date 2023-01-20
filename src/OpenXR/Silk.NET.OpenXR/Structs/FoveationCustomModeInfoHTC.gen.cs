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
    [NativeName("Name", "XrFoveationCustomModeInfoHTC")]
    public unsafe partial struct FoveationCustomModeInfoHTC
    {
        public FoveationCustomModeInfoHTC
        (
            StructureType? type = StructureType.TypeFoveationCustomModeInfoHtc,
            void* next = null,
            uint? configCount = null,
            FoveationConfigurationHTC* configs = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (configCount is not null)
            {
                ConfigCount = configCount.Value;
            }

            if (configs is not null)
            {
                Configs = configs;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "configCount")]
        public uint ConfigCount;
/// <summary></summary>
        [NativeName("Type", "XrFoveationConfigurationHTC*")]
        [NativeName("Type.Name", "XrFoveationConfigurationHTC")]
        [NativeName("Name", "configs")]
        public FoveationConfigurationHTC* Configs;
    }
}
