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
    [NativeName("Name", "WGPUCompilationMessage")]
    public unsafe partial struct CompilationMessage
    {
        public CompilationMessage
        (
            ChainedStruct* nextInChain = null,
            StringView? message = null,
            CompilationMessageType? type = null,
            ulong? lineNum = null,
            ulong? linePos = null,
            ulong? offset = null,
            ulong? length = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (message is not null)
            {
                Message = message.Value;
            }

            if (type is not null)
            {
                Type = type.Value;
            }

            if (lineNum is not null)
            {
                LineNum = lineNum.Value;
            }

            if (linePos is not null)
            {
                LinePos = linePos.Value;
            }

            if (offset is not null)
            {
                Offset = offset.Value;
            }

            if (length is not null)
            {
                Length = length.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStruct *")]
        [NativeName("Type.Name", "WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "WGPUStringView")]
        [NativeName("Type.Name", "WGPUStringView")]
        [NativeName("Name", "message")]
        public StringView Message;

        [NativeName("Type", "WGPUCompilationMessageType")]
        [NativeName("Type.Name", "WGPUCompilationMessageType")]
        [NativeName("Name", "type")]
        public CompilationMessageType Type;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "lineNum")]
        public ulong LineNum;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "linePos")]
        public ulong LinePos;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "offset")]
        public ulong Offset;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "length")]
        public ulong Length;
    }
}
