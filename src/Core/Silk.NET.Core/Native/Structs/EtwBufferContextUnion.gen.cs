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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_evntrace_L973_C5")]
    public unsafe partial struct EtwBufferContextUnion
    {
        public EtwBufferContextUnion
        (
            EtwBufferContextUnionUnion? anonymous = null,
            ushort? processorIndex = null,
            byte? processorNumber = null,
            byte? alignment = null
        ) : this()
        {
            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (processorIndex is not null)
            {
                ProcessorIndex = processorIndex.Value;
            }

            if (processorNumber is not null)
            {
                ProcessorNumber = processorNumber.Value;
            }

            if (alignment is not null)
            {
                Alignment = alignment.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_evntrace_L974_C9")]
        [NativeName("Name", "anonymous1")]
        public EtwBufferContextUnionUnion Anonymous;

        [FieldOffset(0)]
        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "ProcessorIndex")]
        public ushort ProcessorIndex;
#if NETSTANDARD2_1
        public ref byte ProcessorNumber
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.ProcessorNumber;
        }
#else
        public byte ProcessorNumber
        {
            get => Anonymous.ProcessorNumber;
            set => Anonymous.ProcessorNumber = value;
        }
#endif

#if NETSTANDARD2_1
        public ref byte Alignment
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.Alignment;
        }
#else
        public byte Alignment
        {
            get => Anonymous.Alignment;
            set => Anonymous.Alignment = value;
        }
#endif

    }
}
