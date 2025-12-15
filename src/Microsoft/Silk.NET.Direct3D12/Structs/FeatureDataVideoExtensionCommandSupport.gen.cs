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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_SUPPORT")]
    public unsafe partial struct FeatureDataVideoExtensionCommandSupport
    {
        public FeatureDataVideoExtensionCommandSupport
        (
            uint? nodeIndex = null,
            Guid? commandId = null,
            void* pInputData = null,
            nuint? inputDataSizeInBytes = null,
            void* pOutputData = null,
            nuint? outputDataSizeInBytes = null
        ) : this()
        {
            if (nodeIndex is not null)
            {
                NodeIndex = nodeIndex.Value;
            }

            if (commandId is not null)
            {
                CommandId = commandId.Value;
            }

            if (pInputData is not null)
            {
                PInputData = pInputData;
            }

            if (inputDataSizeInBytes is not null)
            {
                InputDataSizeInBytes = inputDataSizeInBytes.Value;
            }

            if (pOutputData is not null)
            {
                POutputData = pOutputData;
            }

            if (outputDataSizeInBytes is not null)
            {
                OutputDataSizeInBytes = outputDataSizeInBytes.Value;
            }
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
        public nuint InputDataSizeInBytes;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "pOutputData")]
        public void* POutputData;

        [NativeName("Type", "SIZE_T")]
        [NativeName("Type.Name", "SIZE_T")]
        [NativeName("Name", "OutputDataSizeInBytes")]
        public nuint OutputDataSizeInBytes;
    }
}
