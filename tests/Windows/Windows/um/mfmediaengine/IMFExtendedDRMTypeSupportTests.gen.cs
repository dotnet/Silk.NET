// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMFExtendedDRMTypeSupport"/> struct.</summary>
public static unsafe partial class IMFExtendedDRMTypeSupportTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMFExtendedDRMTypeSupport"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFExtendedDRMTypeSupport).GUID, Is.EqualTo(IID_IMFExtendedDRMTypeSupport));
    }

    /// <summary>Validates that the <see cref = "IMFExtendedDRMTypeSupport"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFExtendedDRMTypeSupport>(), Is.EqualTo(sizeof(IMFExtendedDRMTypeSupport)));
    }

    /// <summary>Validates that the <see cref = "IMFExtendedDRMTypeSupport"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFExtendedDRMTypeSupport).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMFExtendedDRMTypeSupport"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFExtendedDRMTypeSupport), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFExtendedDRMTypeSupport), Is.EqualTo(4));
        }
    }
}