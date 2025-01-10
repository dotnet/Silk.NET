// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SAFEARRAYUNION
{
    [NativeTypeName("ULONG")]
    public uint sfType;

    [NativeTypeName("union __MIDL_IOleAutomationTypes_0001")]
    public _u_e__Union u;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _u_e__Union
    {
        [FieldOffset(0)]
        public SAFEARR_BSTR BstrStr;

        [FieldOffset(0)]
        public SAFEARR_UNKNOWN UnknownStr;

        [FieldOffset(0)]
        public SAFEARR_DISPATCH DispatchStr;

        [FieldOffset(0)]
        public SAFEARR_VARIANT VariantStr;

        [FieldOffset(0)]
        public SAFEARR_BRECORD RecordStr;

        [FieldOffset(0)]
        public SAFEARR_HAVEIID HaveIidStr;

        [FieldOffset(0)]
        public BYTE_SIZEDARR ByteStr;

        [FieldOffset(0)]
        public WORD_SIZEDARR WordStr;

        [FieldOffset(0)]
        public DWORD_SIZEDARR LongStr;

        [FieldOffset(0)]
        public HYPER_SIZEDARR HyperStr;
    }
}
