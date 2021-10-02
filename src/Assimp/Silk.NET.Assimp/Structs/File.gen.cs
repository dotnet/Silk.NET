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

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiFile")]
    public unsafe partial struct File
    {
        public File
        (
            PfnFileReadProc? readProc = null,
            PfnFileReadProc? writeProc = null,
            PfnFileTellProc? tellProc = null,
            PfnFileTellProc? fileSizeProc = null,
            PfnFileSeek? seekProc = null,
            PfnFileFlushProc? flushProc = null,
            byte* userData = null
        ) : this()
        {
            if (readProc is not null)
            {
                ReadProc = readProc.Value;
            }

            if (writeProc is not null)
            {
                WriteProc = writeProc.Value;
            }

            if (tellProc is not null)
            {
                TellProc = tellProc.Value;
            }

            if (fileSizeProc is not null)
            {
                FileSizeProc = fileSizeProc.Value;
            }

            if (seekProc is not null)
            {
                SeekProc = seekProc.Value;
            }

            if (flushProc is not null)
            {
                FlushProc = flushProc.Value;
            }

            if (userData is not null)
            {
                UserData = userData;
            }
        }


        [NativeName("Type", "aiFileReadProc")]
        [NativeName("Type.Name", "aiFileReadProc")]
        [NativeName("Name", "ReadProc")]
        public PfnFileReadProc ReadProc;

        [NativeName("Type", "aiFileWriteProc")]
        [NativeName("Type.Name", "aiFileWriteProc")]
        [NativeName("Name", "WriteProc")]
        public PfnFileReadProc WriteProc;

        [NativeName("Type", "aiFileTellProc")]
        [NativeName("Type.Name", "aiFileTellProc")]
        [NativeName("Name", "TellProc")]
        public PfnFileTellProc TellProc;

        [NativeName("Type", "aiFileTellProc")]
        [NativeName("Type.Name", "aiFileTellProc")]
        [NativeName("Name", "FileSizeProc")]
        public PfnFileTellProc FileSizeProc;

        [NativeName("Type", "aiFileSeek")]
        [NativeName("Type.Name", "aiFileSeek")]
        [NativeName("Name", "SeekProc")]
        public PfnFileSeek SeekProc;

        [NativeName("Type", "aiFileFlushProc")]
        [NativeName("Type.Name", "aiFileFlushProc")]
        [NativeName("Name", "FlushProc")]
        public PfnFileFlushProc FlushProc;

        [NativeName("Type", "aiUserData")]
        [NativeName("Type.Name", "aiUserData")]
        [NativeName("Name", "UserData")]
        public byte* UserData;
    }
}
