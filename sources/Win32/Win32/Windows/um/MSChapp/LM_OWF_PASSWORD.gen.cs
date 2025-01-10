// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MSChapp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct LM_OWF_PASSWORD
{
    [NativeTypeName("CYPHER_BLOCK[2]")]
    public _data_e__FixedBuffer data;

    [InlineArray(2)]
    public partial struct _data_e__FixedBuffer
    {
        public CYPHER_BLOCK e0;
    }
}
