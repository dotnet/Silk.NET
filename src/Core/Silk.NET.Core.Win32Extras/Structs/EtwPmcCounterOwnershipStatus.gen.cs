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
    [NativeName("Name", "_ETW_PMC_COUNTER_OWNERSHIP_STATUS")]
    public unsafe partial struct EtwPmcCounterOwnershipStatus
    {
        public EtwPmcCounterOwnershipStatus
        (
            uint? processorNumber = null,
            uint? numberOfCounters = null
        ) : this()
        {
            if (processorNumber is not null)
            {
                ProcessorNumber = processorNumber.Value;
            }

            if (numberOfCounters is not null)
            {
                NumberOfCounters = numberOfCounters.Value;
            }
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "ProcessorNumber")]
        public uint ProcessorNumber;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "NumberOfCounters")]
        public uint NumberOfCounters;
        
        [NativeName("Type", "ETW_PMC_COUNTER_OWNER[1]")]
        [NativeName("Type.Name", "ETW_PMC_COUNTER_OWNER[1]")]
        [NativeName("Name", "CounterOwners")]
        public CounterOwnersBuffer CounterOwners;

        public struct CounterOwnersBuffer
        {
            public EtwPmcCounterOwner Element0;
            public ref EtwPmcCounterOwner this[int index]
            {
                get
                {
                    if (index > 0 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (EtwPmcCounterOwner* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<EtwPmcCounterOwner> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 1);
#endif
        }

    }
}
