// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='COPYFILE2_MESSAGE.xml' path='doc/member[@name="COPYFILE2_MESSAGE"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct COPYFILE2_MESSAGE
{
    /// <include file='COPYFILE2_MESSAGE.xml' path='doc/member[@name="COPYFILE2_MESSAGE.Type"]/*' />
    public COPYFILE2_MESSAGE_TYPE Type;

    /// <include file='COPYFILE2_MESSAGE.xml' path='doc/member[@name="COPYFILE2_MESSAGE.dwPadding"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwPadding;

    /// <include file='COPYFILE2_MESSAGE.xml' path='doc/member[@name="COPYFILE2_MESSAGE.Info"]/*' />
    [NativeTypeName("__AnonymousRecord_WinBase_L5797_C5")]
    public _Info_e__Union Info;

    /// <include file='_Info_e__Union.xml' path='doc/member[@name="_Info_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Info_e__Union
    {
        /// <include file='_Info_e__Union.xml' path='doc/member[@name="_Info_e__Union.ChunkStarted"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_WinBase_L5799_C9")]
        public _ChunkStarted_e__Struct ChunkStarted;

        /// <include file='_Info_e__Union.xml' path='doc/member[@name="_Info_e__Union.ChunkFinished"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_WinBase_L5810_C9")]
        public _ChunkFinished_e__Struct ChunkFinished;

        /// <include file='_Info_e__Union.xml' path='doc/member[@name="_Info_e__Union.StreamStarted"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_WinBase_L5823_C9")]
        public _StreamStarted_e__Struct StreamStarted;

        /// <include file='_Info_e__Union.xml' path='doc/member[@name="_Info_e__Union.StreamFinished"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_WinBase_L5832_C9")]
        public _StreamFinished_e__Struct StreamFinished;

        /// <include file='_Info_e__Union.xml' path='doc/member[@name="_Info_e__Union.PollContinue"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_WinBase_L5843_C9")]
        public _PollContinue_e__Struct PollContinue;

        /// <include file='_Info_e__Union.xml' path='doc/member[@name="_Info_e__Union.Error"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_WinBase_L5847_C9")]
        public _Error_e__Struct Error;

        /// <include file='_ChunkStarted_e__Struct.xml' path='doc/member[@name="_ChunkStarted_e__Struct"]/*' />
        public partial struct _ChunkStarted_e__Struct
        {
            /// <include file='_ChunkStarted_e__Struct.xml' path='doc/member[@name="_ChunkStarted_e__Struct.dwStreamNumber"]/*' />
            [NativeTypeName("DWORD")]
            public uint dwStreamNumber;

            /// <include file='_ChunkStarted_e__Struct.xml' path='doc/member[@name="_ChunkStarted_e__Struct.dwReserved"]/*' />
            [NativeTypeName("DWORD")]
            public uint dwReserved;

            /// <include file='_ChunkStarted_e__Struct.xml' path='doc/member[@name="_ChunkStarted_e__Struct.hSourceFile"]/*' />
            public HANDLE hSourceFile;

            /// <include file='_ChunkStarted_e__Struct.xml' path='doc/member[@name="_ChunkStarted_e__Struct.hDestinationFile"]/*' />
            public HANDLE hDestinationFile;

            /// <include file='_ChunkStarted_e__Struct.xml' path='doc/member[@name="_ChunkStarted_e__Struct.uliChunkNumber"]/*' />
            public ULARGE_INTEGER uliChunkNumber;

            /// <include file='_ChunkStarted_e__Struct.xml' path='doc/member[@name="_ChunkStarted_e__Struct.uliChunkSize"]/*' />
            public ULARGE_INTEGER uliChunkSize;

            /// <include file='_ChunkStarted_e__Struct.xml' path='doc/member[@name="_ChunkStarted_e__Struct.uliStreamSize"]/*' />
            public ULARGE_INTEGER uliStreamSize;

            /// <include file='_ChunkStarted_e__Struct.xml' path='doc/member[@name="_ChunkStarted_e__Struct.uliTotalFileSize"]/*' />
            public ULARGE_INTEGER uliTotalFileSize;
        }

        /// <include file='_ChunkFinished_e__Struct.xml' path='doc/member[@name="_ChunkFinished_e__Struct"]/*' />
        public partial struct _ChunkFinished_e__Struct
        {
            /// <include file='_ChunkFinished_e__Struct.xml' path='doc/member[@name="_ChunkFinished_e__Struct.dwStreamNumber"]/*' />
            [NativeTypeName("DWORD")]
            public uint dwStreamNumber;

            /// <include file='_ChunkFinished_e__Struct.xml' path='doc/member[@name="_ChunkFinished_e__Struct.dwFlags"]/*' />
            [NativeTypeName("DWORD")]
            public uint dwFlags;

            /// <include file='_ChunkFinished_e__Struct.xml' path='doc/member[@name="_ChunkFinished_e__Struct.hSourceFile"]/*' />
            public HANDLE hSourceFile;

            /// <include file='_ChunkFinished_e__Struct.xml' path='doc/member[@name="_ChunkFinished_e__Struct.hDestinationFile"]/*' />
            public HANDLE hDestinationFile;

            /// <include file='_ChunkFinished_e__Struct.xml' path='doc/member[@name="_ChunkFinished_e__Struct.uliChunkNumber"]/*' />
            public ULARGE_INTEGER uliChunkNumber;

            /// <include file='_ChunkFinished_e__Struct.xml' path='doc/member[@name="_ChunkFinished_e__Struct.uliChunkSize"]/*' />
            public ULARGE_INTEGER uliChunkSize;

            /// <include file='_ChunkFinished_e__Struct.xml' path='doc/member[@name="_ChunkFinished_e__Struct.uliStreamSize"]/*' />
            public ULARGE_INTEGER uliStreamSize;

            /// <include file='_ChunkFinished_e__Struct.xml' path='doc/member[@name="_ChunkFinished_e__Struct.uliStreamBytesTransferred"]/*' />
            public ULARGE_INTEGER uliStreamBytesTransferred;

            /// <include file='_ChunkFinished_e__Struct.xml' path='doc/member[@name="_ChunkFinished_e__Struct.uliTotalFileSize"]/*' />
            public ULARGE_INTEGER uliTotalFileSize;

            /// <include file='_ChunkFinished_e__Struct.xml' path='doc/member[@name="_ChunkFinished_e__Struct.uliTotalBytesTransferred"]/*' />
            public ULARGE_INTEGER uliTotalBytesTransferred;
        }

        /// <include file='_StreamStarted_e__Struct.xml' path='doc/member[@name="_StreamStarted_e__Struct"]/*' />
        public partial struct _StreamStarted_e__Struct
        {
            /// <include file='_StreamStarted_e__Struct.xml' path='doc/member[@name="_StreamStarted_e__Struct.dwStreamNumber"]/*' />
            [NativeTypeName("DWORD")]
            public uint dwStreamNumber;

            /// <include file='_StreamStarted_e__Struct.xml' path='doc/member[@name="_StreamStarted_e__Struct.dwReserved"]/*' />
            [NativeTypeName("DWORD")]
            public uint dwReserved;

            /// <include file='_StreamStarted_e__Struct.xml' path='doc/member[@name="_StreamStarted_e__Struct.hSourceFile"]/*' />
            public HANDLE hSourceFile;

            /// <include file='_StreamStarted_e__Struct.xml' path='doc/member[@name="_StreamStarted_e__Struct.hDestinationFile"]/*' />
            public HANDLE hDestinationFile;

            /// <include file='_StreamStarted_e__Struct.xml' path='doc/member[@name="_StreamStarted_e__Struct.uliStreamSize"]/*' />
            public ULARGE_INTEGER uliStreamSize;

            /// <include file='_StreamStarted_e__Struct.xml' path='doc/member[@name="_StreamStarted_e__Struct.uliTotalFileSize"]/*' />
            public ULARGE_INTEGER uliTotalFileSize;
        }

        /// <include file='_StreamFinished_e__Struct.xml' path='doc/member[@name="_StreamFinished_e__Struct"]/*' />
        public partial struct _StreamFinished_e__Struct
        {
            /// <include file='_StreamFinished_e__Struct.xml' path='doc/member[@name="_StreamFinished_e__Struct.dwStreamNumber"]/*' />
            [NativeTypeName("DWORD")]
            public uint dwStreamNumber;

            /// <include file='_StreamFinished_e__Struct.xml' path='doc/member[@name="_StreamFinished_e__Struct.dwReserved"]/*' />
            [NativeTypeName("DWORD")]
            public uint dwReserved;

            /// <include file='_StreamFinished_e__Struct.xml' path='doc/member[@name="_StreamFinished_e__Struct.hSourceFile"]/*' />
            public HANDLE hSourceFile;

            /// <include file='_StreamFinished_e__Struct.xml' path='doc/member[@name="_StreamFinished_e__Struct.hDestinationFile"]/*' />
            public HANDLE hDestinationFile;

            /// <include file='_StreamFinished_e__Struct.xml' path='doc/member[@name="_StreamFinished_e__Struct.uliStreamSize"]/*' />
            public ULARGE_INTEGER uliStreamSize;

            /// <include file='_StreamFinished_e__Struct.xml' path='doc/member[@name="_StreamFinished_e__Struct.uliStreamBytesTransferred"]/*' />
            public ULARGE_INTEGER uliStreamBytesTransferred;

            /// <include file='_StreamFinished_e__Struct.xml' path='doc/member[@name="_StreamFinished_e__Struct.uliTotalFileSize"]/*' />
            public ULARGE_INTEGER uliTotalFileSize;

            /// <include file='_StreamFinished_e__Struct.xml' path='doc/member[@name="_StreamFinished_e__Struct.uliTotalBytesTransferred"]/*' />
            public ULARGE_INTEGER uliTotalBytesTransferred;
        }

        /// <include file='_PollContinue_e__Struct.xml' path='doc/member[@name="_PollContinue_e__Struct"]/*' />
        public partial struct _PollContinue_e__Struct
        {
            /// <include file='_PollContinue_e__Struct.xml' path='doc/member[@name="_PollContinue_e__Struct.dwReserved"]/*' />
            [NativeTypeName("DWORD")]
            public uint dwReserved;
        }

        /// <include file='_Error_e__Struct.xml' path='doc/member[@name="_Error_e__Struct"]/*' />
        public partial struct _Error_e__Struct
        {
            /// <include file='_Error_e__Struct.xml' path='doc/member[@name="_Error_e__Struct.CopyPhase"]/*' />
            public COPYFILE2_COPY_PHASE CopyPhase;

            /// <include file='_Error_e__Struct.xml' path='doc/member[@name="_Error_e__Struct.dwStreamNumber"]/*' />
            [NativeTypeName("DWORD")]
            public uint dwStreamNumber;

            /// <include file='_Error_e__Struct.xml' path='doc/member[@name="_Error_e__Struct.hrFailure"]/*' />
            public HRESULT hrFailure;

            /// <include file='_Error_e__Struct.xml' path='doc/member[@name="_Error_e__Struct.dwReserved"]/*' />
            [NativeTypeName("DWORD")]
            public uint dwReserved;

            /// <include file='_Error_e__Struct.xml' path='doc/member[@name="_Error_e__Struct.uliChunkNumber"]/*' />
            public ULARGE_INTEGER uliChunkNumber;

            /// <include file='_Error_e__Struct.xml' path='doc/member[@name="_Error_e__Struct.uliStreamSize"]/*' />
            public ULARGE_INTEGER uliStreamSize;

            /// <include file='_Error_e__Struct.xml' path='doc/member[@name="_Error_e__Struct.uliStreamBytesTransferred"]/*' />
            public ULARGE_INTEGER uliStreamBytesTransferred;

            /// <include file='_Error_e__Struct.xml' path='doc/member[@name="_Error_e__Struct.uliTotalFileSize"]/*' />
            public ULARGE_INTEGER uliTotalFileSize;

            /// <include file='_Error_e__Struct.xml' path='doc/member[@name="_Error_e__Struct.uliTotalBytesTransferred"]/*' />
            public ULARGE_INTEGER uliTotalBytesTransferred;
        }
    }
}
