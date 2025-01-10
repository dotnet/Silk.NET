// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "Windows"/> class.</summary>
public static unsafe partial class WindowsTests
{
    /// <summary>Validates that the value of the <see cref = "MFENABLETYPE_WMDRMV1_LicenseAcquisition"/> property is correct.</summary>

    [Test]
    public static void MFENABLETYPE_WMDRMV1_LicenseAcquisitionTest()
    {
        Assert.That(
            MFENABLETYPE_WMDRMV1_LicenseAcquisition,
            Is.EqualTo(
                new Guid(0x4ff6eeaf, 0xb43, 0x4797, 0x9b, 0x85, 0xab, 0xf3, 0x18, 0x15, 0xe7, 0xb0)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFENABLETYPE_WMDRMV7_LicenseAcquisition"/> property is correct.</summary>

    [Test]
    public static void MFENABLETYPE_WMDRMV7_LicenseAcquisitionTest()
    {
        Assert.That(
            MFENABLETYPE_WMDRMV7_LicenseAcquisition,
            Is.EqualTo(
                new Guid(0x3306df, 0x4a06, 0x4884, 0xa0, 0x97, 0xef, 0x6d, 0x22, 0xec, 0x84, 0xa3)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFENABLETYPE_WMDRMV7_Individualization"/> property is correct.</summary>

    [Test]
    public static void MFENABLETYPE_WMDRMV7_IndividualizationTest()
    {
        Assert.That(
            MFENABLETYPE_WMDRMV7_Individualization,
            Is.EqualTo(
                new Guid(0xacd2c84a, 0xb303, 0x4f65, 0xbc, 0x2c, 0x2c, 0x84, 0x8d, 0x1, 0xa9, 0x89)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFENABLETYPE_MF_UpdateRevocationInformation"/> property is correct.</summary>

    [Test]
    public static void MFENABLETYPE_MF_UpdateRevocationInformationTest()
    {
        Assert.That(
            MFENABLETYPE_MF_UpdateRevocationInformation,
            Is.EqualTo(
                new Guid(0xe558b0b5, 0xb3c4, 0x44a0, 0x92, 0x4c, 0x50, 0xd1, 0x78, 0x93, 0x23, 0x85)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFENABLETYPE_MF_UpdateUntrustedComponent"/> property is correct.</summary>

    [Test]
    public static void MFENABLETYPE_MF_UpdateUntrustedComponentTest()
    {
        Assert.That(
            MFENABLETYPE_MF_UpdateUntrustedComponent,
            Is.EqualTo(
                new Guid(0x9879f3d6, 0xcee2, 0x48e6, 0xb5, 0x73, 0x97, 0x67, 0xab, 0x17, 0x2f, 0x16)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFENABLETYPE_MF_RebootRequired"/> property is correct.</summary>

    [Test]
    public static void MFENABLETYPE_MF_RebootRequiredTest()
    {
        Assert.That(
            MFENABLETYPE_MF_RebootRequired,
            Is.EqualTo(
                new Guid(0x6d4d3d4b, 0x0ece, 0x4652, 0x8b, 0x3a, 0xf2, 0xd2, 0x42, 0x60, 0xd8, 0x87)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MR_POLICY_VOLUME_SERVICE"/> property is correct.</summary>

    [Test]
    public static void MR_POLICY_VOLUME_SERVICETest()
    {
        Assert.That(
            MR_POLICY_VOLUME_SERVICE,
            Is.EqualTo(
                new Guid(0x1abaa2ac, 0x9d3b, 0x47c6, 0xab, 0x48, 0xc5, 0x95, 0x6, 0xde, 0x78, 0x4d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MR_CAPTURE_POLICY_VOLUME_SERVICE"/> property is correct.</summary>

    [Test]
    public static void MR_CAPTURE_POLICY_VOLUME_SERVICETest()
    {
        Assert.That(
            MR_CAPTURE_POLICY_VOLUME_SERVICE,
            Is.EqualTo(
                new Guid(0x24030acd, 0x107a, 0x4265, 0x97, 0x5c, 0x41, 0x4e, 0x33, 0xe6, 0x5f, 0x2a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MR_STREAM_VOLUME_SERVICE"/> property is correct.</summary>

    [Test]
    public static void MR_STREAM_VOLUME_SERVICETest()
    {
        Assert.That(
            MR_STREAM_VOLUME_SERVICE,
            Is.EqualTo(
                new Guid(0xf8b5fa2f, 0x32ef, 0x46f5, 0xb1, 0x72, 0x13, 0x21, 0x21, 0x2f, 0xb2, 0xc4)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MR_AUDIO_POLICY_SERVICE"/> property is correct.</summary>

    [Test]
    public static void MR_AUDIO_POLICY_SERVICETest()
    {
        Assert.That(
            MR_AUDIO_POLICY_SERVICE,
            Is.EqualTo(
                new Guid(0x911fd737, 0x6775, 0x4ab0, 0xa6, 0x14, 0x29, 0x78, 0x62, 0xfd, 0xac, 0x88)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFNET_SAVEJOB_SERVICE"/> property is correct.</summary>

    [Test]
    public static void MFNET_SAVEJOB_SERVICETest()
    {
        Assert.That(
            MFNET_SAVEJOB_SERVICE,
            Is.EqualTo(
                new Guid(0xb85a587f, 0x3d02, 0x4e52, 0x95, 0x65, 0x55, 0xd3, 0xec, 0x1e, 0x7f, 0xf7)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFPROTECTIONATTRIBUTE_BEST_EFFORT"/> property is correct.</summary>

    [Test]
    public static void MFPROTECTIONATTRIBUTE_BEST_EFFORTTest()
    {
        Assert.That(
            MFPROTECTIONATTRIBUTE_BEST_EFFORT,
            Is.EqualTo(
                new Guid(0xc8e06331, 0x75f0, 0x4ec1, 0x8e, 0x77, 0x17, 0x57, 0x8f, 0x77, 0x3b, 0x46)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFPROTECTIONATTRIBUTE_FAIL_OVER"/> property is correct.</summary>

    [Test]
    public static void MFPROTECTIONATTRIBUTE_FAIL_OVERTest()
    {
        Assert.That(
            MFPROTECTIONATTRIBUTE_FAIL_OVER,
            Is.EqualTo(
                new Guid(0x8536abc5, 0x38f1, 0x4151, 0x9c, 0xce, 0xf5, 0x5d, 0x94, 0x12, 0x29, 0xac)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFPROTECTIONATTRIBUTE_CONSTRICTVIDEO_IMAGESIZE"/> property is correct.</summary>

    [Test]
    public static void MFPROTECTIONATTRIBUTE_CONSTRICTVIDEO_IMAGESIZETest()
    {
        Assert.That(
            MFPROTECTIONATTRIBUTE_CONSTRICTVIDEO_IMAGESIZE,
            Is.EqualTo(
                new Guid(0x8476fc, 0x4b58, 0x4d80, 0xa7, 0x90, 0xe7, 0x29, 0x76, 0x73, 0x16, 0x1d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFPROTECTIONATTRIBUTE_HDCP_SRM"/> property is correct.</summary>

    [Test]
    public static void MFPROTECTIONATTRIBUTE_HDCP_SRMTest()
    {
        Assert.That(
            MFPROTECTIONATTRIBUTE_HDCP_SRM,
            Is.EqualTo(
                new Guid(0x6f302107, 0x3477, 0x4468, 0x8a, 0x8, 0xee, 0xf9, 0xdb, 0x10, 0xe2, 0xf)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_DeviceTimestamp"/> property is correct.</summary>

    [Test]
    public static void MFSampleExtension_DeviceTimestampTest()
    {
        Assert.That(
            MFSampleExtension_DeviceTimestamp,
            Is.EqualTo(
                new Guid(0x8f3e35e7, 0x2dcd, 0x4887, 0x86, 0x22, 0x2a, 0x58, 0xba, 0xa6, 0x52, 0xb0)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_Spatial_CameraViewTransform"/> property is correct.</summary>

    [Test]
    public static void MFSampleExtension_Spatial_CameraViewTransformTest()
    {
        Assert.That(
            MFSampleExtension_Spatial_CameraViewTransform,
            Is.EqualTo(
                new Guid(0x4e251fa4, 0x830f, 0x4770, 0x85, 0x9a, 0x4b, 0x8d, 0x99, 0xaa, 0x80, 0x9b)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_Spatial_CameraCoordinateSystem"/> property is correct.</summary>

    [Test]
    public static void MFSampleExtension_Spatial_CameraCoordinateSystemTest()
    {
        Assert.That(
            MFSampleExtension_Spatial_CameraCoordinateSystem,
            Is.EqualTo(
                new Guid(0x9d13c82f, 0x2199, 0x4e67, 0x91, 0xcd, 0xd1, 0xa4, 0x18, 0x1f, 0x25, 0x34)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_Spatial_CameraProjectionTransform"/> property is correct.</summary>

    [Test]
    public static void MFSampleExtension_Spatial_CameraProjectionTransformTest()
    {
        Assert.That(
            MFSampleExtension_Spatial_CameraProjectionTransform,
            Is.EqualTo(
                new Guid(0x47f9fcb5, 0x2a02, 0x4f26, 0xa4, 0x77, 0x79, 0x2f, 0xdf, 0x95, 0x88, 0x6a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFStreamExtension_ExtendedCameraIntrinsics"/> property is correct.</summary>

    [Test]
    public static void MFStreamExtension_ExtendedCameraIntrinsicsTest()
    {
        Assert.That(
            MFStreamExtension_ExtendedCameraIntrinsics,
            Is.EqualTo(
                new Guid(0xaa74b3df, 0x9a2c, 0x48d6, 0x83, 0x93, 0x5b, 0xd1, 0xc1, 0xa8, 0x1e, 0x6e)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_ExtendedCameraIntrinsics"/> property is correct.</summary>

    [Test]
    public static void MFSampleExtension_ExtendedCameraIntrinsicsTest()
    {
        Assert.That(
            MFSampleExtension_ExtendedCameraIntrinsics,
            Is.EqualTo(
                new Guid(0x560bc4a5, 0x4de0, 0x4113, 0x9c, 0xdc, 0x83, 0x2d, 0xb9, 0x74, 0xf, 0x3d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "KSPROPERTYSETID_ANYCAMERACONTROL"/> property is correct.</summary>

    [Test]
    public static void KSPROPERTYSETID_ANYCAMERACONTROLTest()
    {
        Assert.That(
            KSPROPERTYSETID_ANYCAMERACONTROL,
            Is.EqualTo(
                new Guid(0x94dd0c30, 0x28c7, 0x4efb, 0x9d, 0x6b, 0x81, 0x23, 0x0, 0xfb, 0xc, 0x7f)
            )
        );
    }
}
