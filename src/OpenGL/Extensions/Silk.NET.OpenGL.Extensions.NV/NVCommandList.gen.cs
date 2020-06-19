// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_command_list")]
    public abstract unsafe partial class NVCommandList : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_command_list";
        [NativeApi(EntryPoint = "glCallCommandListNV")]
        public abstract void CallCommandList([Flow(FlowDirection.In)] uint list);

        [NativeApi(EntryPoint = "glCommandListSegmentsNV")]
        public abstract void CommandListSegments([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segments);

        [NativeApi(EntryPoint = "glCompileCommandListNV")]
        public abstract void CompileCommandList([Flow(FlowDirection.In)] uint list);

        [NativeApi(EntryPoint = "glCreateCommandListsNV")]
        public abstract unsafe void CreateCommandLists([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* lists);

        [NativeApi(EntryPoint = "glCreateCommandListsNV")]
        public abstract void CreateCommandLists([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> lists);

        [NativeApi(EntryPoint = "glCreateStatesNV")]
        public abstract unsafe void CreateStates([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* states);

        [NativeApi(EntryPoint = "glCreateStatesNV")]
        public abstract void CreateStates([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> states);

        [NativeApi(EntryPoint = "glDeleteCommandListsNV")]
        public abstract unsafe void DeleteCommandLists([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* lists);

        [NativeApi(EntryPoint = "glDeleteCommandListsNV")]
        public abstract void DeleteCommandLists([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> lists);

        [NativeApi(EntryPoint = "glDeleteStatesNV")]
        public abstract unsafe void DeleteStates([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* states);

        [NativeApi(EntryPoint = "glDeleteStatesNV")]
        public abstract void DeleteStates([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> states);

        [NativeApi(EntryPoint = "glDrawCommandsNV")]
        public abstract unsafe void DrawCommands([Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsNV")]
        public abstract void DrawCommands([Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] Span<IntPtr> indirects, [Flow(FlowDirection.In)] Span<uint> sizes, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsAddressNV")]
        public abstract unsafe void DrawCommandsAddress([Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsAddressNV")]
        public abstract void DrawCommandsAddress([Flow(FlowDirection.In)] NV primitiveMode, [Flow(FlowDirection.In)] Span<ulong> indirects, [Flow(FlowDirection.In)] Span<uint> sizes, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV")]
        public abstract unsafe void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesNV")]
        public abstract void DrawCommandsStates([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] Span<IntPtr> indirects, [Flow(FlowDirection.In)] Span<uint> sizes, [Flow(FlowDirection.In)] Span<uint> states, [Flow(FlowDirection.In)] Span<uint> fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV")]
        public abstract unsafe void DrawCommandsStatesAddress([Flow(FlowDirection.In)] ulong* indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawCommandsStatesAddressNV")]
        public abstract void DrawCommandsStatesAddress([Flow(FlowDirection.In)] Span<ulong> indirects, [Flow(FlowDirection.In)] Span<uint> sizes, [Flow(FlowDirection.In)] Span<uint> states, [Flow(FlowDirection.In)] Span<uint> fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glGetCommandHeaderNV")]
        public abstract uint GetCommandHeader([Flow(FlowDirection.In)] NV tokenID, [Flow(FlowDirection.In)] uint size);

        [NativeApi(EntryPoint = "glGetStageIndexNV")]
        public abstract ushort GetStageIndex([Flow(FlowDirection.In)] NV shadertype);

        [NativeApi(EntryPoint = "glIsCommandListNV")]
        public abstract bool IsCommandList([Flow(FlowDirection.In)] uint list);

        [NativeApi(EntryPoint = "glIsStateNV")]
        public abstract bool IsState([Flow(FlowDirection.In)] uint state);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV")]
        public abstract unsafe void ListDrawCommandsStatesClient([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Flow(FlowDirection.In)] void** indirects, [Flow(FlowDirection.In)] uint* sizes, [Flow(FlowDirection.In)] uint* states, [Flow(FlowDirection.In)] uint* fbos, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glListDrawCommandsStatesClientNV")]
        public abstract unsafe void ListDrawCommandsStatesClient<T0>([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] uint segment, [Flow(FlowDirection.In)] void** indirects, [Flow(FlowDirection.In)] Span<uint> sizes, [Flow(FlowDirection.In)] Span<uint> states, [Flow(FlowDirection.In)] Span<uint> fbos, [Flow(FlowDirection.In)] uint count) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStateCaptureNV")]
        public abstract void StateCapture([Flow(FlowDirection.In)] uint state, [Flow(FlowDirection.In)] NV mode);

        [NativeApi(EntryPoint = "glGetStageIndexNV")]
        public abstract ushort GetStageIndex([Flow(FlowDirection.In)] ShaderType shadertype);

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

        public NVCommandList(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

