# Batch Subtitle Sync

파이썬으로 작성한 [기존 프로젝트](https://github.com/Ariette/Batch-SAMI-Sync)를 C#으로 다시 쓴 프로젝트입니다.
ASS, SSA, SRT 자막 형식을 추가로 지원하며, 자막 저장 인코딩을 ANSI(cp949)로 저장할 수 있습니다.

## 특징
+ 자막 인코딩 자동 감지
+ 드래그 앤 드랍 지원
+ 싱크 꼬임 방지

<img alt="screenshot" src="https://github.com/Ariette/Batch-SAMI-Sync/raw/master/assets/screenshot.png" />

### 옵션 설명
+ 검색 텍스트 : 해당 텍스트를 **포함하는** 가장 첫번째 줄을 찾습니다. 공백 여부와 대소문자를 구분하며, 검색된 줄을 포함해 그 이후 모든 줄의 싱크를 스폰서 영상 길이만큼 당깁니다.
+ 스폰서 영상 길이(기본값 10) : 해당 시간만큼 자막 싱크를 **빠르게** 합니다. NS → S 변환시 음수로 입력하세요. (단위 : 초)
+ 라인 오프셋(기본값 2) : 검색된 줄을 기준으로 오프셋을 설정합니다. (ex. 3번째 줄이 검색되었고 라인 오프셋이 2라면 5번째 줄부터 싱크 수정.)
+ 시작부터 n줄 무시(기본값 5): n번째 이후 줄부터 검색을 시작합니다.
+ 시작부터 n초 무시(기본값 90) : n초 이후 자막부터 검색을 시작합니다.
+ 싱크 꼬임 무시(기본값 Off) : 싱크 꼬임을 무시하고 모든 자막을 보존합니다.

## License
+ [UTF Unknown](https://github.com/CharsetDetector/UTF-unknown) © Julian Verdurmen - MPL v1.1
+ [Material Icons](https://github.com/google/material-design-icons) © Google - Apache License v2.0, Modified by Ariette(see "Resources" folder)