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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_register_combiners")]
    public unsafe partial class NVRegisterCombiners : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_register_combiners";
        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glCombinerInputNV")]
        public partial void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        public partial void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum);

        [NativeApi(EntryPoint = "glCombinerParameterfvNV")]
        public unsafe partial void CombinerParameter([Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glCombinerParameterfvNV")]
        public partial void CombinerParameter([Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glCombinerParameterfvNV")]
        public unsafe partial void CombinerParameter([Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glCombinerParameterfvNV")]
        public partial void CombinerParameter([Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glCombinerParameterfNV")]
        public partial void CombinerParameter([Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glCombinerParameterfNV")]
        public partial void CombinerParameter([Flow(FlowDirection.In)] CombinerParameterNV pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glCombinerParameterivNV")]
        public unsafe partial void CombinerParameter([Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glCombinerParameterivNV")]
        public partial void CombinerParameter([Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glCombinerParameterivNV")]
        public unsafe partial void CombinerParameter([Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glCombinerParameterivNV")]
        public partial void CombinerParameter([Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glCombinerParameteriNV")]
        public partial void CombinerParameter([Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glCombinerParameteriNV")]
        public partial void CombinerParameter([Flow(FlowDirection.In)] CombinerParameterNV pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV")]
        public partial void FinalCombinerInput([Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV")]
        public partial void FinalCombinerInput([Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV")]
        public partial void FinalCombinerInput([Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV")]
        public partial void FinalCombinerInput([Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV")]
        public partial void FinalCombinerInput([Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV")]
        public partial void FinalCombinerInput([Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV")]
        public partial void FinalCombinerInput([Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV")]
        public partial void FinalCombinerInput([Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV")]
        public partial void FinalCombinerInput([Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV")]
        public partial void FinalCombinerInput([Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV")]
        public partial void FinalCombinerInput([Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV")]
        public partial void FinalCombinerInput([Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV")]
        public partial void FinalCombinerInput([Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV")]
        public partial void FinalCombinerInput([Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV")]
        public partial void FinalCombinerInput([Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] NV componentUsage);

        [NativeApi(EntryPoint = "glFinalCombinerInputNV")]
        public partial void FinalCombinerInput([Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public unsafe partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        public partial void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV")]
        public unsafe partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV")]
        public partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV")]
        public unsafe partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV")]
        public partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV")]
        public unsafe partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV")]
        public partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV")]
        public unsafe partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV")]
        public partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV")]
        public unsafe partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV")]
        public partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV")]
        public unsafe partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV")]
        public partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV")]
        public unsafe partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV")]
        public partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV")]
        public unsafe partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV")]
        public partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV")]
        public unsafe partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV")]
        public partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV")]
        public unsafe partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV")]
        public partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV")]
        public unsafe partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV")]
        public partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV")]
        public unsafe partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV")]
        public partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV")]
        public unsafe partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV")]
        public partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV")]
        public unsafe partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV")]
        public partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV")]
        public unsafe partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV")]
        public partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV")]
        public unsafe partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV")]
        public partial void GetCombinerOutputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterfvNV")]
        public unsafe partial void GetFinalCombinerInputParameter([Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterfvNV")]
        public partial void GetFinalCombinerInputParameter([Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterfvNV")]
        public unsafe partial void GetFinalCombinerInputParameter([Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterfvNV")]
        public partial void GetFinalCombinerInputParameter([Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterfvNV")]
        public unsafe partial void GetFinalCombinerInputParameter([Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterfvNV")]
        public partial void GetFinalCombinerInputParameter([Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterfvNV")]
        public unsafe partial void GetFinalCombinerInputParameter([Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterfvNV")]
        public partial void GetFinalCombinerInputParameter([Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterivNV")]
        public unsafe partial void GetFinalCombinerInputParameter([Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterivNV")]
        public partial void GetFinalCombinerInputParameter([Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterivNV")]
        public unsafe partial void GetFinalCombinerInputParameter([Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterivNV")]
        public partial void GetFinalCombinerInputParameter([Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterivNV")]
        public unsafe partial void GetFinalCombinerInputParameter([Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterivNV")]
        public partial void GetFinalCombinerInputParameter([Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterivNV")]
        public unsafe partial void GetFinalCombinerInputParameter([Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterivNV")]
        public partial void GetFinalCombinerInputParameter([Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        public NVRegisterCombiners(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

