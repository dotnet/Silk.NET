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
    [NativeName("Name", "aiFileIO")]
    public unsafe partial struct FileIO
    {
        public FileIO
        (
            PfnFileOpenProc? openProc = null,
            PfnFileCloseProc? closeProc = null,
            byte* userData = null
        ) : this()
        {
            if (openProc is not null)
            {
                OpenProc = openProc.Value;
            }

            if (closeProc is not null)
            {
                CloseProc = closeProc.Value;
            }

            if (userData is not null)
            {
                UserData = userData;
            }
        }


        [NativeName("Type", "aiFileOpenProc")]
        [NativeName("Type.Name", "aiFileOpenProc")]
        [NativeName("Name", "OpenProc")]
        public PfnFileOpenProc OpenProc;

        [NativeName("Type", "aiFileCloseProc")]
        [NativeName("Type.Name", "aiFileCloseProc")]
        [NativeName("Name", "CloseProc")]
        public PfnFileCloseProc CloseProc;

        [NativeName("Type", "aiUserData")]
        [NativeName("Type.Name", "aiUserData")]
        [NativeName("Name", "UserData")]
        public byte* UserData;
    }
}
