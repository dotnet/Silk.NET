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
    [Extension("NV_register_combiners")]
    public unsafe partial class NVRegisterCombiners : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_register_combiners";
        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerOutput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerScaleNV scale, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerBiasNV bias, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool abDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool cdDotProduct, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CombinerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glCombinerParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glCombinerParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CombinerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glCombinerParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glCombinerParameterfNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glCombinerParameterfNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glCombinerParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CombinerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glCombinerParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glCombinerParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CombinerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glCombinerParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glCombinerParameteriNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glCombinerParameteriNV", Convention = CallingConvention.Winapi)]
        public partial void CombinerParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void FinalCombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void FinalCombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void FinalCombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void FinalCombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void FinalCombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void FinalCombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void FinalCombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void FinalCombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void FinalCombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void FinalCombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void FinalCombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void FinalCombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void FinalCombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void FinalCombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void FinalCombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV", Convention = CallingConvention.Winapi)]
        public partial void FinalCombinerInput([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerRegisterNV input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerMappingNV mapping, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFinalCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetFinalCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFinalCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetFinalCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFinalCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetFinalCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFinalCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetFinalCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFinalCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetFinalCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFinalCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetFinalCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFinalCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetFinalCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFinalCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetFinalCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        public unsafe float GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname)
        {
            // NonKhrReturnTypeOverloader
            GetCombinerInputParameter(stage, portion, variable, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname)
        {
            // NonKhrReturnTypeOverloader
            GetCombinerInputParameter(stage, portion, variable, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname)
        {
            // NonKhrReturnTypeOverloader
            GetCombinerInputParameter(stage, portion, variable, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname)
        {
            // NonKhrReturnTypeOverloader
            GetCombinerInputParameter(stage, portion, variable, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname)
        {
            // NonKhrReturnTypeOverloader
            GetCombinerInputParameter(stage, portion, variable, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname)
        {
            // NonKhrReturnTypeOverloader
            GetCombinerInputParameter(stage, portion, variable, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname)
        {
            // NonKhrReturnTypeOverloader
            GetCombinerInputParameter(stage, portion, variable, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname)
        {
            // NonKhrReturnTypeOverloader
            GetCombinerInputParameter(stage, portion, variable, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname)
        {
            // NonKhrReturnTypeOverloader
            GetCombinerInputParameter(stage, portion, variable, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname)
        {
            // NonKhrReturnTypeOverloader
            GetCombinerInputParameter(stage, portion, variable, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname)
        {
            // NonKhrReturnTypeOverloader
            GetCombinerInputParameter(stage, portion, variable, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname)
        {
            // NonKhrReturnTypeOverloader
            GetCombinerInputParameter(stage, portion, variable, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname)
        {
            // NonKhrReturnTypeOverloader
            GetCombinerInputParameter(stage, portion, variable, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname)
        {
            // NonKhrReturnTypeOverloader
            GetCombinerInputParameter(stage, portion, variable, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname)
        {
            // NonKhrReturnTypeOverloader
            GetCombinerInputParameter(stage, portion, variable, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname)
        {
            // NonKhrReturnTypeOverloader
            GetCombinerInputParameter(stage, portion, variable, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname)
        {
            // NonKhrReturnTypeOverloader
            GetCombinerOutputParameter(stage, portion, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname)
        {
            // NonKhrReturnTypeOverloader
            GetCombinerOutputParameter(stage, portion, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname)
        {
            // NonKhrReturnTypeOverloader
            GetCombinerOutputParameter(stage, portion, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname)
        {
            // NonKhrReturnTypeOverloader
            GetCombinerOutputParameter(stage, portion, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname)
        {
            // NonKhrReturnTypeOverloader
            GetCombinerOutputParameter(stage, portion, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname)
        {
            // NonKhrReturnTypeOverloader
            GetCombinerOutputParameter(stage, portion, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname)
        {
            // NonKhrReturnTypeOverloader
            GetCombinerOutputParameter(stage, portion, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetCombinerOutputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerStageNV stage, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerPortionNV portion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname)
        {
            // NonKhrReturnTypeOverloader
            GetCombinerOutputParameter(stage, portion, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetFinalCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname)
        {
            // NonKhrReturnTypeOverloader
            GetFinalCombinerInputParameter(variable, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetFinalCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname)
        {
            // NonKhrReturnTypeOverloader
            GetFinalCombinerInputParameter(variable, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetFinalCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname)
        {
            // NonKhrReturnTypeOverloader
            GetFinalCombinerInputParameter(variable, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetFinalCombinerInputParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerVariableNV variable, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinerParameterNV pname)
        {
            // NonKhrReturnTypeOverloader
            GetFinalCombinerInputParameter(variable, pname, out float silkRet);
            return silkRet;
        }

        public NVRegisterCombiners(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

