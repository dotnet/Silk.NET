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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DPSHADERCAPS2_0")]
    public unsafe partial struct Pshadercaps20
    {
        public Pshadercaps20
        (
            uint? caps = null,
            int? dynamicFlowControlDepth = null,
            int? numTemps = null,
            int? staticFlowControlDepth = null,
            int? numInstructionSlots = null
        ) : this()
        {
            if (caps is not null)
            {
                Caps = caps.Value;
            }

            if (dynamicFlowControlDepth is not null)
            {
                DynamicFlowControlDepth = dynamicFlowControlDepth.Value;
            }

            if (numTemps is not null)
            {
                NumTemps = numTemps.Value;
            }

            if (staticFlowControlDepth is not null)
            {
                StaticFlowControlDepth = staticFlowControlDepth.Value;
            }

            if (numInstructionSlots is not null)
            {
                NumInstructionSlots = numInstructionSlots.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Caps")]
        public uint Caps;

        [NativeName("Type", "INT")]
        [NativeName("Type.Name", "INT")]
        [NativeName("Name", "DynamicFlowControlDepth")]
        public int DynamicFlowControlDepth;

        [NativeName("Type", "INT")]
        [NativeName("Type.Name", "INT")]
        [NativeName("Name", "NumTemps")]
        public int NumTemps;

        [NativeName("Type", "INT")]
        [NativeName("Type.Name", "INT")]
        [NativeName("Name", "StaticFlowControlDepth")]
        public int StaticFlowControlDepth;

        [NativeName("Type", "INT")]
        [NativeName("Type.Name", "INT")]
        [NativeName("Name", "NumInstructionSlots")]
        public int NumInstructionSlots;
    }
}
