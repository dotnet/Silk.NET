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
    [NativeName("Name", "aiLogStream")]
    public unsafe partial struct LogStream
    {
        public LogStream
        (
            PfnLogStreamCallback? callback = null,
            byte* user = null
        ) : this()
        {
            if (callback is not null)
            {
                Callback = callback.Value;
            }

            if (user is not null)
            {
                User = user;
            }
        }


        [NativeName("Type", "aiLogStreamCallback")]
        [NativeName("Type.Name", "aiLogStreamCallback")]
        [NativeName("Name", "callback")]
        public PfnLogStreamCallback Callback;

        [NativeName("Type", "char *")]
        [NativeName("Type.Name", "char *")]
        [NativeName("Name", "user")]
        public byte* User;
    }
}
