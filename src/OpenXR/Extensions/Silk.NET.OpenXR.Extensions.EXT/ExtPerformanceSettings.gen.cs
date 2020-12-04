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
using Silk.NET.OpenXR;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.EXT
{
    [Extension("XR_EXT_performance_settings")]
    public unsafe partial class ExtPerformanceSettings : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_EXT_performance_settings";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrPerfSettingsSetPerformanceLevelEXT")]
        public partial Result PerfSettingsSetPerformanceLevel([Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] PerfSettingsLevelEXT level);

        public ExtPerformanceSettings(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

