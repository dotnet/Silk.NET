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
    [NativeName("Name", "_MOF_FIELD")]
    public unsafe partial struct MofField
    {
        public MofField
        (
            ulong? dataPtr = null,
            uint? length = null,
            uint? dataType = null
        ) : this()
        {
            if (dataPtr is not null)
            {
                DataPtr = dataPtr.Value;
            }

            if (length is not null)
            {
                Length = length.Value;
            }

            if (dataType is not null)
            {
                DataType = dataType.Value;
            }
        }


        [NativeName("Type", "ULONG64")]
        [NativeName("Type.Name", "ULONG64")]
        [NativeName("Name", "DataPtr")]
        public ulong DataPtr;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "Length")]
        public uint Length;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "DataType")]
        public uint DataType;
    }
}
