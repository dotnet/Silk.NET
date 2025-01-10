// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MIB_MFE_STATS_TABLE_EX_XP
{
    [NativeTypeName("DWORD")]
    public uint dwNumEntries;

    [NativeTypeName("PMIB_IPMCAST_MFE_STATS_EX_XP[1]")]
    public _table_e__FixedBuffer table;

    public unsafe partial struct _table_e__FixedBuffer
    {
        public MIB_IPMCAST_MFE_STATS_EX_XP* e0;
        public ref MIB_IPMCAST_MFE_STATS_EX_XP* this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (MIB_IPMCAST_MFE_STATS_EX_XP** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }
}
