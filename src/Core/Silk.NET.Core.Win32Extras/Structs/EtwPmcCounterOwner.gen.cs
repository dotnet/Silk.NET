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
    [NativeName("Name", "_ETW_PMC_COUNTER_OWNER")]
    public unsafe partial struct EtwPmcCounterOwner
    {
        public EtwPmcCounterOwner
        (
            EtwPmcCounterOwnerType? ownerType = null,
            uint? profileSource = null,
            uint? ownerTag = null
        ) : this()
        {
            if (ownerType is not null)
            {
                OwnerType = ownerType.Value;
            }

            if (profileSource is not null)
            {
                ProfileSource = profileSource.Value;
            }

            if (ownerTag is not null)
            {
                OwnerTag = ownerTag.Value;
            }
        }


        [NativeName("Type", "ETW_PMC_COUNTER_OWNER_TYPE")]
        [NativeName("Type.Name", "ETW_PMC_COUNTER_OWNER_TYPE")]
        [NativeName("Name", "OwnerType")]
        public EtwPmcCounterOwnerType OwnerType;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "ProfileSource")]
        public uint ProfileSource;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "OwnerTag")]
        public uint OwnerTag;
    }
}
