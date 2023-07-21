// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.WinRT;

/// <include file='MLOperatorSchemaEdgeDescription.xml' path='doc/member[@name="MLOperatorSchemaEdgeDescription"]/*' />
public unsafe partial struct MLOperatorSchemaEdgeDescription
{
    /// <include file='MLOperatorSchemaEdgeDescription.xml' path='doc/member[@name="MLOperatorSchemaEdgeDescription.options"]/*' />
    public MLOperatorParameterOptions options;

    /// <include file='MLOperatorSchemaEdgeDescription.xml' path='doc/member[@name="MLOperatorSchemaEdgeDescription.typeFormat"]/*' />
    public MLOperatorSchemaEdgeTypeFormat typeFormat;

    /// <include file='MLOperatorSchemaEdgeDescription.xml' path='doc/member[@name="MLOperatorSchemaEdgeDescription.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_MLOperatorAuthor_L424_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.reserved"]/*' />
    [UnscopedRef]
    public ref void* reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.reserved;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.typeLabel"]/*' />
    [UnscopedRef]
    public ref sbyte* typeLabel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.typeLabel;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.edgeDescription"]/*' />
    [UnscopedRef]
    public ref MLOperatorEdgeDescription edgeDescription
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.edgeDescription;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.reserved"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("const void *")]
        public void* reserved;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.typeLabel"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("const char *")]
        public sbyte* typeLabel;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.edgeDescription"]/*' />
        [FieldOffset(0)]
        public MLOperatorEdgeDescription edgeDescription;
    }
}
