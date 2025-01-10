// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class DeviceDsmAction
{
    [NativeTypeName("#define DeviceDsmAction_None (0x00000000u)")]
    public const uint DeviceDsmAction_None = (0x00000000U);

    [NativeTypeName("#define DeviceDsmAction_Trim (0x00000001u)")]
    public const uint DeviceDsmAction_Trim = (0x00000001U);

    [NativeTypeName(
        "#define DeviceDsmAction_Notification (0x00000002u | DeviceDsmActionFlag_NonDestructive)"
    )]
    public const uint DeviceDsmAction_Notification = (0x00000002U | (0x80000000));

    [NativeTypeName(
        "#define DeviceDsmAction_OffloadRead (0x00000003u | DeviceDsmActionFlag_NonDestructive)"
    )]
    public const uint DeviceDsmAction_OffloadRead = (0x00000003U | (0x80000000));

    [NativeTypeName("#define DeviceDsmAction_OffloadWrite (0x00000004u)")]
    public const uint DeviceDsmAction_OffloadWrite = (0x00000004U);

    [NativeTypeName(
        "#define DeviceDsmAction_Allocation (0x00000005u | DeviceDsmActionFlag_NonDestructive)"
    )]
    public const uint DeviceDsmAction_Allocation = (0x00000005U | (0x80000000));

    [NativeTypeName(
        "#define DeviceDsmAction_Repair (0x00000006u | DeviceDsmActionFlag_NonDestructive)"
    )]
    public const uint DeviceDsmAction_Repair = (0x00000006U | (0x80000000));

    [NativeTypeName(
        "#define DeviceDsmAction_Scrub (0x00000007u | DeviceDsmActionFlag_NonDestructive)"
    )]
    public const uint DeviceDsmAction_Scrub = (0x00000007U | (0x80000000));

    [NativeTypeName(
        "#define DeviceDsmAction_DrtQuery (0x00000008u | DeviceDsmActionFlag_NonDestructive)"
    )]
    public const uint DeviceDsmAction_DrtQuery = (0x00000008U | (0x80000000));

    [NativeTypeName(
        "#define DeviceDsmAction_DrtClear (0x00000009u | DeviceDsmActionFlag_NonDestructive)"
    )]
    public const uint DeviceDsmAction_DrtClear = (0x00000009U | (0x80000000));

    [NativeTypeName(
        "#define DeviceDsmAction_DrtDisable (0x0000000Au | DeviceDsmActionFlag_NonDestructive)"
    )]
    public const uint DeviceDsmAction_DrtDisable = (0x0000000AU | (0x80000000));

    [NativeTypeName(
        "#define DeviceDsmAction_TieringQuery (0x0000000Bu | DeviceDsmActionFlag_NonDestructive)"
    )]
    public const uint DeviceDsmAction_TieringQuery = (0x0000000BU | (0x80000000));

    [NativeTypeName(
        "#define DeviceDsmAction_Map (0x0000000Cu | DeviceDsmActionFlag_NonDestructive)"
    )]
    public const uint DeviceDsmAction_Map = (0x0000000CU | (0x80000000));

    [NativeTypeName(
        "#define DeviceDsmAction_RegenerateParity (0x0000000Du | DeviceDsmActionFlag_NonDestructive)"
    )]
    public const uint DeviceDsmAction_RegenerateParity = (0x0000000DU | (0x80000000));

    [NativeTypeName(
        "#define DeviceDsmAction_NvCache_Change_Priority (0x0000000Eu | DeviceDsmActionFlag_NonDestructive)"
    )]
    public const uint DeviceDsmAction_NvCache_Change_Priority = (0x0000000EU | (0x80000000));

    [NativeTypeName(
        "#define DeviceDsmAction_NvCache_Evict (0x0000000Fu | DeviceDsmActionFlag_NonDestructive)"
    )]
    public const uint DeviceDsmAction_NvCache_Evict = (0x0000000FU | (0x80000000));

    [NativeTypeName(
        "#define DeviceDsmAction_TopologyIdQuery (0x00000010u | DeviceDsmActionFlag_NonDestructive)"
    )]
    public const uint DeviceDsmAction_TopologyIdQuery = (0x00000010U | (0x80000000));

    [NativeTypeName(
        "#define DeviceDsmAction_GetPhysicalAddresses (0x00000011u | DeviceDsmActionFlag_NonDestructive)"
    )]
    public const uint DeviceDsmAction_GetPhysicalAddresses = (0x00000011U | (0x80000000));

    [NativeTypeName(
        "#define DeviceDsmAction_ScopeRegen (0x00000012u | DeviceDsmActionFlag_NonDestructive)"
    )]
    public const uint DeviceDsmAction_ScopeRegen = (0x00000012U | (0x80000000));

    [NativeTypeName(
        "#define DeviceDsmAction_ReportZones (0x00000013u | DeviceDsmActionFlag_NonDestructive)"
    )]
    public const uint DeviceDsmAction_ReportZones = (0x00000013U | (0x80000000));

    [NativeTypeName(
        "#define DeviceDsmAction_OpenZone (0x00000014u | DeviceDsmActionFlag_NonDestructive)"
    )]
    public const uint DeviceDsmAction_OpenZone = (0x00000014U | (0x80000000));

    [NativeTypeName(
        "#define DeviceDsmAction_FinishZone (0x00000015u | DeviceDsmActionFlag_NonDestructive)"
    )]
    public const uint DeviceDsmAction_FinishZone = (0x00000015U | (0x80000000));

    [NativeTypeName(
        "#define DeviceDsmAction_CloseZone (0x00000016u | DeviceDsmActionFlag_NonDestructive)"
    )]
    public const uint DeviceDsmAction_CloseZone = (0x00000016U | (0x80000000));

    [NativeTypeName("#define DeviceDsmAction_ResetWritePointer (0x00000017u)")]
    public const uint DeviceDsmAction_ResetWritePointer = (0x00000017U);

    [NativeTypeName(
        "#define DeviceDsmAction_GetRangeErrorInfo (0x00000018u | DeviceDsmActionFlag_NonDestructive)"
    )]
    public const uint DeviceDsmAction_GetRangeErrorInfo = (0x00000018U | (0x80000000));

    [NativeTypeName("#define DeviceDsmAction_WriteZeroes (0x00000019u)")]
    public const uint DeviceDsmAction_WriteZeroes = (0x00000019U);

    [NativeTypeName(
        "#define DeviceDsmAction_LostQuery (0x0000001Au | DeviceDsmActionFlag_NonDestructive)"
    )]
    public const uint DeviceDsmAction_LostQuery = (0x0000001AU | (0x80000000));

    [NativeTypeName(
        "#define DeviceDsmAction_GetFreeSpace (0x0000001Bu | DeviceDsmActionFlag_NonDestructive)"
    )]
    public const uint DeviceDsmAction_GetFreeSpace = (0x0000001BU | (0x80000000));

    [NativeTypeName(
        "#define DeviceDsmAction_ConversionQuery (0x0000001Cu | DeviceDsmActionFlag_NonDestructive)"
    )]
    public const uint DeviceDsmAction_ConversionQuery = (0x0000001CU | (0x80000000));

    [NativeTypeName("#define DeviceDsmAction_VdtSet (0x0000001Du)")]
    public const uint DeviceDsmAction_VdtSet = (0x0000001DU);

    [NativeTypeName(
        "#define DeviceDsmAction_QueryPreferLocalRepair (0x0000001Eu | DeviceDsmActionFlag_NonDestructive)"
    )]
    public const uint DeviceDsmAction_QueryPreferLocalRepair = (0x0000001EU | (0x80000000));
}
