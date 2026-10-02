# Project Variants

## Variant comparison

| Root | Editor | URP | Enabled scene |
| --- | --- | --- | --- |
| `BrandVRtise/` | 2023.2.3f1 | 16.0.5 | SampleScene |
| `BrandVRtise_old/` | 2022.3.30f1 | 14.0.11 | HelloWorld |

Both contain HelloWorld and the pulse script. The newer manifest declares Ads 4.4.2, Analytics 3.8.1, and Purchasing 4.10.0; source integration was not established. The `builds` branch is an alternate baseline, not proof of a release artifact. Choose a variant before editor import and inspect its own settings.

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
