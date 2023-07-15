// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WindowsStorageCOM.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "IUnbufferedFileHandleOplockCallback"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class IUnbufferedFileHandleOplockCallbackTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IUnbufferedFileHandleOplockCallback"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IUnbufferedFileHandleOplockCallback).GUID, Is.EqualTo(IID_IUnbufferedFileHandleOplockCallback));
    }

    /// <summary>Validates that the <see cref = "IUnbufferedFileHandleOplockCallback"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IUnbufferedFileHandleOplockCallback>(), Is.EqualTo(sizeof(IUnbufferedFileHandleOplockCallback)));
    }

    /// <summary>Validates that the <see cref = "IUnbufferedFileHandleOplockCallback"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IUnbufferedFileHandleOplockCallback).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IUnbufferedFileHandleOplockCallback"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IUnbufferedFileHandleOplockCallback), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IUnbufferedFileHandleOplockCallback), Is.EqualTo(4));
        }
    }
}