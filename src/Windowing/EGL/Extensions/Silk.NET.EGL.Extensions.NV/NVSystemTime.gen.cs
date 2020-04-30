// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.EGL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.EGL.Extensions.NV
{
    [Extension("NV_system_time")]
    public abstract unsafe partial class NVSystemTime : NativeExtension<EGL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglGetSystemTimeNV")]
        public abstract ulong GetSystemTime();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglGetSystemTimeFrequencyNV")]
        public abstract ulong GetSystemTimeFrequency();

        public NVSystemTime(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

