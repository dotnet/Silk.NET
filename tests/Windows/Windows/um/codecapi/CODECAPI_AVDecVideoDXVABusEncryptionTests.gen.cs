// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CODECAPI_AVDecVideoDXVABusEncryption"/> struct.</summary>
public static unsafe partial class CODECAPI_AVDecVideoDXVABusEncryptionTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "CODECAPI_AVDecVideoDXVABusEncryption"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(CODECAPI_AVDecVideoDXVABusEncryption).GUID, Is.EqualTo(IID_CODECAPI_AVDecVideoDXVABusEncryption));
    }

    /// <summary>Validates that the <see cref = "CODECAPI_AVDecVideoDXVABusEncryption"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CODECAPI_AVDecVideoDXVABusEncryption>(), Is.EqualTo(sizeof(CODECAPI_AVDecVideoDXVABusEncryption)));
    }

    /// <summary>Validates that the <see cref = "CODECAPI_AVDecVideoDXVABusEncryption"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CODECAPI_AVDecVideoDXVABusEncryption).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CODECAPI_AVDecVideoDXVABusEncryption"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(CODECAPI_AVDecVideoDXVABusEncryption), Is.EqualTo(1));
    }
}