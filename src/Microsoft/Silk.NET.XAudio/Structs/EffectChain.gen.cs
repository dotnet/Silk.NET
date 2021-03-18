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

namespace Silk.NET.XAudio
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [NativeName("Name", "XAUDIO2_EFFECT_CHAIN")]
    public unsafe partial struct EffectChain
    {
        public EffectChain
        (
            uint? effectCount = null,
            EffectDescriptor* pEffectDescriptors = null
        ) : this()
        {
            if (effectCount is not null)
            {
                EffectCount = effectCount.Value;
            }

            if (pEffectDescriptors is not null)
            {
                PEffectDescriptors = pEffectDescriptors;
            }
        }


        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "EffectCount")]
        public uint EffectCount;

        [NativeName("Type", "XAUDIO2_EFFECT_DESCRIPTOR *")]
        [NativeName("Type.Name", "XAUDIO2_EFFECT_DESCRIPTOR *")]
        [NativeName("Name", "pEffectDescriptors")]
        public EffectDescriptor* PEffectDescriptors;
    }
}
