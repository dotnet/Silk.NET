// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMFVideoSampleAllocator"/> struct.</summary>
public static unsafe partial class IMFVideoSampleAllocatorTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMFVideoSampleAllocator"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFVideoSampleAllocator).GUID, Is.EqualTo(IID_IMFVideoSampleAllocator));
    }

    /// <summary>Validates that the <see cref = "IMFVideoSampleAllocator"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFVideoSampleAllocator>(), Is.EqualTo(sizeof(IMFVideoSampleAllocator)));
    }

    /// <summary>Validates that the <see cref = "IMFVideoSampleAllocator"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFVideoSampleAllocator).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMFVideoSampleAllocator"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFVideoSampleAllocator), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFVideoSampleAllocator), Is.EqualTo(4));
        }
    }
}