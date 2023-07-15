// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMFQualityManager"/> struct.</summary>
public static unsafe partial class IMFQualityManagerTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMFQualityManager"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFQualityManager).GUID, Is.EqualTo(IID_IMFQualityManager));
    }

    /// <summary>Validates that the <see cref = "IMFQualityManager"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFQualityManager>(), Is.EqualTo(sizeof(IMFQualityManager)));
    }

    /// <summary>Validates that the <see cref = "IMFQualityManager"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFQualityManager).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMFQualityManager"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFQualityManager), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFQualityManager), Is.EqualTo(4));
        }
    }
}