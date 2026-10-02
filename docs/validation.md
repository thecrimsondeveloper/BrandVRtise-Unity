# Validation

## Validation ceiling

This is a static-source documentation pass. The documentation contract uses `standard-full-documentation-v1`, pattern set `luminary-repository-documentation-patterns`, revision `3`; required headings: None. Final Markdown/path/content/diff/remote gates are verified by the maintenance pass. This file does not certify runtime behavior.

## Evidence coverage

| Dimension | Status | Scope |
| --- | --- | --- |
| Identity/history | CONFIRMED | Canonical repository/default branch, commit history, tags/releases inspected. |
| Source/configuration | CONFIRMED | Recursive untruncated tree plus owned entry paths/configuration inspected. |
| LFS/submodules | ABSENT | No .gitattributes, .gitmodules, or gitlink entries in the inspected default tree; complete media/runtime checkout not exercised. |
| Owned systems | CONFIRMED | Unity UI/pulse prototype with project variants |
| Vendor/assets | CONFIRMED | Inventory/boundaries inspected; vendor code and binary assets not exhaustively executed or decoded. |
| Runtime/device/build | UNKNOWN | No Unity import, Play Mode, player build, headset, browser execution, live API, or media playback in this static pass. |
| Deployment | UNKNOWN | No deployment executed or certified. |
| Rights/ownership/successor | UNKNOWN | Provenance and context evidence insufficient for a complete rights grant or successor claim. |

## Reproduce the documentation checks

1. Enumerate the recursive Git tree and confirm README.md, AGENTS.md, CHANGELOG.md, all seven core docs, all four .agent files, and the focused guides linked from README.
2. Check relative Markdown targets against exact case-sensitive paths; check branch evidence links against the pinned branch inventories.
3. Compare the documentation commit with its parent. Only approved Markdown paths may differ; all other blob identities must remain identical.
4. Read the default branch head and documentation blobs back from GitHub. Their Git blob identities must match the reviewed UTF-8 content.
5. Review claims against the cited scripts/configuration; distinguish declared dependencies, active code, commented design, unknown rights, and actual executed checks.

## Remaining execution gates

Validate HelloWorld and PulseObject in the intended variant; separately repair workflow path, build entry, and license logging before CI use.

Capture exact editor/browser/device versions, commands/actions, diagnostics, and outcomes during any later runtime pass. Tests found in source are not passing test results. No deployment, vendor service, model, or asset-rights certification is implied.


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
