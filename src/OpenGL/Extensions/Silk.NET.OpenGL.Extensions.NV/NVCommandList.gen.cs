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
        public partial void CallCommandList([Flow(FlowDirection.In)] uint list);

        [NativeApi(EntryPoint = "glCommandListSegmentsNV", Convention = CallingConvention.Winapi)]
        public partial void CommandListSegments([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segments);

        [NativeApi(EntryPoint = "glCompileCommandListNV", Convention = CallingConvention.Winapi)]
        public partial void CompileCommandList([Flow(FlowDirection.In)] uint list);

        [NativeApi(EntryPoint = "glCreateCommandListsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateCommandLists([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* lists);

        [NativeApi(EntryPoint = "glCreateCommandListsNV", Convention = CallingConvention.Winapi)]
        public partial void CreateCommandLists([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint lists);

        [NativeApi(EntryPoint = "glCreateStatesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateStates([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* states);

        [NativeApi(EntryPoint = "glCreateStatesNV", Convention = CallingConvention.Winapi)]
        public partial void CreateStates([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint states);

        [NativeApi(EntryPoint = "glDeleteCommandListsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteCommandLists([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* lists);

        [NativeApi(EntryPoint = "glDeleteCommandListsNV", Convention = CallingConvention.Winapi)]
        public partial void DeleteCommandLists([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint lists);

        [NativeApi(EntryPoint = "glDeleteStatesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteStates([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* states);

        [NativeApi(EntryPoint = "glDeleteStatesNV", Convention = CallingConvention.Winapi)]
        public partial void DeleteStates([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint states);

        [NativeApi(EntryPoint = "glDrawCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommands([Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommands([Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint* indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommands([Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] in nint indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsNV", Convention = CallingConvention.Winapi)]
        public partial void DrawCommands([Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] in nint indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsAddressNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsAddress([Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsAddressNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsAddress([Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsAddressNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsAddress([Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] in ulong indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsAddressNV", Convention = CallingConvention.Winapi)]
        public partial void DrawCommandsAddress([Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] in ulong indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint* indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint* indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint* indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint* indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] in nint indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] in nint indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] in nint indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] in nint indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] in nint indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] in nint indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] in nint indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV", Convention = CallingConvention.Winapi)]
        public partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] in nint indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] in ulong indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] in ulong indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] in ulong indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] in ulong indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] in ulong indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] in ulong indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] in ulong indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV", Convention = CallingConvention.Winapi)]
        public partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] in ulong indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glGetCommandHeaderNV", Convention = CallingConvention.Winapi)]
        public partial uint GetCommandHeader([Flow(FlowDirection.In)] NV tokenID, [Flow(FlowDirection.In)] uint size);

        [NativeApi(EntryPoint = "glGetStageIndexNV", Convention = CallingConvention.Winapi)]
        public partial ushort GetStageIndex([Flow(FlowDirection.In)] NV shadertype);

        [NativeApi(EntryPoint = "glGetStageIndexNV", Convention = CallingConvention.Winapi)]
        public partial ushort GetStageIndex([Flow(FlowDirection.In)] ShaderType shadertype);

        [NativeApi(EntryPoint = "glIsCommandListNV", Convention = CallingConvention.Winapi)]
        public partial bool IsCommandList([Flow(FlowDirection.In)] uint list);

        [NativeApi(EntryPoint = "glIsStateNV", Convention = CallingConvention.Winapi)]
        public partial bool IsState([Flow(FlowDirection.In)] uint state);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint states, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint states, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint states, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint states, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] in void* indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] in void* indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] in void* indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint states, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] in void* indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint states, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] in void* indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] in void* indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] in void* indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint states, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] in void* indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint states, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glStateCaptureNV", Convention = CallingConvention.Winapi)]
        public partial void StateCapture([Flow(FlowDirection.In)] uint state, [Flow(FlowDirection.In)] NV mode);

        public unsafe uint CreateCommandList()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateCommandLists(n, &ret);
            return ret;
        }

        public unsafe void CreateCommandLists([Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> lists)
        {
            // ImplicitCountSpanOverloader
            CreateCommandLists((uint) lists.Length, out lists.GetPinnableReference());
        }

        public unsafe uint CreateState()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateStates(n, &ret);
            return ret;
        }

        public unsafe void CreateStates([Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> states)
        {
            // ImplicitCountSpanOverloader
            CreateStates((uint) states.Length, out states.GetPinnableReference());
        }

        public unsafe void DeleteCommandList([Count(Parameter = "n"), Flow(FlowDirection.In)] uint lists)
        {
            // ArrayParameterOverloader
            DeleteCommandLists(1, &lists);
        }

        public unsafe void DeleteCommandLists([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> lists)
        {
            // ImplicitCountSpanOverloader
            DeleteCommandLists((uint) lists.Length, in lists.GetPinnableReference());
        }

        public unsafe void DeleteState([Count(Parameter = "n"), Flow(FlowDirection.In)] uint states)
        {
            // ArrayParameterOverloader
            DeleteStates(1, &states);
        }

        public unsafe void DeleteStates([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> states)
        {
            // ImplicitCountSpanOverloader
            DeleteStates((uint) states.Length, in states.GetPinnableReference());
        }

        public unsafe void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos)
        {
            // ImplicitCountSpanOverloader
            ListDrawCommandsStatesClient(list, segment, indirects, sizes, states, in fbos.GetPinnableReference(), (uint) fbos.Length);
        }

        public unsafe void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* fbos)
        {
            // ImplicitCountSpanOverloader
            ListDrawCommandsStatesClient(list, segment, indirects, sizes, in states.GetPinnableReference(), fbos, (uint) states.Length);
        }

        public unsafe void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos)
        {
            // ImplicitCountSpanOverloader
            ListDrawCommandsStatesClient(list, segment, indirects, sizes, in states.GetPinnableReference(), in fbos.GetPinnableReference(), (uint) fbos.Length);
        }

        public unsafe void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* fbos)
        {
            // ImplicitCountSpanOverloader
            ListDrawCommandsStatesClient(list, segment, indirects, in sizes.GetPinnableReference(), states, fbos, (uint) sizes.Length);
        }

        public unsafe void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos)
        {
            // ImplicitCountSpanOverloader
            ListDrawCommandsStatesClient(list, segment, indirects, in sizes.GetPinnableReference(), states, in fbos.GetPinnableReference(), (uint) fbos.Length);
        }

        public unsafe void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* fbos)
        {
            // ImplicitCountSpanOverloader
            ListDrawCommandsStatesClient(list, segment, indirects, in sizes.GetPinnableReference(), in states.GetPinnableReference(), fbos, (uint) states.Length);
        }

        public unsafe void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos)
        {
            // ImplicitCountSpanOverloader
            ListDrawCommandsStatesClient(list, segment, indirects, in sizes.GetPinnableReference(), in states.GetPinnableReference(), in fbos.GetPinnableReference(), (uint) fbos.Length);
        }

        public unsafe void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] in void* indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos)
        {
            // ImplicitCountSpanOverloader
            ListDrawCommandsStatesClient(list, segment, in indirects, sizes, states, in fbos.GetPinnableReference(), (uint) fbos.Length);
        }

        public unsafe void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] in void* indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* fbos)
        {
            // ImplicitCountSpanOverloader
            ListDrawCommandsStatesClient(list, segment, in indirects, sizes, in states.GetPinnableReference(), fbos, (uint) states.Length);
        }

        public unsafe void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] in void* indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos)
        {
            // ImplicitCountSpanOverloader
            ListDrawCommandsStatesClient(list, segment, in indirects, sizes, in states.GetPinnableReference(), in fbos.GetPinnableReference(), (uint) fbos.Length);
        }

        public unsafe void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] in void* indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* fbos)
        {
            // ImplicitCountSpanOverloader
            ListDrawCommandsStatesClient(list, segment, in indirects, in sizes.GetPinnableReference(), states, fbos, (uint) sizes.Length);
        }

        public unsafe void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] in void* indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos)
        {
            // ImplicitCountSpanOverloader
            ListDrawCommandsStatesClient(list, segment, in indirects, in sizes.GetPinnableReference(), states, in fbos.GetPinnableReference(), (uint) fbos.Length);
        }

        public unsafe void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] in void* indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* fbos)
        {
            // ImplicitCountSpanOverloader
            ListDrawCommandsStatesClient(list, segment, in indirects, in sizes.GetPinnableReference(), in states.GetPinnableReference(), fbos, (uint) states.Length);
        }

        public unsafe void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] in void* indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> states, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> fbos)
        {
            // ImplicitCountSpanOverloader
            ListDrawCommandsStatesClient(list, segment, in indirects, in sizes.GetPinnableReference(), in states.GetPinnableReference(), in fbos.GetPinnableReference(), (uint) fbos.Length);
        }

        public NVCommandList(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

