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

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "EVENT_INSTANCE_INFO")]
    public unsafe partial struct EventInstanceInfo
    {
        public EventInstanceInfo
        (
            void* regHandle = null,
            uint? instanceId = null
        ) : this()
        {
            if (regHandle is not null)
            {
                RegHandle = regHandle;
            }

            if (instanceId is not null)
            {
                InstanceId = instanceId.Value;
            }
        }


        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "RegHandle")]
        public void* RegHandle;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "InstanceId")]
        public uint InstanceId;
    }
}
