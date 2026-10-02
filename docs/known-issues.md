# Known issues and unknowns

### MNT-095-F01

Confirmed scene difference: current build enables SampleScene while old build enables HelloWorld.

Action: Recommended later: verify the affected configuration/behavior before rehabilitation or claims of support.

### MNT-095-F02

Confirmed workflow exposure: decoded license content is printed to logs.

Action: Required before credential/service use; remediation is outside this documentation pass.

### MNT-095-F03

Confirmed workflow mismatch: projectPath points to repository root, not a nested Unity root.

Action: Recommended later: verify the affected configuration/behavior before rehabilitation or claims of support.

### MNT-095-F04

Unverified: workflow build invocation, activation, successful player output, ads/service integration, and data import.

Action: Recommended later: verify the affected configuration/behavior before rehabilitation or claims of support.

## Ownership and continuation

Repository maintenance is authorized for this documentation pass. Original product/client ownership, complete asset rights, and any canonical successor remain unverified unless specifically evidenced in [provenance](provenance.md) or [history](project-history.md). These unknowns do not grant permission for publication or reconstruction.

Next bounded action: Validate HelloWorld and PulseObject in the intended variant; separately repair workflow path, build entry, and license logging before CI use.

## Source evidence

- [BrandVRtise/Packages/manifest.json](https://github.com/thecrimsondeveloper/BrandVRtise-Unity/blob/78959fcf0d063633a2ecb4651bd8a948fcba98a9/BrandVRtise/Packages/manifest.json)
- [BrandVRtise/ProjectSettings/EditorBuildSettings.asset](https://github.com/thecrimsondeveloper/BrandVRtise-Unity/blob/78959fcf0d063633a2ecb4651bd8a948fcba98a9/BrandVRtise/ProjectSettings/EditorBuildSettings.asset)
- [BrandVRtise/ProjectSettings/ProjectVersion.txt](https://github.com/thecrimsondeveloper/BrandVRtise-Unity/blob/78959fcf0d063633a2ecb4651bd8a948fcba98a9/BrandVRtise/ProjectSettings/ProjectVersion.txt)
- [BrandVRtise_old/Packages/manifest.json](https://github.com/thecrimsondeveloper/BrandVRtise-Unity/blob/78959fcf0d063633a2ecb4651bd8a948fcba98a9/BrandVRtise_old/Packages/manifest.json)
- [BrandVRtise_old/ProjectSettings/EditorBuildSettings.asset](https://github.com/thecrimsondeveloper/BrandVRtise-Unity/blob/78959fcf0d063633a2ecb4651bd8a948fcba98a9/BrandVRtise_old/ProjectSettings/EditorBuildSettings.asset)
- [BrandVRtise_old/ProjectSettings/ProjectVersion.txt](https://github.com/thecrimsondeveloper/BrandVRtise-Unity/blob/78959fcf0d063633a2ecb4651bd8a948fcba98a9/BrandVRtise_old/ProjectSettings/ProjectVersion.txt)
- [BrandVRtise/Assets/_BrandVRtise/PulseObject.cs](https://github.com/thecrimsondeveloper/BrandVRtise-Unity/blob/78959fcf0d063633a2ecb4651bd8a948fcba98a9/BrandVRtise/Assets/_BrandVRtise/PulseObject.cs)
- [BrandVRtise_old/Assets/_BrandVRtise/PulseObject.cs](https://github.com/thecrimsondeveloper/BrandVRtise-Unity/blob/78959fcf0d063633a2ecb4651bd8a948fcba98a9/BrandVRtise_old/Assets/_BrandVRtise/PulseObject.cs)
- [BrandVRtise/Assets/_BrandVRtise/HelloWorld.unity](https://github.com/thecrimsondeveloper/BrandVRtise-Unity/blob/78959fcf0d063633a2ecb4651bd8a948fcba98a9/BrandVRtise/Assets/_BrandVRtise/HelloWorld.unity)
- [BrandVRtise_old/Assets/_BrandVRtise/HelloWorld.unity](https://github.com/thecrimsondeveloper/BrandVRtise-Unity/blob/78959fcf0d063633a2ecb4651bd8a948fcba98a9/BrandVRtise_old/Assets/_BrandVRtise/HelloWorld.unity)
- [.github/workflows/windows-build.yml](https://github.com/thecrimsondeveloper/BrandVRtise-Unity/blob/78959fcf0d063633a2ecb4651bd8a948fcba98a9/.github/workflows/windows-build.yml)
