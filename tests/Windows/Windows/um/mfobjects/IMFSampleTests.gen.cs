// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMFSample"/> struct.</summary>
public static unsafe partial class IMFSampleTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMFSample"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFSample).GUID, Is.EqualTo(IID_IMFSample));
    }

    /// <summary>Validates that the <see cref = "IMFSample"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFSample>(), Is.EqualTo(sizeof(IMFSample)));
    }

    /// <summary>Validates that the <see cref = "IMFSample"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFSample).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMFSample"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFSample), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFSample), Is.EqualTo(4));
        }
    }
}