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

namespace Silk.NET.SPIRV
{
    public unsafe partial class Spv
    {
        [NativeName("Type", "const unsigned int")]
        [NativeName("Name", "SpvMagicNumber")]
        public const uint MagicNumber = unchecked((uint) 0x7230203);
        [NativeName("Type", "const unsigned int")]
        [NativeName("Name", "SpvVersion")]
        public const uint Version = unchecked((uint) 0x10600);
        [NativeName("Type", "const unsigned int")]
        [NativeName("Name", "SpvRevision")]
        public const uint Revision = unchecked((uint) 0x1);
        [NativeName("Type", "const unsigned int")]
        [NativeName("Name", "SpvOpCodeMask")]
        public const uint OpCodeMask = unchecked((uint) 0xFFFF);
        [NativeName("Type", "const unsigned int")]
        [NativeName("Name", "SpvWordCountShift")]
        public const uint WordCountShift = unchecked((uint) 0x10);

    }
}

