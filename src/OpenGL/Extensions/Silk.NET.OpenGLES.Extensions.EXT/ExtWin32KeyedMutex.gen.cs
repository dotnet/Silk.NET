// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_win32_keyed_mutex")]
    public unsafe partial class ExtWin32KeyedMutex : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_win32_keyed_mutex";
        [NativeApi(EntryPoint = "glAcquireKeyedMutexWin32EXT")]
        public partial bool AcquireKeyedMutexWin32([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong key, [Flow(FlowDirection.In)] uint timeout);

        [NativeApi(EntryPoint = "glReleaseKeyedMutexWin32EXT")]
        public partial bool ReleaseKeyedMutexWin32([Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong key);

        public ExtWin32KeyedMutex(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

