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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_command_list")]
    public unsafe partial class NVCommandList : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_command_list";
        [NativeApi(EntryPoint = "glCallCommandListNV", Convention = CallingConvention.Winapi)]
        public partial void CallCommandList([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint list);

        [NativeApi(EntryPoint = "glCommandListSegmentsNV", Convention = CallingConvention.Winapi)]
        public partial void CommandListSegments([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint segments);

        [NativeApi(EntryPoint = "glCompileCommandListNV", Convention = CallingConvention.Winapi)]
        public partial void CompileCommandList([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint list);

        [NativeApi(EntryPoint = "glCreateCommandListsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateCommandLists([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* lists);

        [NativeApi(EntryPoint = "glCreateStatesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateStates([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* states);

        [NativeApi(EntryPoint = "glDeleteCommandListsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteCommandLists([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* lists);

        [NativeApi(EntryPoint = "glDeleteStatesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteStates([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* states);

        [NativeApi(EntryPoint = "glDrawCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV primitiveMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsAddressNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsAddress([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV primitiveMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStates([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStatesAddress([Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glGetCommandHeaderNV", Convention = CallingConvention.Winapi)]
        public partial uint GetCommandHeader([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV tokenID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size);

        [NativeApi(EntryPoint = "glGetStageIndexNV", Convention = CallingConvention.Winapi)]
        public partial ushort GetStageIndex([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV shadertype);

        [NativeApi(EntryPoint = "glIsCommandListNV", Convention = CallingConvention.Winapi)]
        public partial bool IsCommandList([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint list);

        [NativeApi(EntryPoint = "glIsStateNV", Convention = CallingConvention.Winapi)]
        public partial bool IsState([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint state);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glStateCaptureNV", Convention = CallingConvention.Winapi)]
        public partial void StateCapture([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint state, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode);

        public NVCommandList(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

