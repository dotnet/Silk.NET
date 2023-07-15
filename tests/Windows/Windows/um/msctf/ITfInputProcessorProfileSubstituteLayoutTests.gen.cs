// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ITfInputProcessorProfileSubstituteLayout"/> struct.</summary>
public static unsafe partial class ITfInputProcessorProfileSubstituteLayoutTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ITfInputProcessorProfileSubstituteLayout"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ITfInputProcessorProfileSubstituteLayout).GUID, Is.EqualTo(IID_ITfInputProcessorProfileSubstituteLayout));
    }

    /// <summary>Validates that the <see cref = "ITfInputProcessorProfileSubstituteLayout"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ITfInputProcessorProfileSubstituteLayout>(), Is.EqualTo(sizeof(ITfInputProcessorProfileSubstituteLayout)));
    }

    /// <summary>Validates that the <see cref = "ITfInputProcessorProfileSubstituteLayout"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ITfInputProcessorProfileSubstituteLayout).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ITfInputProcessorProfileSubstituteLayout"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ITfInputProcessorProfileSubstituteLayout), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ITfInputProcessorProfileSubstituteLayout), Is.EqualTo(4));
        }
    }
}