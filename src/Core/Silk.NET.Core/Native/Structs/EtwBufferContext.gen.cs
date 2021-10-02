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

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "_ETW_BUFFER_CONTEXT")]
    public unsafe partial struct EtwBufferContext
    {
        public EtwBufferContext
        (
            ushort? loggerId = null
        ) : this()
        {
            if (loggerId is not null)
            {
                LoggerId = loggerId.Value;
            }
        }


        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "LoggerId")]
        public ushort LoggerId;
    }
}
