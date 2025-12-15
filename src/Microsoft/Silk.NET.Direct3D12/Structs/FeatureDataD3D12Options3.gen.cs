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

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_FEATURE_DATA_D3D12_OPTIONS3")]
    public unsafe partial struct FeatureDataD3D12Options3
    {
        public FeatureDataD3D12Options3
        (
            Silk.NET.Core.Bool32? copyQueueTimestampQueriesSupported = null,
            Silk.NET.Core.Bool32? castingFullyTypedFormatSupported = null,
            CommandListSupportFlags? writeBufferImmediateSupportFlags = null,
            ViewInstancingTier? viewInstancingTier = null,
            Silk.NET.Core.Bool32? barycentricsSupported = null
        ) : this()
        {
            if (copyQueueTimestampQueriesSupported is not null)
            {
                CopyQueueTimestampQueriesSupported = copyQueueTimestampQueriesSupported.Value;
            }

            if (castingFullyTypedFormatSupported is not null)
            {
                CastingFullyTypedFormatSupported = castingFullyTypedFormatSupported.Value;
            }

            if (writeBufferImmediateSupportFlags is not null)
            {
                WriteBufferImmediateSupportFlags = writeBufferImmediateSupportFlags.Value;
            }

            if (viewInstancingTier is not null)
            {
                ViewInstancingTier = viewInstancingTier.Value;
            }

            if (barycentricsSupported is not null)
            {
                BarycentricsSupported = barycentricsSupported.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "CopyQueueTimestampQueriesSupported")]
        public Silk.NET.Core.Bool32 CopyQueueTimestampQueriesSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "CastingFullyTypedFormatSupported")]
        public Silk.NET.Core.Bool32 CastingFullyTypedFormatSupported;

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
        public Silk.NET.Core.Bool32 BarycentricsSupported;
    }
}
