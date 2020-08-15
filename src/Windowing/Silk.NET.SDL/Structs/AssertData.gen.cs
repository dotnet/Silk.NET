// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
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
            int alwaysIgnore = default,
            uint triggerCount = default,
            byte* condition = default,
            byte* filename = default,
            int linenum = default,
            byte* function = default,
            AssertData* next = default
        )
        {
            AlwaysIgnore = alwaysIgnore;
            TriggerCount = triggerCount;
            Condition = condition;
            Filename = filename;
            Linenum = linenum;
            Function = function;
            Next = next;
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
