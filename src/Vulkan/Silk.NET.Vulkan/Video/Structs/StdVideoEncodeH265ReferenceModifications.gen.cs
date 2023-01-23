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

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoEncodeH265ReferenceModifications")]
    public unsafe partial struct StdVideoEncodeH265ReferenceModifications
    {
        public StdVideoEncodeH265ReferenceModifications
        (
            StdVideoEncodeH265ReferenceModificationFlags? flags = null,
            byte? referenceList0ModificationsCount = null,
            byte* pReferenceList0Modifications = null,
            byte? referenceList1ModificationsCount = null,
            byte* pReferenceList1Modifications = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (referenceList0ModificationsCount is not null)
            {
                ReferenceList0ModificationsCount = referenceList0ModificationsCount.Value;
            }

            if (pReferenceList0Modifications is not null)
            {
                PReferenceList0Modifications = pReferenceList0Modifications;
            }

            if (referenceList1ModificationsCount is not null)
            {
                ReferenceList1ModificationsCount = referenceList1ModificationsCount.Value;
            }

            if (pReferenceList1Modifications is not null)
            {
                PReferenceList1Modifications = pReferenceList1Modifications;
            }
        }


        [NativeName("Type", "StdVideoEncodeH265ReferenceModificationFlags")]
        [NativeName("Type.Name", "StdVideoEncodeH265ReferenceModificationFlags")]
        [NativeName("Name", "flags")]
        public StdVideoEncodeH265ReferenceModificationFlags Flags;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "referenceList0ModificationsCount")]
        public byte ReferenceList0ModificationsCount;

        [NativeName("Type", "const uint8_t *")]
        [NativeName("Type.Name", "const uint8_t *")]
        [NativeName("Name", "pReferenceList0Modifications")]
        public byte* PReferenceList0Modifications;

        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "referenceList1ModificationsCount")]
        public byte ReferenceList1ModificationsCount;

        [NativeName("Type", "const uint8_t *")]
        [NativeName("Type.Name", "const uint8_t *")]
        [NativeName("Name", "pReferenceList1Modifications")]
        public byte* PReferenceList1Modifications;
    }
}
