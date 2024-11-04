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
    [NativeName("Name", "__AnonymousRecord_evntrace_L1342_C9")]
    public unsafe partial struct EtwBufferContextUnionUnion
    {
        public EtwBufferContextUnionUnion
        (
            byte? processorNumber = null,
            byte? alignment = null
        ) : this()
        {
            if (processorNumber is not null)
            {
                ProcessorNumber = processorNumber.Value;
            }

            if (alignment is not null)
            {
                Alignment = alignment.Value;
            }
        }


        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "ProcessorNumber")]
        public byte ProcessorNumber;

        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "Alignment")]
        public byte Alignment;
    }
}
