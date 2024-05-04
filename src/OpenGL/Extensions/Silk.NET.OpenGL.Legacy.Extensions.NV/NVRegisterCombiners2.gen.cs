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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_register_combiners2")]
    public unsafe partial class NVRegisterCombiners2 : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_register_combiners2";
        [NativeApi(EntryPoint = "glCombinerStageParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CombinerStageParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glCombinerStageParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerStageParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glCombinerStageParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CombinerStageParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glCombinerStageParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerStageParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glCombinerStageParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CombinerStageParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glCombinerStageParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerStageParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glCombinerStageParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CombinerStageParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glCombinerStageParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerStageParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glGetCombinerStageParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerStageParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerStageParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerStageParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerStageParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerStageParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerStageParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerStageParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerStageParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerStageParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerStageParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerStageParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerStageParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerStageParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerStageParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerStageParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        public unsafe float GetCombinerStageParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname)
        {
            // NonKhrReturnTypeOverloader
            GetCombinerStageParameter(stage, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetCombinerStageParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname)
        {
            // NonKhrReturnTypeOverloader
            GetCombinerStageParameter(stage, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetCombinerStageParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname)
        {
            // NonKhrReturnTypeOverloader
            GetCombinerStageParameter(stage, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetCombinerStageParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname)
        {
            // NonKhrReturnTypeOverloader
            GetCombinerStageParameter(stage, pname, out float silkRet);
            return silkRet;
        }

        public NVRegisterCombiners2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

