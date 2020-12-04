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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.APPLE
{
    [Extension("APPLE_sync")]
    public unsafe partial class AppleSync : NativeExtension<GL>
    {
        public const string ExtensionName = "APPLE_sync";
        [NativeApi(EntryPoint = "glClientWaitSyncAPPLE")]
        public partial APPLE ClientWaitSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] ulong timeout);

        [NativeApi(EntryPoint = "glDeleteSyncAPPLE")]
        public partial void DeleteSync([Flow(FlowDirection.In)] IntPtr sync);

        [NativeApi(EntryPoint = "glFenceSyncAPPLE")]
        public partial IntPtr FenceSync([Flow(FlowDirection.In)] APPLE condition, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glFenceSyncAPPLE")]
        public partial IntPtr FenceSync([Flow(FlowDirection.In)] SyncCondition condition, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glGetInteger64vAPPLE")]
        public unsafe partial void GetInteger64([Flow(FlowDirection.In)] APPLE pname, [Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetInteger64vAPPLE")]
        public partial void GetInteger64([Flow(FlowDirection.In)] APPLE pname, [Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetInteger64vAPPLE")]
        public unsafe partial void GetInteger64([Flow(FlowDirection.In)] GetPName pname, [Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetInteger64vAPPLE")]
        public partial void GetInteger64([Flow(FlowDirection.In)] GetPName pname, [Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetSyncivAPPLE")]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] APPLE pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetSyncivAPPLE")]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] APPLE pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetSyncivAPPLE")]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] APPLE pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetSyncivAPPLE")]
        public partial void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] APPLE pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetSyncivAPPLE")]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetSyncivAPPLE")]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetSyncivAPPLE")]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetSyncivAPPLE")]
        public partial void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glIsSyncAPPLE")]
        public partial bool IsSync([Flow(FlowDirection.In)] IntPtr sync);

        [NativeApi(EntryPoint = "glWaitSyncAPPLE")]
        public partial void WaitSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] ulong timeout);

        public unsafe long GetInteger64([Flow(FlowDirection.In)] APPLE pname)
        {
            // ReturnTypeOverloader
            long ret = default;
            GetInteger64(pname, &ret);
            return ret;
        }

        public AppleSync(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

