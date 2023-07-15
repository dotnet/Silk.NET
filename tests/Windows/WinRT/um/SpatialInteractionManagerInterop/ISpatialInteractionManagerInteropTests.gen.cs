// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialInteractionManagerInterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "ISpatialInteractionManagerInterop"/> struct.</summary>
[SupportedOSPlatform("windows10.0.15063.0")]
public static unsafe partial class ISpatialInteractionManagerInteropTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ISpatialInteractionManagerInterop"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISpatialInteractionManagerInterop).GUID, Is.EqualTo(IID_ISpatialInteractionManagerInterop));
    }

    /// <summary>Validates that the <see cref = "ISpatialInteractionManagerInterop"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISpatialInteractionManagerInterop>(), Is.EqualTo(sizeof(ISpatialInteractionManagerInterop)));
    }

    /// <summary>Validates that the <see cref = "ISpatialInteractionManagerInterop"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISpatialInteractionManagerInterop).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ISpatialInteractionManagerInterop"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISpatialInteractionManagerInterop), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISpatialInteractionManagerInterop), Is.EqualTo(4));
        }
    }
}