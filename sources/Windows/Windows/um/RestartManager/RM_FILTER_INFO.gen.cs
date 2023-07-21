// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/RestartManager.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='RM_FILTER_INFO.xml' path='doc/member[@name="RM_FILTER_INFO"]/*' />
public unsafe partial struct RM_FILTER_INFO
{
    /// <include file='RM_FILTER_INFO.xml' path='doc/member[@name="RM_FILTER_INFO.FilterAction"]/*' />
    public RM_FILTER_ACTION FilterAction;

    /// <include file='RM_FILTER_INFO.xml' path='doc/member[@name="RM_FILTER_INFO.FilterTrigger"]/*' />
    public RM_FILTER_TRIGGER FilterTrigger;

    /// <include file='RM_FILTER_INFO.xml' path='doc/member[@name="RM_FILTER_INFO.cbNextOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbNextOffset;

    /// <include file='RM_FILTER_INFO.xml' path='doc/member[@name="RM_FILTER_INFO.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_RestartManager_L124_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.strFilename"]/*' />
    [UnscopedRef]
    public ref ushort* strFilename
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.strFilename;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Process"]/*' />
    [UnscopedRef]
    public ref RM_UNIQUE_PROCESS Process
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Process;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.strServiceShortName"]/*' />
    [UnscopedRef]
    public ref ushort* strServiceShortName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.strServiceShortName;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.strFilename"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPWSTR")]
        public ushort* strFilename;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Process"]/*' />
        [FieldOffset(0)]
        public RM_UNIQUE_PROCESS Process;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.strServiceShortName"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPWSTR")]
        public ushort* strServiceShortName;
    }
}
