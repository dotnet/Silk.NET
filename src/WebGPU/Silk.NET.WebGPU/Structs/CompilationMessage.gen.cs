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
            byte* message = null,
            CompilationMessageType? type = null,
            ulong? lineNum = null,
            ulong? linePos = null,
            ulong? offset = null,
            ulong? length = null,
            ulong? utf16LinePos = null,
            ulong? utf16Offset = null,
            ulong? utf16Length = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (message is not null)
            {
                Message = message;
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

            if (utf16LinePos is not null)
            {
                Utf16LinePos = utf16LinePos.Value;
            }

            if (utf16Offset is not null)
            {
                Utf16Offset = utf16Offset.Value;
            }

            if (utf16Length is not null)
            {
                Utf16Length = utf16Length.Value;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "message")]
        public byte* Message;

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

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "utf16LinePos")]
        public ulong Utf16LinePos;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "utf16Offset")]
        public ulong Utf16Offset;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "utf16Length")]
        public ulong Utf16Length;
    }
}
