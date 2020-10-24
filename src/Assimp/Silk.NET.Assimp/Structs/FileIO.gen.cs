// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiFileIO")]
    public unsafe partial struct FileIO
    {
        public FileIO
        (
            void* openProc = null,
            void* closeProc = null,
            byte* userData = null
        ) : this()
        {
            if (openProc is not null)
            {
                OpenProc = openProc;
            }

            if (closeProc is not null)
            {
                CloseProc = closeProc;
            }

            if (userData is not null)
            {
                UserData = userData;
            }
        }


        [NativeName("Type", "aiFileOpenProc")]
        [NativeName("Type.Name", "aiFileOpenProc")]
        [NativeName("Name", "OpenProc")]
        public void* OpenProc;

        [NativeName("Type", "aiFileCloseProc")]
        [NativeName("Type.Name", "aiFileCloseProc")]
        [NativeName("Name", "CloseProc")]
        public void* CloseProc;

        [NativeName("Type", "aiUserData")]
        [NativeName("Type.Name", "aiUserData")]
        [NativeName("Name", "UserData")]
        public byte* UserData;
    }
}
