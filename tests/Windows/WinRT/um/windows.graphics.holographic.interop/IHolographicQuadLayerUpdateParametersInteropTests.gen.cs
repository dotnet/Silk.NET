// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.graphics.holographic.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "IHolographicQuadLayerUpdateParametersInterop"/> struct.</summary>
[SupportedOSPlatform("windows10.0.19041.0")]
public static unsafe partial class IHolographicQuadLayerUpdateParametersInteropTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IHolographicQuadLayerUpdateParametersInterop"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IHolographicQuadLayerUpdateParametersInterop).GUID, Is.EqualTo(IID_IHolographicQuadLayerUpdateParametersInterop));
    }

    /// <summary>Validates that the <see cref = "IHolographicQuadLayerUpdateParametersInterop"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IHolographicQuadLayerUpdateParametersInterop>(), Is.EqualTo(sizeof(IHolographicQuadLayerUpdateParametersInterop)));
    }

    /// <summary>Validates that the <see cref = "IHolographicQuadLayerUpdateParametersInterop"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IHolographicQuadLayerUpdateParametersInterop).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IHolographicQuadLayerUpdateParametersInterop"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IHolographicQuadLayerUpdateParametersInterop), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IHolographicQuadLayerUpdateParametersInterop), Is.EqualTo(4));
        }
    }
}