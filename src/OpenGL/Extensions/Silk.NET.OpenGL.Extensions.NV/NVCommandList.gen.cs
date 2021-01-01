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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_command_list")]
    public unsafe partial class NVCommandList : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_command_list";
        [NativeApi(EntryPoint = "glCallCommandListNV")]
        public partial void CallCommandList([Flow(FlowDirection.In)] uint list);

        [NativeApi(EntryPoint = "glCommandListSegmentsNV")]
        public partial void CommandListSegments([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segments);

        [NativeApi(EntryPoint = "glCompileCommandListNV")]
        public partial void CompileCommandList([Flow(FlowDirection.In)] uint list);

        [NativeApi(EntryPoint = "glCreateCommandListsNV")]
        public unsafe partial void CreateCommandLists([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* lists);

        [NativeApi(EntryPoint = "glCreateCommandListsNV")]
        public partial void CreateCommandLists([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint lists);

        [NativeApi(EntryPoint = "glCreateStatesNV")]
        public unsafe partial void CreateStates([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* states);

        [NativeApi(EntryPoint = "glCreateStatesNV")]
        public partial void CreateStates([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint states);

        [NativeApi(EntryPoint = "glDeleteCommandListsNV")]
        public unsafe partial void DeleteCommandLists([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* lists);

        [NativeApi(EntryPoint = "glDeleteCommandListsNV")]
        public partial void DeleteCommandLists([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint lists);

        [NativeApi(EntryPoint = "glDeleteStatesNV")]
        public unsafe partial void DeleteStates([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* states);

        [NativeApi(EntryPoint = "glDeleteStatesNV")]
        public partial void DeleteStates([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint states);

        [NativeApi(EntryPoint = "glDrawCommandsNV")]
        public unsafe partial void DrawCommands([Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsNV")]
        public unsafe partial void DrawCommands([Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint* indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsNV")]
        public unsafe partial void DrawCommands([Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] in nint indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsNV")]
        public partial void DrawCommands([Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] in nint indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsAddressNV")]
        public unsafe partial void DrawCommandsAddress([Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsAddressNV")]
        public unsafe partial void DrawCommandsAddress([Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsAddressNV")]
        public unsafe partial void DrawCommandsAddress([Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] in ulong indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsAddressNV")]
        public partial void DrawCommandsAddress([Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] in ulong indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV")]
        public unsafe partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV")]
        public unsafe partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV")]
        public unsafe partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV")]
        public unsafe partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV")]
        public unsafe partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint* indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV")]
        public unsafe partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint* indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV")]
        public unsafe partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint* indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV")]
        public unsafe partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint* indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV")]
        public unsafe partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] in nint indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV")]
        public unsafe partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] in nint indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV")]
        public unsafe partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] in nint indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV")]
        public unsafe partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] in nint indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV")]
        public unsafe partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] in nint indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV")]
        public unsafe partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] in nint indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV")]
        public unsafe partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] in nint indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV")]
        public partial void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] in nint indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV")]
        public unsafe partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV")]
        public unsafe partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV")]
        public unsafe partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV")]
        public unsafe partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV")]
        public unsafe partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV")]
        public unsafe partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV")]
        public unsafe partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV")]
        public unsafe partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV")]
        public unsafe partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] in ulong indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV")]
        public unsafe partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] in ulong indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV")]
        public unsafe partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] in ulong indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV")]
        public unsafe partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] in ulong indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV")]
        public unsafe partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] in ulong indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV")]
        public unsafe partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] in ulong indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV")]
        public unsafe partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] in ulong indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV")]
        public partial void DrawCommandsStatesAddress([Flow(FlowDirection.In)] in ulong indirects, [Flow(FlowDirection.In)] in uint sizes, [Flow(FlowDirection.In)] in uint states, [Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glGetCommandHeaderNV")]
        public partial uint GetCommandHeader([Flow(FlowDirection.In)] NV tokenID, [Flow(FlowDirection.In)] uint size);

        [NativeApi(EntryPoint = "glGetStageIndexNV")]
        public partial ushort GetStageIndex([Flow(FlowDirection.In)] NV shadertype);

        [NativeApi(EntryPoint = "glGetStageIndexNV")]
        public partial ushort GetStageIndex([Flow(FlowDirection.In)] ShaderType shadertype);

        [NativeApi(EntryPoint = "glIsCommandListNV")]
        public partial bool IsCommandList([Flow(FlowDirection.In)] uint list);

        [NativeApi(EntryPoint = "glIsStateNV")]
        public partial bool IsState([Flow(FlowDirection.In)] uint state);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV")]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV")]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV")]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint states, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV")]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint states, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV")]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV")]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV")]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint states, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV")]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint states, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV")]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] in void* indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV")]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] in void* indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV")]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] in void* indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint states, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV")]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] in void* indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint states, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV")]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] in void* indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV")]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] in void* indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV")]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] in void* indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint states, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV")]
        public unsafe partial void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(FlowDirection.In)] in void* indirects, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint sizes, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint states, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glStateCaptureNV")]
        public partial void StateCapture([Flow(FlowDirection.In)] uint state, [Flow(FlowDirection.In)] NV mode);

        public unsafe uint CreateCommandList()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateCommandLists(n, &ret);
            return ret;
        }

        public unsafe uint CreateState()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateStates(n, &ret);
            return ret;
        }

        public unsafe void DeleteCommandList([Count(Parameter = "n"), Flow(FlowDirection.In)] uint lists)
        {
            // ArrayParameterOverloader
            DeleteCommandLists(1, &lists);
        }

        public unsafe void DeleteState([Count(Parameter = "n"), Flow(FlowDirection.In)] uint states)
        {
            // ArrayParameterOverloader
            DeleteStates(1, &states);
        }

        public NVCommandList(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

