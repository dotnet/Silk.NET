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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_win32_keyed_mutex")]
    public unsafe partial class ExtWin32KeyedMutex : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_win32_keyed_mutex";
        [NativeApi(EntryPoint = "glAcquireKeyedMutexWin32EXT", Convention = CallingConvention.Winapi)]
        public partial bool AcquireKeyedMutexWin32([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint timeout);

        [NativeApi(EntryPoint = "glReleaseKeyedMutexWin32EXT", Convention = CallingConvention.Winapi)]
        public partial bool ReleaseKeyedMutexWin32([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong key);

        public ExtWin32KeyedMutex(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

