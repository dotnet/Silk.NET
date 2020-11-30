// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
            void* readProc = null,
            void* writeProc = null,
            void* tellProc = null,
            void* fileSizeProc = null,
            void* seekProc = null,
            void* flushProc = null,
            byte* userData = null
        ) : this()
        {
            if (readProc is not null)
            {
                ReadProc = readProc;
            }

            if (writeProc is not null)
            {
                WriteProc = writeProc;
            }

            if (tellProc is not null)
            {
                TellProc = tellProc;
            }

            if (fileSizeProc is not null)
            {
                FileSizeProc = fileSizeProc;
            }

            if (seekProc is not null)
            {
                SeekProc = seekProc;
            }

            if (flushProc is not null)
            {
                FlushProc = flushProc;
            }

            if (userData is not null)
            {
                UserData = userData;
            }
        }


        [NativeName("Type", "aiFileReadProc")]
        [NativeName("Type.Name", "aiFileReadProc")]
        [NativeName("Name", "ReadProc")]
        public void* ReadProc;

        [NativeName("Type", "aiFileWriteProc")]
        [NativeName("Type.Name", "aiFileWriteProc")]
        [NativeName("Name", "WriteProc")]
        public void* WriteProc;

        [NativeName("Type", "aiFileTellProc")]
        [NativeName("Type.Name", "aiFileTellProc")]
        [NativeName("Name", "TellProc")]
        public void* TellProc;

        [NativeName("Type", "aiFileTellProc")]
        [NativeName("Type.Name", "aiFileTellProc")]
        [NativeName("Name", "FileSizeProc")]
        public void* FileSizeProc;

        [NativeName("Type", "aiFileSeek")]
        [NativeName("Type.Name", "aiFileSeek")]
        [NativeName("Name", "SeekProc")]
        public void* SeekProc;

        [NativeName("Type", "aiFileFlushProc")]
        [NativeName("Type.Name", "aiFileFlushProc")]
        [NativeName("Name", "FlushProc")]
        public void* FlushProc;

        [NativeName("Type", "aiUserData")]
        [NativeName("Type.Name", "aiUserData")]
        [NativeName("Name", "UserData")]
        public byte* UserData;
    }
}
