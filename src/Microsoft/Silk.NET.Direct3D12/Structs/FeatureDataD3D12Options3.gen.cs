// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_FEATURE_DATA_D3D12_OPTIONS3")]
    public unsafe partial struct FeatureDataD3D12Options3
    {
        public FeatureDataD3D12Options3
        (
            int copyQueueTimestampQueriesSupported = default,
            int castingFullyTypedFormatSupported = default,
            CommandListSupportFlags writeBufferImmediateSupportFlags = default,
            ViewInstancingTier viewInstancingTier = default,
            int barycentricsSupported = default
        )
        {
            CopyQueueTimestampQueriesSupported = copyQueueTimestampQueriesSupported;
            CastingFullyTypedFormatSupported = castingFullyTypedFormatSupported;
            WriteBufferImmediateSupportFlags = writeBufferImmediateSupportFlags;
            ViewInstancingTier = viewInstancingTier;
            BarycentricsSupported = barycentricsSupported;
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "CopyQueueTimestampQueriesSupported")]
        public int CopyQueueTimestampQueriesSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "CastingFullyTypedFormatSupported")]
        public int CastingFullyTypedFormatSupported;

        [NativeName("Type", "D3D12_COMMAND_LIST_SUPPORT_FLAGS")]
        [NativeName("Type.Name", "D3D12_COMMAND_LIST_SUPPORT_FLAGS")]
        [NativeName("Name", "WriteBufferImmediateSupportFlags")]
        public CommandListSupportFlags WriteBufferImmediateSupportFlags;

        [NativeName("Type", "D3D12_VIEW_INSTANCING_TIER")]
        [NativeName("Type.Name", "D3D12_VIEW_INSTANCING_TIER")]
        [NativeName("Name", "ViewInstancingTier")]
        public ViewInstancingTier ViewInstancingTier;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "BarycentricsSupported")]
        public int BarycentricsSupported;
    }
}
