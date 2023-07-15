// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.WinRT;
/// <include file='MLOperatorAttributeNameValue.xml' path='doc/member[@name="MLOperatorAttributeNameValue"]/*'/>
public unsafe partial struct MLOperatorAttributeNameValue
{
    /// <include file='MLOperatorAttributeNameValue.xml' path='doc/member[@name="MLOperatorAttributeNameValue.name"]/*'/>
    [NativeTypeName("const char *")]
    public sbyte* name;
    /// <include file='MLOperatorAttributeNameValue.xml' path='doc/member[@name="MLOperatorAttributeNameValue.type"]/*'/>
    public MLOperatorAttributeType type;
    /// <include file='MLOperatorAttributeNameValue.xml' path='doc/member[@name="MLOperatorAttributeNameValue.valueCount"]/*'/>
    [NativeTypeName("uint32_t")]
    public uint valueCount;
    /// <include file='MLOperatorAttributeNameValue.xml' path='doc/member[@name="MLOperatorAttributeNameValue.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_MLOperatorAuthor_L600_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.reserved"]/*'/>
    [UnscopedRef]
    public ref void* reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.reserved;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ints"]/*'/>
    [UnscopedRef]
    public ref long* ints
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.ints;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.strings"]/*'/>
    [UnscopedRef]
    public ref sbyte** strings
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.strings;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.floats"]/*'/>
    [UnscopedRef]
    public ref float* floats
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.floats;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.reserved"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("const void *")]
        public void* reserved;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ints"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("const int64_t *")]
        public long* ints;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.strings"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("const char *const *")]
        public sbyte** strings;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.floats"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("const float *")]
        public float* floats;
    }
}