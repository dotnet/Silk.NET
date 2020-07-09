// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiFile")]
    public unsafe struct File
    {
        public File
        (
            void* readProc = default,
            void* writeProc = default,
            void* tellProc = default,
            void* fileSizeProc = default,
            void* seekProc = default,
            void* flushProc = default,
            byte* userData = default
        )
        {
           ReadProc = readProc;
           WriteProc = writeProc;
           TellProc = tellProc;
           FileSizeProc = fileSizeProc;
           SeekProc = seekProc;
           FlushProc = flushProc;
           UserData = userData;
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
