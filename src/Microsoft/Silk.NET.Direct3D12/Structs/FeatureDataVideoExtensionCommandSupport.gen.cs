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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SUPPORT")]
    public unsafe partial struct FeatureDataVideoExtensionCommandSupport
    {
        public FeatureDataVideoExtensionCommandSupport
        (
            uint nodeIndex = default,
            Guid commandId = default,
            void* pInputData = default,
            uint inputDataSizeInBytes = default,
            void* pOutputData = default,
            uint outputDataSizeInBytes = default
        )
        {
            NodeIndex = nodeIndex;
            CommandId = commandId;
            PInputData = pInputData;
            InputDataSizeInBytes = inputDataSizeInBytes;
            POutputData = pOutputData;
            OutputDataSizeInBytes = outputDataSizeInBytes;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeIndex")]
        public uint NodeIndex;

        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "CommandId")]
        public Guid CommandId;

        [NativeName("Type", "const void *")]
        [NativeName("Type.Name", "const void *")]
        [NativeName("Name", "pInputData")]
        public void* PInputData;

        [NativeName("Type", "SIZE_T")]
        [NativeName("Type.Name", "SIZE_T")]
        [NativeName("Name", "InputDataSizeInBytes")]
        public uint InputDataSizeInBytes;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "pOutputData")]
        public void* POutputData;

        [NativeName("Type", "SIZE_T")]
        [NativeName("Type.Name", "SIZE_T")]
        [NativeName("Name", "OutputDataSizeInBytes")]
        public uint OutputDataSizeInBytes;
    }
}
