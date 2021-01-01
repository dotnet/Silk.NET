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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_x11_sync_object")]
    public unsafe partial class ExtX11SyncObject : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_x11_sync_object";
        [NativeApi(EntryPoint = "glImportSyncEXT")]
        public partial nint ImportSync([Flow(FlowDirection.In)] EXT external_sync_type, [Flow(FlowDirection.In)] nint external_sync, [Flow(FlowDirection.In)] uint flags);

        public ExtX11SyncObject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

