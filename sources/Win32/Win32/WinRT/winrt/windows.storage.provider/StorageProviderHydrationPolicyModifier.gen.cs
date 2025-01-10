// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[NativeTypeName("unsigned int")]
public enum StorageProviderHydrationPolicyModifier : uint
{
    StorageProviderHydrationPolicyModifier_None = 0,
    StorageProviderHydrationPolicyModifier_ValidationRequired = 0x1,
    StorageProviderHydrationPolicyModifier_StreamingAllowed = 0x2,
    StorageProviderHydrationPolicyModifier_AutoDehydrationAllowed = 0x4,
    StorageProviderHydrationPolicyModifier_AllowFullRestartHydration = 0x8,
}
