// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;
/// <include file='RPCOLEMESSAGE.xml' path='doc/member[@name="RPCOLEMESSAGE"]/*'/>
public unsafe partial struct RPCOLEMESSAGE
{
    /// <include file='RPCOLEMESSAGE.xml' path='doc/member[@name="RPCOLEMESSAGE.reserved1"]/*'/>
    public void* reserved1;
    /// <include file='RPCOLEMESSAGE.xml' path='doc/member[@name="RPCOLEMESSAGE.dataRepresentation"]/*'/>
    [NativeTypeName("RPCOLEDATAREP")]
    public uint dataRepresentation;
    /// <include file='RPCOLEMESSAGE.xml' path='doc/member[@name="RPCOLEMESSAGE.Buffer"]/*'/>
    public void* Buffer;
    /// <include file='RPCOLEMESSAGE.xml' path='doc/member[@name="RPCOLEMESSAGE.cbBuffer"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cbBuffer;
    /// <include file='RPCOLEMESSAGE.xml' path='doc/member[@name="RPCOLEMESSAGE.iMethod"]/*'/>
    [NativeTypeName("ULONG")]
    public uint iMethod;
    /// <include file='RPCOLEMESSAGE.xml' path='doc/member[@name="RPCOLEMESSAGE.reserved2"]/*'/>
    [NativeTypeName("void *[5]")]
    public _reserved2_e__FixedBuffer reserved2;
    /// <include file='RPCOLEMESSAGE.xml' path='doc/member[@name="RPCOLEMESSAGE.rpcFlags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint rpcFlags;
    /// <include file='_reserved2_e__FixedBuffer.xml' path='doc/member[@name="_reserved2_e__FixedBuffer"]/*'/>
    public unsafe partial struct _reserved2_e__FixedBuffer
    {
        public void* e0;
        public void* e1;
        public void* e2;
        public void* e3;
        public void* e4;
        public ref void* this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (void** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }
}