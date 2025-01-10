// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IMFSaveJob"/> struct.</summary>
public static unsafe partial class IMFSaveJobTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMFSaveJob"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFSaveJob).GUID, Is.EqualTo(IID_IMFSaveJob));
    }

    /// <summary>Validates that the <see cref = "IMFSaveJob"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFSaveJob>(), Is.EqualTo(sizeof(IMFSaveJob)));
    }

    /// <summary>Validates that the <see cref = "IMFSaveJob"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFSaveJob).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMFSaveJob"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFSaveJob), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFSaveJob), Is.EqualTo(4));
        }
    }
}
