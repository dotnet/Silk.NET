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
    [NativeName("Name", "aiLogStream")]
    public unsafe partial struct LogStream
    {
        public LogStream
        (
            void* callback = null,
            byte* user = null
        ) : this()
        {
            if (callback is not null)
            {
                Callback = callback;
            }

            if (user is not null)
            {
                User = user;
            }
        }


        [NativeName("Type", "aiLogStreamCallback")]
        [NativeName("Type.Name", "aiLogStreamCallback")]
        [NativeName("Name", "callback")]
        public void* Callback;

        [NativeName("Type", "char *")]
        [NativeName("Type.Name", "char *")]
        [NativeName("Name", "user")]
        public byte* User;
    }
}
