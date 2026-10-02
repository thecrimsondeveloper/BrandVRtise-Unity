# Build Automation

## Existing workflow

`.github/workflows/windows-build.yml` expresses a Windows Unity build attempt using 2023.2.3f1. Its project path points at the repository root even though Unity projects are nested. Custom build-target/output switches are present without an established executeMethod implementation. A successful build was not observed.

The workflow decodes license material and prints it to logs. Do not reproduce its secret values in docs or run it for exploratory validation. A separately authorized workflow repair should remove content logging, assess historical log exposure, select the correct nested project, use a supported build entry, and verify activation/output handling. Documentation does not repair the workflow or rotate licenses.

CI and deployment remain unvalidated; package presence and a workflow file do not prove either.

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
