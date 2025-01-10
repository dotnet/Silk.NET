// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.GUID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "GUID"/> class.</summary>
public static partial class GUIDTests
{
    /// <summary>Validates that the value of the <see cref = "GUID_MAX_POWER_SAVINGS"/> property is correct.</summary>

    [Test]
    public static void GUID_MAX_POWER_SAVINGSTest()
    {
        Assert.That(
            GUID_MAX_POWER_SAVINGS,
            Is.EqualTo(
                new Guid(0xA1841308, 0x3541, 0x4FAB, 0xBC, 0x81, 0xF7, 0x15, 0x56, 0xF2, 0x0B, 0x4A)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MIN_POWER_SAVINGS"/> property is correct.</summary>

    [Test]
    public static void GUID_MIN_POWER_SAVINGSTest()
    {
        Assert.That(
            GUID_MIN_POWER_SAVINGS,
            Is.EqualTo(
                new Guid(0x8C5E7FDA, 0xE8BF, 0x4A96, 0x9A, 0x85, 0xA6, 0xE2, 0x3A, 0x8C, 0x63, 0x5C)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_TYPICAL_POWER_SAVINGS"/> property is correct.</summary>

    [Test]
    public static void GUID_TYPICAL_POWER_SAVINGSTest()
    {
        Assert.That(
            GUID_TYPICAL_POWER_SAVINGS,
            Is.EqualTo(
                new Guid(0x381B4222, 0xF694, 0x41F0, 0x96, 0x85, 0xFF, 0x5B, 0xB2, 0x60, 0xDF, 0x2E)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_POWERSCHEME_PERSONALITY"/> property is correct.</summary>

    [Test]
    public static void GUID_POWERSCHEME_PERSONALITYTest()
    {
        Assert.That(
            GUID_POWERSCHEME_PERSONALITY,
            Is.EqualTo(
                new Guid(0x245D8541, 0x3943, 0x4422, 0xB0, 0x25, 0x13, 0xA7, 0x84, 0xF6, 0x79, 0xB7)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_ACTIVE_POWERSCHEME"/> property is correct.</summary>

    [Test]
    public static void GUID_ACTIVE_POWERSCHEMETest()
    {
        Assert.That(
            GUID_ACTIVE_POWERSCHEME,
            Is.EqualTo(
                new Guid(0x31F9F286, 0x5084, 0x42FE, 0xB7, 0x20, 0x2B, 0x02, 0x64, 0x99, 0x37, 0x63)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_POWER_MODE_BEST_EFFICIENCY"/> property is correct.</summary>

    [Test]
    public static void GUID_POWER_MODE_BEST_EFFICIENCYTest()
    {
        Assert.That(
            GUID_POWER_MODE_BEST_EFFICIENCY,
            Is.EqualTo(
                new Guid(0x961cc777, 0x2547, 0x4f9d, 0x81, 0x74, 0x7d, 0x86, 0x18, 0x1b, 0x8a, 0x7a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_POWER_MODE_NONE"/> property is correct.</summary>

    [Test]
    public static void GUID_POWER_MODE_NONETest()
    {
        Assert.That(GUID_POWER_MODE_NONE, Is.EqualTo(new Guid(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_POWER_MODE_PERFORMANCE"/> property is correct.</summary>

    [Test]
    public static void GUID_POWER_MODE_PERFORMANCETest()
    {
        Assert.That(
            GUID_POWER_MODE_PERFORMANCE,
            Is.EqualTo(
                new Guid(0x3af9b8d9, 0x7c97, 0x431d, 0xad, 0x78, 0x34, 0xa8, 0xbf, 0xea, 0x43, 0x9f)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_POWER_MODE_BEST_PERFORMANCE"/> property is correct.</summary>

    [Test]
    public static void GUID_POWER_MODE_BEST_PERFORMANCETest()
    {
        Assert.That(
            GUID_POWER_MODE_BEST_PERFORMANCE,
            Is.EqualTo(
                new Guid(0xded574b5, 0x45a0, 0x4f42, 0x87, 0x37, 0x46, 0x34, 0x5c, 0x9, 0xc2, 0x38)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_IDLE_RESILIENCY_SUBGROUP"/> property is correct.</summary>

    [Test]
    public static void GUID_IDLE_RESILIENCY_SUBGROUPTest()
    {
        Assert.That(
            GUID_IDLE_RESILIENCY_SUBGROUP,
            Is.EqualTo(
                new Guid(0x2e601130, 0x5351, 0x4d9d, 0x8e, 0x4, 0x25, 0x29, 0x66, 0xba, 0xd0, 0x54)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_IDLE_RESILIENCY_PERIOD"/> property is correct.</summary>

    [Test]
    public static void GUID_IDLE_RESILIENCY_PERIODTest()
    {
        Assert.That(
            GUID_IDLE_RESILIENCY_PERIOD,
            Is.EqualTo(
                new Guid(0xc42b79aa, 0xaa3a, 0x484b, 0xa9, 0x8f, 0x2c, 0xf3, 0x2a, 0xa9, 0xa, 0x28)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_DEEP_SLEEP_ENABLED"/> property is correct.</summary>

    [Test]
    public static void GUID_DEEP_SLEEP_ENABLEDTest()
    {
        Assert.That(
            GUID_DEEP_SLEEP_ENABLED,
            Is.EqualTo(
                new Guid(0xd502f7ee, 0x1dc7, 0x4efd, 0xa5, 0x5d, 0xf0, 0x4b, 0x6f, 0x5c, 0x5, 0x45)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_DEEP_SLEEP_PLATFORM_STATE"/> property is correct.</summary>

    [Test]
    public static void GUID_DEEP_SLEEP_PLATFORM_STATETest()
    {
        Assert.That(
            GUID_DEEP_SLEEP_PLATFORM_STATE,
            Is.EqualTo(
                new Guid(0xd23f2fb8, 0x9536, 0x4038, 0x9c, 0x94, 0x1c, 0xe0, 0x2e, 0x5c, 0x21, 0x52)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_DISK_COALESCING_POWERDOWN_TIMEOUT"/> property is correct.</summary>

    [Test]
    public static void GUID_DISK_COALESCING_POWERDOWN_TIMEOUTTest()
    {
        Assert.That(
            GUID_DISK_COALESCING_POWERDOWN_TIMEOUT,
            Is.EqualTo(
                new Guid(0xc36f0eb4, 0x2988, 0x4a70, 0x8e, 0xee, 0x8, 0x84, 0xfc, 0x2c, 0x24, 0x33)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_EXECUTION_REQUIRED_REQUEST_TIMEOUT"/> property is correct.</summary>

    [Test]
    public static void GUID_EXECUTION_REQUIRED_REQUEST_TIMEOUTTest()
    {
        Assert.That(
            GUID_EXECUTION_REQUIRED_REQUEST_TIMEOUT,
            Is.EqualTo(
                new Guid(0x3166bc41, 0x7e98, 0x4e03, 0xb3, 0x4e, 0xec, 0xf, 0x5f, 0x2b, 0x21, 0x8e)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_VIDEO_SUBGROUP"/> property is correct.</summary>

    [Test]
    public static void GUID_VIDEO_SUBGROUPTest()
    {
        Assert.That(
            GUID_VIDEO_SUBGROUP,
            Is.EqualTo(
                new Guid(0x7516B95F, 0xF776, 0x4464, 0x8C, 0x53, 0x06, 0x16, 0x7F, 0x40, 0xCC, 0x99)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_VIDEO_POWERDOWN_TIMEOUT"/> property is correct.</summary>

    [Test]
    public static void GUID_VIDEO_POWERDOWN_TIMEOUTTest()
    {
        Assert.That(
            GUID_VIDEO_POWERDOWN_TIMEOUT,
            Is.EqualTo(
                new Guid(0x3C0BC021, 0xC8A8, 0x4E07, 0xA9, 0x73, 0x6B, 0x14, 0xCB, 0xCB, 0x2B, 0x7E)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_VIDEO_ANNOYANCE_TIMEOUT"/> property is correct.</summary>

    [Test]
    public static void GUID_VIDEO_ANNOYANCE_TIMEOUTTest()
    {
        Assert.That(
            GUID_VIDEO_ANNOYANCE_TIMEOUT,
            Is.EqualTo(
                new Guid(0x82DBCF2D, 0xCD67, 0x40C5, 0xBF, 0xDC, 0x9F, 0x1A, 0x5C, 0xCD, 0x46, 0x63)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_VIDEO_ADAPTIVE_PERCENT_INCREASE"/> property is correct.</summary>

    [Test]
    public static void GUID_VIDEO_ADAPTIVE_PERCENT_INCREASETest()
    {
        Assert.That(
            GUID_VIDEO_ADAPTIVE_PERCENT_INCREASE,
            Is.EqualTo(
                new Guid(0xEED904DF, 0xB142, 0x4183, 0xB1, 0x0B, 0x5A, 0x11, 0x97, 0xA3, 0x78, 0x64)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_VIDEO_DIM_TIMEOUT"/> property is correct.</summary>

    [Test]
    public static void GUID_VIDEO_DIM_TIMEOUTTest()
    {
        Assert.That(
            GUID_VIDEO_DIM_TIMEOUT,
            Is.EqualTo(
                new Guid(0x17aaa29b, 0x8b43, 0x4b94, 0xaa, 0xfe, 0x35, 0xf6, 0x4d, 0xaa, 0xf1, 0xee)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_VIDEO_ADAPTIVE_POWERDOWN"/> property is correct.</summary>

    [Test]
    public static void GUID_VIDEO_ADAPTIVE_POWERDOWNTest()
    {
        Assert.That(
            GUID_VIDEO_ADAPTIVE_POWERDOWN,
            Is.EqualTo(
                new Guid(0x90959D22, 0xD6A1, 0x49B9, 0xAF, 0x93, 0xBC, 0xE8, 0x85, 0xAD, 0x33, 0x5B)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MONITOR_POWER_ON"/> property is correct.</summary>

    [Test]
    public static void GUID_MONITOR_POWER_ONTest()
    {
        Assert.That(
            GUID_MONITOR_POWER_ON,
            Is.EqualTo(
                new Guid(0x02731015, 0x4510, 0x4526, 0x99, 0xE6, 0xE5, 0xA1, 0x7E, 0xBD, 0x1A, 0xEA)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_DEVICE_POWER_POLICY_VIDEO_BRIGHTNESS"/> property is correct.</summary>

    [Test]
    public static void GUID_DEVICE_POWER_POLICY_VIDEO_BRIGHTNESSTest()
    {
        Assert.That(
            GUID_DEVICE_POWER_POLICY_VIDEO_BRIGHTNESS,
            Is.EqualTo(
                new Guid(0xaded5e82, 0xb909, 0x4619, 0x99, 0x49, 0xf5, 0xd7, 0x1d, 0xac, 0x0b, 0xcb)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_DEVICE_POWER_POLICY_VIDEO_DIM_BRIGHTNESS"/> property is correct.</summary>

    [Test]
    public static void GUID_DEVICE_POWER_POLICY_VIDEO_DIM_BRIGHTNESSTest()
    {
        Assert.That(
            GUID_DEVICE_POWER_POLICY_VIDEO_DIM_BRIGHTNESS,
            Is.EqualTo(
                new Guid(0xf1fbfde2, 0xa960, 0x4165, 0x9f, 0x88, 0x50, 0x66, 0x79, 0x11, 0xce, 0x96)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_VIDEO_CURRENT_MONITOR_BRIGHTNESS"/> property is correct.</summary>

    [Test]
    public static void GUID_VIDEO_CURRENT_MONITOR_BRIGHTNESSTest()
    {
        Assert.That(
            GUID_VIDEO_CURRENT_MONITOR_BRIGHTNESS,
            Is.EqualTo(
                new Guid(0x8ffee2c6, 0x2d01, 0x46be, 0xad, 0xb9, 0x39, 0x8a, 0xdd, 0xc5, 0xb4, 0xff)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_VIDEO_ADAPTIVE_DISPLAY_BRIGHTNESS"/> property is correct.</summary>

    [Test]
    public static void GUID_VIDEO_ADAPTIVE_DISPLAY_BRIGHTNESSTest()
    {
        Assert.That(
            GUID_VIDEO_ADAPTIVE_DISPLAY_BRIGHTNESS,
            Is.EqualTo(
                new Guid(0xFBD9AA66, 0x9553, 0x4097, 0xBA, 0x44, 0xED, 0x6E, 0x9D, 0x65, 0xEA, 0xB8)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_CONSOLE_DISPLAY_STATE"/> property is correct.</summary>

    [Test]
    public static void GUID_CONSOLE_DISPLAY_STATETest()
    {
        Assert.That(
            GUID_CONSOLE_DISPLAY_STATE,
            Is.EqualTo(
                new Guid(0x6fe69556, 0x704a, 0x47a0, 0x8f, 0x24, 0xc2, 0x8d, 0x93, 0x6f, 0xda, 0x47)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_ALLOW_DISPLAY_REQUIRED"/> property is correct.</summary>

    [Test]
    public static void GUID_ALLOW_DISPLAY_REQUIREDTest()
    {
        Assert.That(
            GUID_ALLOW_DISPLAY_REQUIRED,
            Is.EqualTo(
                new Guid(0xA9CEB8DA, 0xCD46, 0x44FB, 0xA9, 0x8B, 0x02, 0xAF, 0x69, 0xDE, 0x46, 0x23)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_VIDEO_CONSOLE_LOCK_TIMEOUT"/> property is correct.</summary>

    [Test]
    public static void GUID_VIDEO_CONSOLE_LOCK_TIMEOUTTest()
    {
        Assert.That(
            GUID_VIDEO_CONSOLE_LOCK_TIMEOUT,
            Is.EqualTo(
                new Guid(0x8ec4b3a5, 0x6868, 0x48c2, 0xbe, 0x75, 0x4f, 0x30, 0x44, 0xbe, 0x88, 0xa7)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_ADVANCED_COLOR_QUALITY_BIAS"/> property is correct.</summary>

    [Test]
    public static void GUID_ADVANCED_COLOR_QUALITY_BIASTest()
    {
        Assert.That(
            GUID_ADVANCED_COLOR_QUALITY_BIAS,
            Is.EqualTo(
                new Guid(0x684c3e69, 0xa4f7, 0x4014, 0x87, 0x54, 0xd4, 0x51, 0x79, 0xa5, 0x61, 0x67)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_ADAPTIVE_POWER_BEHAVIOR_SUBGROUP"/> property is correct.</summary>

    [Test]
    public static void GUID_ADAPTIVE_POWER_BEHAVIOR_SUBGROUPTest()
    {
        Assert.That(
            GUID_ADAPTIVE_POWER_BEHAVIOR_SUBGROUP,
            Is.EqualTo(
                new Guid(0x8619b916, 0xe004, 0x4dd8, 0x9b, 0x66, 0xda, 0xe8, 0x6f, 0x80, 0x66, 0x98)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_NON_ADAPTIVE_INPUT_TIMEOUT"/> property is correct.</summary>

    [Test]
    public static void GUID_NON_ADAPTIVE_INPUT_TIMEOUTTest()
    {
        Assert.That(
            GUID_NON_ADAPTIVE_INPUT_TIMEOUT,
            Is.EqualTo(
                new Guid(0x5adbbfbc, 0x74e, 0x4da1, 0xba, 0x38, 0xdb, 0x8b, 0x36, 0xb2, 0xc8, 0xf3)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_ADAPTIVE_INPUT_CONTROLLER_STATE"/> property is correct.</summary>

    [Test]
    public static void GUID_ADAPTIVE_INPUT_CONTROLLER_STATETest()
    {
        Assert.That(
            GUID_ADAPTIVE_INPUT_CONTROLLER_STATE,
            Is.EqualTo(
                new Guid(0xe98fae9, 0xf45a, 0x4de1, 0xa7, 0x57, 0x60, 0x31, 0xf1, 0x97, 0xf6, 0xea)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_DISK_SUBGROUP"/> property is correct.</summary>

    [Test]
    public static void GUID_DISK_SUBGROUPTest()
    {
        Assert.That(
            GUID_DISK_SUBGROUP,
            Is.EqualTo(
                new Guid(0x0012EE47, 0x9041, 0x4B5D, 0x9B, 0x77, 0x53, 0x5F, 0xBA, 0x8B, 0x14, 0x42)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_DISK_MAX_POWER"/> property is correct.</summary>

    [Test]
    public static void GUID_DISK_MAX_POWERTest()
    {
        Assert.That(
            GUID_DISK_MAX_POWER,
            Is.EqualTo(
                new Guid(0x51dea550, 0xbb38, 0x4bc4, 0x99, 0x1b, 0xea, 0xcf, 0x37, 0xbe, 0x5e, 0xc8)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_DISK_POWERDOWN_TIMEOUT"/> property is correct.</summary>

    [Test]
    public static void GUID_DISK_POWERDOWN_TIMEOUTTest()
    {
        Assert.That(
            GUID_DISK_POWERDOWN_TIMEOUT,
            Is.EqualTo(
                new Guid(0x6738E2C4, 0xE8A5, 0x4A42, 0xB1, 0x6A, 0xE0, 0x40, 0xE7, 0x69, 0x75, 0x6E)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_DISK_IDLE_TIMEOUT"/> property is correct.</summary>

    [Test]
    public static void GUID_DISK_IDLE_TIMEOUTTest()
    {
        Assert.That(
            GUID_DISK_IDLE_TIMEOUT,
            Is.EqualTo(
                new Guid(0x58E39BA8, 0xB8E6, 0x4EF6, 0x90, 0xD0, 0x89, 0xAE, 0x32, 0xB2, 0x58, 0xD6)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_DISK_BURST_IGNORE_THRESHOLD"/> property is correct.</summary>

    [Test]
    public static void GUID_DISK_BURST_IGNORE_THRESHOLDTest()
    {
        Assert.That(
            GUID_DISK_BURST_IGNORE_THRESHOLD,
            Is.EqualTo(
                new Guid(0x80e3c60e, 0xbb94, 0x4ad8, 0xbb, 0xe0, 0x0d, 0x31, 0x95, 0xef, 0xc6, 0x63)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_DISK_ADAPTIVE_POWERDOWN"/> property is correct.</summary>

    [Test]
    public static void GUID_DISK_ADAPTIVE_POWERDOWNTest()
    {
        Assert.That(
            GUID_DISK_ADAPTIVE_POWERDOWN,
            Is.EqualTo(
                new Guid(0x396A32E1, 0x499A, 0x40B2, 0x91, 0x24, 0xA9, 0x6A, 0xFE, 0x70, 0x76, 0x67)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_DISK_NVME_NOPPME"/> property is correct.</summary>

    [Test]
    public static void GUID_DISK_NVME_NOPPMETest()
    {
        Assert.That(
            GUID_DISK_NVME_NOPPME,
            Is.EqualTo(
                new Guid(0xfc7372b6, 0xab2d, 0x43ee, 0x87, 0x97, 0x15, 0xe9, 0x84, 0x1f, 0x2c, 0xca)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_SLEEP_SUBGROUP"/> property is correct.</summary>

    [Test]
    public static void GUID_SLEEP_SUBGROUPTest()
    {
        Assert.That(
            GUID_SLEEP_SUBGROUP,
            Is.EqualTo(
                new Guid(0x238C9FA8, 0x0AAD, 0x41ED, 0x83, 0xF4, 0x97, 0xBE, 0x24, 0x2C, 0x8F, 0x20)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_SLEEP_IDLE_THRESHOLD"/> property is correct.</summary>

    [Test]
    public static void GUID_SLEEP_IDLE_THRESHOLDTest()
    {
        Assert.That(
            GUID_SLEEP_IDLE_THRESHOLD,
            Is.EqualTo(
                new Guid(0x81cd32e0, 0x7833, 0x44f3, 0x87, 0x37, 0x70, 0x81, 0xf3, 0x8d, 0x1f, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_STANDBY_TIMEOUT"/> property is correct.</summary>

    [Test]
    public static void GUID_STANDBY_TIMEOUTTest()
    {
        Assert.That(
            GUID_STANDBY_TIMEOUT,
            Is.EqualTo(
                new Guid(0x29F6C1DB, 0x86DA, 0x48C5, 0x9F, 0xDB, 0xF2, 0xB6, 0x7B, 0x1F, 0x44, 0xDA)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_UNATTEND_SLEEP_TIMEOUT"/> property is correct.</summary>

    [Test]
    public static void GUID_UNATTEND_SLEEP_TIMEOUTTest()
    {
        Assert.That(
            GUID_UNATTEND_SLEEP_TIMEOUT,
            Is.EqualTo(
                new Guid(0x7bc4a2f9, 0xd8fc, 0x4469, 0xb0, 0x7b, 0x33, 0xeb, 0x78, 0x5a, 0xac, 0xa0)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_HIBERNATE_TIMEOUT"/> property is correct.</summary>

    [Test]
    public static void GUID_HIBERNATE_TIMEOUTTest()
    {
        Assert.That(
            GUID_HIBERNATE_TIMEOUT,
            Is.EqualTo(
                new Guid(0x9D7815A6, 0x7EE4, 0x497E, 0x88, 0x88, 0x51, 0x5A, 0x05, 0xF0, 0x23, 0x64)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_HIBERNATE_FASTS4_POLICY"/> property is correct.</summary>

    [Test]
    public static void GUID_HIBERNATE_FASTS4_POLICYTest()
    {
        Assert.That(
            GUID_HIBERNATE_FASTS4_POLICY,
            Is.EqualTo(
                new Guid(0x94AC6D29, 0x73CE, 0x41A6, 0x80, 0x9F, 0x63, 0x63, 0xBA, 0x21, 0xB4, 0x7E)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_CRITICAL_POWER_TRANSITION"/> property is correct.</summary>

    [Test]
    public static void GUID_CRITICAL_POWER_TRANSITIONTest()
    {
        Assert.That(
            GUID_CRITICAL_POWER_TRANSITION,
            Is.EqualTo(
                new Guid(0xB7A27025, 0xE569, 0x46c2, 0xA5, 0x04, 0x2B, 0x96, 0xCA, 0xD2, 0x25, 0xA1)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_SYSTEM_AWAYMODE"/> property is correct.</summary>

    [Test]
    public static void GUID_SYSTEM_AWAYMODETest()
    {
        Assert.That(
            GUID_SYSTEM_AWAYMODE,
            Is.EqualTo(
                new Guid(0x98A7F580, 0x01F7, 0x48AA, 0x9C, 0x0F, 0x44, 0x35, 0x2C, 0x29, 0xE5, 0xC0)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_ALLOW_AWAYMODE"/> property is correct.</summary>

    [Test]
    public static void GUID_ALLOW_AWAYMODETest()
    {
        Assert.That(
            GUID_ALLOW_AWAYMODE,
            Is.EqualTo(
                new Guid(0x25dfa149, 0x5dd1, 0x4736, 0xb5, 0xab, 0xe8, 0xa3, 0x7b, 0x5b, 0x81, 0x87)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_USER_PRESENCE_PREDICTION"/> property is correct.</summary>

    [Test]
    public static void GUID_USER_PRESENCE_PREDICTIONTest()
    {
        Assert.That(
            GUID_USER_PRESENCE_PREDICTION,
            Is.EqualTo(
                new Guid(0x82011705, 0xfb95, 0x4d46, 0x8d, 0x35, 0x40, 0x42, 0xb1, 0xd2, 0xd, 0xef)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_STANDBY_BUDGET_GRACE_PERIOD"/> property is correct.</summary>

    [Test]
    public static void GUID_STANDBY_BUDGET_GRACE_PERIODTest()
    {
        Assert.That(
            GUID_STANDBY_BUDGET_GRACE_PERIOD,
            Is.EqualTo(
                new Guid(0x60c07fe1, 0x0556, 0x45cf, 0x99, 0x03, 0xd5, 0x6e, 0x32, 0x21, 0x2, 0x42)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_STANDBY_BUDGET_PERCENT"/> property is correct.</summary>

    [Test]
    public static void GUID_STANDBY_BUDGET_PERCENTTest()
    {
        Assert.That(
            GUID_STANDBY_BUDGET_PERCENT,
            Is.EqualTo(
                new Guid(0x9fe527be, 0x1b70, 0x48da, 0x93, 0x0d, 0x7b, 0xcf, 0x17, 0xb4, 0x49, 0x90)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_STANDBY_BUDGET_REFRESH_COUNT"/> property is correct.</summary>

    [Test]
    public static void GUID_STANDBY_BUDGET_REFRESH_COUNTTest()
    {
        Assert.That(
            GUID_STANDBY_BUDGET_REFRESH_COUNT,
            Is.EqualTo(
                new Guid(0xACA8648E, 0xC4B1, 0x4BAA, 0x8C, 0xCE, 0x93, 0x90, 0xAD, 0x64, 0x7F, 0x8C)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_STANDBY_BUDGET_REFRESH_INTERVAL"/> property is correct.</summary>

    [Test]
    public static void GUID_STANDBY_BUDGET_REFRESH_INTERVALTest()
    {
        Assert.That(
            GUID_STANDBY_BUDGET_REFRESH_INTERVAL,
            Is.EqualTo(
                new Guid(0x61F45DFE, 0x1919, 0x4180, 0xBB, 0x46, 0x8C, 0xC7, 0x0E, 0x0B, 0x38, 0xF1)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_STANDBY_RESERVE_GRACE_PERIOD"/> property is correct.</summary>

    [Test]
    public static void GUID_STANDBY_RESERVE_GRACE_PERIODTest()
    {
        Assert.That(
            GUID_STANDBY_RESERVE_GRACE_PERIOD,
            Is.EqualTo(
                new Guid(0xc763ee92, 0x71e8, 0x4127, 0x84, 0xeb, 0xf6, 0xed, 0x04, 0x3a, 0x3e, 0x3d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_STANDBY_RESERVE_TIME"/> property is correct.</summary>

    [Test]
    public static void GUID_STANDBY_RESERVE_TIMETest()
    {
        Assert.That(
            GUID_STANDBY_RESERVE_TIME,
            Is.EqualTo(
                new Guid(0x468FE7E5, 0x1158, 0x46EC, 0x88, 0xbc, 0x5b, 0x96, 0xc9, 0xe4, 0x4f, 0xd0)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_STANDBY_RESET_PERCENT"/> property is correct.</summary>

    [Test]
    public static void GUID_STANDBY_RESET_PERCENTTest()
    {
        Assert.That(
            GUID_STANDBY_RESET_PERCENT,
            Is.EqualTo(
                new Guid(0x49cb11a5, 0x56e2, 0x4afb, 0x9d, 0x38, 0x3d, 0xf4, 0x78, 0x72, 0xe2, 0x1b)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_HUPR_ADAPTIVE_AWAY_DISPLAY_TIMEOUT"/> property is correct.</summary>

    [Test]
    public static void GUID_HUPR_ADAPTIVE_AWAY_DISPLAY_TIMEOUTTest()
    {
        Assert.That(
            GUID_HUPR_ADAPTIVE_AWAY_DISPLAY_TIMEOUT,
            Is.EqualTo(
                new Guid(0x0A7D6AB6, 0xAC83, 0x4AD1, 0x82, 0x82, 0xEC, 0xA5, 0xB5, 0x83, 0x08, 0xF3)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_HUPR_ADAPTIVE_INATTENTIVE_DIM_TIMEOUT"/> property is correct.</summary>

    [Test]
    public static void GUID_HUPR_ADAPTIVE_INATTENTIVE_DIM_TIMEOUTTest()
    {
        Assert.That(
            GUID_HUPR_ADAPTIVE_INATTENTIVE_DIM_TIMEOUT,
            Is.EqualTo(
                new Guid(0xCF8C6097, 0x12B8, 0x4279, 0xBB, 0xDD, 0x44, 0x60, 0x1E, 0xE5, 0x20, 0x9D)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_HUPR_ADAPTIVE_INATTENTIVE_DISPLAY_TIMEOUT"/> property is correct.</summary>

    [Test]
    public static void GUID_HUPR_ADAPTIVE_INATTENTIVE_DISPLAY_TIMEOUTTest()
    {
        Assert.That(
            GUID_HUPR_ADAPTIVE_INATTENTIVE_DISPLAY_TIMEOUT,
            Is.EqualTo(
                new Guid(0xEE16691E, 0x6AB3, 0x4619, 0xBB, 0x48, 0x1C, 0x77, 0xC9, 0x35, 0x7E, 0x5A)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_HUPR_ADAPTIVE_AWAY_DIM_TIMEOUT"/> property is correct.</summary>

    [Test]
    public static void GUID_HUPR_ADAPTIVE_AWAY_DIM_TIMEOUTTest()
    {
        Assert.That(
            GUID_HUPR_ADAPTIVE_AWAY_DIM_TIMEOUT,
            Is.EqualTo(
                new Guid(0xA79C8E0E, 0xF271, 0x482D, 0x8F, 0x8A, 0x5D, 0xB9, 0xA1, 0x83, 0x12, 0xDE)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_ALLOW_STANDBY_STATES"/> property is correct.</summary>

    [Test]
    public static void GUID_ALLOW_STANDBY_STATESTest()
    {
        Assert.That(
            GUID_ALLOW_STANDBY_STATES,
            Is.EqualTo(
                new Guid(0xabfc2519, 0x3608, 0x4c2a, 0x94, 0xea, 0x17, 0x1b, 0x0e, 0xd5, 0x46, 0xab)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_ALLOW_RTC_WAKE"/> property is correct.</summary>

    [Test]
    public static void GUID_ALLOW_RTC_WAKETest()
    {
        Assert.That(
            GUID_ALLOW_RTC_WAKE,
            Is.EqualTo(
                new Guid(0xBD3B718A, 0x0680, 0x4D9D, 0x8A, 0xB2, 0xE1, 0xD2, 0xB4, 0xAC, 0x80, 0x6D)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_LEGACY_RTC_MITIGATION"/> property is correct.</summary>

    [Test]
    public static void GUID_LEGACY_RTC_MITIGATIONTest()
    {
        Assert.That(
            GUID_LEGACY_RTC_MITIGATION,
            Is.EqualTo(
                new Guid(0x1A34BDC3, 0x7E6B, 0x442E, 0xA9, 0xD0, 0x64, 0xB6, 0xEF, 0x37, 0x8E, 0x84)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_ALLOW_SYSTEM_REQUIRED"/> property is correct.</summary>

    [Test]
    public static void GUID_ALLOW_SYSTEM_REQUIREDTest()
    {
        Assert.That(
            GUID_ALLOW_SYSTEM_REQUIRED,
            Is.EqualTo(
                new Guid(0xA4B195F5, 0x8225, 0x47D8, 0x80, 0x12, 0x9D, 0x41, 0x36, 0x97, 0x86, 0xE2)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_POWER_SAVING_STATUS"/> property is correct.</summary>

    [Test]
    public static void GUID_POWER_SAVING_STATUSTest()
    {
        Assert.That(
            GUID_POWER_SAVING_STATUS,
            Is.EqualTo(
                new Guid(0xe00958c0, 0xc213, 0x4ace, 0xac, 0x77, 0xfe, 0xcc, 0xed, 0x2e, 0xee, 0xa5)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_ENERGY_SAVER_STATUS"/> property is correct.</summary>

    [Test]
    public static void GUID_ENERGY_SAVER_STATUSTest()
    {
        Assert.That(
            GUID_ENERGY_SAVER_STATUS,
            Is.EqualTo(
                new Guid(0x550e8400, 0xe29b, 0x41d4, 0xa7, 0x16, 0x44, 0x66, 0x55, 0x44, 0x00, 0x00)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_ENERGY_SAVER_SUBGROUP"/> property is correct.</summary>

    [Test]
    public static void GUID_ENERGY_SAVER_SUBGROUPTest()
    {
        Assert.That(
            GUID_ENERGY_SAVER_SUBGROUP,
            Is.EqualTo(
                new Guid(0xDE830923, 0xA562, 0x41AF, 0xA0, 0x86, 0xE3, 0xA2, 0xC6, 0xBA, 0xD2, 0xDA)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_ENERGY_SAVER_BATTERY_THRESHOLD"/> property is correct.</summary>

    [Test]
    public static void GUID_ENERGY_SAVER_BATTERY_THRESHOLDTest()
    {
        Assert.That(
            GUID_ENERGY_SAVER_BATTERY_THRESHOLD,
            Is.EqualTo(
                new Guid(0xE69653CA, 0xCF7F, 0x4F05, 0xAA, 0x73, 0xCB, 0x83, 0x3F, 0xA9, 0x0A, 0xD4)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_ENERGY_SAVER_BRIGHTNESS"/> property is correct.</summary>

    [Test]
    public static void GUID_ENERGY_SAVER_BRIGHTNESSTest()
    {
        Assert.That(
            GUID_ENERGY_SAVER_BRIGHTNESS,
            Is.EqualTo(
                new Guid(0x13D09884, 0xF74E, 0x474A, 0xA8, 0x52, 0xB6, 0xBD, 0xE8, 0xAD, 0x03, 0xA8)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_ENERGY_SAVER_POLICY"/> property is correct.</summary>

    [Test]
    public static void GUID_ENERGY_SAVER_POLICYTest()
    {
        Assert.That(
            GUID_ENERGY_SAVER_POLICY,
            Is.EqualTo(
                new Guid(0x5c5bb349, 0xad29, 0x4ee2, 0x9d, 0xb, 0x2b, 0x25, 0x27, 0xf, 0x7a, 0x81)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_SYSTEM_BUTTON_SUBGROUP"/> property is correct.</summary>

    [Test]
    public static void GUID_SYSTEM_BUTTON_SUBGROUPTest()
    {
        Assert.That(
            GUID_SYSTEM_BUTTON_SUBGROUP,
            Is.EqualTo(
                new Guid(0x4F971E89, 0xEEBD, 0x4455, 0xA8, 0xDE, 0x9E, 0x59, 0x04, 0x0E, 0x73, 0x47)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_POWERBUTTON_ACTION"/> property is correct.</summary>

    [Test]
    public static void GUID_POWERBUTTON_ACTIONTest()
    {
        Assert.That(
            GUID_POWERBUTTON_ACTION,
            Is.EqualTo(
                new Guid(0x7648EFA3, 0xDD9C, 0x4E3E, 0xB5, 0x66, 0x50, 0xF9, 0x29, 0x38, 0x62, 0x80)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_SLEEPBUTTON_ACTION"/> property is correct.</summary>

    [Test]
    public static void GUID_SLEEPBUTTON_ACTIONTest()
    {
        Assert.That(
            GUID_SLEEPBUTTON_ACTION,
            Is.EqualTo(
                new Guid(0x96996BC0, 0xAD50, 0x47EC, 0x92, 0x3B, 0x6F, 0x41, 0x87, 0x4D, 0xD9, 0xEB)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_USERINTERFACEBUTTON_ACTION"/> property is correct.</summary>

    [Test]
    public static void GUID_USERINTERFACEBUTTON_ACTIONTest()
    {
        Assert.That(
            GUID_USERINTERFACEBUTTON_ACTION,
            Is.EqualTo(
                new Guid(0xA7066653, 0x8D6C, 0x40A8, 0x91, 0x0E, 0xA1, 0xF5, 0x4B, 0x84, 0xC7, 0xE5)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_LIDCLOSE_ACTION"/> property is correct.</summary>

    [Test]
    public static void GUID_LIDCLOSE_ACTIONTest()
    {
        Assert.That(
            GUID_LIDCLOSE_ACTION,
            Is.EqualTo(
                new Guid(0x5CA83367, 0x6E45, 0x459F, 0xA2, 0x7B, 0x47, 0x6B, 0x1D, 0x01, 0xC9, 0x36)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_LIDOPEN_POWERSTATE"/> property is correct.</summary>

    [Test]
    public static void GUID_LIDOPEN_POWERSTATETest()
    {
        Assert.That(
            GUID_LIDOPEN_POWERSTATE,
            Is.EqualTo(
                new Guid(0x99FF10E7, 0x23B1, 0x4C07, 0xA9, 0xD1, 0x5C, 0x32, 0x06, 0xD7, 0x41, 0xB4)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_BATTERY_SUBGROUP"/> property is correct.</summary>

    [Test]
    public static void GUID_BATTERY_SUBGROUPTest()
    {
        Assert.That(
            GUID_BATTERY_SUBGROUP,
            Is.EqualTo(
                new Guid(0xE73A048D, 0xBF27, 0x4F12, 0x97, 0x31, 0x8B, 0x20, 0x76, 0xE8, 0x89, 0x1F)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_BATTERY_DISCHARGE_ACTION_0"/> property is correct.</summary>

    [Test]
    public static void GUID_BATTERY_DISCHARGE_ACTION_0Test()
    {
        Assert.That(
            GUID_BATTERY_DISCHARGE_ACTION_0,
            Is.EqualTo(
                new Guid(0x637EA02F, 0xBBCB, 0x4015, 0x8E, 0x2C, 0xA1, 0xC7, 0xB9, 0xC0, 0xB5, 0x46)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_BATTERY_DISCHARGE_LEVEL_0"/> property is correct.</summary>

    [Test]
    public static void GUID_BATTERY_DISCHARGE_LEVEL_0Test()
    {
        Assert.That(
            GUID_BATTERY_DISCHARGE_LEVEL_0,
            Is.EqualTo(
                new Guid(0x9A66D8D7, 0x4FF7, 0x4EF9, 0xB5, 0xA2, 0x5A, 0x32, 0x6C, 0xA2, 0xA4, 0x69)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_BATTERY_DISCHARGE_FLAGS_0"/> property is correct.</summary>

    [Test]
    public static void GUID_BATTERY_DISCHARGE_FLAGS_0Test()
    {
        Assert.That(
            GUID_BATTERY_DISCHARGE_FLAGS_0,
            Is.EqualTo(
                new Guid(0x5dbb7c9f, 0x38e9, 0x40d2, 0x97, 0x49, 0x4f, 0x8a, 0x0e, 0x9f, 0x64, 0x0f)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_BATTERY_DISCHARGE_ACTION_1"/> property is correct.</summary>

    [Test]
    public static void GUID_BATTERY_DISCHARGE_ACTION_1Test()
    {
        Assert.That(
            GUID_BATTERY_DISCHARGE_ACTION_1,
            Is.EqualTo(
                new Guid(0xD8742DCB, 0x3E6A, 0x4B3C, 0xB3, 0xFE, 0x37, 0x46, 0x23, 0xCD, 0xCF, 0x06)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_BATTERY_DISCHARGE_LEVEL_1"/> property is correct.</summary>

    [Test]
    public static void GUID_BATTERY_DISCHARGE_LEVEL_1Test()
    {
        Assert.That(
            GUID_BATTERY_DISCHARGE_LEVEL_1,
            Is.EqualTo(
                new Guid(0x8183BA9A, 0xE910, 0x48DA, 0x87, 0x69, 0x14, 0xAE, 0x6D, 0xC1, 0x17, 0x0A)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_BATTERY_DISCHARGE_FLAGS_1"/> property is correct.</summary>

    [Test]
    public static void GUID_BATTERY_DISCHARGE_FLAGS_1Test()
    {
        Assert.That(
            GUID_BATTERY_DISCHARGE_FLAGS_1,
            Is.EqualTo(
                new Guid(0xbcded951, 0x187b, 0x4d05, 0xbc, 0xcc, 0xf7, 0xe5, 0x19, 0x60, 0xc2, 0x58)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_BATTERY_DISCHARGE_ACTION_2"/> property is correct.</summary>

    [Test]
    public static void GUID_BATTERY_DISCHARGE_ACTION_2Test()
    {
        Assert.That(
            GUID_BATTERY_DISCHARGE_ACTION_2,
            Is.EqualTo(
                new Guid(0x421CBA38, 0x1A8E, 0x4881, 0xAC, 0x89, 0xE3, 0x3A, 0x8B, 0x04, 0xEC, 0xE4)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_BATTERY_DISCHARGE_LEVEL_2"/> property is correct.</summary>

    [Test]
    public static void GUID_BATTERY_DISCHARGE_LEVEL_2Test()
    {
        Assert.That(
            GUID_BATTERY_DISCHARGE_LEVEL_2,
            Is.EqualTo(
                new Guid(0x07A07CA2, 0xADAF, 0x40D7, 0xB0, 0x77, 0x53, 0x3A, 0xAD, 0xED, 0x1B, 0xFA)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_BATTERY_DISCHARGE_FLAGS_2"/> property is correct.</summary>

    [Test]
    public static void GUID_BATTERY_DISCHARGE_FLAGS_2Test()
    {
        Assert.That(
            GUID_BATTERY_DISCHARGE_FLAGS_2,
            Is.EqualTo(
                new Guid(0x7fd2f0c4, 0xfeb7, 0x4da3, 0x81, 0x17, 0xe3, 0xfb, 0xed, 0xc4, 0x65, 0x82)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_BATTERY_DISCHARGE_ACTION_3"/> property is correct.</summary>

    [Test]
    public static void GUID_BATTERY_DISCHARGE_ACTION_3Test()
    {
        Assert.That(
            GUID_BATTERY_DISCHARGE_ACTION_3,
            Is.EqualTo(
                new Guid(0x80472613, 0x9780, 0x455E, 0xB3, 0x08, 0x72, 0xD3, 0x00, 0x3C, 0xF2, 0xF8)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_BATTERY_DISCHARGE_LEVEL_3"/> property is correct.</summary>

    [Test]
    public static void GUID_BATTERY_DISCHARGE_LEVEL_3Test()
    {
        Assert.That(
            GUID_BATTERY_DISCHARGE_LEVEL_3,
            Is.EqualTo(
                new Guid(0x58AFD5A6, 0xC2DD, 0x47D2, 0x9F, 0xBF, 0xEF, 0x70, 0xCC, 0x5C, 0x59, 0x65)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_BATTERY_DISCHARGE_FLAGS_3"/> property is correct.</summary>

    [Test]
    public static void GUID_BATTERY_DISCHARGE_FLAGS_3Test()
    {
        Assert.That(
            GUID_BATTERY_DISCHARGE_FLAGS_3,
            Is.EqualTo(
                new Guid(0x73613ccf, 0xdbfa, 0x4279, 0x83, 0x56, 0x49, 0x35, 0xf6, 0xbf, 0x62, 0xf3)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_SETTINGS_SUBGROUP"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_SETTINGS_SUBGROUPTest()
    {
        Assert.That(
            GUID_PROCESSOR_SETTINGS_SUBGROUP,
            Is.EqualTo(
                new Guid(0x54533251, 0x82BE, 0x4824, 0x96, 0xC1, 0x47, 0xB6, 0x0B, 0x74, 0x0D, 0x00)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_THROTTLE_POLICY"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_THROTTLE_POLICYTest()
    {
        Assert.That(
            GUID_PROCESSOR_THROTTLE_POLICY,
            Is.EqualTo(
                new Guid(0x57027304, 0x4AF6, 0x4104, 0x92, 0x60, 0xE3, 0xD9, 0x52, 0x48, 0xFC, 0x36)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_THROTTLE_MAXIMUM"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_THROTTLE_MAXIMUMTest()
    {
        Assert.That(
            GUID_PROCESSOR_THROTTLE_MAXIMUM,
            Is.EqualTo(
                new Guid(0xBC5038F7, 0x23E0, 0x4960, 0x96, 0xDA, 0x33, 0xAB, 0xAF, 0x59, 0x35, 0xEC)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_THROTTLE_MAXIMUM_1"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_THROTTLE_MAXIMUM_1Test()
    {
        Assert.That(
            GUID_PROCESSOR_THROTTLE_MAXIMUM_1,
            Is.EqualTo(
                new Guid(0xBC5038F7, 0x23E0, 0x4960, 0x96, 0xDA, 0x33, 0xAB, 0xAF, 0x59, 0x35, 0xED)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_THROTTLE_MINIMUM"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_THROTTLE_MINIMUMTest()
    {
        Assert.That(
            GUID_PROCESSOR_THROTTLE_MINIMUM,
            Is.EqualTo(
                new Guid(0x893DEE8E, 0x2BEF, 0x41E0, 0x89, 0xC6, 0xB5, 0x5D, 0x09, 0x29, 0x96, 0x4C)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_THROTTLE_MINIMUM_1"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_THROTTLE_MINIMUM_1Test()
    {
        Assert.That(
            GUID_PROCESSOR_THROTTLE_MINIMUM_1,
            Is.EqualTo(
                new Guid(0x893DEE8E, 0x2BEF, 0x41E0, 0x89, 0xC6, 0xB5, 0x5D, 0x09, 0x29, 0x96, 0x4D)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_FREQUENCY_LIMIT"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_FREQUENCY_LIMITTest()
    {
        Assert.That(
            GUID_PROCESSOR_FREQUENCY_LIMIT,
            Is.EqualTo(
                new Guid(0x75b0ae3f, 0xbce0, 0x45a7, 0x8c, 0x89, 0xc9, 0x61, 0x1c, 0x25, 0xe1, 0x00)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_FREQUENCY_LIMIT_1"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_FREQUENCY_LIMIT_1Test()
    {
        Assert.That(
            GUID_PROCESSOR_FREQUENCY_LIMIT_1,
            Is.EqualTo(
                new Guid(0x75b0ae3f, 0xbce0, 0x45a7, 0x8c, 0x89, 0xc9, 0x61, 0x1c, 0x25, 0xe1, 0x01)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_ALLOW_THROTTLING"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_ALLOW_THROTTLINGTest()
    {
        Assert.That(
            GUID_PROCESSOR_ALLOW_THROTTLING,
            Is.EqualTo(
                new Guid(0x3b04d4fd, 0x1cc7, 0x4f23, 0xab, 0x1c, 0xd1, 0x33, 0x78, 0x19, 0xc4, 0xbb)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_IDLESTATE_POLICY"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_IDLESTATE_POLICYTest()
    {
        Assert.That(
            GUID_PROCESSOR_IDLESTATE_POLICY,
            Is.EqualTo(
                new Guid(0x68f262a7, 0xf621, 0x4069, 0xb9, 0xa5, 0x48, 0x74, 0x16, 0x9b, 0xe2, 0x3c)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PERFSTATE_POLICY"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PERFSTATE_POLICYTest()
    {
        Assert.That(
            GUID_PROCESSOR_PERFSTATE_POLICY,
            Is.EqualTo(
                new Guid(0xBBDC3814, 0x18E9, 0x4463, 0x8A, 0x55, 0xD1, 0x97, 0x32, 0x7C, 0x45, 0xC0)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PERF_INCREASE_THRESHOLD"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PERF_INCREASE_THRESHOLDTest()
    {
        Assert.That(
            GUID_PROCESSOR_PERF_INCREASE_THRESHOLD,
            Is.EqualTo(
                new Guid(0x06cadf0e, 0x64ed, 0x448a, 0x89, 0x27, 0xce, 0x7b, 0xf9, 0x0e, 0xb3, 0x5d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PERF_INCREASE_THRESHOLD_1"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PERF_INCREASE_THRESHOLD_1Test()
    {
        Assert.That(
            GUID_PROCESSOR_PERF_INCREASE_THRESHOLD_1,
            Is.EqualTo(
                new Guid(0x06cadf0e, 0x64ed, 0x448a, 0x89, 0x27, 0xce, 0x7b, 0xf9, 0x0e, 0xb3, 0x5e)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PERF_DECREASE_THRESHOLD"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PERF_DECREASE_THRESHOLDTest()
    {
        Assert.That(
            GUID_PROCESSOR_PERF_DECREASE_THRESHOLD,
            Is.EqualTo(
                new Guid(0x12a0ab44, 0xfe28, 0x4fa9, 0xb3, 0xbd, 0x4b, 0x64, 0xf4, 0x49, 0x60, 0xa6)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PERF_DECREASE_THRESHOLD_1"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PERF_DECREASE_THRESHOLD_1Test()
    {
        Assert.That(
            GUID_PROCESSOR_PERF_DECREASE_THRESHOLD_1,
            Is.EqualTo(
                new Guid(0x12a0ab44, 0xfe28, 0x4fa9, 0xb3, 0xbd, 0x4b, 0x64, 0xf4, 0x49, 0x60, 0xa7)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PERF_INCREASE_POLICY"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PERF_INCREASE_POLICYTest()
    {
        Assert.That(
            GUID_PROCESSOR_PERF_INCREASE_POLICY,
            Is.EqualTo(
                new Guid(0x465e1f50, 0xb610, 0x473a, 0xab, 0x58, 0x0, 0xd1, 0x7, 0x7d, 0xc4, 0x18)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PERF_INCREASE_POLICY_1"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PERF_INCREASE_POLICY_1Test()
    {
        Assert.That(
            GUID_PROCESSOR_PERF_INCREASE_POLICY_1,
            Is.EqualTo(
                new Guid(0x465e1f50, 0xb610, 0x473a, 0xab, 0x58, 0x0, 0xd1, 0x7, 0x7d, 0xc4, 0x19)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PERF_DECREASE_POLICY"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PERF_DECREASE_POLICYTest()
    {
        Assert.That(
            GUID_PROCESSOR_PERF_DECREASE_POLICY,
            Is.EqualTo(
                new Guid(0x40fbefc7, 0x2e9d, 0x4d25, 0xa1, 0x85, 0xc, 0xfd, 0x85, 0x74, 0xba, 0xc6)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PERF_DECREASE_POLICY_1"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PERF_DECREASE_POLICY_1Test()
    {
        Assert.That(
            GUID_PROCESSOR_PERF_DECREASE_POLICY_1,
            Is.EqualTo(
                new Guid(0x40fbefc7, 0x2e9d, 0x4d25, 0xa1, 0x85, 0xc, 0xfd, 0x85, 0x74, 0xba, 0xc7)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PERF_INCREASE_TIME"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PERF_INCREASE_TIMETest()
    {
        Assert.That(
            GUID_PROCESSOR_PERF_INCREASE_TIME,
            Is.EqualTo(
                new Guid(0x984cf492, 0x3bed, 0x4488, 0xa8, 0xf9, 0x42, 0x86, 0xc9, 0x7b, 0xf5, 0xaa)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PERF_INCREASE_TIME_1"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PERF_INCREASE_TIME_1Test()
    {
        Assert.That(
            GUID_PROCESSOR_PERF_INCREASE_TIME_1,
            Is.EqualTo(
                new Guid(0x984cf492, 0x3bed, 0x4488, 0xa8, 0xf9, 0x42, 0x86, 0xc9, 0x7b, 0xf5, 0xab)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PERF_DECREASE_TIME"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PERF_DECREASE_TIMETest()
    {
        Assert.That(
            GUID_PROCESSOR_PERF_DECREASE_TIME,
            Is.EqualTo(
                new Guid(0xd8edeb9b, 0x95cf, 0x4f95, 0xa7, 0x3c, 0xb0, 0x61, 0x97, 0x36, 0x93, 0xc8)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PERF_DECREASE_TIME_1"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PERF_DECREASE_TIME_1Test()
    {
        Assert.That(
            GUID_PROCESSOR_PERF_DECREASE_TIME_1,
            Is.EqualTo(
                new Guid(0xd8edeb9b, 0x95cf, 0x4f95, 0xa7, 0x3c, 0xb0, 0x61, 0x97, 0x36, 0x93, 0xc9)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PERF_TIME_CHECK"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PERF_TIME_CHECKTest()
    {
        Assert.That(
            GUID_PROCESSOR_PERF_TIME_CHECK,
            Is.EqualTo(
                new Guid(0x4d2b0152, 0x7d5c, 0x498b, 0x88, 0xe2, 0x34, 0x34, 0x53, 0x92, 0xa2, 0xc5)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PERF_BOOST_POLICY"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PERF_BOOST_POLICYTest()
    {
        Assert.That(
            GUID_PROCESSOR_PERF_BOOST_POLICY,
            Is.EqualTo(
                new Guid(0x45bcc044, 0xd885, 0x43e2, 0x86, 0x5, 0xee, 0xe, 0xc6, 0xe9, 0x6b, 0x59)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PERF_BOOST_MODE"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PERF_BOOST_MODETest()
    {
        Assert.That(
            GUID_PROCESSOR_PERF_BOOST_MODE,
            Is.EqualTo(
                new Guid(0xbe337238, 0xd82, 0x4146, 0xa9, 0x60, 0x4f, 0x37, 0x49, 0xd4, 0x70, 0xc7)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PERF_AUTONOMOUS_MODE"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PERF_AUTONOMOUS_MODETest()
    {
        Assert.That(
            GUID_PROCESSOR_PERF_AUTONOMOUS_MODE,
            Is.EqualTo(
                new Guid(0x8baa4a8a, 0x14c6, 0x4451, 0x8e, 0x8b, 0x14, 0xbd, 0xbd, 0x19, 0x75, 0x37)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PERF_ENERGY_PERFORMANCE_PREFERENCE"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PERF_ENERGY_PERFORMANCE_PREFERENCETest()
    {
        Assert.That(
            GUID_PROCESSOR_PERF_ENERGY_PERFORMANCE_PREFERENCE,
            Is.EqualTo(
                new Guid(0x36687f9e, 0xe3a5, 0x4dbf, 0xb1, 0xdc, 0x15, 0xeb, 0x38, 0x1c, 0x68, 0x63)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PERF_ENERGY_PERFORMANCE_PREFERENCE_1"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PERF_ENERGY_PERFORMANCE_PREFERENCE_1Test()
    {
        Assert.That(
            GUID_PROCESSOR_PERF_ENERGY_PERFORMANCE_PREFERENCE_1,
            Is.EqualTo(
                new Guid(0x36687f9e, 0xe3a5, 0x4dbf, 0xb1, 0xdc, 0x15, 0xeb, 0x38, 0x1c, 0x68, 0x64)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PERF_AUTONOMOUS_ACTIVITY_WINDOW"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PERF_AUTONOMOUS_ACTIVITY_WINDOWTest()
    {
        Assert.That(
            GUID_PROCESSOR_PERF_AUTONOMOUS_ACTIVITY_WINDOW,
            Is.EqualTo(
                new Guid(0xcfeda3d0, 0x7697, 0x4566, 0xa9, 0x22, 0xa9, 0x8, 0x6c, 0xd4, 0x9d, 0xfa)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_DUTY_CYCLING"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_DUTY_CYCLINGTest()
    {
        Assert.That(
            GUID_PROCESSOR_DUTY_CYCLING,
            Is.EqualTo(
                new Guid(0x4e4450b3, 0x6179, 0x4e91, 0xb8, 0xf1, 0x5b, 0xb9, 0x93, 0x8f, 0x81, 0xa1)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_IDLE_ALLOW_SCALING"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_IDLE_ALLOW_SCALINGTest()
    {
        Assert.That(
            GUID_PROCESSOR_IDLE_ALLOW_SCALING,
            Is.EqualTo(
                new Guid(0x6c2993b0, 0x8f48, 0x481f, 0xbc, 0xc6, 0x0, 0xdd, 0x27, 0x42, 0xaa, 0x6)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_IDLE_DISABLE"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_IDLE_DISABLETest()
    {
        Assert.That(
            GUID_PROCESSOR_IDLE_DISABLE,
            Is.EqualTo(
                new Guid(0x5d76a2ca, 0xe8c0, 0x402f, 0xa1, 0x33, 0x21, 0x58, 0x49, 0x2d, 0x58, 0xad)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_IDLE_STATE_MAXIMUM"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_IDLE_STATE_MAXIMUMTest()
    {
        Assert.That(
            GUID_PROCESSOR_IDLE_STATE_MAXIMUM,
            Is.EqualTo(
                new Guid(0x9943e905, 0x9a30, 0x4ec1, 0x9b, 0x99, 0x44, 0xdd, 0x3b, 0x76, 0xf7, 0xa2)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_IDLE_TIME_CHECK"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_IDLE_TIME_CHECKTest()
    {
        Assert.That(
            GUID_PROCESSOR_IDLE_TIME_CHECK,
            Is.EqualTo(
                new Guid(0xc4581c31, 0x89ab, 0x4597, 0x8e, 0x2b, 0x9c, 0x9c, 0xab, 0x44, 0xe, 0x6b)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_IDLE_DEMOTE_THRESHOLD"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_IDLE_DEMOTE_THRESHOLDTest()
    {
        Assert.That(
            GUID_PROCESSOR_IDLE_DEMOTE_THRESHOLD,
            Is.EqualTo(
                new Guid(0x4b92d758, 0x5a24, 0x4851, 0xa4, 0x70, 0x81, 0x5d, 0x78, 0xae, 0xe1, 0x19)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_IDLE_PROMOTE_THRESHOLD"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_IDLE_PROMOTE_THRESHOLDTest()
    {
        Assert.That(
            GUID_PROCESSOR_IDLE_PROMOTE_THRESHOLD,
            Is.EqualTo(
                new Guid(0x7b224883, 0xb3cc, 0x4d79, 0x81, 0x9f, 0x83, 0x74, 0x15, 0x2c, 0xbe, 0x7c)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_CORE_PARKING_INCREASE_THRESHOLD"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_CORE_PARKING_INCREASE_THRESHOLDTest()
    {
        Assert.That(
            GUID_PROCESSOR_CORE_PARKING_INCREASE_THRESHOLD,
            Is.EqualTo(
                new Guid(0xdf142941, 0x20f3, 0x4edf, 0x9a, 0x4a, 0x9c, 0x83, 0xd3, 0xd7, 0x17, 0xd1)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_CORE_PARKING_DECREASE_THRESHOLD"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_CORE_PARKING_DECREASE_THRESHOLDTest()
    {
        Assert.That(
            GUID_PROCESSOR_CORE_PARKING_DECREASE_THRESHOLD,
            Is.EqualTo(
                new Guid(0x68dd2f27, 0xa4ce, 0x4e11, 0x84, 0x87, 0x37, 0x94, 0xe4, 0x13, 0x5d, 0xfa)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_CORE_PARKING_INCREASE_POLICY"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_CORE_PARKING_INCREASE_POLICYTest()
    {
        Assert.That(
            GUID_PROCESSOR_CORE_PARKING_INCREASE_POLICY,
            Is.EqualTo(
                new Guid(0xc7be0679, 0x2817, 0x4d69, 0x9d, 0x02, 0x51, 0x9a, 0x53, 0x7e, 0xd0, 0xc6)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_CORE_PARKING_DECREASE_POLICY"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_CORE_PARKING_DECREASE_POLICYTest()
    {
        Assert.That(
            GUID_PROCESSOR_CORE_PARKING_DECREASE_POLICY,
            Is.EqualTo(
                new Guid(0x71021b41, 0xc749, 0x4d21, 0xbe, 0x74, 0xa0, 0x0f, 0x33, 0x5d, 0x58, 0x2b)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_CORE_PARKING_MAX_CORES"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_CORE_PARKING_MAX_CORESTest()
    {
        Assert.That(
            GUID_PROCESSOR_CORE_PARKING_MAX_CORES,
            Is.EqualTo(
                new Guid(0xea062031, 0x0e34, 0x4ff1, 0x9b, 0x6d, 0xeb, 0x10, 0x59, 0x33, 0x40, 0x28)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_CORE_PARKING_MAX_CORES_1"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_CORE_PARKING_MAX_CORES_1Test()
    {
        Assert.That(
            GUID_PROCESSOR_CORE_PARKING_MAX_CORES_1,
            Is.EqualTo(
                new Guid(0xea062031, 0x0e34, 0x4ff1, 0x9b, 0x6d, 0xeb, 0x10, 0x59, 0x33, 0x40, 0x29)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_CORE_PARKING_MIN_CORES"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_CORE_PARKING_MIN_CORESTest()
    {
        Assert.That(
            GUID_PROCESSOR_CORE_PARKING_MIN_CORES,
            Is.EqualTo(
                new Guid(0x0cc5b647, 0xc1df, 0x4637, 0x89, 0x1a, 0xde, 0xc3, 0x5c, 0x31, 0x85, 0x83)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_CORE_PARKING_MIN_CORES_1"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_CORE_PARKING_MIN_CORES_1Test()
    {
        Assert.That(
            GUID_PROCESSOR_CORE_PARKING_MIN_CORES_1,
            Is.EqualTo(
                new Guid(0x0cc5b647, 0xc1df, 0x4637, 0x89, 0x1a, 0xde, 0xc3, 0x5c, 0x31, 0x85, 0x84)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_CORE_PARKING_INCREASE_TIME"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_CORE_PARKING_INCREASE_TIMETest()
    {
        Assert.That(
            GUID_PROCESSOR_CORE_PARKING_INCREASE_TIME,
            Is.EqualTo(
                new Guid(0x2ddd5a84, 0x5a71, 0x437e, 0x91, 0x2a, 0xdb, 0x0b, 0x8c, 0x78, 0x87, 0x32)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_CORE_PARKING_DECREASE_TIME"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_CORE_PARKING_DECREASE_TIMETest()
    {
        Assert.That(
            GUID_PROCESSOR_CORE_PARKING_DECREASE_TIME,
            Is.EqualTo(
                new Guid(0xdfd10d17, 0xd5eb, 0x45dd, 0x87, 0x7a, 0x9a, 0x34, 0xdd, 0xd1, 0x5c, 0x82)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_CORE_PARKING_AFFINITY_HISTORY_DECREASE_FACTOR"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_CORE_PARKING_AFFINITY_HISTORY_DECREASE_FACTORTest()
    {
        Assert.That(
            GUID_PROCESSOR_CORE_PARKING_AFFINITY_HISTORY_DECREASE_FACTOR,
            Is.EqualTo(
                new Guid(0x8f7b45e3, 0xc393, 0x480a, 0x87, 0x8c, 0xf6, 0x7a, 0xc3, 0xd0, 0x70, 0x82)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_CORE_PARKING_AFFINITY_HISTORY_THRESHOLD"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_CORE_PARKING_AFFINITY_HISTORY_THRESHOLDTest()
    {
        Assert.That(
            GUID_PROCESSOR_CORE_PARKING_AFFINITY_HISTORY_THRESHOLD,
            Is.EqualTo(
                new Guid(0x5b33697b, 0xe89d, 0x4d38, 0xaa, 0x46, 0x9e, 0x7d, 0xfb, 0x7c, 0xd2, 0xf9)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_CORE_PARKING_AFFINITY_WEIGHTING"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_CORE_PARKING_AFFINITY_WEIGHTINGTest()
    {
        Assert.That(
            GUID_PROCESSOR_CORE_PARKING_AFFINITY_WEIGHTING,
            Is.EqualTo(
                new Guid(0xe70867f1, 0xfa2f, 0x4f4e, 0xae, 0xa1, 0x4d, 0x8a, 0x0b, 0xa2, 0x3b, 0x20)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_HISTORY_DECREASE_FACTOR"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_HISTORY_DECREASE_FACTORTest()
    {
        Assert.That(
            GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_HISTORY_DECREASE_FACTOR,
            Is.EqualTo(
                new Guid(0x1299023c, 0xbc28, 0x4f0a, 0x81, 0xec, 0xd3, 0x29, 0x5a, 0x8d, 0x81, 0x5d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_HISTORY_THRESHOLD"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_HISTORY_THRESHOLDTest()
    {
        Assert.That(
            GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_HISTORY_THRESHOLD,
            Is.EqualTo(
                new Guid(0x9ac18e92, 0xaa3c, 0x4e27, 0xb3, 0x07, 0x01, 0xae, 0x37, 0x30, 0x71, 0x29)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_WEIGHTING"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_WEIGHTINGTest()
    {
        Assert.That(
            GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_WEIGHTING,
            Is.EqualTo(
                new Guid(0x8809c2d8, 0xb155, 0x42d4, 0xbc, 0xda, 0x0d, 0x34, 0x56, 0x51, 0xb1, 0xdb)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_THRESHOLD"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_THRESHOLDTest()
    {
        Assert.That(
            GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_THRESHOLD,
            Is.EqualTo(
                new Guid(0x943c8cb6, 0x6f93, 0x4227, 0xad, 0x87, 0xe9, 0xa3, 0xfe, 0xec, 0x08, 0xd1)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PARKING_CORE_OVERRIDE"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PARKING_CORE_OVERRIDETest()
    {
        Assert.That(
            GUID_PROCESSOR_PARKING_CORE_OVERRIDE,
            Is.EqualTo(
                new Guid(0xa55612aa, 0xf624, 0x42c6, 0xa4, 0x43, 0x73, 0x97, 0xd0, 0x64, 0xc0, 0x4f)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PARKING_PERF_STATE"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PARKING_PERF_STATETest()
    {
        Assert.That(
            GUID_PROCESSOR_PARKING_PERF_STATE,
            Is.EqualTo(
                new Guid(0x447235c7, 0x6a8d, 0x4cc0, 0x8e, 0x24, 0x9e, 0xaf, 0x70, 0xb9, 0x6e, 0x2b)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PARKING_PERF_STATE_1"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PARKING_PERF_STATE_1Test()
    {
        Assert.That(
            GUID_PROCESSOR_PARKING_PERF_STATE_1,
            Is.EqualTo(
                new Guid(0x447235c7, 0x6a8d, 0x4cc0, 0x8e, 0x24, 0x9e, 0xaf, 0x70, 0xb9, 0x6e, 0x2c)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PARKING_CONCURRENCY_THRESHOLD"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PARKING_CONCURRENCY_THRESHOLDTest()
    {
        Assert.That(
            GUID_PROCESSOR_PARKING_CONCURRENCY_THRESHOLD,
            Is.EqualTo(
                new Guid(0x2430ab6f, 0xa520, 0x44a2, 0x96, 0x01, 0xf7, 0xf2, 0x3b, 0x51, 0x34, 0xb1)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PARKING_HEADROOM_THRESHOLD"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PARKING_HEADROOM_THRESHOLDTest()
    {
        Assert.That(
            GUID_PROCESSOR_PARKING_HEADROOM_THRESHOLD,
            Is.EqualTo(
                new Guid(0xf735a673, 0x2066, 0x4f80, 0xa0, 0xc5, 0xdd, 0xee, 0x0c, 0xf1, 0xbf, 0x5d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PARKING_DISTRIBUTION_THRESHOLD"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PARKING_DISTRIBUTION_THRESHOLDTest()
    {
        Assert.That(
            GUID_PROCESSOR_PARKING_DISTRIBUTION_THRESHOLD,
            Is.EqualTo(
                new Guid(0x4bdaf4e9, 0xd103, 0x46d7, 0xa5, 0xf0, 0x62, 0x80, 0x12, 0x16, 0x16, 0xef)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_SOFT_PARKING_LATENCY"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_SOFT_PARKING_LATENCYTest()
    {
        Assert.That(
            GUID_PROCESSOR_SOFT_PARKING_LATENCY,
            Is.EqualTo(
                new Guid(0x97cfac41, 0x2217, 0x47eb, 0x99, 0x2d, 0x61, 0x8b, 0x19, 0x77, 0xc9, 0x7)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PERF_HISTORY"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PERF_HISTORYTest()
    {
        Assert.That(
            GUID_PROCESSOR_PERF_HISTORY,
            Is.EqualTo(
                new Guid(0x7d24baa7, 0x0b84, 0x480f, 0x84, 0x0c, 0x1b, 0x07, 0x43, 0xc0, 0x0f, 0x5f)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PERF_HISTORY_1"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PERF_HISTORY_1Test()
    {
        Assert.That(
            GUID_PROCESSOR_PERF_HISTORY_1,
            Is.EqualTo(
                new Guid(0x7d24baa7, 0x0b84, 0x480f, 0x84, 0x0c, 0x1b, 0x07, 0x43, 0xc0, 0x0f, 0x60)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PERF_INCREASE_HISTORY"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PERF_INCREASE_HISTORYTest()
    {
        Assert.That(
            GUID_PROCESSOR_PERF_INCREASE_HISTORY,
            Is.EqualTo(
                new Guid(0x99b3ef01, 0x752f, 0x46a1, 0x80, 0xfb, 0x77, 0x30, 0x1, 0x1f, 0x23, 0x54)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PERF_DECREASE_HISTORY"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PERF_DECREASE_HISTORYTest()
    {
        Assert.That(
            GUID_PROCESSOR_PERF_DECREASE_HISTORY,
            Is.EqualTo(
                new Guid(0x300f6f8, 0xabd6, 0x45a9, 0xb7, 0x4f, 0x49, 0x8, 0x69, 0x1a, 0x40, 0xb5)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PERF_CORE_PARKING_HISTORY"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PERF_CORE_PARKING_HISTORYTest()
    {
        Assert.That(
            GUID_PROCESSOR_PERF_CORE_PARKING_HISTORY,
            Is.EqualTo(
                new Guid(0x77d7f282, 0x8f1a, 0x42cd, 0x85, 0x37, 0x45, 0x45, 0xa, 0x83, 0x9b, 0xe8)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PERF_LATENCY_HINT"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PERF_LATENCY_HINTTest()
    {
        Assert.That(
            GUID_PROCESSOR_PERF_LATENCY_HINT,
            Is.EqualTo(
                new Guid(0x0822df31, 0x9c83, 0x441c, 0xa0, 0x79, 0x0d, 0xe4, 0xcf, 0x00, 0x9c, 0x7b)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PERF_LATENCY_HINT_PERF"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PERF_LATENCY_HINT_PERFTest()
    {
        Assert.That(
            GUID_PROCESSOR_PERF_LATENCY_HINT_PERF,
            Is.EqualTo(
                new Guid(0x619b7505, 0x3b, 0x4e82, 0xb7, 0xa6, 0x4d, 0xd2, 0x9c, 0x30, 0x9, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PERF_LATENCY_HINT_PERF_1"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PERF_LATENCY_HINT_PERF_1Test()
    {
        Assert.That(
            GUID_PROCESSOR_PERF_LATENCY_HINT_PERF_1,
            Is.EqualTo(
                new Guid(0x619b7505, 0x3b, 0x4e82, 0xb7, 0xa6, 0x4d, 0xd2, 0x9c, 0x30, 0x9, 0x72)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PERF_LATENCY_HINT_EPP"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PERF_LATENCY_HINT_EPPTest()
    {
        Assert.That(
            GUID_PROCESSOR_PERF_LATENCY_HINT_EPP,
            Is.EqualTo(
                new Guid(0x4b70f900, 0xcdd9, 0x4e66, 0xaa, 0x26, 0xae, 0x84, 0x17, 0xf9, 0x81, 0x73)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_PERF_LATENCY_HINT_EPP_1"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_PERF_LATENCY_HINT_EPP_1Test()
    {
        Assert.That(
            GUID_PROCESSOR_PERF_LATENCY_HINT_EPP_1,
            Is.EqualTo(
                new Guid(0x4b70f900, 0xcdd9, 0x4e66, 0xaa, 0x26, 0xae, 0x84, 0x17, 0xf9, 0x81, 0x74)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_LATENCY_HINT_MIN_UNPARK"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_LATENCY_HINT_MIN_UNPARKTest()
    {
        Assert.That(
            GUID_PROCESSOR_LATENCY_HINT_MIN_UNPARK,
            Is.EqualTo(
                new Guid(0x616cdaa5, 0x695e, 0x4545, 0x97, 0xad, 0x97, 0xdc, 0x2d, 0x1b, 0xdd, 0x88)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_LATENCY_HINT_MIN_UNPARK_1"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_LATENCY_HINT_MIN_UNPARK_1Test()
    {
        Assert.That(
            GUID_PROCESSOR_LATENCY_HINT_MIN_UNPARK_1,
            Is.EqualTo(
                new Guid(0x616cdaa5, 0x695e, 0x4545, 0x97, 0xad, 0x97, 0xdc, 0x2d, 0x1b, 0xdd, 0x89)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_MODULE_PARKING_POLICY"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_MODULE_PARKING_POLICYTest()
    {
        Assert.That(
            GUID_PROCESSOR_MODULE_PARKING_POLICY,
            Is.EqualTo(
                new Guid(0xb0deaf6b, 0x59c0, 0x4523, 0x8a, 0x45, 0xca, 0x7f, 0x40, 0x24, 0x41, 0x14)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_COMPLEX_PARKING_POLICY"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_COMPLEX_PARKING_POLICYTest()
    {
        Assert.That(
            GUID_PROCESSOR_COMPLEX_PARKING_POLICY,
            Is.EqualTo(
                new Guid(0xb669a5e9, 0x7b1d, 0x4132, 0xba, 0xaa, 0x49, 0x19, 0xa, 0xbc, 0xfe, 0xb6)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_SMT_UNPARKING_POLICY"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_SMT_UNPARKING_POLICYTest()
    {
        Assert.That(
            GUID_PROCESSOR_SMT_UNPARKING_POLICY,
            Is.EqualTo(
                new Guid(0xb28a6829, 0xc5f7, 0x444e, 0x8f, 0x61, 0x10, 0xe2, 0x4e, 0x85, 0xc5, 0x32)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_RESTRICTION_COUNT"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_RESTRICTION_COUNTTest()
    {
        Assert.That(
            GUID_PROCESSOR_RESTRICTION_COUNT,
            Is.EqualTo(
                new Guid(0x1a98ad09, 0xaf22, 0x42ca, 0x8e, 0x61, 0xf0, 0xa5, 0x80, 0x2c, 0x27, 0x0a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_DISTRIBUTE_UTILITY"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_DISTRIBUTE_UTILITYTest()
    {
        Assert.That(
            GUID_PROCESSOR_DISTRIBUTE_UTILITY,
            Is.EqualTo(
                new Guid(0xe0007330, 0xf589, 0x42ed, 0xa4, 0x01, 0x5d, 0xdb, 0x10, 0xe7, 0x85, 0xd3)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_RESOURCE_PRIORITY"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_RESOURCE_PRIORITYTest()
    {
        Assert.That(
            GUID_PROCESSOR_RESOURCE_PRIORITY,
            Is.EqualTo(
                new Guid(0x603fe9ce, 0x8d01, 0x4b48, 0xa9, 0x68, 0x1d, 0x70, 0x6c, 0x28, 0xfd, 0x5c)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_RESOURCE_PRIORITY_1"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_RESOURCE_PRIORITY_1Test()
    {
        Assert.That(
            GUID_PROCESSOR_RESOURCE_PRIORITY_1,
            Is.EqualTo(
                new Guid(0x603fe9ce, 0x8d01, 0x4b48, 0xa9, 0x68, 0x1d, 0x70, 0x6c, 0x28, 0xfd, 0x5d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_HETEROGENEOUS_POLICY"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_HETEROGENEOUS_POLICYTest()
    {
        Assert.That(
            GUID_PROCESSOR_HETEROGENEOUS_POLICY,
            Is.EqualTo(
                new Guid(0x7f2f5cfa, 0xf10c, 0x4823, 0xb5, 0xe1, 0xe9, 0x3a, 0xe8, 0x5f, 0x46, 0xb5)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_HETERO_DECREASE_TIME"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_HETERO_DECREASE_TIMETest()
    {
        Assert.That(
            GUID_PROCESSOR_HETERO_DECREASE_TIME,
            Is.EqualTo(
                new Guid(0x7f2492b6, 0x60b1, 0x45e5, 0xae, 0x55, 0x77, 0x3f, 0x8c, 0xd5, 0xca, 0xec)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_HETERO_INCREASE_TIME"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_HETERO_INCREASE_TIMETest()
    {
        Assert.That(
            GUID_PROCESSOR_HETERO_INCREASE_TIME,
            Is.EqualTo(
                new Guid(0x4009efa7, 0xe72d, 0x4cba, 0x9e, 0xdf, 0x91, 0x08, 0x4e, 0xa8, 0xcb, 0xc3)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_HETERO_CONTAINMENT_DECREASE_TIME"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_HETERO_CONTAINMENT_DECREASE_TIMETest()
    {
        Assert.That(
            GUID_PROCESSOR_HETERO_CONTAINMENT_DECREASE_TIME,
            Is.EqualTo(
                new Guid(0x6FF13AEB, 0x7897, 0x4356, 0x99, 0x99, 0xDD, 0x99, 0x30, 0xAF, 0x06, 0x5F)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_HETERO_CONTAINMENT_INCREASE_TIME"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_HETERO_CONTAINMENT_INCREASE_TIMETest()
    {
        Assert.That(
            GUID_PROCESSOR_HETERO_CONTAINMENT_INCREASE_TIME,
            Is.EqualTo(
                new Guid(0x64FCEE6B, 0x5B1F, 0x45A4, 0xA7, 0x6A, 0x19, 0xB2, 0xC3, 0x6E, 0xE2, 0x90)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_HETERO_CONTAINMENT_EFFICIENCY_THRESHOLD"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_HETERO_CONTAINMENT_EFFICIENCY_THRESHOLDTest()
    {
        Assert.That(
            GUID_PROCESSOR_HETERO_CONTAINMENT_EFFICIENCY_THRESHOLD,
            Is.EqualTo(
                new Guid(0x69439b22, 0x221b, 0x4830, 0xbd, 0x34, 0xf7, 0xbc, 0xec, 0xe2, 0x45, 0x83)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_HETERO_CONTAINMENT_HYBRID_THRESHOLD"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_HETERO_CONTAINMENT_HYBRID_THRESHOLDTest()
    {
        Assert.That(
            GUID_PROCESSOR_HETERO_CONTAINMENT_HYBRID_THRESHOLD,
            Is.EqualTo(
                new Guid(0x6788488b, 0x1b90, 0x4d11, 0x8f, 0xa7, 0x97, 0x3e, 0x47, 0xd, 0xff, 0x47)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_HETERO_CONTAINMENT_POLICY"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_HETERO_CONTAINMENT_POLICYTest()
    {
        Assert.That(
            GUID_PROCESSOR_HETERO_CONTAINMENT_POLICY,
            Is.EqualTo(
                new Guid(0x60fbe21b, 0xefd9, 0x49f2, 0xb0, 0x66, 0x86, 0x74, 0xd8, 0xe9, 0xf4, 0x23)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_HETERO_DECREASE_THRESHOLD"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_HETERO_DECREASE_THRESHOLDTest()
    {
        Assert.That(
            GUID_PROCESSOR_HETERO_DECREASE_THRESHOLD,
            Is.EqualTo(
                new Guid(0xf8861c27, 0x95e7, 0x475c, 0x86, 0x5b, 0x13, 0xc0, 0xcb, 0x3f, 0x9d, 0x6b)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_HETERO_DECREASE_THRESHOLD_1"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_HETERO_DECREASE_THRESHOLD_1Test()
    {
        Assert.That(
            GUID_PROCESSOR_HETERO_DECREASE_THRESHOLD_1,
            Is.EqualTo(
                new Guid(0xf8861c27, 0x95e7, 0x475c, 0x86, 0x5b, 0x13, 0xc0, 0xcb, 0x3f, 0x9d, 0x6c)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_HETERO_INCREASE_THRESHOLD"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_HETERO_INCREASE_THRESHOLDTest()
    {
        Assert.That(
            GUID_PROCESSOR_HETERO_INCREASE_THRESHOLD,
            Is.EqualTo(
                new Guid(0xb000397d, 0x9b0b, 0x483d, 0x98, 0xc9, 0x69, 0x2a, 0x60, 0x60, 0xcf, 0xbf)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_HETERO_INCREASE_THRESHOLD_1"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_HETERO_INCREASE_THRESHOLD_1Test()
    {
        Assert.That(
            GUID_PROCESSOR_HETERO_INCREASE_THRESHOLD_1,
            Is.EqualTo(
                new Guid(0xb000397d, 0x9b0b, 0x483d, 0x98, 0xc9, 0x69, 0x2a, 0x60, 0x60, 0xcf, 0xc0)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_CLASS0_FLOOR_PERF"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_CLASS0_FLOOR_PERFTest()
    {
        Assert.That(
            GUID_PROCESSOR_CLASS0_FLOOR_PERF,
            Is.EqualTo(
                new Guid(0xfddc842b, 0x8364, 0x4edc, 0x94, 0xcf, 0xc1, 0x7f, 0x60, 0xde, 0x1c, 0x80)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_CLASS1_INITIAL_PERF"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_CLASS1_INITIAL_PERFTest()
    {
        Assert.That(
            GUID_PROCESSOR_CLASS1_INITIAL_PERF,
            Is.EqualTo(
                new Guid(0x1facfc65, 0xa930, 0x4bc5, 0x9f, 0x38, 0x50, 0x4e, 0xc0, 0x97, 0xbb, 0xc0)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_THREAD_SCHEDULING_POLICY"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_THREAD_SCHEDULING_POLICYTest()
    {
        Assert.That(
            GUID_PROCESSOR_THREAD_SCHEDULING_POLICY,
            Is.EqualTo(
                new Guid(0x93b8b6dc, 0x698, 0x4d1c, 0x9e, 0xe4, 0x6, 0x44, 0xe9, 0x0, 0xc8, 0x5d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_SHORT_THREAD_SCHEDULING_POLICY"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_SHORT_THREAD_SCHEDULING_POLICYTest()
    {
        Assert.That(
            GUID_PROCESSOR_SHORT_THREAD_SCHEDULING_POLICY,
            Is.EqualTo(
                new Guid(0xbae08b81, 0x2d5e, 0x4688, 0xad, 0x6a, 0x13, 0x24, 0x33, 0x56, 0x65, 0x4b)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_SHORT_THREAD_RUNTIME_THRESHOLD"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_SHORT_THREAD_RUNTIME_THRESHOLDTest()
    {
        Assert.That(
            GUID_PROCESSOR_SHORT_THREAD_RUNTIME_THRESHOLD,
            Is.EqualTo(
                new Guid(0xd92998c2, 0x6a48, 0x49ca, 0x85, 0xd4, 0x8c, 0xce, 0xec, 0x29, 0x45, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_SHORT_THREAD_ARCH_CLASS_UPPER_THRESHOLD"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_SHORT_THREAD_ARCH_CLASS_UPPER_THRESHOLDTest()
    {
        Assert.That(
            GUID_PROCESSOR_SHORT_THREAD_ARCH_CLASS_UPPER_THRESHOLD,
            Is.EqualTo(
                new Guid(0x828423eb, 0x8662, 0x4344, 0x90, 0xf7, 0x52, 0xbf, 0x15, 0x87, 0x0f, 0x5a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_SHORT_THREAD_ARCH_CLASS_LOWER_THRESHOLD"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_SHORT_THREAD_ARCH_CLASS_LOWER_THRESHOLDTest()
    {
        Assert.That(
            GUID_PROCESSOR_SHORT_THREAD_ARCH_CLASS_LOWER_THRESHOLD,
            Is.EqualTo(
                new Guid(0x53824d46, 0x87bd, 0x4739, 0xaa, 0x1b, 0xaa, 0x79, 0x3f, 0xac, 0x36, 0xd6)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_LONG_THREAD_ARCH_CLASS_UPPER_THRESHOLD"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_LONG_THREAD_ARCH_CLASS_UPPER_THRESHOLDTest()
    {
        Assert.That(
            GUID_PROCESSOR_LONG_THREAD_ARCH_CLASS_UPPER_THRESHOLD,
            Is.EqualTo(
                new Guid(0xbf903d33, 0x9d24, 0x49d3, 0xa4, 0x68, 0xe6, 0x5e, 0x03, 0x25, 0x04, 0x6a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_LONG_THREAD_ARCH_CLASS_LOWER_THRESHOLD"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_LONG_THREAD_ARCH_CLASS_LOWER_THRESHOLDTest()
    {
        Assert.That(
            GUID_PROCESSOR_LONG_THREAD_ARCH_CLASS_LOWER_THRESHOLD,
            Is.EqualTo(
                new Guid(0x43f278bc, 0x0f8a, 0x46d0, 0x8b, 0x31, 0x9a, 0x23, 0xe6, 0x15, 0xd7, 0x13)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_SYSTEM_COOLING_POLICY"/> property is correct.</summary>

    [Test]
    public static void GUID_SYSTEM_COOLING_POLICYTest()
    {
        Assert.That(
            GUID_SYSTEM_COOLING_POLICY,
            Is.EqualTo(
                new Guid(0x94D3A615, 0xA899, 0x4AC5, 0xAE, 0x2B, 0xE4, 0xD8, 0xF6, 0x34, 0x36, 0x7F)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_RESPONSIVENESS_DISABLE_THRESHOLD"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_RESPONSIVENESS_DISABLE_THRESHOLDTest()
    {
        Assert.That(
            GUID_PROCESSOR_RESPONSIVENESS_DISABLE_THRESHOLD,
            Is.EqualTo(
                new Guid(0x38b8383d, 0xcce0, 0x4c79, 0x9e, 0x3e, 0x56, 0xa4, 0xf1, 0x7c, 0xc4, 0x80)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_RESPONSIVENESS_DISABLE_THRESHOLD_1"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_RESPONSIVENESS_DISABLE_THRESHOLD_1Test()
    {
        Assert.That(
            GUID_PROCESSOR_RESPONSIVENESS_DISABLE_THRESHOLD_1,
            Is.EqualTo(
                new Guid(0x38b8383d, 0xcce0, 0x4c79, 0x9e, 0x3e, 0x56, 0xa4, 0xf1, 0x7c, 0xc4, 0x81)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_RESPONSIVENESS_ENABLE_THRESHOLD"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_RESPONSIVENESS_ENABLE_THRESHOLDTest()
    {
        Assert.That(
            GUID_PROCESSOR_RESPONSIVENESS_ENABLE_THRESHOLD,
            Is.EqualTo(
                new Guid(0x3d44e256, 0x7222, 0x4415, 0xa9, 0xed, 0x9c, 0x45, 0xfa, 0x3d, 0xd8, 0x30)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_RESPONSIVENESS_ENABLE_THRESHOLD_1"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_RESPONSIVENESS_ENABLE_THRESHOLD_1Test()
    {
        Assert.That(
            GUID_PROCESSOR_RESPONSIVENESS_ENABLE_THRESHOLD_1,
            Is.EqualTo(
                new Guid(0x3d44e256, 0x7222, 0x4415, 0xa9, 0xed, 0x9c, 0x45, 0xfa, 0x3d, 0xd8, 0x31)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_RESPONSIVENESS_DISABLE_TIME"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_RESPONSIVENESS_DISABLE_TIMETest()
    {
        Assert.That(
            GUID_PROCESSOR_RESPONSIVENESS_DISABLE_TIME,
            Is.EqualTo(
                new Guid(0xf565999f, 0x3fb0, 0x411a, 0xa2, 0x26, 0x3f, 0x1, 0x98, 0xde, 0xc1, 0x30)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_RESPONSIVENESS_DISABLE_TIME_1"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_RESPONSIVENESS_DISABLE_TIME_1Test()
    {
        Assert.That(
            GUID_PROCESSOR_RESPONSIVENESS_DISABLE_TIME_1,
            Is.EqualTo(
                new Guid(0xf565999f, 0x3fb0, 0x411a, 0xa2, 0x26, 0x3f, 0x1, 0x98, 0xde, 0xc1, 0x31)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_RESPONSIVENESS_ENABLE_TIME"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_RESPONSIVENESS_ENABLE_TIMETest()
    {
        Assert.That(
            GUID_PROCESSOR_RESPONSIVENESS_ENABLE_TIME,
            Is.EqualTo(
                new Guid(0x3d915188, 0x7830, 0x49ae, 0xa7, 0x9a, 0xf, 0xb0, 0xa1, 0xe5, 0xa2, 0x0)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_RESPONSIVENESS_ENABLE_TIME_1"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_RESPONSIVENESS_ENABLE_TIME_1Test()
    {
        Assert.That(
            GUID_PROCESSOR_RESPONSIVENESS_ENABLE_TIME_1,
            Is.EqualTo(
                new Guid(0x3d915188, 0x7830, 0x49ae, 0xa7, 0x9a, 0xf, 0xb0, 0xa1, 0xe5, 0xa2, 0x1)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_RESPONSIVENESS_EPP_CEILING"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_RESPONSIVENESS_EPP_CEILINGTest()
    {
        Assert.That(
            GUID_PROCESSOR_RESPONSIVENESS_EPP_CEILING,
            Is.EqualTo(
                new Guid(0x4427c73b, 0x9756, 0x4a5c, 0xb8, 0x4b, 0xc7, 0xbd, 0xa7, 0x9c, 0x73, 0x20)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_RESPONSIVENESS_EPP_CEILING_1"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_RESPONSIVENESS_EPP_CEILING_1Test()
    {
        Assert.That(
            GUID_PROCESSOR_RESPONSIVENESS_EPP_CEILING_1,
            Is.EqualTo(
                new Guid(0x4427c73b, 0x9756, 0x4a5c, 0xb8, 0x4b, 0xc7, 0xbd, 0xa7, 0x9c, 0x73, 0x21)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_RESPONSIVENESS_PERF_FLOOR"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_RESPONSIVENESS_PERF_FLOORTest()
    {
        Assert.That(
            GUID_PROCESSOR_RESPONSIVENESS_PERF_FLOOR,
            Is.EqualTo(
                new Guid(0xce8e92ee, 0x6a86, 0x4572, 0xbf, 0xe0, 0x20, 0xc2, 0x1d, 0x3, 0xcd, 0x40)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PROCESSOR_RESPONSIVENESS_PERF_FLOOR_1"/> property is correct.</summary>

    [Test]
    public static void GUID_PROCESSOR_RESPONSIVENESS_PERF_FLOOR_1Test()
    {
        Assert.That(
            GUID_PROCESSOR_RESPONSIVENESS_PERF_FLOOR_1,
            Is.EqualTo(
                new Guid(0xce8e92ee, 0x6a86, 0x4572, 0xbf, 0xe0, 0x20, 0xc2, 0x1d, 0x3, 0xcd, 0x41)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_LOCK_CONSOLE_ON_WAKE"/> property is correct.</summary>

    [Test]
    public static void GUID_LOCK_CONSOLE_ON_WAKETest()
    {
        Assert.That(
            GUID_LOCK_CONSOLE_ON_WAKE,
            Is.EqualTo(
                new Guid(0x0E796BDB, 0x100D, 0x47D6, 0xA2, 0xD5, 0xF7, 0xD2, 0xDA, 0xA5, 0x1F, 0x51)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_DEVICE_IDLE_POLICY"/> property is correct.</summary>

    [Test]
    public static void GUID_DEVICE_IDLE_POLICYTest()
    {
        Assert.That(
            GUID_DEVICE_IDLE_POLICY,
            Is.EqualTo(
                new Guid(0x4faab71a, 0x92e5, 0x4726, 0xb5, 0x31, 0x22, 0x45, 0x59, 0x67, 0x2d, 0x19)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_CONNECTIVITY_IN_STANDBY"/> property is correct.</summary>

    [Test]
    public static void GUID_CONNECTIVITY_IN_STANDBYTest()
    {
        Assert.That(
            GUID_CONNECTIVITY_IN_STANDBY,
            Is.EqualTo(
                new Guid(0xF15576E8, 0x98B7, 0x4186, 0xB9, 0x44, 0xEA, 0xFA, 0x66, 0x44, 0x02, 0xD9)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_DISCONNECTED_STANDBY_MODE"/> property is correct.</summary>

    [Test]
    public static void GUID_DISCONNECTED_STANDBY_MODETest()
    {
        Assert.That(
            GUID_DISCONNECTED_STANDBY_MODE,
            Is.EqualTo(
                new Guid(0x68AFB2D9, 0xEE95, 0x47A8, 0x8F, 0x50, 0x41, 0x15, 0x08, 0x80, 0x73, 0xB1)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_ACDC_POWER_SOURCE"/> property is correct.</summary>

    [Test]
    public static void GUID_ACDC_POWER_SOURCETest()
    {
        Assert.That(
            GUID_ACDC_POWER_SOURCE,
            Is.EqualTo(
                new Guid(0x5D3E9A59, 0xE9D5, 0x4B00, 0xA6, 0xBD, 0xFF, 0x34, 0xFF, 0x51, 0x65, 0x48)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_LIDSWITCH_STATE_CHANGE"/> property is correct.</summary>

    [Test]
    public static void GUID_LIDSWITCH_STATE_CHANGETest()
    {
        Assert.That(
            GUID_LIDSWITCH_STATE_CHANGE,
            Is.EqualTo(
                new Guid(0xBA3E0F4D, 0xB817, 0x4094, 0xA2, 0xD1, 0xD5, 0x63, 0x79, 0xE6, 0xA0, 0xF3)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_LIDSWITCH_STATE_RELIABILITY"/> property is correct.</summary>

    [Test]
    public static void GUID_LIDSWITCH_STATE_RELIABILITYTest()
    {
        Assert.That(
            GUID_LIDSWITCH_STATE_RELIABILITY,
            Is.EqualTo(
                new Guid(0xAE4C4FF1, 0xD361, 0x43F4, 0x80, 0xAA, 0xBB, 0xB6, 0xEB, 0x03, 0xDE, 0x94)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_BATTERY_PERCENTAGE_REMAINING"/> property is correct.</summary>

    [Test]
    public static void GUID_BATTERY_PERCENTAGE_REMAININGTest()
    {
        Assert.That(
            GUID_BATTERY_PERCENTAGE_REMAINING,
            Is.EqualTo(
                new Guid(0xA7AD8041, 0xB45A, 0x4CAE, 0x87, 0xA3, 0xEE, 0xCB, 0xB4, 0x68, 0xA9, 0xE1)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_BATTERY_COUNT"/> property is correct.</summary>

    [Test]
    public static void GUID_BATTERY_COUNTTest()
    {
        Assert.That(
            GUID_BATTERY_COUNT,
            Is.EqualTo(
                new Guid(0x7d263f15, 0xfca4, 0x49e5, 0x85, 0x4b, 0xa9, 0xf2, 0xbf, 0xbd, 0x5c, 0x24)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_GLOBAL_USER_PRESENCE"/> property is correct.</summary>

    [Test]
    public static void GUID_GLOBAL_USER_PRESENCETest()
    {
        Assert.That(
            GUID_GLOBAL_USER_PRESENCE,
            Is.EqualTo(
                new Guid(0x786e8a1d, 0xb427, 0x4344, 0x92, 0x7, 0x9, 0xe7, 0xb, 0xdc, 0xbe, 0xa9)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_SESSION_DISPLAY_STATUS"/> property is correct.</summary>

    [Test]
    public static void GUID_SESSION_DISPLAY_STATUSTest()
    {
        Assert.That(
            GUID_SESSION_DISPLAY_STATUS,
            Is.EqualTo(
                new Guid(0x2b84c20e, 0xad23, 0x4ddf, 0x93, 0xdb, 0x5, 0xff, 0xbd, 0x7e, 0xfc, 0xa5)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_SESSION_USER_PRESENCE"/> property is correct.</summary>

    [Test]
    public static void GUID_SESSION_USER_PRESENCETest()
    {
        Assert.That(
            GUID_SESSION_USER_PRESENCE,
            Is.EqualTo(
                new Guid(0x3c0f4548, 0xc03f, 0x4c4d, 0xb9, 0xf2, 0x23, 0x7e, 0xde, 0x68, 0x63, 0x76)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_IDLE_BACKGROUND_TASK"/> property is correct.</summary>

    [Test]
    public static void GUID_IDLE_BACKGROUND_TASKTest()
    {
        Assert.That(
            GUID_IDLE_BACKGROUND_TASK,
            Is.EqualTo(
                new Guid(0x515C31D8, 0xF734, 0x163D, 0xA0, 0xFD, 0x11, 0xA0, 0x8C, 0x91, 0xE8, 0xF1)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_BACKGROUND_TASK_NOTIFICATION"/> property is correct.</summary>

    [Test]
    public static void GUID_BACKGROUND_TASK_NOTIFICATIONTest()
    {
        Assert.That(
            GUID_BACKGROUND_TASK_NOTIFICATION,
            Is.EqualTo(
                new Guid(0xCF23F240, 0x2A54, 0x48D8, 0xB1, 0x14, 0xDE, 0x15, 0x18, 0xFF, 0x05, 0x2E)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_APPLAUNCH_BUTTON"/> property is correct.</summary>

    [Test]
    public static void GUID_APPLAUNCH_BUTTONTest()
    {
        Assert.That(
            GUID_APPLAUNCH_BUTTON,
            Is.EqualTo(
                new Guid(0x1A689231, 0x7399, 0x4E9A, 0x8F, 0x99, 0xB7, 0x1F, 0x99, 0x9D, 0xB3, 0xFA)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PCIEXPRESS_SETTINGS_SUBGROUP"/> property is correct.</summary>

    [Test]
    public static void GUID_PCIEXPRESS_SETTINGS_SUBGROUPTest()
    {
        Assert.That(
            GUID_PCIEXPRESS_SETTINGS_SUBGROUP,
            Is.EqualTo(
                new Guid(0x501a4d13, 0x42af, 0x4429, 0x9f, 0xd1, 0xa8, 0x21, 0x8c, 0x26, 0x8e, 0x20)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_PCIEXPRESS_ASPM_POLICY"/> property is correct.</summary>

    [Test]
    public static void GUID_PCIEXPRESS_ASPM_POLICYTest()
    {
        Assert.That(
            GUID_PCIEXPRESS_ASPM_POLICY,
            Is.EqualTo(
                new Guid(0xee12f906, 0xd277, 0x404b, 0xb6, 0xda, 0xe5, 0xfa, 0x1a, 0x57, 0x6d, 0xf5)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_ENABLE_SWITCH_FORCED_SHUTDOWN"/> property is correct.</summary>

    [Test]
    public static void GUID_ENABLE_SWITCH_FORCED_SHUTDOWNTest()
    {
        Assert.That(
            GUID_ENABLE_SWITCH_FORCED_SHUTDOWN,
            Is.EqualTo(
                new Guid(0x833a6b62, 0xdfa4, 0x46d1, 0x82, 0xf8, 0xe0, 0x9e, 0x34, 0xd0, 0x29, 0xd6)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_INTSTEER_SUBGROUP"/> property is correct.</summary>

    [Test]
    public static void GUID_INTSTEER_SUBGROUPTest()
    {
        Assert.That(
            GUID_INTSTEER_SUBGROUP,
            Is.EqualTo(
                new Guid(0x48672f38, 0x7a9a, 0x4bb2, 0x8b, 0xf8, 0x3d, 0x85, 0xbe, 0x19, 0xde, 0x4e)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_INTSTEER_MODE"/> property is correct.</summary>

    [Test]
    public static void GUID_INTSTEER_MODETest()
    {
        Assert.That(
            GUID_INTSTEER_MODE,
            Is.EqualTo(
                new Guid(0x2bfc24f9, 0x5ea2, 0x4801, 0x82, 0x13, 0x3d, 0xba, 0xe0, 0x1a, 0xa3, 0x9d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_INTSTEER_LOAD_PER_PROC_TRIGGER"/> property is correct.</summary>

    [Test]
    public static void GUID_INTSTEER_LOAD_PER_PROC_TRIGGERTest()
    {
        Assert.That(
            GUID_INTSTEER_LOAD_PER_PROC_TRIGGER,
            Is.EqualTo(
                new Guid(0x73cde64d, 0xd720, 0x4bb2, 0xa8, 0x60, 0xc7, 0x55, 0xaf, 0xe7, 0x7e, 0xf2)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_INTSTEER_TIME_UNPARK_TRIGGER"/> property is correct.</summary>

    [Test]
    public static void GUID_INTSTEER_TIME_UNPARK_TRIGGERTest()
    {
        Assert.That(
            GUID_INTSTEER_TIME_UNPARK_TRIGGER,
            Is.EqualTo(
                new Guid(0xd6ba4903, 0x386f, 0x4c2c, 0x8a, 0xdb, 0x5c, 0x21, 0xb3, 0x32, 0x8d, 0x25)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_GRAPHICS_SUBGROUP"/> property is correct.</summary>

    [Test]
    public static void GUID_GRAPHICS_SUBGROUPTest()
    {
        Assert.That(
            GUID_GRAPHICS_SUBGROUP,
            Is.EqualTo(
                new Guid(0x5fb4938d, 0x1ee8, 0x4b0f, 0x9a, 0x3c, 0x50, 0x36, 0xb0, 0xab, 0x99, 0x5c)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_GPU_PREFERENCE_POLICY"/> property is correct.</summary>

    [Test]
    public static void GUID_GPU_PREFERENCE_POLICYTest()
    {
        Assert.That(
            GUID_GPU_PREFERENCE_POLICY,
            Is.EqualTo(
                new Guid(0xdd848b2a, 0x8a5d, 0x4451, 0x9a, 0xe2, 0x39, 0xcd, 0x41, 0x65, 0x8f, 0x6c)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MIXED_REALITY_MODE"/> property is correct.</summary>

    [Test]
    public static void GUID_MIXED_REALITY_MODETest()
    {
        Assert.That(
            GUID_MIXED_REALITY_MODE,
            Is.EqualTo(
                new Guid(0x1e626b4e, 0xcf04, 0x4f8d, 0x9c, 0xc7, 0xc9, 0x7c, 0x5b, 0xf, 0x23, 0x91)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_SPR_ACTIVE_SESSION_CHANGE"/> property is correct.</summary>

    [Test]
    public static void GUID_SPR_ACTIVE_SESSION_CHANGETest()
    {
        Assert.That(
            GUID_SPR_ACTIVE_SESSION_CHANGE,
            Is.EqualTo(
                new Guid(0xe24ce38, 0xc393, 0x4742, 0xbd, 0xb1, 0x74, 0x4f, 0x4b, 0x9e, 0xe0, 0x8e)
            )
        );
    }
}
