// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_sync")]
    public unsafe partial class ArbSync : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_sync";
        [NativeApi(EntryPoint = "glClientWaitSync")]
        public partial ARB ClientWaitSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] ulong timeout);

        [NativeApi(EntryPoint = "glDeleteSync")]
        public partial void DeleteSync([Flow(FlowDirection.In)] IntPtr sync);

        [NativeApi(EntryPoint = "glFenceSync")]
        public partial IntPtr FenceSync([Flow(FlowDirection.In)] ARB condition, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glFenceSync")]
        public partial IntPtr FenceSync([Flow(FlowDirection.In)] SyncCondition condition, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glGetInteger64v")]
        public unsafe partial void GetInteger64([Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* data);

        [NativeApi(EntryPoint = "glGetInteger64v")]
        public partial void GetInteger64([Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long data);

        [NativeApi(EntryPoint = "glGetInteger64v")]
        public unsafe partial void GetInteger64([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* data);

        [NativeApi(EntryPoint = "glGetInteger64v")]
        public partial void GetInteger64([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long data);

        [NativeApi(EntryPoint = "glGetSynciv")]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetSynciv")]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetSynciv")]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetSynciv")]
        public partial void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetSynciv")]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetSynciv")]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetSynciv")]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetSynciv")]
        public partial void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glIsSync")]
        public partial bool IsSync([Flow(FlowDirection.In)] IntPtr sync);

        [NativeApi(EntryPoint = "glWaitSync")]
        public partial void WaitSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] ulong timeout);

        public unsafe long GetInteger64([Flow(FlowDirection.In)] ARB pname)
        {
            // ReturnTypeOverloader
            long ret = default;
            GetInteger64(pname, &ret);
            return ret;
        }

        public ArbSync(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

