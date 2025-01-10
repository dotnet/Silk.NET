// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct RPCOLEMESSAGE
{
    public void* reserved1;

    [NativeTypeName("RPCOLEDATAREP")]
    public uint dataRepresentation;
    public void* Buffer;

    [NativeTypeName("ULONG")]
    public uint cbBuffer;

    [NativeTypeName("ULONG")]
    public uint iMethod;

    [NativeTypeName("void *[5]")]
    public _reserved2_e__FixedBuffer reserved2;

    [NativeTypeName("ULONG")]
    public uint rpcFlags;

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
