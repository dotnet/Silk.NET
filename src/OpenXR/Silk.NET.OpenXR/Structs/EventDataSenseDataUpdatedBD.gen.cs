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
    [NativeName("Name", "XrEventDataSenseDataUpdatedBD")]
    public unsafe partial struct EventDataSenseDataUpdatedBD
    {
        public EventDataSenseDataUpdatedBD
        (
            StructureType? type = StructureType.TypeEventDataSenseDataUpdatedBD,
            void* next = null,
            SenseDataProviderBD? provider = null
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

            if (provider is not null)
            {
                Provider = provider.Value;
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
        [NativeName("Type", "XrSenseDataProviderBD")]
        [NativeName("Type.Name", "XrSenseDataProviderBD")]
        [NativeName("Name", "provider")]
        public SenseDataProviderBD Provider;
    }
}
