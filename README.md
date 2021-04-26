TDDBC Sendai X Online のお題をC#でやってみた
=====

[![Build status](https://ci.appveyor.com/api/projects/status/wq5xvs1k98k4n204?svg=true)](https://ci.appveyor.com/project/masaru-b-cl/tddbcsendaixbycsharp)

[TDDBC Sendai X - connpass](https://tddbc.connpass.com/event/203954/)のお題[いちごの格付け](https://gist.github.com/135yshr/3a894104e63074ae307e6c26867a6e54)をC#でやってみたリポジトリです。

## ディレクトリ構成

```
├── IchigoRankCalculator            作成したコード
│   ├── IchigoRankCalculator            クラスライブラリプロジェクト
│   └── IchigoRankCalculator.Test       テストプロジェクト
├── TODO                            TODOリスト
│   └── exercises1.md                   課題1のTODO
├── README.md                       このファイル
└── appveyor.yml                    AppVeyor構成ファイル
```

## 必要要件

- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)

## クイックスタート

```sh
cd (any_work_dir)
git clone https://github.com/masaru-b-cl/TddbcSendaiXByCSharp.git
cd TddbcSendaiXByCSharp
dotnet test IchigoRankCalculator/IchigoRankCalculator.sln
```
