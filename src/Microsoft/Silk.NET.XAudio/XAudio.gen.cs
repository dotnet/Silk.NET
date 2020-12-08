// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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
    public unsafe partial class XAudio : NativeAPI
    {

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1271, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\xaudio2.h")]
        [NativeApi(EntryPoint = "XAudio2CreateWithVersionInfo")]
        public unsafe partial int CreateWithVersionInfo(IXAudio2** ppXAudio2, uint Flags, uint XAudio2Processor, uint ntddiVersion);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1271, Column 16 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\xaudio2.h")]
        [NativeApi(EntryPoint = "XAudio2CreateWithVersionInfo")]
        public unsafe partial int CreateWithVersionInfo(ref IXAudio2* ppXAudio2, uint Flags, uint XAudio2Processor, uint ntddiVersion);


        public XAudio(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

