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
    [Extension("EXT_x11_sync_object")]
    public unsafe partial class ExtX11SyncObject : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_x11_sync_object";
        [NativeApi(EntryPoint = "glImportSyncEXT", Convention = CallingConvention.Winapi)]
        public partial nint ImportSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT external_sync_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint external_sync, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint flags);

        public ExtX11SyncObject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

