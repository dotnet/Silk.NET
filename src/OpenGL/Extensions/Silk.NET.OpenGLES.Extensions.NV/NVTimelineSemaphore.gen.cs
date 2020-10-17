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

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_timeline_semaphore")]
    public unsafe partial class NVTimelineSemaphore : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_timeline_semaphore";
        [NativeApi(EntryPoint = "glCreateSemaphoresNV")]
        public unsafe partial void CreateSemaphores([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* semaphores);

        [NativeApi(EntryPoint = "glCreateSemaphoresNV")]
        public partial void CreateSemaphores([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint semaphores);

        [NativeApi(EntryPoint = "glGetSemaphoreParameterivNV")]
        public unsafe partial void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSemaphoreParameterivNV")]
        public partial void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSemaphoreParameterivNV")]
        public unsafe partial void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSemaphoreParameterivNV")]
        public partial void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glSemaphoreParameterivNV")]
        public unsafe partial void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glSemaphoreParameterivNV")]
        public partial void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glSemaphoreParameterivNV")]
        public unsafe partial void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glSemaphoreParameterivNV")]
        public partial void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.In)] in int @params);

        public unsafe uint CreateSemaphore()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateSemaphores(n, &ret);
            return ret;
        }

        public NVTimelineSemaphore(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

