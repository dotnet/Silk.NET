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
    [NativeName("Name", "WGPUBindGroupLayoutDescriptor")]
    public unsafe partial struct BindGroupLayoutDescriptor
    {
        public BindGroupLayoutDescriptor
        (
            ChainedStruct* nextInChain = null,
            StringView? label = null,
            nuint? entryCount = null,
            BindGroupLayoutEntry* entries = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (label is not null)
            {
                Label = label.Value;
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


        [NativeName("Type", "WGPUChainedStruct *")]
        [NativeName("Type.Name", "WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "WGPUStringView")]
        [NativeName("Type.Name", "WGPUStringView")]
        [NativeName("Name", "label")]
        public StringView Label;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "entryCount")]
        public nuint EntryCount;

        [NativeName("Type", "const WGPUBindGroupLayoutEntry *")]
        [NativeName("Type.Name", "const WGPUBindGroupLayoutEntry *")]
        [NativeName("Name", "entries")]
        public BindGroupLayoutEntry* Entries;
    }
}
