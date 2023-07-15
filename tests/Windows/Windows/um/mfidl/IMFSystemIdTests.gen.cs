// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMFSystemId"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class IMFSystemIdTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMFSystemId"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFSystemId).GUID, Is.EqualTo(IID_IMFSystemId));
    }

    /// <summary>Validates that the <see cref = "IMFSystemId"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFSystemId>(), Is.EqualTo(sizeof(IMFSystemId)));
    }

    /// <summary>Validates that the <see cref = "IMFSystemId"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFSystemId).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMFSystemId"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFSystemId), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFSystemId), Is.EqualTo(4));
        }
    }
}