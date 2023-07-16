// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMFSensorProfileCollection"/> struct.</summary>
[SupportedOSPlatform("windows10.0.17134.0")]
public static unsafe partial class IMFSensorProfileCollectionTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMFSensorProfileCollection"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFSensorProfileCollection).GUID, Is.EqualTo(IID_IMFSensorProfileCollection));
    }

    /// <summary>Validates that the <see cref = "IMFSensorProfileCollection"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFSensorProfileCollection>(), Is.EqualTo(sizeof(IMFSensorProfileCollection)));
    }

    /// <summary>Validates that the <see cref = "IMFSensorProfileCollection"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFSensorProfileCollection).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMFSensorProfileCollection"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFSensorProfileCollection), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFSensorProfileCollection), Is.EqualTo(4));
        }
    }
}