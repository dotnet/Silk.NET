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
    [NativeName("Name", "WGPUCompilationInfo")]
    public unsafe partial struct CompilationInfo
    {
        public CompilationInfo
        (
            ChainedStruct* nextInChain = null,
            nuint? messageCount = null,
            CompilationMessage* messages = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (messageCount is not null)
            {
                MessageCount = messageCount.Value;
            }

            if (messages is not null)
            {
                Messages = messages;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "messageCount")]
        public nuint MessageCount;

        [NativeName("Type", "const WGPUCompilationMessage *")]
        [NativeName("Type.Name", "const WGPUCompilationMessage *")]
        [NativeName("Name", "messages")]
        public CompilationMessage* Messages;
    }
}
