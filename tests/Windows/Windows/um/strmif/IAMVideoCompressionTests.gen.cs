// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IAMVideoCompression"/> struct.</summary>
public static unsafe partial class IAMVideoCompressionTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IAMVideoCompression"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IAMVideoCompression).GUID, Is.EqualTo(IID_IAMVideoCompression));
    }

    /// <summary>Validates that the <see cref = "IAMVideoCompression"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IAMVideoCompression>(), Is.EqualTo(sizeof(IAMVideoCompression)));
    }

    /// <summary>Validates that the <see cref = "IAMVideoCompression"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IAMVideoCompression).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IAMVideoCompression"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IAMVideoCompression), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IAMVideoCompression), Is.EqualTo(4));
        }
    }
}