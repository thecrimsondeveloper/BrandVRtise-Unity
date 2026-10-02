# Development

## Opening and inspection

Clone the repository through your authorized GitHub account. Select the intended branch; do not assume prototype branches share dependencies or entry scenes.

- Open `BrandVRtise/` using Unity **2023.2.3f1**.
- Open `BrandVRtise_old/` using Unity **2022.3.30f1**.

Use Unity Hub's existing-project route pointing at that nested folder, not the repository root. Inspect its `Packages/manifest.json`, package lock, `ProjectSettings/ProjectVersion.txt`, and `EditorBuildSettings.asset` before import. Package resolution may require separately authorized vendor access. Do not use credentials found in source.

Read [architecture](architecture.md) and the focused guides before choosing a scene. Open the documented scene, inspect missing scripts/references, capture compiler/import diagnostics, then test the bounded behavior. Scene objects and code are static evidence; Play Mode has not been validated here.

## Builds and contributions

No player build is certified by this documentation. Inspect enabled scenes and target configuration first; empty or sample-only scene lists require a separately authorized configuration change before a product build. Do not invent a command-line build method where none is established.

Preserve `.meta` GUIDs, vendor content, settings, serialized scene/prefab data, and package versions. Keep documentation edits separate from rehabilitation. Next action: Validate HelloWorld and PulseObject in the intended variant; separately repair workflow path, build entry, and license logging before CI use.

## Source evidence

- [BrandVRtise/ProjectSettings/EditorBuildSettings.asset](https://github.com/thecrimsondeveloper/BrandVRtise-Unity/blob/78959fcf0d063633a2ecb4651bd8a948fcba98a9/BrandVRtise/ProjectSettings/EditorBuildSettings.asset)
- [BrandVRtise/ProjectSettings/ProjectVersion.txt](https://github.com/thecrimsondeveloper/BrandVRtise-Unity/blob/78959fcf0d063633a2ecb4651bd8a948fcba98a9/BrandVRtise/ProjectSettings/ProjectVersion.txt)
- [BrandVRtise_old/ProjectSettings/EditorBuildSettings.asset](https://github.com/thecrimsondeveloper/BrandVRtise-Unity/blob/78959fcf0d063633a2ecb4651bd8a948fcba98a9/BrandVRtise_old/ProjectSettings/EditorBuildSettings.asset)
- [BrandVRtise_old/ProjectSettings/ProjectVersion.txt](https://github.com/thecrimsondeveloper/BrandVRtise-Unity/blob/78959fcf0d063633a2ecb4651bd8a948fcba98a9/BrandVRtise_old/ProjectSettings/ProjectVersion.txt)
