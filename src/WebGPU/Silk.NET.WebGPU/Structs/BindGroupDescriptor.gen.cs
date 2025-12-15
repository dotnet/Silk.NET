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

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUBindGroupDescriptor")]
    public unsafe partial struct BindGroupDescriptor
    {
        public BindGroupDescriptor
        (
            ChainedStruct* nextInChain = null,
            byte* label = null,
            BindGroupLayout* layout = null,
            nuint? entryCount = null,
            BindGroupEntry* entries = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (label is not null)
            {
                Label = label;
            }

            if (layout is not null)
            {
                Layout = layout;
            }

            if (entryCount is not null)
            {
                EntryCount = entryCount.Value;
            }

            if (entries is not null)
            {
                Entries = entries;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "label")]
        public byte* Label;

        [NativeName("Type", "WGPUBindGroupLayout")]
        [NativeName("Type.Name", "WGPUBindGroupLayout")]
        [NativeName("Name", "layout")]
        public BindGroupLayout* Layout;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "entryCount")]
        public nuint EntryCount;

        [NativeName("Type", "const WGPUBindGroupEntry *")]
        [NativeName("Type.Name", "const WGPUBindGroupEntry *")]
        [NativeName("Name", "entries")]
        public BindGroupEntry* Entries;
    }
}
