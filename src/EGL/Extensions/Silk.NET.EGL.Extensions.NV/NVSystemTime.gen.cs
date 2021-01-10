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
using Silk.NET.EGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.NV
{
    [Extension("NV_system_time")]
    public unsafe partial class NVSystemTime : NativeExtension<EGL>
    {
        public const string ExtensionName = "NV_system_time";
        [NativeApi(EntryPoint = "eglGetSystemTimeNV")]
        public partial ulong GetSystemTime();

        [NativeApi(EntryPoint = "eglGetSystemTimeFrequencyNV")]
        public partial ulong GetSystemTimeFrequency();

        public NVSystemTime(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

