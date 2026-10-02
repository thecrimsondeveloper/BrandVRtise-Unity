# Architecture

Both project variants contain `_BrandVRtise/HelloWorld.unity` with Canvas/TMP/button content and `PulseObject.cs`. Pulse starts a scale animation using a curve, duration (default 0.5), and pulse scale (default 1.2), then restores the starting scale. Its public target field is unused in the inspected implementation.

The current project enables SampleScene; the older variant enables HelloWorld. `.github/workflows/windows-build.yml` installs Unity 2023.2.3f1, decodes a license secret, and uses repository-root projectPath despite nested projects. It prints decoded license content. No verified custom build method accompanies its custom build switches. See [build automation](build-automation.md) before invoking it.

## Preservation and reuse

Preserves a bounded UI animation example, two editor-era variants, and historical automation intent.

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
