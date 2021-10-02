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

namespace Silk.NET.SDL
{
    [NativeName("Name", "SDL_AssertData")]
    public unsafe partial struct AssertData
    {
        public AssertData
        (
            int? alwaysIgnore = null,
            uint? triggerCount = null,
            byte* condition = null,
            byte* filename = null,
            int? linenum = null,
            byte* function = null,
            AssertData* next = null
        ) : this()
        {
            if (alwaysIgnore is not null)
            {
                AlwaysIgnore = alwaysIgnore.Value;
            }

            if (triggerCount is not null)
            {
                TriggerCount = triggerCount.Value;
            }

            if (condition is not null)
            {
                Condition = condition;
            }

            if (filename is not null)
            {
                Filename = filename;
            }

            if (linenum is not null)
            {
                Linenum = linenum.Value;
            }

            if (function is not null)
            {
                Function = function;
            }

            if (next is not null)
            {
                Next = next;
            }
        }


        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "always_ignore")]
        public int AlwaysIgnore;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "trigger_count")]
        public uint TriggerCount;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "condition")]
        public byte* Condition;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "filename")]
        public byte* Filename;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "linenum")]
        public int Linenum;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "function")]
        public byte* Function;

        [NativeName("Type", "const struct SDL_AssertData *")]
        [NativeName("Type.Name", "const struct SDL_AssertData *")]
        [NativeName("Name", "next")]
        public AssertData* Next;
    }
}
